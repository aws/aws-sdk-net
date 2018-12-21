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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Lightsail.Model;
using Amazon.Lightsail.Model.Internal.MarshallTransformations;
using Amazon.Lightsail.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lightsail
{
    /// <summary>
    /// Implementation for accessing Lightsail
    ///
    /// Amazon Lightsail is the easiest way to get started with AWS for developers who just
    /// need virtual private servers. Lightsail includes everything you need to launch your
    /// project quickly - a virtual machine, SSD-based storage, data transfer, DNS management,
    /// and a static IP - for a low, predictable price. You manage those Lightsail servers
    /// through the Lightsail console or by using the API or command-line interface (CLI).
    /// 
    ///  
    /// <para>
    /// For more information about Lightsail concepts and tasks, see the <a href="https://lightsail.aws.amazon.com/ls/docs/all">Lightsail
    /// Dev Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the Lightsail API or the CLI, you will need to use AWS Identity and Access
    /// Management (IAM) to generate access keys. For details about how to set this up, see
    /// the <a href="http://lightsail.aws.amazon.com/ls/docs/how-to/article/lightsail-how-to-set-up-access-keys-to-use-sdk-api-cli">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonLightsailClient : AmazonServiceClient, IAmazonLightsail
    {
        private static IServiceMetadata serviceMetadata = new AmazonLightsailMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonLightsailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLightsailConfig()) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLightsailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(AmazonLightsailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLightsailClient(AWSCredentials credentials)
            : this(credentials, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLightsailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials and an
        /// AmazonLightsailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(AWSCredentials credentials, AmazonLightsailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLightsailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLightsailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLightsailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLightsailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLightsailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLightsailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


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
        public virtual AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;

            return Invoke<AllocateStaticIpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        public virtual Task<AllocateStaticIpResponse> AllocateStaticIpAsync(AllocateStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<AllocateStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachDisk


        /// <summary>
        /// Attaches a block storage disk to a running or stopped Lightsail instance and exposes
        /// it to the instance with the specified disk name.
        /// 
        ///  
        /// <para>
        /// The <code>attach disk</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by diskName. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual AttachDiskResponse AttachDisk(AttachDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachDiskResponseUnmarshaller.Instance;

            return Invoke<AttachDiskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachDisk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachDisk">REST API Reference for AttachDisk Operation</seealso>
        public virtual Task<AttachDiskResponse> AttachDiskAsync(AttachDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachDiskResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachDiskResponse>(request, options, cancellationToken);
        }

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
        /// control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual AttachInstancesToLoadBalancerResponse AttachInstancesToLoadBalancer(AttachInstancesToLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesToLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesToLoadBalancerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstancesToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstancesToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachInstancesToLoadBalancer">REST API Reference for AttachInstancesToLoadBalancer Operation</seealso>
        public virtual Task<AttachInstancesToLoadBalancerResponse> AttachInstancesToLoadBalancerAsync(AttachInstancesToLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesToLoadBalancerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachInstancesToLoadBalancerResponse>(request, options, cancellationToken);
        }

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
        /// operation with the non-attached certificate, and it will replace the existing one
        /// and become the attached certificate.
        /// </para>
        ///  
        /// <para>
        /// The <code>attach load balancer tls certificate</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual AttachLoadBalancerTlsCertificateResponse AttachLoadBalancerTlsCertificate(AttachLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerTlsCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTlsCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachLoadBalancerTlsCertificate">REST API Reference for AttachLoadBalancerTlsCertificate Operation</seealso>
        public virtual Task<AttachLoadBalancerTlsCertificateResponse> AttachLoadBalancerTlsCertificateAsync(AttachLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTlsCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

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
        public virtual AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachStaticIpResponseUnmarshaller.Instance;

            return Invoke<AttachStaticIpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        public virtual Task<AttachStaticIpResponse> AttachStaticIpAsync(AttachStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachStaticIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CloseInstancePublicPorts


        /// <summary>
        /// Closes the public ports on a specific Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>close instance public ports</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by instanceName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<CloseInstancePublicPortsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        public virtual Task<CloseInstancePublicPortsResponse> CloseInstancePublicPortsAsync(CloseInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CloseInstancePublicPortsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// Copies an instance or disk snapshot from one AWS Region to another in Amazon Lightsail.
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
        public virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateCloudFormationStackResponse CreateCloudFormationStack(CreateCloudFormationStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationStackResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFormationStackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudFormationStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudFormationStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateCloudFormationStack">REST API Reference for CreateCloudFormationStack Operation</seealso>
        public virtual Task<CreateCloudFormationStackResponse> CreateCloudFormationStackAsync(CreateCloudFormationStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationStackResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCloudFormationStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDisk


        /// <summary>
        /// Creates a block storage disk that can be attached to a Lightsail instance in the same
        /// Availability Zone (e.g., <code>us-east-2a</code>). The disk is created in the regional
        /// endpoint that you send the HTTP request to. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/overview/article/understanding-regions-and-availability-zones-in-amazon-lightsail">Regions
        /// and Availability Zones in Lightsail</a>.
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
        public virtual CreateDiskResponse CreateDisk(CreateDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskResponseUnmarshaller.Instance;

            return Invoke<CreateDiskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDisk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDisk">REST API Reference for CreateDisk Operation</seealso>
        public virtual Task<CreateDiskResponse> CreateDiskAsync(CreateDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDiskFromSnapshot


        /// <summary>
        /// Creates a block storage disk from a disk snapshot that can be attached to a Lightsail
        /// instance in the same Availability Zone (e.g., <code>us-east-2a</code>). The disk is
        /// created in the regional endpoint that you send the HTTP request to. For more information,
        /// see <a href="https://lightsail.aws.amazon.com/ls/docs/overview/article/understanding-regions-and-availability-zones-in-amazon-lightsail">Regions
        /// and Availability Zones in Lightsail</a>.
        /// 
        ///  
        /// <para>
        /// The <code>create disk from snapshot</code> operation supports tag-based access control
        /// via request tags and resource tags applied to the resource identified by diskSnapshotName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual CreateDiskFromSnapshotResponse CreateDiskFromSnapshot(CreateDiskFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDiskFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDiskFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskFromSnapshot">REST API Reference for CreateDiskFromSnapshot Operation</seealso>
        public virtual Task<CreateDiskFromSnapshotResponse> CreateDiskFromSnapshotAsync(CreateDiskFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskFromSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDiskFromSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateDiskSnapshotResponse CreateDiskSnapshot(CreateDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDiskSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiskSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDiskSnapshot">REST API Reference for CreateDiskSnapshot Operation</seealso>
        public virtual Task<CreateDiskSnapshotResponse> CreateDiskSnapshotAsync(CreateDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDiskSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainEntry


        /// <summary>
        /// Creates one of the following entry records associated with the domain: A record, CNAME
        /// record, TXT record, or MX record.
        /// 
        ///  
        /// <para>
        /// The <code>create domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by domainName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<CreateDomainEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        public virtual Task<CreateDomainEntryResponse> CreateDomainEntryAsync(CreateDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstances


        /// <summary>
        /// Creates one or more Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// Create instances using active blueprints. Inactive blueprints are listed to support
        /// customers with existing instances but are not necessarily available for launch of
        /// new instances. Blueprints are marked inactive when they become outdated due to operating
        /// system updates or new application releases. Use the get blueprints operation to return
        /// a list of available blueprints.
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
        public virtual CreateInstancesResponse CreateInstances(CreateInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        public virtual Task<CreateInstancesResponse> CreateInstancesAsync(CreateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstancesFromSnapshot


        /// <summary>
        /// Uses a specific snapshot as a blueprint for creating one or more new instances that
        /// are based on that identical configuration.
        /// 
        ///  
        /// <para>
        /// The <code>create instances from snapshot</code> operation supports tag-based access
        /// control via request tags and resource tags applied to the resource identified by instanceSnapshotName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        public virtual Task<CreateInstancesFromSnapshotResponse> CreateInstancesFromSnapshotAsync(CreateInstancesFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInstancesFromSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        public virtual Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(CreateInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateInstanceSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public virtual Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateKeyPairResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public virtual Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLoadBalancerResponse>(request, options, cancellationToken);
        }

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
        /// The <code>create load balancer tls certificate</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual CreateLoadBalancerTlsCertificateResponse CreateLoadBalancerTlsCertificate(CreateLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerTlsCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerTlsCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateLoadBalancerTlsCertificate">REST API Reference for CreateLoadBalancerTlsCertificate Operation</seealso>
        public virtual Task<CreateLoadBalancerTlsCertificateResponse> CreateLoadBalancerTlsCertificateAsync(CreateLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerTlsCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateRelationalDatabaseResponse CreateRelationalDatabase(CreateRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabase">REST API Reference for CreateRelationalDatabase Operation</seealso>
        public virtual Task<CreateRelationalDatabaseResponse> CreateRelationalDatabaseAsync(CreateRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRelationalDatabaseResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateRelationalDatabaseFromSnapshotResponse CreateRelationalDatabaseFromSnapshot(CreateRelationalDatabaseFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelationalDatabaseFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseFromSnapshot">REST API Reference for CreateRelationalDatabaseFromSnapshot Operation</seealso>
        public virtual Task<CreateRelationalDatabaseFromSnapshotResponse> CreateRelationalDatabaseFromSnapshotAsync(CreateRelationalDatabaseFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseFromSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRelationalDatabaseFromSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateRelationalDatabaseSnapshotResponse CreateRelationalDatabaseSnapshot(CreateRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationalDatabaseSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateRelationalDatabaseSnapshot">REST API Reference for CreateRelationalDatabaseSnapshot Operation</seealso>
        public virtual Task<CreateRelationalDatabaseSnapshotResponse> CreateRelationalDatabaseSnapshotAsync(CreateRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

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
        /// tags applied to the resource identified by diskName. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteDiskResponse DeleteDisk(DeleteDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskResponseUnmarshaller.Instance;

            return Invoke<DeleteDiskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDisk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDisk">REST API Reference for DeleteDisk Operation</seealso>
        public virtual Task<DeleteDiskResponse> DeleteDiskAsync(DeleteDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDiskResponse>(request, options, cancellationToken);
        }

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
        /// via resource tags applied to the resource identified by diskSnapshotName. For more
        /// information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteDiskSnapshotResponse DeleteDiskSnapshot(DeleteDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDiskSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiskSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDiskSnapshot">REST API Reference for DeleteDiskSnapshot Operation</seealso>
        public virtual Task<DeleteDiskSnapshotResponse> DeleteDiskSnapshotAsync(DeleteDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDiskSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by domainName. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainEntry


        /// <summary>
        /// Deletes a specific domain entry.
        /// 
        ///  
        /// <para>
        /// The <code>delete domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by domainName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        public virtual Task<DeleteDomainEntryResponse> DeleteDomainEntryAsync(DeleteDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance


        /// <summary>
        /// Deletes a specific Amazon Lightsail virtual private server, or <i>instance</i>.
        /// 
        ///  
        /// <para>
        /// The <code>delete instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by instanceName. For more information, see
        /// the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceSnapshot


        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// 
        ///  
        /// <para>
        /// The <code>delete instance snapshot</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by instanceSnapshotName. For
        /// more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        public virtual Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(DeleteInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteInstanceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes a specific SSH key pair.
        /// 
        ///  
        /// <para>
        /// The <code>delete key pair</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by keyPairName. For more information, see
        /// the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public virtual Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteKeyPairResponse>(request, options, cancellationToken);
        }

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
        /// via resource tags applied to the resource identified by loadBalancerName. For more
        /// information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public virtual Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerTlsCertificate


        /// <summary>
        /// Deletes an SSL/TLS certificate associated with a Lightsail load balancer.
        /// 
        ///  
        /// <para>
        /// The <code>delete load balancer tls certificate</code> operation supports tag-based
        /// access control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DeleteLoadBalancerTlsCertificateResponse DeleteLoadBalancerTlsCertificate(DeleteLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerTlsCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerTlsCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerTlsCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteLoadBalancerTlsCertificate">REST API Reference for DeleteLoadBalancerTlsCertificate Operation</seealso>
        public virtual Task<DeleteLoadBalancerTlsCertificateResponse> DeleteLoadBalancerTlsCertificateAsync(DeleteLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerTlsCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteRelationalDatabaseResponse DeleteRelationalDatabase(DeleteRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabase">REST API Reference for DeleteRelationalDatabase Operation</seealso>
        public virtual Task<DeleteRelationalDatabaseResponse> DeleteRelationalDatabaseAsync(DeleteRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRelationalDatabaseResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteRelationalDatabaseSnapshotResponse DeleteRelationalDatabaseSnapshot(DeleteRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteRelationalDatabaseSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationalDatabaseSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteRelationalDatabaseSnapshot">REST API Reference for DeleteRelationalDatabaseSnapshot Operation</seealso>
        public virtual Task<DeleteRelationalDatabaseSnapshotResponse> DeleteRelationalDatabaseSnapshotAsync(DeleteRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

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
        /// tags applied to the resource identified by diskName. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DetachDiskResponse DetachDisk(DetachDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachDiskResponseUnmarshaller.Instance;

            return Invoke<DetachDiskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachDisk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachDisk">REST API Reference for DetachDisk Operation</seealso>
        public virtual Task<DetachDiskResponse> DetachDiskAsync(DetachDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachDiskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachDiskResponse>(request, options, cancellationToken);
        }

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
        /// access control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual DetachInstancesFromLoadBalancerResponse DetachInstancesFromLoadBalancer(DetachInstancesFromLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesFromLoadBalancerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachInstancesFromLoadBalancer">REST API Reference for DetachInstancesFromLoadBalancer Operation</seealso>
        public virtual Task<DetachInstancesFromLoadBalancerResponse> DetachInstancesFromLoadBalancerAsync(DetachInstancesFromLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesFromLoadBalancerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachInstancesFromLoadBalancerResponse>(request, options, cancellationToken);
        }

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
        public virtual DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachStaticIpResponseUnmarshaller.Instance;

            return Invoke<DetachStaticIpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        public virtual Task<DetachStaticIpResponse> DetachStaticIpAsync(DetachStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachStaticIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachStaticIpResponse>(request, options, cancellationToken);
        }

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
        public virtual DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDefaultKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;

            return Invoke<DownloadDefaultKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        public virtual Task<DownloadDefaultKeyPairResponse> DownloadDefaultKeyPairAsync(DownloadDefaultKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDefaultKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<DownloadDefaultKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportSnapshot


        /// <summary>
        /// Exports a Amazon Lightsail instance or block storage disk snapshot to Amazon Elastic
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
        /// tags applied to the resource identified by sourceSnapshotName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ExportSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        public virtual Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActiveNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActiveNamesResponseUnmarshaller.Instance;

            return Invoke<GetActiveNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        public virtual Task<GetActiveNamesResponse> GetActiveNamesAsync(GetActiveNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActiveNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActiveNamesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetActiveNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlueprints


        /// <summary>
        /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
        /// blueprint to create a new virtual private server already running a specific operating
        /// system, as well as a preinstalled app or development stack. The software each instance
        /// is running depends on the blueprint image you choose.
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
        public virtual GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintsResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        public virtual Task<GetBlueprintsResponse> GetBlueprintsAsync(GetBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBlueprintsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetBundlesResponse GetBundles(GetBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBundlesResponseUnmarshaller.Instance;

            return Invoke<GetBundlesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        public virtual Task<GetBundlesResponse> GetBundlesAsync(GetBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBundlesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBundlesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetCloudFormationStackRecordsResponse GetCloudFormationStackRecords(GetCloudFormationStackRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFormationStackRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationStackRecordsResponseUnmarshaller.Instance;

            return Invoke<GetCloudFormationStackRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudFormationStackRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudFormationStackRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetCloudFormationStackRecords">REST API Reference for GetCloudFormationStackRecords Operation</seealso>
        public virtual Task<GetCloudFormationStackRecordsResponse> GetCloudFormationStackRecordsAsync(GetCloudFormationStackRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFormationStackRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationStackRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCloudFormationStackRecordsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetDiskResponse GetDisk(GetDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskResponseUnmarshaller.Instance;

            return Invoke<GetDiskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDisk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDisk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisk">REST API Reference for GetDisk Operation</seealso>
        public virtual Task<GetDiskResponse> GetDiskAsync(GetDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDisks


        /// <summary>
        /// Returns information about all block storage disks in your AWS account and region.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of disks, you can paginate the output to make the
        /// list more manageable. You can use the pageToken and nextPageToken values to retrieve
        /// the next items in the list.
        /// </para>
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
        public virtual GetDisksResponse GetDisks(GetDisksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDisksResponseUnmarshaller.Instance;

            return Invoke<GetDisksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDisks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDisks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDisks">REST API Reference for GetDisks Operation</seealso>
        public virtual Task<GetDisksResponse> GetDisksAsync(GetDisksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDisksResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDisksResponse>(request, options, cancellationToken);
        }

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
        public virtual GetDiskSnapshotResponse GetDiskSnapshot(GetDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetDiskSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiskSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshot">REST API Reference for GetDiskSnapshot Operation</seealso>
        public virtual Task<GetDiskSnapshotResponse> GetDiskSnapshotAsync(GetDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDiskSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDiskSnapshots


        /// <summary>
        /// Returns information about all block storage disk snapshots in your AWS account and
        /// region.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of disk snapshots, you can paginate the output to
        /// make the list more manageable. You can use the pageToken and nextPageToken values
        /// to retrieve the next items in the list.
        /// </para>
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
        public virtual GetDiskSnapshotsResponse GetDiskSnapshots(GetDiskSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetDiskSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiskSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiskSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDiskSnapshots">REST API Reference for GetDiskSnapshots Operation</seealso>
        public virtual Task<GetDiskSnapshotsResponse> GetDiskSnapshotsAsync(GetDiskSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDiskSnapshotsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }

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
        public virtual GetDomainsResponse GetDomains(GetDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainsResponseUnmarshaller.Instance;

            return Invoke<GetDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        public virtual Task<GetDomainsResponse> GetDomainsAsync(GetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetExportSnapshotRecordsResponse GetExportSnapshotRecords(GetExportSnapshotRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportSnapshotRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportSnapshotRecordsResponseUnmarshaller.Instance;

            return Invoke<GetExportSnapshotRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportSnapshotRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportSnapshotRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetExportSnapshotRecords">REST API Reference for GetExportSnapshotRecords Operation</seealso>
        public virtual Task<GetExportSnapshotRecordsResponse> GetExportSnapshotRecordsAsync(GetExportSnapshotRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportSnapshotRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportSnapshotRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExportSnapshotRecordsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceAccessDetails


        /// <summary>
        /// Returns temporary SSH keys you can use to connect to a specific virtual private server,
        /// or <i>instance</i>.
        /// 
        ///  
        /// <para>
        /// The <code>get instance access details</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by instanceName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        public virtual Task<GetInstanceAccessDetailsResponse> GetInstanceAccessDetailsAsync(GetInstanceAccessDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceAccessDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceMetricData


        /// <summary>
        /// Returns the data points for the specified Amazon Lightsail instance metric, given
        /// an instance name.
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
        public virtual GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetInstanceMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        public virtual Task<GetInstanceMetricDataResponse> GetInstanceMetricDataAsync(GetInstanceMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstancePortStates


        /// <summary>
        /// Returns the port states for a specific virtual private server, or <i>instance</i>.
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
        public virtual GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancePortStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;

            return Invoke<GetInstancePortStatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        public virtual Task<GetInstancePortStatesResponse> GetInstancePortStatesAsync(GetInstancePortStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancePortStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstancePortStatesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetInstancesResponse GetInstances(GetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesResponseUnmarshaller.Instance;

            return Invoke<GetInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        public virtual Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstancesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        public virtual Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(GetInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        public virtual Task<GetInstanceSnapshotsResponse> GetInstanceSnapshotsAsync(GetInstanceSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceSnapshotsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceStateResponseUnmarshaller.Instance;

            return Invoke<GetInstanceStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        public virtual Task<GetInstanceStateResponse> GetInstanceStateAsync(GetInstanceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceStateResponse>(request, options, cancellationToken);
        }

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
        public virtual GetKeyPairResponse GetKeyPair(GetKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        public virtual Task<GetKeyPairResponse> GetKeyPairAsync(GetKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKeyPairResponse>(request, options, cancellationToken);
        }

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
        public virtual GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairsResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        public virtual Task<GetKeyPairsResponse> GetKeyPairsAsync(GetKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKeyPairsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetLoadBalancerResponse GetLoadBalancer(GetLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancer">REST API Reference for GetLoadBalancer Operation</seealso>
        public virtual Task<GetLoadBalancerResponse> GetLoadBalancerAsync(GetLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancerMetricData


        /// <summary>
        /// Returns information about health metrics for your Lightsail load balancer.
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
        public virtual GetLoadBalancerMetricDataResponse GetLoadBalancerMetricData(GetLoadBalancerMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoadBalancerMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerMetricData">REST API Reference for GetLoadBalancerMetricData Operation</seealso>
        public virtual Task<GetLoadBalancerMetricDataResponse> GetLoadBalancerMetricDataAsync(GetLoadBalancerMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerMetricDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoadBalancerMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancers


        /// <summary>
        /// Returns information about all load balancers in an account.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of load balancers, you can paginate the output to
        /// make the list more manageable. You can use the pageToken and nextPageToken values
        /// to retrieve the next items in the list.
        /// </para>
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
        public virtual GetLoadBalancersResponse GetLoadBalancers(GetLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancers">REST API Reference for GetLoadBalancers Operation</seealso>
        public virtual Task<GetLoadBalancersResponse> GetLoadBalancersAsync(GetLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoadBalancersResponse>(request, options, cancellationToken);
        }

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
        public virtual GetLoadBalancerTlsCertificatesResponse GetLoadBalancerTlsCertificates(GetLoadBalancerTlsCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerTlsCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoadBalancerTlsCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoadBalancerTlsCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetLoadBalancerTlsCertificates">REST API Reference for GetLoadBalancerTlsCertificates Operation</seealso>
        public virtual Task<GetLoadBalancerTlsCertificatesResponse> GetLoadBalancerTlsCertificatesAsync(GetLoadBalancerTlsCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoadBalancerTlsCertificatesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOperationResponse>(request, options, cancellationToken);
        }

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
        public virtual GetOperationsResponse GetOperations(GetOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsResponseUnmarshaller.Instance;

            return Invoke<GetOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        public virtual Task<GetOperationsResponse> GetOperationsAsync(GetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOperationsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;

            return Invoke<GetOperationsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        public virtual Task<GetOperationsForResourceResponse> GetOperationsForResourceAsync(GetOperationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOperationsForResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRegionsResponse GetRegions(GetRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionsResponseUnmarshaller.Instance;

            return Invoke<GetRegionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        public virtual Task<GetRegionsResponse> GetRegionsAsync(GetRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRegionsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseResponse GetRelationalDatabase(GetRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabase">REST API Reference for GetRelationalDatabase Operation</seealso>
        public virtual Task<GetRelationalDatabaseResponse> GetRelationalDatabaseAsync(GetRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseBlueprintsResponse GetRelationalDatabaseBlueprints(GetRelationalDatabaseBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBlueprintsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBlueprints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBlueprints">REST API Reference for GetRelationalDatabaseBlueprints Operation</seealso>
        public virtual Task<GetRelationalDatabaseBlueprintsResponse> GetRelationalDatabaseBlueprintsAsync(GetRelationalDatabaseBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBlueprintsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseBlueprintsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseBundlesResponse GetRelationalDatabaseBundles(GetRelationalDatabaseBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBundlesResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseBundlesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseBundles">REST API Reference for GetRelationalDatabaseBundles Operation</seealso>
        public virtual Task<GetRelationalDatabaseBundlesResponse> GetRelationalDatabaseBundlesAsync(GetRelationalDatabaseBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBundlesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseBundlesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseEventsResponse GetRelationalDatabaseEvents(GetRelationalDatabaseEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseEventsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseEvents">REST API Reference for GetRelationalDatabaseEvents Operation</seealso>
        public virtual Task<GetRelationalDatabaseEventsResponse> GetRelationalDatabaseEventsAsync(GetRelationalDatabaseEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseEventsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseLogEventsResponse GetRelationalDatabaseLogEvents(GetRelationalDatabaseLogEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogEventsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseLogEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogEvents">REST API Reference for GetRelationalDatabaseLogEvents Operation</seealso>
        public virtual Task<GetRelationalDatabaseLogEventsResponse> GetRelationalDatabaseLogEventsAsync(GetRelationalDatabaseLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseLogEventsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseLogStreamsResponse GetRelationalDatabaseLogStreams(GetRelationalDatabaseLogStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogStreamsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseLogStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseLogStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseLogStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseLogStreams">REST API Reference for GetRelationalDatabaseLogStreams Operation</seealso>
        public virtual Task<GetRelationalDatabaseLogStreamsResponse> GetRelationalDatabaseLogStreamsAsync(GetRelationalDatabaseLogStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogStreamsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseLogStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseMasterUserPassword


        /// <summary>
        /// Returns the current, previous, or pending versions of the master user password for
        /// a Lightsail database.
        /// 
        ///  
        /// <para>
        /// The <code>asdf</code> operation GetRelationalDatabaseMasterUserPassword supports tag-based
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
        public virtual GetRelationalDatabaseMasterUserPasswordResponse GetRelationalDatabaseMasterUserPassword(GetRelationalDatabaseMasterUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMasterUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMasterUserPasswordResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseMasterUserPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseMasterUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMasterUserPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMasterUserPassword">REST API Reference for GetRelationalDatabaseMasterUserPassword Operation</seealso>
        public virtual Task<GetRelationalDatabaseMasterUserPasswordResponse> GetRelationalDatabaseMasterUserPasswordAsync(GetRelationalDatabaseMasterUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMasterUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMasterUserPasswordResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseMasterUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseMetricData


        /// <summary>
        /// Returns the data points of the specified metric for a database in Amazon Lightsail.
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
        public virtual GetRelationalDatabaseMetricDataResponse GetRelationalDatabaseMetricData(GetRelationalDatabaseMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseMetricData">REST API Reference for GetRelationalDatabaseMetricData Operation</seealso>
        public virtual Task<GetRelationalDatabaseMetricDataResponse> GetRelationalDatabaseMetricDataAsync(GetRelationalDatabaseMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMetricDataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseMetricDataResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseParametersResponse GetRelationalDatabaseParameters(GetRelationalDatabaseParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseParametersResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseParameters">REST API Reference for GetRelationalDatabaseParameters Operation</seealso>
        public virtual Task<GetRelationalDatabaseParametersResponse> GetRelationalDatabaseParametersAsync(GetRelationalDatabaseParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseParametersResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabasesResponse GetRelationalDatabases(GetRelationalDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabases">REST API Reference for GetRelationalDatabases Operation</seealso>
        public virtual Task<GetRelationalDatabasesResponse> GetRelationalDatabasesAsync(GetRelationalDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabasesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseSnapshotResponse GetRelationalDatabaseSnapshot(GetRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshot">REST API Reference for GetRelationalDatabaseSnapshot Operation</seealso>
        public virtual Task<GetRelationalDatabaseSnapshotResponse> GetRelationalDatabaseSnapshotAsync(GetRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

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
        public virtual GetRelationalDatabaseSnapshotsResponse GetRelationalDatabaseSnapshots(GetRelationalDatabaseSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelationalDatabaseSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelationalDatabaseSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRelationalDatabaseSnapshots">REST API Reference for GetRelationalDatabaseSnapshots Operation</seealso>
        public virtual Task<GetRelationalDatabaseSnapshotsResponse> GetRelationalDatabaseSnapshotsAsync(GetRelationalDatabaseSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRelationalDatabaseSnapshotsResponse>(request, options, cancellationToken);
        }

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
        public virtual GetStaticIpResponse GetStaticIp(GetStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        public virtual Task<GetStaticIpResponse> GetStaticIpAsync(GetStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStaticIpResponse>(request, options, cancellationToken);
        }

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
        public virtual GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpsResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        public virtual Task<GetStaticIpsResponse> GetStaticIpsAsync(GetStaticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStaticIpsResponse>(request, options, cancellationToken);
        }

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
        public virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public virtual Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportKeyPairResponse>(request, options, cancellationToken);
        }

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
        public virtual IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsVpcPeeredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;

            return Invoke<IsVpcPeeredResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        public virtual Task<IsVpcPeeredResponse> IsVpcPeeredAsync(IsVpcPeeredRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsVpcPeeredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;
            
            return InvokeAsync<IsVpcPeeredResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OpenInstancePublicPorts


        /// <summary>
        /// Adds public ports to an Amazon Lightsail instance.
        /// 
        ///  
        /// <para>
        /// The <code>open instance public ports</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by instanceName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OpenInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<OpenInstancePublicPortsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        public virtual Task<OpenInstancePublicPortsResponse> OpenInstancePublicPortsAsync(OpenInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OpenInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;
            
            return InvokeAsync<OpenInstancePublicPortsResponse>(request, options, cancellationToken);
        }

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
        public virtual PeerVpcResponse PeerVpc(PeerVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PeerVpcResponseUnmarshaller.Instance;

            return Invoke<PeerVpcResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        public virtual Task<PeerVpcResponse> PeerVpcAsync(PeerVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PeerVpcResponseUnmarshaller.Instance;
            
            return InvokeAsync<PeerVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInstancePublicPorts


        /// <summary>
        /// Sets the specified open ports for an Amazon Lightsail instance, and closes all ports
        /// for every protocol not included in the current request.
        /// 
        ///  
        /// <para>
        /// The <code>put instance public ports</code> operation supports tag-based access control
        /// via resource tags applied to the resource identified by instanceName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<PutInstancePublicPortsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        public virtual Task<PutInstancePublicPortsResponse> PutInstancePublicPortsAsync(PutInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutInstancePublicPortsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootInstance


        /// <summary>
        /// Restarts a specific instance. When your Amazon Lightsail instance is finished rebooting,
        /// Lightsail assigns a new public IP address. To use the same IP address after restarting,
        /// create a static IP address and attach it to the instance.
        /// 
        ///  
        /// <para>
        /// The <code>reboot instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by instanceName. For more information, see
        /// the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public virtual Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootInstanceResponse>(request, options, cancellationToken);
        }

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
        public virtual RebootRelationalDatabaseResponse RebootRelationalDatabase(RebootRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<RebootRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootRelationalDatabase">REST API Reference for RebootRelationalDatabase Operation</seealso>
        public virtual Task<RebootRelationalDatabaseResponse> RebootRelationalDatabaseAsync(RebootRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootRelationalDatabaseResponse>(request, options, cancellationToken);
        }

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
        public virtual ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;

            return Invoke<ReleaseStaticIpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        public virtual Task<ReleaseStaticIpResponse> ReleaseStaticIpAsync(ReleaseStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReleaseStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstance


        /// <summary>
        /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
        /// use the reboot instance operation.
        /// 
        ///  
        /// <para>
        /// The <code>start instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by instanceName. For more information, see
        /// the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return Invoke<StartInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public virtual Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartInstanceResponse>(request, options, cancellationToken);
        }

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
        public virtual StartRelationalDatabaseResponse StartRelationalDatabase(StartRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<StartRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartRelationalDatabase">REST API Reference for StartRelationalDatabase Operation</seealso>
        public virtual Task<StartRelationalDatabaseResponse> StartRelationalDatabaseAsync(StartRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInstance


        /// <summary>
        /// Stops a specific Amazon Lightsail instance that is currently running.
        /// 
        ///  
        /// <para>
        /// The <code>stop instance</code> operation supports tag-based access control via resource
        /// tags applied to the resource identified by instanceName. For more information, see
        /// the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return Invoke<StopInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public virtual Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopInstanceResponse>(request, options, cancellationToken);
        }

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
        public virtual StopRelationalDatabaseResponse StopRelationalDatabase(StopRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<StopRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopRelationalDatabase">REST API Reference for StopRelationalDatabase Operation</seealso>
        public virtual Task<StopRelationalDatabaseResponse> StopRelationalDatabaseAsync(StopRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopRelationalDatabaseResponse>(request, options, cancellationToken);
        }

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
        /// tags and resource tags applied to the resource identified by resourceName. For more
        /// information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnpeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnpeerVpcResponseUnmarshaller.Instance;

            return Invoke<UnpeerVpcResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        public virtual Task<UnpeerVpcResponse> UnpeerVpcAsync(UnpeerVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnpeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnpeerVpcResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnpeerVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the specified set of tag keys and their values from the specified Amazon Lightsail
        /// resource.
        /// 
        ///  
        /// <para>
        /// The <code>untag resource</code> operation supports tag-based access control via request
        /// tags and resource tags applied to the resource identified by resourceName. For more
        /// information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainEntry


        /// <summary>
        /// Updates a domain recordset after it is created.
        /// 
        ///  
        /// <para>
        /// The <code>update domain entry</code> operation supports tag-based access control via
        /// resource tags applied to the resource identified by domainName. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainEntryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        public virtual Task<UpdateDomainEntryResponse> UpdateDomainEntryAsync(UpdateDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoadBalancerAttribute


        /// <summary>
        /// Updates the specified attribute for a load balancer. You can only update one attribute
        /// at a time.
        /// 
        ///  
        /// <para>
        /// The <code>update load balancer attribute</code> operation supports tag-based access
        /// control via resource tags applied to the resource identified by loadBalancerName.
        /// For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
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
        public virtual UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoadBalancerAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoadBalancerAttributeResponseUnmarshaller.Instance;

            return Invoke<UpdateLoadBalancerAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoadBalancerAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoadBalancerAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateLoadBalancerAttribute">REST API Reference for UpdateLoadBalancerAttribute Operation</seealso>
        public virtual Task<UpdateLoadBalancerAttributeResponse> UpdateLoadBalancerAttributeAsync(UpdateLoadBalancerAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoadBalancerAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoadBalancerAttributeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLoadBalancerAttributeResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateRelationalDatabaseResponse UpdateRelationalDatabase(UpdateRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateRelationalDatabaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelationalDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabase operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabase">REST API Reference for UpdateRelationalDatabase Operation</seealso>
        public virtual Task<UpdateRelationalDatabaseResponse> UpdateRelationalDatabaseAsync(UpdateRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRelationalDatabaseParameters


        /// <summary>
        /// Allows the update of one or more parameters of a database in Amazon Lightsail.
        /// 
        ///  
        /// <para>
        /// Parameter updates don't cause outages; therefore, their application is not subject
        /// to the preferred maintenance window. However, there are two ways in which paramater
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
        public virtual UpdateRelationalDatabaseParametersResponse UpdateRelationalDatabaseParameters(UpdateRelationalDatabaseParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateRelationalDatabaseParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelationalDatabaseParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationalDatabaseParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateRelationalDatabaseParameters">REST API Reference for UpdateRelationalDatabaseParameters Operation</seealso>
        public virtual Task<UpdateRelationalDatabaseParametersResponse> UpdateRelationalDatabaseParametersAsync(UpdateRelationalDatabaseParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRelationalDatabaseParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
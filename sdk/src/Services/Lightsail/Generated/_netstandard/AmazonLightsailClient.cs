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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLightsailEndpointResolver());
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

        internal virtual AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;

            return Invoke<AllocateStaticIpResponse>(request, options);
        }



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
        public virtual Task<AllocateStaticIpResponse> AllocateStaticIpAsync(AllocateStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachCertificateToDistribution

        internal virtual AttachCertificateToDistributionResponse AttachCertificateToDistribution(AttachCertificateToDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCertificateToDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCertificateToDistributionResponseUnmarshaller.Instance;

            return Invoke<AttachCertificateToDistributionResponse>(request, options);
        }



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
        public virtual Task<AttachCertificateToDistributionResponse> AttachCertificateToDistributionAsync(AttachCertificateToDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachCertificateToDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachCertificateToDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<AttachCertificateToDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachDisk

        internal virtual AttachDiskResponse AttachDisk(AttachDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachDiskResponseUnmarshaller.Instance;

            return Invoke<AttachDiskResponse>(request, options);
        }



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
        public virtual Task<AttachDiskResponse> AttachDiskAsync(AttachDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachDiskResponseUnmarshaller.Instance;

            return InvokeAsync<AttachDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachInstancesToLoadBalancer

        internal virtual AttachInstancesToLoadBalancerResponse AttachInstancesToLoadBalancer(AttachInstancesToLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesToLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesToLoadBalancerResponse>(request, options);
        }



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
        public virtual Task<AttachInstancesToLoadBalancerResponse> AttachInstancesToLoadBalancerAsync(AttachInstancesToLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesToLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInstancesToLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancerTlsCertificate

        internal virtual AttachLoadBalancerTlsCertificateResponse AttachLoadBalancerTlsCertificate(AttachLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerTlsCertificateResponse>(request, options);
        }



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
        public virtual Task<AttachLoadBalancerTlsCertificateResponse> AttachLoadBalancerTlsCertificateAsync(AttachLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachStaticIp

        internal virtual AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachStaticIpResponseUnmarshaller.Instance;

            return Invoke<AttachStaticIpResponse>(request, options);
        }



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
        public virtual Task<AttachStaticIpResponse> AttachStaticIpAsync(AttachStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachStaticIpResponseUnmarshaller.Instance;

            return InvokeAsync<AttachStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CloseInstancePublicPorts

        internal virtual CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<CloseInstancePublicPortsResponse>(request, options);
        }



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
        public virtual Task<CloseInstancePublicPortsResponse> CloseInstancePublicPortsAsync(CloseInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;

            return InvokeAsync<CloseInstancePublicPortsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }



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
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBucket

        internal virtual CreateBucketResponse CreateBucket(CreateBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketResponseUnmarshaller.Instance;

            return Invoke<CreateBucketResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateBucketResponse> CreateBucketAsync(CreateBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBucketAccessKey

        internal virtual CreateBucketAccessKeyResponse CreateBucketAccessKey(CreateBucketAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketAccessKeyResponseUnmarshaller.Instance;

            return Invoke<CreateBucketAccessKeyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateBucketAccessKeyResponse> CreateBucketAccessKeyAsync(CreateBucketAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBucketAccessKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCertificate

        internal virtual CreateCertificateResponse CreateCertificate(CreateCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateResponse>(request, options);
        }



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
        public virtual Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCloudFormationStack

        internal virtual CreateCloudFormationStackResponse CreateCloudFormationStack(CreateCloudFormationStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationStackResponseUnmarshaller.Instance;

            return Invoke<CreateCloudFormationStackResponse>(request, options);
        }



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
        public virtual Task<CreateCloudFormationStackResponse> CreateCloudFormationStackAsync(CreateCloudFormationStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCloudFormationStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudFormationStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudFormationStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContactMethod

        internal virtual CreateContactMethodResponse CreateContactMethod(CreateContactMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactMethodResponseUnmarshaller.Instance;

            return Invoke<CreateContactMethodResponse>(request, options);
        }



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
        public virtual Task<CreateContactMethodResponse> CreateContactMethodAsync(CreateContactMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContactMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContactMethodResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContactMethodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContainerService

        internal virtual CreateContainerServiceResponse CreateContainerService(CreateContainerServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceResponseUnmarshaller.Instance;

            return Invoke<CreateContainerServiceResponse>(request, options);
        }



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
        public virtual Task<CreateContainerServiceResponse> CreateContainerServiceAsync(CreateContainerServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContainerServiceDeployment

        internal virtual CreateContainerServiceDeploymentResponse CreateContainerServiceDeployment(CreateContainerServiceDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateContainerServiceDeploymentResponse>(request, options);
        }



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
        public virtual Task<CreateContainerServiceDeploymentResponse> CreateContainerServiceDeploymentAsync(CreateContainerServiceDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerServiceDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateContainerServiceRegistryLogin

        internal virtual CreateContainerServiceRegistryLoginResponse CreateContainerServiceRegistryLogin(CreateContainerServiceRegistryLoginRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceRegistryLoginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceRegistryLoginResponseUnmarshaller.Instance;

            return Invoke<CreateContainerServiceRegistryLoginResponse>(request, options);
        }



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
        public virtual Task<CreateContainerServiceRegistryLoginResponse> CreateContainerServiceRegistryLoginAsync(CreateContainerServiceRegistryLoginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateContainerServiceRegistryLoginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateContainerServiceRegistryLoginResponseUnmarshaller.Instance;

            return InvokeAsync<CreateContainerServiceRegistryLoginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDisk

        internal virtual CreateDiskResponse CreateDisk(CreateDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskResponseUnmarshaller.Instance;

            return Invoke<CreateDiskResponse>(request, options);
        }



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
        public virtual Task<CreateDiskResponse> CreateDiskAsync(CreateDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDiskFromSnapshot

        internal virtual CreateDiskFromSnapshotResponse CreateDiskFromSnapshot(CreateDiskFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDiskFromSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateDiskFromSnapshotResponse> CreateDiskFromSnapshotAsync(CreateDiskFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDiskFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDiskSnapshot

        internal virtual CreateDiskSnapshotResponse CreateDiskSnapshot(CreateDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDiskSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateDiskSnapshotResponse> CreateDiskSnapshotAsync(CreateDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiskSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDiskSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDistribution

        internal virtual CreateDistributionResponse CreateDistribution(CreateDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return Invoke<CreateDistributionResponse>(request, options);
        }



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
        public virtual Task<CreateDistributionResponse> CreateDistributionAsync(CreateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }



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
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainEntry

        internal virtual CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<CreateDomainEntryResponse>(request, options);
        }



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
        public virtual Task<CreateDomainEntryResponse> CreateDomainEntryAsync(CreateDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGUISessionAccessDetails

        internal virtual CreateGUISessionAccessDetailsResponse CreateGUISessionAccessDetails(CreateGUISessionAccessDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGUISessionAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGUISessionAccessDetailsResponseUnmarshaller.Instance;

            return Invoke<CreateGUISessionAccessDetailsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateGUISessionAccessDetailsResponse> CreateGUISessionAccessDetailsAsync(CreateGUISessionAccessDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGUISessionAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGUISessionAccessDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGUISessionAccessDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstances

        internal virtual CreateInstancesResponse CreateInstances(CreateInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesResponse>(request, options);
        }



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
        public virtual Task<CreateInstancesResponse> CreateInstancesAsync(CreateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstancesFromSnapshot

        internal virtual CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesFromSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateInstancesFromSnapshotResponse> CreateInstancesFromSnapshotAsync(CreateInstancesFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstancesFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstancesFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceSnapshot

        internal virtual CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateInstanceSnapshotResponse> CreateInstanceSnapshotAsync(CreateInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKeyPair

        internal virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairResponse>(request, options);
        }



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
        public virtual Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer

        internal virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerResponse>(request, options);
        }



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
        public virtual Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancerTlsCertificate

        internal virtual CreateLoadBalancerTlsCertificateResponse CreateLoadBalancerTlsCertificate(CreateLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerTlsCertificateResponse>(request, options);
        }



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
        public virtual Task<CreateLoadBalancerTlsCertificateResponse> CreateLoadBalancerTlsCertificateAsync(CreateLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRelationalDatabase

        internal virtual CreateRelationalDatabaseResponse CreateRelationalDatabase(CreateRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<CreateRelationalDatabaseResponse> CreateRelationalDatabaseAsync(CreateRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRelationalDatabaseFromSnapshot

        internal virtual CreateRelationalDatabaseFromSnapshotResponse CreateRelationalDatabaseFromSnapshot(CreateRelationalDatabaseFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseFromSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateRelationalDatabaseFromSnapshotResponse> CreateRelationalDatabaseFromSnapshotAsync(CreateRelationalDatabaseFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRelationalDatabaseFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRelationalDatabaseSnapshot

        internal virtual CreateRelationalDatabaseSnapshotResponse CreateRelationalDatabaseSnapshot(CreateRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateRelationalDatabaseSnapshotResponse>(request, options);
        }



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
        public virtual Task<CreateRelationalDatabaseSnapshotResponse> CreateRelationalDatabaseSnapshotAsync(CreateRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlarm

        internal virtual DeleteAlarmResponse DeleteAlarm(DeleteAlarmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmResponseUnmarshaller.Instance;

            return Invoke<DeleteAlarmResponse>(request, options);
        }



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
        public virtual Task<DeleteAlarmResponse> DeleteAlarmAsync(DeleteAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoSnapshot

        internal virtual DeleteAutoSnapshotResponse DeleteAutoSnapshot(DeleteAutoSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes an automatic snapshot of an instance or disk. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        public virtual Task<DeleteAutoSnapshotResponse> DeleteAutoSnapshotAsync(DeleteAutoSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutoSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket

        internal virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketAccessKey

        internal virtual DeleteBucketAccessKeyResponse DeleteBucketAccessKey(DeleteBucketAccessKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAccessKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketAccessKeyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteBucketAccessKeyResponse> DeleteBucketAccessKeyAsync(DeleteBucketAccessKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAccessKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAccessKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketAccessKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate

        internal virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }



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
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContactMethod

        internal virtual DeleteContactMethodResponse DeleteContactMethod(DeleteContactMethodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteContactMethodResponse>(request, options);
        }



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
        public virtual Task<DeleteContactMethodResponse> DeleteContactMethodAsync(DeleteContactMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContactMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContactMethodResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContactMethodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainerImage

        internal virtual DeleteContainerImageResponse DeleteContainerImage(DeleteContainerImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerImageResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerImageResponse>(request, options);
        }



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
        public virtual Task<DeleteContainerImageResponse> DeleteContainerImageAsync(DeleteContainerImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteContainerService

        internal virtual DeleteContainerServiceResponse DeleteContainerService(DeleteContainerServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteContainerServiceResponse>(request, options);
        }



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
        public virtual Task<DeleteContainerServiceResponse> DeleteContainerServiceAsync(DeleteContainerServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteContainerServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteContainerServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDisk

        internal virtual DeleteDiskResponse DeleteDisk(DeleteDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskResponseUnmarshaller.Instance;

            return Invoke<DeleteDiskResponse>(request, options);
        }



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
        public virtual Task<DeleteDiskResponse> DeleteDiskAsync(DeleteDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDiskSnapshot

        internal virtual DeleteDiskSnapshotResponse DeleteDiskSnapshot(DeleteDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDiskSnapshotResponse>(request, options);
        }



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
        public virtual Task<DeleteDiskSnapshotResponse> DeleteDiskSnapshotAsync(DeleteDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiskSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDiskSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDistribution

        internal virtual DeleteDistributionResponse DeleteDistribution(DeleteDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return Invoke<DeleteDistributionResponse>(request, options);
        }



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
        public virtual Task<DeleteDistributionResponse> DeleteDistributionAsync(DeleteDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }



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
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainEntry

        internal virtual DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainEntryResponse>(request, options);
        }



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
        public virtual Task<DeleteDomainEntryResponse> DeleteDomainEntryAsync(DeleteDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstance

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceResponse>(request, options);
        }



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
        public virtual Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInstanceSnapshot

        internal virtual DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceSnapshotResponse>(request, options);
        }



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
        public virtual Task<DeleteInstanceSnapshotResponse> DeleteInstanceSnapshotAsync(DeleteInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInstanceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        internal virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairResponse>(request, options);
        }



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
        public virtual Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKnownHostKeys

        internal virtual DeleteKnownHostKeysResponse DeleteKnownHostKeys(DeleteKnownHostKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKnownHostKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnownHostKeysResponseUnmarshaller.Instance;

            return Invoke<DeleteKnownHostKeysResponse>(request, options);
        }



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
        public virtual Task<DeleteKnownHostKeysResponse> DeleteKnownHostKeysAsync(DeleteKnownHostKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKnownHostKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKnownHostKeysResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKnownHostKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer

        internal virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerResponse>(request, options);
        }



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
        public virtual Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerTlsCertificate

        internal virtual DeleteLoadBalancerTlsCertificateResponse DeleteLoadBalancerTlsCertificate(DeleteLoadBalancerTlsCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerTlsCertificateResponse>(request, options);
        }



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
        public virtual Task<DeleteLoadBalancerTlsCertificateResponse> DeleteLoadBalancerTlsCertificateAsync(DeleteLoadBalancerTlsCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerTlsCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerTlsCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerTlsCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRelationalDatabase

        internal virtual DeleteRelationalDatabaseResponse DeleteRelationalDatabase(DeleteRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<DeleteRelationalDatabaseResponse> DeleteRelationalDatabaseAsync(DeleteRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRelationalDatabaseSnapshot

        internal virtual DeleteRelationalDatabaseSnapshotResponse DeleteRelationalDatabaseSnapshot(DeleteRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteRelationalDatabaseSnapshotResponse>(request, options);
        }



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
        public virtual Task<DeleteRelationalDatabaseSnapshotResponse> DeleteRelationalDatabaseSnapshotAsync(DeleteRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachCertificateFromDistribution

        internal virtual DetachCertificateFromDistributionResponse DetachCertificateFromDistribution(DetachCertificateFromDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCertificateFromDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCertificateFromDistributionResponseUnmarshaller.Instance;

            return Invoke<DetachCertificateFromDistributionResponse>(request, options);
        }



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
        public virtual Task<DetachCertificateFromDistributionResponse> DetachCertificateFromDistributionAsync(DetachCertificateFromDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachCertificateFromDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachCertificateFromDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<DetachCertificateFromDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachDisk

        internal virtual DetachDiskResponse DetachDisk(DetachDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachDiskResponseUnmarshaller.Instance;

            return Invoke<DetachDiskResponse>(request, options);
        }



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
        public virtual Task<DetachDiskResponse> DetachDiskAsync(DetachDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachDiskResponseUnmarshaller.Instance;

            return InvokeAsync<DetachDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachInstancesFromLoadBalancer

        internal virtual DetachInstancesFromLoadBalancerResponse DetachInstancesFromLoadBalancer(DetachInstancesFromLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesFromLoadBalancerResponse>(request, options);
        }



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
        public virtual Task<DetachInstancesFromLoadBalancerResponse> DetachInstancesFromLoadBalancerAsync(DetachInstancesFromLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInstancesFromLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachStaticIp

        internal virtual DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachStaticIpResponseUnmarshaller.Instance;

            return Invoke<DetachStaticIpResponse>(request, options);
        }



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
        public virtual Task<DetachStaticIpResponse> DetachStaticIpAsync(DetachStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachStaticIpResponseUnmarshaller.Instance;

            return InvokeAsync<DetachStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAddOn

        internal virtual DisableAddOnResponse DisableAddOn(DisableAddOnRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAddOnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAddOnResponseUnmarshaller.Instance;

            return Invoke<DisableAddOnResponse>(request, options);
        }



        /// <summary>
        /// Disables an add-on for an Amazon Lightsail resource. For more information, see the
        /// <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        public virtual Task<DisableAddOnResponse> DisableAddOnAsync(DisableAddOnRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAddOnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAddOnResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAddOnResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DownloadDefaultKeyPair

        internal virtual DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDefaultKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;

            return Invoke<DownloadDefaultKeyPairResponse>(request, options);
        }



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
        public virtual Task<DownloadDefaultKeyPairResponse> DownloadDefaultKeyPairAsync(DownloadDefaultKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDefaultKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DownloadDefaultKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAddOn

        internal virtual EnableAddOnResponse EnableAddOn(EnableAddOnRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAddOnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAddOnResponseUnmarshaller.Instance;

            return Invoke<EnableAddOnResponse>(request, options);
        }



        /// <summary>
        /// Enables or modifies an add-on for an Amazon Lightsail resource. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        public virtual Task<EnableAddOnResponse> EnableAddOnAsync(EnableAddOnRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAddOnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAddOnResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAddOnResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportSnapshot

        internal virtual ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ExportSnapshotResponse>(request, options);
        }



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
        public virtual Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ExportSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetActiveNames

        internal virtual GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActiveNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActiveNamesResponseUnmarshaller.Instance;

            return Invoke<GetActiveNamesResponse>(request, options);
        }



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
        public virtual Task<GetActiveNamesResponse> GetActiveNamesAsync(GetActiveNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActiveNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActiveNamesResponseUnmarshaller.Instance;

            return InvokeAsync<GetActiveNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAlarms

        internal virtual GetAlarmsResponse GetAlarms(GetAlarmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlarmsResponseUnmarshaller.Instance;

            return Invoke<GetAlarmsResponse>(request, options);
        }



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
        public virtual Task<GetAlarmsResponse> GetAlarmsAsync(GetAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlarmsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAlarmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAutoSnapshots

        internal virtual GetAutoSnapshotsResponse GetAutoSnapshots(GetAutoSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetAutoSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns the available automatic snapshots for an instance or disk. For more information,
        /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Amazon
        /// Lightsail Developer Guide</a>.
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
        public virtual Task<GetAutoSnapshotsResponse> GetAutoSnapshotsAsync(GetAutoSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlueprints

        internal virtual GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintsResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintsResponse>(request, options);
        }



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
        public virtual Task<GetBlueprintsResponse> GetBlueprintsAsync(GetBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlueprintsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlueprintsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAccessKeys

        internal virtual GetBucketAccessKeysResponse GetBucketAccessKeys(GetBucketAccessKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccessKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccessKeysResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccessKeysResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBucketAccessKeysResponse> GetBucketAccessKeysAsync(GetBucketAccessKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccessKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccessKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAccessKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketBundles

        internal virtual GetBucketBundlesResponse GetBucketBundles(GetBucketBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketBundlesResponseUnmarshaller.Instance;

            return Invoke<GetBucketBundlesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBucketBundlesResponse> GetBucketBundlesAsync(GetBucketBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketMetricData

        internal virtual GetBucketMetricDataResponse GetBucketMetricData(GetBucketMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetBucketMetricDataResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBucketMetricDataResponse> GetBucketMetricDataAsync(GetBucketMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBuckets

        internal virtual GetBucketsResponse GetBuckets(GetBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketsResponseUnmarshaller.Instance;

            return Invoke<GetBucketsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetBucketsResponse> GetBucketsAsync(GetBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBundles

        internal virtual GetBundlesResponse GetBundles(GetBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBundlesResponseUnmarshaller.Instance;

            return Invoke<GetBundlesResponse>(request, options);
        }



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
        public virtual Task<GetBundlesResponse> GetBundlesAsync(GetBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<GetBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCertificates

        internal virtual GetCertificatesResponse GetCertificates(GetCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetCertificatesResponse>(request, options);
        }



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
        public virtual Task<GetCertificatesResponse> GetCertificatesAsync(GetCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCloudFormationStackRecords

        internal virtual GetCloudFormationStackRecordsResponse GetCloudFormationStackRecords(GetCloudFormationStackRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFormationStackRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationStackRecordsResponseUnmarshaller.Instance;

            return Invoke<GetCloudFormationStackRecordsResponse>(request, options);
        }



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
        public virtual Task<GetCloudFormationStackRecordsResponse> GetCloudFormationStackRecordsAsync(GetCloudFormationStackRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCloudFormationStackRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudFormationStackRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudFormationStackRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContactMethods

        internal virtual GetContactMethodsResponse GetContactMethods(GetContactMethodsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactMethodsResponseUnmarshaller.Instance;

            return Invoke<GetContactMethodsResponse>(request, options);
        }



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
        public virtual Task<GetContactMethodsResponse> GetContactMethodsAsync(GetContactMethodsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContactMethodsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContactMethodsResponseUnmarshaller.Instance;

            return InvokeAsync<GetContactMethodsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerAPIMetadata

        internal virtual GetContainerAPIMetadataResponse GetContainerAPIMetadata(GetContainerAPIMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerAPIMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerAPIMetadataResponseUnmarshaller.Instance;

            return Invoke<GetContainerAPIMetadataResponse>(request, options);
        }



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
        public virtual Task<GetContainerAPIMetadataResponse> GetContainerAPIMetadataAsync(GetContainerAPIMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerAPIMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerAPIMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerAPIMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerImages

        internal virtual GetContainerImagesResponse GetContainerImages(GetContainerImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerImagesResponseUnmarshaller.Instance;

            return Invoke<GetContainerImagesResponse>(request, options);
        }



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
        public virtual Task<GetContainerImagesResponse> GetContainerImagesAsync(GetContainerImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerImagesResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerLog

        internal virtual GetContainerLogResponse GetContainerLog(GetContainerLogRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerLogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerLogResponseUnmarshaller.Instance;

            return Invoke<GetContainerLogResponse>(request, options);
        }



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
        public virtual Task<GetContainerLogResponse> GetContainerLogAsync(GetContainerLogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerLogRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerLogResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerLogResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerServiceDeployments

        internal virtual GetContainerServiceDeploymentsResponse GetContainerServiceDeployments(GetContainerServiceDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServiceDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServiceDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetContainerServiceDeploymentsResponse>(request, options);
        }



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
        public virtual Task<GetContainerServiceDeploymentsResponse> GetContainerServiceDeploymentsAsync(GetContainerServiceDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServiceDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServiceDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerServiceDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerServiceMetricData

        internal virtual GetContainerServiceMetricDataResponse GetContainerServiceMetricData(GetContainerServiceMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServiceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServiceMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetContainerServiceMetricDataResponse>(request, options);
        }



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
        public virtual Task<GetContainerServiceMetricDataResponse> GetContainerServiceMetricDataAsync(GetContainerServiceMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServiceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServiceMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerServiceMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerServicePowers

        internal virtual GetContainerServicePowersResponse GetContainerServicePowers(GetContainerServicePowersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServicePowersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServicePowersResponseUnmarshaller.Instance;

            return Invoke<GetContainerServicePowersResponse>(request, options);
        }



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
        public virtual Task<GetContainerServicePowersResponse> GetContainerServicePowersAsync(GetContainerServicePowersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServicePowersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServicePowersResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerServicePowersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContainerServices

        internal virtual GetContainerServicesResponse GetContainerServices(GetContainerServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServicesResponseUnmarshaller.Instance;

            return Invoke<GetContainerServicesResponse>(request, options);
        }



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
        public virtual Task<GetContainerServicesResponse> GetContainerServicesAsync(GetContainerServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContainerServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContainerServicesResponseUnmarshaller.Instance;

            return InvokeAsync<GetContainerServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCostEstimate

        internal virtual GetCostEstimateResponse GetCostEstimate(GetCostEstimateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostEstimateResponseUnmarshaller.Instance;

            return Invoke<GetCostEstimateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the cost estimate for a specified resource. A cost estimate
        /// will not generate for a resource that has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetCostEstimateResponse> GetCostEstimateAsync(GetCostEstimateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostEstimateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostEstimateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostEstimateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDisk

        internal virtual GetDiskResponse GetDisk(GetDiskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskResponseUnmarshaller.Instance;

            return Invoke<GetDiskResponse>(request, options);
        }



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
        public virtual Task<GetDiskResponse> GetDiskAsync(GetDiskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDisks

        internal virtual GetDisksResponse GetDisks(GetDisksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDisksResponseUnmarshaller.Instance;

            return Invoke<GetDisksResponse>(request, options);
        }



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
        public virtual Task<GetDisksResponse> GetDisksAsync(GetDisksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDisksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDisksResponseUnmarshaller.Instance;

            return InvokeAsync<GetDisksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDiskSnapshot

        internal virtual GetDiskSnapshotResponse GetDiskSnapshot(GetDiskSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetDiskSnapshotResponse>(request, options);
        }



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
        public virtual Task<GetDiskSnapshotResponse> GetDiskSnapshotAsync(GetDiskSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiskSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDiskSnapshots

        internal virtual GetDiskSnapshotsResponse GetDiskSnapshots(GetDiskSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetDiskSnapshotsResponse>(request, options);
        }



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
        public virtual Task<GetDiskSnapshotsResponse> GetDiskSnapshotsAsync(GetDiskSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiskSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiskSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDiskSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionBundles

        internal virtual GetDistributionBundlesResponse GetDistributionBundles(GetDistributionBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionBundlesResponseUnmarshaller.Instance;

            return Invoke<GetDistributionBundlesResponse>(request, options);
        }



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
        public virtual Task<GetDistributionBundlesResponse> GetDistributionBundlesAsync(GetDistributionBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionLatestCacheReset

        internal virtual GetDistributionLatestCacheResetResponse GetDistributionLatestCacheReset(GetDistributionLatestCacheResetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionLatestCacheResetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionLatestCacheResetResponseUnmarshaller.Instance;

            return Invoke<GetDistributionLatestCacheResetResponse>(request, options);
        }



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
        public virtual Task<GetDistributionLatestCacheResetResponse> GetDistributionLatestCacheResetAsync(GetDistributionLatestCacheResetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionLatestCacheResetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionLatestCacheResetResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionLatestCacheResetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistributionMetricData

        internal virtual GetDistributionMetricDataResponse GetDistributionMetricData(GetDistributionMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetDistributionMetricDataResponse>(request, options);
        }



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
        public virtual Task<GetDistributionMetricDataResponse> GetDistributionMetricDataAsync(GetDistributionMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDistributions

        internal virtual GetDistributionsResponse GetDistributions(GetDistributionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionsResponseUnmarshaller.Instance;

            return Invoke<GetDistributionsResponse>(request, options);
        }



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
        public virtual Task<GetDistributionsResponse> GetDistributionsAsync(GetDistributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDistributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDistributionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDistributionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomain

        internal virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }



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
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomains

        internal virtual GetDomainsResponse GetDomains(GetDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainsResponseUnmarshaller.Instance;

            return Invoke<GetDomainsResponse>(request, options);
        }



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
        public virtual Task<GetDomainsResponse> GetDomainsAsync(GetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExportSnapshotRecords

        internal virtual GetExportSnapshotRecordsResponse GetExportSnapshotRecords(GetExportSnapshotRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportSnapshotRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportSnapshotRecordsResponseUnmarshaller.Instance;

            return Invoke<GetExportSnapshotRecordsResponse>(request, options);
        }



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
        public virtual Task<GetExportSnapshotRecordsResponse> GetExportSnapshotRecordsAsync(GetExportSnapshotRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExportSnapshotRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportSnapshotRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportSnapshotRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstance

        internal virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceResponse>(request, options);
        }



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
        public virtual Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceAccessDetails

        internal virtual GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessDetailsResponse>(request, options);
        }



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
        public virtual Task<GetInstanceAccessDetailsResponse> GetInstanceAccessDetailsAsync(GetInstanceAccessDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceAccessDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceMetricData

        internal virtual GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetInstanceMetricDataResponse>(request, options);
        }



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
        public virtual Task<GetInstanceMetricDataResponse> GetInstanceMetricDataAsync(GetInstanceMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstancePortStates

        internal virtual GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancePortStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;

            return Invoke<GetInstancePortStatesResponse>(request, options);
        }



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
        public virtual Task<GetInstancePortStatesResponse> GetInstancePortStatesAsync(GetInstancePortStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancePortStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstancePortStatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstances

        internal virtual GetInstancesResponse GetInstances(GetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesResponseUnmarshaller.Instance;

            return Invoke<GetInstancesResponse>(request, options);
        }



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
        public virtual Task<GetInstancesResponse> GetInstancesAsync(GetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceSnapshot

        internal virtual GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotResponse>(request, options);
        }



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
        public virtual Task<GetInstanceSnapshotResponse> GetInstanceSnapshotAsync(GetInstanceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceSnapshots

        internal virtual GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotsResponse>(request, options);
        }



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
        public virtual Task<GetInstanceSnapshotsResponse> GetInstanceSnapshotsAsync(GetInstanceSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceState

        internal virtual GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceStateResponseUnmarshaller.Instance;

            return Invoke<GetInstanceStateResponse>(request, options);
        }



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
        public virtual Task<GetInstanceStateResponse> GetInstanceStateAsync(GetInstanceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceStateResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPair

        internal virtual GetKeyPairResponse GetKeyPair(GetKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairResponse>(request, options);
        }



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
        public virtual Task<GetKeyPairResponse> GetKeyPairAsync(GetKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPairs

        internal virtual GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairsResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairsResponse>(request, options);
        }



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
        public virtual Task<GetKeyPairsResponse> GetKeyPairsAsync(GetKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPairsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancer

        internal virtual GetLoadBalancerResponse GetLoadBalancer(GetLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerResponse>(request, options);
        }



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
        public virtual Task<GetLoadBalancerResponse> GetLoadBalancerAsync(GetLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancerMetricData

        internal virtual GetLoadBalancerMetricDataResponse GetLoadBalancerMetricData(GetLoadBalancerMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerMetricDataResponse>(request, options);
        }



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
        public virtual Task<GetLoadBalancerMetricDataResponse> GetLoadBalancerMetricDataAsync(GetLoadBalancerMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoadBalancerMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancers

        internal virtual GetLoadBalancersResponse GetLoadBalancers(GetLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancersResponse>(request, options);
        }



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
        public virtual Task<GetLoadBalancersResponse> GetLoadBalancersAsync(GetLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancerTlsCertificates

        internal virtual GetLoadBalancerTlsCertificatesResponse GetLoadBalancerTlsCertificates(GetLoadBalancerTlsCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerTlsCertificatesResponse>(request, options);
        }



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
        public virtual Task<GetLoadBalancerTlsCertificatesResponse> GetLoadBalancerTlsCertificatesAsync(GetLoadBalancerTlsCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoadBalancerTlsCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoadBalancerTlsPolicies

        internal virtual GetLoadBalancerTlsPoliciesResponse GetLoadBalancerTlsPolicies(GetLoadBalancerTlsPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsPoliciesResponseUnmarshaller.Instance;

            return Invoke<GetLoadBalancerTlsPoliciesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetLoadBalancerTlsPoliciesResponse> GetLoadBalancerTlsPoliciesAsync(GetLoadBalancerTlsPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLoadBalancerTlsPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoadBalancerTlsPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLoadBalancerTlsPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOperation

        internal virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationResponse>(request, options);
        }



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
        public virtual Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOperations

        internal virtual GetOperationsResponse GetOperations(GetOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsResponseUnmarshaller.Instance;

            return Invoke<GetOperationsResponse>(request, options);
        }



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
        public virtual Task<GetOperationsResponse> GetOperationsAsync(GetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOperationsForResource

        internal virtual GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;

            return Invoke<GetOperationsForResourceResponse>(request, options);
        }



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
        public virtual Task<GetOperationsForResourceResponse> GetOperationsForResourceAsync(GetOperationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetOperationsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRegions

        internal virtual GetRegionsResponse GetRegions(GetRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionsResponseUnmarshaller.Instance;

            return Invoke<GetRegionsResponse>(request, options);
        }



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
        public virtual Task<GetRegionsResponse> GetRegionsAsync(GetRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabase

        internal virtual GetRelationalDatabaseResponse GetRelationalDatabase(GetRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseResponse> GetRelationalDatabaseAsync(GetRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseBlueprints

        internal virtual GetRelationalDatabaseBlueprintsResponse GetRelationalDatabaseBlueprints(GetRelationalDatabaseBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBlueprintsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseBlueprintsResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseBlueprintsResponse> GetRelationalDatabaseBlueprintsAsync(GetRelationalDatabaseBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBlueprintsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseBlueprintsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseBundles

        internal virtual GetRelationalDatabaseBundlesResponse GetRelationalDatabaseBundles(GetRelationalDatabaseBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBundlesResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseBundlesResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseBundlesResponse> GetRelationalDatabaseBundlesAsync(GetRelationalDatabaseBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseEvents

        internal virtual GetRelationalDatabaseEventsResponse GetRelationalDatabaseEvents(GetRelationalDatabaseEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseEventsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseEventsResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseEventsResponse> GetRelationalDatabaseEventsAsync(GetRelationalDatabaseEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseEventsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseLogEvents

        internal virtual GetRelationalDatabaseLogEventsResponse GetRelationalDatabaseLogEvents(GetRelationalDatabaseLogEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogEventsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseLogEventsResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseLogEventsResponse> GetRelationalDatabaseLogEventsAsync(GetRelationalDatabaseLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseLogEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseLogStreams

        internal virtual GetRelationalDatabaseLogStreamsResponse GetRelationalDatabaseLogStreams(GetRelationalDatabaseLogStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogStreamsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseLogStreamsResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseLogStreamsResponse> GetRelationalDatabaseLogStreamsAsync(GetRelationalDatabaseLogStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseLogStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseLogStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseMasterUserPassword

        internal virtual GetRelationalDatabaseMasterUserPasswordResponse GetRelationalDatabaseMasterUserPassword(GetRelationalDatabaseMasterUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMasterUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMasterUserPasswordResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseMasterUserPasswordResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseMasterUserPasswordResponse> GetRelationalDatabaseMasterUserPasswordAsync(GetRelationalDatabaseMasterUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMasterUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMasterUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseMasterUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseMetricData

        internal virtual GetRelationalDatabaseMetricDataResponse GetRelationalDatabaseMetricData(GetRelationalDatabaseMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseMetricDataResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseMetricDataResponse> GetRelationalDatabaseMetricDataAsync(GetRelationalDatabaseMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseMetricDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseMetricDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseParameters

        internal virtual GetRelationalDatabaseParametersResponse GetRelationalDatabaseParameters(GetRelationalDatabaseParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseParametersResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseParametersResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseParametersResponse> GetRelationalDatabaseParametersAsync(GetRelationalDatabaseParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseParametersResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabases

        internal virtual GetRelationalDatabasesResponse GetRelationalDatabases(GetRelationalDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabasesResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabasesResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabasesResponse> GetRelationalDatabasesAsync(GetRelationalDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabasesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseSnapshot

        internal virtual GetRelationalDatabaseSnapshotResponse GetRelationalDatabaseSnapshot(GetRelationalDatabaseSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseSnapshotResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseSnapshotResponse> GetRelationalDatabaseSnapshotAsync(GetRelationalDatabaseSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRelationalDatabaseSnapshots

        internal virtual GetRelationalDatabaseSnapshotsResponse GetRelationalDatabaseSnapshots(GetRelationalDatabaseSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetRelationalDatabaseSnapshotsResponse>(request, options);
        }



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
        public virtual Task<GetRelationalDatabaseSnapshotsResponse> GetRelationalDatabaseSnapshotsAsync(GetRelationalDatabaseSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRelationalDatabaseSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelationalDatabaseSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRelationalDatabaseSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStaticIp

        internal virtual GetStaticIpResponse GetStaticIp(GetStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an Amazon Lightsail static IP.
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
        public virtual Task<GetStaticIpResponse> GetStaticIpAsync(GetStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpResponseUnmarshaller.Instance;

            return InvokeAsync<GetStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStaticIps

        internal virtual GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpsResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpsResponse>(request, options);
        }



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
        public virtual Task<GetStaticIpsResponse> GetStaticIpsAsync(GetStaticIpsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStaticIpsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStaticIpsResponseUnmarshaller.Instance;

            return InvokeAsync<GetStaticIpsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyPair

        internal virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairResponse>(request, options);
        }



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
        public virtual Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IsVpcPeered

        internal virtual IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsVpcPeeredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;

            return Invoke<IsVpcPeeredResponse>(request, options);
        }



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
        public virtual Task<IsVpcPeeredResponse> IsVpcPeeredAsync(IsVpcPeeredRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsVpcPeeredRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;

            return InvokeAsync<IsVpcPeeredResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OpenInstancePublicPorts

        internal virtual OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OpenInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<OpenInstancePublicPortsResponse>(request, options);
        }



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
        public virtual Task<OpenInstancePublicPortsResponse> OpenInstancePublicPortsAsync(OpenInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = OpenInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;

            return InvokeAsync<OpenInstancePublicPortsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PeerVpc

        internal virtual PeerVpcResponse PeerVpc(PeerVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PeerVpcResponseUnmarshaller.Instance;

            return Invoke<PeerVpcResponse>(request, options);
        }



        /// <summary>
        /// Peers the Lightsail VPC with the user's default VPC.
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
        public virtual Task<PeerVpcResponse> PeerVpcAsync(PeerVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PeerVpcResponseUnmarshaller.Instance;

            return InvokeAsync<PeerVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAlarm

        internal virtual PutAlarmResponse PutAlarm(PutAlarmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlarmResponseUnmarshaller.Instance;

            return Invoke<PutAlarmResponse>(request, options);
        }



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
        public virtual Task<PutAlarmResponse> PutAlarmAsync(PutAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlarmResponseUnmarshaller.Instance;

            return InvokeAsync<PutAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutInstancePublicPorts

        internal virtual PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<PutInstancePublicPortsResponse>(request, options);
        }



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
        public virtual Task<PutInstancePublicPortsResponse> PutInstancePublicPortsAsync(PutInstancePublicPortsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInstancePublicPortsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;

            return InvokeAsync<PutInstancePublicPortsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootInstance

        internal virtual RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootInstanceResponse>(request, options);
        }



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
        public virtual Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootRelationalDatabase

        internal virtual RebootRelationalDatabaseResponse RebootRelationalDatabase(RebootRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<RebootRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<RebootRelationalDatabaseResponse> RebootRelationalDatabaseAsync(RebootRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<RebootRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterContainerImage

        internal virtual RegisterContainerImageResponse RegisterContainerImage(RegisterContainerImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterContainerImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterContainerImageResponseUnmarshaller.Instance;

            return Invoke<RegisterContainerImageResponse>(request, options);
        }



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
        public virtual Task<RegisterContainerImageResponse> RegisterContainerImageAsync(RegisterContainerImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterContainerImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterContainerImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterContainerImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseStaticIp

        internal virtual ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;

            return Invoke<ReleaseStaticIpResponse>(request, options);
        }



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
        public virtual Task<ReleaseStaticIpResponse> ReleaseStaticIpAsync(ReleaseStaticIpRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseStaticIpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseStaticIpResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetDistributionCache

        internal virtual ResetDistributionCacheResponse ResetDistributionCache(ResetDistributionCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDistributionCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDistributionCacheResponseUnmarshaller.Instance;

            return Invoke<ResetDistributionCacheResponse>(request, options);
        }



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
        public virtual Task<ResetDistributionCacheResponse> ResetDistributionCacheAsync(ResetDistributionCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDistributionCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDistributionCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDistributionCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendContactMethodVerification

        internal virtual SendContactMethodVerificationResponse SendContactMethodVerification(SendContactMethodVerificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendContactMethodVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendContactMethodVerificationResponseUnmarshaller.Instance;

            return Invoke<SendContactMethodVerificationResponse>(request, options);
        }



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
        public virtual Task<SendContactMethodVerificationResponse> SendContactMethodVerificationAsync(SendContactMethodVerificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendContactMethodVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendContactMethodVerificationResponseUnmarshaller.Instance;

            return InvokeAsync<SendContactMethodVerificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIpAddressType

        internal virtual SetIpAddressTypeResponse SetIpAddressType(SetIpAddressTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIpAddressTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return Invoke<SetIpAddressTypeResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetIpAddressTypeResponse> SetIpAddressTypeAsync(SetIpAddressTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIpAddressTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return InvokeAsync<SetIpAddressTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetResourceAccessForBucket

        internal virtual SetResourceAccessForBucketResponse SetResourceAccessForBucket(SetResourceAccessForBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetResourceAccessForBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetResourceAccessForBucketResponseUnmarshaller.Instance;

            return Invoke<SetResourceAccessForBucketResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<SetResourceAccessForBucketResponse> SetResourceAccessForBucketAsync(SetResourceAccessForBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetResourceAccessForBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetResourceAccessForBucketResponseUnmarshaller.Instance;

            return InvokeAsync<SetResourceAccessForBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartGUISession

        internal virtual StartGUISessionResponse StartGUISession(StartGUISessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGUISessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGUISessionResponseUnmarshaller.Instance;

            return Invoke<StartGUISessionResponse>(request, options);
        }



        /// <summary>
        /// Initiates a graphical user interface (GUI) session that’s used to access a virtual
        /// computer’s operating system and application. The session will be active for 1 hour.
        /// Use this action to resume the session after it expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGUISession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartGUISessionResponse> StartGUISessionAsync(StartGUISessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGUISessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGUISessionResponseUnmarshaller.Instance;

            return InvokeAsync<StartGUISessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstance

        internal virtual StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return Invoke<StartInstanceResponse>(request, options);
        }



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
        public virtual Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartRelationalDatabase

        internal virtual StartRelationalDatabaseResponse StartRelationalDatabase(StartRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<StartRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<StartRelationalDatabaseResponse> StartRelationalDatabaseAsync(StartRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<StartRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopGUISession

        internal virtual StopGUISessionResponse StopGUISession(StopGUISessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGUISessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGUISessionResponseUnmarshaller.Instance;

            return Invoke<StopGUISessionResponse>(request, options);
        }



        /// <summary>
        /// Terminates a web-based NICE DCV session that’s used to access a virtual computer’s
        /// operating system or application. The session will close and any unsaved data will
        /// be lost.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGUISession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StopGUISessionResponse> StopGUISessionAsync(StopGUISessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGUISessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGUISessionResponseUnmarshaller.Instance;

            return InvokeAsync<StopGUISessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInstance

        internal virtual StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return Invoke<StopInstanceResponse>(request, options);
        }



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
        public virtual Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopRelationalDatabase

        internal virtual StopRelationalDatabaseResponse StopRelationalDatabase(StopRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<StopRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<StopRelationalDatabaseResponse> StopRelationalDatabaseAsync(StopRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<StopRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestAlarm

        internal virtual TestAlarmResponse TestAlarm(TestAlarmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAlarmResponseUnmarshaller.Instance;

            return Invoke<TestAlarmResponse>(request, options);
        }



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
        public virtual Task<TestAlarmResponse> TestAlarmAsync(TestAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestAlarmResponseUnmarshaller.Instance;

            return InvokeAsync<TestAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnpeerVpc

        internal virtual UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnpeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnpeerVpcResponseUnmarshaller.Instance;

            return Invoke<UnpeerVpcResponse>(request, options);
        }



        /// <summary>
        /// Unpeers the Lightsail VPC from the user's default VPC.
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
        public virtual Task<UnpeerVpcResponse> UnpeerVpcAsync(UnpeerVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnpeerVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnpeerVpcResponseUnmarshaller.Instance;

            return InvokeAsync<UnpeerVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBucket

        internal virtual UpdateBucketResponse UpdateBucket(UpdateBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBucketResponseUnmarshaller.Instance;

            return Invoke<UpdateBucketResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateBucketResponse> UpdateBucketAsync(UpdateBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBucketResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBucketBundle

        internal virtual UpdateBucketBundleResponse UpdateBucketBundle(UpdateBucketBundleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBucketBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBucketBundleResponseUnmarshaller.Instance;

            return Invoke<UpdateBucketBundleResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateBucketBundleResponse> UpdateBucketBundleAsync(UpdateBucketBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBucketBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBucketBundleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBucketBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContainerService

        internal virtual UpdateContainerServiceResponse UpdateContainerService(UpdateContainerServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateContainerServiceResponse>(request, options);
        }



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
        public virtual Task<UpdateContainerServiceResponse> UpdateContainerServiceAsync(UpdateContainerServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateContainerServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContainerServiceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateContainerServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDistribution

        internal virtual UpdateDistributionResponse UpdateDistribution(UpdateDistributionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Amazon Lightsail content delivery network (CDN) distribution.
        /// 
        ///  
        /// <para>
        /// Use this action to update the configuration of your existing distribution.
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
        public virtual Task<UpdateDistributionResponse> UpdateDistributionAsync(UpdateDistributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDistributionBundle

        internal virtual UpdateDistributionBundleResponse UpdateDistributionBundle(UpdateDistributionBundleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionBundleResponseUnmarshaller.Instance;

            return Invoke<UpdateDistributionBundleResponse>(request, options);
        }



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
        public virtual Task<UpdateDistributionBundleResponse> UpdateDistributionBundleAsync(UpdateDistributionBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDistributionBundleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDistributionBundleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDistributionBundleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainEntry

        internal virtual UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainEntryResponse>(request, options);
        }



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
        public virtual Task<UpdateDomainEntryResponse> UpdateDomainEntryAsync(UpdateDomainEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstanceMetadataOptions

        internal virtual UpdateInstanceMetadataOptionsResponse UpdateInstanceMetadataOptions(UpdateInstanceMetadataOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceMetadataOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceMetadataOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceMetadataOptionsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateInstanceMetadataOptionsResponse> UpdateInstanceMetadataOptionsAsync(UpdateInstanceMetadataOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceMetadataOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceMetadataOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInstanceMetadataOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoadBalancerAttribute

        internal virtual UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoadBalancerAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoadBalancerAttributeResponseUnmarshaller.Instance;

            return Invoke<UpdateLoadBalancerAttributeResponse>(request, options);
        }



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
        public virtual Task<UpdateLoadBalancerAttributeResponse> UpdateLoadBalancerAttributeAsync(UpdateLoadBalancerAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoadBalancerAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoadBalancerAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoadBalancerAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRelationalDatabase

        internal virtual UpdateRelationalDatabaseResponse UpdateRelationalDatabase(UpdateRelationalDatabaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseResponseUnmarshaller.Instance;

            return Invoke<UpdateRelationalDatabaseResponse>(request, options);
        }



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
        public virtual Task<UpdateRelationalDatabaseResponse> UpdateRelationalDatabaseAsync(UpdateRelationalDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRelationalDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRelationalDatabaseParameters

        internal virtual UpdateRelationalDatabaseParametersResponse UpdateRelationalDatabaseParameters(UpdateRelationalDatabaseParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelationalDatabaseParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelationalDatabaseParametersResponseUnmarshaller.Instance;

            return Invoke<UpdateRelationalDatabaseParametersResponse>(request, options);
        }



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
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

#if CORECLR
    
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

#endif

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

        internal virtual AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request)
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

        internal virtual AttachDiskResponse AttachDisk(AttachDiskRequest request)
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

        internal virtual AttachInstancesToLoadBalancerResponse AttachInstancesToLoadBalancer(AttachInstancesToLoadBalancerRequest request)
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

        internal virtual AttachLoadBalancerTlsCertificateResponse AttachLoadBalancerTlsCertificate(AttachLoadBalancerTlsCertificateRequest request)
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

        internal virtual AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request)
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

        internal virtual CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request)
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

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
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

        internal virtual CreateCloudFormationStackResponse CreateCloudFormationStack(CreateCloudFormationStackRequest request)
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

        internal virtual CreateDiskResponse CreateDisk(CreateDiskRequest request)
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

        internal virtual CreateDiskFromSnapshotResponse CreateDiskFromSnapshot(CreateDiskFromSnapshotRequest request)
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

        internal virtual CreateDiskSnapshotResponse CreateDiskSnapshot(CreateDiskSnapshotRequest request)
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

        internal virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
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

        internal virtual CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request)
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

        internal virtual CreateInstancesResponse CreateInstances(CreateInstancesRequest request)
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

        internal virtual CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request)
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

        internal virtual CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request)
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

        internal virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
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

        internal virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
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

        internal virtual CreateLoadBalancerTlsCertificateResponse CreateLoadBalancerTlsCertificate(CreateLoadBalancerTlsCertificateRequest request)
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

        internal virtual CreateRelationalDatabaseResponse CreateRelationalDatabase(CreateRelationalDatabaseRequest request)
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

        internal virtual CreateRelationalDatabaseFromSnapshotResponse CreateRelationalDatabaseFromSnapshot(CreateRelationalDatabaseFromSnapshotRequest request)
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

        internal virtual CreateRelationalDatabaseSnapshotResponse CreateRelationalDatabaseSnapshot(CreateRelationalDatabaseSnapshotRequest request)
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

        internal virtual DeleteDiskResponse DeleteDisk(DeleteDiskRequest request)
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

        internal virtual DeleteDiskSnapshotResponse DeleteDiskSnapshot(DeleteDiskSnapshotRequest request)
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

        internal virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
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

        internal virtual DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request)
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

        internal virtual DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
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

        internal virtual DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request)
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

        internal virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
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

        internal virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
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

        internal virtual DeleteLoadBalancerTlsCertificateResponse DeleteLoadBalancerTlsCertificate(DeleteLoadBalancerTlsCertificateRequest request)
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

        internal virtual DeleteRelationalDatabaseResponse DeleteRelationalDatabase(DeleteRelationalDatabaseRequest request)
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

        internal virtual DeleteRelationalDatabaseSnapshotResponse DeleteRelationalDatabaseSnapshot(DeleteRelationalDatabaseSnapshotRequest request)
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

        internal virtual DetachDiskResponse DetachDisk(DetachDiskRequest request)
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

        internal virtual DetachInstancesFromLoadBalancerResponse DetachInstancesFromLoadBalancer(DetachInstancesFromLoadBalancerRequest request)
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

        internal virtual DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request)
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

        internal virtual DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request)
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

        internal virtual ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
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

        internal virtual GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request)
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

        internal virtual GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request)
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

        internal virtual GetBundlesResponse GetBundles(GetBundlesRequest request)
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

        internal virtual GetCloudFormationStackRecordsResponse GetCloudFormationStackRecords(GetCloudFormationStackRecordsRequest request)
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

        internal virtual GetDiskResponse GetDisk(GetDiskRequest request)
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

        internal virtual GetDisksResponse GetDisks(GetDisksRequest request)
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

        internal virtual GetDiskSnapshotResponse GetDiskSnapshot(GetDiskSnapshotRequest request)
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

        internal virtual GetDiskSnapshotsResponse GetDiskSnapshots(GetDiskSnapshotsRequest request)
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

        internal virtual GetDomainResponse GetDomain(GetDomainRequest request)
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

        internal virtual GetDomainsResponse GetDomains(GetDomainsRequest request)
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

        internal virtual GetExportSnapshotRecordsResponse GetExportSnapshotRecords(GetExportSnapshotRecordsRequest request)
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

        internal virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
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

        internal virtual GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request)
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

        internal virtual GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request)
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

        internal virtual GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request)
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

        internal virtual GetInstancesResponse GetInstances(GetInstancesRequest request)
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

        internal virtual GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request)
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

        internal virtual GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request)
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

        internal virtual GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request)
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

        internal virtual GetKeyPairResponse GetKeyPair(GetKeyPairRequest request)
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

        internal virtual GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request)
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

        internal virtual GetLoadBalancerResponse GetLoadBalancer(GetLoadBalancerRequest request)
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

        internal virtual GetLoadBalancerMetricDataResponse GetLoadBalancerMetricData(GetLoadBalancerMetricDataRequest request)
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

        internal virtual GetLoadBalancersResponse GetLoadBalancers(GetLoadBalancersRequest request)
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

        internal virtual GetLoadBalancerTlsCertificatesResponse GetLoadBalancerTlsCertificates(GetLoadBalancerTlsCertificatesRequest request)
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

        internal virtual GetOperationResponse GetOperation(GetOperationRequest request)
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

        internal virtual GetOperationsResponse GetOperations(GetOperationsRequest request)
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

        internal virtual GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request)
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

        internal virtual GetRegionsResponse GetRegions(GetRegionsRequest request)
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

        internal virtual GetRelationalDatabaseResponse GetRelationalDatabase(GetRelationalDatabaseRequest request)
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

        internal virtual GetRelationalDatabaseBlueprintsResponse GetRelationalDatabaseBlueprints(GetRelationalDatabaseBlueprintsRequest request)
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

        internal virtual GetRelationalDatabaseBundlesResponse GetRelationalDatabaseBundles(GetRelationalDatabaseBundlesRequest request)
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

        internal virtual GetRelationalDatabaseEventsResponse GetRelationalDatabaseEvents(GetRelationalDatabaseEventsRequest request)
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

        internal virtual GetRelationalDatabaseLogEventsResponse GetRelationalDatabaseLogEvents(GetRelationalDatabaseLogEventsRequest request)
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

        internal virtual GetRelationalDatabaseLogStreamsResponse GetRelationalDatabaseLogStreams(GetRelationalDatabaseLogStreamsRequest request)
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

        internal virtual GetRelationalDatabaseMasterUserPasswordResponse GetRelationalDatabaseMasterUserPassword(GetRelationalDatabaseMasterUserPasswordRequest request)
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

        internal virtual GetRelationalDatabaseMetricDataResponse GetRelationalDatabaseMetricData(GetRelationalDatabaseMetricDataRequest request)
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

        internal virtual GetRelationalDatabaseParametersResponse GetRelationalDatabaseParameters(GetRelationalDatabaseParametersRequest request)
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

        internal virtual GetRelationalDatabasesResponse GetRelationalDatabases(GetRelationalDatabasesRequest request)
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

        internal virtual GetRelationalDatabaseSnapshotResponse GetRelationalDatabaseSnapshot(GetRelationalDatabaseSnapshotRequest request)
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

        internal virtual GetRelationalDatabaseSnapshotsResponse GetRelationalDatabaseSnapshots(GetRelationalDatabaseSnapshotsRequest request)
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

        internal virtual GetStaticIpResponse GetStaticIp(GetStaticIpRequest request)
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

        internal virtual GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request)
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

        internal virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
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

        internal virtual IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request)
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

        internal virtual OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request)
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

        internal virtual PeerVpcResponse PeerVpc(PeerVpcRequest request)
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

        internal virtual PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request)
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

        internal virtual RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
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

        internal virtual RebootRelationalDatabaseResponse RebootRelationalDatabase(RebootRelationalDatabaseRequest request)
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

        internal virtual ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request)
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

        internal virtual StartInstanceResponse StartInstance(StartInstanceRequest request)
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

        internal virtual StartRelationalDatabaseResponse StartRelationalDatabase(StartRelationalDatabaseRequest request)
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

        internal virtual StopInstanceResponse StopInstance(StopInstanceRequest request)
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

        internal virtual StopRelationalDatabaseResponse StopRelationalDatabase(StopRelationalDatabaseRequest request)
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

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
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

        internal virtual UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request)
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

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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

        internal virtual UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request)
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

        internal virtual UpdateLoadBalancerAttributeResponse UpdateLoadBalancerAttribute(UpdateLoadBalancerAttributeRequest request)
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

        internal virtual UpdateRelationalDatabaseResponse UpdateRelationalDatabase(UpdateRelationalDatabaseRequest request)
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

        internal virtual UpdateRelationalDatabaseParametersResponse UpdateRelationalDatabaseParameters(UpdateRelationalDatabaseParametersRequest request)
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
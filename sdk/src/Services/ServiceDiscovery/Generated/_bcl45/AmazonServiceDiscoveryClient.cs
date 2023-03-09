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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ServiceDiscovery.Model;
using Amazon.ServiceDiscovery.Model.Internal.MarshallTransformations;
using Amazon.ServiceDiscovery.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServiceDiscovery
{
    /// <summary>
    /// Implementation for accessing ServiceDiscovery
    ///
    /// Cloud Map 
    /// <para>
    /// With Cloud Map, you can configure public DNS, private DNS, or HTTP namespaces that
    /// your microservice applications run in. When an instance becomes available, you can
    /// call the Cloud Map API to register the instance with Cloud Map. For public or private
    /// DNS namespaces, Cloud Map automatically creates DNS records and an optional health
    /// check. Clients that submit public or private DNS queries, or HTTP requests, for the
    /// service receive an answer that contains up to eight healthy records. 
    /// </para>
    /// </summary>
    public partial class AmazonServiceDiscoveryClient : AmazonServiceClient, IAmazonServiceDiscovery
    {
        private static IServiceMetadata serviceMetadata = new AmazonServiceDiscoveryMetadata();
        private IServiceDiscoveryPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IServiceDiscoveryPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ServiceDiscoveryPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
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
        public AmazonServiceDiscoveryClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceDiscoveryConfig()) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
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
        public AmazonServiceDiscoveryClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServiceDiscoveryConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(AmazonServiceDiscoveryConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials)
            : this(credentials, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServiceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Credentials and an
        /// AmazonServiceDiscoveryClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(AWSCredentials credentials, AmazonServiceDiscoveryConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServiceDiscoveryConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServiceDiscoveryConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceDiscoveryConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServiceDiscoveryConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServiceDiscoveryClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServiceDiscoveryClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServiceDiscoveryClient Configuration Object</param>
        public AmazonServiceDiscoveryClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServiceDiscoveryConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonServiceDiscoveryEndpointResolver());
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


        #region  CreateHttpNamespace


        /// <summary>
        /// Creates an HTTP namespace. Service instances registered using an HTTP namespace can
        /// be discovered using a <code>DiscoverInstances</code> request but can't be discovered
        /// using DNS.
        /// 
        ///  
        /// <para>
        /// For the current quota on the number of namespaces that you can create using the same
        /// Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHttpNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateHttpNamespace">REST API Reference for CreateHttpNamespace Operation</seealso>
        public virtual CreateHttpNamespaceResponse CreateHttpNamespace(CreateHttpNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHttpNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHttpNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateHttpNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Creates an HTTP namespace. Service instances registered using an HTTP namespace can
        /// be discovered using a <code>DiscoverInstances</code> request but can't be discovered
        /// using DNS.
        /// 
        ///  
        /// <para>
        /// For the current quota on the number of namespaces that you can create using the same
        /// Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHttpNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateHttpNamespace">REST API Reference for CreateHttpNamespace Operation</seealso>
        public virtual Task<CreateHttpNamespaceResponse> CreateHttpNamespaceAsync(CreateHttpNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHttpNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHttpNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHttpNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePrivateDnsNamespace


        /// <summary>
        /// Creates a private namespace based on DNS, which is visible only inside a specified
        /// Amazon VPC. The namespace defines your service naming scheme. For example, if you
        /// name your namespace <code>example.com</code> and name your service <code>backend</code>,
        /// the resulting DNS name for the service is <code>backend.example.com</code>. Service
        /// instances that are registered using a private DNS namespace can be discovered using
        /// either a <code>DiscoverInstances</code> request or using DNS. For the current quota
        /// on the number of namespaces that you can create using the same Amazon Web Services
        /// account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        public virtual CreatePrivateDnsNamespaceResponse CreatePrivateDnsNamespace(CreatePrivateDnsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateDnsNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Creates a private namespace based on DNS, which is visible only inside a specified
        /// Amazon VPC. The namespace defines your service naming scheme. For example, if you
        /// name your namespace <code>example.com</code> and name your service <code>backend</code>,
        /// the resulting DNS name for the service is <code>backend.example.com</code>. Service
        /// instances that are registered using a private DNS namespace can be discovered using
        /// either a <code>DiscoverInstances</code> request or using DNS. For the current quota
        /// on the number of namespaces that you can create using the same Amazon Web Services
        /// account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateDnsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePrivateDnsNamespace">REST API Reference for CreatePrivateDnsNamespace Operation</seealso>
        public virtual Task<CreatePrivateDnsNamespaceResponse> CreatePrivateDnsNamespaceAsync(CreatePrivateDnsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateDnsNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePrivateDnsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicDnsNamespace


        /// <summary>
        /// Creates a public namespace based on DNS, which is visible on the internet. The namespace
        /// defines your service naming scheme. For example, if you name your namespace <code>example.com</code>
        /// and name your service <code>backend</code>, the resulting DNS name for the service
        /// is <code>backend.example.com</code>. You can discover instances that were registered
        /// with a public DNS namespace by using either a <code>DiscoverInstances</code> request
        /// or using DNS. For the current quota on the number of namespaces that you can create
        /// using the same Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// The <code>CreatePublicDnsNamespace</code> API operation is not supported in the Amazon
        /// Web Services GovCloud (US) Regions.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        public virtual CreatePublicDnsNamespaceResponse CreatePublicDnsNamespace(CreatePublicDnsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreatePublicDnsNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Creates a public namespace based on DNS, which is visible on the internet. The namespace
        /// defines your service naming scheme. For example, if you name your namespace <code>example.com</code>
        /// and name your service <code>backend</code>, the resulting DNS name for the service
        /// is <code>backend.example.com</code>. You can discover instances that were registered
        /// with a public DNS namespace by using either a <code>DiscoverInstances</code> request
        /// or using DNS. For the current quota on the number of namespaces that you can create
        /// using the same Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// The <code>CreatePublicDnsNamespace</code> API operation is not supported in the Amazon
        /// Web Services GovCloud (US) Regions.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicDnsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceAlreadyExistsException">
        /// The namespace that you're trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreatePublicDnsNamespace">REST API Reference for CreatePublicDnsNamespace Operation</seealso>
        public virtual Task<CreatePublicDnsNamespaceResponse> CreatePublicDnsNamespaceAsync(CreatePublicDnsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicDnsNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePublicDnsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates a service. This action defines the configuration for the following entities:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For public and private DNS namespaces, one of the following combinations of DNS records
        /// in Amazon Route 53:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>A</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>A</code> and <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SRV</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CNAME</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Optionally, a health check
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you create the service, you can submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request, and Cloud Map uses the values in the configuration to create the specified
        /// entities.
        /// </para>
        ///  
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceAlreadyExistsException">
        /// The service can't be created because a service with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }


        /// <summary>
        /// Creates a service. This action defines the configuration for the following entities:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For public and private DNS namespaces, one of the following combinations of DNS records
        /// in Amazon Route 53:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>A</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>A</code> and <code>AAAA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SRV</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CNAME</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Optionally, a health check
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you create the service, you can submit a <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_RegisterInstance.html">RegisterInstance</a>
        /// request, and Cloud Map uses the values in the configuration to create the specified
        /// entities.
        /// </para>
        ///  
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceAlreadyExistsException">
        /// The service can't be created because a service with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes a namespace from the current account. If the namespace still contains one
        /// or more services, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a namespace from the current account. If the namespace still contains one
        /// or more services, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a specified service. If the service still contains one or more registered
        /// instances, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified service. If the service still contains one or more registered
        /// instances, the request fails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstance


        /// <summary>
        /// Deletes the Amazon Route 53 DNS records and health check, if any, that Cloud Map created
        /// for the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual DeregisterInstanceResponse DeregisterInstance(DeregisterInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Amazon Route 53 DNS records and health check, if any, that Cloud Map created
        /// for the specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DeregisterInstance">REST API Reference for DeregisterInstance Operation</seealso>
        public virtual Task<DeregisterInstanceResponse> DeregisterInstanceAsync(DeregisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DiscoverInstances


        /// <summary>
        /// Discovers registered instances for a specified namespace and service. You can use
        /// <code>DiscoverInstances</code> to discover instances for any type of namespace. For
        /// public and private DNS namespaces, you can also use DNS queries to discover instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInstances service method.</param>
        /// 
        /// <returns>The response from the DiscoverInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DiscoverInstances">REST API Reference for DiscoverInstances Operation</seealso>
        public virtual DiscoverInstancesResponse DiscoverInstances(DiscoverInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DiscoverInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInstancesResponseUnmarshaller.Instance;

            return Invoke<DiscoverInstancesResponse>(request, options);
        }


        /// <summary>
        /// Discovers registered instances for a specified namespace and service. You can use
        /// <code>DiscoverInstances</code> to discover instances for any type of namespace. For
        /// public and private DNS namespaces, you can also use DNS queries to discover instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DiscoverInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/DiscoverInstances">REST API Reference for DiscoverInstances Operation</seealso>
        public virtual Task<DiscoverInstancesResponse> DiscoverInstancesAsync(DiscoverInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DiscoverInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DiscoverInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstance


        /// <summary>
        /// Gets information about a specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specified instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public virtual Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstancesHealthStatus


        /// <summary>
        /// Gets the current health status (<code>Healthy</code>, <code>Unhealthy</code>, or <code>Unknown</code>)
        /// of one or more instances that are associated with a specified service.
        /// 
        ///  <note> 
        /// <para>
        /// There's a brief delay between when you register an instance and when the health status
        /// for the instance is available. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstancesHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        public virtual GetInstancesHealthStatusResponse GetInstancesHealthStatus(GetInstancesHealthStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesHealthStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesHealthStatusResponseUnmarshaller.Instance;

            return Invoke<GetInstancesHealthStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the current health status (<code>Healthy</code>, <code>Unhealthy</code>, or <code>Unknown</code>)
        /// of one or more instances that are associated with a specified service.
        /// 
        ///  <note> 
        /// <para>
        /// There's a brief delay between when you register an instance and when the health status
        /// for the instance is available. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancesHealthStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInstancesHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetInstancesHealthStatus">REST API Reference for GetInstancesHealthStatus Operation</seealso>
        public virtual Task<GetInstancesHealthStatusResponse> GetInstancesHealthStatusAsync(GetInstancesHealthStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstancesHealthStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstancesHealthStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInstancesHealthStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNamespace


        /// <summary>
        /// Gets information about a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOperation


        /// <summary>
        /// Gets information about any operation that returns an operation ID in the response,
        /// such as a <code>CreateService</code> request.
        /// 
        ///  <note> 
        /// <para>
        /// To get a list of operations that match specified criteria, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListOperations.html">ListOperations</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.OperationNotFoundException">
        /// No operation exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationResponse>(request, options);
        }


        /// <summary>
        /// Gets information about any operation that returns an operation ID in the response,
        /// such as a <code>CreateService</code> request.
        /// 
        ///  <note> 
        /// <para>
        /// To get a list of operations that match specified criteria, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_ListOperations.html">ListOperations</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.OperationNotFoundException">
        /// No operation exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public virtual Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetService


        /// <summary>
        /// Gets the settings for a specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }


        /// <summary>
        /// Gets the settings for a specified service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/GetService">REST API Reference for GetService Operation</seealso>
        public virtual Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstances


        /// <summary>
        /// Lists summary information about the instances that you registered by using a specified
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }


        /// <summary>
        /// Lists summary information about the instances that you registered by using a specified
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNamespaces


        /// <summary>
        /// Lists summary information about the namespaces that were created by the current Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }


        /// <summary>
        /// Lists summary information about the namespaces that were created by the current Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListNamespacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOperations


        /// <summary>
        /// Lists operations that match the criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;

            return Invoke<ListOperationsResponse>(request, options);
        }


        /// <summary>
        /// Lists operations that match the criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOperations service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListOperations">REST API Reference for ListOperations Operation</seealso>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists summary information for all the services that are associated with one or more
        /// specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }


        /// <summary>
        /// Lists summary information for all the services that are associated with one or more
        /// specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstance


        /// <summary>
        /// Creates or updates one or more records and, optionally, creates a health check based
        /// on the settings in a specified service. When you submit a <code>RegisterInstance</code>
        /// request, the following occurs:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For each DNS record that you define in the service that's specified by <code>ServiceId</code>,
        /// a record is created or updated in the hosted zone that's associated with the corresponding
        /// namespace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service includes <code>HealthCheckConfig</code>, a health check is created
        /// based on the settings in the health check configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The health check, if any, is associated with each of the new or updated records.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// One <code>RegisterInstance</code> request must complete before you can submit another
        /// request and specify the same service ID and instance ID.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html">CreateService</a>.
        /// </para>
        ///  
        /// <para>
        /// When Cloud Map receives a DNS query for the specified DNS name, it returns the applicable
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>If the health check is healthy</b>: returns all the records
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If the health check is unhealthy</b>: returns the applicable value for the last
        /// healthy instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you didn't specify a health check configuration</b>: returns all the records
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual RegisterInstanceResponse RegisterInstance(RegisterInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterInstanceResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates one or more records and, optionally, creates a health check based
        /// on the settings in a specified service. When you submit a <code>RegisterInstance</code>
        /// request, the following occurs:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For each DNS record that you define in the service that's specified by <code>ServiceId</code>,
        /// a record is created or updated in the hosted zone that's associated with the corresponding
        /// namespace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service includes <code>HealthCheckConfig</code>, a health check is created
        /// based on the settings in the health check configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The health check, if any, is associated with each of the new or updated records.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// One <code>RegisterInstance</code> request must complete before you can submit another
        /// request and specify the same service ID and instance ID.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html">CreateService</a>.
        /// </para>
        ///  
        /// <para>
        /// When Cloud Map receives a DNS query for the specified DNS name, it returns the applicable
        /// value:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>If the health check is healthy</b>: returns all the records
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If the health check is unhealthy</b>: returns the applicable value for the last
        /// healthy instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you didn't specify a health check configuration</b>: returns all the records
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the current quota on the number of instances that you can register using the same
        /// namespace and using the same service, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
        /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterInstance service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceLimitExceededException">
        /// The resource can't be created because you've reached the quota on the number of resources.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/RegisterInstance">REST API Reference for RegisterInstance Operation</seealso>
        public virtual Task<RegisterInstanceResponse> RegisterInstanceAsync(RegisterInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.TooManyTagsException">
        /// The list of tags on the resource is over the quota. The maximum number of tags that
        /// can be applied to a resource is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceNotFoundException">
        /// The operation can't be completed because the resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHttpNamespace


        /// <summary>
        /// Updates an HTTP namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHttpNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateHttpNamespace">REST API Reference for UpdateHttpNamespace Operation</seealso>
        public virtual UpdateHttpNamespaceResponse UpdateHttpNamespace(UpdateHttpNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHttpNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHttpNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateHttpNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Updates an HTTP namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHttpNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHttpNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateHttpNamespace">REST API Reference for UpdateHttpNamespace Operation</seealso>
        public virtual Task<UpdateHttpNamespaceResponse> UpdateHttpNamespaceAsync(UpdateHttpNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHttpNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHttpNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateHttpNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateInstanceCustomHealthStatus


        /// <summary>
        /// Submits a request to change the health status of a custom health check to healthy
        /// or unhealthy.
        /// 
        ///  
        /// <para>
        /// You can use <code>UpdateInstanceCustomHealthStatus</code> to change the status only
        /// for custom health checks, which you define using <code>HealthCheckCustomConfig</code>
        /// when you create a service. You can't use it to change the status for Route 53 health
        /// checks, which you define using <code>HealthCheckConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_HealthCheckCustomConfig.html">HealthCheckCustomConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateInstanceCustomHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.CustomHealthNotFoundException">
        /// The health check for the instance that's specified by <code>ServiceId</code> and <code>InstanceId</code>
        /// isn't a custom health check.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        public virtual UpdateInstanceCustomHealthStatusResponse UpdateInstanceCustomHealthStatus(UpdateInstanceCustomHealthStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceCustomHealthStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceCustomHealthStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateInstanceCustomHealthStatusResponse>(request, options);
        }


        /// <summary>
        /// Submits a request to change the health status of a custom health check to healthy
        /// or unhealthy.
        /// 
        ///  
        /// <para>
        /// You can use <code>UpdateInstanceCustomHealthStatus</code> to change the status only
        /// for custom health checks, which you define using <code>HealthCheckCustomConfig</code>
        /// when you create a service. You can't use it to change the status for Route 53 health
        /// checks, which you define using <code>HealthCheckConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_HealthCheckCustomConfig.html">HealthCheckCustomConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInstanceCustomHealthStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInstanceCustomHealthStatus service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.CustomHealthNotFoundException">
        /// The health check for the instance that's specified by <code>ServiceId</code> and <code>InstanceId</code>
        /// isn't a custom health check.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InstanceNotFoundException">
        /// No instance exists with the specified ID, or the instance was recently registered,
        /// and information about the instance hasn't propagated yet.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateInstanceCustomHealthStatus">REST API Reference for UpdateInstanceCustomHealthStatus Operation</seealso>
        public virtual Task<UpdateInstanceCustomHealthStatusResponse> UpdateInstanceCustomHealthStatusAsync(UpdateInstanceCustomHealthStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInstanceCustomHealthStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInstanceCustomHealthStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateInstanceCustomHealthStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePrivateDnsNamespace


        /// <summary>
        /// Updates a private DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePrivateDnsNamespace">REST API Reference for UpdatePrivateDnsNamespace Operation</seealso>
        public virtual UpdatePrivateDnsNamespaceResponse UpdatePrivateDnsNamespace(UpdatePrivateDnsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrivateDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdatePrivateDnsNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Updates a private DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateDnsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivateDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePrivateDnsNamespace">REST API Reference for UpdatePrivateDnsNamespace Operation</seealso>
        public virtual Task<UpdatePrivateDnsNamespaceResponse> UpdatePrivateDnsNamespaceAsync(UpdatePrivateDnsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrivateDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateDnsNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePrivateDnsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePublicDnsNamespace


        /// <summary>
        /// Updates a public DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicDnsNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePublicDnsNamespace">REST API Reference for UpdatePublicDnsNamespace Operation</seealso>
        public virtual UpdatePublicDnsNamespaceResponse UpdatePublicDnsNamespace(UpdatePublicDnsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicDnsNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdatePublicDnsNamespaceResponse>(request, options);
        }


        /// <summary>
        /// Updates a public DNS namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePublicDnsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePublicDnsNamespace service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.NamespaceNotFoundException">
        /// No namespace exists with the specified ID.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ResourceInUseException">
        /// The specified resource can't be deleted because it contains other resources. For example,
        /// you can't delete a service that contains any instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdatePublicDnsNamespace">REST API Reference for UpdatePublicDnsNamespace Operation</seealso>
        public virtual Task<UpdatePublicDnsNamespaceResponse> UpdatePublicDnsNamespaceAsync(UpdatePublicDnsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePublicDnsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePublicDnsNamespaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePublicDnsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Submits a request to perform the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the TTL setting for existing <code>DnsRecords</code> configurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add, update, or delete <code>HealthCheckConfig</code> for a specified service
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't add, update, or delete a <code>HealthCheckCustomConfig</code> configuration.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For public and private DNS namespaces, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you omit any existing <code>DnsRecords</code> or <code>HealthCheckConfig</code>
        /// configurations from an <code>UpdateService</code> request, the configurations are
        /// deleted from the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you omit an existing <code>HealthCheckCustomConfig</code> configuration from an
        /// <code>UpdateService</code> request, the configuration isn't deleted from the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you update settings for a service, Cloud Map also updates the corresponding settings
        /// in all the records and health checks that were created by using the specified service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }


        /// <summary>
        /// Submits a request to perform the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Update the TTL setting for existing <code>DnsRecords</code> configurations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add, update, or delete <code>HealthCheckConfig</code> for a specified service
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't add, update, or delete a <code>HealthCheckCustomConfig</code> configuration.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        /// For public and private DNS namespaces, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you omit any existing <code>DnsRecords</code> or <code>HealthCheckConfig</code>
        /// configurations from an <code>UpdateService</code> request, the configurations are
        /// deleted from the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you omit an existing <code>HealthCheckCustomConfig</code> configuration from an
        /// <code>UpdateService</code> request, the configuration isn't deleted from the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you update settings for a service, Cloud Map also updates the corresponding settings
        /// in all the records and health checks that were created by using the specified service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by ServiceDiscovery.</returns>
        /// <exception cref="Amazon.ServiceDiscovery.Model.DuplicateRequestException">
        /// The operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.InvalidInputException">
        /// One or more specified values aren't valid. For example, a required value might be
        /// missing, a numeric value might be outside the allowed range, or a string value might
        /// exceed length constraints.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.RequestLimitExceededException">
        /// The operation can't be completed because you've reached the quota for the number of
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/throttling.html">Cloud
        /// Map API request throttling quota</a> in the <i>Cloud Map Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ServiceDiscovery.Model.ServiceNotFoundException">
        /// No service exists with the specified ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicediscovery-2017-03-14/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Elasticsearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Elasticsearch
{
    /// <summary>
    /// Implementation for accessing Elasticsearch
    ///
    /// Amazon Elasticsearch Configuration Service 
    /// <para>
    /// Use the Amazon Elasticsearch configuration API to create, configure, and manage Elasticsearch
    /// domains.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticsearch-service-regions"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticsearchClient : AmazonServiceClient, IAmazonElasticsearch
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticsearchMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        public AmazonElasticsearchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        public AmazonElasticsearchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AmazonElasticsearchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticsearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials and an
        /// AmazonElasticsearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, AmazonElasticsearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticsearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticsearchConfig clientConfig)
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


        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelElasticsearchServiceSoftwareUpdate

        internal virtual CancelElasticsearchServiceSoftwareUpdateResponse CancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<CancelElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CancelElasticsearchServiceSoftwareUpdateResponse> CancelElasticsearchServiceSoftwareUpdateAsync(CancelElasticsearchServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<CancelElasticsearchServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateElasticsearchDomain

        internal virtual CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<CreateElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateElasticsearchDomainResponse> CreateElasticsearchDomainAsync(CreateElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteElasticsearchDomain

        internal virtual DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteElasticsearchDomainResponse> DeleteElasticsearchDomainAsync(DeleteElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteElasticsearchServiceRole

        internal virtual DeleteElasticsearchServiceRoleResponse DeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchServiceRoleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteElasticsearchServiceRoleResponse> DeleteElasticsearchServiceRoleAsync(DeleteElasticsearchServiceRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteElasticsearchServiceRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomain

        internal virtual DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeElasticsearchDomainResponse> DescribeElasticsearchDomainAsync(DescribeElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomainConfig

        internal virtual DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeElasticsearchDomainConfigResponse> DescribeElasticsearchDomainConfigAsync(DescribeElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomains

        internal virtual DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeElasticsearchDomainsResponse> DescribeElasticsearchDomainsAsync(DescribeElasticsearchDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchInstanceTypeLimits

        internal virtual DescribeElasticsearchInstanceTypeLimitsResponse DescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchInstanceTypeLimitsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeElasticsearchInstanceTypeLimitsResponse> DescribeElasticsearchInstanceTypeLimitsAsync(DescribeElasticsearchInstanceTypeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchInstanceTypeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstanceOfferings

        internal virtual DescribeReservedElasticsearchInstanceOfferingsResponse DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstanceOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeReservedElasticsearchInstanceOfferingsResponse> DescribeReservedElasticsearchInstanceOfferingsAsync(DescribeReservedElasticsearchInstanceOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedElasticsearchInstanceOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstances

        internal virtual DescribeReservedElasticsearchInstancesResponse DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DescribeReservedElasticsearchInstancesResponse> DescribeReservedElasticsearchInstancesAsync(DescribeReservedElasticsearchInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedElasticsearchInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCompatibleElasticsearchVersions

        internal virtual GetCompatibleElasticsearchVersionsResponse GetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleElasticsearchVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCompatibleElasticsearchVersionsResponse> GetCompatibleElasticsearchVersionsAsync(GetCompatibleElasticsearchVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCompatibleElasticsearchVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeHistory

        internal virtual GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUpgradeHistoryResponse> GetUpgradeHistoryAsync(GetUpgradeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetUpgradeHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUpgradeStatus

        internal virtual GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(GetUpgradeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetUpgradeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainNames

        internal virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListElasticsearchInstanceTypes

        internal virtual ListElasticsearchInstanceTypesResponse ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchInstanceTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListElasticsearchInstanceTypesResponse> ListElasticsearchInstanceTypesAsync(ListElasticsearchInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListElasticsearchInstanceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListElasticsearchVersions

        internal virtual ListElasticsearchVersionsResponse ListElasticsearchVersions(ListElasticsearchVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListElasticsearchVersionsResponse> ListElasticsearchVersionsAsync(ListElasticsearchVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListElasticsearchVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedElasticsearchInstanceOffering

        internal virtual PurchaseReservedElasticsearchInstanceOfferingResponse PurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedElasticsearchInstanceOfferingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PurchaseReservedElasticsearchInstanceOfferingResponse> PurchaseReservedElasticsearchInstanceOfferingAsync(PurchaseReservedElasticsearchInstanceOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedElasticsearchInstanceOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartElasticsearchServiceSoftwareUpdate

        internal virtual StartElasticsearchServiceSoftwareUpdateResponse StartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<StartElasticsearchServiceSoftwareUpdateResponse> StartElasticsearchServiceSoftwareUpdateAsync(StartElasticsearchServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartElasticsearchServiceSoftwareUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticsearchDomainConfig

        internal virtual UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticsearchDomainConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateElasticsearchDomainConfigResponse> UpdateElasticsearchDomainConfigAsync(UpdateElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateElasticsearchDomainConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpgradeElasticsearchDomain

        internal virtual UpgradeElasticsearchDomainResponse UpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeElasticsearchDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpgradeElasticsearchDomainResponse> UpgradeElasticsearchDomainAsync(UpgradeElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpgradeElasticsearchDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
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

using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
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
        #region Constructors

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


        /// <summary>
        /// Attaches tags to an existing Elasticsearch domain. Tags are a set of case-sensitive
        /// key value pairs. An Elasticsearch domain may have up to 10 tags. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon Elasticsearch Service Domains for more information.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateElasticsearchDomain


        /// <summary>
        /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the CreateElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request)
        {
            var marshaller = new CreateElasticsearchDomainRequestMarshaller();
            var unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<CreateElasticsearchDomainRequest,CreateElasticsearchDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateElasticsearchDomainResponse> CreateElasticsearchDomainAsync(CreateElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateElasticsearchDomainRequestMarshaller();
            var unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateElasticsearchDomainRequest,CreateElasticsearchDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteElasticsearchDomain


        /// <summary>
        /// Permanently deletes the specified Elasticsearch domain and all of its data. Once a
        /// domain is deleted, it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request)
        {
            var marshaller = new DeleteElasticsearchDomainRequestMarshaller();
            var unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchDomainRequest,DeleteElasticsearchDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteElasticsearchDomainResponse> DeleteElasticsearchDomainAsync(DeleteElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteElasticsearchDomainRequestMarshaller();
            var unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteElasticsearchDomainRequest,DeleteElasticsearchDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomain


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domain,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request)
        {
            var marshaller = new DescribeElasticsearchDomainRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainRequest,DescribeElasticsearchDomainResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeElasticsearchDomainResponse> DescribeElasticsearchDomainAsync(DescribeElasticsearchDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticsearchDomainRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainRequest,DescribeElasticsearchDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomainConfig


        /// <summary>
        /// Provides cluster configuration information about the specified Elasticsearch domain,
        /// such as the state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request)
        {
            var marshaller = new DescribeElasticsearchDomainConfigRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainConfigRequest,DescribeElasticsearchDomainConfigResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeElasticsearchDomainConfigResponse> DescribeElasticsearchDomainConfigAsync(DescribeElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticsearchDomainConfigRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainConfigRequest,DescribeElasticsearchDomainConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticsearchDomains


        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domains,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomains service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request)
        {
            var marshaller = new DescribeElasticsearchDomainsRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainsRequest,DescribeElasticsearchDomainsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeElasticsearchDomainsResponse> DescribeElasticsearchDomainsAsync(DescribeElasticsearchDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeElasticsearchDomainsRequestMarshaller();
            var unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticsearchDomainsRequest,DescribeElasticsearchDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomainNames


        /// <summary>
        /// Returns the name of all Elasticsearch domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainNamesRequestMarshaller();
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns all tags for the given Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsRequestMarshaller();
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsRequest,ListTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified set of tags from the specified Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateElasticsearchDomainConfig


        /// <summary>
        /// Modifies the cluster configuration of the specified Elasticsearch domain, setting
        /// as setting the instance type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request)
        {
            var marshaller = new UpdateElasticsearchDomainConfigRequestMarshaller();
            var unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticsearchDomainConfigRequest,UpdateElasticsearchDomainConfigResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateElasticsearchDomainConfigResponse> UpdateElasticsearchDomainConfigAsync(UpdateElasticsearchDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateElasticsearchDomainConfigRequestMarshaller();
            var unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateElasticsearchDomainConfigRequest,UpdateElasticsearchDomainConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
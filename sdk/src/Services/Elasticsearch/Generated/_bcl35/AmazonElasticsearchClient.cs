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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Elasticsearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Elasticsearch
{
    /// <summary>
    /// <para>Implementation for accessing Elasticsearch</para>
    ///
    /// Amazon Elasticsearch Configuration Service 
    /// <para>
    /// Use the Amazon Elasticsearch Configuration API to create, configure, and manage Elasticsearch
    /// domains.
    /// </para>
    ///  
    /// <para>
    /// For sample code that uses the Configuration API, see the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-configuration-samples.html">Amazon
    /// Elasticsearch Service Developer Guide</a>. The guide also contains <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-request-signing.html">sample
    /// code for sending signed HTTP requests to the Elasticsearch APIs</a>.
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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IElasticsearchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticsearchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticsearchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticsearchEndpointResolver());
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


        #region  AcceptInboundCrossClusterSearchConnection

        /// <summary>
        /// Allows the destination domain owner to accept an inbound cross-cluster search connection
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        public virtual AcceptInboundCrossClusterSearchConnectionResponse AcceptInboundCrossClusterSearchConnection(AcceptInboundCrossClusterSearchConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptInboundCrossClusterSearchConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        public virtual IAsyncResult BeginAcceptInboundCrossClusterSearchConnection(AcceptInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  AcceptInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AcceptInboundCrossClusterSearchConnection">REST API Reference for AcceptInboundCrossClusterSearchConnection Operation</seealso>
        public virtual AcceptInboundCrossClusterSearchConnectionResponse EndAcceptInboundCrossClusterSearchConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptInboundCrossClusterSearchConnectionResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePackage

        /// <summary>
        /// Associates a package with an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        public virtual AssociatePackageResponse AssociatePackage(AssociatePackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePackageResponseUnmarshaller.Instance;

            return Invoke<AssociatePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        public virtual IAsyncResult BeginAssociatePackage(AssociatePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePackage.</param>
        /// 
        /// <returns>Returns a  AssociatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        public virtual AssociatePackageResponse EndAssociatePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeVpcEndpointAccess

        /// <summary>
        /// Provides access to an Amazon OpenSearch Service domain through the use of an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        public virtual AuthorizeVpcEndpointAccessResponse AuthorizeVpcEndpointAccess(AuthorizeVpcEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeVpcEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeVpcEndpointAccess(AuthorizeVpcEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeVpcEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        public virtual AuthorizeVpcEndpointAccessResponse EndAuthorizeVpcEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeVpcEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelDomainConfigChange

        /// <summary>
        /// Cancels a pending configuration change on an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainConfigChange service method.</param>
        /// 
        /// <returns>The response from the CancelDomainConfigChange service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelDomainConfigChange">REST API Reference for CancelDomainConfigChange Operation</seealso>
        public virtual CancelDomainConfigChangeResponse CancelDomainConfigChange(CancelDomainConfigChangeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDomainConfigChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainConfigChangeResponseUnmarshaller.Instance;

            return Invoke<CancelDomainConfigChangeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDomainConfigChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainConfigChange operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDomainConfigChange
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelDomainConfigChange">REST API Reference for CancelDomainConfigChange Operation</seealso>
        public virtual IAsyncResult BeginCancelDomainConfigChange(CancelDomainConfigChangeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDomainConfigChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDomainConfigChangeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDomainConfigChange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDomainConfigChange.</param>
        /// 
        /// <returns>Returns a  CancelDomainConfigChangeResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelDomainConfigChange">REST API Reference for CancelDomainConfigChange Operation</seealso>
        public virtual CancelDomainConfigChangeResponse EndCancelDomainConfigChange(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDomainConfigChangeResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelElasticsearchServiceSoftwareUpdate

        /// <summary>
        /// Cancels a scheduled service software update for an Amazon ES domain. You can only
        /// perform this operation before the <c>AutomatedUpdateDate</c> and when the <c>UpdateStatus</c>
        /// is in the <c>PENDING_UPDATE</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the CancelElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual CancelElasticsearchServiceSoftwareUpdateResponse CancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<CancelElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual IAsyncResult BeginCancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  CancelElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CancelElasticsearchServiceSoftwareUpdate">REST API Reference for CancelElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual CancelElasticsearchServiceSoftwareUpdateResponse EndCancelElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelElasticsearchServiceSoftwareUpdateResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        public virtual CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<CreateElasticsearchDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateElasticsearchDomain(CreateElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  CreateElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateElasticsearchDomain">REST API Reference for CreateElasticsearchDomain Operation</seealso>
        public virtual CreateElasticsearchDomainResponse EndCreateElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOutboundCrossClusterSearchConnection

        /// <summary>
        /// Creates a new cross-cluster search connection from a source domain to a destination
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the CreateOutboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual CreateOutboundCrossClusterSearchConnectionResponse CreateOutboundCrossClusterSearchConnection(CreateOutboundCrossClusterSearchConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOutboundCrossClusterSearchConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOutboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateOutboundCrossClusterSearchConnection(CreateOutboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOutboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOutboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOutboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  CreateOutboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateOutboundCrossClusterSearchConnection">REST API Reference for CreateOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual CreateOutboundCrossClusterSearchConnectionResponse EndCreateOutboundCrossClusterSearchConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOutboundCrossClusterSearchConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePackage

        /// <summary>
        /// Create a package for use with Amazon ES domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual CreatePackageResponse CreatePackage(CreatePackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return Invoke<CreatePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual IAsyncResult BeginCreatePackage(CreatePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePackage.</param>
        /// 
        /// <returns>Returns a  CreatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        public virtual CreatePackageResponse EndCreatePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        /// <summary>
        /// Creates an Amazon OpenSearch Service-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcEndpointResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        public virtual DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchDomain">REST API Reference for DeleteElasticsearchDomain Operation</seealso>
        public virtual DeleteElasticsearchDomainResponse EndDeleteElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteElasticsearchServiceRole

        /// <summary>
        /// Deletes the service-linked role that Elasticsearch Service uses to manage and maintain
        /// VPC domains. Role deletion will fail if any existing VPC domains use the role. You
        /// must delete any such Elasticsearch domains before deleting the role. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-enabling-slr"
        /// target="_blank">Deleting Elasticsearch Service Role</a> in <i>VPC Endpoints for Amazon
        /// Elasticsearch Service Domains</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchServiceRole service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        public virtual DeleteElasticsearchServiceRoleResponse DeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchServiceRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchServiceRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        public virtual IAsyncResult BeginDeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchServiceRole.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchServiceRoleResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteElasticsearchServiceRole">REST API Reference for DeleteElasticsearchServiceRole Operation</seealso>
        public virtual DeleteElasticsearchServiceRoleResponse EndDeleteElasticsearchServiceRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteElasticsearchServiceRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInboundCrossClusterSearchConnection

        /// <summary>
        /// Allows the destination domain owner to delete an existing inbound cross-cluster search
        /// connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        public virtual DeleteInboundCrossClusterSearchConnectionResponse DeleteInboundCrossClusterSearchConnection(DeleteInboundCrossClusterSearchConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteInboundCrossClusterSearchConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteInboundCrossClusterSearchConnection(DeleteInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  DeleteInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteInboundCrossClusterSearchConnection">REST API Reference for DeleteInboundCrossClusterSearchConnection Operation</seealso>
        public virtual DeleteInboundCrossClusterSearchConnectionResponse EndDeleteInboundCrossClusterSearchConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInboundCrossClusterSearchConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOutboundCrossClusterSearchConnection

        /// <summary>
        /// Allows the source domain owner to delete an existing outbound cross-cluster search
        /// connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteOutboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual DeleteOutboundCrossClusterSearchConnectionResponse DeleteOutboundCrossClusterSearchConnection(DeleteOutboundCrossClusterSearchConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOutboundCrossClusterSearchConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteOutboundCrossClusterSearchConnection(DeleteOutboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOutboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  DeleteOutboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteOutboundCrossClusterSearchConnection">REST API Reference for DeleteOutboundCrossClusterSearchConnection Operation</seealso>
        public virtual DeleteOutboundCrossClusterSearchConnectionResponse EndDeleteOutboundCrossClusterSearchConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOutboundCrossClusterSearchConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePackage

        /// <summary>
        /// Delete the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual DeletePackageResponse DeletePackage(DeletePackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return Invoke<DeletePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual IAsyncResult BeginDeletePackage(DeletePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePackage.</param>
        /// 
        /// <returns>Returns a  DeletePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        public virtual DeletePackageResponse EndDeletePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcEndpoint

        /// <summary>
        /// Deletes an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcEndpoint(DeleteVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual DeleteVpcEndpointResponse EndDeleteVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomainAutoTunes

        /// <summary>
        /// Provides scheduled Auto-Tune action details for the Elasticsearch domain, such as
        /// Auto-Tune action type, description, severity, and scheduled date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainAutoTunes service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        public virtual DescribeDomainAutoTunesResponse DescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainAutoTunesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainAutoTunesResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainAutoTunesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainAutoTunes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        public virtual IAsyncResult BeginDescribeDomainAutoTunes(DescribeDomainAutoTunesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainAutoTunesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainAutoTunesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainAutoTunes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainAutoTunes.</param>
        /// 
        /// <returns>Returns a  DescribeDomainAutoTunesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        public virtual DescribeDomainAutoTunesResponse EndDescribeDomainAutoTunes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainAutoTunesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomainChangeProgress

        /// <summary>
        /// Returns information about the current blue/green deployment happening on a domain,
        /// including a change ID, status, and progress stages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainChangeProgress service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        public virtual DescribeDomainChangeProgressResponse DescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainChangeProgressResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainChangeProgressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainChangeProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        public virtual IAsyncResult BeginDescribeDomainChangeProgress(DescribeDomainChangeProgressRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDomainChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainChangeProgressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainChangeProgress.</param>
        /// 
        /// <returns>Returns a  DescribeDomainChangeProgressResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        public virtual DescribeDomainChangeProgressResponse EndDescribeDomainChangeProgress(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainChangeProgressResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        public virtual DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        public virtual IAsyncResult BeginDescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomain">REST API Reference for DescribeElasticsearchDomain Operation</seealso>
        public virtual DescribeElasticsearchDomainResponse EndDescribeElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        public virtual DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        public virtual IAsyncResult BeginDescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainConfigResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomainConfig">REST API Reference for DescribeElasticsearchDomainConfig Operation</seealso>
        public virtual DescribeElasticsearchDomainConfigResponse EndDescribeElasticsearchDomainConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainConfigResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        public virtual DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        public virtual IAsyncResult BeginDescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomains.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchDomains">REST API Reference for DescribeElasticsearchDomains Operation</seealso>
        public virtual DescribeElasticsearchDomainsResponse EndDescribeElasticsearchDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeElasticsearchInstanceTypeLimits

        /// <summary>
        /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
        /// When modifying existing Domain, specify the <c> <a>DomainName</a> </c> to know what
        /// Limits are supported for modifying.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchInstanceTypeLimits service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        public virtual DescribeElasticsearchInstanceTypeLimitsResponse DescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchInstanceTypeLimitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchInstanceTypeLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchInstanceTypeLimits.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchInstanceTypeLimitsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeElasticsearchInstanceTypeLimits">REST API Reference for DescribeElasticsearchInstanceTypeLimits Operation</seealso>
        public virtual DescribeElasticsearchInstanceTypeLimitsResponse EndDescribeElasticsearchInstanceTypeLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchInstanceTypeLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInboundCrossClusterSearchConnections

        /// <summary>
        /// Lists all the inbound cross-cluster search connections for a destination domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundCrossClusterSearchConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeInboundCrossClusterSearchConnections service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        public virtual DescribeInboundCrossClusterSearchConnectionsResponse DescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInboundCrossClusterSearchConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundCrossClusterSearchConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeInboundCrossClusterSearchConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundCrossClusterSearchConnections operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInboundCrossClusterSearchConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        public virtual IAsyncResult BeginDescribeInboundCrossClusterSearchConnections(DescribeInboundCrossClusterSearchConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInboundCrossClusterSearchConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInboundCrossClusterSearchConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInboundCrossClusterSearchConnections.</param>
        /// 
        /// <returns>Returns a  DescribeInboundCrossClusterSearchConnectionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeInboundCrossClusterSearchConnections">REST API Reference for DescribeInboundCrossClusterSearchConnections Operation</seealso>
        public virtual DescribeInboundCrossClusterSearchConnectionsResponse EndDescribeInboundCrossClusterSearchConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInboundCrossClusterSearchConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOutboundCrossClusterSearchConnections

        /// <summary>
        /// Lists all the outbound cross-cluster search connections for a source domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundCrossClusterSearchConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeOutboundCrossClusterSearchConnections service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidPaginationTokenException">
        /// The request processing has failed because of invalid pagination token provided by
        /// customer. Returns an HTTP status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        public virtual DescribeOutboundCrossClusterSearchConnectionsResponse DescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOutboundCrossClusterSearchConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOutboundCrossClusterSearchConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOutboundCrossClusterSearchConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOutboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundCrossClusterSearchConnections operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOutboundCrossClusterSearchConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        public virtual IAsyncResult BeginDescribeOutboundCrossClusterSearchConnections(DescribeOutboundCrossClusterSearchConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOutboundCrossClusterSearchConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOutboundCrossClusterSearchConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOutboundCrossClusterSearchConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOutboundCrossClusterSearchConnections.</param>
        /// 
        /// <returns>Returns a  DescribeOutboundCrossClusterSearchConnectionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeOutboundCrossClusterSearchConnections">REST API Reference for DescribeOutboundCrossClusterSearchConnections Operation</seealso>
        public virtual DescribeOutboundCrossClusterSearchConnectionsResponse EndDescribeOutboundCrossClusterSearchConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOutboundCrossClusterSearchConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePackages

        /// <summary>
        /// Describes all packages available to Amazon ES. Includes options for filtering, limiting
        /// the number of results, and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        public virtual DescribePackagesResponse DescribePackages(DescribePackagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagesResponseUnmarshaller.Instance;

            return Invoke<DescribePackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        public virtual IAsyncResult BeginDescribePackages(DescribePackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePackages.</param>
        /// 
        /// <returns>Returns a  DescribePackagesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        public virtual DescribePackagesResponse EndDescribePackages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstanceOfferings

        /// <summary>
        /// Lists available reserved Elasticsearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstanceOfferings service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        public virtual DescribeReservedElasticsearchInstanceOfferingsResponse DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstanceOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstanceOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstanceOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstanceOfferingsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstanceOfferings">REST API Reference for DescribeReservedElasticsearchInstanceOfferings Operation</seealso>
        public virtual DescribeReservedElasticsearchInstanceOfferingsResponse EndDescribeReservedElasticsearchInstanceOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedElasticsearchInstanceOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstances

        /// <summary>
        /// Returns information about reserved Elasticsearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstances service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        public virtual DescribeReservedElasticsearchInstancesResponse DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstancesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeReservedElasticsearchInstances">REST API Reference for DescribeReservedElasticsearchInstances Operation</seealso>
        public virtual DescribeReservedElasticsearchInstancesResponse EndDescribeReservedElasticsearchInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedElasticsearchInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        /// <summary>
        /// Describes one or more Amazon OpenSearch Service-managed VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual IAsyncResult BeginDescribeVpcEndpoints(DescribeVpcEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual DescribeVpcEndpointsResponse EndDescribeVpcEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DissociatePackage

        /// <summary>
        /// Dissociates a package from the Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        public virtual DissociatePackageResponse DissociatePackage(DissociatePackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociatePackageResponseUnmarshaller.Instance;

            return Invoke<DissociatePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDissociatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        public virtual IAsyncResult BeginDissociatePackage(DissociatePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociatePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DissociatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDissociatePackage.</param>
        /// 
        /// <returns>Returns a  DissociatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        public virtual DissociatePackageResponse EndDissociatePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DissociatePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCompatibleElasticsearchVersions

        /// <summary>
        /// Returns a list of upgrade compatible Elastisearch versions. You can optionally pass
        /// a <c> <a>DomainName</a> </c> to get all upgrade compatible Elasticsearch versions
        /// for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleElasticsearchVersions service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        public virtual GetCompatibleElasticsearchVersionsResponse GetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleElasticsearchVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleElasticsearchVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        public virtual IAsyncResult BeginGetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleElasticsearchVersionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetCompatibleElasticsearchVersions">REST API Reference for GetCompatibleElasticsearchVersions Operation</seealso>
        public virtual GetCompatibleElasticsearchVersionsResponse EndGetCompatibleElasticsearchVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCompatibleElasticsearchVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPackageVersionHistory

        /// <summary>
        /// Returns a list of versions of the package, along with their creation time and commit
        /// message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        public virtual GetPackageVersionHistoryResponse GetPackageVersionHistory(GetPackageVersionHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPackageVersionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetPackageVersionHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPackageVersionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        public virtual IAsyncResult BeginGetPackageVersionHistory(GetPackageVersionHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPackageVersionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPackageVersionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPackageVersionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPackageVersionHistory.</param>
        /// 
        /// <returns>Returns a  GetPackageVersionHistoryResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        public virtual GetPackageVersionHistoryResponse EndGetPackageVersionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPackageVersionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpgradeHistory

        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades that were performed on the
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        public virtual GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        public virtual IAsyncResult BeginGetUpgradeHistory(GetUpgradeHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeHistory.</param>
        /// 
        /// <returns>Returns a  GetUpgradeHistoryResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        public virtual GetUpgradeHistoryResponse EndGetUpgradeHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUpgradeHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpgradeStatus

        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check that
        /// was performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        public virtual GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        public virtual IAsyncResult BeginGetUpgradeStatus(GetUpgradeStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUpgradeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeStatus.</param>
        /// 
        /// <returns>Returns a  GetUpgradeStatusResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        public virtual GetUpgradeStatusResponse EndGetUpgradeStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUpgradeStatusResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        public virtual ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomainsForPackage

        /// <summary>
        /// Lists all Amazon ES domains associated with the package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        public virtual ListDomainsForPackageResponse ListDomainsForPackage(ListDomainsForPackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsForPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsForPackageResponseUnmarshaller.Instance;

            return Invoke<ListDomainsForPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainsForPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        public virtual IAsyncResult BeginListDomainsForPackage(ListDomainsForPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsForPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsForPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainsForPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainsForPackage.</param>
        /// 
        /// <returns>Returns a  ListDomainsForPackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        public virtual ListDomainsForPackageResponse EndListDomainsForPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsForPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListElasticsearchInstanceTypes

        /// <summary>
        /// List all Elasticsearch instance types that are supported for given ElasticsearchVersion
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchInstanceTypes service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        public virtual ListElasticsearchInstanceTypesResponse ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchInstanceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        public virtual IAsyncResult BeginListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchInstanceTypesResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchInstanceTypes">REST API Reference for ListElasticsearchInstanceTypes Operation</seealso>
        public virtual ListElasticsearchInstanceTypesResponse EndListElasticsearchInstanceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListElasticsearchInstanceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListElasticsearchVersions

        /// <summary>
        /// List all supported Elasticsearch versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchVersions service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        public virtual ListElasticsearchVersionsResponse ListElasticsearchVersions(ListElasticsearchVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        public virtual IAsyncResult BeginListElasticsearchVersions(ListElasticsearchVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchVersionsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListElasticsearchVersions">REST API Reference for ListElasticsearchVersions Operation</seealso>
        public virtual ListElasticsearchVersionsResponse EndListElasticsearchVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListElasticsearchVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPackagesForDomain

        /// <summary>
        /// Lists all packages associated with the Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        public virtual ListPackagesForDomainResponse ListPackagesForDomain(ListPackagesForDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagesForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesForDomainResponseUnmarshaller.Instance;

            return Invoke<ListPackagesForDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPackagesForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        public virtual IAsyncResult BeginListPackagesForDomain(ListPackagesForDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPackagesForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPackagesForDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPackagesForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPackagesForDomain.</param>
        /// 
        /// <returns>Returns a  ListPackagesForDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        public virtual ListPackagesForDomainResponse EndListPackagesForDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPackagesForDomainResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcEndpointAccess

        /// <summary>
        /// Retrieves information about each principal that is allowed to access a given Amazon
        /// OpenSearch Service domain through the use of an interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        public virtual ListVpcEndpointAccessResponse ListVpcEndpointAccess(ListVpcEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginListVpcEndpointAccess(ListVpcEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        public virtual ListVpcEndpointAccessResponse EndListVpcEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcEndpoints

        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints in the current account
        /// and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListVpcEndpoints(ListVpcEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual ListVpcEndpointsResponse EndListVpcEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcEndpointsForDomain

        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints associated with a particular
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpointsForDomain service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        public virtual ListVpcEndpointsForDomainResponse ListVpcEndpointsForDomain(ListVpcEndpointsForDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsForDomainResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsForDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpointsForDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpointsForDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        public virtual IAsyncResult BeginListVpcEndpointsForDomain(ListVpcEndpointsForDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsForDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsForDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpointsForDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpointsForDomain.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointsForDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        public virtual ListVpcEndpointsForDomainResponse EndListVpcEndpointsForDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcEndpointsForDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedElasticsearchInstanceOffering

        /// <summary>
        /// Allows you to purchase reserved Elasticsearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedElasticsearchInstanceOffering service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        public virtual PurchaseReservedElasticsearchInstanceOfferingResponse PurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedElasticsearchInstanceOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedElasticsearchInstanceOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedElasticsearchInstanceOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedElasticsearchInstanceOfferingResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/PurchaseReservedElasticsearchInstanceOffering">REST API Reference for PurchaseReservedElasticsearchInstanceOffering Operation</seealso>
        public virtual PurchaseReservedElasticsearchInstanceOfferingResponse EndPurchaseReservedElasticsearchInstanceOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseReservedElasticsearchInstanceOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectInboundCrossClusterSearchConnection

        /// <summary>
        /// Allows the destination domain owner to reject an inbound cross-cluster search connection
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundCrossClusterSearchConnection service method.</param>
        /// 
        /// <returns>The response from the RejectInboundCrossClusterSearchConnection service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        public virtual RejectInboundCrossClusterSearchConnectionResponse RejectInboundCrossClusterSearchConnection(RejectInboundCrossClusterSearchConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectInboundCrossClusterSearchConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundCrossClusterSearchConnection operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInboundCrossClusterSearchConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        public virtual IAsyncResult BeginRejectInboundCrossClusterSearchConnection(RejectInboundCrossClusterSearchConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectInboundCrossClusterSearchConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectInboundCrossClusterSearchConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInboundCrossClusterSearchConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInboundCrossClusterSearchConnection.</param>
        /// 
        /// <returns>Returns a  RejectInboundCrossClusterSearchConnectionResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RejectInboundCrossClusterSearchConnection">REST API Reference for RejectInboundCrossClusterSearchConnection Operation</seealso>
        public virtual RejectInboundCrossClusterSearchConnectionResponse EndRejectInboundCrossClusterSearchConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectInboundCrossClusterSearchConnectionResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeVpcEndpointAccess

        /// <summary>
        /// Revokes access to an Amazon OpenSearch Service domain that was provided through an
        /// interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeVpcEndpointAccess service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        public virtual RevokeVpcEndpointAccessResponse RevokeVpcEndpointAccess(RevokeVpcEndpointAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeVpcEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeVpcEndpointAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeVpcEndpointAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        public virtual IAsyncResult BeginRevokeVpcEndpointAccess(RevokeVpcEndpointAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeVpcEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeVpcEndpointAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeVpcEndpointAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeVpcEndpointAccess.</param>
        /// 
        /// <returns>Returns a  RevokeVpcEndpointAccessResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        public virtual RevokeVpcEndpointAccessResponse EndRevokeVpcEndpointAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeVpcEndpointAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  StartElasticsearchServiceSoftwareUpdate

        /// <summary>
        /// Schedules a service software update for an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the StartElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual StartElasticsearchServiceSoftwareUpdateResponse StartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartElasticsearchServiceSoftwareUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual IAsyncResult BeginStartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  StartElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/StartElasticsearchServiceSoftwareUpdate">REST API Reference for StartElasticsearchServiceSoftwareUpdate Operation</seealso>
        public virtual StartElasticsearchServiceSoftwareUpdateResponse EndStartElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<StartElasticsearchServiceSoftwareUpdateResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        public virtual UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticsearchDomainConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticsearchDomainConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  UpdateElasticsearchDomainConfigResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateElasticsearchDomainConfig">REST API Reference for UpdateElasticsearchDomainConfig Operation</seealso>
        public virtual UpdateElasticsearchDomainConfigResponse EndUpdateElasticsearchDomainConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateElasticsearchDomainConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePackage

        /// <summary>
        /// Updates a package for use with Amazon ES domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.AccessDeniedException">
        /// An error occurred because user does not have permissions to access the resource. Returns
        /// HTTP status code 403.
        /// </exception>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        public virtual UpdatePackageResponse UpdatePackage(UpdatePackageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageResponseUnmarshaller.Instance;

            return Invoke<UpdatePackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        public virtual IAsyncResult BeginUpdatePackage(UpdatePackageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePackage.</param>
        /// 
        /// <returns>Returns a  UpdatePackageResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        public virtual UpdatePackageResponse EndUpdatePackage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePackageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcEndpoint

        /// <summary>
        /// Modifies an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use. Returns HTTP status code 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual UpdateVpcEndpointResponse UpdateVpcEndpoint(UpdateVpcEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateVpcEndpoint(UpdateVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateVpcEndpointResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual UpdateVpcEndpointResponse EndUpdateVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpgradeElasticsearchDomain

        /// <summary>
        /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
        /// a compatible Elasticsearch version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the UpgradeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
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
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        public virtual UpgradeElasticsearchDomainResponse UpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeElasticsearchDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeElasticsearchDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        public virtual IAsyncResult BeginUpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  UpgradeElasticsearchDomainResult from Elasticsearch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/es-2015-01-01/UpgradeElasticsearchDomain">REST API Reference for UpgradeElasticsearchDomain Operation</seealso>
        public virtual UpgradeElasticsearchDomainResponse EndUpgradeElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpgradeElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonElasticsearchEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
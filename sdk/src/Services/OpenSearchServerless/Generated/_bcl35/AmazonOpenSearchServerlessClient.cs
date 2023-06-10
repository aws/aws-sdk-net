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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.OpenSearchServerless.Model;
using Amazon.OpenSearchServerless.Model.Internal.MarshallTransformations;
using Amazon.OpenSearchServerless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OpenSearchServerless
{
    /// <summary>
    /// Implementation for accessing OpenSearchServerless
    ///
    /// Use the Amazon OpenSearch Serverless API to create, configure, and manage OpenSearch
    /// Serverless collections and security policies.
    /// 
    ///  
    /// <para>
    /// OpenSearch Serverless is an on-demand, pre-provisioned serverless configuration for
    /// Amazon OpenSearch Service. OpenSearch Serverless removes the operational complexities
    /// of provisioning, configuring, and tuning your OpenSearch clusters. It enables you
    /// to easily search and analyze petabytes of data without having to worry about the underlying
    /// infrastructure and data management.
    /// </para>
    ///  
    /// <para>
    ///  To learn more about OpenSearch Serverless, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html">What
    /// is Amazon OpenSearch Serverless?</a> 
    /// </para>
    /// </summary>
    public partial class AmazonOpenSearchServerlessClient : AmazonServiceClient, IAmazonOpenSearchServerless
    {
        private static IServiceMetadata serviceMetadata = new AmazonOpenSearchServerlessMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IOpenSearchServerlessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOpenSearchServerlessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OpenSearchServerlessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServerlessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServerlessConfig()) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        public AmazonOpenSearchServerlessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpenSearchServerlessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(AmazonOpenSearchServerlessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpenSearchServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Credentials and an
        /// AmazonOpenSearchServerlessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(AWSCredentials credentials, AmazonOpenSearchServerlessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpenSearchServerlessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpenSearchServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpenSearchServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpenSearchServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpenSearchServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpenSearchServerlessClient Configuration Object</param>
        public AmazonOpenSearchServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpenSearchServerlessConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOpenSearchServerlessEndpointResolver());
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


        #region  BatchGetCollection

        /// <summary>
        /// Returns attributes for one or more collections, including the collection endpoint
        /// and the OpenSearch Dashboards endpoint. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollection service method.</param>
        /// 
        /// <returns>The response from the BatchGetCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetCollection">REST API Reference for BatchGetCollection Operation</seealso>
        public virtual BatchGetCollectionResponse BatchGetCollection(BatchGetCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollectionResponseUnmarshaller.Instance;

            return Invoke<BatchGetCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCollection operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetCollection">REST API Reference for BatchGetCollection Operation</seealso>
        public virtual IAsyncResult BeginBatchGetCollection(BatchGetCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCollection.</param>
        /// 
        /// <returns>Returns a  BatchGetCollectionResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetCollection">REST API Reference for BatchGetCollection Operation</seealso>
        public virtual BatchGetCollectionResponse EndBatchGetCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetVpcEndpoint

        /// <summary>
        /// Returns attributes for one or more VPC endpoints associated with the current account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the BatchGetVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetVpcEndpoint">REST API Reference for BatchGetVpcEndpoint Operation</seealso>
        public virtual BatchGetVpcEndpointResponse BatchGetVpcEndpoint(BatchGetVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<BatchGetVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVpcEndpoint operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetVpcEndpoint">REST API Reference for BatchGetVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginBatchGetVpcEndpoint(BatchGetVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  BatchGetVpcEndpointResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/BatchGetVpcEndpoint">REST API Reference for BatchGetVpcEndpoint Operation</seealso>
        public virtual BatchGetVpcEndpointResponse EndBatchGetVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessPolicy

        /// <summary>
        /// Creates a data access policy for OpenSearch Serverless. Access policies limit access
        /// to collections and the resources within them, and allow a user to access that data
        /// irrespective of the access mechanism or network source. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessPolicy(CreateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  CreateAccessPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual CreateAccessPolicyResponse EndCreateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCollection

        /// <summary>
        /// Creates a new OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.OcuLimitExceededException">
        /// OCU Limit Exceeded for service limits
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual IAsyncResult BeginCreateCollection(CreateCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCollection.</param>
        /// 
        /// <returns>Returns a  CreateCollectionResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual CreateCollectionResponse EndCreateCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityConfig

        /// <summary>
        /// Specifies a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfig service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityConfig">REST API Reference for CreateSecurityConfig Operation</seealso>
        public virtual CreateSecurityConfigResponse CreateSecurityConfig(CreateSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfig operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityConfig">REST API Reference for CreateSecurityConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityConfig(CreateSecurityConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityConfig.</param>
        /// 
        /// <returns>Returns a  CreateSecurityConfigResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityConfig">REST API Reference for CreateSecurityConfig Operation</seealso>
        public virtual CreateSecurityConfigResponse EndCreateSecurityConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityPolicy

        /// <summary>
        /// Creates a security policy to be used by one or more OpenSearch Serverless collections.
        /// Security policies provide access to a collection and its OpenSearch Dashboards endpoint
        /// from public networks or specific VPC endpoints. They also allow you to secure a collection
        /// with a KMS encryption key. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityPolicy">REST API Reference for CreateSecurityPolicy Operation</seealso>
        public virtual CreateSecurityPolicyResponse CreateSecurityPolicy(CreateSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityPolicy">REST API Reference for CreateSecurityPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateSecurityPolicy(CreateSecurityPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityPolicy.</param>
        /// 
        /// <returns>Returns a  CreateSecurityPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateSecurityPolicy">REST API Reference for CreateSecurityPolicy Operation</seealso>
        public virtual CreateSecurityPolicyResponse EndCreateSecurityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        /// <summary>
        /// Creates an OpenSearch Serverless-managed interface VPC endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateVpcEndpointResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessPolicy

        /// <summary>
        /// Deletes an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual DeleteAccessPolicyResponse DeleteAccessPolicy(DeleteAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessPolicy(DeleteAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual DeleteAccessPolicyResponse EndDeleteAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCollection

        /// <summary>
        /// Deletes an OpenSearch Serverless collection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual IAsyncResult BeginDeleteCollection(DeleteCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCollection.</param>
        /// 
        /// <returns>Returns a  DeleteCollectionResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual DeleteCollectionResponse EndDeleteCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityConfig

        /// <summary>
        /// Deletes a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityConfig">REST API Reference for DeleteSecurityConfig Operation</seealso>
        public virtual DeleteSecurityConfigResponse DeleteSecurityConfig(DeleteSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfig operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityConfig">REST API Reference for DeleteSecurityConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityConfig(DeleteSecurityConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityConfig.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityConfigResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityConfig">REST API Reference for DeleteSecurityConfig Operation</seealso>
        public virtual DeleteSecurityConfigResponse EndDeleteSecurityConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityPolicy

        /// <summary>
        /// Deletes an OpenSearch Serverless security policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityPolicy">REST API Reference for DeleteSecurityPolicy Operation</seealso>
        public virtual DeleteSecurityPolicyResponse DeleteSecurityPolicy(DeleteSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityPolicy">REST API Reference for DeleteSecurityPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteSecurityPolicy(DeleteSecurityPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteSecurityPolicy">REST API Reference for DeleteSecurityPolicy Operation</seealso>
        public virtual DeleteSecurityPolicyResponse EndDeleteSecurityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcEndpoint

        /// <summary>
        /// Deletes an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcEndpoint(DeleteVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteVpcEndpointResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        public virtual DeleteVpcEndpointResponse EndDeleteVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccessPolicy

        /// <summary>
        /// Returns an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccessPolicy">REST API Reference for GetAccessPolicy Operation</seealso>
        public virtual GetAccessPolicyResponse GetAccessPolicy(GetAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccessPolicy">REST API Reference for GetAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetAccessPolicy(GetAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccessPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccessPolicy">REST API Reference for GetAccessPolicy Operation</seealso>
        public virtual GetAccessPolicyResponse EndGetAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Returns account-level settings related to OpenSearch Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPoliciesStats

        /// <summary>
        /// Returns statistical information about your OpenSearch Serverless access policies,
        /// security configurations, and security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPoliciesStats service method.</param>
        /// 
        /// <returns>The response from the GetPoliciesStats service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetPoliciesStats">REST API Reference for GetPoliciesStats Operation</seealso>
        public virtual GetPoliciesStatsResponse GetPoliciesStats(GetPoliciesStatsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPoliciesStatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPoliciesStatsResponseUnmarshaller.Instance;

            return Invoke<GetPoliciesStatsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPoliciesStats operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPoliciesStats operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPoliciesStats
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetPoliciesStats">REST API Reference for GetPoliciesStats Operation</seealso>
        public virtual IAsyncResult BeginGetPoliciesStats(GetPoliciesStatsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPoliciesStatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPoliciesStatsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPoliciesStats operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPoliciesStats.</param>
        /// 
        /// <returns>Returns a  GetPoliciesStatsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetPoliciesStats">REST API Reference for GetPoliciesStats Operation</seealso>
        public virtual GetPoliciesStatsResponse EndGetPoliciesStats(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPoliciesStatsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityConfig

        /// <summary>
        /// Returns information about an OpenSearch Serverless security configuration. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfig service method.</param>
        /// 
        /// <returns>The response from the GetSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityConfig">REST API Reference for GetSecurityConfig Operation</seealso>
        public virtual GetSecurityConfigResponse GetSecurityConfig(GetSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<GetSecurityConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityConfig operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityConfig">REST API Reference for GetSecurityConfig Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityConfig(GetSecurityConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityConfig.</param>
        /// 
        /// <returns>Returns a  GetSecurityConfigResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityConfig">REST API Reference for GetSecurityConfig Operation</seealso>
        public virtual GetSecurityConfigResponse EndGetSecurityConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSecurityPolicy

        /// <summary>
        /// Returns information about a configured OpenSearch Serverless security policy. For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the GetSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityPolicy">REST API Reference for GetSecurityPolicy Operation</seealso>
        public virtual GetSecurityPolicyResponse GetSecurityPolicy(GetSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<GetSecurityPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSecurityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityPolicy">REST API Reference for GetSecurityPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetSecurityPolicy(GetSecurityPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSecurityPolicy.</param>
        /// 
        /// <returns>Returns a  GetSecurityPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/GetSecurityPolicy">REST API Reference for GetSecurityPolicy Operation</seealso>
        public virtual GetSecurityPolicyResponse EndGetSecurityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSecurityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessPolicies

        /// <summary>
        /// Returns information about a list of OpenSearch Serverless access policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAccessPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual IAsyncResult BeginListAccessPolicies(ListAccessPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPolicies.</param>
        /// 
        /// <returns>Returns a  ListAccessPoliciesResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual ListAccessPoliciesResponse EndListAccessPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCollections

        /// <summary>
        /// Lists all OpenSearch Serverless collections. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-manage.html">Creating
        /// and managing Amazon OpenSearch Serverless collections</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Make sure to include an empty request body {} if you don't include any collection
        /// filters in the request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollections operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual IAsyncResult BeginListCollections(ListCollectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollections.</param>
        /// 
        /// <returns>Returns a  ListCollectionsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual ListCollectionsResponse EndListCollections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCollectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityConfigs

        /// <summary>
        /// Returns information about configured OpenSearch Serverless security configurations.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigs service method.</param>
        /// 
        /// <returns>The response from the ListSecurityConfigs service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityConfigs">REST API Reference for ListSecurityConfigs Operation</seealso>
        public virtual ListSecurityConfigsResponse ListSecurityConfigs(ListSecurityConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigs operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityConfigs">REST API Reference for ListSecurityConfigs Operation</seealso>
        public virtual IAsyncResult BeginListSecurityConfigs(ListSecurityConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityConfigs.</param>
        /// 
        /// <returns>Returns a  ListSecurityConfigsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityConfigs">REST API Reference for ListSecurityConfigs Operation</seealso>
        public virtual ListSecurityConfigsResponse EndListSecurityConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSecurityPolicies

        /// <summary>
        /// Returns information about configured OpenSearch Serverless security policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSecurityPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual IAsyncResult BeginListSecurityPolicies(ListSecurityPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityPolicies.</param>
        /// 
        /// <returns>Returns a  ListSecurityPoliciesResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        public virtual ListSecurityPoliciesResponse EndListSecurityPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSecurityPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns the tags for an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcEndpoints

        /// <summary>
        /// Returns the OpenSearch Serverless-managed interface VPC endpoints associated with
        /// the current account. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListVpcEndpoints(ListVpcEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListVpcEndpointsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        public virtual ListVpcEndpointsResponse EndListVpcEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates tags with an OpenSearch Serverless resource. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag or set of tags from an OpenSearch Serverless resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-collection.html">Tagging
        /// Amazon OpenSearch Serverless collections</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessPolicy

        /// <summary>
        /// Updates an OpenSearch Serverless access policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-data-access.html">Data
        /// access control for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccessPolicy(UpdateAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccessPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual UpdateAccessPolicyResponse EndUpdateAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountSettings

        /// <summary>
        /// Update the OpenSearch Serverless settings for the current Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-scaling.html">Managing
        /// capacity limits for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCollection

        /// <summary>
        /// Updates an OpenSearch Serverless collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollection service method.</param>
        /// 
        /// <returns>The response from the UpdateCollection service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateCollection">REST API Reference for UpdateCollection Operation</seealso>
        public virtual UpdateCollectionResponse UpdateCollection(UpdateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectionResponseUnmarshaller.Instance;

            return Invoke<UpdateCollectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollection operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateCollection">REST API Reference for UpdateCollection Operation</seealso>
        public virtual IAsyncResult BeginUpdateCollection(UpdateCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCollection.</param>
        /// 
        /// <returns>Returns a  UpdateCollectionResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateCollection">REST API Reference for UpdateCollection Operation</seealso>
        public virtual UpdateCollectionResponse EndUpdateCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityConfig

        /// <summary>
        /// Updates a security configuration for OpenSearch Serverless. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
        /// authentication for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityConfig service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityConfig">REST API Reference for UpdateSecurityConfig Operation</seealso>
        public virtual UpdateSecurityConfigResponse UpdateSecurityConfig(UpdateSecurityConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityConfig operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityConfig">REST API Reference for UpdateSecurityConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityConfig(UpdateSecurityConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityConfig.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityConfigResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityConfig">REST API Reference for UpdateSecurityConfig Operation</seealso>
        public virtual UpdateSecurityConfigResponse EndUpdateSecurityConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSecurityPolicy

        /// <summary>
        /// Updates an OpenSearch Serverless security policy. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-network.html">Network
        /// access for Amazon OpenSearch Serverless</a> and <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-encryption.html">Encryption
        /// at rest for Amazon OpenSearch Serverless</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityPolicy service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ResourceNotFoundException">
        /// Thrown when accessing or deleting a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ServiceQuotaExceededException">
        /// Thrown when you attempt to create more resources than the service allows based on
        /// service quotas.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityPolicy">REST API Reference for UpdateSecurityPolicy Operation</seealso>
        public virtual UpdateSecurityPolicyResponse UpdateSecurityPolicy(UpdateSecurityPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityPolicy operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityPolicy">REST API Reference for UpdateSecurityPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateSecurityPolicy(UpdateSecurityPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityPolicyResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateSecurityPolicy">REST API Reference for UpdateSecurityPolicy Operation</seealso>
        public virtual UpdateSecurityPolicyResponse EndUpdateSecurityPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSecurityPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcEndpoint

        /// <summary>
        /// Updates an OpenSearch Serverless-managed interface endpoint. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
        /// Amazon OpenSearch Serverless using an interface endpoint</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by OpenSearchServerless.</returns>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ConflictException">
        /// When creating a resource, thrown when a resource with the same name already exists
        /// or is being created. When deleting a resource, thrown when the resource is not in
        /// the ACTIVE or FAILED state.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.InternalServerException">
        /// Thrown when an error internal to the service occurs while processing a request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchServerless.Model.ValidationException">
        /// Thrown when the HTTP request contains invalid input or is missing required input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual UpdateVpcEndpointResponse UpdateVpcEndpoint(UpdateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint operation on AmazonOpenSearchServerlessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateVpcEndpoint(UpdateVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UpdateVpcEndpointResult from OpenSearchServerless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearchserverless-2021-11-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        public virtual UpdateVpcEndpointResponse EndUpdateVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
    }
}
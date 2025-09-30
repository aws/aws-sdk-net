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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Schemas.Model;
using Amazon.Schemas.Model.Internal.MarshallTransformations;
using Amazon.Schemas.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Schemas
{
    /// <summary>
    /// <para>Implementation for accessing Schemas</para>
    ///
    /// Amazon EventBridge Schema Registry
    /// </summary>
    public partial class AmazonSchemasClient : AmazonServiceClient, IAmazonSchemas
    {
        private static IServiceMetadata serviceMetadata = new AmazonSchemasMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISchemasPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISchemasPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SchemasPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        public AmazonSchemasClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSchemasConfig()) { }

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        public AmazonSchemasClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSchemasConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSchemasClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(AmazonSchemasConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSchemasClient(AWSCredentials credentials)
            : this(credentials, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSchemasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Credentials and an
        /// AmazonSchemasClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(AWSCredentials credentials, AmazonSchemasConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchemasConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchemasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSchemasConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchemasConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchemasConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchemasClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchemasClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSchemasClient Configuration Object</param>
        public AmazonSchemasClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSchemasConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSchemasEndpointResolver());
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


        #region  CreateDiscoverer

        /// <summary>
        /// Creates a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the CreateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        public virtual CreateDiscovererResponse CreateDiscoverer(CreateDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiscovererResponseUnmarshaller.Instance;

            return Invoke<CreateDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginCreateDiscoverer(CreateDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDiscoverer.</param>
        /// 
        /// <returns>Returns a  CreateDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        public virtual CreateDiscovererResponse EndCreateDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRegistry

        /// <summary>
        /// Creates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual CreateRegistryResponse CreateRegistry(CreateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return Invoke<CreateRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual IAsyncResult BeginCreateRegistry(CreateRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRegistry.</param>
        /// 
        /// <returns>Returns a  CreateRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        public virtual CreateRegistryResponse EndCreateRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSchema

        /// <summary>
        /// Creates a schema definition.
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse CreateSchema(CreateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return Invoke<CreateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual IAsyncResult BeginCreateSchema(CreateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchema.</param>
        /// 
        /// <returns>Returns a  CreateSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        public virtual CreateSchemaResponse EndCreateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDiscoverer

        /// <summary>
        /// Deletes a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DeleteDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        public virtual DeleteDiscovererResponse DeleteDiscoverer(DeleteDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscovererResponseUnmarshaller.Instance;

            return Invoke<DeleteDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginDeleteDiscoverer(DeleteDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDiscoverer.</param>
        /// 
        /// <returns>Returns a  DeleteDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        public virtual DeleteDiscovererResponse EndDeleteDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRegistry

        /// <summary>
        /// Deletes a Registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual IAsyncResult BeginDeleteRegistry(DeleteRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegistry.</param>
        /// 
        /// <returns>Returns a  DeleteRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        public virtual DeleteRegistryResponse EndDeleteRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Delete the resource-based policy attached to the specified registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchema

        /// <summary>
        /// Delete a schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchema(DeleteSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchema.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        public virtual DeleteSchemaResponse EndDeleteSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchemaVersion

        /// <summary>
        /// Delete the schema version definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaVersion service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        public virtual DeleteSchemaVersionResponse DeleteSchemaVersion(DeleteSchemaVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteSchemaVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchemaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchemaVersion(DeleteSchemaVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSchemaVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchemaVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchemaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchemaVersion.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaVersionResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        public virtual DeleteSchemaVersionResponse EndDeleteSchemaVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchemaVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCodeBinding

        /// <summary>
        /// Describe the code binding URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        public virtual DescribeCodeBindingResponse DescribeCodeBinding(DescribeCodeBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeBindingResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeBindingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeBinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        public virtual IAsyncResult BeginDescribeCodeBinding(DescribeCodeBindingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeBindingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeBinding.</param>
        /// 
        /// <returns>Returns a  DescribeCodeBindingResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        public virtual DescribeCodeBindingResponse EndDescribeCodeBinding(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCodeBindingResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDiscoverer

        /// <summary>
        /// Describes the discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DescribeDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        public virtual DescribeDiscovererResponse DescribeDiscoverer(DescribeDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscovererResponseUnmarshaller.Instance;

            return Invoke<DescribeDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginDescribeDiscoverer(DescribeDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDiscoverer.</param>
        /// 
        /// <returns>Returns a  DescribeDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        public virtual DescribeDiscovererResponse EndDescribeDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRegistry

        /// <summary>
        /// Describes the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        public virtual DescribeRegistryResponse DescribeRegistry(DescribeRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        public virtual IAsyncResult BeginDescribeRegistry(DescribeRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegistry.</param>
        /// 
        /// <returns>Returns a  DescribeRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        public virtual DescribeRegistryResponse EndDescribeRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSchema

        /// <summary>
        /// Retrieve the schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual IAsyncResult BeginDescribeSchema(DescribeSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchema.</param>
        /// 
        /// <returns>Returns a  DescribeSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        public virtual DescribeSchemaResponse EndDescribeSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportSchema

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema service method.</param>
        /// 
        /// <returns>The response from the ExportSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        public virtual ExportSchemaResponse ExportSchema(ExportSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSchemaResponseUnmarshaller.Instance;

            return Invoke<ExportSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        public virtual IAsyncResult BeginExportSchema(ExportSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportSchema.</param>
        /// 
        /// <returns>Returns a  ExportSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        public virtual ExportSchemaResponse EndExportSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCodeBindingSource

        /// <summary>
        /// Get the code binding source URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource service method.</param>
        /// 
        /// <returns>The response from the GetCodeBindingSource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        public virtual GetCodeBindingSourceResponse GetCodeBindingSource(GetCodeBindingSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeBindingSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeBindingSourceResponseUnmarshaller.Instance;

            return Invoke<GetCodeBindingSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeBindingSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeBindingSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        public virtual IAsyncResult BeginGetCodeBindingSource(GetCodeBindingSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCodeBindingSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeBindingSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeBindingSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeBindingSource.</param>
        /// 
        /// <returns>Returns a  GetCodeBindingSourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        public virtual GetCodeBindingSourceResponse EndGetCodeBindingSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCodeBindingSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDiscoveredSchema

        /// <summary>
        /// Get the discovered schema that was generated based on sampled events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema service method.</param>
        /// 
        /// <returns>The response from the GetDiscoveredSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        public virtual GetDiscoveredSchemaResponse GetDiscoveredSchema(GetDiscoveredSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveredSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredSchemaResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveredSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoveredSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiscoveredSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        public virtual IAsyncResult BeginGetDiscoveredSchema(GetDiscoveredSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDiscoveredSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiscoveredSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiscoveredSchema.</param>
        /// 
        /// <returns>Returns a  GetDiscoveredSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        public virtual GetDiscoveredSchemaResponse EndGetDiscoveredSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDiscoveredSchemaResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Retrieves the resource-based policy attached to a given registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoverers

        /// <summary>
        /// List the discoverers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers service method.</param>
        /// 
        /// <returns>The response from the ListDiscoverers service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        public virtual ListDiscoverersResponse ListDiscoverers(ListDiscoverersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverersResponseUnmarshaller.Instance;

            return Invoke<ListDiscoverersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoverers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoverers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        public virtual IAsyncResult BeginListDiscoverers(ListDiscoverersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoverersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoverersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoverers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoverers.</param>
        /// 
        /// <returns>Returns a  ListDiscoverersResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        public virtual ListDiscoverersResponse EndListDiscoverers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoverersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRegistries

        /// <summary>
        /// List the registries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual ListRegistriesResponse ListRegistries(ListRegistriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return Invoke<ListRegistriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegistries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual IAsyncResult BeginListRegistries(ListRegistriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegistries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegistries.</param>
        /// 
        /// <returns>Returns a  ListRegistriesResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        public virtual ListRegistriesResponse EndListRegistries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRegistriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemas

        /// <summary>
        /// List the schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse ListSchemas(ListSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return Invoke<ListSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        public virtual ListSchemasResponse EndListSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchemaVersions

        /// <summary>
        /// Provides a list of the schema versions and related information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual IAsyncResult BeginListSchemaVersions(ListSchemaVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchemaVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaVersions.</param>
        /// 
        /// <returns>Returns a  ListSchemaVersionsResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        public virtual ListSchemaVersionsResponse EndListSchemaVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchemaVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Get tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCodeBinding

        /// <summary>
        /// Put code binding URI
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding service method.</param>
        /// 
        /// <returns>The response from the PutCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.GoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        public virtual PutCodeBindingResponse PutCodeBinding(PutCodeBindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCodeBindingResponseUnmarshaller.Instance;

            return Invoke<PutCodeBindingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCodeBinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        public virtual IAsyncResult BeginPutCodeBinding(PutCodeBindingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCodeBindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCodeBindingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCodeBinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCodeBinding.</param>
        /// 
        /// <returns>Returns a  PutCodeBindingResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        public virtual PutCodeBindingResponse EndPutCodeBinding(IAsyncResult asyncResult)
        {
            return EndInvoke<PutCodeBindingResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// The name of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSchemas

        /// <summary>
        /// Search the schemas
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas service method.</param>
        /// 
        /// <returns>The response from the SearchSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        public virtual SearchSchemasResponse SearchSchemas(SearchSchemasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSchemasResponseUnmarshaller.Instance;

            return Invoke<SearchSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        public virtual IAsyncResult BeginSearchSchemas(SearchSchemasRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSchemasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSchemas.</param>
        /// 
        /// <returns>Returns a  SearchSchemasResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        public virtual SearchSchemasResponse EndSearchSchemas(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSchemasResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDiscoverer

        /// <summary>
        /// Starts the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StartDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        public virtual StartDiscovererResponse StartDiscoverer(StartDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscovererResponseUnmarshaller.Instance;

            return Invoke<StartDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginStartDiscoverer(StartDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDiscoverer.</param>
        /// 
        /// <returns>Returns a  StartDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        public virtual StartDiscovererResponse EndStartDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDiscoverer

        /// <summary>
        /// Stops the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StopDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        public virtual StopDiscovererResponse StopDiscoverer(StopDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscovererResponseUnmarshaller.Instance;

            return Invoke<StopDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginStopDiscoverer(StopDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDiscoverer.</param>
        /// 
        /// <returns>Returns a  StopDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        public virtual StopDiscovererResponse EndStopDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDiscoverer

        /// <summary>
        /// Updates the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the UpdateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        public virtual UpdateDiscovererResponse UpdateDiscoverer(UpdateDiscovererRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscovererResponseUnmarshaller.Instance;

            return Invoke<UpdateDiscovererResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDiscoverer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        public virtual IAsyncResult BeginUpdateDiscoverer(UpdateDiscovererRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDiscovererRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscovererResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDiscoverer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDiscoverer.</param>
        /// 
        /// <returns>Returns a  UpdateDiscovererResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        public virtual UpdateDiscovererResponse EndUpdateDiscoverer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDiscovererResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRegistry

        /// <summary>
        /// Updates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegistry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual IAsyncResult BeginUpdateRegistry(UpdateRegistryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegistry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegistry.</param>
        /// 
        /// <returns>Returns a  UpdateRegistryResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        public virtual UpdateRegistryResponse EndUpdateRegistry(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRegistryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSchema

        /// <summary>
        /// Updates the schema definition
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return Invoke<UpdateSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema operation on AmazonSchemasClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual IAsyncResult BeginUpdateSchema(UpdateSchemaRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchemaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchema.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaResult from Schemas.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        public virtual UpdateSchemaResponse EndUpdateSchema(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchemaResponse>(asyncResult);
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
            var resolver = new AmazonSchemasEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
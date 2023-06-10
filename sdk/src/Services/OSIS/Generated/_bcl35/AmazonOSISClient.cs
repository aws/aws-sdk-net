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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.OSIS.Model;
using Amazon.OSIS.Model.Internal.MarshallTransformations;
using Amazon.OSIS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OSIS
{
    /// <summary>
    /// Implementation for accessing OSIS
    ///
    /// Use the Amazon OpenSearch Ingestion API to create and manage ingestion pipelines.
    /// OpenSearch Ingestion is a fully managed data collector that delivers real-time log
    /// and trace data to OpenSearch Service domains. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ingestion.html">Getting
    /// data into your cluster using OpenSearch Ingestion</a>.
    /// </summary>
    public partial class AmazonOSISClient : AmazonServiceClient, IAmazonOSIS
    {
        private static IServiceMetadata serviceMetadata = new AmazonOSISMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IOSISPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOSISPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OSISPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonOSISClient with the credentials loaded from the application's
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
        public AmazonOSISClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOSISConfig()) { }

        /// <summary>
        /// Constructs AmazonOSISClient with the credentials loaded from the application's
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
        public AmazonOSISClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOSISConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOSISClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOSISClient Configuration Object</param>
        public AmazonOSISClient(AmazonOSISConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOSISClient(AWSCredentials credentials)
            : this(credentials, new AmazonOSISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOSISClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOSISConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Credentials and an
        /// AmazonOSISClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOSISClient Configuration Object</param>
        public AmazonOSISClient(AWSCredentials credentials, AmazonOSISConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOSISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOSISConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOSISClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOSISClient Configuration Object</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOSISConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOSISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOSISConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOSISClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOSISClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOSISClient Configuration Object</param>
        public AmazonOSISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOSISConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOSISEndpointResolver());
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


        #region  CreatePipeline

        /// <summary>
        /// Creates an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.LimitExceededException">
        /// You attempted to create more than the allowed number of tags.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceAlreadyExistsException">
        /// You attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePipeline

        /// <summary>
        /// Deletes an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/delete-pipeline.html">Deleting
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPipeline

        /// <summary>
        /// Retrieves information about an OpenSearch Ingestion pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual GetPipelineResponse GetPipeline(GetPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return Invoke<GetPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual IAsyncResult BeginGetPipeline(GetPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipeline.</param>
        /// 
        /// <returns>Returns a  GetPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        public virtual GetPipelineResponse EndGetPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPipelineBlueprint

        /// <summary>
        /// Retrieves information about a specific blueprint for OpenSearch Ingestion. Blueprints
        /// are templates for the configuration needed for a <code>CreatePipeline</code> request.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#pipeline-blueprint">Using
        /// blueprints to create a pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetPipelineBlueprint service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        public virtual GetPipelineBlueprintResponse GetPipelineBlueprint(GetPipelineBlueprintRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetPipelineBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineBlueprint operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        public virtual IAsyncResult BeginGetPipelineBlueprint(GetPipelineBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineBlueprint.</param>
        /// 
        /// <returns>Returns a  GetPipelineBlueprintResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        public virtual GetPipelineBlueprintResponse EndGetPipelineBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPipelineChangeProgress

        /// <summary>
        /// Returns progress information for the current change happening on an OpenSearch Ingestion
        /// pipeline. Currently, this operation only returns information when a pipeline is being
        /// created.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#get-pipeline-progress">Tracking
        /// the status of pipeline creation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineChangeProgress service method.</param>
        /// 
        /// <returns>The response from the GetPipelineChangeProgress service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        public virtual GetPipelineChangeProgressResponse GetPipelineChangeProgress(GetPipelineChangeProgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineChangeProgressResponseUnmarshaller.Instance;

            return Invoke<GetPipelineChangeProgressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineChangeProgress operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineChangeProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        public virtual IAsyncResult BeginGetPipelineChangeProgress(GetPipelineChangeProgressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineChangeProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineChangeProgressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineChangeProgress.</param>
        /// 
        /// <returns>Returns a  GetPipelineChangeProgressResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        public virtual GetPipelineChangeProgressResponse EndGetPipelineChangeProgress(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPipelineChangeProgressResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPipelineBlueprints

        /// <summary>
        /// Retrieves a list of all available blueprints for Data Prepper. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#pipeline-blueprint">Using
        /// blueprints to create a pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListPipelineBlueprints service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InvalidPaginationTokenException">
        /// An invalid pagination token provided in the request.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        public virtual ListPipelineBlueprintsResponse ListPipelineBlueprints(ListPipelineBlueprintsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineBlueprints operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        public virtual IAsyncResult BeginListPipelineBlueprints(ListPipelineBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelineBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineBlueprints.</param>
        /// 
        /// <returns>Returns a  ListPipelineBlueprintsResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        public virtual ListPipelineBlueprintsResponse EndListPipelineBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelineBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPipelines

        /// <summary>
        /// Lists all OpenSearch Ingestion pipelines in the current Amazon Web Services account
        /// and Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/list-pipeline.html">Viewing
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InvalidPaginationTokenException">
        /// An invalid pagination token provided in the request.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all resource tags associated with an OpenSearch Ingestion pipeline. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartPipeline

        /// <summary>
        /// Starts an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/pipeline--stop-start.html#pipeline--start">Starting
        /// an OpenSearch Ingestion pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipeline service method.</param>
        /// 
        /// <returns>The response from the StartPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        public virtual StartPipelineResponse StartPipeline(StartPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineResponseUnmarshaller.Instance;

            return Invoke<StartPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        public virtual IAsyncResult BeginStartPipeline(StartPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipeline.</param>
        /// 
        /// <returns>Returns a  StartPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        public virtual StartPipelineResponse EndStartPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  StopPipeline

        /// <summary>
        /// Stops an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/pipeline--stop-start.html#pipeline--stop">Stopping
        /// an OpenSearch Ingestion pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipeline service method.</param>
        /// 
        /// <returns>The response from the StopPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        public virtual StopPipelineResponse StopPipeline(StopPipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineResponseUnmarshaller.Instance;

            return Invoke<StopPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        public virtual IAsyncResult BeginStopPipeline(StopPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPipeline.</param>
        /// 
        /// <returns>Returns a  StopPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        public virtual StopPipelineResponse EndStopPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<StopPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.LimitExceededException">
        /// You attempted to create more than the allowed number of tags.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from an OpenSearch Ingestion pipeline. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipeline

        /// <summary>
        /// Updates an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/update-pipeline.html">Updating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidatePipeline

        /// <summary>
        /// Checks whether an OpenSearch Ingestion pipeline configuration is valid prior to creation.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipeline service method.</param>
        /// 
        /// <returns>The response from the ValidatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        public virtual ValidatePipelineResponse ValidatePipeline(ValidatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineResponseUnmarshaller.Instance;

            return Invoke<ValidatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        public virtual IAsyncResult BeginValidatePipeline(ValidatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidatePipeline.</param>
        /// 
        /// <returns>Returns a  ValidatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        public virtual ValidatePipelineResponse EndValidatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidatePipelineResponse>(asyncResult);
        }

        #endregion
        
    }
}
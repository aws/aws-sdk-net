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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.XRay.Model;
using Amazon.XRay.Model.Internal.MarshallTransformations;
using Amazon.XRay.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.XRay
{
    /// <summary>
    /// <para>Implementation for accessing XRay</para>
    ///
    /// Amazon Web Services X-Ray provides APIs for managing debug traces and retrieving service
    /// maps and other data created by processing those traces.
    /// </summary>
    public partial class AmazonXRayClient : AmazonServiceClient, IAmazonXRay
    {
        private static IServiceMetadata serviceMetadata = new AmazonXRayMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IXRayPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IXRayPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new XRayPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        public AmazonXRayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonXRayConfig()) { }

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        public AmazonXRayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonXRayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonXRayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(AmazonXRayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonXRayClient(AWSCredentials credentials)
            : this(credentials, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonXRayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Credentials and an
        /// AmazonXRayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(AWSCredentials credentials, AmazonXRayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonXRayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonXRayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonXRayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonXRayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonXRayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonXRayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonXRayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonXRayClient Configuration Object</param>
        public AmazonXRayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonXRayConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonXRayEndpointResolver());
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


        #region  BatchGetTraces

        /// <summary>
        /// <note> 
        /// <para>
        /// You cannot find traces through this API if Transaction Search is enabled since trace
        /// is not indexed in X-Ray.
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <c>GetTraceSummaries</c> to get
        /// a list of trace IDs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces service method.</param>
        /// 
        /// <returns>The response from the BatchGetTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        public virtual BatchGetTracesResponse BatchGetTraces(BatchGetTracesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return Invoke<BatchGetTracesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetTraces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        public virtual IAsyncResult BeginBatchGetTraces(BatchGetTracesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetTraces.</param>
        /// 
        /// <returns>Returns a  BatchGetTracesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        public virtual BatchGetTracesResponse EndBatchGetTraces(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetTracesResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelTraceRetrieval

        /// <summary>
        /// Cancels an ongoing trace retrieval job initiated by <c>StartTraceRetrieval</c> using
        /// the provided <c>RetrievalToken</c>. A successful cancellation will return an HTTP
        /// 200 response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTraceRetrieval service method.</param>
        /// 
        /// <returns>The response from the CancelTraceRetrieval service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CancelTraceRetrieval">REST API Reference for CancelTraceRetrieval Operation</seealso>
        public virtual CancelTraceRetrievalResponse CancelTraceRetrieval(CancelTraceRetrievalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTraceRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTraceRetrievalResponseUnmarshaller.Instance;

            return Invoke<CancelTraceRetrievalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTraceRetrieval operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTraceRetrieval operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTraceRetrieval
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CancelTraceRetrieval">REST API Reference for CancelTraceRetrieval Operation</seealso>
        public virtual IAsyncResult BeginCancelTraceRetrieval(CancelTraceRetrievalRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTraceRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTraceRetrievalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTraceRetrieval operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTraceRetrieval.</param>
        /// 
        /// <returns>Returns a  CancelTraceRetrievalResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CancelTraceRetrieval">REST API Reference for CancelTraceRetrieval Operation</seealso>
        public virtual CancelTraceRetrievalResponse EndCancelTraceRetrieval(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelTraceRetrievalResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates a group resource with a name and a filter expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSamplingRule

        /// <summary>
        /// Creates a rule to control sampling behavior for instrumented applications. Services
        /// retrieve rules with <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingRules.html">GetSamplingRules</a>,
        /// and evaluate each rule in ascending order of <i>priority</i> for each request. If
        /// a rule matches, the service records a trace, borrowing it from the reservoir size.
        /// After 10 seconds, the service reports back to X-Ray with <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>
        /// to get updated versions of each in-use rule. The updated rule contains a trace quota
        /// that the service can use instead of borrowing from the reservoir.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule service method.</param>
        /// 
        /// <returns>The response from the CreateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.RuleLimitExceededException">
        /// You have reached the maximum number of sampling rules.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateSamplingRule">REST API Reference for CreateSamplingRule Operation</seealso>
        public virtual CreateSamplingRuleResponse CreateSamplingRule(CreateSamplingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSamplingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSamplingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateSamplingRule">REST API Reference for CreateSamplingRule Operation</seealso>
        public virtual IAsyncResult BeginCreateSamplingRule(CreateSamplingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSamplingRule.</param>
        /// 
        /// <returns>Returns a  CreateSamplingRuleResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateSamplingRule">REST API Reference for CreateSamplingRule Operation</seealso>
        public virtual CreateSamplingRuleResponse EndCreateSamplingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSamplingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Deletes a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a resource policy from the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidPolicyRevisionIdException">
        /// A policy revision id was provided which does not match the latest policy revision.
        /// This exception is also if a policy revision id of 0 is provided via <c>PutResourcePolicy</c>
        /// and a policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
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
        /// <returns>Returns a  DeleteResourcePolicyResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSamplingRule

        /// <summary>
        /// Deletes a sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule service method.</param>
        /// 
        /// <returns>The response from the DeleteSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        public virtual DeleteSamplingRuleResponse DeleteSamplingRule(DeleteSamplingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSamplingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSamplingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteSamplingRule(DeleteSamplingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSamplingRule.</param>
        /// 
        /// <returns>Returns a  DeleteSamplingRuleResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        public virtual DeleteSamplingRuleResponse EndDeleteSamplingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSamplingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEncryptionConfig

        /// <summary>
        /// Retrieves the current encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the GetEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        public virtual GetEncryptionConfigResponse GetEncryptionConfig(GetEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginGetEncryptionConfig(GetEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  GetEncryptionConfigResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        public virtual GetEncryptionConfigResponse EndGetEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Retrieves group resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroups

        /// <summary>
        /// Retrieves all active group details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroups service method.</param>
        /// 
        /// <returns>The response from the GetGroups service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        public virtual GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return Invoke<GetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroups operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        public virtual IAsyncResult BeginGetGroups(GetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroups.</param>
        /// 
        /// <returns>Returns a  GetGroupsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        public virtual GetGroupsResponse EndGetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIndexingRules

        /// <summary>
        /// Retrieves all indexing rules.
        /// 
        ///  
        /// <para>
        /// Indexing rules are used to determine the server-side sampling rate for spans ingested
        /// through the CloudWatchLogs destination and indexed by X-Ray. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingRules service method.</param>
        /// 
        /// <returns>The response from the GetIndexingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetIndexingRules">REST API Reference for GetIndexingRules Operation</seealso>
        public virtual GetIndexingRulesResponse GetIndexingRules(GetIndexingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIndexingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingRulesResponseUnmarshaller.Instance;

            return Invoke<GetIndexingRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndexingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingRules operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndexingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetIndexingRules">REST API Reference for GetIndexingRules Operation</seealso>
        public virtual IAsyncResult BeginGetIndexingRules(GetIndexingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIndexingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIndexingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndexingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndexingRules.</param>
        /// 
        /// <returns>Returns a  GetIndexingRulesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetIndexingRules">REST API Reference for GetIndexingRules Operation</seealso>
        public virtual GetIndexingRulesResponse EndGetIndexingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIndexingRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsight

        /// <summary>
        /// Retrieves the summary information of an insight. This includes impact to clients and
        /// root cause services, the top anomalous services, the category, the state of the insight,
        /// and the start and end time of the insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsight service method.</param>
        /// 
        /// <returns>The response from the GetInsight service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsight">REST API Reference for GetInsight Operation</seealso>
        public virtual GetInsightResponse GetInsight(GetInsightRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResponseUnmarshaller.Instance;

            return Invoke<GetInsightResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsight operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsight">REST API Reference for GetInsight Operation</seealso>
        public virtual IAsyncResult BeginGetInsight(GetInsightRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsight.</param>
        /// 
        /// <returns>Returns a  GetInsightResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsight">REST API Reference for GetInsight Operation</seealso>
        public virtual GetInsightResponse EndGetInsight(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsightEvents

        /// <summary>
        /// X-Ray reevaluates insights periodically until they're resolved, and records each intermediate
        /// state as an event. You can review an insight's events in the Impact Timeline on the
        /// Inspect page in the X-Ray console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightEvents service method.</param>
        /// 
        /// <returns>The response from the GetInsightEvents service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightEvents">REST API Reference for GetInsightEvents Operation</seealso>
        public virtual GetInsightEventsResponse GetInsightEvents(GetInsightEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightEventsResponseUnmarshaller.Instance;

            return Invoke<GetInsightEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightEvents operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightEvents">REST API Reference for GetInsightEvents Operation</seealso>
        public virtual IAsyncResult BeginGetInsightEvents(GetInsightEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightEvents.</param>
        /// 
        /// <returns>Returns a  GetInsightEventsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightEvents">REST API Reference for GetInsightEvents Operation</seealso>
        public virtual GetInsightEventsResponse EndGetInsightEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsightImpactGraph

        /// <summary>
        /// Retrieves a service graph structure filtered by the specified insight. The service
        /// graph is limited to only structural information. For a complete service graph, use
        /// this API with the GetServiceGraph API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightImpactGraph service method.</param>
        /// 
        /// <returns>The response from the GetInsightImpactGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightImpactGraph">REST API Reference for GetInsightImpactGraph Operation</seealso>
        public virtual GetInsightImpactGraphResponse GetInsightImpactGraph(GetInsightImpactGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightImpactGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightImpactGraphResponseUnmarshaller.Instance;

            return Invoke<GetInsightImpactGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightImpactGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightImpactGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightImpactGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightImpactGraph">REST API Reference for GetInsightImpactGraph Operation</seealso>
        public virtual IAsyncResult BeginGetInsightImpactGraph(GetInsightImpactGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightImpactGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightImpactGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightImpactGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightImpactGraph.</param>
        /// 
        /// <returns>Returns a  GetInsightImpactGraphResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightImpactGraph">REST API Reference for GetInsightImpactGraph Operation</seealso>
        public virtual GetInsightImpactGraphResponse EndGetInsightImpactGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightImpactGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsightSummaries

        /// <summary>
        /// Retrieves the summaries of all insights in the specified group matching the provided
        /// filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSummaries service method.</param>
        /// 
        /// <returns>The response from the GetInsightSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightSummaries">REST API Reference for GetInsightSummaries Operation</seealso>
        public virtual GetInsightSummariesResponse GetInsightSummaries(GetInsightSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSummariesResponseUnmarshaller.Instance;

            return Invoke<GetInsightSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSummaries operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightSummaries">REST API Reference for GetInsightSummaries Operation</seealso>
        public virtual IAsyncResult BeginGetInsightSummaries(GetInsightSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInsightSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightSummaries.</param>
        /// 
        /// <returns>Returns a  GetInsightSummariesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightSummaries">REST API Reference for GetInsightSummaries Operation</seealso>
        public virtual GetInsightSummariesResponse EndGetInsightSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRetrievedTracesGraph

        /// <summary>
        /// Retrieves a service graph for traces based on the specified <c>RetrievalToken</c>
        /// from the CloudWatch log group generated by Transaction Search. This API does not initiate
        /// a retrieval job. You must first execute <c>StartTraceRetrieval</c> to obtain the required
        /// <c>RetrievalToken</c>. 
        /// 
        ///  
        /// <para>
        /// The trace graph describes services that process incoming requests and any downstream
        /// services they call, which may include Amazon Web Services resources, external APIs,
        /// or databases.
        /// </para>
        ///  
        /// <para>
        /// The response is empty until the <c>RetrievalStatus</c> is <i>COMPLETE</i>. Retry the
        /// request after the status changes from <i>RUNNING</i> or <i>SCHEDULED</i> to <i>COMPLETE</i>
        /// to access the full service graph.
        /// </para>
        ///  
        /// <para>
        ///  When CloudWatch log is the destination, this API can support cross-account observability
        /// and service graph retrieval across linked accounts.
        /// </para>
        ///  
        /// <para>
        /// For retrieving graphs from X-Ray directly as opposed to the Transaction-Search Log
        /// group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetTraceGraph.html">GetTraceGraph</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetrievedTracesGraph service method.</param>
        /// 
        /// <returns>The response from the GetRetrievedTracesGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetRetrievedTracesGraph">REST API Reference for GetRetrievedTracesGraph Operation</seealso>
        public virtual GetRetrievedTracesGraphResponse GetRetrievedTracesGraph(GetRetrievedTracesGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRetrievedTracesGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrievedTracesGraphResponseUnmarshaller.Instance;

            return Invoke<GetRetrievedTracesGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetrievedTracesGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetrievedTracesGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetrievedTracesGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetRetrievedTracesGraph">REST API Reference for GetRetrievedTracesGraph Operation</seealso>
        public virtual IAsyncResult BeginGetRetrievedTracesGraph(GetRetrievedTracesGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRetrievedTracesGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetrievedTracesGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetrievedTracesGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetrievedTracesGraph.</param>
        /// 
        /// <returns>Returns a  GetRetrievedTracesGraphResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetRetrievedTracesGraph">REST API Reference for GetRetrievedTracesGraph Operation</seealso>
        public virtual GetRetrievedTracesGraphResponse EndGetRetrievedTracesGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRetrievedTracesGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSamplingRules

        /// <summary>
        /// Retrieves all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules service method.</param>
        /// 
        /// <returns>The response from the GetSamplingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        public virtual GetSamplingRulesResponse GetSamplingRules(GetSamplingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        public virtual IAsyncResult BeginGetSamplingRules(GetSamplingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingRules.</param>
        /// 
        /// <returns>Returns a  GetSamplingRulesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        public virtual GetSamplingRulesResponse EndGetSamplingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSamplingRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSamplingStatisticSummaries

        /// <summary>
        /// Retrieves information about recent sampling results for all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries service method.</param>
        /// 
        /// <returns>The response from the GetSamplingStatisticSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        public virtual GetSamplingStatisticSummariesResponse GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingStatisticSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingStatisticSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        public virtual IAsyncResult BeginGetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingStatisticSummaries.</param>
        /// 
        /// <returns>Returns a  GetSamplingStatisticSummariesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        public virtual GetSamplingStatisticSummariesResponse EndGetSamplingStatisticSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSamplingStatisticSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSamplingTargets

        /// <summary>
        /// Requests a sampling quota for rules that the service is using to sample requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets service method.</param>
        /// 
        /// <returns>The response from the GetSamplingTargets service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        public virtual GetSamplingTargetsResponse GetSamplingTargets(GetSamplingTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return Invoke<GetSamplingTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSamplingTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        public virtual IAsyncResult BeginGetSamplingTargets(GetSamplingTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSamplingTargets.</param>
        /// 
        /// <returns>Returns a  GetSamplingTargetsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        public virtual GetSamplingTargetsResponse EndGetSamplingTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSamplingTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceGraph

        /// <summary>
        /// Retrieves a document that describes services that process incoming requests, and downstream
        /// services that they call as a result. Root services process incoming requests and make
        /// calls to downstream services. Root services are applications that use the <a href="https://docs.aws.amazon.com/xray/index.html">Amazon
        /// Web Services X-Ray SDK</a>. Downstream services can be other applications, Amazon
        /// Web Services resources, HTTP web APIs, or SQL databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph service method.</param>
        /// 
        /// <returns>The response from the GetServiceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        public virtual GetServiceGraphResponse GetServiceGraph(GetServiceGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return Invoke<GetServiceGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        public virtual IAsyncResult BeginGetServiceGraph(GetServiceGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceGraph.</param>
        /// 
        /// <returns>Returns a  GetServiceGraphResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        public virtual GetServiceGraphResponse EndGetServiceGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTimeSeriesServiceStatistics

        /// <summary>
        /// Get an aggregation of service statistics defined by a specific time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesServiceStatistics service method.</param>
        /// 
        /// <returns>The response from the GetTimeSeriesServiceStatistics service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        public virtual GetTimeSeriesServiceStatisticsResponse GetTimeSeriesServiceStatistics(GetTimeSeriesServiceStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetTimeSeriesServiceStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTimeSeriesServiceStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesServiceStatistics operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTimeSeriesServiceStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetTimeSeriesServiceStatistics(GetTimeSeriesServiceStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTimeSeriesServiceStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTimeSeriesServiceStatistics.</param>
        /// 
        /// <returns>Returns a  GetTimeSeriesServiceStatisticsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        public virtual GetTimeSeriesServiceStatisticsResponse EndGetTimeSeriesServiceStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTimeSeriesServiceStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTraceGraph

        /// <summary>
        /// Retrieves a service graph for one or more specific trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph service method.</param>
        /// 
        /// <returns>The response from the GetTraceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        public virtual GetTraceGraphResponse GetTraceGraph(GetTraceGraphRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return Invoke<GetTraceGraphResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTraceGraph
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        public virtual IAsyncResult BeginGetTraceGraph(GetTraceGraphRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTraceGraph.</param>
        /// 
        /// <returns>Returns a  GetTraceGraphResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        public virtual GetTraceGraphResponse EndGetTraceGraph(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTraceGraphResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTraceSegmentDestination

        /// <summary>
        /// Retrieves the current destination of data sent to <c>PutTraceSegments</c> and <i>OpenTelemetry
        /// protocol (OTLP)</i> endpoint. The Transaction Search feature requires a CloudWatchLogs
        /// destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a> and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-OpenTelemetry-Sections.html">OpenTelemetry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSegmentDestination service method.</param>
        /// 
        /// <returns>The response from the GetTraceSegmentDestination service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSegmentDestination">REST API Reference for GetTraceSegmentDestination Operation</seealso>
        public virtual GetTraceSegmentDestinationResponse GetTraceSegmentDestination(GetTraceSegmentDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceSegmentDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSegmentDestinationResponseUnmarshaller.Instance;

            return Invoke<GetTraceSegmentDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceSegmentDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSegmentDestination operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTraceSegmentDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSegmentDestination">REST API Reference for GetTraceSegmentDestination Operation</seealso>
        public virtual IAsyncResult BeginGetTraceSegmentDestination(GetTraceSegmentDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceSegmentDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSegmentDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTraceSegmentDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTraceSegmentDestination.</param>
        /// 
        /// <returns>Returns a  GetTraceSegmentDestinationResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSegmentDestination">REST API Reference for GetTraceSegmentDestination Operation</seealso>
        public virtual GetTraceSegmentDestinationResponse EndGetTraceSegmentDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTraceSegmentDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTraceSummaries

        /// <summary>
        /// Retrieves IDs and annotations for traces available for a specified time frame using
        /// an optional filter. To get the full traces, pass the trace IDs to <c>BatchGetTraces</c>.
        /// 
        ///  
        /// <para>
        /// A filter expression can target traced requests that hit specific service nodes or
        /// edges, have errors, or come from a known user. For example, the following filter expression
        /// targets traces that pass through <c>api.example.com</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>service("api.example.com")</c> 
        /// </para>
        ///  
        /// <para>
        /// This filter expression finds traces that have an annotation named <c>account</c> with
        /// the value <c>12345</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>annotation.account = "12345"</c> 
        /// </para>
        ///  
        /// <para>
        /// For a full list of indexed fields and keywords that you can use in filter expressions,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-console.html#xray-console-filters">Use
        /// filter expressions</a> in the <i>Amazon Web Services X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries service method.</param>
        /// 
        /// <returns>The response from the GetTraceSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        public virtual GetTraceSummariesResponse GetTraceSummaries(GetTraceSummariesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return Invoke<GetTraceSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTraceSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        public virtual IAsyncResult BeginGetTraceSummaries(GetTraceSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTraceSummaries.</param>
        /// 
        /// <returns>Returns a  GetTraceSummariesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        public virtual GetTraceSummariesResponse EndGetTraceSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTraceSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourcePolicies

        /// <summary>
        /// Returns the list of resource policies in the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual ListResourcePoliciesResponse ListResourcePolicies(ListResourcePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginListResourcePolicies(ListResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcePolicies.</param>
        /// 
        /// <returns>Returns a  ListResourcePoliciesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual ListResourcePoliciesResponse EndListResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRetrievedTraces

        /// <summary>
        /// Retrieves a list of traces for a given <c>RetrievalToken</c> from the CloudWatch
        /// log group generated by Transaction Search. For information on what each trace returns,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// This API does not initiate a retrieval process. To start a trace retrieval, use <c>StartTraceRetrieval</c>,
        /// which generates the required <c>RetrievalToken</c>.
        /// </para>
        ///  
        /// <para>
        ///  When the <c>RetrievalStatus</c> is not <i>COMPLETE</i>, the API will return an empty
        /// response. Retry the request once the retrieval has completed to access the full list
        /// of traces.
        /// </para>
        ///  
        /// <para>
        /// For cross-account observability, this API can retrieve traces from linked accounts
        /// when CloudWatch log is set as the destination across relevant accounts. For more details,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        /// For retrieving data from X-Ray directly as opposed to the Transaction Search generated
        /// log group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievedTraces service method.</param>
        /// 
        /// <returns>The response from the ListRetrievedTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListRetrievedTraces">REST API Reference for ListRetrievedTraces Operation</seealso>
        public virtual ListRetrievedTracesResponse ListRetrievedTraces(ListRetrievedTracesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRetrievedTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrievedTracesResponseUnmarshaller.Instance;

            return Invoke<ListRetrievedTracesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetrievedTraces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievedTraces operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRetrievedTraces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListRetrievedTraces">REST API Reference for ListRetrievedTraces Operation</seealso>
        public virtual IAsyncResult BeginListRetrievedTraces(ListRetrievedTracesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRetrievedTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrievedTracesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRetrievedTraces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRetrievedTraces.</param>
        /// 
        /// <returns>Returns a  ListRetrievedTracesResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListRetrievedTraces">REST API Reference for ListRetrievedTraces Operation</seealso>
        public virtual ListRetrievedTracesResponse EndListRetrievedTraces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRetrievedTracesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Web Services X-Ray
        /// group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEncryptionConfig

        /// <summary>
        /// Updates the encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig service method.</param>
        /// 
        /// <returns>The response from the PutEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        public virtual PutEncryptionConfigResponse PutEncryptionConfig(PutEncryptionConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<PutEncryptionConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEncryptionConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        public virtual IAsyncResult BeginPutEncryptionConfig(PutEncryptionConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEncryptionConfig.</param>
        /// 
        /// <returns>Returns a  PutEncryptionConfigResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        public virtual PutEncryptionConfigResponse EndPutEncryptionConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEncryptionConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Sets the resource policy to grant one or more Amazon Web Services services and accounts
        /// permissions to access X-Ray. Each resource policy will be associated with a specific
        /// Amazon Web Services account. Each Amazon Web Services account can have a maximum of
        /// 5 resource policies, and each policy name must be unique within that account. The
        /// maximum size of each resource policy is 5KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidPolicyRevisionIdException">
        /// A policy revision id was provided which does not match the latest policy revision.
        /// This exception is also if a policy revision id of 0 is provided via <c>PutResourcePolicy</c>
        /// and a policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.LockoutPreventionException">
        /// The provided resource policy would prevent the caller of this request from calling
        /// PutResourcePolicy in the future.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.MalformedPolicyDocumentException">
        /// Invalid policy document provided in request.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.PolicyCountLimitExceededException">
        /// Exceeded the maximum number of resource policies for a target Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.PolicySizeLimitExceededException">
        /// Exceeded the maximum size for a resource policy.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
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
        /// <returns>Returns a  PutResourcePolicyResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTelemetryRecords

        /// <summary>
        /// Used by the Amazon Web Services X-Ray daemon to upload telemetry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords service method.</param>
        /// 
        /// <returns>The response from the PutTelemetryRecords service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        public virtual PutTelemetryRecordsResponse PutTelemetryRecords(PutTelemetryRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return Invoke<PutTelemetryRecordsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTelemetryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        public virtual IAsyncResult BeginPutTelemetryRecords(PutTelemetryRecordsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTelemetryRecords.</param>
        /// 
        /// <returns>Returns a  PutTelemetryRecordsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        public virtual PutTelemetryRecordsResponse EndPutTelemetryRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTelemetryRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutTraceSegments

        /// <summary>
        /// Uploads segment documents to Amazon Web Services X-Ray. A segment document can be
        /// a completed segment, an in-progress segment, or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-api.html#xray-api-segmentdocuments.html">Amazon
        /// Web Services X-Ray Segment Documents</a> in the <i>Amazon Web Services X-Ray Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required segment document fields</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> - The name of the service that handled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>id</c> - A 64-bit identifier for the segment, unique among segments in the same
        /// trace, in 16 hexadecimal digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>trace_id</c> - A unique identifier that connects all segments and subsegments
        /// originating from a single client request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start_time</c> - Time the segment or subsegment was created, in floating point
        /// seconds in epoch time, accurate to milliseconds. For example, <c>1480615200.010</c>
        /// or <c>1.480615200010E9</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>end_time</c> - Time the segment or subsegment was closed. For example, <c>1480615200.090</c>
        /// or <c>1.480615200090E9</c>. Specify either an <c>end_time</c> or <c>in_progress</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in_progress</c> - Set to <c>true</c> instead of specifying an <c>end_time</c>
        /// to record that a segment has been started, but is not complete. Send an in-progress
        /// segment when your application receives a request that will take a long time to serve,
        /// to trace that the request was received. When the response is sent, send the complete
        /// segment to overwrite the in-progress segment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <c>trace_id</c> consists of three numbers separated by hyphens. For example, 1-58406520-a006649127e371903a2de979.
        /// For trace IDs created by an X-Ray SDK, or by Amazon Web Services services integrated
        /// with X-Ray, a trace ID includes:
        /// </para>
        ///  
        /// <para>
        ///  <b>Trace ID Format</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The version number, for instance, <c>1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
        /// example, 10:00AM December 2nd, 2016 PST in epoch time is <c>1480615200</c> seconds,
        /// or <c>58406520</c> in hexadecimal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Trace IDs created via OpenTelemetry have a different format based on the <a href="https://www.w3.org/TR/trace-context/">W3C
        /// Trace Context specification</a>. A W3C trace ID must be formatted in the X-Ray trace
        /// ID format when sending to X-Ray. For example, a W3C trace ID <c>4efaaf4d1e8720b39541901950019ee5</c>
        /// should be formatted as <c>1-4efaaf4d-1e8720b39541901950019ee5</c> when sending to
        /// X-Ray. While X-Ray trace IDs include the original request timestamp in Unix epoch
        /// time, this is not required or validated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments service method.</param>
        /// 
        /// <returns>The response from the PutTraceSegments service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        public virtual PutTraceSegmentsResponse PutTraceSegments(PutTraceSegmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return Invoke<PutTraceSegmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTraceSegments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        public virtual IAsyncResult BeginPutTraceSegments(PutTraceSegmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTraceSegments.</param>
        /// 
        /// <returns>Returns a  PutTraceSegmentsResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        public virtual PutTraceSegmentsResponse EndPutTraceSegments(IAsyncResult asyncResult)
        {
            return EndInvoke<PutTraceSegmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTraceRetrieval

        /// <summary>
        /// Initiates a trace retrieval process using the specified time range and for the given
        /// trace IDs in the Transaction Search generated CloudWatch log group. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>. 
        /// 
        ///  
        /// <para>
        /// API returns a <c>RetrievalToken</c>, which can be used with <c>ListRetrievedTraces</c>
        /// or <c>GetRetrievedTracesGraph</c> to fetch results. Retrievals will time out after
        /// 60 minutes. To execute long time ranges, consider segmenting into multiple retrievals.
        /// </para>
        ///  
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>, you can use this operation in a monitoring account
        /// to retrieve data from a linked source account, as long as both accounts have transaction
        /// search enabled.
        /// </para>
        ///  
        /// <para>
        /// For retrieving data from X-Ray directly as opposed to the Transaction-Search Log group,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTraceRetrieval service method.</param>
        /// 
        /// <returns>The response from the StartTraceRetrieval service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/StartTraceRetrieval">REST API Reference for StartTraceRetrieval Operation</seealso>
        public virtual StartTraceRetrievalResponse StartTraceRetrieval(StartTraceRetrievalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTraceRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTraceRetrievalResponseUnmarshaller.Instance;

            return Invoke<StartTraceRetrievalResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTraceRetrieval operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTraceRetrieval operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTraceRetrieval
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/StartTraceRetrieval">REST API Reference for StartTraceRetrieval Operation</seealso>
        public virtual IAsyncResult BeginStartTraceRetrieval(StartTraceRetrievalRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTraceRetrievalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTraceRetrievalResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTraceRetrieval operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTraceRetrieval.</param>
        /// 
        /// <returns>Returns a  StartTraceRetrievalResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/StartTraceRetrieval">REST API Reference for StartTraceRetrieval Operation</seealso>
        public virtual StartTraceRetrievalResponse EndStartTraceRetrieval(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTraceRetrievalResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies tags to an existing Amazon Web Services X-Ray group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from an Amazon Web Services X-Ray group or sampling rule. You cannot
        /// edit or delete system tags (those with an <c>aws:</c> prefix).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Updates a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIndexingRule

        /// <summary>
        /// Modifies an indexing rule’s configuration. 
        /// 
        ///  
        /// <para>
        /// Indexing rules are used for determining the sampling rate for spans indexed from CloudWatch
        /// Logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingRule service method.</param>
        /// 
        /// <returns>The response from the UpdateIndexingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateIndexingRule">REST API Reference for UpdateIndexingRule Operation</seealso>
        public virtual UpdateIndexingRuleResponse UpdateIndexingRule(UpdateIndexingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIndexingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateIndexingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndexingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndexingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateIndexingRule">REST API Reference for UpdateIndexingRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateIndexingRule(UpdateIndexingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIndexingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIndexingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndexingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndexingRule.</param>
        /// 
        /// <returns>Returns a  UpdateIndexingRuleResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateIndexingRule">REST API Reference for UpdateIndexingRule Operation</seealso>
        public virtual UpdateIndexingRuleResponse EndUpdateIndexingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIndexingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSamplingRule

        /// <summary>
        /// Modifies a sampling rule's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule service method.</param>
        /// 
        /// <returns>The response from the UpdateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        public virtual UpdateSamplingRuleResponse UpdateSamplingRule(UpdateSamplingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSamplingRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSamplingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateSamplingRule(UpdateSamplingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSamplingRule.</param>
        /// 
        /// <returns>Returns a  UpdateSamplingRuleResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        public virtual UpdateSamplingRuleResponse EndUpdateSamplingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSamplingRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTraceSegmentDestination

        /// <summary>
        /// Modifies the destination of data sent to <c>PutTraceSegments</c>. The Transaction
        /// Search feature requires the CloudWatchLogs destination. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTraceSegmentDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateTraceSegmentDestination service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateTraceSegmentDestination">REST API Reference for UpdateTraceSegmentDestination Operation</seealso>
        public virtual UpdateTraceSegmentDestinationResponse UpdateTraceSegmentDestination(UpdateTraceSegmentDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTraceSegmentDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTraceSegmentDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateTraceSegmentDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTraceSegmentDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTraceSegmentDestination operation on AmazonXRayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTraceSegmentDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateTraceSegmentDestination">REST API Reference for UpdateTraceSegmentDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateTraceSegmentDestination(UpdateTraceSegmentDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTraceSegmentDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTraceSegmentDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTraceSegmentDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTraceSegmentDestination.</param>
        /// 
        /// <returns>Returns a  UpdateTraceSegmentDestinationResult from XRay.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateTraceSegmentDestination">REST API Reference for UpdateTraceSegmentDestination Operation</seealso>
        public virtual UpdateTraceSegmentDestinationResponse EndUpdateTraceSegmentDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTraceSegmentDestinationResponse>(asyncResult);
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
            var resolver = new AmazonXRayEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
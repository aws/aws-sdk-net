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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <c>GetTraceSummaries</c> to get
        /// a list of trace IDs.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return Invoke<BatchGetTracesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <c>GetTraceSummaries</c> to get
        /// a list of trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        public virtual Task<BatchGetTracesResponse> BatchGetTracesAsync(BatchGetTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetTracesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a group resource with a name and a filter expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSamplingRuleResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSamplingRuleResponse> CreateSamplingRuleAsync(CreateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSamplingRuleResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes a resource policy from the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSamplingRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes a sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        public virtual Task<DeleteSamplingRuleResponse> DeleteSamplingRuleAsync(DeleteSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSamplingRuleResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the current encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        public virtual Task<GetEncryptionConfigResponse> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEncryptionConfigResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }


        /// <summary>
        /// Retrieves group resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return Invoke<GetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all active group details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroups service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        public virtual Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGroupsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResponseUnmarshaller.Instance;

            return Invoke<GetInsightResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the summary information of an insight. This includes impact to clients and
        /// root cause services, the top anomalous services, the category, the state of the insight,
        /// and the start and end time of the insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsight service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsight">REST API Reference for GetInsight Operation</seealso>
        public virtual Task<GetInsightResponse> GetInsightAsync(GetInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightEventsResponseUnmarshaller.Instance;

            return Invoke<GetInsightEventsResponse>(request, options);
        }


        /// <summary>
        /// X-Ray reevaluates insights periodically until they're resolved, and records each intermediate
        /// state as an event. You can review an insight's events in the Impact Timeline on the
        /// Inspect page in the X-Ray console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightEvents service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightEvents">REST API Reference for GetInsightEvents Operation</seealso>
        public virtual Task<GetInsightEventsResponse> GetInsightEventsAsync(GetInsightEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightEventsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightImpactGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightImpactGraphResponseUnmarshaller.Instance;

            return Invoke<GetInsightImpactGraphResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a service graph structure filtered by the specified insight. The service
        /// graph is limited to only structural information. For a complete service graph, use
        /// this API with the GetServiceGraph API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightImpactGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightImpactGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightImpactGraph">REST API Reference for GetInsightImpactGraph Operation</seealso>
        public virtual Task<GetInsightImpactGraphResponse> GetInsightImpactGraphAsync(GetInsightImpactGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightImpactGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightImpactGraphResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightImpactGraphResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSummariesResponseUnmarshaller.Instance;

            return Invoke<GetInsightSummariesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the summaries of all insights in the specified group matching the provided
        /// filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightSummaries">REST API Reference for GetInsightSummaries Operation</seealso>
        public virtual Task<GetInsightSummariesResponse> GetInsightSummariesAsync(GetInsightSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetInsightSummariesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingRulesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        public virtual Task<GetSamplingRulesResponse> GetSamplingRulesAsync(GetSamplingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSamplingRulesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingStatisticSummariesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about recent sampling results for all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingStatisticSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        public virtual Task<GetSamplingStatisticSummariesResponse> GetSamplingStatisticSummariesAsync(GetSamplingStatisticSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSamplingStatisticSummariesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return Invoke<GetSamplingTargetsResponse>(request, options);
        }


        /// <summary>
        /// Requests a sampling quota for rules that the service is using to sample requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingTargets service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        public virtual Task<GetSamplingTargetsResponse> GetSamplingTargetsAsync(GetSamplingTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSamplingTargetsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return Invoke<GetServiceGraphResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a document that describes services that process incoming requests, and downstream
        /// services that they call as a result. Root services process incoming requests and make
        /// calls to downstream services. Root services are applications that use the <a href="https://docs.aws.amazon.com/xray/index.html">Amazon
        /// Web Services X-Ray SDK</a>. Downstream services can be other applications, Amazon
        /// Web Services resources, HTTP web APIs, or SQL databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        public virtual Task<GetServiceGraphResponse> GetServiceGraphAsync(GetServiceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceGraphResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetTimeSeriesServiceStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Get an aggregation of service statistics defined by a specific time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesServiceStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimeSeriesServiceStatistics service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        public virtual Task<GetTimeSeriesServiceStatisticsResponse> GetTimeSeriesServiceStatisticsAsync(GetTimeSeriesServiceStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesServiceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesServiceStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTimeSeriesServiceStatisticsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return Invoke<GetTraceGraphResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a service graph for one or more specific trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        public virtual Task<GetTraceGraphResponse> GetTraceGraphAsync(GetTraceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTraceGraphResponse>(request, options, cancellationToken);
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
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-console-filters.html">Using
        /// Filter Expressions</a> in the <i>Amazon Web Services X-Ray Developer Guide</i>.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return Invoke<GetTraceSummariesResponse>(request, options);
        }


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
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-console-filters.html">Using
        /// Filter Expressions</a> in the <i>Amazon Web Services X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        public virtual Task<GetTraceSummariesResponse> GetTraceSummariesAsync(GetTraceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTraceSummariesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResourcePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Returns the list of resource policies in the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcePoliciesResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Web Services X-Ray
        /// group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<PutEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Updates the encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        public virtual Task<PutEncryptionConfigResponse> PutEncryptionConfigAsync(PutEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEncryptionConfigResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Sets the resource policy to grant one or more Amazon Web Services services and accounts
        /// permissions to access X-Ray. Each resource policy will be associated with a specific
        /// Amazon Web Services account. Each Amazon Web Services account can have a maximum of
        /// 5 resource policies, and each policy name must be unique within that account. The
        /// maximum size of each resource policy is 5KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return Invoke<PutTelemetryRecordsResponse>(request, options);
        }


        /// <summary>
        /// Used by the Amazon Web Services X-Ray daemon to upload telemetry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTelemetryRecords service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        public virtual Task<PutTelemetryRecordsResponse> PutTelemetryRecordsAsync(PutTelemetryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutTelemetryRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTraceSegments


        /// <summary>
        /// Uploads segment documents to Amazon Web Services X-Ray. The <a href="https://docs.aws.amazon.com/xray/index.html">X-Ray
        /// SDK</a> generates segment documents and sends them to the X-Ray daemon, which uploads
        /// them in batches. A segment document can be a completed segment, an in-progress segment,
        /// or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-api-segmentdocuments.html">Amazon
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
        /// This includes:
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
        ///  </li> </ul>
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return Invoke<PutTraceSegmentsResponse>(request, options);
        }


        /// <summary>
        /// Uploads segment documents to Amazon Web Services X-Ray. The <a href="https://docs.aws.amazon.com/xray/index.html">X-Ray
        /// SDK</a> generates segment documents and sends them to the X-Ray daemon, which uploads
        /// them in batches. A segment document can be a completed segment, an in-progress segment,
        /// or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/xray-api-segmentdocuments.html">Amazon
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
        /// This includes:
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
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTraceSegments service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        public virtual Task<PutTraceSegmentsResponse> PutTraceSegmentsAsync(PutTraceSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutTraceSegmentsResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Applies tags to an existing Amazon Web Services X-Ray group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from an Amazon Web Services X-Ray group or sampling rule. You cannot
        /// edit or delete system tags (those with an <c>aws:</c> prefix).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }


        /// <summary>
        /// Updates a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSamplingRuleResponse>(request, options);
        }


        /// <summary>
        /// Modifies a sampling rule's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        public virtual Task<UpdateSamplingRuleResponse> UpdateSamplingRuleAsync(UpdateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSamplingRuleResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonXRayEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
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

namespace Amazon.XRay
{
    /// <summary>
    /// Implementation for accessing XRay
    ///
    /// AWS X-Ray provides APIs for managing debug traces and retrieving service maps and
    /// other data created by processing those traces.
    /// </summary>
    public partial class AmazonXRayClient : AmazonServiceClient, IAmazonXRay
    {
        private static IServiceMetadata serviceMetadata = new AmazonXRayMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        internal virtual BatchGetTracesResponse BatchGetTraces(BatchGetTracesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return Invoke<BatchGetTracesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetTraces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<BatchGetTracesResponse> BatchGetTracesAsync(BatchGetTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetTracesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTracesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSamplingRule

        internal virtual CreateSamplingRuleResponse CreateSamplingRule(CreateSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSamplingRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateSamplingRuleResponse> CreateSamplingRuleAsync(CreateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSamplingRule

        internal virtual DeleteSamplingRuleResponse DeleteSamplingRule(DeleteSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSamplingRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteSamplingRuleResponse> DeleteSamplingRuleAsync(DeleteSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEncryptionConfig

        internal virtual GetEncryptionConfigResponse GetEncryptionConfig(GetEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetEncryptionConfigResponse> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroups

        internal virtual GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return Invoke<GetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingRules

        internal virtual GetSamplingRulesResponse GetSamplingRules(GetSamplingRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingRulesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSamplingRulesResponse> GetSamplingRulesAsync(GetSamplingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingStatisticSummaries

        internal virtual GetSamplingStatisticSummariesResponse GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingStatisticSummariesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingStatisticSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSamplingStatisticSummariesResponse> GetSamplingStatisticSummariesAsync(GetSamplingStatisticSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingStatisticSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingTargets

        internal virtual GetSamplingTargetsResponse GetSamplingTargets(GetSamplingTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return Invoke<GetSamplingTargetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSamplingTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSamplingTargetsResponse> GetSamplingTargetsAsync(GetSamplingTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSamplingTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceGraph

        internal virtual GetServiceGraphResponse GetServiceGraph(GetServiceGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return Invoke<GetServiceGraphResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetServiceGraphResponse> GetServiceGraphAsync(GetServiceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTraceGraph

        internal virtual GetTraceGraphResponse GetTraceGraph(GetTraceGraphRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return Invoke<GetTraceGraphResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceGraph operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetTraceGraphResponse> GetTraceGraphAsync(GetTraceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceGraphRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceGraphResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTraceSummaries

        internal virtual GetTraceSummariesResponse GetTraceSummaries(GetTraceSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return Invoke<GetTraceSummariesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTraceSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetTraceSummariesResponse> GetTraceSummariesAsync(GetTraceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTraceSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEncryptionConfig

        internal virtual PutEncryptionConfigResponse PutEncryptionConfig(PutEncryptionConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<PutEncryptionConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutEncryptionConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutEncryptionConfigResponse> PutEncryptionConfigAsync(PutEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEncryptionConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<PutEncryptionConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTelemetryRecords

        internal virtual PutTelemetryRecordsResponse PutTelemetryRecords(PutTelemetryRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return Invoke<PutTelemetryRecordsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutTelemetryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutTelemetryRecordsResponse> PutTelemetryRecordsAsync(PutTelemetryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTelemetryRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutTraceSegments

        internal virtual PutTraceSegmentsResponse PutTraceSegments(PutTraceSegmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return Invoke<PutTraceSegmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutTraceSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutTraceSegmentsResponse> PutTraceSegmentsAsync(PutTraceSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutTraceSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTraceSegmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSamplingRule

        internal virtual UpdateSamplingRuleResponse UpdateSamplingRule(UpdateSamplingRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSamplingRuleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSamplingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateSamplingRuleResponse> UpdateSamplingRuleAsync(UpdateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSamplingRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
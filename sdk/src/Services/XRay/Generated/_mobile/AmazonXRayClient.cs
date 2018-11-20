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
            var marshaller = BatchGetTracesRequestMarshaller.Instance;
            var unmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return Invoke<BatchGetTracesRequest,BatchGetTracesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchGetTracesRequestMarshaller.Instance;
            var unmarshaller = BatchGetTracesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTracesRequest,BatchGetTracesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateGroupRequestMarshaller.Instance;
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupRequest,CreateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSamplingRule

        internal virtual CreateSamplingRuleResponse CreateSamplingRule(CreateSamplingRuleRequest request)
        {
            var marshaller = CreateSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSamplingRuleRequest,CreateSamplingRuleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = CreateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSamplingRuleRequest,CreateSamplingRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSamplingRule

        internal virtual DeleteSamplingRuleResponse DeleteSamplingRule(DeleteSamplingRuleRequest request)
        {
            var marshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSamplingRuleRequest,DeleteSamplingRuleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = DeleteSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSamplingRuleRequest,DeleteSamplingRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEncryptionConfig

        internal virtual GetEncryptionConfigResponse GetEncryptionConfig(GetEncryptionConfigRequest request)
        {
            var marshaller = GetEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<GetEncryptionConfigRequest,GetEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = GetEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetEncryptionConfigRequest,GetEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroup

        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupRequest,GetGroupResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetGroupRequestMarshaller.Instance;
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupRequest,GetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGroups

        internal virtual GetGroupsResponse GetGroups(GetGroupsRequest request)
        {
            var marshaller = GetGroupsRequestMarshaller.Instance;
            var unmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return Invoke<GetGroupsRequest,GetGroupsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetGroupsRequestMarshaller.Instance;
            var unmarshaller = GetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupsRequest,GetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingRules

        internal virtual GetSamplingRulesResponse GetSamplingRules(GetSamplingRulesRequest request)
        {
            var marshaller = GetSamplingRulesRequestMarshaller.Instance;
            var unmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingRulesRequest,GetSamplingRulesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSamplingRulesRequestMarshaller.Instance;
            var unmarshaller = GetSamplingRulesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingRulesRequest,GetSamplingRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingStatisticSummaries

        internal virtual GetSamplingStatisticSummariesResponse GetSamplingStatisticSummaries(GetSamplingStatisticSummariesRequest request)
        {
            var marshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            var unmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return Invoke<GetSamplingStatisticSummariesRequest,GetSamplingStatisticSummariesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSamplingStatisticSummariesRequestMarshaller.Instance;
            var unmarshaller = GetSamplingStatisticSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingStatisticSummariesRequest,GetSamplingStatisticSummariesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSamplingTargets

        internal virtual GetSamplingTargetsResponse GetSamplingTargets(GetSamplingTargetsRequest request)
        {
            var marshaller = GetSamplingTargetsRequestMarshaller.Instance;
            var unmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return Invoke<GetSamplingTargetsRequest,GetSamplingTargetsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSamplingTargetsRequestMarshaller.Instance;
            var unmarshaller = GetSamplingTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSamplingTargetsRequest,GetSamplingTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServiceGraph

        internal virtual GetServiceGraphResponse GetServiceGraph(GetServiceGraphRequest request)
        {
            var marshaller = GetServiceGraphRequestMarshaller.Instance;
            var unmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return Invoke<GetServiceGraphRequest,GetServiceGraphResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetServiceGraphRequestMarshaller.Instance;
            var unmarshaller = GetServiceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceGraphRequest,GetServiceGraphResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTraceGraph

        internal virtual GetTraceGraphResponse GetTraceGraph(GetTraceGraphRequest request)
        {
            var marshaller = GetTraceGraphRequestMarshaller.Instance;
            var unmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return Invoke<GetTraceGraphRequest,GetTraceGraphResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetTraceGraphRequestMarshaller.Instance;
            var unmarshaller = GetTraceGraphResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceGraphRequest,GetTraceGraphResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTraceSummaries

        internal virtual GetTraceSummariesResponse GetTraceSummaries(GetTraceSummariesRequest request)
        {
            var marshaller = GetTraceSummariesRequestMarshaller.Instance;
            var unmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return Invoke<GetTraceSummariesRequest,GetTraceSummariesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetTraceSummariesRequestMarshaller.Instance;
            var unmarshaller = GetTraceSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetTraceSummariesRequest,GetTraceSummariesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutEncryptionConfig

        internal virtual PutEncryptionConfigResponse PutEncryptionConfig(PutEncryptionConfigRequest request)
        {
            var marshaller = PutEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return Invoke<PutEncryptionConfigRequest,PutEncryptionConfigResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutEncryptionConfigRequestMarshaller.Instance;
            var unmarshaller = PutEncryptionConfigResponseUnmarshaller.Instance;

            return InvokeAsync<PutEncryptionConfigRequest,PutEncryptionConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutTelemetryRecords

        internal virtual PutTelemetryRecordsResponse PutTelemetryRecords(PutTelemetryRecordsRequest request)
        {
            var marshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            var unmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return Invoke<PutTelemetryRecordsRequest,PutTelemetryRecordsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutTelemetryRecordsRequestMarshaller.Instance;
            var unmarshaller = PutTelemetryRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTelemetryRecordsRequest,PutTelemetryRecordsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutTraceSegments

        internal virtual PutTraceSegmentsResponse PutTraceSegments(PutTraceSegmentsRequest request)
        {
            var marshaller = PutTraceSegmentsRequestMarshaller.Instance;
            var unmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return Invoke<PutTraceSegmentsRequest,PutTraceSegmentsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutTraceSegmentsRequestMarshaller.Instance;
            var unmarshaller = PutTraceSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<PutTraceSegmentsRequest,PutTraceSegmentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSamplingRule

        internal virtual UpdateSamplingRuleResponse UpdateSamplingRule(UpdateSamplingRuleRequest request)
        {
            var marshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSamplingRuleRequest,UpdateSamplingRuleResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateSamplingRuleRequestMarshaller.Instance;
            var unmarshaller = UpdateSamplingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSamplingRuleRequest,UpdateSamplingRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Inspector.Model;
using Amazon.Inspector.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Inspector
{
    /// <summary>
    /// Implementation for accessing Inspector
    ///
    /// Amazon Inspector 
    /// <para>
    /// Amazon Inspector enables you to analyze the behavior of your AWS resources and to
    /// identify potential security issues. For more information, see <a href="http://docs.aws.amazon.com/inspector/latest/userguide/inspector_introduction.html">
    /// Amazon Inspector User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonInspectorClient : AmazonServiceClient, IAmazonInspector
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInspectorClient(AWSCredentials credentials)
            : this(credentials, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInspectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Credentials and an
        /// AmazonInspectorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(AWSCredentials credentials, AmazonInspectorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInspectorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInspectorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInspectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInspectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInspectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInspectorConfig clientConfig)
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

        
        #region  AddAttributesToFindings

        internal AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddAttributesToFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddAttributesToFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddAttributesToFindingsRequestMarshaller();
            var unmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttributesToFindingsRequest,AddAttributesToFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTarget

        internal CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var marshaller = new CreateAssessmentTargetRequestMarshaller();
            var unmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetRequest,CreateAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAssessmentTargetResponse> CreateAssessmentTargetAsync(CreateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssessmentTargetRequestMarshaller();
            var unmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTargetRequest,CreateAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTemplate

        internal CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var marshaller = new CreateAssessmentTemplateRequestMarshaller();
            var unmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateRequest,CreateAssessmentTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAssessmentTemplateResponse> CreateAssessmentTemplateAsync(CreateAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAssessmentTemplateRequestMarshaller();
            var unmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTemplateRequest,CreateAssessmentTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceGroup

        internal CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateResourceGroupRequestMarshaller();
            var unmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceGroupRequest,CreateResourceGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentRun

        internal DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var marshaller = new DeleteAssessmentRunRequestMarshaller();
            var unmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunRequest,DeleteAssessmentRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAssessmentRunResponse> DeleteAssessmentRunAsync(DeleteAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssessmentRunRequestMarshaller();
            var unmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentRunRequest,DeleteAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTarget

        internal DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var marshaller = new DeleteAssessmentTargetRequestMarshaller();
            var unmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetRequest,DeleteAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAssessmentTargetResponse> DeleteAssessmentTargetAsync(DeleteAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssessmentTargetRequestMarshaller();
            var unmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTargetRequest,DeleteAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTemplate

        internal DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var marshaller = new DeleteAssessmentTemplateRequestMarshaller();
            var unmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateRequest,DeleteAssessmentTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAssessmentTemplateResponse> DeleteAssessmentTemplateAsync(DeleteAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAssessmentTemplateRequestMarshaller();
            var unmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTemplateRequest,DeleteAssessmentTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentRuns

        internal DescribeAssessmentRunsResponse DescribeAssessmentRuns(DescribeAssessmentRunsRequest request)
        {
            var marshaller = new DescribeAssessmentRunsRequestMarshaller();
            var unmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsRequest,DescribeAssessmentRunsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAssessmentRunsResponse> DescribeAssessmentRunsAsync(DescribeAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssessmentRunsRequestMarshaller();
            var unmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentRunsRequest,DescribeAssessmentRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTargets

        internal DescribeAssessmentTargetsResponse DescribeAssessmentTargets(DescribeAssessmentTargetsRequest request)
        {
            var marshaller = new DescribeAssessmentTargetsRequestMarshaller();
            var unmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsRequest,DescribeAssessmentTargetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAssessmentTargetsResponse> DescribeAssessmentTargetsAsync(DescribeAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssessmentTargetsRequestMarshaller();
            var unmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTargetsRequest,DescribeAssessmentTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTemplates

        internal DescribeAssessmentTemplatesResponse DescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request)
        {
            var marshaller = new DescribeAssessmentTemplatesRequestMarshaller();
            var unmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesRequest,DescribeAssessmentTemplatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssessmentTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAssessmentTemplatesResponse> DescribeAssessmentTemplatesAsync(DescribeAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAssessmentTemplatesRequestMarshaller();
            var unmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTemplatesRequest,DescribeAssessmentTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCrossAccountAccessRole

        internal DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCrossAccountAccessRoleRequest,DescribeCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFindings

        internal DescribeFindingsResponse DescribeFindings(DescribeFindingsRequest request)
        {
            var marshaller = new DescribeFindingsRequestMarshaller();
            var unmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsRequest,DescribeFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeFindingsResponse> DescribeFindingsAsync(DescribeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFindingsRequestMarshaller();
            var unmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFindingsRequest,DescribeFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceGroups

        internal DescribeResourceGroupsResponse DescribeResourceGroups(DescribeResourceGroupsRequest request)
        {
            var marshaller = new DescribeResourceGroupsRequestMarshaller();
            var unmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsRequest,DescribeResourceGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeResourceGroupsResponse> DescribeResourceGroupsAsync(DescribeResourceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResourceGroupsRequestMarshaller();
            var unmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceGroupsRequest,DescribeResourceGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRulesPackages

        internal DescribeRulesPackagesResponse DescribeRulesPackages(DescribeRulesPackagesRequest request)
        {
            var marshaller = new DescribeRulesPackagesRequestMarshaller();
            var unmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesRequest,DescribeRulesPackagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRulesPackagesResponse> DescribeRulesPackagesAsync(DescribeRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRulesPackagesRequestMarshaller();
            var unmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesPackagesRequest,DescribeRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTelemetryMetadata

        internal GetTelemetryMetadataResponse GetTelemetryMetadata(GetTelemetryMetadataRequest request)
        {
            var marshaller = new GetTelemetryMetadataRequestMarshaller();
            var unmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataRequest,GetTelemetryMetadataResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetTelemetryMetadataResponse> GetTelemetryMetadataAsync(GetTelemetryMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTelemetryMetadataRequestMarshaller();
            var unmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetTelemetryMetadataRequest,GetTelemetryMetadataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRunAgents

        internal ListAssessmentRunAgentsResponse ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request)
        {
            var marshaller = new ListAssessmentRunAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsRequest,ListAssessmentRunAgentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRunAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRunAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentRunAgentsResponse> ListAssessmentRunAgentsAsync(ListAssessmentRunAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentRunAgentsRequestMarshaller();
            var unmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunAgentsRequest,ListAssessmentRunAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRuns

        internal ListAssessmentRunsResponse ListAssessmentRuns(ListAssessmentRunsRequest request)
        {
            var marshaller = new ListAssessmentRunsRequestMarshaller();
            var unmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsRequest,ListAssessmentRunsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentRunsResponse> ListAssessmentRunsAsync(ListAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentRunsRequestMarshaller();
            var unmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunsRequest,ListAssessmentRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTargets

        internal ListAssessmentTargetsResponse ListAssessmentTargets(ListAssessmentTargetsRequest request)
        {
            var marshaller = new ListAssessmentTargetsRequestMarshaller();
            var unmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsRequest,ListAssessmentTargetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentTargetsResponse> ListAssessmentTargetsAsync(ListAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentTargetsRequestMarshaller();
            var unmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTargetsRequest,ListAssessmentTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTemplates

        internal ListAssessmentTemplatesResponse ListAssessmentTemplates(ListAssessmentTemplatesRequest request)
        {
            var marshaller = new ListAssessmentTemplatesRequestMarshaller();
            var unmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesRequest,ListAssessmentTemplatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListAssessmentTemplatesResponse> ListAssessmentTemplatesAsync(ListAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAssessmentTemplatesRequestMarshaller();
            var unmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTemplatesRequest,ListAssessmentTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListEventSubscriptions

        internal ListEventSubscriptionsResponse ListEventSubscriptions(ListEventSubscriptionsRequest request)
        {
            var marshaller = new ListEventSubscriptionsRequestMarshaller();
            var unmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsRequest,ListEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListEventSubscriptionsResponse> ListEventSubscriptionsAsync(ListEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEventSubscriptionsRequestMarshaller();
            var unmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSubscriptionsRequest,ListEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var marshaller = new ListFindingsRequestMarshaller();
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsRequest,ListFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListFindingsRequestMarshaller();
            var unmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsRequest,ListFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRulesPackages

        internal ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRulesPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRulesPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRulesPackagesRequestMarshaller();
            var unmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesPackagesRequest,ListRulesPackagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PreviewAgents

        internal PreviewAgentsResponse PreviewAgents(PreviewAgentsRequest request)
        {
            var marshaller = new PreviewAgentsRequestMarshaller();
            var unmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsRequest,PreviewAgentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PreviewAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PreviewAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PreviewAgentsResponse> PreviewAgentsAsync(PreviewAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PreviewAgentsRequestMarshaller();
            var unmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewAgentsRequest,PreviewAgentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterCrossAccountAccessRole

        internal RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCrossAccountAccessRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCrossAccountAccessRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterCrossAccountAccessRoleRequestMarshaller();
            var unmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCrossAccountAccessRoleRequest,RegisterCrossAccountAccessRoleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveAttributesFromFindings

        internal RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributesFromFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributesFromFindings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveAttributesFromFindingsRequestMarshaller();
            var unmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesFromFindingsRequest,RemoveAttributesFromFindingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetTagsForResource

        internal SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTagsForResourceRequestMarshaller();
            var unmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SetTagsForResourceRequest,SetTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartAssessmentRun

        internal StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var marshaller = new StartAssessmentRunRequestMarshaller();
            var unmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunRequest,StartAssessmentRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartAssessmentRunResponse> StartAssessmentRunAsync(StartAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartAssessmentRunRequestMarshaller();
            var unmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssessmentRunRequest,StartAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopAssessmentRun

        internal StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var marshaller = new StopAssessmentRunRequestMarshaller();
            var unmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunRequest,StopAssessmentRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopAssessmentRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAssessmentRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopAssessmentRunResponse> StopAssessmentRunAsync(StopAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopAssessmentRunRequestMarshaller();
            var unmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopAssessmentRunRequest,StopAssessmentRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SubscribeToEvent

        internal SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var marshaller = new SubscribeToEventRequestMarshaller();
            var unmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventRequest,SubscribeToEventResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToEvent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SubscribeToEventResponse> SubscribeToEventAsync(SubscribeToEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SubscribeToEventRequestMarshaller();
            var unmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeToEventRequest,SubscribeToEventResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnsubscribeFromEvent

        internal UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var marshaller = new UnsubscribeFromEventRequestMarshaller();
            var unmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventRequest,UnsubscribeFromEventResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromEvent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnsubscribeFromEventResponse> UnsubscribeFromEventAsync(UnsubscribeFromEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnsubscribeFromEventRequestMarshaller();
            var unmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeFromEventRequest,UnsubscribeFromEventResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentTarget

        internal UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var marshaller = new UpdateAssessmentTargetRequestMarshaller();
            var unmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetRequest,UpdateAssessmentTargetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAssessmentTargetResponse> UpdateAssessmentTargetAsync(UpdateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAssessmentTargetRequestMarshaller();
            var unmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentTargetRequest,UpdateAssessmentTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
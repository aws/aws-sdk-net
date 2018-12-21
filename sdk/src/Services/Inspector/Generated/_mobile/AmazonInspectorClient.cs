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
using System.Net;

using Amazon.Inspector.Model;
using Amazon.Inspector.Model.Internal.MarshallTransformations;
using Amazon.Inspector.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonInspectorMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        public AmazonInspectorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInspectorConfig()) { }

        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        public AmazonInspectorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInspectorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInspectorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInspectorClient Configuration Object</param>
        public AmazonInspectorClient(AmazonInspectorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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


        #region  AddAttributesToFindings

        internal virtual AddAttributesToFindingsResponse AddAttributesToFindings(AddAttributesToFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return Invoke<AddAttributesToFindingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/AddAttributesToFindings">REST API Reference for AddAttributesToFindings Operation</seealso>
        public virtual Task<AddAttributesToFindingsResponse> AddAttributesToFindingsAsync(AddAttributesToFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddAttributesToFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddAttributesToFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddAttributesToFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTarget

        internal virtual CreateAssessmentTargetResponse CreateAssessmentTarget(CreateAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTargetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTarget">REST API Reference for CreateAssessmentTarget Operation</seealso>
        public virtual Task<CreateAssessmentTargetResponse> CreateAssessmentTargetAsync(CreateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentTemplate

        internal virtual CreateAssessmentTemplateResponse CreateAssessmentTemplate(CreateAssessmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentTemplateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateAssessmentTemplate">REST API Reference for CreateAssessmentTemplate Operation</seealso>
        public virtual Task<CreateAssessmentTemplateResponse> CreateAssessmentTemplateAsync(CreateAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateExclusionsPreview

        internal virtual CreateExclusionsPreviewResponse CreateExclusionsPreview(CreateExclusionsPreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<CreateExclusionsPreviewResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExclusionsPreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateExclusionsPreview">REST API Reference for CreateExclusionsPreview Operation</seealso>
        public virtual Task<CreateExclusionsPreviewResponse> CreateExclusionsPreviewAsync(CreateExclusionsPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExclusionsPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExclusionsPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceGroup

        internal virtual CreateResourceGroupResponse CreateResourceGroup(CreateResourceGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return Invoke<CreateResourceGroupResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/CreateResourceGroup">REST API Reference for CreateResourceGroup Operation</seealso>
        public virtual Task<CreateResourceGroupResponse> CreateResourceGroupAsync(CreateResourceGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentRun

        internal virtual DeleteAssessmentRunResponse DeleteAssessmentRun(DeleteAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentRunResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentRun">REST API Reference for DeleteAssessmentRun Operation</seealso>
        public virtual Task<DeleteAssessmentRunResponse> DeleteAssessmentRunAsync(DeleteAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTarget

        internal virtual DeleteAssessmentTargetResponse DeleteAssessmentTarget(DeleteAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTargetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTarget">REST API Reference for DeleteAssessmentTarget Operation</seealso>
        public virtual Task<DeleteAssessmentTargetResponse> DeleteAssessmentTargetAsync(DeleteAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentTemplate

        internal virtual DeleteAssessmentTemplateResponse DeleteAssessmentTemplate(DeleteAssessmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentTemplateResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DeleteAssessmentTemplate">REST API Reference for DeleteAssessmentTemplate Operation</seealso>
        public virtual Task<DeleteAssessmentTemplateResponse> DeleteAssessmentTemplateAsync(DeleteAssessmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentRuns

        internal virtual DescribeAssessmentRunsResponse DescribeAssessmentRuns(DescribeAssessmentRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentRunsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentRuns">REST API Reference for DescribeAssessmentRuns Operation</seealso>
        public virtual Task<DescribeAssessmentRunsResponse> DescribeAssessmentRunsAsync(DescribeAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTargets

        internal virtual DescribeAssessmentTargetsResponse DescribeAssessmentTargets(DescribeAssessmentTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTargetsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTargets">REST API Reference for DescribeAssessmentTargets Operation</seealso>
        public virtual Task<DescribeAssessmentTargetsResponse> DescribeAssessmentTargetsAsync(DescribeAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAssessmentTemplates

        internal virtual DescribeAssessmentTemplatesResponse DescribeAssessmentTemplates(DescribeAssessmentTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeAssessmentTemplatesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeAssessmentTemplates">REST API Reference for DescribeAssessmentTemplates Operation</seealso>
        public virtual Task<DescribeAssessmentTemplatesResponse> DescribeAssessmentTemplatesAsync(DescribeAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssessmentTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCrossAccountAccessRole

        internal virtual DescribeCrossAccountAccessRoleResponse DescribeCrossAccountAccessRole(DescribeCrossAccountAccessRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<DescribeCrossAccountAccessRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeCrossAccountAccessRole">REST API Reference for DescribeCrossAccountAccessRole Operation</seealso>
        public virtual Task<DescribeCrossAccountAccessRoleResponse> DescribeCrossAccountAccessRoleAsync(DescribeCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCrossAccountAccessRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExclusions

        internal virtual DescribeExclusionsResponse DescribeExclusions(DescribeExclusionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return Invoke<DescribeExclusionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExclusions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExclusions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeExclusions">REST API Reference for DescribeExclusions Operation</seealso>
        public virtual Task<DescribeExclusionsResponse> DescribeExclusionsAsync(DescribeExclusionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExclusionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExclusionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFindings

        internal virtual DescribeFindingsResponse DescribeFindings(DescribeFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFindingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeFindings">REST API Reference for DescribeFindings Operation</seealso>
        public virtual Task<DescribeFindingsResponse> DescribeFindingsAsync(DescribeFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourceGroups

        internal virtual DescribeResourceGroupsResponse DescribeResourceGroups(DescribeResourceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceGroupsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeResourceGroups">REST API Reference for DescribeResourceGroups Operation</seealso>
        public virtual Task<DescribeResourceGroupsResponse> DescribeResourceGroupsAsync(DescribeResourceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourceGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRulesPackages

        internal virtual DescribeRulesPackagesResponse DescribeRulesPackages(DescribeRulesPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesPackagesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/DescribeRulesPackages">REST API Reference for DescribeRulesPackages Operation</seealso>
        public virtual Task<DescribeRulesPackagesResponse> DescribeRulesPackagesAsync(DescribeRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssessmentReport

        internal virtual GetAssessmentReportResponse GetAssessmentReport(GetAssessmentReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetAssessmentReport">REST API Reference for GetAssessmentReport Operation</seealso>
        public virtual Task<GetAssessmentReportResponse> GetAssessmentReportAsync(GetAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExclusionsPreview

        internal virtual GetExclusionsPreviewResponse GetExclusionsPreview(GetExclusionsPreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return Invoke<GetExclusionsPreviewResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExclusionsPreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExclusionsPreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetExclusionsPreview">REST API Reference for GetExclusionsPreview Operation</seealso>
        public virtual Task<GetExclusionsPreviewResponse> GetExclusionsPreviewAsync(GetExclusionsPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExclusionsPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExclusionsPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetExclusionsPreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTelemetryMetadata

        internal virtual GetTelemetryMetadataResponse GetTelemetryMetadata(GetTelemetryMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryMetadataResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/GetTelemetryMetadata">REST API Reference for GetTelemetryMetadata Operation</seealso>
        public virtual Task<GetTelemetryMetadataResponse> GetTelemetryMetadataAsync(GetTelemetryMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetTelemetryMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRunAgents

        internal virtual ListAssessmentRunAgentsResponse ListAssessmentRunAgents(ListAssessmentRunAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunAgentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRunAgents">REST API Reference for ListAssessmentRunAgents Operation</seealso>
        public virtual Task<ListAssessmentRunAgentsResponse> ListAssessmentRunAgentsAsync(ListAssessmentRunAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunAgentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentRuns

        internal virtual ListAssessmentRunsResponse ListAssessmentRuns(ListAssessmentRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentRunsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentRuns">REST API Reference for ListAssessmentRuns Operation</seealso>
        public virtual Task<ListAssessmentRunsResponse> ListAssessmentRunsAsync(ListAssessmentRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentRunsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTargets

        internal virtual ListAssessmentTargetsResponse ListAssessmentTargets(ListAssessmentTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTargetsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTargets">REST API Reference for ListAssessmentTargets Operation</seealso>
        public virtual Task<ListAssessmentTargetsResponse> ListAssessmentTargetsAsync(ListAssessmentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentTemplates

        internal virtual ListAssessmentTemplatesResponse ListAssessmentTemplates(ListAssessmentTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentTemplatesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListAssessmentTemplates">REST API Reference for ListAssessmentTemplates Operation</seealso>
        public virtual Task<ListAssessmentTemplatesResponse> ListAssessmentTemplatesAsync(ListAssessmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventSubscriptions

        internal virtual ListEventSubscriptionsResponse ListEventSubscriptions(ListEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListEventSubscriptionsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListEventSubscriptions">REST API Reference for ListEventSubscriptions Operation</seealso>
        public virtual Task<ListEventSubscriptionsResponse> ListEventSubscriptionsAsync(ListEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExclusions

        internal virtual ListExclusionsResponse ListExclusions(ListExclusionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return Invoke<ListExclusionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListExclusions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExclusions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListExclusions">REST API Reference for ListExclusions Operation</seealso>
        public virtual Task<ListExclusionsResponse> ListExclusionsAsync(ListExclusionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExclusionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExclusionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExclusionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFindings

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRulesPackages

        internal virtual ListRulesPackagesResponse ListRulesPackages(ListRulesPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return Invoke<ListRulesPackagesResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListRulesPackages">REST API Reference for ListRulesPackages Operation</seealso>
        public virtual Task<ListRulesPackagesResponse> ListRulesPackagesAsync(ListRulesPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PreviewAgents

        internal virtual PreviewAgentsResponse PreviewAgents(PreviewAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return Invoke<PreviewAgentsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/PreviewAgents">REST API Reference for PreviewAgents Operation</seealso>
        public virtual Task<PreviewAgentsResponse> PreviewAgentsAsync(PreviewAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PreviewAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewAgentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterCrossAccountAccessRole

        internal virtual RegisterCrossAccountAccessRoleResponse RegisterCrossAccountAccessRole(RegisterCrossAccountAccessRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return Invoke<RegisterCrossAccountAccessRoleResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RegisterCrossAccountAccessRole">REST API Reference for RegisterCrossAccountAccessRole Operation</seealso>
        public virtual Task<RegisterCrossAccountAccessRoleResponse> RegisterCrossAccountAccessRoleAsync(RegisterCrossAccountAccessRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterCrossAccountAccessRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterCrossAccountAccessRoleResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterCrossAccountAccessRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAttributesFromFindings

        internal virtual RemoveAttributesFromFindingsResponse RemoveAttributesFromFindings(RemoveAttributesFromFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesFromFindingsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/RemoveAttributesFromFindings">REST API Reference for RemoveAttributesFromFindings Operation</seealso>
        public virtual Task<RemoveAttributesFromFindingsResponse> RemoveAttributesFromFindingsAsync(RemoveAttributesFromFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAttributesFromFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesFromFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAttributesFromFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTagsForResource

        internal virtual SetTagsForResourceResponse SetTagsForResource(SetTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<SetTagsForResourceResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SetTagsForResource">REST API Reference for SetTagsForResource Operation</seealso>
        public virtual Task<SetTagsForResourceResponse> SetTagsForResourceAsync(SetTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SetTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAssessmentRun

        internal virtual StartAssessmentRunResponse StartAssessmentRun(StartAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentRunResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StartAssessmentRun">REST API Reference for StartAssessmentRun Operation</seealso>
        public virtual Task<StartAssessmentRunResponse> StartAssessmentRunAsync(StartAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartAssessmentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopAssessmentRun

        internal virtual StopAssessmentRunResponse StopAssessmentRun(StopAssessmentRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return Invoke<StopAssessmentRunResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/StopAssessmentRun">REST API Reference for StopAssessmentRun Operation</seealso>
        public virtual Task<StopAssessmentRunResponse> StopAssessmentRunAsync(StopAssessmentRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAssessmentRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAssessmentRunResponseUnmarshaller.Instance;

            return InvokeAsync<StopAssessmentRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubscribeToEvent

        internal virtual SubscribeToEventResponse SubscribeToEvent(SubscribeToEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return Invoke<SubscribeToEventResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/SubscribeToEvent">REST API Reference for SubscribeToEvent Operation</seealso>
        public virtual Task<SubscribeToEventResponse> SubscribeToEventAsync(SubscribeToEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubscribeToEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubscribeToEventResponseUnmarshaller.Instance;

            return InvokeAsync<SubscribeToEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnsubscribeFromEvent

        internal virtual UnsubscribeFromEventResponse UnsubscribeFromEvent(UnsubscribeFromEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromEventResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UnsubscribeFromEvent">REST API Reference for UnsubscribeFromEvent Operation</seealso>
        public virtual Task<UnsubscribeFromEventResponse> UnsubscribeFromEventAsync(UnsubscribeFromEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnsubscribeFromEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnsubscribeFromEventResponseUnmarshaller.Instance;

            return InvokeAsync<UnsubscribeFromEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentTarget

        internal virtual UpdateAssessmentTargetResponse UpdateAssessmentTarget(UpdateAssessmentTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentTargetResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/inspector-2016-02-16/UpdateAssessmentTarget">REST API Reference for UpdateAssessmentTarget Operation</seealso>
        public virtual Task<UpdateAssessmentTargetResponse> UpdateAssessmentTargetAsync(UpdateAssessmentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentTargetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
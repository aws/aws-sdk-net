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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MigrationHub.Model;
using Amazon.MigrationHub.Model.Internal.MarshallTransformations;
using Amazon.MigrationHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MigrationHub
{
    /// <summary>
    /// Implementation for accessing MigrationHub
    ///
    /// The AWS Migration Hub API methods help to obtain server and application migration
    /// status and integrate your resource-specific migration tool by providing a programmatic
    /// interface to Migration Hub.
    /// </summary>
    public partial class AmazonMigrationHubClient : AmazonServiceClient, IAmazonMigrationHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonMigrationHubMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
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
        public AmazonMigrationHubClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubConfig()) { }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
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
        public AmazonMigrationHubClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMigrationHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(AmazonMigrationHubConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMigrationHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMigrationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Credentials and an
        /// AmazonMigrationHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(AWSCredentials credentials, AmazonMigrationHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMigrationHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMigrationHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMigrationHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMigrationHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMigrationHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMigrationHubClient Configuration Object</param>
        public AmazonMigrationHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMigrationHubConfig clientConfig)
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


        #region  AssociateCreatedArtifact

        internal virtual AssociateCreatedArtifactResponse AssociateCreatedArtifact(AssociateCreatedArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCreatedArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCreatedArtifactResponseUnmarshaller.Instance;

            return Invoke<AssociateCreatedArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCreatedArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateCreatedArtifact">REST API Reference for AssociateCreatedArtifact Operation</seealso>
        public virtual Task<AssociateCreatedArtifactResponse> AssociateCreatedArtifactAsync(AssociateCreatedArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCreatedArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCreatedArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateCreatedArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDiscoveredResource

        internal virtual AssociateDiscoveredResourceResponse AssociateDiscoveredResource(AssociateDiscoveredResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDiscoveredResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDiscoveredResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateDiscoveredResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDiscoveredResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/AssociateDiscoveredResource">REST API Reference for AssociateDiscoveredResource Operation</seealso>
        public virtual Task<AssociateDiscoveredResourceResponse> AssociateDiscoveredResourceAsync(AssociateDiscoveredResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDiscoveredResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDiscoveredResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDiscoveredResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProgressUpdateStream

        internal virtual CreateProgressUpdateStreamResponse CreateProgressUpdateStream(CreateProgressUpdateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgressUpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgressUpdateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateProgressUpdateStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProgressUpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/CreateProgressUpdateStream">REST API Reference for CreateProgressUpdateStream Operation</seealso>
        public virtual Task<CreateProgressUpdateStreamResponse> CreateProgressUpdateStreamAsync(CreateProgressUpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProgressUpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProgressUpdateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProgressUpdateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProgressUpdateStream

        internal virtual DeleteProgressUpdateStreamResponse DeleteProgressUpdateStream(DeleteProgressUpdateStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgressUpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgressUpdateStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteProgressUpdateStreamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProgressUpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgressUpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DeleteProgressUpdateStream">REST API Reference for DeleteProgressUpdateStream Operation</seealso>
        public virtual Task<DeleteProgressUpdateStreamResponse> DeleteProgressUpdateStreamAsync(DeleteProgressUpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProgressUpdateStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProgressUpdateStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProgressUpdateStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationState

        internal virtual DescribeApplicationStateResponse DescribeApplicationState(DescribeApplicationStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationStateResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationStateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeApplicationState">REST API Reference for DescribeApplicationState Operation</seealso>
        public virtual Task<DescribeApplicationStateResponse> DescribeApplicationStateAsync(DescribeApplicationStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationStateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMigrationTask

        internal virtual DescribeMigrationTaskResponse DescribeMigrationTask(DescribeMigrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMigrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeMigrationTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMigrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DescribeMigrationTask">REST API Reference for DescribeMigrationTask Operation</seealso>
        public virtual Task<DescribeMigrationTaskResponse> DescribeMigrationTaskAsync(DescribeMigrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMigrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMigrationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMigrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateCreatedArtifact

        internal virtual DisassociateCreatedArtifactResponse DisassociateCreatedArtifact(DisassociateCreatedArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCreatedArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCreatedArtifactResponseUnmarshaller.Instance;

            return Invoke<DisassociateCreatedArtifactResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCreatedArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCreatedArtifact operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateCreatedArtifact">REST API Reference for DisassociateCreatedArtifact Operation</seealso>
        public virtual Task<DisassociateCreatedArtifactResponse> DisassociateCreatedArtifactAsync(DisassociateCreatedArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCreatedArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCreatedArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateCreatedArtifactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateDiscoveredResource

        internal virtual DisassociateDiscoveredResourceResponse DisassociateDiscoveredResource(DisassociateDiscoveredResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDiscoveredResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDiscoveredResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateDiscoveredResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDiscoveredResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDiscoveredResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/DisassociateDiscoveredResource">REST API Reference for DisassociateDiscoveredResource Operation</seealso>
        public virtual Task<DisassociateDiscoveredResourceResponse> DisassociateDiscoveredResourceAsync(DisassociateDiscoveredResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateDiscoveredResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateDiscoveredResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateDiscoveredResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportMigrationTask

        internal virtual ImportMigrationTaskResponse ImportMigrationTask(ImportMigrationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportMigrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportMigrationTaskResponseUnmarshaller.Instance;

            return Invoke<ImportMigrationTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportMigrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportMigrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ImportMigrationTask">REST API Reference for ImportMigrationTask Operation</seealso>
        public virtual Task<ImportMigrationTaskResponse> ImportMigrationTaskAsync(ImportMigrationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportMigrationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportMigrationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<ImportMigrationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCreatedArtifacts

        internal virtual ListCreatedArtifactsResponse ListCreatedArtifacts(ListCreatedArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCreatedArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCreatedArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListCreatedArtifactsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCreatedArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreatedArtifacts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListCreatedArtifacts">REST API Reference for ListCreatedArtifacts Operation</seealso>
        public virtual Task<ListCreatedArtifactsResponse> ListCreatedArtifactsAsync(ListCreatedArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCreatedArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCreatedArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCreatedArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDiscoveredResources

        internal virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveredResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMigrationTasks

        internal virtual ListMigrationTasksResponse ListMigrationTasks(ListMigrationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMigrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMigrationTasksResponseUnmarshaller.Instance;

            return Invoke<ListMigrationTasksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMigrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMigrationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListMigrationTasks">REST API Reference for ListMigrationTasks Operation</seealso>
        public virtual Task<ListMigrationTasksResponse> ListMigrationTasksAsync(ListMigrationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMigrationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMigrationTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListMigrationTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProgressUpdateStreams

        internal virtual ListProgressUpdateStreamsResponse ListProgressUpdateStreams(ListProgressUpdateStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProgressUpdateStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProgressUpdateStreamsResponseUnmarshaller.Instance;

            return Invoke<ListProgressUpdateStreamsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProgressUpdateStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProgressUpdateStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/ListProgressUpdateStreams">REST API Reference for ListProgressUpdateStreams Operation</seealso>
        public virtual Task<ListProgressUpdateStreamsResponse> ListProgressUpdateStreamsAsync(ListProgressUpdateStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProgressUpdateStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProgressUpdateStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProgressUpdateStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyApplicationState

        internal virtual NotifyApplicationStateResponse NotifyApplicationState(NotifyApplicationStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyApplicationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyApplicationStateResponseUnmarshaller.Instance;

            return Invoke<NotifyApplicationStateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyApplicationState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyApplicationState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyApplicationState">REST API Reference for NotifyApplicationState Operation</seealso>
        public virtual Task<NotifyApplicationStateResponse> NotifyApplicationStateAsync(NotifyApplicationStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyApplicationStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyApplicationStateResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyApplicationStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyMigrationTaskState

        internal virtual NotifyMigrationTaskStateResponse NotifyMigrationTaskState(NotifyMigrationTaskStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyMigrationTaskStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyMigrationTaskStateResponseUnmarshaller.Instance;

            return Invoke<NotifyMigrationTaskStateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the NotifyMigrationTaskState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyMigrationTaskState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/NotifyMigrationTaskState">REST API Reference for NotifyMigrationTaskState Operation</seealso>
        public virtual Task<NotifyMigrationTaskStateResponse> NotifyMigrationTaskStateAsync(NotifyMigrationTaskStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyMigrationTaskStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyMigrationTaskStateResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyMigrationTaskStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourceAttributes

        internal virtual PutResourceAttributesResponse PutResourceAttributes(PutResourceAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceAttributesResponseUnmarshaller.Instance;

            return Invoke<PutResourceAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSMigrationHub-2017-05-31/PutResourceAttributes">REST API Reference for PutResourceAttributes Operation</seealso>
        public virtual Task<PutResourceAttributesResponse> PutResourceAttributesAsync(PutResourceAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourceAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
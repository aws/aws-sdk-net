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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Glacier
{
    /// <summary>
    /// Implementation for accessing Glacier
    ///
    /// Amazon Glacier is a storage solution for "cold data."
    /// 
    ///  
    /// <para>
    /// Amazon Glacier is an extremely low-cost storage service that provides secure, durable,
    /// and easy-to-use storage for data backup and archival. With Amazon Glacier, customers
    /// can store their data cost effectively for months, years, or decades. Amazon Glacier
    /// also enables customers to offload the administrative burdens of operating and scaling
    /// storage to AWS, so they don't have to worry about capacity planning, hardware provisioning,
    /// data replication, hardware failure and recovery, or time-consuming hardware migrations.
    /// </para>
    ///  
    /// <para>
    /// Amazon Glacier is a great storage choice when low storage cost is paramount, your
    /// data is rarely retrieved, and retrieval latency of several hours is acceptable. If
    /// your application requires fast or frequent access to your data, consider using Amazon
    /// S3. For more information, go to <a href="http://aws.amazon.com/s3/">Amazon Simple
    /// Storage Service (Amazon S3)</a>.
    /// </para>
    ///  
    /// <para>
    /// You can store any kind of data in any format. There is no maximum limit on the total
    /// amount of data you can store in Amazon Glacier. 
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Glacier, we recommend that you begin by reading
    /// the following sections in the <i>Amazon Glacier Developer Guide</i>:
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    /// </li> <li>
    /// <para>
    /// <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon Glacier</a> - The Getting Started section walks you through the
    /// process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    /// </li> </ul>
    /// </summary>
    public partial class AmazonGlacierClient : AmazonServiceClient, IAmazonGlacier
    {
        
        #region Constructors

#if DNX
    
        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        public AmazonGlacierClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig()) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        public AmazonGlacierClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGlacierConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGlacierClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(AmazonGlacierConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGlacierClient(AWSCredentials credentials)
            : this(credentials, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGlacierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Credentials and an
        /// AmazonGlacierClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(AWSCredentials credentials, AmazonGlacierConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGlacierConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGlacierConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGlacierConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGlacierClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGlacierClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGlacierClient Configuration Object</param>
        public AmazonGlacierClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGlacierConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Glacier.Internal.ProcessRequestHandler());
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

        
        #region  AbortMultipartUpload

        internal AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadRequest,AbortMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AbortVaultLock

        internal AbortVaultLockResponse AbortVaultLock(AbortVaultLockRequest request)
        {
            var marshaller = new AbortVaultLockRequestMarshaller();
            var unmarshaller = AbortVaultLockResponseUnmarshaller.Instance;

            return Invoke<AbortVaultLockRequest,AbortVaultLockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AbortVaultLockResponse> AbortVaultLockAsync(AbortVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortVaultLockRequestMarshaller();
            var unmarshaller = AbortVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<AbortVaultLockRequest,AbortVaultLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToVault

        internal AddTagsToVaultResponse AddTagsToVault(AddTagsToVaultRequest request)
        {
            var marshaller = new AddTagsToVaultRequestMarshaller();
            var unmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;

            return Invoke<AddTagsToVaultRequest,AddTagsToVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddTagsToVaultResponse> AddTagsToVaultAsync(AddTagsToVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToVaultRequestMarshaller();
            var unmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToVaultRequest,AddTagsToVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        internal CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteVaultLock

        internal CompleteVaultLockResponse CompleteVaultLock(CompleteVaultLockRequest request)
        {
            var marshaller = new CompleteVaultLockRequestMarshaller();
            var unmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;

            return Invoke<CompleteVaultLockRequest,CompleteVaultLockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteVaultLockResponse> CompleteVaultLockAsync(CompleteVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteVaultLockRequestMarshaller();
            var unmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteVaultLockRequest,CompleteVaultLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVault

        internal CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            var marshaller = new CreateVaultRequestMarshaller();
            var unmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return Invoke<CreateVaultRequest,CreateVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVaultRequestMarshaller();
            var unmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVaultRequest,CreateVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchive

        internal DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var marshaller = new DeleteArchiveRequestMarshaller();
            var unmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveRequest,DeleteArchiveResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteArchiveRequestMarshaller();
            var unmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArchiveRequest,DeleteArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVault

        internal DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            var marshaller = new DeleteVaultRequestMarshaller();
            var unmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultRequest,DeleteVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVaultRequestMarshaller();
            var unmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultRequest,DeleteVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultAccessPolicy

        internal DeleteVaultAccessPolicyResponse DeleteVaultAccessPolicy(DeleteVaultAccessPolicyRequest request)
        {
            var marshaller = new DeleteVaultAccessPolicyRequestMarshaller();
            var unmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultAccessPolicyRequest,DeleteVaultAccessPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVaultAccessPolicyResponse> DeleteVaultAccessPolicyAsync(DeleteVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVaultAccessPolicyRequestMarshaller();
            var unmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultAccessPolicyRequest,DeleteVaultAccessPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultNotifications

        internal DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest request)
        {
            var marshaller = new DeleteVaultNotificationsRequestMarshaller();
            var unmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultNotificationsRequest,DeleteVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVaultNotificationsResponse> DeleteVaultNotificationsAsync(DeleteVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVaultNotificationsRequestMarshaller();
            var unmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultNotificationsRequest,DeleteVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobRequest,DescribeJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeJobRequestMarshaller();
            var unmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobRequest,DescribeJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVault

        internal DescribeVaultResponse DescribeVault(DescribeVaultRequest request)
        {
            var marshaller = new DescribeVaultRequestMarshaller();
            var unmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeVaultRequest,DescribeVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVaultResponse> DescribeVaultAsync(DescribeVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVaultRequestMarshaller();
            var unmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVaultRequest,DescribeVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDataRetrievalPolicy

        internal GetDataRetrievalPolicyResponse GetDataRetrievalPolicy(GetDataRetrievalPolicyRequest request)
        {
            var marshaller = new GetDataRetrievalPolicyRequestMarshaller();
            var unmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDataRetrievalPolicyRequest,GetDataRetrievalPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDataRetrievalPolicyResponse> GetDataRetrievalPolicyAsync(GetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDataRetrievalPolicyRequestMarshaller();
            var unmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataRetrievalPolicyRequest,GetDataRetrievalPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetJobOutput

        internal GetJobOutputResponse GetJobOutput(GetJobOutputRequest request)
        {
            var marshaller = new GetJobOutputRequestMarshaller();
            var unmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return Invoke<GetJobOutputRequest,GetJobOutputResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetJobOutputResponse> GetJobOutputAsync(GetJobOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetJobOutputRequestMarshaller();
            var unmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobOutputRequest,GetJobOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVaultAccessPolicy

        internal GetVaultAccessPolicyResponse GetVaultAccessPolicy(GetVaultAccessPolicyRequest request)
        {
            var marshaller = new GetVaultAccessPolicyRequestMarshaller();
            var unmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetVaultAccessPolicyRequest,GetVaultAccessPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetVaultAccessPolicyResponse> GetVaultAccessPolicyAsync(GetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetVaultAccessPolicyRequestMarshaller();
            var unmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultAccessPolicyRequest,GetVaultAccessPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVaultLock

        internal GetVaultLockResponse GetVaultLock(GetVaultLockRequest request)
        {
            var marshaller = new GetVaultLockRequestMarshaller();
            var unmarshaller = GetVaultLockResponseUnmarshaller.Instance;

            return Invoke<GetVaultLockRequest,GetVaultLockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetVaultLockResponse> GetVaultLockAsync(GetVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetVaultLockRequestMarshaller();
            var unmarshaller = GetVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultLockRequest,GetVaultLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVaultNotifications

        internal GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest request)
        {
            var marshaller = new GetVaultNotificationsRequestMarshaller();
            var unmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetVaultNotificationsRequest,GetVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetVaultNotificationsResponse> GetVaultNotificationsAsync(GetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetVaultNotificationsRequestMarshaller();
            var unmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultNotificationsRequest,GetVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateJob

        internal InitiateJobResponse InitiateJob(InitiateJobRequest request)
        {
            var marshaller = new InitiateJobRequestMarshaller();
            var unmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return Invoke<InitiateJobRequest,InitiateJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateJobResponse> InitiateJobAsync(InitiateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateJobRequestMarshaller();
            var unmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateJobRequest,InitiateJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        internal InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateVaultLock

        internal InitiateVaultLockResponse InitiateVaultLock(InitiateVaultLockRequest request)
        {
            var marshaller = new InitiateVaultLockRequestMarshaller();
            var unmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;

            return Invoke<InitiateVaultLockRequest,InitiateVaultLockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateVaultLock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<InitiateVaultLockResponse> InitiateVaultLockAsync(InitiateVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateVaultLockRequestMarshaller();
            var unmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateVaultLockRequest,InitiateVaultLockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsRequest,ListJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsRequestMarshaller();
            var unmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsRequest,ListJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        internal ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsRequest,ListMultipartUploadsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        internal ListPartsResponse ListParts(ListPartsRequest request)
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsRequest,ListPartsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsRequest,ListPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForVault

        internal ListTagsForVaultResponse ListTagsForVault(ListTagsForVaultRequest request)
        {
            var marshaller = new ListTagsForVaultRequestMarshaller();
            var unmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;

            return Invoke<ListTagsForVaultRequest,ListTagsForVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForVaultResponse> ListTagsForVaultAsync(ListTagsForVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForVaultRequestMarshaller();
            var unmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForVaultRequest,ListTagsForVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVaults

        internal ListVaultsResponse ListVaults()
        {
            return ListVaults(new ListVaultsRequest());
        }
        internal ListVaultsResponse ListVaults(ListVaultsRequest request)
        {
            var marshaller = new ListVaultsRequestMarshaller();
            var unmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return Invoke<ListVaultsRequest,ListVaultsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name. 
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 1,000 items. If there are more vaults to
        /// list, the response <code class="code">marker</code> field contains the vault Amazon
        /// Resource Name (ARN) at which to continue the list with a new List Vaults request;
        /// otherwise, the <code class="code">marker</code> field is <code class="code">null</code>.
        /// To return a list of vaults that begins at a specific vault, set the <code class="code">marker</code>
        /// request parameter to the vault ARN you obtained from a previous List Vaults request.
        /// You can also limit the number of vaults returned in the response by specifying the
        /// <code class="code">limit</code> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, go to <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVaults service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource, such as a vault, upload ID, or job ID, does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public Task<ListVaultsResponse> ListVaultsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListVaultsAsync(new ListVaultsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVaults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListVaultsResponse> ListVaultsAsync(ListVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVaultsRequestMarshaller();
            var unmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVaultsRequest,ListVaultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromVault

        internal RemoveTagsFromVaultResponse RemoveTagsFromVault(RemoveTagsFromVaultRequest request)
        {
            var marshaller = new RemoveTagsFromVaultRequestMarshaller();
            var unmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromVaultRequest,RemoveTagsFromVaultResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveTagsFromVaultResponse> RemoveTagsFromVaultAsync(RemoveTagsFromVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromVaultRequestMarshaller();
            var unmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromVaultRequest,RemoveTagsFromVaultResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetDataRetrievalPolicy

        internal SetDataRetrievalPolicyResponse SetDataRetrievalPolicy(SetDataRetrievalPolicyRequest request)
        {
            var marshaller = new SetDataRetrievalPolicyRequestMarshaller();
            var unmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<SetDataRetrievalPolicyRequest,SetDataRetrievalPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetDataRetrievalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetDataRetrievalPolicyResponse> SetDataRetrievalPolicyAsync(SetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetDataRetrievalPolicyRequestMarshaller();
            var unmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetDataRetrievalPolicyRequest,SetDataRetrievalPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetVaultAccessPolicy

        internal SetVaultAccessPolicyResponse SetVaultAccessPolicy(SetVaultAccessPolicyRequest request)
        {
            var marshaller = new SetVaultAccessPolicyRequestMarshaller();
            var unmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<SetVaultAccessPolicyRequest,SetVaultAccessPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetVaultAccessPolicyResponse> SetVaultAccessPolicyAsync(SetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetVaultAccessPolicyRequestMarshaller();
            var unmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetVaultAccessPolicyRequest,SetVaultAccessPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetVaultNotifications

        internal SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest request)
        {
            var marshaller = new SetVaultNotificationsRequestMarshaller();
            var unmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<SetVaultNotificationsRequest,SetVaultNotificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetVaultNotificationsResponse> SetVaultNotificationsAsync(SetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetVaultNotificationsRequestMarshaller();
            var unmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<SetVaultNotificationsRequest,SetVaultNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadArchive

        internal UploadArchiveResponse UploadArchive(UploadArchiveRequest request)
        {
            var marshaller = new UploadArchiveRequestMarshaller();
            var unmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return Invoke<UploadArchiveRequest,UploadArchiveResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadArchiveResponse> UploadArchiveAsync(UploadArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadArchiveRequestMarshaller();
            var unmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<UploadArchiveRequest,UploadArchiveResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UploadMultipartPart

        internal UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest request)
        {
            var marshaller = new UploadMultipartPartRequestMarshaller();
            var unmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return Invoke<UploadMultipartPartRequest,UploadMultipartPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadMultipartPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UploadMultipartPartResponse> UploadMultipartPartAsync(UploadMultipartPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadMultipartPartRequestMarshaller();
            var unmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadMultipartPartRequest,UploadMultipartPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
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
using System.Net;

using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Glacier.Internal;
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
    /// Amazon Glacier is a great storage choice when low storage cost is paramount and your
    /// data is rarely retrieved. If your application requires fast or frequent access to
    /// your data, consider using Amazon S3. For more information, see <a href="http://aws.amazon.com/s3/">Amazon
    /// Simple Storage Service (Amazon S3)</a>.
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
    ///  <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon Glacier</a> - The Getting Started section walks you through the
    /// process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonGlacierClient : AmazonServiceClient, IAmazonGlacier
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlacierMetadata();
        
        #region Constructors

#if CORECLR
    
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


        #region  AbortMultipartUpload

        internal virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadResponse>(request, options);
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
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AbortVaultLock

        internal virtual AbortVaultLockResponse AbortVaultLock(AbortVaultLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortVaultLockResponseUnmarshaller.Instance;

            return Invoke<AbortVaultLockResponse>(request, options);
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
        public virtual Task<AbortVaultLockResponse> AbortVaultLockAsync(AbortVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<AbortVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToVault

        internal virtual AddTagsToVaultResponse AddTagsToVault(AddTagsToVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;

            return Invoke<AddTagsToVaultResponse>(request, options);
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
        public virtual Task<AddTagsToVaultResponse> AddTagsToVaultAsync(AddTagsToVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        internal virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadResponse>(request, options);
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
        public virtual Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteVaultLock

        internal virtual CompleteVaultLockResponse CompleteVaultLock(CompleteVaultLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;

            return Invoke<CompleteVaultLockResponse>(request, options);
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
        public virtual Task<CompleteVaultLockResponse> CompleteVaultLockAsync(CompleteVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVault

        internal virtual CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return Invoke<CreateVaultResponse>(request, options);
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
        public virtual Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchive

        internal virtual DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveResponse>(request, options);
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
        public virtual Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVault

        internal virtual DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultResponse>(request, options);
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
        public virtual Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultAccessPolicy

        internal virtual DeleteVaultAccessPolicyResponse DeleteVaultAccessPolicy(DeleteVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultAccessPolicyResponse>(request, options);
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
        public virtual Task<DeleteVaultAccessPolicyResponse> DeleteVaultAccessPolicyAsync(DeleteVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultNotifications

        internal virtual DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultNotificationsResponse>(request, options);
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
        public virtual Task<DeleteVaultNotificationsResponse> DeleteVaultNotificationsAsync(DeleteVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob

        internal virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
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
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVault

        internal virtual DescribeVaultResponse DescribeVault(DescribeVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeVaultResponse>(request, options);
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
        public virtual Task<DescribeVaultResponse> DescribeVaultAsync(DescribeVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataRetrievalPolicy

        internal virtual GetDataRetrievalPolicyResponse GetDataRetrievalPolicy(GetDataRetrievalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDataRetrievalPolicyResponse>(request, options);
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
        public virtual Task<GetDataRetrievalPolicyResponse> GetDataRetrievalPolicyAsync(GetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataRetrievalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobOutput

        internal virtual GetJobOutputResponse GetJobOutput(GetJobOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return Invoke<GetJobOutputResponse>(request, options);
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
        public virtual Task<GetJobOutputResponse> GetJobOutputAsync(GetJobOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultAccessPolicy

        internal virtual GetVaultAccessPolicyResponse GetVaultAccessPolicy(GetVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetVaultAccessPolicyResponse>(request, options);
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
        public virtual Task<GetVaultAccessPolicyResponse> GetVaultAccessPolicyAsync(GetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultLock

        internal virtual GetVaultLockResponse GetVaultLock(GetVaultLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultLockResponseUnmarshaller.Instance;

            return Invoke<GetVaultLockResponse>(request, options);
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
        public virtual Task<GetVaultLockResponse> GetVaultLockAsync(GetVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultNotifications

        internal virtual GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetVaultNotificationsResponse>(request, options);
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
        public virtual Task<GetVaultNotificationsResponse> GetVaultNotificationsAsync(GetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateJob

        internal virtual InitiateJobResponse InitiateJob(InitiateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return Invoke<InitiateJobResponse>(request, options);
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
        public virtual Task<InitiateJobResponse> InitiateJobAsync(InitiateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        internal virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadResponse>(request, options);
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
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateVaultLock

        internal virtual InitiateVaultLockResponse InitiateVaultLock(InitiateVaultLockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;

            return Invoke<InitiateVaultLockResponse>(request, options);
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
        public virtual Task<InitiateVaultLockResponse> InitiateVaultLockAsync(InitiateVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
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
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        internal virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsResponse>(request, options);
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
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        internal virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsResponse>(request, options);
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
        public virtual Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedCapacity

        internal virtual ListProvisionedCapacityResponse ListProvisionedCapacity(ListProvisionedCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedCapacityResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedCapacityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListProvisionedCapacityResponse> ListProvisionedCapacityAsync(ListProvisionedCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<ListProvisionedCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForVault

        internal virtual ListTagsForVaultResponse ListTagsForVault(ListTagsForVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;

            return Invoke<ListTagsForVaultResponse>(request, options);
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
        public virtual Task<ListTagsForVaultResponse> ListTagsForVaultAsync(ListTagsForVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVaults

        internal virtual ListVaultsResponse ListVaults()
        {
            return ListVaults(new ListVaultsRequest());
        }
        internal virtual ListVaultsResponse ListVaults(ListVaultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return Invoke<ListVaultsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 10 items. If there are more vaults to list,
        /// the response <code>marker</code> field contains the vault Amazon Resource Name (ARN)
        /// at which to continue the list with a new List Vaults request; otherwise, the <code>marker</code>
        /// field is <code>null</code>. To return a list of vaults that begins at a specific vault,
        /// set the <code>marker</code> request parameter to the vault ARN you obtained from a
        /// previous List Vaults request. You can also limit the number of vaults returned in
        /// the response by specifying the <code>limit</code> parameter in the request. 
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
        /// For conceptual information and underlying REST API, see <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon Glacier</a> and <a href="http://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
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
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public virtual Task<ListVaultsResponse> ListVaultsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public virtual Task<ListVaultsResponse> ListVaultsAsync(ListVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVaultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVaultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseProvisionedCapacity

        internal virtual PurchaseProvisionedCapacityResponse PurchaseProvisionedCapacity(PurchaseProvisionedCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseProvisionedCapacityResponseUnmarshaller.Instance;

            return Invoke<PurchaseProvisionedCapacityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseProvisionedCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseProvisionedCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PurchaseProvisionedCapacityResponse> PurchaseProvisionedCapacityAsync(PurchaseProvisionedCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseProvisionedCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseProvisionedCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromVault

        internal virtual RemoveTagsFromVaultResponse RemoveTagsFromVault(RemoveTagsFromVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromVaultResponse>(request, options);
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
        public virtual Task<RemoveTagsFromVaultResponse> RemoveTagsFromVaultAsync(RemoveTagsFromVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDataRetrievalPolicy

        internal virtual SetDataRetrievalPolicyResponse SetDataRetrievalPolicy(SetDataRetrievalPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<SetDataRetrievalPolicyResponse>(request, options);
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
        public virtual Task<SetDataRetrievalPolicyResponse> SetDataRetrievalPolicyAsync(SetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetDataRetrievalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetVaultAccessPolicy

        internal virtual SetVaultAccessPolicyResponse SetVaultAccessPolicy(SetVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<SetVaultAccessPolicyResponse>(request, options);
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
        public virtual Task<SetVaultAccessPolicyResponse> SetVaultAccessPolicyAsync(SetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetVaultNotifications

        internal virtual SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<SetVaultNotificationsResponse>(request, options);
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
        public virtual Task<SetVaultNotificationsResponse> SetVaultNotificationsAsync(SetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<SetVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadArchive

        internal virtual UploadArchiveResponse UploadArchive(UploadArchiveRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return Invoke<UploadArchiveResponse>(request, options);
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
        public virtual Task<UploadArchiveResponse> UploadArchiveAsync(UploadArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return InvokeAsync<UploadArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadMultipartPart

        internal virtual UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadMultipartPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return Invoke<UploadMultipartPartResponse>(request, options);
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
        public virtual Task<UploadMultipartPartResponse> UploadMultipartPartAsync(UploadMultipartPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadMultipartPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadMultipartPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
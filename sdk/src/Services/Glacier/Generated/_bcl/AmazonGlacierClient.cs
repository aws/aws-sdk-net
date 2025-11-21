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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Glacier
{
    /// <summary>
    /// <para>Implementation for accessing Glacier</para>
    ///
    /// Amazon S3 Glacier (Glacier) is a storage solution for "cold data."
    /// 
    ///  
    /// <para>
    /// Glacier is an extremely low-cost storage service that provides secure, durable, and
    /// easy-to-use storage for data backup and archival. With Glacier, customers can store
    /// their data cost effectively for months, years, or decades. Glacier also enables customers
    /// to offload the administrative burdens of operating and scaling storage to AWS, so
    /// they don't have to worry about capacity planning, hardware provisioning, data replication,
    /// hardware failure and recovery, or time-consuming hardware migrations.
    /// </para>
    ///  
    /// <para>
    /// Glacier is a great storage choice when low storage cost is paramount and your data
    /// is rarely retrieved. If your application requires fast or frequent access to your
    /// data, consider using Amazon S3. For more information, see <a href="http://aws.amazon.com/s3/">Amazon
    /// Simple Storage Service (Amazon S3)</a>.
    /// </para>
    ///  
    /// <para>
    /// You can store any kind of data in any format. There is no maximum limit on the total
    /// amount of data you can store in Glacier.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Glacier, we recommend that you begin by reading the
    /// following sections in the <i>Amazon S3 Glacier Developer Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/introduction.html">What
    /// is Amazon S3 Glacier</a> - This section of the Developer Guide describes the underlying
    /// data model, the operations it supports, and the AWS SDKs that you can use to interact
    /// with the service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/amazon-glacier-getting-started.html">Getting
    /// Started with Amazon S3 Glacier</a> - The Getting Started section walks you through
    /// the process of creating a vault, uploading archives, creating jobs to download archives,
    /// retrieving the job output, and deleting archives.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonGlacierClient : AmazonServiceClient, IAmazonGlacier
    {
        private static IServiceMetadata serviceMetadata = new AmazonGlacierMetadata();
        private IGlacierPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGlacierPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GlacierPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

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
            : base(new AmazonGlacierConfig()) { }

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
            : base(new AmazonGlacierConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.Glacier.Internal.ProcessRequestHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGlacierEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGlacierAuthSchemeHandler());
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


        /// <summary>
        /// This operation aborts a multipart upload identified by the upload ID.
        /// 
        ///  
        /// <para>
        /// After the Abort Multipart Upload request succeeds, you cannot upload any more parts
        /// to the multipart upload or complete the multipart upload. Aborting a completed upload
        /// fails. However, aborting an already-aborted upload will succeed, for a short time.
        /// For more information about uploading a part and completing a multipart upload, see
        /// <a>UploadMultipartPart</a> and <a>CompleteMultipartUpload</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-abort-upload.html">Abort
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AbortMultipartUpload">REST API Reference for AbortMultipartUpload Operation</seealso>
        public virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// This operation aborts a multipart upload identified by the upload ID.
        /// 
        ///  
        /// <para>
        /// After the Abort Multipart Upload request succeeds, you cannot upload any more parts
        /// to the multipart upload or complete the multipart upload. Aborting a completed upload
        /// fails. However, aborting an already-aborted upload will succeed, for a short time.
        /// For more information about uploading a part and completing a multipart upload, see
        /// <a>UploadMultipartPart</a> and <a>CompleteMultipartUpload</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-abort-upload.html">Abort
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AbortMultipartUpload">REST API Reference for AbortMultipartUpload Operation</seealso>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<AbortMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AbortVaultLock


        /// <summary>
        /// This operation aborts the vault locking process if the vault lock is not in the <c>Locked</c>
        /// state. If the vault lock is in the <c>Locked</c> state when this operation is requested,
        /// the operation returns an <c>AccessDeniedException</c> error. Aborting the vault locking
        /// process removes the vault lock policy from the specified vault. 
        /// 
        ///  
        /// <para>
        /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
        /// You can get the state of a vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. For more information about vault lock policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. You can successfully invoke this operation multiple
        /// times, if the vault lock is in the <c>InProgress</c> state or if there is no policy
        /// associated with the vault.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock service method.</param>
        /// 
        /// <returns>The response from the AbortVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AbortVaultLock">REST API Reference for AbortVaultLock Operation</seealso>
        public virtual AbortVaultLockResponse AbortVaultLock(AbortVaultLockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortVaultLockResponseUnmarshaller.Instance;

            return Invoke<AbortVaultLockResponse>(request, options);
        }


        /// <summary>
        /// This operation aborts the vault locking process if the vault lock is not in the <c>Locked</c>
        /// state. If the vault lock is in the <c>Locked</c> state when this operation is requested,
        /// the operation returns an <c>AccessDeniedException</c> error. Aborting the vault locking
        /// process removes the vault lock policy from the specified vault. 
        /// 
        ///  
        /// <para>
        /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
        /// You can get the state of a vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. For more information about vault lock policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent. You can successfully invoke this operation multiple
        /// times, if the vault lock is in the <c>InProgress</c> state or if there is no policy
        /// associated with the vault.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AbortVaultLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AbortVaultLock">REST API Reference for AbortVaultLock Operation</seealso>
        public virtual Task<AbortVaultLockResponse> AbortVaultLockAsync(AbortVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AbortVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortVaultLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<AbortVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToVault


        /// <summary>
        /// This operation adds the specified tags to a vault. Each tag is composed of a key and
        /// a value. Each vault can have up to 10 tags. If your request would cause the tag limit
        /// for the vault to be exceeded, the operation throws the <c>LimitExceededException</c>
        /// error. If a tag already exists on the vault under a specified key, the existing key
        /// value will be overwritten. For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault service method.</param>
        /// 
        /// <returns>The response from the AddTagsToVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AddTagsToVault">REST API Reference for AddTagsToVault Operation</seealso>
        public virtual AddTagsToVaultResponse AddTagsToVault(AddTagsToVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;

            return Invoke<AddTagsToVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation adds the specified tags to a vault. Each tag is composed of a key and
        /// a value. Each vault can have up to 10 tags. If your request would cause the tag limit
        /// for the vault to be exceeded, the operation throws the <c>LimitExceededException</c>
        /// error. If a tag already exists on the vault under a specified key, the existing key
        /// value will be overwritten. For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/AddTagsToVault">REST API Reference for AddTagsToVault Operation</seealso>
        public virtual Task<AddTagsToVaultResponse> AddTagsToVaultAsync(AddTagsToVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload


        /// <summary>
        /// You call this operation to inform Amazon S3 Glacier (Glacier) that all the archive
        /// parts have been uploaded and that Glacier can now assemble the archive from the uploaded
        /// parts. After assembling and saving the archive to the vault, Glacier returns the URI
        /// path of the newly created archive resource. Using the URI path, you can then access
        /// the archive. After you upload an archive, you should save the archive ID returned
        /// to retrieve the archive at a later point. You can also get the vault inventory to
        /// obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you must include the computed SHA256 tree hash of the entire archive
        /// you have uploaded. For information about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. On the server side, Glacier also constructs the SHA256 tree hash of
        /// the assembled archive. If the values match, Glacier saves the archive to the vault;
        /// otherwise, it returns an error, and the operation fails. The <a>ListParts</a> operation
        /// returns a list of parts uploaded for a specific multipart upload. It includes checksum
        /// information for each uploaded part that can be used to debug a bad checksum issue.
        /// </para>
        ///  
        /// <para>
        /// Additionally, Glacier also checks for any missing content ranges when assembling the
        /// archive, if missing content ranges are found, Glacier returns an error and the operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// Complete Multipart Upload is an idempotent operation. After your first successful
        /// complete multipart upload, if you call the operation again within a short period,
        /// the operation will succeed and return the same archive ID. This is useful in the event
        /// you experience a network issue that causes an aborted connection or receive a 500
        /// server error, in which case you can repeat your Complete Multipart Upload request
        /// and get the same archive ID without creating duplicate archives. Note, however, that
        /// after the multipart upload completes, you cannot call the List Parts operation and
        /// the multipart upload will not appear in List Multipart Uploads response, even if idempotent
        /// complete is possible.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html">Complete
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CompleteMultipartUpload">REST API Reference for CompleteMultipartUpload Operation</seealso>
        public virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// You call this operation to inform Amazon S3 Glacier (Glacier) that all the archive
        /// parts have been uploaded and that Glacier can now assemble the archive from the uploaded
        /// parts. After assembling and saving the archive to the vault, Glacier returns the URI
        /// path of the newly created archive resource. Using the URI path, you can then access
        /// the archive. After you upload an archive, you should save the archive ID returned
        /// to retrieve the archive at a later point. You can also get the vault inventory to
        /// obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        ///  
        /// <para>
        /// In the request, you must include the computed SHA256 tree hash of the entire archive
        /// you have uploaded. For information about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. On the server side, Glacier also constructs the SHA256 tree hash of
        /// the assembled archive. If the values match, Glacier saves the archive to the vault;
        /// otherwise, it returns an error, and the operation fails. The <a>ListParts</a> operation
        /// returns a list of parts uploaded for a specific multipart upload. It includes checksum
        /// information for each uploaded part that can be used to debug a bad checksum issue.
        /// </para>
        ///  
        /// <para>
        /// Additionally, Glacier also checks for any missing content ranges when assembling the
        /// archive, if missing content ranges are found, Glacier returns an error and the operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// Complete Multipart Upload is an idempotent operation. After your first successful
        /// complete multipart upload, if you call the operation again within a short period,
        /// the operation will succeed and return the same archive ID. This is useful in the event
        /// you experience a network issue that causes an aborted connection or receive a 500
        /// server error, in which case you can repeat your Complete Multipart Upload request
        /// and get the same archive ID without creating duplicate archives. Note, however, that
        /// after the multipart upload completes, you cannot call the List Parts operation and
        /// the multipart upload will not appear in List Multipart Uploads response, even if idempotent
        /// complete is possible.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-complete-upload.html">Complete
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CompleteMultipartUpload">REST API Reference for CompleteMultipartUpload Operation</seealso>
        public virtual Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteVaultLock


        /// <summary>
        /// This operation completes the vault locking process by transitioning the vault lock
        /// from the <c>InProgress</c> state to the <c>Locked</c> state, which causes the vault
        /// lock policy to become unchangeable. A vault lock is put into the <c>InProgress</c>
        /// state by calling <a>InitiateVaultLock</a>. You can obtain the state of the vault lock
        /// by calling <a>GetVaultLock</a>. For more information about the vault locking process,
        /// <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. This request is always successful if the vault lock
        /// is in the <c>Locked</c> state and the provided lock ID matches the lock ID originally
        /// used to lock the vault.
        /// </para>
        ///  
        /// <para>
        /// If an invalid lock ID is passed in the request when the vault lock is in the <c>Locked</c>
        /// state, the operation returns an <c>AccessDeniedException</c> error. If an invalid
        /// lock ID is passed in the request when the vault lock is in the <c>InProgress</c> state,
        /// the operation throws an <c>InvalidParameter</c> error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock service method.</param>
        /// 
        /// <returns>The response from the CompleteVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CompleteVaultLock">REST API Reference for CompleteVaultLock Operation</seealso>
        public virtual CompleteVaultLockResponse CompleteVaultLock(CompleteVaultLockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;

            return Invoke<CompleteVaultLockResponse>(request, options);
        }


        /// <summary>
        /// This operation completes the vault locking process by transitioning the vault lock
        /// from the <c>InProgress</c> state to the <c>Locked</c> state, which causes the vault
        /// lock policy to become unchangeable. A vault lock is put into the <c>InProgress</c>
        /// state by calling <a>InitiateVaultLock</a>. You can obtain the state of the vault lock
        /// by calling <a>GetVaultLock</a>. For more information about the vault locking process,
        /// <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. This request is always successful if the vault lock
        /// is in the <c>Locked</c> state and the provided lock ID matches the lock ID originally
        /// used to lock the vault.
        /// </para>
        ///  
        /// <para>
        /// If an invalid lock ID is passed in the request when the vault lock is in the <c>Locked</c>
        /// state, the operation returns an <c>AccessDeniedException</c> error. If an invalid
        /// lock ID is passed in the request when the vault lock is in the <c>InProgress</c> state,
        /// the operation throws an <c>InvalidParameter</c> error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteVaultLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CompleteVaultLock">REST API Reference for CompleteVaultLock Operation</seealso>
        public virtual Task<CompleteVaultLockResponse> CompleteVaultLockAsync(CompleteVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteVaultLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVault


        /// <summary>
        /// This operation creates a new vault with the specified name. The name of the vault
        /// must be unique within a region for an AWS account. You can create up to 1,000 vaults
        /// per account. If you need to create more vaults, contact Amazon S3 Glacier.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a vault.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Names can be between 1 and 255 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/creating-vaults.html">Creating
        /// a Vault in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-put.html">Create
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault service method.</param>
        /// 
        /// <returns>The response from the CreateVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CreateVault">REST API Reference for CreateVault Operation</seealso>
        public virtual CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVaultResponseUnmarshaller.Instance;

            return Invoke<CreateVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation creates a new vault with the specified name. The name of the vault
        /// must be unique within a region for an AWS account. You can create up to 1,000 vaults
        /// per account. If you need to create more vaults, contact Amazon S3 Glacier.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a vault.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Names can be between 1 and 255 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Allowed characters are a-z, A-Z, 0-9, '_' (underscore), '-' (hyphen), and '.' (period).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/creating-vaults.html">Creating
        /// a Vault in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-put.html">Create
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVault service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/CreateVault">REST API Reference for CreateVault Operation</seealso>
        public virtual Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteArchive


        /// <summary>
        /// This operation deletes an archive from a vault. Subsequent requests to initiate a
        /// retrieval of this archive will fail. Archive retrievals that are in progress for this
        /// archive ID may or may not succeed according to the following scenarios:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the archive retrieval job is actively preparing the data for download when Amazon
        /// S3 Glacier receives the delete archive request, the archival retrieval operation might
        /// fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the archive retrieval job has successfully prepared the archive for download when
        /// Amazon S3 Glacier receives the delete archive request, you will be able to download
        /// the output.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. Attempting to delete an already-deleted archive does
        /// not result in an error.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-an-archive.html">Deleting
        /// an Archive in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes an archive from a vault. Subsequent requests to initiate a
        /// retrieval of this archive will fail. Archive retrievals that are in progress for this
        /// archive ID may or may not succeed according to the following scenarios:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If the archive retrieval job is actively preparing the data for download when Amazon
        /// S3 Glacier receives the delete archive request, the archival retrieval operation might
        /// fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the archive retrieval job has successfully prepared the archive for download when
        /// Amazon S3 Glacier receives the delete archive request, you will be able to download
        /// the output.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. Attempting to delete an already-deleted archive does
        /// not result in an error.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-an-archive.html">Deleting
        /// an Archive in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual Task<DeleteArchiveResponse> DeleteArchiveAsync(DeleteArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVault


        /// <summary>
        /// This operation deletes a vault. Amazon S3 Glacier will delete a vault only if there
        /// are no archives in the vault as of the last inventory and there have been no writes
        /// to the vault since the last inventory. If either of these conditions is not satisfied,
        /// the vault deletion fails (that is, the vault is not removed) and Amazon S3 Glacier
        /// returns an error. You can use <a>DescribeVault</a> to return the number of archives
        /// in a vault, and you can use <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job (POST jobs)</a> to initiate a new inventory retrieval for a vault. The inventory
        /// contains the archive IDs you use to delete archives using <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive (DELETE archive)</a>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-vaults.html">Deleting
        /// a Vault in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-delete.html">Delete
        /// Vault </a> in the <i>Amazon S3 Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault service method.</param>
        /// 
        /// <returns>The response from the DeleteVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVault">REST API Reference for DeleteVault Operation</seealso>
        public virtual DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes a vault. Amazon S3 Glacier will delete a vault only if there
        /// are no archives in the vault as of the last inventory and there have been no writes
        /// to the vault since the last inventory. If either of these conditions is not satisfied,
        /// the vault deletion fails (that is, the vault is not removed) and Amazon S3 Glacier
        /// returns an error. You can use <a>DescribeVault</a> to return the number of archives
        /// in a vault, and you can use <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job (POST jobs)</a> to initiate a new inventory retrieval for a vault. The inventory
        /// contains the archive IDs you use to delete archives using <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-delete.html">Delete
        /// Archive (DELETE archive)</a>.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/deleting-vaults.html">Deleting
        /// a Vault in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-delete.html">Delete
        /// Vault </a> in the <i>Amazon S3 Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVault">REST API Reference for DeleteVault Operation</seealso>
        public virtual Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultAccessPolicy


        /// <summary>
        /// This operation deletes the access policy associated with the specified vault. The
        /// operation is eventually consistent; that is, it might take some time for Amazon S3
        /// Glacier to completely remove the access policy, and you might still see the effect
        /// of the policy for a short time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. You can invoke delete multiple times, even if there
        /// is no policy associated with the vault. For more information about vault access policies,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVaultAccessPolicy">REST API Reference for DeleteVaultAccessPolicy Operation</seealso>
        public virtual DeleteVaultAccessPolicyResponse DeleteVaultAccessPolicy(DeleteVaultAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes the access policy associated with the specified vault. The
        /// operation is eventually consistent; that is, it might take some time for Amazon S3
        /// Glacier to completely remove the access policy, and you might still see the effect
        /// of the policy for a short time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. You can invoke delete multiple times, even if there
        /// is no policy associated with the vault. For more information about vault access policies,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVaultAccessPolicy">REST API Reference for DeleteVaultAccessPolicy Operation</seealso>
        public virtual Task<DeleteVaultAccessPolicyResponse> DeleteVaultAccessPolicyAsync(DeleteVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVaultNotifications


        /// <summary>
        /// This operation deletes the notification configuration set for a vault. The operation
        /// is eventually consistent; that is, it might take some time for Amazon S3 Glacier to
        /// completely disable the notifications and you might still receive some notifications
        /// for a short time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-delete.html">Delete
        /// Vault Notification Configuration </a> in the Amazon S3 Glacier Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVaultNotifications">REST API Reference for DeleteVaultNotifications Operation</seealso>
        public virtual DeleteVaultNotificationsResponse DeleteVaultNotifications(DeleteVaultNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// This operation deletes the notification configuration set for a vault. The operation
        /// is eventually consistent; that is, it might take some time for Amazon S3 Glacier to
        /// completely disable the notifications and you might still receive some notifications
        /// for a short time after you send the delete request.
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-delete.html">Delete
        /// Vault Notification Configuration </a> in the Amazon S3 Glacier Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DeleteVaultNotifications">REST API Reference for DeleteVaultNotifications Operation</seealso>
        public virtual Task<DeleteVaultNotificationsResponse> DeleteVaultNotificationsAsync(DeleteVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// This operation returns information about a job you previously initiated, including
        /// the job initiation date, the user who initiated the job, the job status code/message
        /// and the Amazon SNS topic to notify after Amazon S3 Glacier (Glacier) completes the
        /// job. For more information about initiating a job, see <a>InitiateJob</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation enables you to check the status of your job. However, it is strongly
        /// recommended that you set up an Amazon SNS topic and specify it in your initiate job
        /// request so that Glacier can notify the topic after it completes the job.
        /// </para>
        ///  </note> 
        /// <para>
        /// A job ID will not expire for at least 24 hours after Glacier completes the job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Describe
        /// Job</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about a job you previously initiated, including
        /// the job initiation date, the user who initiated the job, the job status code/message
        /// and the Amazon SNS topic to notify after Amazon S3 Glacier (Glacier) completes the
        /// job. For more information about initiating a job, see <a>InitiateJob</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// This operation enables you to check the status of your job. However, it is strongly
        /// recommended that you set up an Amazon SNS topic and specify it in your initiate job
        /// request so that Glacier can notify the topic after it completes the job.
        /// </para>
        ///  </note> 
        /// <para>
        /// A job ID will not expire for at least 24 hours after Glacier completes the job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-describe-job-get.html">Describe
        /// Job</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVault


        /// <summary>
        /// This operation returns information about a vault, including the vault's Amazon Resource
        /// Name (ARN), the date the vault was created, the number of archives it contains, and
        /// the total size of all the archives in the vault. The number of archives and their
        /// total size are as of the last inventory generation. This means that if you add or
        /// remove an archive from a vault, and then immediately use Describe Vault, the change
        /// in contents will not be immediately reflected. If you want to retrieve the latest
        /// inventory of the vault, use <a>InitiateJob</a>. Amazon S3 Glacier generates vault
        /// inventories approximately daily. For more information, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory in Amazon S3 Glacier</a>. 
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-get.html">Describe
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault service method.</param>
        /// 
        /// <returns>The response from the DescribeVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DescribeVault">REST API Reference for DescribeVault Operation</seealso>
        public virtual DescribeVaultResponse DescribeVault(DescribeVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation returns information about a vault, including the vault's Amazon Resource
        /// Name (ARN), the date the vault was created, the number of archives it contains, and
        /// the total size of all the archives in the vault. The number of archives and their
        /// total size are as of the last inventory generation. This means that if you add or
        /// remove an archive from a vault, and then immediately use Describe Vault, the change
        /// in contents will not be immediately reflected. If you want to retrieve the latest
        /// inventory of the vault, use <a>InitiateJob</a>. Amazon S3 Glacier generates vault
        /// inventories approximately daily. For more information, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory in Amazon S3 Glacier</a>. 
        /// 
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-get.html">Describe
        /// Vault </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/DescribeVault">REST API Reference for DescribeVault Operation</seealso>
        public virtual Task<DescribeVaultResponse> DescribeVaultAsync(DescribeVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataRetrievalPolicy


        /// <summary>
        /// This operation returns the current data retrieval policy for the account and region
        /// specified in the GET request. For more information about data retrieval policies,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetDataRetrievalPolicy">REST API Reference for GetDataRetrievalPolicy Operation</seealso>
        public virtual GetDataRetrievalPolicyResponse GetDataRetrievalPolicy(GetDataRetrievalPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDataRetrievalPolicyResponse>(request, options);
        }


        /// <summary>
        /// This operation returns the current data retrieval policy for the account and region
        /// specified in the GET request. For more information about data retrieval policies,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetrievalPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetDataRetrievalPolicy">REST API Reference for GetDataRetrievalPolicy Operation</seealso>
        public virtual Task<GetDataRetrievalPolicyResponse> GetDataRetrievalPolicyAsync(GetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataRetrievalPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataRetrievalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobOutput


        /// <summary>
        /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
        /// Depending on the job type you specified when you initiated the job, the output will
        /// be either the content of an archive or a vault inventory.
        /// 
        ///  
        /// <para>
        /// You can download all the job output or download a portion of the output by specifying
        /// a byte range. In the case of an archive retrieval job, depending on the byte range
        /// you specify, Amazon S3 Glacier (Glacier) returns the checksum for the portion of the
        /// data. You can compute the checksum on the client and verify that the values match
        /// to ensure the portion you downloaded is the correct data.
        /// </para>
        ///  
        /// <para>
        /// A job ID will not expire for at least 24 hours after Glacier completes the job. That
        /// a byte range. For both archive and inventory retrieval jobs, you should verify the
        /// downloaded size against the size returned in the headers from the <b>Get Job Output</b>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// For archive retrieval jobs, you should also verify that the size is what you expected.
        /// If you download a portion of the output, the expected size is based on the range of
        /// bytes you specified. For example, if you specify a range of <c>bytes=0-1048575</c>,
        /// you should verify your download size is 1,048,576 bytes. If you download an entire
        /// archive, the expected size is the size of the archive when you uploaded it to Amazon
        /// S3 Glacier The expected size is also returned in the headers from the <b>Get Job Output</b>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// In the case of an archive retrieval job, depending on the byte range you specify,
        /// Glacier returns the checksum for the portion of the data. To ensure the portion you
        /// downloaded is the correct data, compute the checksum on the client, verify that the
        /// values match, and verify that the size is what you expected.
        /// </para>
        ///  
        /// <para>
        /// A job ID does not expire for at least 24 hours after Glacier completes the job. That
        /// is, you can download the job output within the 24 hours period after Amazon Glacier
        /// completes the job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a>, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/downloading-an-archive.html">Downloading
        /// an Archive</a>, and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-job-output-get.html">Get
        /// Job Output </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput service method.</param>
        /// 
        /// <returns>The response from the GetJobOutput service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetJobOutput">REST API Reference for GetJobOutput Operation</seealso>
        public virtual GetJobOutputResponse GetJobOutput(GetJobOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobOutputResponseUnmarshaller.Instance;

            return Invoke<GetJobOutputResponse>(request, options);
        }


        /// <summary>
        /// This operation downloads the output of the job you initiated using <a>InitiateJob</a>.
        /// Depending on the job type you specified when you initiated the job, the output will
        /// be either the content of an archive or a vault inventory.
        /// 
        ///  
        /// <para>
        /// You can download all the job output or download a portion of the output by specifying
        /// a byte range. In the case of an archive retrieval job, depending on the byte range
        /// you specify, Amazon S3 Glacier (Glacier) returns the checksum for the portion of the
        /// data. You can compute the checksum on the client and verify that the values match
        /// to ensure the portion you downloaded is the correct data.
        /// </para>
        ///  
        /// <para>
        /// A job ID will not expire for at least 24 hours after Glacier completes the job. That
        /// a byte range. For both archive and inventory retrieval jobs, you should verify the
        /// downloaded size against the size returned in the headers from the <b>Get Job Output</b>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// For archive retrieval jobs, you should also verify that the size is what you expected.
        /// If you download a portion of the output, the expected size is based on the range of
        /// bytes you specified. For example, if you specify a range of <c>bytes=0-1048575</c>,
        /// you should verify your download size is 1,048,576 bytes. If you download an entire
        /// archive, the expected size is the size of the archive when you uploaded it to Amazon
        /// S3 Glacier The expected size is also returned in the headers from the <b>Get Job Output</b>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// In the case of an archive retrieval job, depending on the byte range you specify,
        /// Glacier returns the checksum for the portion of the data. To ensure the portion you
        /// downloaded is the correct data, compute the checksum on the client, verify that the
        /// values match, and verify that the size is what you expected.
        /// </para>
        ///  
        /// <para>
        /// A job ID does not expire for at least 24 hours after Glacier completes the job. That
        /// is, you can download the job output within the 24 hours period after Amazon Glacier
        /// completes the job.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-inventory.html">Downloading
        /// a Vault Inventory</a>, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/downloading-an-archive.html">Downloading
        /// an Archive</a>, and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-job-output-get.html">Get
        /// Job Output </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobOutput service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetJobOutput">REST API Reference for GetJobOutput Operation</seealso>
        public virtual Task<GetJobOutputResponse> GetJobOutputAsync(GetJobOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobOutputResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultAccessPolicy


        /// <summary>
        /// This operation retrieves the <c>access-policy</c> subresource set on the vault; for
        /// more information on setting this subresource, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-SetVaultAccessPolicy.html">Set
        /// Vault Access Policy (PUT access-policy)</a>. If there is no access policy set on the
        /// vault, the operation returns a <c>404 Not found</c> error. For more information about
        /// vault access policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the GetVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultAccessPolicy">REST API Reference for GetVaultAccessPolicy Operation</seealso>
        public virtual GetVaultAccessPolicyResponse GetVaultAccessPolicy(GetVaultAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves the <c>access-policy</c> subresource set on the vault; for
        /// more information on setting this subresource, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-SetVaultAccessPolicy.html">Set
        /// Vault Access Policy (PUT access-policy)</a>. If there is no access policy set on the
        /// vault, the operation returns a <c>404 Not found</c> error. For more information about
        /// vault access policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultAccessPolicy">REST API Reference for GetVaultAccessPolicy Operation</seealso>
        public virtual Task<GetVaultAccessPolicyResponse> GetVaultAccessPolicyAsync(GetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultLock


        /// <summary>
        /// This operation retrieves the following attributes from the <c>lock-policy</c> subresource
        /// set on the specified vault: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The vault lock policy set on the vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The state of the vault lock, which is either <c>InProgess</c> or <c>Locked</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the lock ID expires. The lock ID is used to complete the vault locking process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the vault lock was initiated and put into the <c>InProgress</c> state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. For more
        /// information about the vault locking process, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// </para>
        ///  
        /// <para>
        /// If there is no vault lock policy set on the vault, the operation returns a <c>404
        /// Not found</c> error. For more information about vault lock policies, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock service method.</param>
        /// 
        /// <returns>The response from the GetVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultLock">REST API Reference for GetVaultLock Operation</seealso>
        public virtual GetVaultLockResponse GetVaultLock(GetVaultLockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultLockResponseUnmarshaller.Instance;

            return Invoke<GetVaultLockResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves the following attributes from the <c>lock-policy</c> subresource
        /// set on the specified vault: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The vault lock policy set on the vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The state of the vault lock, which is either <c>InProgess</c> or <c>Locked</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the lock ID expires. The lock ID is used to complete the vault locking process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When the vault lock was initiated and put into the <c>InProgress</c> state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A vault lock is put into the <c>InProgress</c> state by calling <a>InitiateVaultLock</a>.
        /// A vault lock is put into the <c>Locked</c> state by calling <a>CompleteVaultLock</a>.
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. For more
        /// information about the vault locking process, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>. 
        /// </para>
        ///  
        /// <para>
        /// If there is no vault lock policy set on the vault, the operation returns a <c>404
        /// Not found</c> error. For more information about vault lock policies, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultLock">REST API Reference for GetVaultLock Operation</seealso>
        public virtual Task<GetVaultLockResponse> GetVaultLockAsync(GetVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVaultNotifications


        /// <summary>
        /// This operation retrieves the <c>notification-configuration</c> subresource of the
        /// specified vault.
        /// 
        ///  
        /// <para>
        /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
        /// If a notification configuration for a vault is not set, the operation returns a <c>404
        /// Not Found</c> error. For more information about vault notifications, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a>. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html">Get
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the GetVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultNotifications">REST API Reference for GetVaultNotifications Operation</seealso>
        public virtual GetVaultNotificationsResponse GetVaultNotifications(GetVaultNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// This operation retrieves the <c>notification-configuration</c> subresource of the
        /// specified vault.
        /// 
        ///  
        /// <para>
        /// For information about setting a notification configuration on a vault, see <a>SetVaultNotifications</a>.
        /// If a notification configuration for a vault is not set, the operation returns a <c>404
        /// Not Found</c> error. For more information about vault notifications, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a>. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-get.html">Get
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/GetVaultNotifications">REST API Reference for GetVaultNotifications Operation</seealso>
        public virtual Task<GetVaultNotificationsResponse> GetVaultNotificationsAsync(GetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateJob


        /// <summary>
        /// This operation initiates a job of the specified type, which can be a select, an archival
        /// retrieval, or a vault retrieval. For more information about using this operation,
        /// see the documentation for the underlying REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob service method.</param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InsufficientCapacityException">
        /// Returned if there is insufficient capacity to process this expedited request. This
        /// error only applies to expedited retrievals and not to standard or bulk retrievals.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.PolicyEnforcedException">
        /// Returned if a retrieval job would exceed the current data policy's retrieval rate
        /// limit. For more information about data retrieval policies,
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateJob">REST API Reference for InitiateJob Operation</seealso>
        public virtual InitiateJobResponse InitiateJob(InitiateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateJobResponseUnmarshaller.Instance;

            return Invoke<InitiateJobResponse>(request, options);
        }


        /// <summary>
        /// This operation initiates a job of the specified type, which can be a select, an archival
        /// retrieval, or a vault retrieval. For more information about using this operation,
        /// see the documentation for the underlying REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html">Initiate
        /// a Job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateJob service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InsufficientCapacityException">
        /// Returned if there is insufficient capacity to process this expedited request. This
        /// error only applies to expedited retrievals and not to standard or bulk retrievals.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.PolicyEnforcedException">
        /// Returned if a retrieval job would exceed the current data policy's retrieval rate
        /// limit. For more information about data retrieval policies,
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateJob">REST API Reference for InitiateJob Operation</seealso>
        public virtual Task<InitiateJobResponse> InitiateJobAsync(InitiateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<InitiateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload


        /// <summary>
        /// This operation initiates a multipart upload. Amazon S3 Glacier creates a multipart
        /// upload resource and returns its ID in the response. The multipart upload ID is used
        /// in subsequent requests to upload parts of an archive (see <a>UploadMultipartPart</a>).
        /// 
        ///  
        /// <para>
        /// When you initiate a multipart upload, you specify the part size in number of bytes.
        /// The part size must be a megabyte (1024 KB) multiplied by a power of 2-for example,
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
        /// allowable part size is 1 MB, and the maximum is 4 GB.
        /// </para>
        ///  
        /// <para>
        /// Every part you upload to this resource (see <a>UploadMultipartPart</a>), except the
        /// last one, must have the same size. The last one can be the same size or smaller. For
        /// example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
        /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part
        /// of 0.2 MB. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to know the size of the archive when you start a multipart upload because
        /// Amazon S3 Glacier does not require you to specify the overall archive size.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you complete the multipart upload, Amazon S3 Glacier (Glacier) removes the multipart
        /// upload resource referenced by the ID. Glacier also removes the multipart upload resource
        /// if you cancel the multipart upload or it may be removed if there is no activity for
        /// a period of 24 hours.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-initiate-upload.html">Initiate
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateMultipartUpload">REST API Reference for InitiateMultipartUpload Operation</seealso>
        public virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// This operation initiates a multipart upload. Amazon S3 Glacier creates a multipart
        /// upload resource and returns its ID in the response. The multipart upload ID is used
        /// in subsequent requests to upload parts of an archive (see <a>UploadMultipartPart</a>).
        /// 
        ///  
        /// <para>
        /// When you initiate a multipart upload, you specify the part size in number of bytes.
        /// The part size must be a megabyte (1024 KB) multiplied by a power of 2-for example,
        /// 1048576 (1 MB), 2097152 (2 MB), 4194304 (4 MB), 8388608 (8 MB), and so on. The minimum
        /// allowable part size is 1 MB, and the maximum is 4 GB.
        /// </para>
        ///  
        /// <para>
        /// Every part you upload to this resource (see <a>UploadMultipartPart</a>), except the
        /// last one, must have the same size. The last one can be the same size or smaller. For
        /// example, suppose you want to upload a 16.2 MB file. If you initiate the multipart
        /// upload with a part size of 4 MB, you will upload four parts of 4 MB each and one part
        /// of 0.2 MB. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to know the size of the archive when you start a multipart upload because
        /// Amazon S3 Glacier does not require you to specify the overall archive size.
        /// </para>
        ///  </note> 
        /// <para>
        /// After you complete the multipart upload, Amazon S3 Glacier (Glacier) removes the multipart
        /// upload resource referenced by the ID. Glacier also removes the multipart upload resource
        /// if you cancel the multipart upload or it may be removed if there is no activity for
        /// a period of 24 hours.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-initiate-upload.html">Initiate
        /// Multipart Upload</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateMultipartUpload">REST API Reference for InitiateMultipartUpload Operation</seealso>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;
            
            return InvokeAsync<InitiateMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateVaultLock


        /// <summary>
        /// This operation initiates the vault locking process by doing the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Installing a vault lock policy on the specified vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Setting the lock state of vault lock to <c>InProgress</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returning a lock ID, which is used to complete the vault locking process.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can set one vault lock policy for each vault and this policy can be up to 20 KB
        /// in size. For more information about vault lock policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must complete the vault locking process within 24 hours after the vault lock enters
        /// the <c>InProgress</c> state. After the 24 hour window ends, the lock ID expires, the
        /// vault automatically exits the <c>InProgress</c> state, and the vault lock policy is
        /// removed from the vault. You call <a>CompleteVaultLock</a> to complete the vault locking
        /// process by setting the state of the vault lock to <c>Locked</c>. 
        /// </para>
        ///  
        /// <para>
        /// After a vault lock is in the <c>Locked</c> state, you cannot initiate a new vault
        /// lock for the vault.
        /// </para>
        ///  
        /// <para>
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. You can
        /// get the state of the vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>.
        /// </para>
        ///  
        /// <para>
        /// If this operation is called when the vault lock is in the <c>InProgress</c> state,
        /// the operation returns an <c>AccessDeniedException</c> error. When the vault lock is
        /// in the <c>InProgress</c> state you must call <a>AbortVaultLock</a> before you can
        /// initiate a new vault lock policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock service method.</param>
        /// 
        /// <returns>The response from the InitiateVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateVaultLock">REST API Reference for InitiateVaultLock Operation</seealso>
        public virtual InitiateVaultLockResponse InitiateVaultLock(InitiateVaultLockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;

            return Invoke<InitiateVaultLockResponse>(request, options);
        }


        /// <summary>
        /// This operation initiates the vault locking process by doing the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Installing a vault lock policy on the specified vault.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Setting the lock state of vault lock to <c>InProgress</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returning a lock ID, which is used to complete the vault locking process.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can set one vault lock policy for each vault and this policy can be up to 20 KB
        /// in size. For more information about vault lock policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock-policy.html">Amazon
        /// Glacier Access Control with Vault Lock Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must complete the vault locking process within 24 hours after the vault lock enters
        /// the <c>InProgress</c> state. After the 24 hour window ends, the lock ID expires, the
        /// vault automatically exits the <c>InProgress</c> state, and the vault lock policy is
        /// removed from the vault. You call <a>CompleteVaultLock</a> to complete the vault locking
        /// process by setting the state of the vault lock to <c>Locked</c>. 
        /// </para>
        ///  
        /// <para>
        /// After a vault lock is in the <c>Locked</c> state, you cannot initiate a new vault
        /// lock for the vault.
        /// </para>
        ///  
        /// <para>
        /// You can abort the vault locking process by calling <a>AbortVaultLock</a>. You can
        /// get the state of the vault lock by calling <a>GetVaultLock</a>. For more information
        /// about the vault locking process, <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-lock.html">Amazon
        /// Glacier Vault Lock</a>.
        /// </para>
        ///  
        /// <para>
        /// If this operation is called when the vault lock is in the <c>InProgress</c> state,
        /// the operation returns an <c>AccessDeniedException</c> error. When the vault lock is
        /// in the <c>InProgress</c> state you must call <a>AbortVaultLock</a> before you can
        /// initiate a new vault lock policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateVaultLock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateVaultLock service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/InitiateVaultLock">REST API Reference for InitiateVaultLock Operation</seealso>
        public virtual Task<InitiateVaultLockResponse> InitiateVaultLockAsync(InitiateVaultLockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateVaultLockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateVaultLockResponseUnmarshaller.Instance;
            
            return InvokeAsync<InitiateVaultLockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
        /// that have recently finished. The List Job operation returns a list of these jobs sorted
        /// by job initiation time.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Glacier retains recently completed jobs for a period before deleting them;
        /// however, it eventually removes completed jobs. The output of completed jobs can be
        /// retrieved. Retaining completed jobs for a period of time after they have completed
        /// enables you to get a job output in the event you miss the job completion notification
        /// or your first attempt to download it fails. For example, suppose you start an archive
        /// retrieval job to download an archive. After the job completes, you start to download
        /// the archive but encounter a network error. In this scenario, you can retry and download
        /// the archive while the job exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// The List Jobs operation supports pagination. You should always check the response
        /// <c>Marker</c> field. If there are no more jobs to list, the <c>Marker</c> field is
        /// set to <c>null</c>. If there are more jobs to list, the <c>Marker</c> field is set
        /// to a non-null value, which you can use to continue the pagination of the list. To
        /// return a list of jobs that begins at a specific job, set the marker request parameter
        /// to the <c>Marker</c> value for that job that you obtained from a previous List Jobs
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You can set a maximum limit for the number of jobs returned in the response by specifying
        /// the <c>limit</c> parameter in the request. The default limit is 50. The number of
        /// jobs returned might be fewer than the limit, but the number of returned jobs never
        /// exceeds the limit.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can filter the jobs list returned by specifying the optional <c>statuscode</c>
        /// parameter or <c>completed</c> parameter, or both. Using the <c>statuscode</c> parameter,
        /// you can specify to return only jobs that match either the <c>InProgress</c>, <c>Succeeded</c>,
        /// or <c>Failed</c> status. Using the <c>completed</c> parameter, you can specify to
        /// return only jobs that were completed (<c>true</c>) or jobs that were not completed
        /// (<c>false</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
        /// Jobs</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists jobs for a vault, including jobs that are in-progress and jobs
        /// that have recently finished. The List Job operation returns a list of these jobs sorted
        /// by job initiation time.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Glacier retains recently completed jobs for a period before deleting them;
        /// however, it eventually removes completed jobs. The output of completed jobs can be
        /// retrieved. Retaining completed jobs for a period of time after they have completed
        /// enables you to get a job output in the event you miss the job completion notification
        /// or your first attempt to download it fails. For example, suppose you start an archive
        /// retrieval job to download an archive. After the job completes, you start to download
        /// the archive but encounter a network error. In this scenario, you can retry and download
        /// the archive while the job exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// The List Jobs operation supports pagination. You should always check the response
        /// <c>Marker</c> field. If there are no more jobs to list, the <c>Marker</c> field is
        /// set to <c>null</c>. If there are more jobs to list, the <c>Marker</c> field is set
        /// to a non-null value, which you can use to continue the pagination of the list. To
        /// return a list of jobs that begins at a specific job, set the marker request parameter
        /// to the <c>Marker</c> value for that job that you obtained from a previous List Jobs
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You can set a maximum limit for the number of jobs returned in the response by specifying
        /// the <c>limit</c> parameter in the request. The default limit is 50. The number of
        /// jobs returned might be fewer than the limit, but the number of returned jobs never
        /// exceeds the limit.
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can filter the jobs list returned by specifying the optional <c>statuscode</c>
        /// parameter or <c>completed</c> parameter, or both. Using the <c>statuscode</c> parameter,
        /// you can specify to return only jobs that match either the <c>InProgress</c>, <c>Succeeded</c>,
        /// or <c>Failed</c> status. Using the <c>completed</c> parameter, you can specify to
        /// return only jobs that were completed (<c>true</c>) or jobs that were not completed
        /// (<c>false</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information about using this operation, see the documentation for the underlying
        /// REST API <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-jobs-get.html">List
        /// Jobs</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads


        /// <summary>
        /// This operation lists in-progress multipart uploads for the specified vault. An in-progress
        /// multipart upload is a multipart upload that has been initiated by an <a>InitiateMultipartUpload</a>
        /// request, but has not yet been completed or aborted. The list returned in the List
        /// Multipart Upload response has no guaranteed order. 
        /// 
        ///  
        /// <para>
        /// The List Multipart Uploads operation supports pagination. By default, this operation
        /// returns up to 50 multipart uploads in the response. You should always check the response
        /// for a <c>marker</c> at which to continue the list; if there are no more items the
        /// <c>marker</c> is <c>null</c>. To return a list of multipart uploads that begins at
        /// a specific upload, set the <c>marker</c> request parameter to the value you obtained
        /// from a previous List Multipart Upload request. You can also limit the number of uploads
        /// returned in the response by specifying the <c>limit</c> parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Note the difference between this operation and listing parts (<a>ListParts</a>). The
        /// List Multipart Uploads operation lists all multipart uploads for a vault and does
        /// not require a multipart upload ID. The List Parts operation requires a multipart upload
        /// ID since parts are associated with a single upload.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-uploads.html">List
        /// Multipart Uploads </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListMultipartUploads">REST API Reference for ListMultipartUploads Operation</seealso>
        public virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads for the specified vault. An in-progress
        /// multipart upload is a multipart upload that has been initiated by an <a>InitiateMultipartUpload</a>
        /// request, but has not yet been completed or aborted. The list returned in the List
        /// Multipart Upload response has no guaranteed order. 
        /// 
        ///  
        /// <para>
        /// The List Multipart Uploads operation supports pagination. By default, this operation
        /// returns up to 50 multipart uploads in the response. You should always check the response
        /// for a <c>marker</c> at which to continue the list; if there are no more items the
        /// <c>marker</c> is <c>null</c>. To return a list of multipart uploads that begins at
        /// a specific upload, set the <c>marker</c> request parameter to the value you obtained
        /// from a previous List Multipart Upload request. You can also limit the number of uploads
        /// returned in the response by specifying the <c>limit</c> parameter in the request.
        /// </para>
        ///  
        /// <para>
        /// Note the difference between this operation and listing parts (<a>ListParts</a>). The
        /// List Multipart Uploads operation lists all multipart uploads for a vault and does
        /// not require a multipart upload ID. The List Parts operation requires a multipart upload
        /// ID since parts are associated with a single upload.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-uploads.html">List
        /// Multipart Uploads </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListMultipartUploads">REST API Reference for ListMultipartUploads Operation</seealso>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMultipartUploadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParts


        /// <summary>
        /// This operation lists the parts of an archive that have been uploaded in a specific
        /// multipart upload. You can make this request at any time during an in-progress multipart
        /// upload before you complete the upload (see <a>CompleteMultipartUpload</a>. List Parts
        /// returns an error for completed uploads. The list returned in the List Parts response
        /// is sorted by part range. 
        /// 
        ///  
        /// <para>
        /// The List Parts operation supports pagination. By default, this operation returns up
        /// to 50 uploaded parts in the response. You should always check the response for a <c>marker</c>
        /// at which to continue the list; if there are no more items the <c>marker</c> is <c>null</c>.
        /// To return a list of parts that begins at a specific part, set the <c>marker</c> request
        /// parameter to the value you obtained from a previous List Parts request. You can also
        /// limit the number of parts returned in the response by specifying the <c>limit</c>
        /// parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-parts.html">List
        /// Parts</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListParts">REST API Reference for ListParts Operation</seealso>
        public virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists the parts of an archive that have been uploaded in a specific
        /// multipart upload. You can make this request at any time during an in-progress multipart
        /// upload before you complete the upload (see <a>CompleteMultipartUpload</a>. List Parts
        /// returns an error for completed uploads. The list returned in the List Parts response
        /// is sorted by part range. 
        /// 
        ///  
        /// <para>
        /// The List Parts operation supports pagination. By default, this operation returns up
        /// to 50 uploaded parts in the response. You should always check the response for a <c>marker</c>
        /// at which to continue the list; if there are no more items the <c>marker</c> is <c>null</c>.
        /// To return a list of parts that begins at a specific part, set the <c>marker</c> request
        /// parameter to the value you obtained from a previous List Parts request. You can also
        /// limit the number of parts returned in the response by specifying the <c>limit</c>
        /// parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and the underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/working-with-archives.html">Working
        /// with Archives in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-multipart-list-parts.html">List
        /// Parts</a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListParts">REST API Reference for ListParts Operation</seealso>
        public virtual Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPartsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProvisionedCapacity


        /// <summary>
        /// This operation lists the provisioned capacity units for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedCapacity service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListProvisionedCapacity">REST API Reference for ListProvisionedCapacity Operation</seealso>
        public virtual ListProvisionedCapacityResponse ListProvisionedCapacity(ListProvisionedCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedCapacityResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedCapacityResponse>(request, options);
        }


        /// <summary>
        /// This operation lists the provisioned capacity units for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListProvisionedCapacity">REST API Reference for ListProvisionedCapacity Operation</seealso>
        public virtual Task<ListProvisionedCapacityResponse> ListProvisionedCapacityAsync(ListProvisionedCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedCapacityResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProvisionedCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForVault


        /// <summary>
        /// This operation lists all the tags attached to a vault. The operation returns an empty
        /// map if there are no tags. For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault service method.</param>
        /// 
        /// <returns>The response from the ListTagsForVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListTagsForVault">REST API Reference for ListTagsForVault Operation</seealso>
        public virtual ListTagsForVaultResponse ListTagsForVault(ListTagsForVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;

            return Invoke<ListTagsForVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation lists all the tags attached to a vault. The operation returns an empty
        /// map if there are no tags. For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListTagsForVault">REST API Reference for ListTagsForVault Operation</seealso>
        public virtual Task<ListTagsForVaultResponse> ListTagsForVaultAsync(ListTagsForVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVaults


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 10 items. If there are more vaults to list,
        /// the response <c>marker</c> field contains the vault Amazon Resource Name (ARN) at
        /// which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c>. To return a list of vaults that begins at a specific vault,
        /// set the <c>marker</c> request parameter to the vault ARN you obtained from a previous
        /// List Vaults request. You can also limit the number of vaults returned in the response
        /// by specifying the <c>limit</c> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListVaults">REST API Reference for ListVaults Operation</seealso>
        public virtual ListVaultsResponse ListVaults()
        {
            return ListVaults(new ListVaultsRequest());
        }


        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 10 items. If there are more vaults to list,
        /// the response <c>marker</c> field contains the vault Amazon Resource Name (ARN) at
        /// which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c>. To return a list of vaults that begins at a specific vault,
        /// set the <c>marker</c> request parameter to the vault ARN you obtained from a previous
        /// List Vaults request. You can also limit the number of vaults returned in the response
        /// by specifying the <c>limit</c> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListVaults">REST API Reference for ListVaults Operation</seealso>
        public virtual ListVaultsResponse ListVaults(ListVaultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// the response <c>marker</c> field contains the vault Amazon Resource Name (ARN) at
        /// which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c>. To return a list of vaults that begins at a specific vault,
        /// set the <c>marker</c> request parameter to the vault ARN you obtained from a previous
        /// List Vaults request. You can also limit the number of vaults returned in the response
        /// by specifying the <c>limit</c> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListVaults">REST API Reference for ListVaults Operation</seealso>
        public virtual Task<ListVaultsResponse> ListVaultsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListVaultsAsync(new ListVaultsRequest(), cancellationToken);
        }

        /// <summary>
        /// This operation lists all vaults owned by the calling user's account. The list returned
        /// in the response is ASCII-sorted by vault name.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns up to 10 items. If there are more vaults to list,
        /// the response <c>marker</c> field contains the vault Amazon Resource Name (ARN) at
        /// which to continue the list with a new List Vaults request; otherwise, the <c>marker</c>
        /// field is <c>null</c>. To return a list of vaults that begins at a specific vault,
        /// set the <c>marker</c> request parameter to the vault ARN you obtained from a previous
        /// List Vaults request. You can also limit the number of vaults returned in the response
        /// by specifying the <c>limit</c> parameter in the request. 
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/retrieving-vault-info.html">Retrieving
        /// Vault Metadata in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vaults-get.html">List
        /// Vaults </a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaults service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/ListVaults">REST API Reference for ListVaults Operation</seealso>
        public virtual Task<ListVaultsResponse> ListVaultsAsync(ListVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVaultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVaultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseProvisionedCapacity


        /// <summary>
        /// This operation purchases a provisioned capacity unit for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseProvisionedCapacity service method.</param>
        /// 
        /// <returns>The response from the PurchaseProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/PurchaseProvisionedCapacity">REST API Reference for PurchaseProvisionedCapacity Operation</seealso>
        public virtual PurchaseProvisionedCapacityResponse PurchaseProvisionedCapacity(PurchaseProvisionedCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseProvisionedCapacityResponseUnmarshaller.Instance;

            return Invoke<PurchaseProvisionedCapacityResponse>(request, options);
        }


        /// <summary>
        /// This operation purchases a provisioned capacity unit for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseProvisionedCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseProvisionedCapacity service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.LimitExceededException">
        /// Returned if the request results in a vault or account limit being exceeded.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/PurchaseProvisionedCapacity">REST API Reference for PurchaseProvisionedCapacity Operation</seealso>
        public virtual Task<PurchaseProvisionedCapacityResponse> PurchaseProvisionedCapacityAsync(PurchaseProvisionedCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseProvisionedCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseProvisionedCapacityResponseUnmarshaller.Instance;
            
            return InvokeAsync<PurchaseProvisionedCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromVault


        /// <summary>
        /// This operation removes one or more tags from the set of tags attached to a vault.
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>. This operation is idempotent. The operation will
        /// be successful, even if there are no tags attached to the vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/RemoveTagsFromVault">REST API Reference for RemoveTagsFromVault Operation</seealso>
        public virtual RemoveTagsFromVaultResponse RemoveTagsFromVault(RemoveTagsFromVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromVaultResponse>(request, options);
        }


        /// <summary>
        /// This operation removes one or more tags from the set of tags attached to a vault.
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/tagging.html">Tagging
        /// Amazon S3 Glacier Resources</a>. This operation is idempotent. The operation will
        /// be successful, even if there are no tags attached to the vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromVault service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/RemoveTagsFromVault">REST API Reference for RemoveTagsFromVault Operation</seealso>
        public virtual Task<RemoveTagsFromVaultResponse> RemoveTagsFromVaultAsync(RemoveTagsFromVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDataRetrievalPolicy


        /// <summary>
        /// This operation sets and then enacts a data retrieval policy in the region specified
        /// in the PUT request. You can set one policy per region for an AWS account. The policy
        /// is enacted within a few minutes of a successful PUT operation.
        /// 
        ///  
        /// <para>
        /// The set policy operation does not affect retrieval jobs that were in progress before
        /// the policy was enacted. For more information about data retrieval policies, see <a
        /// href="https://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy service method.</param>
        /// 
        /// <returns>The response from the SetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetDataRetrievalPolicy">REST API Reference for SetDataRetrievalPolicy Operation</seealso>
        public virtual SetDataRetrievalPolicyResponse SetDataRetrievalPolicy(SetDataRetrievalPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;

            return Invoke<SetDataRetrievalPolicyResponse>(request, options);
        }


        /// <summary>
        /// This operation sets and then enacts a data retrieval policy in the region specified
        /// in the PUT request. You can set one policy per region for an AWS account. The policy
        /// is enacted within a few minutes of a successful PUT operation.
        /// 
        ///  
        /// <para>
        /// The set policy operation does not affect retrieval jobs that were in progress before
        /// the policy was enacted. For more information about data retrieval policies, see <a
        /// href="https://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
        /// Glacier Data Retrieval Policies</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDataRetrievalPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDataRetrievalPolicy service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetDataRetrievalPolicy">REST API Reference for SetDataRetrievalPolicy Operation</seealso>
        public virtual Task<SetDataRetrievalPolicyResponse> SetDataRetrievalPolicyAsync(SetDataRetrievalPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDataRetrievalPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDataRetrievalPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetDataRetrievalPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetVaultAccessPolicy


        /// <summary>
        /// This operation configures an access policy for a vault and will overwrite an existing
        /// policy. To configure a vault access policy, send a PUT request to the <c>access-policy</c>
        /// subresource of the vault. An access policy is specific to a vault and is also called
        /// a vault subresource. You can set one access policy per vault and the policy can be
        /// up to 20 KB in size. For more information about vault access policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the SetVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetVaultAccessPolicy">REST API Reference for SetVaultAccessPolicy Operation</seealso>
        public virtual SetVaultAccessPolicyResponse SetVaultAccessPolicy(SetVaultAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<SetVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// This operation configures an access policy for a vault and will overwrite an existing
        /// policy. To configure a vault access policy, send a PUT request to the <c>access-policy</c>
        /// subresource of the vault. An access policy is specific to a vault and is also called
        /// a vault subresource. You can set one access policy per vault and the policy can be
        /// up to 20 KB in size. For more information about vault access policies, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/vault-access-policy.html">Amazon
        /// Glacier Access Control with Vault Access Policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVaultAccessPolicy service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetVaultAccessPolicy">REST API Reference for SetVaultAccessPolicy Operation</seealso>
        public virtual Task<SetVaultAccessPolicyResponse> SetVaultAccessPolicyAsync(SetVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetVaultNotifications


        /// <summary>
        /// This operation configures notifications that will be sent when specific events happen
        /// to a vault. By default, you don't get any notifications.
        /// 
        ///  
        /// <para>
        /// To configure vault notifications, send a PUT request to the <c>notification-configuration</c>
        /// subresource of the vault. The request should include a JSON document that provides
        /// an Amazon SNS topic and specific events for which you want Amazon S3 Glacier to send
        /// notifications to the topic.
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
        /// to the topic. You can configure a vault to publish a notification for the following
        /// vault events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an archive retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an inventory retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the SetVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetVaultNotifications">REST API Reference for SetVaultNotifications Operation</seealso>
        public virtual SetVaultNotificationsResponse SetVaultNotifications(SetVaultNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<SetVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// This operation configures notifications that will be sent when specific events happen
        /// to a vault. By default, you don't get any notifications.
        /// 
        ///  
        /// <para>
        /// To configure vault notifications, send a PUT request to the <c>notification-configuration</c>
        /// subresource of the vault. The request should include a JSON document that provides
        /// an Amazon SNS topic and specific events for which you want Amazon S3 Glacier to send
        /// notifications to the topic.
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS topics must grant permission to the vault to be allowed to publish notifications
        /// to the topic. You can configure a vault to publish a notification for the following
        /// vault events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ArchiveRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an archive retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InventoryRetrievalCompleted</b> This event occurs when a job that was initiated
        /// for an inventory retrieval is completed (<a>InitiateJob</a>). The status of the completed
        /// job can be "Succeeded" or "Failed". The notification sent to the SNS topic is the
        /// same output as returned from <a>DescribeJob</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        /// For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/configuring-notifications.html">Configuring
        /// Vault Notifications in Amazon S3 Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-vault-notifications-put.html">Set
        /// Vault Notification Configuration </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVaultNotifications service method, as returned by Glacier.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/SetVaultNotifications">REST API Reference for SetVaultNotifications Operation</seealso>
        public virtual Task<SetVaultNotificationsResponse> SetVaultNotificationsAsync(SetVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadArchive


        /// <summary>
        /// This operation adds an archive to a vault. This is a synchronous operation, and for
        /// a successful upload, your data is durably persisted. Amazon S3 Glacier returns the
        /// archive ID in the <c>x-amz-archive-id</c> header of the response. 
        /// 
        ///  
        /// <para>
        /// You must use the archive ID to access your data in Amazon S3 Glacier. After you upload
        /// an archive, you should save the archive ID returned so that you can retrieve or delete
        /// the archive later. Besides saving the archive ID, you can also index it and give it
        /// a friendly name to allow for better searching. You can also use the optional archive
        /// description field to specify how the archive is referred to in an external index of
        /// archives, such as you might create in Amazon DynamoDB. You can also get the vault
        /// inventory to obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must provide a SHA256 tree hash of the data you are uploading. For information
        /// about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify an archive description of up to 1,024 printable ASCII characters.
        /// You can get the archive description when you either retrieve the archive or get the
        /// vault inventory. For more information, see <a>InitiateJob</a>. Amazon Glacier does
        /// not interpret the description in any way. An archive description does not need to
        /// be unique. You cannot use the description to retrieve or sort the archive list. 
        /// </para>
        ///  
        /// <para>
        /// Archives are immutable. After you upload an archive, you cannot edit the archive or
        /// its description.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
        /// an Archive in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html">Upload
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive service method.</param>
        /// 
        /// <returns>The response from the UploadArchive service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon S3 Glacier times out while receiving
        /// the upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/UploadArchive">REST API Reference for UploadArchive Operation</seealso>
        public virtual UploadArchiveResponse UploadArchive(UploadArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadArchiveResponseUnmarshaller.Instance;

            return Invoke<UploadArchiveResponse>(request, options);
        }


        /// <summary>
        /// This operation adds an archive to a vault. This is a synchronous operation, and for
        /// a successful upload, your data is durably persisted. Amazon S3 Glacier returns the
        /// archive ID in the <c>x-amz-archive-id</c> header of the response. 
        /// 
        ///  
        /// <para>
        /// You must use the archive ID to access your data in Amazon S3 Glacier. After you upload
        /// an archive, you should save the archive ID returned so that you can retrieve or delete
        /// the archive later. Besides saving the archive ID, you can also index it and give it
        /// a friendly name to allow for better searching. You can also use the optional archive
        /// description field to specify how the archive is referred to in an external index of
        /// archives, such as you might create in Amazon DynamoDB. You can also get the vault
        /// inventory to obtain a list of archive IDs in a vault. For more information, see <a>InitiateJob</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must provide a SHA256 tree hash of the data you are uploading. For information
        /// about computing a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify an archive description of up to 1,024 printable ASCII characters.
        /// You can get the archive description when you either retrieve the archive or get the
        /// vault inventory. For more information, see <a>InitiateJob</a>. Amazon Glacier does
        /// not interpret the description in any way. An archive description does not need to
        /// be unique. You cannot use the description to retrieve or sort the archive list. 
        /// </para>
        ///  
        /// <para>
        /// Archives are immutable. After you upload an archive, you cannot edit the archive or
        /// its description.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-an-archive.html">Uploading
        /// an Archive in Amazon Glacier</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-archive-post.html">Upload
        /// Archive</a> in the <i>Amazon Glacier Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadArchive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadArchive service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon S3 Glacier times out while receiving
        /// the upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/UploadArchive">REST API Reference for UploadArchive Operation</seealso>
        public virtual Task<UploadArchiveResponse> UploadArchiveAsync(UploadArchiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadArchiveResponseUnmarshaller.Instance;
            
            return InvokeAsync<UploadArchiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadMultipartPart


        /// <summary>
        /// This operation uploads a part of an archive. You can upload archive parts in any order.
        /// You can also upload them in parallel. You can upload up to 10,000 parts for a multipart
        /// upload.
        /// 
        ///  
        /// <para>
        /// Amazon Glacier rejects your upload part request if any of the following conditions
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SHA256 tree hash does not match</b>To ensure that part data is not corrupted in
        /// transmission, you compute a SHA256 tree hash of the part and include it in your request.
        /// Upon receiving the part data, Amazon S3 Glacier also computes a SHA256 tree hash.
        /// If these hash values don't match, the operation fails. For information about computing
        /// a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Part size does not match</b>The size of each part except the last must match the
        /// size specified in the corresponding <a>InitiateMultipartUpload</a> request. The size
        /// of the last part must be the same size as, or smaller than, the specified size.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you upload a part whose size is smaller than the part size you specified in your
        /// initiate multipart upload request and that part is not the last part, then the upload
        /// part request will succeed. However, the subsequent Complete Multipart Upload request
        /// will fail.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b>Range does not align</b>The byte range value in the request does not align with
        /// the part size specified in the corresponding initiate request. For example, if you
        /// specify a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and
        /// 4194304 (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However, if you set a
        /// range value of 2 MB to 6 MB, the range does not align with the part size and the upload
        /// will fail. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. If you upload the same part multiple times, the data
        /// included in the most recent request overwrites the previously uploaded data.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html">Upload
        /// Part </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart service method.</param>
        /// 
        /// <returns>The response from the UploadMultipartPart service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon S3 Glacier times out while receiving
        /// the upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/UploadMultipartPart">REST API Reference for UploadMultipartPart Operation</seealso>
        public virtual UploadMultipartPartResponse UploadMultipartPart(UploadMultipartPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadMultipartPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;

            return Invoke<UploadMultipartPartResponse>(request, options);
        }


        /// <summary>
        /// This operation uploads a part of an archive. You can upload archive parts in any order.
        /// You can also upload them in parallel. You can upload up to 10,000 parts for a multipart
        /// upload.
        /// 
        ///  
        /// <para>
        /// Amazon Glacier rejects your upload part request if any of the following conditions
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>SHA256 tree hash does not match</b>To ensure that part data is not corrupted in
        /// transmission, you compute a SHA256 tree hash of the part and include it in your request.
        /// Upon receiving the part data, Amazon S3 Glacier also computes a SHA256 tree hash.
        /// If these hash values don't match, the operation fails. For information about computing
        /// a SHA256 tree hash, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/checksum-calculations.html">Computing
        /// Checksums</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Part size does not match</b>The size of each part except the last must match the
        /// size specified in the corresponding <a>InitiateMultipartUpload</a> request. The size
        /// of the last part must be the same size as, or smaller than, the specified size.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you upload a part whose size is smaller than the part size you specified in your
        /// initiate multipart upload request and that part is not the last part, then the upload
        /// part request will succeed. However, the subsequent Complete Multipart Upload request
        /// will fail.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b>Range does not align</b>The byte range value in the request does not align with
        /// the part size specified in the corresponding initiate request. For example, if you
        /// specify a part size of 4194304 bytes (4 MB), then 0 to 4194303 bytes (4 MB - 1) and
        /// 4194304 (4 MB) to 8388607 (8 MB - 1) are valid part ranges. However, if you set a
        /// range value of 2 MB to 6 MB, the range does not align with the part size and the upload
        /// will fail. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent. If you upload the same part multiple times, the data
        /// included in the most recent request overwrites the previously uploaded data.
        /// </para>
        ///  
        /// <para>
        /// An AWS account has full permission to perform all operations (actions). However, AWS
        /// Identity and Access Management (IAM) users don't have any permissions by default.
        /// You must grant them explicit permission to perform specific actions. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/using-iam-with-amazon-glacier.html">Access
        /// Control Using AWS Identity and Access Management (IAM)</a>.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information and underlying REST API, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/uploading-archive-mpu.html">Uploading
        /// Large Archives in Parts (Multipart Upload)</a> and <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-upload-part.html">Upload
        /// Part </a> in the <i>Amazon Glacier Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadMultipartPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadMultipartPart service method, as returned by Glacier.</returns>
        /// <exception cref="Amazon.Glacier.Model.InvalidParameterValueException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.MissingParameterValueException">
        /// Returned if a required header or parameter is missing from the request.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.RequestTimeoutException">
        /// Returned if, when uploading an archive, Amazon S3 Glacier times out while receiving
        /// the upload.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ResourceNotFoundException">
        /// Returned if the specified resource (such as a vault, upload ID, or job ID) doesn't
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Glacier.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/glacier-2012-06-01/UploadMultipartPart">REST API Reference for UploadMultipartPart Operation</seealso>
        public virtual Task<UploadMultipartPartResponse> UploadMultipartPartAsync(UploadMultipartPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadMultipartPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadMultipartPartResponseUnmarshaller.Instance;
            
            return InvokeAsync<UploadMultipartPartResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}
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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FSx.Model;
using Amazon.FSx.Model.Internal.MarshallTransformations;
using Amazon.FSx.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FSx
{
    /// <summary>
    /// Implementation for accessing FSx
    ///
    /// Amazon FSx is a fully managed service that makes it easy for storage and application
    /// administrators to launch and use shared file storage.
    /// </summary>
    public partial class AmazonFSxClient : AmazonServiceClient, IAmazonFSx
    {
        private static IServiceMetadata serviceMetadata = new AmazonFSxMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonFSxClient with the credentials loaded from the application's
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
        public AmazonFSxClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFSxConfig()) { }

        /// <summary>
        /// Constructs AmazonFSxClient with the credentials loaded from the application's
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
        public AmazonFSxClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFSxConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFSxClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFSxClient Configuration Object</param>
        public AmazonFSxClient(AmazonFSxConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonFSxClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFSxClient(AWSCredentials credentials)
            : this(credentials, new AmazonFSxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFSxClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFSxConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Credentials and an
        /// AmazonFSxClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFSxClient Configuration Object</param>
        public AmazonFSxClient(AWSCredentials credentials, AmazonFSxConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFSxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFSxConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFSxClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFSxClient Configuration Object</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFSxConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFSxConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFSxConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFSxClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFSxClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFSxClient Configuration Object</param>
        public AmazonFSxClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFSxConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IFSxPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFSxPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FSxPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFSxEndpointResolver());
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


        #region  AssociateFileSystemAliases

        internal virtual AssociateFileSystemAliasesResponse AssociateFileSystemAliases(AssociateFileSystemAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFileSystemAliasesResponseUnmarshaller.Instance;

            return Invoke<AssociateFileSystemAliasesResponse>(request, options);
        }



        /// <summary>
        /// Use this action to associate one or more Domain Name Server (DNS) aliases with an
        /// existing Amazon FSx for Windows File Server file system. A file system can have a
        /// maximum of 50 DNS aliases associated with it at any one time. If you try to associate
        /// a DNS alias that is already associated with the file system, FSx takes no action on
        /// that alias in the request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/walkthrough05-file-system-custom-CNAME.html">Walkthrough
        /// 5: Using DNS aliases to access your file system</a>, including additional steps you
        /// must take to be able to access your file system using a DNS alias.
        /// 
        ///  
        /// <para>
        /// The system response shows the DNS aliases that Amazon FSx is attempting to associate
        /// with the file system. Use the API operation to monitor the status of the aliases Amazon
        /// FSx is associating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystemAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        public virtual Task<AssociateFileSystemAliasesResponse> AssociateFileSystemAliasesAsync(AssociateFileSystemAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFileSystemAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFileSystemAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelDataRepositoryTask

        internal virtual CancelDataRepositoryTaskResponse CancelDataRepositoryTask(CancelDataRepositoryTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataRepositoryTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataRepositoryTaskResponseUnmarshaller.Instance;

            return Invoke<CancelDataRepositoryTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an existing Amazon FSx for Lustre data repository task if that task is in
        /// either the <code>PENDING</code> or <code>EXECUTING</code> state. When you cancel a
        /// task, Amazon FSx does the following.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Any files that FSx has already exported are not reverted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx continues to export any files that are "in-flight" when the cancel operation is
        /// received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx does not export any files that have not yet been exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDataRepositoryTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskEndedException">
        /// The data repository task could not be canceled because the task has already ended.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        public virtual Task<CancelDataRepositoryTaskResponse> CancelDataRepositoryTaskAsync(CancelDataRepositoryTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDataRepositoryTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDataRepositoryTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelDataRepositoryTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyBackup

        internal virtual CopyBackupResponse CopyBackup(CopyBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBackupResponseUnmarshaller.Instance;

            return Invoke<CopyBackupResponse>(request, options);
        }



        /// <summary>
        /// Copies an existing backup within the same Amazon Web Services account to another Amazon
        /// Web Services Region (cross-Region copy) or within the same Amazon Web Services Region
        /// (in-Region copy). You can have up to five backup copy requests in progress to a single
        /// destination Region per account.
        /// 
        ///  
        /// <para>
        /// You can use cross-Region backup copies for cross-Region disaster recovery. You can
        /// periodically take backups and copy them to another Region so that in the event of
        /// a disaster in the primary Region, you can restore from backup and recover availability
        /// quickly in the other Region. You can make cross-Region copies only within your Amazon
        /// Web Services partition. A partition is a grouping of Regions. Amazon Web Services
        /// currently has three partitions: <code>aws</code> (Standard Regions), <code>aws-cn</code>
        /// (China Regions), and <code>aws-us-gov</code> (Amazon Web Services GovCloud [US] Regions).
        /// </para>
        ///  
        /// <para>
        /// You can also use backup copies to clone your file dataset to another Region or within
        /// the same Region.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>SourceRegion</code> parameter to specify the Amazon Web Services
        /// Region from which the backup will be copied. For example, if you make the call from
        /// the <code>us-west-1</code> Region and want to copy a backup from the <code>us-east-2</code>
        /// Region, you specify <code>us-east-2</code> in the <code>SourceRegion</code> parameter
        /// to make a cross-Region copy. If you don't specify a Region, the backup copy is created
        /// in the same Region where the request is sent from (in-Region copy).
        /// </para>
        ///  
        /// <para>
        /// For more information about creating backup copies, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html#copy-backups">
        /// Copying backups</a> in the <i>Amazon FSx for Windows User Guide</i>, <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html#copy-backups">Copying
        /// backups</a> in the <i>Amazon FSx for Lustre User Guide</i>, and <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/using-backups.html#copy-backups">Copying
        /// backups</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleRegionForMultiAZException">
        /// Amazon FSx doesn't support Multi-AZ Windows File Server copy backup in the destination
        /// Region, so the copied backup can't be restored.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidDestinationKmsKeyException">
        /// The Key Management Service (KMS) key of the destination backup is not valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidRegionException">
        /// The Region provided for <code>SourceRegion</code> is not valid or is in a different
        /// Amazon Web Services partition.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidSourceKmsKeyException">
        /// The Key Management Service (KMS) key of the source backup is not valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SourceBackupUnavailableException">
        /// The request was rejected because the lifecycle status of the source backup isn't <code>AVAILABLE</code>.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CopyBackup">REST API Reference for CopyBackup Operation</seealso>
        public virtual Task<CopyBackupResponse> CopyBackupAsync(CopyBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackup

        internal virtual CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return Invoke<CreateBackupResponse>(request, options);
        }



        /// <summary>
        /// Creates a backup of an existing Amazon FSx for Windows File Server file system, Amazon
        /// FSx for Lustre file system, Amazon FSx for NetApp ONTAP volume, or Amazon FSx for
        /// OpenZFS file system. We recommend creating regular backups so that you can restore
        /// a file system or volume from a backup if an issue arises with the original file system
        /// or volume.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Lustre file systems, you can create a backup only for file systems
        /// that have the following configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A Persistent deployment type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Are <i>not</i> linked to a data repository
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about backups, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon FSx for Lustre, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html">Working
        /// with FSx for Lustre backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for Windows, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html">Working
        /// with FSx for Windows backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for NetApp ONTAP, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/using-backups.html">Working
        /// with FSx for NetApp ONTAP backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for OpenZFS, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/using-backups.html">Working
        /// with FSx for OpenZFS backups</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a backup with the specified client request token exists and the parameters match,
        /// this operation returns the description of the existing backup. If a backup with the
        /// specified client request token exists and the parameters don't match, this operation
        /// returns <code>IncompatibleParameterError</code>. If a backup with the specified client
        /// request token doesn't exist, <code>CreateBackup</code> does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx backup with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the backup.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateBackup</code> operation
        /// without the risk of creating an extra backup. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a backup was created. If
        /// you use the same client request token and the initial call created a backup, the operation
        /// returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateBackup</code> operation returns while the backup's lifecycle state
        /// is still <code>CREATING</code>. You can check the backup creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeBackups.html">DescribeBackups</a>
        /// operation, which returns the backup state along with other information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public virtual Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataRepositoryAssociation

        internal virtual CreateDataRepositoryAssociationResponse CreateDataRepositoryAssociation(CreateDataRepositoryAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRepositoryAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDataRepositoryAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon FSx for Lustre data repository association (DRA). A data repository
        /// association is a link between a directory on the file system and an Amazon S3 bucket
        /// or prefix. You can have a maximum of 8 data repository associations on a file system.
        /// Data repository associations are supported only for file systems with the <code>Persistent_2</code>
        /// deployment type.
        /// 
        ///  
        /// <para>
        /// Each data repository association must have a unique Amazon FSx file system directory
        /// and a unique S3 bucket or prefix associated with it. You can configure a data repository
        /// association for automatic import only, for automatic export only, or for both. To
        /// learn more about linking a data repository to your file system, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
        /// your file system to an S3 bucket</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>CreateDataRepositoryAssociation</code> isn't supported on Amazon File Cache
        /// resources. To create a DRA on Amazon File Cache, use the <code>CreateFileCache</code>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryAssociation">REST API Reference for CreateDataRepositoryAssociation Operation</seealso>
        public virtual Task<CreateDataRepositoryAssociationResponse> CreateDataRepositoryAssociationAsync(CreateDataRepositoryAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRepositoryAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataRepositoryAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataRepositoryTask

        internal virtual CreateDataRepositoryTaskResponse CreateDataRepositoryTask(CreateDataRepositoryTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataRepositoryTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRepositoryTaskResponseUnmarshaller.Instance;

            return Invoke<CreateDataRepositoryTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon FSx for Lustre data repository task. You use data repository tasks
        /// to perform bulk operations between your Amazon FSx file system and its linked data
        /// repositories. An example of a data repository task is exporting any data and metadata
        /// changes, including POSIX metadata, to files, directories, and symbolic links (symlinks)
        /// from your FSx file system to a linked data repository. A <code>CreateDataRepositoryTask</code>
        /// operation will fail if a data repository is not linked to the FSx file system. To
        /// learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Data
        /// Repository Tasks</a>. To learn more about linking a data repository to your file system,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
        /// your file system to an S3 bucket</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskExecutingException">
        /// An existing data repository task is currently executing on the file system. Wait until
        /// the existing task has completed, then create the new task.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        public virtual Task<CreateDataRepositoryTaskResponse> CreateDataRepositoryTaskAsync(CreateDataRepositoryTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataRepositoryTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataRepositoryTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataRepositoryTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFileCache

        internal virtual CreateFileCacheResponse CreateFileCache(CreateFileCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileCacheResponseUnmarshaller.Instance;

            return Invoke<CreateFileCacheResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon File Cache resource.
        /// 
        ///  
        /// <para>
        /// You can use this operation with a client request token in the request that Amazon
        /// File Cache uses to ensure idempotent creation. If a cache with the specified client
        /// request token exists and the parameters match, <code>CreateFileCache</code> returns
        /// the description of the existing cache. If a cache with the specified client request
        /// token exists and the parameters don't match, this call returns <code>IncompatibleParameterError</code>.
        /// If a file cache with the specified client request token doesn't exist, <code>CreateFileCache</code>
        /// does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty Amazon File Cache resourcewith an assigned ID, and an initial
        /// lifecycle state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the cache in JSON format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>CreateFileCache</code> call returns while the cache's lifecycle state is
        /// still <code>CREATING</code>. You can check the cache creation status by calling the
        /// <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileCaches.html">DescribeFileCaches</a>
        /// operation, which returns the cache state along with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileCache service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileCacheConfigurationException">
        /// A cache configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileCache">REST API Reference for CreateFileCache Operation</seealso>
        public virtual Task<CreateFileCacheResponse> CreateFileCacheAsync(CreateFileCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileCacheResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFileCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFileSystem

        internal virtual CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;

            return Invoke<CreateFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Creates a new, empty Amazon FSx file system. You can create the following supported
        /// Amazon FSx file systems using the <code>CreateFileSystem</code> API operation:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Amazon FSx for Lustre
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for NetApp ONTAP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for OpenZFS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for Windows File Server
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires a client request token in the request that Amazon FSx uses
        /// to ensure idempotent creation. This means that calling the operation multiple times
        /// with the same client request token has no effect. By using the idempotent operation,
        /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
        /// an extra file system. This approach can be useful when an initial call fails in a
        /// way that makes it unclear whether a file system was created. Examples are if a transport
        /// level timeout occurred, or your connection was reset. If you use the same client request
        /// token and the initial call created a file system, the client receives success as long
        /// as the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, <code>CreateFileSystem</code> returns the description of the existing file
        /// system. If a file system with the specified client request token exists and the parameters
        /// don't match, this call returns <code>IncompatibleParameterError</code>. If a file
        /// system with the specified client request token doesn't exist, <code>CreateFileSystem</code>
        /// does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
        /// state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system in JSON format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>CREATING</code>. You can check the file-system creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
        /// operation, which returns the file system state along with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidExportPathException">
        /// The path provided for data repository export isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidImportPathException">
        /// The path provided for data repository import isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        public virtual Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFileSystemFromBackup

        internal virtual CreateFileSystemFromBackupResponse CreateFileSystemFromBackup(CreateFileSystemFromBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemFromBackupResponseUnmarshaller.Instance;

            return Invoke<CreateFileSystemFromBackupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon FSx for Lustre, Amazon FSx for Windows File Server, or Amazon
        /// FSx for OpenZFS file system from an existing Amazon FSx backup.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, this operation returns the description of the file system. If a file system
        /// with the specified client request token exists but the parameters don't match, this
        /// call returns <code>IncompatibleParameterError</code>. If a file system with the specified
        /// client request token doesn't exist, this operation does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
        /// lifecycle state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Parameters like the Active Directory, default share name, automatic backup, and backup
        /// settings default to the parameters of the file system that was backed up, unless overridden.
        /// You can explicitly supply other settings.
        /// </para>
        ///  
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
        /// call without the risk of creating an extra file system. This approach can be useful
        /// when an initial call fails in a way that makes it unclear whether a file system was
        /// created. Examples are if a transport level timeout occurred, or your connection was
        /// reset. If you use the same client request token and the initial call created a file
        /// system, the client receives a success message as long as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
        /// state is still <code>CREATING</code>. You can check the file-system creation status
        /// by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">
        /// DescribeFileSystems</a> operation, which returns the file system state along with
        /// other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystemFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        public virtual Task<CreateFileSystemFromBackupResponse> CreateFileSystemFromBackupAsync(CreateFileSystemFromBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFileSystemFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFileSystemFromBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFileSystemFromBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of an existing Amazon FSx for OpenZFS volume. With snapshots, you
        /// can easily undo file changes and compare file versions by restoring the volume to
        /// a previous version.
        /// 
        ///  
        /// <para>
        /// If a snapshot with the specified client request token exists, and the parameters match,
        /// this operation returns the description of the existing snapshot. If a snapshot with
        /// the specified client request token exists, and the parameters don't match, this operation
        /// returns <code>IncompatibleParameterError</code>. If a snapshot with the specified
        /// client request token doesn't exist, <code>CreateSnapshot</code> does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new OpenZFS snapshot with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the snapshot.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateSnapshot</code> operation
        /// without the risk of creating an extra snapshot. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a snapshot was created.
        /// If you use the same client request token and the initial call created a snapshot,
        /// the operation returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateSnapshot</code> operation returns while the snapshot's lifecycle state
        /// is still <code>CREATING</code>. You can check the snapshot creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// operation, which returns the snapshot state along with other information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorageVirtualMachine

        internal virtual CreateStorageVirtualMachineResponse CreateStorageVirtualMachine(CreateStorageVirtualMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageVirtualMachineResponseUnmarshaller.Instance;

            return Invoke<CreateStorageVirtualMachineResponse>(request, options);
        }



        /// <summary>
        /// Creates a storage virtual machine (SVM) for an Amazon FSx for ONTAP file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageVirtualMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateStorageVirtualMachine">REST API Reference for CreateStorageVirtualMachine Operation</seealso>
        public virtual Task<CreateStorageVirtualMachineResponse> CreateStorageVirtualMachineAsync(CreateStorageVirtualMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageVirtualMachineResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorageVirtualMachineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        internal virtual CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeResponse>(request, options);
        }



        /// <summary>
        /// Creates an FSx for ONTAP or Amazon FSx for OpenZFS storage volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No FSx for ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVolumeFromBackup

        internal virtual CreateVolumeFromBackupResponse CreateVolumeFromBackup(CreateVolumeFromBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeFromBackupResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeFromBackupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon FSx for NetApp ONTAP volume from an existing Amazon FSx volume
        /// backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolumeFromBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolumeFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No FSx for ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolumeFromBackup">REST API Reference for CreateVolumeFromBackup Operation</seealso>
        public virtual Task<CreateVolumeFromBackupResponse> CreateVolumeFromBackupAsync(CreateVolumeFromBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeFromBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeFromBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackup

        internal virtual DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon FSx backup. After deletion, the backup no longer exists, and its
        /// data is gone.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteBackup</code> call returns instantly. The backup won't show up in
        /// later <code>DescribeBackups</code> calls.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted backup is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupBeingCopiedException">
        /// You can't delete a backup while it's being copied.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupRestoringException">
        /// You can't delete a backup while it's being used to restore a file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public virtual Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataRepositoryAssociation

        internal virtual DeleteDataRepositoryAssociationResponse DeleteDataRepositoryAssociation(DeleteDataRepositoryAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataRepositoryAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDataRepositoryAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a data repository association on an Amazon FSx for Lustre file system. Deleting
        /// the data repository association unlinks the file system from the Amazon S3 bucket.
        /// When deleting a data repository association, you have the option of deleting the data
        /// in the file system that corresponds to the data repository association. Data repository
        /// associations are supported only for file systems with the <code>Persistent_2</code>
        /// deployment type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRepositoryAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteDataRepositoryAssociation">REST API Reference for DeleteDataRepositoryAssociation Operation</seealso>
        public virtual Task<DeleteDataRepositoryAssociationResponse> DeleteDataRepositoryAssociationAsync(DeleteDataRepositoryAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataRepositoryAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataRepositoryAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileCache

        internal virtual DeleteFileCacheResponse DeleteFileCache(DeleteFileCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileCacheResponseUnmarshaller.Instance;

            return Invoke<DeleteFileCacheResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon File Cache resource. After deletion, the cache no longer exists,
        /// and its data is gone.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteFileCache</code> operation returns while the cache has the <code>DELETING</code>
        /// status. You can check the cache deletion status by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileCaches.html">DescribeFileCaches</a>
        /// operation, which returns a list of caches in your account. If you pass the cache ID
        /// for a deleted cache, the <code>DescribeFileCaches</code> operation returns a <code>FileCacheNotFound</code>
        /// error.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted cache is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileCache service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileCacheNotFoundException">
        /// No caches were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileCache">REST API Reference for DeleteFileCache Operation</seealso>
        public virtual Task<DeleteFileCacheResponse> DeleteFileCacheAsync(DeleteFileCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileCacheResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFileSystem

        internal virtual DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;

            return Invoke<DeleteFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Deletes a file system. After deletion, the file system no longer exists, and its data
        /// is gone. Any existing automatic backups and snapshots are also deleted.
        /// 
        ///  
        /// <para>
        /// To delete an Amazon FSx for NetApp ONTAP file system, first delete all the volumes
        /// and storage virtual machines (SVMs) on the file system. Then provide a <code>FileSystemId</code>
        /// value to the <code>DeleFileSystem</code> operation.
        /// </para>
        ///  
        /// <para>
        /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
        /// backup is created upon deletion. This final backup isn't subject to the file system's
        /// retention policy, and must be manually deleted.
        /// </para>
        ///  
        /// <para>
        /// The <code>DeleteFileSystem</code> operation returns while the file system has the
        /// <code>DELETING</code> status. You can check the file system deletion status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
        /// operation, which returns a list of file systems in your account. If you pass the file
        /// system ID for a deleted file system, the <code>DescribeFileSystems</code> operation
        /// returns a <code>FileSystemNotFound</code> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a data repository task is in a <code>PENDING</code> or <code>EXECUTING</code> state,
        /// deleting an Amazon FSx for Lustre file system will fail with an HTTP status code 400
        /// (Bad Request).
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// The data in a deleted file system is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        public virtual Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon FSx for OpenZFS snapshot. After deletion, the snapshot no longer
        /// exists, and its data is gone. Deleting a snapshot doesn't affect snapshots stored
        /// in a file system backup. 
        /// 
        ///  
        /// <para>
        /// The <code>DeleteSnapshot</code> operation returns instantly. The snapshot appears
        /// with the lifecycle status of <code>DELETING</code> until the deletion is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStorageVirtualMachine

        internal virtual DeleteStorageVirtualMachineResponse DeleteStorageVirtualMachine(DeleteStorageVirtualMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageVirtualMachineResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageVirtualMachineResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing Amazon FSx for ONTAP storage virtual machine (SVM). Prior to deleting
        /// an SVM, you must delete all non-root volumes in the SVM, otherwise the operation will
        /// fail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageVirtualMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No FSx for ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteStorageVirtualMachine">REST API Reference for DeleteStorageVirtualMachine Operation</seealso>
        public virtual Task<DeleteStorageVirtualMachineResponse> DeleteStorageVirtualMachineAsync(DeleteStorageVirtualMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageVirtualMachineResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStorageVirtualMachineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackups

        internal virtual DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupsResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of a specific Amazon FSx backup, if a <code>BackupIds</code>
        /// value is provided for that backup. Otherwise, it returns all backups owned by your
        /// Amazon Web Services account in the Amazon Web Services Region of the endpoint that
        /// you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all backups, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of backups in a response. If more backups remain, Amazon
        /// FSx returns a <code>NextToken</code> value in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of the
        /// <code>NextToken</code> value from the last response.
        /// </para>
        ///  
        /// <para>
        /// This operation is used in an iterative process to retrieve a list of your backups.
        /// <code>DescribeBackups</code> is called first without a <code>NextToken</code> value.
        /// Then the operation continues to be called with the <code>NextToken</code> parameter
        /// set to the value of the last <code>NextToken</code> value until a response has no
        /// <code>NextToken</code> value.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The operation might return fewer than the <code>MaxResults</code> value of backup
        /// descriptions while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of the backups returned in the response of one <code>DescribeBackups</code>
        /// call and the order of the backups returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public virtual Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataRepositoryAssociations

        internal virtual DescribeDataRepositoryAssociationsResponse DescribeDataRepositoryAssociations(DescribeDataRepositoryAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataRepositoryAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDataRepositoryAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of specific Amazon FSx for Lustre or Amazon File Cache data
        /// repository associations, if one or more <code>AssociationIds</code> values are provided
        /// in the request, or if filters are used in the request. Data repository associations
        /// are supported only for Amazon FSx for Lustre file systems with the <code>Persistent_2</code>
        /// deployment type and for Amazon File Cache resources.
        /// 
        ///  
        /// <para>
        /// You can use filters to narrow the response to include just data repository associations
        /// for specific file systems (use the <code>file-system-id</code> filter with the ID
        /// of the file system) or caches (use the <code>file-cache-id</code> filter with the
        /// ID of the cache), or data repository associations for a specific repository type (use
        /// the <code>data-repository-type</code> filter with a value of <code>S3</code> or <code>NFS</code>).
        /// If you don't use filters, the response returns all data repository associations owned
        /// by your Amazon Web Services account in the Amazon Web Services Region of the endpoint
        /// that you're calling.
        /// </para>
        ///  
        /// <para>
        /// When retrieving all data repository associations, you can paginate the response by
        /// using the optional <code>MaxResults</code> parameter to limit the number of data repository
        /// associations returned in a response. If more data repository associations remain,
        /// a <code>NextToken</code> value is returned in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataRepositoryAssociations service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidDataRepositoryTypeException">
        /// You have filtered the response to a data repository type that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryAssociations">REST API Reference for DescribeDataRepositoryAssociations Operation</seealso>
        public virtual Task<DescribeDataRepositoryAssociationsResponse> DescribeDataRepositoryAssociationsAsync(DescribeDataRepositoryAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataRepositoryAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataRepositoryAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataRepositoryTasks

        internal virtual DescribeDataRepositoryTasksResponse DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataRepositoryTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataRepositoryTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeDataRepositoryTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of specific Amazon FSx for Lustre or Amazon File Cache data
        /// repository tasks, if one or more <code>TaskIds</code> values are provided in the request,
        /// or if filters are used in the request. You can use filters to narrow the response
        /// to include just tasks for specific file systems or caches, or tasks in a specific
        /// lifecycle state. Otherwise, it returns all data repository tasks owned by your Amazon
        /// Web Services account in the Amazon Web Services Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all tasks, you can paginate the response by using the optional <code>MaxResults</code>
        /// parameter to limit the number of tasks returned in a response. If more tasks remain,
        /// a <code>NextToken</code> value is returned in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataRepositoryTasks service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        public virtual Task<DescribeDataRepositoryTasksResponse> DescribeDataRepositoryTasksAsync(DescribeDataRepositoryTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataRepositoryTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataRepositoryTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataRepositoryTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFileCaches

        internal virtual DescribeFileCachesResponse DescribeFileCaches(DescribeFileCachesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileCachesResponseUnmarshaller.Instance;

            return Invoke<DescribeFileCachesResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of a specific Amazon File Cache resource, if a <code>FileCacheIds</code>
        /// value is provided for that cache. Otherwise, it returns descriptions of all caches
        /// owned by your Amazon Web Services account in the Amazon Web Services Region of the
        /// endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all cache descriptions, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of descriptions in a response. If more cache descriptions
        /// remain, the operation returns a <code>NextToken</code> value in the response. In this
        /// case, send a later request with the <code>NextToken</code> request parameter set to
        /// the value of <code>NextToken</code> from the last response.
        /// </para>
        ///  
        /// <para>
        /// This operation is used in an iterative process to retrieve a list of your cache descriptions.
        /// <code>DescribeFileCaches</code> is called first without a <code>NextToken</code>value.
        /// Then the operation continues to be called with the <code>NextToken</code> parameter
        /// set to the value of the last <code>NextToken</code> value until a response has no
        /// <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> cache descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of caches returned in the response of one <code>DescribeFileCaches</code>
        /// call and the order of caches returned across the responses of a multicall iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileCaches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileCaches service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileCacheNotFoundException">
        /// No caches were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileCaches">REST API Reference for DescribeFileCaches Operation</seealso>
        public virtual Task<DescribeFileCachesResponse> DescribeFileCachesAsync(DescribeFileCachesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileCachesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileCachesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFileCachesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFileSystemAliases

        internal virtual DescribeFileSystemAliasesResponse DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemAliasesResponseUnmarshaller.Instance;

            return Invoke<DescribeFileSystemAliasesResponse>(request, options);
        }



        /// <summary>
        /// Returns the DNS aliases that are associated with the specified Amazon FSx for Windows
        /// File Server file system. A history of all DNS aliases that have been associated with
        /// and disassociated from the file system is available in the list of <a>AdministrativeAction</a>
        /// provided in the <a>DescribeFileSystems</a> operation response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        public virtual Task<DescribeFileSystemAliasesResponse> DescribeFileSystemAliasesAsync(DescribeFileSystemAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFileSystemAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFileSystems

        internal virtual DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemsResponseUnmarshaller.Instance;

            return Invoke<DescribeFileSystemsResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of specific Amazon FSx file systems, if a <code>FileSystemIds</code>
        /// value is provided for that file system. Otherwise, it returns descriptions of all
        /// file systems owned by your Amazon Web Services account in the Amazon Web Services
        /// Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of descriptions in a response. If more file system descriptions
        /// remain, Amazon FSx returns a <code>NextToken</code> value in the response. In this
        /// case, send a later request with the <code>NextToken</code> request parameter set to
        /// the value of <code>NextToken</code> from the last response.
        /// </para>
        ///  
        /// <para>
        /// This operation is used in an iterative process to retrieve a list of your file system
        /// descriptions. <code>DescribeFileSystems</code> is called first without a <code>NextToken</code>value.
        /// Then the operation continues to be called with the <code>NextToken</code> parameter
        /// set to the value of the last <code>NextToken</code> value until a response has no
        /// <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multicall iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        public virtual Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFileSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFileSystemsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFileSystemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns the description of specific Amazon FSx for OpenZFS snapshots, if a <code>SnapshotIds</code>
        /// value is provided. Otherwise, this operation returns all snapshots owned by your Amazon
        /// Web Services account in the Amazon Web Services Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all snapshots, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of snapshots in a response. If more backups remain,
        /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
        /// a later request with the <code>NextToken</code> request parameter set to the value
        /// of <code>NextToken</code> from the last response. 
        /// </para>
        ///  
        /// <para>
        /// Use this operation in an iterative process to retrieve a list of your snapshots. <code>DescribeSnapshots</code>
        /// is called first without a <code>NextToken</code> value. Then the operation continues
        /// to be called with the <code>NextToken</code> parameter set to the value of the last
        /// <code>NextToken</code> value until a response has no <code>NextToken</code> value.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The operation might return fewer than the <code>MaxResults</code> value of snapshot
        /// descriptions while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of snapshots returned in the response of one <code>DescribeSnapshots</code>
        /// call and the order of backups returned across the responses of a multi-call iteration
        /// is unspecified. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorageVirtualMachines

        internal virtual DescribeStorageVirtualMachinesResponse DescribeStorageVirtualMachines(DescribeStorageVirtualMachinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageVirtualMachinesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more Amazon FSx for NetApp ONTAP storage virtual machines (SVMs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageVirtualMachines service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No FSx for ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeStorageVirtualMachines">REST API Reference for DescribeStorageVirtualMachines Operation</seealso>
        public virtual Task<DescribeStorageVirtualMachinesResponse> DescribeStorageVirtualMachinesAsync(DescribeStorageVirtualMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageVirtualMachinesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageVirtualMachinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS volumes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFileSystemAliases

        internal virtual DisassociateFileSystemAliasesResponse DisassociateFileSystemAliases(DisassociateFileSystemAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFileSystemAliasesResponseUnmarshaller.Instance;

            return Invoke<DisassociateFileSystemAliasesResponse>(request, options);
        }



        /// <summary>
        /// Use this action to disassociate, or remove, one or more Domain Name Service (DNS)
        /// aliases from an Amazon FSx for Windows File Server file system. If you attempt to
        /// disassociate a DNS alias that is not associated with the file system, Amazon FSx responds
        /// with a 400 Bad Request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a>.
        /// 
        ///  
        /// <para>
        /// The system generated response showing the DNS aliases that Amazon FSx is attempting
        /// to disassociate from the file system. Use the API operation to monitor the status
        /// of the aliases Amazon FSx is disassociating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystemAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        public virtual Task<DisassociateFileSystemAliasesResponse> DisassociateFileSystemAliasesAsync(DisassociateFileSystemAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFileSystemAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFileSystemAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFileSystemAliasesResponse>(request, options, cancellationToken);
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
        /// Lists tags for Amazon FSx resources.
        /// 
        ///  
        /// <para>
        /// When retrieving all tags, you can optionally specify the <code>MaxResults</code> parameter
        /// to limit the number of tags in a response. If more tags remain, Amazon FSx returns
        /// a <code>NextToken</code> value in the response. In this case, send a later request
        /// with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your tags. <code>ListTagsForResource</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of tags returned in the response of one <code>ListTagsForResource</code>
        /// call and the order of tags returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseFileSystemNfsV3Locks

        internal virtual ReleaseFileSystemNfsV3LocksResponse ReleaseFileSystemNfsV3Locks(ReleaseFileSystemNfsV3LocksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseFileSystemNfsV3LocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseFileSystemNfsV3LocksResponseUnmarshaller.Instance;

            return Invoke<ReleaseFileSystemNfsV3LocksResponse>(request, options);
        }



        /// <summary>
        /// Releases the file system lock from an Amazon FSx for OpenZFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseFileSystemNfsV3Locks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseFileSystemNfsV3Locks service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ReleaseFileSystemNfsV3Locks">REST API Reference for ReleaseFileSystemNfsV3Locks Operation</seealso>
        public virtual Task<ReleaseFileSystemNfsV3LocksResponse> ReleaseFileSystemNfsV3LocksAsync(ReleaseFileSystemNfsV3LocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseFileSystemNfsV3LocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseFileSystemNfsV3LocksResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseFileSystemNfsV3LocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreVolumeFromSnapshot

        internal virtual RestoreVolumeFromSnapshotResponse RestoreVolumeFromSnapshot(RestoreVolumeFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreVolumeFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreVolumeFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreVolumeFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Returns an Amazon FSx for OpenZFS volume to the state saved by the specified snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreVolumeFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreVolumeFromSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/RestoreVolumeFromSnapshot">REST API Reference for RestoreVolumeFromSnapshot Operation</seealso>
        public virtual Task<RestoreVolumeFromSnapshotResponse> RestoreVolumeFromSnapshotAsync(RestoreVolumeFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreVolumeFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreVolumeFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreVolumeFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Tags an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// This action removes a tag from an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataRepositoryAssociation

        internal virtual UpdateDataRepositoryAssociationResponse UpdateDataRepositoryAssociation(UpdateDataRepositoryAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRepositoryAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDataRepositoryAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing data repository association on an Amazon
        /// FSx for Lustre file system. Data repository associations are supported only for file
        /// systems with the <code>Persistent_2</code> deployment type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRepositoryAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateDataRepositoryAssociation">REST API Reference for UpdateDataRepositoryAssociation Operation</seealso>
        public virtual Task<UpdateDataRepositoryAssociationResponse> UpdateDataRepositoryAssociationAsync(UpdateDataRepositoryAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataRepositoryAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataRepositoryAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFileCache

        internal virtual UpdateFileCacheResponse UpdateFileCache(UpdateFileCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileCacheResponseUnmarshaller.Instance;

            return Invoke<UpdateFileCacheResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing Amazon File Cache resource. You can update
        /// multiple properties in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFileCache service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileCacheNotFoundException">
        /// No caches were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileCacheConfigurationException">
        /// A cache configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileCache">REST API Reference for UpdateFileCache Operation</seealso>
        public virtual Task<UpdateFileCacheResponse> UpdateFileCacheAsync(UpdateFileCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileCacheResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFileCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFileSystem

        internal virtual UpdateFileSystemResponse UpdateFileSystem(UpdateFileSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemResponseUnmarshaller.Instance;

            return Invoke<UpdateFileSystemResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to update the configuration of an existing Amazon FSx file system.
        /// You can update multiple properties in a single request.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Windows File Server file systems, you can update the following
        /// properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AuditLogConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SelfManagedActiveDirectoryConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ThroughputCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Amazon FSx for Lustre file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutoImportPolicy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataCompressionType</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LustreRootSquashConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Amazon FSx for NetApp ONTAP file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DiskIopsConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FsxAdminPassword</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ThroughputCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the Amazon FSx for OpenZFS file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CopyTagsToBackups</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CopyTagsToVolumes</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ThroughputCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        public virtual Task<UpdateFileSystemResponse> UpdateFileSystemAsync(UpdateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFileSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFileSystemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFileSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSnapshot

        internal virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of an Amazon FSx for OpenZFS snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStorageVirtualMachine

        internal virtual UpdateStorageVirtualMachineResponse UpdateStorageVirtualMachine(UpdateStorageVirtualMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageVirtualMachineResponseUnmarshaller.Instance;

            return Invoke<UpdateStorageVirtualMachineResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon FSx for ONTAP storage virtual machine (SVM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageVirtualMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No FSx for ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateStorageVirtualMachine">REST API Reference for UpdateStorageVirtualMachine Operation</seealso>
        public virtual Task<UpdateStorageVirtualMachineResponse> UpdateStorageVirtualMachineAsync(UpdateStorageVirtualMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStorageVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageVirtualMachineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStorageVirtualMachineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVolume

        internal virtual UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return Invoke<UpdateVolumeResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS
        /// volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        public virtual Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
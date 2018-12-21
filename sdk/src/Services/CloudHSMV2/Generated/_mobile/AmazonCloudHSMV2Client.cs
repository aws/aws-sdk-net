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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudHSMV2.Model;
using Amazon.CloudHSMV2.Model.Internal.MarshallTransformations;
using Amazon.CloudHSMV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudHSMV2
{
    /// <summary>
    /// Implementation for accessing CloudHSMV2
    ///
    /// For more information about AWS CloudHSM, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a> and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>.
    /// </summary>
    public partial class AmazonCloudHSMV2Client : AmazonServiceClient, IAmazonCloudHSMV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudHSMV2Metadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with the credentials loaded from the application's
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
        public AmazonCloudHSMV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMV2Config()) { }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with the credentials loaded from the application's
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
        public AmazonCloudHSMV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudHSMV2Client Configuration Object</param>
        public AmazonCloudHSMV2Client(AmazonCloudHSMV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudHSMV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonCloudHSMV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudHSMV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Credentials and an
        /// AmazonCloudHSMV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudHSMV2Client Configuration Object</param>
        public AmazonCloudHSMV2Client(AWSCredentials credentials, AmazonCloudHSMV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudHSMV2Client Configuration Object</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudHSMV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudHSMV2Client Configuration Object</param>
        public AmazonCloudHSMV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudHSMV2Config clientConfig)
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


        #region  CopyBackupToRegion

        internal virtual CopyBackupToRegionResponse CopyBackupToRegion(CopyBackupToRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyBackupToRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBackupToRegionResponseUnmarshaller.Instance;

            return Invoke<CopyBackupToRegionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyBackupToRegion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyBackupToRegion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CopyBackupToRegion">REST API Reference for CopyBackupToRegion Operation</seealso>
        public virtual Task<CopyBackupToRegionResponse> CopyBackupToRegionAsync(CopyBackupToRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyBackupToRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyBackupToRegionResponseUnmarshaller.Instance;

            return InvokeAsync<CopyBackupToRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHsm

        internal virtual CreateHsmResponse CreateHsm(CreateHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return Invoke<CreateHsmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        public virtual Task<CreateHsmResponse> CreateHsmAsync(CreateHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public virtual Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsm

        internal virtual DeleteHsmResponse DeleteHsm(DeleteHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual Task<DeleteHsmResponse> DeleteHsmAsync(DeleteHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public virtual Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitializeCluster

        internal virtual InitializeClusterResponse InitializeCluster(InitializeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeClusterResponseUnmarshaller.Instance;

            return Invoke<InitializeClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitializeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/InitializeCluster">REST API Reference for InitializeCluster Operation</seealso>
        public virtual Task<InitializeClusterResponse> InitializeClusterAsync(InitializeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitializeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<InitializeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreBackup

        internal virtual RestoreBackupResponse RestoreBackup(RestoreBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreBackupResponseUnmarshaller.Instance;

            return Invoke<RestoreBackupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/RestoreBackup">REST API Reference for RestoreBackup Operation</seealso>
        public virtual Task<RestoreBackupResponse> RestoreBackupAsync(RestoreBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreBackupResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreBackupResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsmv2-2017-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
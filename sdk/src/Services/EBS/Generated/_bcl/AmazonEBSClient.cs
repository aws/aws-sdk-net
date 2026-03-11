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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EBS.Model;
using Amazon.EBS.Model.Internal.MarshallTransformations;
using Amazon.EBS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.EBS
{
    /// <summary>
    /// <para>Implementation for accessing EBS</para>
    ///
    /// You can use the Amazon Elastic Block Store (Amazon EBS) direct APIs to create Amazon
    /// EBS snapshots, write data directly to your snapshots, read data on your snapshots,
    /// and identify the differences or changes between two snapshots. If you’re an independent
    /// software vendor (ISV) who offers backup services for Amazon EBS, the EBS direct APIs
    /// make it more efficient and cost-effective to track incremental changes on your Amazon
    /// EBS volumes through snapshots. This can be done without having to create new volumes
    /// from snapshots, and then use Amazon Elastic Compute Cloud (Amazon EC2) instances to
    /// compare the differences.
    /// 
    ///  
    /// <para>
    /// You can create incremental snapshots directly from data on-premises into volumes and
    /// the cloud to use for quick disaster recovery. With the ability to write and read snapshots,
    /// you can write your on-premises data to an snapshot during a disaster. Then after recovery,
    /// you can restore it back to Amazon Web Services or on-premises from the snapshot. You
    /// no longer need to build and maintain complex mechanisms to copy data to and from Amazon
    /// EBS.
    /// </para>
    ///  
    /// <para>
    /// This API reference provides detailed information about the actions, data types, parameters,
    /// and errors of the EBS direct APIs. For more information about the elements that make
    /// up the EBS direct APIs, and examples of how to use them effectively, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html">Accessing
    /// the Contents of an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i>. For more information about the supported Amazon Web Services Regions,
    /// endpoints, and service quotas for the EBS direct APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/ebs-service.html">Amazon
    /// Elastic Block Store Endpoints and Quotas</a> in the <i>Amazon Web Services General
    /// Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonEBSClient : AmazonServiceClient, IAmazonEBS
    {
        private static IServiceMetadata serviceMetadata = new AmazonEBSMetadata();
        private IEBSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEBSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EBSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonEBSClient with the credentials loaded from the application's
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
        public AmazonEBSClient()
            : base(new AmazonEBSConfig()) { }

        /// <summary>
        /// Constructs AmazonEBSClient with the credentials loaded from the application's
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
        public AmazonEBSClient(RegionEndpoint region)
            : base(new AmazonEBSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEBSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEBSClient Configuration Object</param>
        public AmazonEBSClient(AmazonEBSConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEBSClient(AWSCredentials credentials)
            : this(credentials, new AmazonEBSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEBSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEBSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Credentials and an
        /// AmazonEBSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEBSClient Configuration Object</param>
        public AmazonEBSClient(AWSCredentials credentials, AmazonEBSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEBSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEBSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEBSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEBSClient Configuration Object</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEBSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEBSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEBSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEBSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEBSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEBSClient Configuration Object</param>
        public AmazonEBSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEBSConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEBSEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEBSAuthSchemeHandler());
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


        #region  CompleteSnapshot


        /// <summary>
        /// Seals and completes the snapshot after all of the required blocks of data have been
        /// written to it. Completing the snapshot changes the status to <c>completed</c>. You
        /// cannot write new blocks to a snapshot after it has been completed.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the CompleteSnapshot service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/CompleteSnapshot">REST API Reference for CompleteSnapshot Operation</seealso>
        public virtual CompleteSnapshotResponse CompleteSnapshot(CompleteSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<CompleteSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Seals and completes the snapshot after all of the required blocks of data have been
        /// written to it. Completing the snapshot changes the status to <c>completed</c>. You
        /// cannot write new blocks to a snapshot after it has been completed.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteSnapshot service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/CompleteSnapshot">REST API Reference for CompleteSnapshot Operation</seealso>
        public virtual Task<CompleteSnapshotResponse> CompleteSnapshotAsync(CompleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CompleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshotBlock


        /// <summary>
        /// Returns the data in a block in an Amazon Elastic Block Store snapshot.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock service method.</param>
        /// 
        /// <returns>The response from the GetSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual GetSnapshotBlockResponse GetSnapshotBlock(GetSnapshotBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotBlockResponse>(request, options);
        }


        /// <summary>
        /// Returns the data in a block in an Amazon Elastic Block Store snapshot.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual Task<GetSnapshotBlockResponse> GetSnapshotBlockAsync(GetSnapshotBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSnapshotBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangedBlocks


        /// <summary>
        /// Returns information about the blocks that are different between two Amazon Elastic
        /// Block Store snapshots of the same volume/snapshot lineage.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks service method.</param>
        /// 
        /// <returns>The response from the ListChangedBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual ListChangedBlocksResponse ListChangedBlocks(ListChangedBlocksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;

            return Invoke<ListChangedBlocksResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the blocks that are different between two Amazon Elastic
        /// Block Store snapshots of the same volume/snapshot lineage.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangedBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual Task<ListChangedBlocksResponse> ListChangedBlocksAsync(ListChangedBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChangedBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSnapshotBlocks


        /// <summary>
        /// Returns information about the blocks in an Amazon Elastic Block Store snapshot.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks service method.</param>
        /// 
        /// <returns>The response from the ListSnapshotBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual ListSnapshotBlocksResponse ListSnapshotBlocks(ListSnapshotBlocksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotBlocksResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the blocks in an Amazon Elastic Block Store snapshot.
        /// 
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshotBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual Task<ListSnapshotBlocksResponse> ListSnapshotBlocksAsync(ListSnapshotBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSnapshotBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSnapshotBlock


        /// <summary>
        /// Writes a block of data to a snapshot. If the specified block contains data, the existing
        /// data is overwritten. The target snapshot must be in the <c>pending</c> state.
        /// 
        ///  
        /// <para>
        /// Data written to a snapshot must be aligned with 512-KiB sectors.
        /// </para>
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSnapshotBlock service method.</param>
        /// 
        /// <returns>The response from the PutSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/PutSnapshotBlock">REST API Reference for PutSnapshotBlock Operation</seealso>
        public virtual PutSnapshotBlockResponse PutSnapshotBlock(PutSnapshotBlockRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSnapshotBlockResponseUnmarshaller.Instance;

            return Invoke<PutSnapshotBlockResponse>(request, options);
        }


        /// <summary>
        /// Writes a block of data to a snapshot. If the specified block contains data, the existing
        /// data is overwritten. The target snapshot must be in the <c>pending</c> state.
        /// 
        ///  
        /// <para>
        /// Data written to a snapshot must be aligned with 512-KiB sectors.
        /// </para>
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSnapshotBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/PutSnapshotBlock">REST API Reference for PutSnapshotBlock Operation</seealso>
        public virtual Task<PutSnapshotBlockResponse> PutSnapshotBlockAsync(PutSnapshotBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSnapshotBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutSnapshotBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSnapshot


        /// <summary>
        /// Creates a new Amazon EBS snapshot. The new snapshot enters the <c>pending</c> state
        /// after the request completes. 
        /// 
        ///  
        /// <para>
        /// After creating the snapshot, use <a href="https://docs.aws.amazon.com/ebs/latest/APIReference/API_PutSnapshotBlock.html">
        /// PutSnapshotBlock</a> to write blocks of data to the snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSnapshot service method.</param>
        /// 
        /// <returns>The response from the StartSnapshot service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ConcurrentLimitExceededException">
        /// You have reached the limit for concurrent API requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html#ebsapi-performance">Optimizing
        /// performance of the EBS direct APIs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ConflictException">
        /// The request uses the same client token as a previous, but non-identical request.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/StartSnapshot">REST API Reference for StartSnapshot Operation</seealso>
        public virtual StartSnapshotResponse StartSnapshot(StartSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSnapshotResponseUnmarshaller.Instance;

            return Invoke<StartSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Amazon EBS snapshot. The new snapshot enters the <c>pending</c> state
        /// after the request completes. 
        /// 
        ///  
        /// <para>
        /// After creating the snapshot, use <a href="https://docs.aws.amazon.com/ebs/latest/APIReference/API_PutSnapshotBlock.html">
        /// PutSnapshotBlock</a> to write blocks of data to the snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// You should always retry requests that receive server (<c>5xx</c>) error responses,
        /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
        /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSnapshot service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ConcurrentLimitExceededException">
        /// You have reached the limit for concurrent API requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html#ebsapi-performance">Optimizing
        /// performance of the EBS direct APIs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ConflictException">
        /// The request uses the same client token as a previous, but non-identical request.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the snapshot. For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
        /// retries</a>.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ServiceQuotaExceededException">
        /// Your current service quotas do not allow you to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/StartSnapshot">REST API Reference for StartSnapshot Operation</seealso>
        public virtual Task<StartSnapshotResponse> StartSnapshotAsync(StartSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSnapshotResponse>(request, options, cancellationToken);
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
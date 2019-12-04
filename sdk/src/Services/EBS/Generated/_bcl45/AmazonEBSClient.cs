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

namespace Amazon.EBS
{
    /// <summary>
    /// Implementation for accessing EBS
    ///
    /// You can use the Amazon Elastic Block Store (EBS) direct APIs to directly read the
    /// data on your EBS snapshots, and identify the difference between two snapshots. You
    /// can view the details of blocks in an EBS snapshot, compare the block difference between
    /// two snapshots, and directly access the data in a snapshot. If you’re an independent
    /// software vendor (ISV) who offers backup services for EBS, the EBS direct APIs makes
    /// it easier and more cost-effective to track incremental changes on your EBS volumes
    /// via EBS snapshots. This can be done without having to create new volumes from EBS
    /// snapshots, and then use EC2 instances to compare the differences.
    /// 
    ///  
    /// <para>
    /// This API reference provides detailed information about the actions, data types, parameters,
    /// and errors of the EBS direct APIs. For more information about the elements that make
    /// up the EBS direct APIs, and examples of how to use them effectively, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html">Accessing
    /// the Contents of an EBS Snapshot</a>. For more information about how to use the EBS
    /// direct APIs, see the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshots.html">EBS
    /// direct APIs User Guide</a>. To view the currently supported AWS Regions and endpoints
    /// for the EBS direct APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ebs_region">AWS
    /// Service Endpoints</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonEBSClient : AmazonServiceClient, IAmazonEBS
    {
        private static IServiceMetadata serviceMetadata = new AmazonEBSMetadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEBSConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEBSConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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


        #region  GetSnapshotBlock


        /// <summary>
        /// Returns the data in a block in an Amazon Elastic Block Store snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock service method.</param>
        /// 
        /// <returns>The response from the GetSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual GetSnapshotBlockResponse GetSnapshotBlock(GetSnapshotBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotBlockResponse>(request, options);
        }


        /// <summary>
        /// Returns the data in a block in an Amazon Elastic Block Store snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual Task<GetSnapshotBlockResponse> GetSnapshotBlockAsync(GetSnapshotBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSnapshotBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangedBlocks


        /// <summary>
        /// Returns the block indexes and block tokens for blocks that are different between two
        /// Amazon Elastic Block Store snapshots of the same volume/snapshot lineage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks service method.</param>
        /// 
        /// <returns>The response from the ListChangedBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual ListChangedBlocksResponse ListChangedBlocks(ListChangedBlocksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;

            return Invoke<ListChangedBlocksResponse>(request, options);
        }


        /// <summary>
        /// Returns the block indexes and block tokens for blocks that are different between two
        /// Amazon Elastic Block Store snapshots of the same volume/snapshot lineage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangedBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual Task<ListChangedBlocksResponse> ListChangedBlocksAsync(ListChangedBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChangedBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSnapshotBlocks


        /// <summary>
        /// Returns the block indexes and block tokens for blocks in an Amazon Elastic Block Store
        /// snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks service method.</param>
        /// 
        /// <returns>The response from the ListSnapshotBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual ListSnapshotBlocksResponse ListSnapshotBlocks(ListSnapshotBlocksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotBlocksResponse>(request, options);
        }


        /// <summary>
        /// Returns the block indexes and block tokens for blocks in an Amazon Elastic Block Store
        /// snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshotBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.ValidationException">
        /// The input fails to satisfy the constraints of the EBS direct APIs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual Task<ListSnapshotBlocksResponse> ListSnapshotBlocksAsync(ListSnapshotBlocksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSnapshotBlocksResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
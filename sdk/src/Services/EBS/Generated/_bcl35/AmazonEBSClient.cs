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
    /// You can use the Amazon Elastic Block Store (Amazon EBS) direct APIs to create EBS
    /// snapshots, write data directly to your snapshots, read data on your snapshots, and
    /// identify the differences or changes between two snapshots. If you’re an independent
    /// software vendor (ISV) who offers backup services for Amazon EBS, the EBS direct APIs
    /// make it more efficient and cost-effective to track incremental changes on your EBS
    /// volumes through snapshots. This can be done without having to create new volumes from
    /// snapshots, and then use Amazon Elastic Compute Cloud (Amazon EC2) instances to compare
    /// the differences.
    /// 
    ///  
    /// <para>
    /// You can create incremental snapshots directly from data on-premises into EBS volumes
    /// and the cloud to use for quick disaster recovery. With the ability to write and read
    /// snapshots, you can write your on-premises data to an EBS snapshot during a disaster.
    /// Then after recovery, you can restore it back to AWS or on-premises from the snapshot.
    /// You no longer need to build and maintain complex mechanisms to copy data to and from
    /// Amazon EBS.
    /// </para>
    ///  
    /// <para>
    /// This API reference provides detailed information about the actions, data types, parameters,
    /// and errors of the EBS direct APIs. For more information about the elements that make
    /// up the EBS direct APIs, and examples of how to use them effectively, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-accessing-snapshot.html">Accessing
    /// the Contents of an EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// For more information about the supported AWS Regions, endpoints, and service quotas
    /// for the EBS direct APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/ebs-service.html">Amazon
    /// Elastic Block Store Endpoints and Quotas</a> in the <i>AWS General Reference</i>.
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


        #region  CompleteSnapshot

        /// <summary>
        /// Seals and completes the snapshot after all of the required blocks of data have been
        /// written to it. Completing the snapshot changes the status to <code>completed</code>.
        /// You cannot write new blocks to a snapshot after it has been completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the CompleteSnapshot service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<CompleteSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteSnapshot operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/CompleteSnapshot">REST API Reference for CompleteSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCompleteSnapshot(CompleteSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteSnapshot.</param>
        /// 
        /// <returns>Returns a  CompleteSnapshotResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/CompleteSnapshot">REST API Reference for CompleteSnapshot Operation</seealso>
        public virtual CompleteSnapshotResponse EndCompleteSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSnapshotBlock

        /// <summary>
        /// Returns the data in a block in an Amazon Elastic Block Store snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock service method.</param>
        /// 
        /// <returns>The response from the GetSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshotBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotBlock operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshotBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual IAsyncResult BeginGetSnapshotBlock(GetSnapshotBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshotBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshotBlock.</param>
        /// 
        /// <returns>Returns a  GetSnapshotBlockResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        public virtual GetSnapshotBlockResponse EndGetSnapshotBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSnapshotBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChangedBlocks

        /// <summary>
        /// Returns information about the blocks that are different between two Amazon Elastic
        /// Block Store snapshots of the same volume/snapshot lineage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks service method.</param>
        /// 
        /// <returns>The response from the ListChangedBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;

            return Invoke<ListChangedBlocksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangedBlocks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangedBlocks operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangedBlocks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual IAsyncResult BeginListChangedBlocks(ListChangedBlocksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangedBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangedBlocksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangedBlocks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangedBlocks.</param>
        /// 
        /// <returns>Returns a  ListChangedBlocksResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        public virtual ListChangedBlocksResponse EndListChangedBlocks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChangedBlocksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSnapshotBlocks

        /// <summary>
        /// Returns information about the blocks in an Amazon Elastic Block Store snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks service method.</param>
        /// 
        /// <returns>The response from the ListSnapshotBlocks service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotBlocksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshotBlocks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshotBlocks operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshotBlocks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual IAsyncResult BeginListSnapshotBlocks(ListSnapshotBlocksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotBlocksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotBlocksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshotBlocks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshotBlocks.</param>
        /// 
        /// <returns>Returns a  ListSnapshotBlocksResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        public virtual ListSnapshotBlocksResponse EndListSnapshotBlocks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSnapshotBlocksResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSnapshotBlock

        /// <summary>
        /// Writes a block of data to a snapshot. If the specified block contains data, the existing
        /// data is overwritten. The target snapshot must be in the <code>pending</code> state.
        /// 
        ///  
        /// <para>
        /// Data written to a snapshot must be aligned with 512-byte sectors.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSnapshotBlock service method.</param>
        /// 
        /// <returns>The response from the PutSnapshotBlock service method, as returned by EBS.</returns>
        /// <exception cref="Amazon.EBS.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSnapshotBlockResponseUnmarshaller.Instance;

            return Invoke<PutSnapshotBlockResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSnapshotBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSnapshotBlock operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSnapshotBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/PutSnapshotBlock">REST API Reference for PutSnapshotBlock Operation</seealso>
        public virtual IAsyncResult BeginPutSnapshotBlock(PutSnapshotBlockRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSnapshotBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSnapshotBlockResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSnapshotBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSnapshotBlock.</param>
        /// 
        /// <returns>Returns a  PutSnapshotBlockResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/PutSnapshotBlock">REST API Reference for PutSnapshotBlock Operation</seealso>
        public virtual PutSnapshotBlockResponse EndPutSnapshotBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSnapshotBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSnapshot

        /// <summary>
        /// Creates a new Amazon EBS snapshot. The new snapshot enters the <code>pending</code>
        /// state after the request completes. 
        /// 
        ///  
        /// <para>
        /// After creating the snapshot, use <a href="https://docs.aws.amazon.com/ebs/latest/APIReference/API_PutSnapshotBlock.html">
        /// PutSnapshotBlock</a> to write blocks of data to the snapshot.
        /// </para>
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
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.EBS.Model.RequestThrottledException">
        /// The number of API requests has exceed the maximum allowed API request throttling limit.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSnapshotResponseUnmarshaller.Instance;

            return Invoke<StartSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSnapshot operation on AmazonEBSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/StartSnapshot">REST API Reference for StartSnapshot Operation</seealso>
        public virtual IAsyncResult BeginStartSnapshot(StartSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSnapshot.</param>
        /// 
        /// <returns>Returns a  StartSnapshotResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/StartSnapshot">REST API Reference for StartSnapshot Operation</seealso>
        public virtual StartSnapshotResponse EndStartSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSnapshotResponse>(asyncResult);
        }

        #endregion
        
    }
}
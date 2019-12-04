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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EBS.Model;

namespace Amazon.EBS
{
    /// <summary>
    /// Interface for accessing EBS
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
    public partial interface IAmazonEBS : IAmazonService, IDisposable
    {

        
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
        GetSnapshotBlockResponse GetSnapshotBlock(GetSnapshotBlockRequest request);

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
        IAsyncResult BeginGetSnapshotBlock(GetSnapshotBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshotBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshotBlock.</param>
        /// 
        /// <returns>Returns a  GetSnapshotBlockResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/GetSnapshotBlock">REST API Reference for GetSnapshotBlock Operation</seealso>
        GetSnapshotBlockResponse EndGetSnapshotBlock(IAsyncResult asyncResult);

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
        ListChangedBlocksResponse ListChangedBlocks(ListChangedBlocksRequest request);

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
        IAsyncResult BeginListChangedBlocks(ListChangedBlocksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangedBlocks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangedBlocks.</param>
        /// 
        /// <returns>Returns a  ListChangedBlocksResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListChangedBlocks">REST API Reference for ListChangedBlocks Operation</seealso>
        ListChangedBlocksResponse EndListChangedBlocks(IAsyncResult asyncResult);

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
        ListSnapshotBlocksResponse ListSnapshotBlocks(ListSnapshotBlocksRequest request);

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
        IAsyncResult BeginListSnapshotBlocks(ListSnapshotBlocksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshotBlocks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshotBlocks.</param>
        /// 
        /// <returns>Returns a  ListSnapshotBlocksResult from EBS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ebs-2019-11-02/ListSnapshotBlocks">REST API Reference for ListSnapshotBlocks Operation</seealso>
        ListSnapshotBlocksResponse EndListSnapshotBlocks(IAsyncResult asyncResult);

        #endregion
        
    }
}
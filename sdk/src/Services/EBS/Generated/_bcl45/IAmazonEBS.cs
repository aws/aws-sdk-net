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
using System.Threading;
using System.Threading.Tasks;
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
    /// software vendor (ISV) who offers backup services for EBS, the EBS direct APIs make
    /// it easier and more cost-effective to track incremental changes on your EBS volumes
    /// via EBS snapshots. This can be done without having to create new volumes from EBS
    /// snapshots.
    /// 
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
        Task<GetSnapshotBlockResponse> GetSnapshotBlockAsync(GetSnapshotBlockRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListChangedBlocksResponse> ListChangedBlocksAsync(ListChangedBlocksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<ListSnapshotBlocksResponse> ListSnapshotBlocksAsync(ListSnapshotBlocksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTEventsData.Model;

namespace Amazon.IoTEventsData
{
    /// <summary>
    /// Interface for accessing IoTEventsData
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur.
    /// </summary>
    public partial interface IAmazonIoTEventsData : IAmazonService, IDisposable
    {
                
        #region  BatchPutMessage


        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateDetector


        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        Task<BatchUpdateDetectorResponse> BatchUpdateDetectorAsync(BatchUpdateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDetector


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        Task<DescribeDetectorResponse> DescribeDetectorAsync(DescribeDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectors


        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
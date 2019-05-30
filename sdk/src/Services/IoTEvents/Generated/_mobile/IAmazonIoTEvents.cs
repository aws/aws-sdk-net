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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTEvents.Model;

namespace Amazon.IoTEvents
{
    /// <summary>
    /// Interface for accessing IoTEvents
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur.
    /// </summary>
    public partial interface IAmazonIoTEvents : IAmazonService, IDisposable
    {
                
        #region  CreateDetectorModel


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        Task<CreateDetectorModelResponse> CreateDetectorModelAsync(CreateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInput


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        Task<CreateInputResponse> CreateInputAsync(CreateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDetectorModel


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        Task<DeleteDetectorModelResponse> DeleteDetectorModelAsync(DeleteDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInput


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        Task<DeleteInputResponse> DeleteInputAsync(DeleteInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDetectorModel


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        Task<DescribeDetectorModelResponse> DescribeDetectorModelAsync(DescribeDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInput


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        Task<DescribeInputResponse> DescribeInputAsync(DescribeInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoggingOptions


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectorModels


        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectorModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        Task<ListDetectorModelsResponse> ListDetectorModelsAsync(ListDetectorModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectorModelVersions


        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectorModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModelVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        Task<ListDetectorModelVersionsResponse> ListDetectorModelVersionsAsync(ListDetectorModelVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInputs


        /// <summary>
        /// Initiates the asynchronous execution of the ListInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        Task<ListInputsResponse> ListInputsAsync(ListInputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutLoggingOptions


        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDetectorModel


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        Task<UpdateDetectorModelResponse> UpdateDetectorModelAsync(UpdateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInput


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        Task<UpdateInputResponse> UpdateInputAsync(UpdateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
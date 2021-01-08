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
    /// operation, and triggers actions when such events occur. AWS IoT Events Data API commands
    /// enable you to send inputs to detectors, list detectors, and view or update a detector's
    /// status.
    /// </summary>
    public partial interface IAmazonIoTEventsData : IAmazonService, IDisposable
    {


        
        #region  BatchPutMessage


        /// <summary>
        /// Sends a set of messages to the AWS IoT Events system. Each message payload is transformed
        /// into the input you specify (<code>"inputName"</code>) and ingested into any detectors
        /// that monitor that input. If multiple messages are sent, the order in which the messages
        /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
        /// at a time and wait for a successful response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request);



        /// <summary>
        /// Sends a set of messages to the AWS IoT Events system. Each message payload is transformed
        /// into the input you specify (<code>"inputName"</code>) and ingested into any detectors
        /// that monitor that input. If multiple messages are sent, the order in which the messages
        /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
        /// at a time and wait for a successful response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateDetector


        /// <summary>
        /// Updates the state, variable values, and timer settings of one or more detectors (instances)
        /// of a specified detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        BatchUpdateDetectorResponse BatchUpdateDetector(BatchUpdateDetectorRequest request);



        /// <summary>
        /// Updates the state, variable values, and timer settings of one or more detectors (instances)
        /// of a specified detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        Task<BatchUpdateDetectorResponse> BatchUpdateDetectorAsync(BatchUpdateDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDetector


        /// <summary>
        /// Returns information about the specified detector (instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request);



        /// <summary>
        /// Returns information about the specified detector (instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        Task<DescribeDetectorResponse> DescribeDetectorAsync(DescribeDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDetectors


        /// <summary>
        /// Lists detectors (the instances of a detector model).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        ListDetectorsResponse ListDetectors(ListDetectorsRequest request);



        /// <summary>
        /// Lists detectors (the instances of a detector model).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occured.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
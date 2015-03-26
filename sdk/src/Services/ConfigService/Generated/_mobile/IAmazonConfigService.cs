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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ConfigService.Model;

namespace Amazon.ConfigService
{
    /// <summary>
    /// Interface for accessing ConfigService
    ///
    /// AWS Config 
    /// <para>
    /// AWS Config provides a way to keep track of the configurations of all the AWS resources
    /// associated with your AWS account. You can use AWS Config to get the current and historical
    /// configurations of each AWS resource and also to get information about the relationship
    /// between the resources. An AWS resource can be an Amazon Compute Cloud (Amazon EC2)
    /// instance, an Elastic Block Store (EBS) volume, an Elastic network Interface (ENI),
    /// or a security group. For a complete list of resources currently supported by AWS Config,
    /// see <a href="http://docs.aws.amazon.com/config/latest/developerguide/config-concepts.html">Supported
    /// AWS Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can access and manage AWS Config through the AWS Management Console, the AWS Command
    /// Line Interface (AWS CLI), the AWS Config API, or the AWS SDKs for AWS Config
    /// </para>
    ///  
    /// <para>
    /// This reference guide contains documentation for the AWS Config API and the AWS CLI
    /// commands that you can use to manage AWS Config.
    /// </para>
    ///  
    /// <para>
    /// The AWS Config API uses the Signature Version 4 protocol for signing requests. For
    /// more information about how to sign a request with this protocol, see <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// For detailed information about AWS Config features and their associated actions or
    /// commands, as well as how to work with AWS Management Console, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/WhatIsConfig.html">What
    /// Is AWS Config?</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonConfigService : IDisposable
    {
                
        #region  DeleteDeliveryChannel

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDeliveryChannelResponse> DeleteDeliveryChannelAsync(DeleteDeliveryChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeliverConfigSnapshot

        /// <summary>
        /// Initiates the asynchronous execution of the DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeliverConfigSnapshotResponse> DeliverConfigSnapshotAsync(DeliverConfigSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurationRecorders

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationRecordersResponse> DescribeConfigurationRecordersAsync(DescribeConfigurationRecordersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurationRecorderStatus

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationRecorderStatusResponse> DescribeConfigurationRecorderStatusAsync(DescribeConfigurationRecorderStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeliveryChannels

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(DescribeDeliveryChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDeliveryChannelStatus

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDeliveryChannelStatusResponse> DescribeDeliveryChannelStatusAsync(DescribeDeliveryChannelStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceConfigHistory

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetResourceConfigHistoryResponse> GetResourceConfigHistoryAsync(GetResourceConfigHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutConfigurationRecorder

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutConfigurationRecorderResponse> PutConfigurationRecorderAsync(PutConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDeliveryChannel

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDeliveryChannelResponse> PutDeliveryChannelAsync(PutDeliveryChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartConfigurationRecorder

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(StartConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopConfigurationRecorder

        /// <summary>
        /// Initiates the asynchronous execution of the StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopConfigurationRecorderResponse> StopConfigurationRecorderAsync(StopConfigurationRecorderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
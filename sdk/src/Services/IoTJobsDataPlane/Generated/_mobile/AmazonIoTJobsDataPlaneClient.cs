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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTJobsDataPlane.Model;
using Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations;
using Amazon.IoTJobsDataPlane.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTJobsDataPlane
{
    /// <summary>
    /// Implementation for accessing IoTJobsDataPlane
    ///
    /// AWS IoT Jobs is a service that allows you to define a set of jobs — remote operations
    /// that are sent to and executed on one or more devices connected to AWS IoT. For example,
    /// you can define a job that instructs a set of devices to download and install application
    /// or firmware updates, reboot, rotate certificates, or perform remote troubleshooting
    /// operations.
    /// 
    ///  
    /// <para>
    ///  To create a job, you make a job document which is a description of the remote operations
    /// to be performed, and you specify a list of targets that should perform the operations.
    /// The targets can be individual things, thing groups or both.
    /// </para>
    ///  
    /// <para>
    ///  AWS IoT Jobs sends a message to inform the targets that a job is available. The target
    /// starts the execution of the job by downloading the job document, performing the operations
    /// it specifies, and reporting its progress to AWS IoT. The Jobs service provides commands
    /// to track the progress of a job on a specific target and for all the targets of the
    /// job
    /// </para>
    /// </summary>
    public partial class AmazonIoTJobsDataPlaneClient : AmazonServiceClient, IAmazonIoTJobsDataPlane
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTJobsDataPlaneMetadata();
        

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


        #region  DescribeJobExecution

        internal virtual DescribeJobExecutionResponse DescribeJobExecution(DescribeJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeJobExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual Task<DescribeJobExecutionResponse> DescribeJobExecutionAsync(DescribeJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPendingJobExecutions

        internal virtual GetPendingJobExecutionsResponse GetPendingJobExecutions(GetPendingJobExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPendingJobExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingJobExecutionsResponseUnmarshaller.Instance;

            return Invoke<GetPendingJobExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPendingJobExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPendingJobExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/GetPendingJobExecutions">REST API Reference for GetPendingJobExecutions Operation</seealso>
        public virtual Task<GetPendingJobExecutionsResponse> GetPendingJobExecutionsAsync(GetPendingJobExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPendingJobExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingJobExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPendingJobExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartNextPendingJobExecution

        internal virtual StartNextPendingJobExecutionResponse StartNextPendingJobExecution(StartNextPendingJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNextPendingJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNextPendingJobExecutionResponseUnmarshaller.Instance;

            return Invoke<StartNextPendingJobExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartNextPendingJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNextPendingJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/StartNextPendingJobExecution">REST API Reference for StartNextPendingJobExecution Operation</seealso>
        public virtual Task<StartNextPendingJobExecutionResponse> StartNextPendingJobExecutionAsync(StartNextPendingJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNextPendingJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNextPendingJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartNextPendingJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJobExecution

        internal virtual UpdateJobExecutionResponse UpdateJobExecution(UpdateJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdateJobExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/UpdateJobExecution">REST API Reference for UpdateJobExecution Operation</seealso>
        public virtual Task<UpdateJobExecutionResponse> UpdateJobExecutionAsync(UpdateJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
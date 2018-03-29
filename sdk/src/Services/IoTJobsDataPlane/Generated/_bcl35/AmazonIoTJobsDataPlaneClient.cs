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
using System.Collections.Generic;

using Amazon.IoTJobsDataPlane.Model;
using Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations;
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        /// <summary>
        /// Gets details of a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeJobExecution service method, as returned by IoTJobsDataPlane.</returns>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.InvalidRequestException">
        /// The contents of the request were invalid. For example, this code is returned when
        /// an UpdateJobExecution request contains invalid status details. The message contains
        /// details about the error.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.TerminalStateException">
        /// The job is in a terminal state.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual DescribeJobExecutionResponse DescribeJobExecution(DescribeJobExecutionRequest request)
        {
            var marshaller = DescribeJobExecutionRequestMarshaller.Instance;
            var unmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeJobExecutionRequest,DescribeJobExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution operation on AmazonIoTJobsDataPlaneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobExecution(DescribeJobExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeJobExecutionRequestMarshaller.Instance;
            var unmarshaller = DescribeJobExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeJobExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobExecution.</param>
        /// 
        /// <returns>Returns a  DescribeJobExecutionResult from IoTJobsDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        public virtual DescribeJobExecutionResponse EndDescribeJobExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPendingJobExecutions

        /// <summary>
        /// Gets the list of all jobs for a thing that are not in a terminal status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPendingJobExecutions service method.</param>
        /// 
        /// <returns>The response from the GetPendingJobExecutions service method, as returned by IoTJobsDataPlane.</returns>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.InvalidRequestException">
        /// The contents of the request were invalid. For example, this code is returned when
        /// an UpdateJobExecution request contains invalid status details. The message contains
        /// details about the error.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/GetPendingJobExecutions">REST API Reference for GetPendingJobExecutions Operation</seealso>
        public virtual GetPendingJobExecutionsResponse GetPendingJobExecutions(GetPendingJobExecutionsRequest request)
        {
            var marshaller = GetPendingJobExecutionsRequestMarshaller.Instance;
            var unmarshaller = GetPendingJobExecutionsResponseUnmarshaller.Instance;

            return Invoke<GetPendingJobExecutionsRequest,GetPendingJobExecutionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPendingJobExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPendingJobExecutions operation on AmazonIoTJobsDataPlaneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPendingJobExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/GetPendingJobExecutions">REST API Reference for GetPendingJobExecutions Operation</seealso>
        public virtual IAsyncResult BeginGetPendingJobExecutions(GetPendingJobExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetPendingJobExecutionsRequestMarshaller.Instance;
            var unmarshaller = GetPendingJobExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetPendingJobExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPendingJobExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPendingJobExecutions.</param>
        /// 
        /// <returns>Returns a  GetPendingJobExecutionsResult from IoTJobsDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/GetPendingJobExecutions">REST API Reference for GetPendingJobExecutions Operation</seealso>
        public virtual GetPendingJobExecutionsResponse EndGetPendingJobExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPendingJobExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartNextPendingJobExecution

        /// <summary>
        /// Gets and starts the next pending (status IN_PROGRESS or QUEUED) job execution for
        /// a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNextPendingJobExecution service method.</param>
        /// 
        /// <returns>The response from the StartNextPendingJobExecution service method, as returned by IoTJobsDataPlane.</returns>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.InvalidRequestException">
        /// The contents of the request were invalid. For example, this code is returned when
        /// an UpdateJobExecution request contains invalid status details. The message contains
        /// details about the error.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/StartNextPendingJobExecution">REST API Reference for StartNextPendingJobExecution Operation</seealso>
        public virtual StartNextPendingJobExecutionResponse StartNextPendingJobExecution(StartNextPendingJobExecutionRequest request)
        {
            var marshaller = StartNextPendingJobExecutionRequestMarshaller.Instance;
            var unmarshaller = StartNextPendingJobExecutionResponseUnmarshaller.Instance;

            return Invoke<StartNextPendingJobExecutionRequest,StartNextPendingJobExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartNextPendingJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNextPendingJobExecution operation on AmazonIoTJobsDataPlaneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNextPendingJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/StartNextPendingJobExecution">REST API Reference for StartNextPendingJobExecution Operation</seealso>
        public virtual IAsyncResult BeginStartNextPendingJobExecution(StartNextPendingJobExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartNextPendingJobExecutionRequestMarshaller.Instance;
            var unmarshaller = StartNextPendingJobExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<StartNextPendingJobExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartNextPendingJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNextPendingJobExecution.</param>
        /// 
        /// <returns>Returns a  StartNextPendingJobExecutionResult from IoTJobsDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/StartNextPendingJobExecution">REST API Reference for StartNextPendingJobExecution Operation</seealso>
        public virtual StartNextPendingJobExecutionResponse EndStartNextPendingJobExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartNextPendingJobExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJobExecution

        /// <summary>
        /// Updates the status of a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobExecution service method.</param>
        /// 
        /// <returns>The response from the UpdateJobExecution service method, as returned by IoTJobsDataPlane.</returns>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.InvalidRequestException">
        /// The contents of the request were invalid. For example, this code is returned when
        /// an UpdateJobExecution request contains invalid status details. The message contains
        /// details about the error.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.InvalidStateTransitionException">
        /// An update attempted to change the job execution to a state that is invalid because
        /// of the job execution's current state (for example, an attempt to change a request
        /// in state SUCCESS to state IN_PROGRESS). In this case, the body of the error message
        /// also contains the executionState field.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTJobsDataPlane.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/UpdateJobExecution">REST API Reference for UpdateJobExecution Operation</seealso>
        public virtual UpdateJobExecutionResponse UpdateJobExecution(UpdateJobExecutionRequest request)
        {
            var marshaller = UpdateJobExecutionRequestMarshaller.Instance;
            var unmarshaller = UpdateJobExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdateJobExecutionRequest,UpdateJobExecutionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobExecution operation on AmazonIoTJobsDataPlaneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/UpdateJobExecution">REST API Reference for UpdateJobExecution Operation</seealso>
        public virtual IAsyncResult BeginUpdateJobExecution(UpdateJobExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateJobExecutionRequestMarshaller.Instance;
            var unmarshaller = UpdateJobExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateJobExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobExecution.</param>
        /// 
        /// <returns>Returns a  UpdateJobExecutionResult from IoTJobsDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-jobs-data-2017-09-29/UpdateJobExecution">REST API Reference for UpdateJobExecution Operation</seealso>
        public virtual UpdateJobExecutionResponse EndUpdateJobExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobExecutionResponse>(asyncResult);
        }

        #endregion
        
    }
}
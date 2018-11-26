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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RoboMaker.Model;

namespace Amazon.RoboMaker
{
    /// <summary>
    /// Interface for accessing RoboMaker
    ///
    /// his section provides documentation for the AWS RoboMaker API operations.
    /// </summary>
    public partial interface IAmazonRoboMaker : IAmazonService, IDisposable
    {

        
        #region  BatchDescribeSimulationJob


        /// <summary>
        /// Describes one or more simulation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        BatchDescribeSimulationJobResponse BatchDescribeSimulationJob(BatchDescribeSimulationJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        Task<BatchDescribeSimulationJobResponse> BatchDescribeSimulationJobAsync(BatchDescribeSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelSimulationJob


        /// <summary>
        /// Cancels the specified simulation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob service method.</param>
        /// 
        /// <returns>The response from the CancelSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        CancelSimulationJobResponse CancelSimulationJob(CancelSimulationJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        Task<CancelSimulationJobResponse> CancelSimulationJobAsync(CancelSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeploymentJob


        /// <summary>
        /// Creates a deployment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        CreateDeploymentJobResponse CreateDeploymentJob(CreateDeploymentJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        Task<CreateDeploymentJobResponse> CreateDeploymentJobAsync(CreateDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet, a logical group of robots running the same robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobot


        /// <summary>
        /// Creates a robot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot service method.</param>
        /// 
        /// <returns>The response from the CreateRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        CreateRobotResponse CreateRobot(CreateRobotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        Task<CreateRobotResponse> CreateRobotAsync(CreateRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobotApplication


        /// <summary>
        /// Creates a robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication service method.</param>
        /// 
        /// <returns>The response from the CreateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        CreateRobotApplicationResponse CreateRobotApplication(CreateRobotApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        Task<CreateRobotApplicationResponse> CreateRobotApplicationAsync(CreateRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobotApplicationVersion


        /// <summary>
        /// Creates a version of a robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateRobotApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        CreateRobotApplicationVersionResponse CreateRobotApplicationVersion(CreateRobotApplicationVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRobotApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        Task<CreateRobotApplicationVersionResponse> CreateRobotApplicationVersionAsync(CreateRobotApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationApplication


        /// <summary>
        /// Creates a simulation application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        CreateSimulationApplicationResponse CreateSimulationApplication(CreateSimulationApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        Task<CreateSimulationApplicationResponse> CreateSimulationApplicationAsync(CreateSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationApplicationVersion


        /// <summary>
        /// Creates a simulation application with a specific revision id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        CreateSimulationApplicationVersionResponse CreateSimulationApplicationVersion(CreateSimulationApplicationVersionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSimulationApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        Task<CreateSimulationApplicationVersionResponse> CreateSimulationApplicationVersionAsync(CreateSimulationApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationJob


        /// <summary>
        /// Creates a simulation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        CreateSimulationJobResponse CreateSimulationJob(CreateSimulationJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        Task<CreateSimulationJobResponse> CreateSimulationJobAsync(CreateSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRobot


        /// <summary>
        /// Deletes a robot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot service method.</param>
        /// 
        /// <returns>The response from the DeleteRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        DeleteRobotResponse DeleteRobot(DeleteRobotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        Task<DeleteRobotResponse> DeleteRobotAsync(DeleteRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRobotApplication


        /// <summary>
        /// Deletes a robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        DeleteRobotApplicationResponse DeleteRobotApplication(DeleteRobotApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        Task<DeleteRobotApplicationResponse> DeleteRobotApplicationAsync(DeleteRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSimulationApplication


        /// <summary>
        /// Deletes a simulation application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        DeleteSimulationApplicationResponse DeleteSimulationApplication(DeleteSimulationApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        Task<DeleteSimulationApplicationResponse> DeleteSimulationApplicationAsync(DeleteSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterRobot


        /// <summary>
        /// Deregisters a robot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot service method.</param>
        /// 
        /// <returns>The response from the DeregisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        DeregisterRobotResponse DeregisterRobot(DeregisterRobotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        Task<DeregisterRobotResponse> DeregisterRobotAsync(DeregisterRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeploymentJob


        /// <summary>
        /// Describes a deployment job. [Does it work regardless of deployment status, e.g. Failed?]
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        DescribeDeploymentJobResponse DescribeDeploymentJob(DescribeDeploymentJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        Task<DescribeDeploymentJobResponse> DescribeDeploymentJobAsync(DescribeDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleet


        /// <summary>
        /// Describes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet service method.</param>
        /// 
        /// <returns>The response from the DescribeFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        DescribeFleetResponse DescribeFleet(DescribeFleetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        Task<DescribeFleetResponse> DescribeFleetAsync(DescribeFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRobot


        /// <summary>
        /// Describes a robot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot service method.</param>
        /// 
        /// <returns>The response from the DescribeRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        DescribeRobotResponse DescribeRobot(DescribeRobotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        Task<DescribeRobotResponse> DescribeRobotAsync(DescribeRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRobotApplication


        /// <summary>
        /// Describes a robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        DescribeRobotApplicationResponse DescribeRobotApplication(DescribeRobotApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        Task<DescribeRobotApplicationResponse> DescribeRobotApplicationAsync(DescribeRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulationApplication


        /// <summary>
        /// Describes a simulation application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        DescribeSimulationApplicationResponse DescribeSimulationApplication(DescribeSimulationApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        Task<DescribeSimulationApplicationResponse> DescribeSimulationApplicationAsync(DescribeSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulationJob


        /// <summary>
        /// Describes a simulation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        DescribeSimulationJobResponse DescribeSimulationJob(DescribeSimulationJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        Task<DescribeSimulationJobResponse> DescribeSimulationJobAsync(DescribeSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeploymentJobs


        /// <summary>
        /// Returns a list of deployment jobs for a fleet. You can optionally provide filters
        /// to retrieve specific deployment jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        ListDeploymentJobsResponse ListDeploymentJobs(ListDeploymentJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        Task<ListDeploymentJobsResponse> ListDeploymentJobsAsync(ListDeploymentJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Returns a list of fleets. You can optionally provide filters to retrieve specific
        /// fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRobotApplications


        /// <summary>
        /// Returns a list of robot application. You can optionally provide filters to retrieve
        /// specific robot applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications service method.</param>
        /// 
        /// <returns>The response from the ListRobotApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        ListRobotApplicationsResponse ListRobotApplications(ListRobotApplicationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListRobotApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        Task<ListRobotApplicationsResponse> ListRobotApplicationsAsync(ListRobotApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRobots


        /// <summary>
        /// Returns a list of robots. You can optionally provide filters to retrieve specific
        /// robots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobots service method.</param>
        /// 
        /// <returns>The response from the ListRobots service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        ListRobotsResponse ListRobots(ListRobotsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListRobots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRobots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        Task<ListRobotsResponse> ListRobotsAsync(ListRobotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulationApplications


        /// <summary>
        /// Returns a list of simulation applications. You can optionally provide filters to retrieve
        /// specific simulation applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications service method.</param>
        /// 
        /// <returns>The response from the ListSimulationApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        ListSimulationApplicationsResponse ListSimulationApplications(ListSimulationApplicationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListSimulationApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        Task<ListSimulationApplicationsResponse> ListSimulationApplicationsAsync(ListSimulationApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulationJobs


        /// <summary>
        /// Returns a list of simulation jobs. You can optionally provide filters to retrieve
        /// specific simulation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs service method.</param>
        /// 
        /// <returns>The response from the ListSimulationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        ListSimulationJobsResponse ListSimulationJobs(ListSimulationJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListSimulationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        Task<ListSimulationJobsResponse> ListSimulationJobsAsync(ListSimulationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterRobot


        /// <summary>
        /// Registers a robot with a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot service method.</param>
        /// 
        /// <returns>The response from the RegisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        RegisterRobotResponse RegisterRobot(RegisterRobotRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        Task<RegisterRobotResponse> RegisterRobotAsync(RegisterRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestartSimulationJob


        /// <summary>
        /// Restarts a running simulation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob service method.</param>
        /// 
        /// <returns>The response from the RestartSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        RestartSimulationJobResponse RestartSimulationJob(RestartSimulationJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RestartSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        Task<RestartSimulationJobResponse> RestartSimulationJobAsync(RestartSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SyncDeploymentJob


        /// <summary>
        /// Syncrhonizes robots in a fleet to the latest deployment. This is helpful if robots
        /// were added after a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the SyncDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        SyncDeploymentJobResponse SyncDeploymentJob(SyncDeploymentJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SyncDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        Task<SyncDeploymentJobResponse> SyncDeploymentJobAsync(SyncDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRobotApplication


        /// <summary>
        /// Updates a robot application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        UpdateRobotApplicationResponse UpdateRobotApplication(UpdateRobotApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        Task<UpdateRobotApplicationResponse> UpdateRobotApplicationAsync(UpdateRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSimulationApplication


        /// <summary>
        /// Updates a simulation application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        UpdateSimulationApplicationResponse UpdateSimulationApplication(UpdateSimulationApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        Task<UpdateSimulationApplicationResponse> UpdateSimulationApplicationAsync(UpdateSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
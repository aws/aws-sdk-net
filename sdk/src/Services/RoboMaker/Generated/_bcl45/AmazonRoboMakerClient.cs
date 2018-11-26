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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.RoboMaker.Model;
using Amazon.RoboMaker.Model.Internal.MarshallTransformations;
using Amazon.RoboMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RoboMaker
{
    /// <summary>
    /// Implementation for accessing RoboMaker
    ///
    /// his section provides documentation for the AWS RoboMaker API operations.
    /// </summary>
    public partial class AmazonRoboMakerClient : AmazonServiceClient, IAmazonRoboMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoboMakerMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        public AmazonRoboMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoboMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        public AmazonRoboMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoboMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(AmazonRoboMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoboMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoboMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials and an
        /// AmazonRoboMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(AWSCredentials credentials, AmazonRoboMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoboMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoboMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoboMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoboMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoboMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoboMakerConfig clientConfig)
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
        public virtual BatchDescribeSimulationJobResponse BatchDescribeSimulationJob(BatchDescribeSimulationJobRequest request)
        {
            var marshaller = BatchDescribeSimulationJobRequestMarshaller.Instance;
            var unmarshaller = BatchDescribeSimulationJobResponseUnmarshaller.Instance;

            return Invoke<BatchDescribeSimulationJobRequest,BatchDescribeSimulationJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<BatchDescribeSimulationJobResponse> BatchDescribeSimulationJobAsync(BatchDescribeSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchDescribeSimulationJobRequestMarshaller.Instance;
            var unmarshaller = BatchDescribeSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDescribeSimulationJobRequest,BatchDescribeSimulationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CancelSimulationJobResponse CancelSimulationJob(CancelSimulationJobRequest request)
        {
            var marshaller = CancelSimulationJobRequestMarshaller.Instance;
            var unmarshaller = CancelSimulationJobResponseUnmarshaller.Instance;

            return Invoke<CancelSimulationJobRequest,CancelSimulationJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CancelSimulationJobResponse> CancelSimulationJobAsync(CancelSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelSimulationJobRequestMarshaller.Instance;
            var unmarshaller = CancelSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSimulationJobRequest,CancelSimulationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateDeploymentJobResponse CreateDeploymentJob(CreateDeploymentJobRequest request)
        {
            var marshaller = CreateDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentJobRequest,CreateDeploymentJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateDeploymentJobResponse> CreateDeploymentJobAsync(CreateDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentJobRequest,CreateDeploymentJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetRequest,CreateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateRobotResponse CreateRobot(CreateRobotRequest request)
        {
            var marshaller = CreateRobotRequestMarshaller.Instance;
            var unmarshaller = CreateRobotResponseUnmarshaller.Instance;

            return Invoke<CreateRobotRequest,CreateRobotResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateRobotResponse> CreateRobotAsync(CreateRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRobotRequestMarshaller.Instance;
            var unmarshaller = CreateRobotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotRequest,CreateRobotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateRobotApplicationResponse CreateRobotApplication(CreateRobotApplicationRequest request)
        {
            var marshaller = CreateRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateRobotApplicationRequest,CreateRobotApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateRobotApplicationResponse> CreateRobotApplicationAsync(CreateRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotApplicationRequest,CreateRobotApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateRobotApplicationVersionResponse CreateRobotApplicationVersion(CreateRobotApplicationVersionRequest request)
        {
            var marshaller = CreateRobotApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateRobotApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateRobotApplicationVersionRequest,CreateRobotApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateRobotApplicationVersionResponse> CreateRobotApplicationVersionAsync(CreateRobotApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRobotApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateRobotApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotApplicationVersionRequest,CreateRobotApplicationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateSimulationApplicationResponse CreateSimulationApplication(CreateSimulationApplicationRequest request)
        {
            var marshaller = CreateSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationApplicationRequest,CreateSimulationApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateSimulationApplicationResponse> CreateSimulationApplicationAsync(CreateSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationApplicationRequest,CreateSimulationApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateSimulationApplicationVersionResponse CreateSimulationApplicationVersion(CreateSimulationApplicationVersionRequest request)
        {
            var marshaller = CreateSimulationApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationApplicationVersionRequest,CreateSimulationApplicationVersionResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateSimulationApplicationVersionResponse> CreateSimulationApplicationVersionAsync(CreateSimulationApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSimulationApplicationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationApplicationVersionRequest,CreateSimulationApplicationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual CreateSimulationJobResponse CreateSimulationJob(CreateSimulationJobRequest request)
        {
            var marshaller = CreateSimulationJobRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationJobResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationJobRequest,CreateSimulationJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateSimulationJobResponse> CreateSimulationJobAsync(CreateSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSimulationJobRequestMarshaller.Instance;
            var unmarshaller = CreateSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationJobRequest,CreateSimulationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFleetRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetRequest,DeleteFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteRobotResponse DeleteRobot(DeleteRobotRequest request)
        {
            var marshaller = DeleteRobotRequestMarshaller.Instance;
            var unmarshaller = DeleteRobotResponseUnmarshaller.Instance;

            return Invoke<DeleteRobotRequest,DeleteRobotResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteRobotResponse> DeleteRobotAsync(DeleteRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRobotRequestMarshaller.Instance;
            var unmarshaller = DeleteRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRobotRequest,DeleteRobotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteRobotApplicationResponse DeleteRobotApplication(DeleteRobotApplicationRequest request)
        {
            var marshaller = DeleteRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteRobotApplicationRequest,DeleteRobotApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteRobotApplicationResponse> DeleteRobotApplicationAsync(DeleteRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRobotApplicationRequest,DeleteRobotApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeleteSimulationApplicationResponse DeleteSimulationApplication(DeleteSimulationApplicationRequest request)
        {
            var marshaller = DeleteSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteSimulationApplicationRequest,DeleteSimulationApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteSimulationApplicationResponse> DeleteSimulationApplicationAsync(DeleteSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSimulationApplicationRequest,DeleteSimulationApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DeregisterRobotResponse DeregisterRobot(DeregisterRobotRequest request)
        {
            var marshaller = DeregisterRobotRequestMarshaller.Instance;
            var unmarshaller = DeregisterRobotResponseUnmarshaller.Instance;

            return Invoke<DeregisterRobotRequest,DeregisterRobotResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeregisterRobotResponse> DeregisterRobotAsync(DeregisterRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterRobotRequestMarshaller.Instance;
            var unmarshaller = DeregisterRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterRobotRequest,DeregisterRobotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeDeploymentJobResponse DescribeDeploymentJob(DescribeDeploymentJobRequest request)
        {
            var marshaller = DescribeDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDeploymentJobRequest,DescribeDeploymentJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeDeploymentJobResponse> DescribeDeploymentJobAsync(DescribeDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeploymentJobRequest,DescribeDeploymentJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeFleetResponse DescribeFleet(DescribeFleetRequest request)
        {
            var marshaller = DescribeFleetRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetRequest,DescribeFleetResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeFleetResponse> DescribeFleetAsync(DescribeFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFleetRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetRequest,DescribeFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeRobotResponse DescribeRobot(DescribeRobotRequest request)
        {
            var marshaller = DescribeRobotRequestMarshaller.Instance;
            var unmarshaller = DescribeRobotResponseUnmarshaller.Instance;

            return Invoke<DescribeRobotRequest,DescribeRobotResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeRobotResponse> DescribeRobotAsync(DescribeRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRobotRequestMarshaller.Instance;
            var unmarshaller = DescribeRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRobotRequest,DescribeRobotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeRobotApplicationResponse DescribeRobotApplication(DescribeRobotApplicationRequest request)
        {
            var marshaller = DescribeRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeRobotApplicationRequest,DescribeRobotApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeRobotApplicationResponse> DescribeRobotApplicationAsync(DescribeRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRobotApplicationRequest,DescribeRobotApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeSimulationApplicationResponse DescribeSimulationApplication(DescribeSimulationApplicationRequest request)
        {
            var marshaller = DescribeSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationApplicationRequest,DescribeSimulationApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeSimulationApplicationResponse> DescribeSimulationApplicationAsync(DescribeSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSimulationApplicationRequest,DescribeSimulationApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual DescribeSimulationJobResponse DescribeSimulationJob(DescribeSimulationJobRequest request)
        {
            var marshaller = DescribeSimulationJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSimulationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationJobRequest,DescribeSimulationJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeSimulationJobResponse> DescribeSimulationJobAsync(DescribeSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSimulationJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSimulationJobRequest,DescribeSimulationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListDeploymentJobsResponse ListDeploymentJobs(ListDeploymentJobsRequest request)
        {
            var marshaller = ListDeploymentJobsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentJobsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentJobsRequest,ListDeploymentJobsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListDeploymentJobsResponse> ListDeploymentJobsAsync(ListDeploymentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentJobsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentJobsRequest,ListDeploymentJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var marshaller = ListFleetsRequestMarshaller.Instance;
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsRequest,ListFleetsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListFleetsRequestMarshaller.Instance;
            var unmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsRequest,ListFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListRobotApplicationsResponse ListRobotApplications(ListRobotApplicationsRequest request)
        {
            var marshaller = ListRobotApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListRobotApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListRobotApplicationsRequest,ListRobotApplicationsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListRobotApplicationsResponse> ListRobotApplicationsAsync(ListRobotApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRobotApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListRobotApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRobotApplicationsRequest,ListRobotApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListRobotsResponse ListRobots(ListRobotsRequest request)
        {
            var marshaller = ListRobotsRequestMarshaller.Instance;
            var unmarshaller = ListRobotsResponseUnmarshaller.Instance;

            return Invoke<ListRobotsRequest,ListRobotsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListRobotsResponse> ListRobotsAsync(ListRobotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRobotsRequestMarshaller.Instance;
            var unmarshaller = ListRobotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRobotsRequest,ListRobotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListSimulationApplicationsResponse ListSimulationApplications(ListSimulationApplicationsRequest request)
        {
            var marshaller = ListSimulationApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListSimulationApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationApplicationsRequest,ListSimulationApplicationsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListSimulationApplicationsResponse> ListSimulationApplicationsAsync(ListSimulationApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSimulationApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListSimulationApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSimulationApplicationsRequest,ListSimulationApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual ListSimulationJobsResponse ListSimulationJobs(ListSimulationJobsRequest request)
        {
            var marshaller = ListSimulationJobsRequestMarshaller.Instance;
            var unmarshaller = ListSimulationJobsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationJobsRequest,ListSimulationJobsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListSimulationJobsResponse> ListSimulationJobsAsync(ListSimulationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListSimulationJobsRequestMarshaller.Instance;
            var unmarshaller = ListSimulationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSimulationJobsRequest,ListSimulationJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual RegisterRobotResponse RegisterRobot(RegisterRobotRequest request)
        {
            var marshaller = RegisterRobotRequestMarshaller.Instance;
            var unmarshaller = RegisterRobotResponseUnmarshaller.Instance;

            return Invoke<RegisterRobotRequest,RegisterRobotResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<RegisterRobotResponse> RegisterRobotAsync(RegisterRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterRobotRequestMarshaller.Instance;
            var unmarshaller = RegisterRobotResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterRobotRequest,RegisterRobotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual RestartSimulationJobResponse RestartSimulationJob(RestartSimulationJobRequest request)
        {
            var marshaller = RestartSimulationJobRequestMarshaller.Instance;
            var unmarshaller = RestartSimulationJobResponseUnmarshaller.Instance;

            return Invoke<RestartSimulationJobRequest,RestartSimulationJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<RestartSimulationJobResponse> RestartSimulationJobAsync(RestartSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestartSimulationJobRequestMarshaller.Instance;
            var unmarshaller = RestartSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<RestartSimulationJobRequest,RestartSimulationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual SyncDeploymentJobResponse SyncDeploymentJob(SyncDeploymentJobRequest request)
        {
            var marshaller = SyncDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = SyncDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<SyncDeploymentJobRequest,SyncDeploymentJobResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<SyncDeploymentJobResponse> SyncDeploymentJobAsync(SyncDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SyncDeploymentJobRequestMarshaller.Instance;
            var unmarshaller = SyncDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<SyncDeploymentJobRequest,SyncDeploymentJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual UpdateRobotApplicationResponse UpdateRobotApplication(UpdateRobotApplicationRequest request)
        {
            var marshaller = UpdateRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateRobotApplicationRequest,UpdateRobotApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UpdateRobotApplicationResponse> UpdateRobotApplicationAsync(UpdateRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRobotApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRobotApplicationRequest,UpdateRobotApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual UpdateSimulationApplicationResponse UpdateSimulationApplication(UpdateSimulationApplicationRequest request)
        {
            var marshaller = UpdateSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateSimulationApplicationRequest,UpdateSimulationApplicationResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UpdateSimulationApplicationResponse> UpdateSimulationApplicationAsync(UpdateSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSimulationApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSimulationApplicationRequest,UpdateSimulationApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.StepFunctions.Model;
using Amazon.StepFunctions.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.StepFunctions
{
    /// <summary>
    /// Implementation for accessing StepFunctions
    ///
    /// AWS Step Functions 
    /// <para>
    /// AWS Step Functions is a web service that enables you to coordinate the components
    /// of distributed applications and microservices using visual workflows. You build applications
    /// from individual components that each perform a discrete function, or <i>task</i>,
    /// allowing you to scale and change applications quickly. Step Functions provides a graphical
    /// console to visualize the components of your application as a series of steps. It automatically
    /// triggers and tracks each step, and retries when there are errors, so your application
    /// executes in order and as expected, every time. Step Functions logs the state of each
    /// step, so when things do go wrong, you can diagnose and debug problems quickly.
    /// </para>
    ///  
    /// <para>
    /// Step Functions manages the operations and underlying infrastructure for you to ensure
    /// your application is available at any scale. You can run tasks on the AWS cloud, on
    /// your own servers, or an any system that has access to AWS. Step Functions can be accessed
    /// and used with the Step Functions console, the AWS SDKs (included with your Beta release
    /// invitation email), or an HTTP API (the subject of this document).
    /// </para>
    /// </summary>
    public partial class AmazonStepFunctionsClient : AmazonServiceClient, IAmazonStepFunctions
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonStepFunctionsClient with the credentials loaded from the application's
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
        public AmazonStepFunctionsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStepFunctionsConfig()) { }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with the credentials loaded from the application's
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
        public AmazonStepFunctionsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonStepFunctionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonStepFunctionsClient Configuration Object</param>
        public AmazonStepFunctionsClient(AmazonStepFunctionsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonStepFunctionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonStepFunctionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStepFunctionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonStepFunctionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Credentials and an
        /// AmazonStepFunctionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonStepFunctionsClient Configuration Object</param>
        public AmazonStepFunctionsClient(AWSCredentials credentials, AmazonStepFunctionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStepFunctionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonStepFunctionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStepFunctionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonStepFunctionsClient Configuration Object</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonStepFunctionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStepFunctionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonStepFunctionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonStepFunctionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonStepFunctionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonStepFunctionsClient Configuration Object</param>
        public AmazonStepFunctionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonStepFunctionsConfig clientConfig)
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

        
        #region  CreateActivity

        internal virtual CreateActivityResponse CreateActivity(CreateActivityRequest request)
        {
            var marshaller = new CreateActivityRequestMarshaller();
            var unmarshaller = CreateActivityResponseUnmarshaller.Instance;

            return Invoke<CreateActivityRequest,CreateActivityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        public virtual Task<CreateActivityResponse> CreateActivityAsync(CreateActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateActivityRequestMarshaller();
            var unmarshaller = CreateActivityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateActivityRequest,CreateActivityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStateMachine

        internal virtual CreateStateMachineResponse CreateStateMachine(CreateStateMachineRequest request)
        {
            var marshaller = new CreateStateMachineRequestMarshaller();
            var unmarshaller = CreateStateMachineResponseUnmarshaller.Instance;

            return Invoke<CreateStateMachineRequest,CreateStateMachineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        public virtual Task<CreateStateMachineResponse> CreateStateMachineAsync(CreateStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStateMachineRequestMarshaller();
            var unmarshaller = CreateStateMachineResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStateMachineRequest,CreateStateMachineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteActivity

        internal virtual DeleteActivityResponse DeleteActivity(DeleteActivityRequest request)
        {
            var marshaller = new DeleteActivityRequestMarshaller();
            var unmarshaller = DeleteActivityResponseUnmarshaller.Instance;

            return Invoke<DeleteActivityRequest,DeleteActivityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        public virtual Task<DeleteActivityResponse> DeleteActivityAsync(DeleteActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteActivityRequestMarshaller();
            var unmarshaller = DeleteActivityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteActivityRequest,DeleteActivityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStateMachine

        internal virtual DeleteStateMachineResponse DeleteStateMachine(DeleteStateMachineRequest request)
        {
            var marshaller = new DeleteStateMachineRequestMarshaller();
            var unmarshaller = DeleteStateMachineResponseUnmarshaller.Instance;

            return Invoke<DeleteStateMachineRequest,DeleteStateMachineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        public virtual Task<DeleteStateMachineResponse> DeleteStateMachineAsync(DeleteStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStateMachineRequestMarshaller();
            var unmarshaller = DeleteStateMachineResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStateMachineRequest,DeleteStateMachineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivity

        internal virtual DescribeActivityResponse DescribeActivity(DescribeActivityRequest request)
        {
            var marshaller = new DescribeActivityRequestMarshaller();
            var unmarshaller = DescribeActivityResponseUnmarshaller.Instance;

            return Invoke<DescribeActivityRequest,DescribeActivityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        public virtual Task<DescribeActivityResponse> DescribeActivityAsync(DescribeActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeActivityRequestMarshaller();
            var unmarshaller = DescribeActivityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivityRequest,DescribeActivityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExecution

        internal virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var marshaller = new DescribeExecutionRequestMarshaller();
            var unmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionRequest,DescribeExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExecutionRequestMarshaller();
            var unmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExecutionRequest,DescribeExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStateMachine

        internal virtual DescribeStateMachineResponse DescribeStateMachine(DescribeStateMachineRequest request)
        {
            var marshaller = new DescribeStateMachineRequestMarshaller();
            var unmarshaller = DescribeStateMachineResponseUnmarshaller.Instance;

            return Invoke<DescribeStateMachineRequest,DescribeStateMachineResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        public virtual Task<DescribeStateMachineResponse> DescribeStateMachineAsync(DescribeStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStateMachineRequestMarshaller();
            var unmarshaller = DescribeStateMachineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStateMachineRequest,DescribeStateMachineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetActivityTask

        internal virtual GetActivityTaskResponse GetActivityTask(GetActivityTaskRequest request)
        {
            var marshaller = new GetActivityTaskRequestMarshaller();
            var unmarshaller = GetActivityTaskResponseUnmarshaller.Instance;

            return Invoke<GetActivityTaskRequest,GetActivityTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        public virtual Task<GetActivityTaskResponse> GetActivityTaskAsync(GetActivityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetActivityTaskRequestMarshaller();
            var unmarshaller = GetActivityTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetActivityTaskRequest,GetActivityTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExecutionHistory

        internal virtual GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request)
        {
            var marshaller = new GetExecutionHistoryRequestMarshaller();
            var unmarshaller = GetExecutionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetExecutionHistoryRequest,GetExecutionHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        public virtual Task<GetExecutionHistoryResponse> GetExecutionHistoryAsync(GetExecutionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetExecutionHistoryRequestMarshaller();
            var unmarshaller = GetExecutionHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetExecutionHistoryRequest,GetExecutionHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActivities

        internal virtual ListActivitiesResponse ListActivities(ListActivitiesRequest request)
        {
            var marshaller = new ListActivitiesRequestMarshaller();
            var unmarshaller = ListActivitiesResponseUnmarshaller.Instance;

            return Invoke<ListActivitiesRequest,ListActivitiesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        public virtual Task<ListActivitiesResponse> ListActivitiesAsync(ListActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListActivitiesRequestMarshaller();
            var unmarshaller = ListActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActivitiesRequest,ListActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListExecutions

        internal virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var marshaller = new ListExecutionsRequestMarshaller();
            var unmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsRequest,ListExecutionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListExecutionsRequestMarshaller();
            var unmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExecutionsRequest,ListExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStateMachines

        internal virtual ListStateMachinesResponse ListStateMachines(ListStateMachinesRequest request)
        {
            var marshaller = new ListStateMachinesRequestMarshaller();
            var unmarshaller = ListStateMachinesResponseUnmarshaller.Instance;

            return Invoke<ListStateMachinesRequest,ListStateMachinesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        public virtual Task<ListStateMachinesResponse> ListStateMachinesAsync(ListStateMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStateMachinesRequestMarshaller();
            var unmarshaller = ListStateMachinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStateMachinesRequest,ListStateMachinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendTaskFailure

        internal virtual SendTaskFailureResponse SendTaskFailure(SendTaskFailureRequest request)
        {
            var marshaller = new SendTaskFailureRequestMarshaller();
            var unmarshaller = SendTaskFailureResponseUnmarshaller.Instance;

            return Invoke<SendTaskFailureRequest,SendTaskFailureResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        public virtual Task<SendTaskFailureResponse> SendTaskFailureAsync(SendTaskFailureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendTaskFailureRequestMarshaller();
            var unmarshaller = SendTaskFailureResponseUnmarshaller.Instance;

            return InvokeAsync<SendTaskFailureRequest,SendTaskFailureResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendTaskHeartbeat

        internal virtual SendTaskHeartbeatResponse SendTaskHeartbeat(SendTaskHeartbeatRequest request)
        {
            var marshaller = new SendTaskHeartbeatRequestMarshaller();
            var unmarshaller = SendTaskHeartbeatResponseUnmarshaller.Instance;

            return Invoke<SendTaskHeartbeatRequest,SendTaskHeartbeatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        public virtual Task<SendTaskHeartbeatResponse> SendTaskHeartbeatAsync(SendTaskHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendTaskHeartbeatRequestMarshaller();
            var unmarshaller = SendTaskHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<SendTaskHeartbeatRequest,SendTaskHeartbeatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendTaskSuccess

        internal virtual SendTaskSuccessResponse SendTaskSuccess(SendTaskSuccessRequest request)
        {
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var unmarshaller = SendTaskSuccessResponseUnmarshaller.Instance;

            return Invoke<SendTaskSuccessRequest,SendTaskSuccessResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        public virtual Task<SendTaskSuccessResponse> SendTaskSuccessAsync(SendTaskSuccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendTaskSuccessRequestMarshaller();
            var unmarshaller = SendTaskSuccessResponseUnmarshaller.Instance;

            return InvokeAsync<SendTaskSuccessRequest,SendTaskSuccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartExecution

        internal virtual StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            var marshaller = new StartExecutionRequestMarshaller();
            var unmarshaller = StartExecutionResponseUnmarshaller.Instance;

            return Invoke<StartExecutionRequest,StartExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        public virtual Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartExecutionRequestMarshaller();
            var unmarshaller = StartExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartExecutionRequest,StartExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopExecution

        internal virtual StopExecutionResponse StopExecution(StopExecutionRequest request)
        {
            var marshaller = new StopExecutionRequestMarshaller();
            var unmarshaller = StopExecutionResponseUnmarshaller.Instance;

            return Invoke<StopExecutionRequest,StopExecutionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        public virtual Task<StopExecutionResponse> StopExecutionAsync(StopExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopExecutionRequestMarshaller();
            var unmarshaller = StopExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopExecutionRequest,StopExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
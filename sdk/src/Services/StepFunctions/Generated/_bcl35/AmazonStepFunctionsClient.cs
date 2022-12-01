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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.StepFunctions.Model;
using Amazon.StepFunctions.Model.Internal.MarshallTransformations;
using Amazon.StepFunctions.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.StepFunctions
{
    /// <summary>
    /// Implementation for accessing StepFunctions
    ///
    /// Step Functions 
    /// <para>
    /// Step Functions is a service that lets you coordinate the components of distributed
    /// applications and microservices using visual workflows.
    /// </para>
    ///  
    /// <para>
    /// You can use Step Functions to build applications from individual components, each
    /// of which performs a discrete function, or <i>task</i>, allowing you to scale and change
    /// applications quickly. Step Functions provides a console that helps visualize the components
    /// of your application as a series of steps. Step Functions automatically triggers and
    /// tracks each step, and retries steps when there are errors, so your application executes
    /// predictably and in the right order every time. Step Functions logs the state of each
    /// step, so you can quickly diagnose and debug any issues.
    /// </para>
    ///  
    /// <para>
    /// Step Functions manages operations and underlying infrastructure to ensure your application
    /// is available at any scale. You can run tasks on Amazon Web Services, your own servers,
    /// or any system that has access to Amazon Web Services. You can access and use Step
    /// Functions using the console, the Amazon Web Services SDKs, or an HTTP API. For more
    /// information about Step Functions, see the <i> <a href="https://docs.aws.amazon.com/step-functions/latest/dg/welcome.html">Step
    /// Functions Developer Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial class AmazonStepFunctionsClient : AmazonServiceClient, IAmazonStepFunctions
    {
        private static IServiceMetadata serviceMetadata = new AmazonStepFunctionsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IStepFunctionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IStepFunctionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new StepFunctionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonStepFunctionsEndpointResolver());
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


        #region  CreateActivity

        /// <summary>
        /// Creates an activity. An activity is a task that you write in any programming language
        /// and host on any machine that has access to Step Functions. Activities must poll Step
        /// Functions using the <code>GetActivityTask</code> API action and respond using <code>SendTask*</code>
        /// API actions. This function lets Step Functions know the existence of your activity
        /// and returns an identifier for use in a state machine and when polling from the activity.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <code>CreateActivity</code> is an idempotent API. Subsequent requests won’t create
        /// a duplicate resource if it was already created. <code>CreateActivity</code>'s idempotency
        /// check is based on the activity <code>name</code>. If a following request has different
        /// <code>tags</code> values, Step Functions will ignore these differences and treat it
        /// as an idempotent request of the previous. In this case, <code>tags</code> will not
        /// be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity service method.</param>
        /// 
        /// <returns>The response from the CreateActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityLimitExceededException">
        /// The maximum number of activities has been reached. Existing activities must be deleted
        /// before a new activity can be created.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        public virtual CreateActivityResponse CreateActivity(CreateActivityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActivityResponseUnmarshaller.Instance;

            return Invoke<CreateActivityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        public virtual IAsyncResult BeginCreateActivity(CreateActivityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateActivityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActivity.</param>
        /// 
        /// <returns>Returns a  CreateActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        public virtual CreateActivityResponse EndCreateActivity(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateActivityResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStateMachine

        /// <summary>
        /// Creates a state machine. A state machine consists of a collection of states that can
        /// do work (<code>Task</code> states), determine to which states to transition next (<code>Choice</code>
        /// states), stop an execution with an error (<code>Fail</code> states), and so on. State
        /// machines are specified using a JSON-based, structured language. For more information,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> in the Step Functions User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <code>CreateStateMachine</code> is an idempotent API. Subsequent requests won’t create
        /// a duplicate resource if it was already created. <code>CreateStateMachine</code>'s
        /// idempotency check is based on the state machine <code>name</code>, <code>definition</code>,
        /// <code>type</code>, <code>LoggingConfiguration</code> and <code>TracingConfiguration</code>.
        /// If a following request has a different <code>roleArn</code> or <code>tags</code>,
        /// Step Functions will ignore these differences and treat it as an idempotent request
        /// of the previous. In this case, <code>roleArn</code> and <code>tags</code> will not
        /// be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine service method.</param>
        /// 
        /// <returns>The response from the CreateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <code>tracingConfiguration</code> key does not match, or <code>enabled</code>
        /// has not been set to <code>true</code> or <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineAlreadyExistsException">
        /// A state machine with the same name but a different definition or role ARN already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineLimitExceededException">
        /// The maximum number of state machines has been reached. Existing state machines must
        /// be deleted before a new state machine can be created.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        public virtual CreateStateMachineResponse CreateStateMachine(CreateStateMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStateMachineResponseUnmarshaller.Instance;

            return Invoke<CreateStateMachineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        public virtual IAsyncResult BeginCreateStateMachine(CreateStateMachineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStateMachineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStateMachine.</param>
        /// 
        /// <returns>Returns a  CreateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        public virtual CreateStateMachineResponse EndCreateStateMachine(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStateMachineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteActivity

        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity service method.</param>
        /// 
        /// <returns>The response from the DeleteActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        public virtual DeleteActivityResponse DeleteActivity(DeleteActivityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActivityResponseUnmarshaller.Instance;

            return Invoke<DeleteActivityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        public virtual IAsyncResult BeginDeleteActivity(DeleteActivityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteActivityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActivity.</param>
        /// 
        /// <returns>Returns a  DeleteActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        public virtual DeleteActivityResponse EndDeleteActivity(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteActivityResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStateMachine

        /// <summary>
        /// Deletes a state machine. This is an asynchronous operation: It sets the state machine's
        /// status to <code>DELETING</code> and begins the deletion process. 
        /// 
        ///  
        /// <para>
        /// If the given state machine Amazon Resource Name (ARN) is a qualified state machine
        /// ARN, it will fail with ValidationException.
        /// </para>
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
        /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
        /// the state machine named <code>stateMachineName</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <code>EXPRESS</code> state machines, the deletion will happen eventually (usually
        /// less than a minute). Running executions may emit logs after <code>DeleteStateMachine</code>
        /// API is called.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine service method.</param>
        /// 
        /// <returns>The response from the DeleteStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        public virtual DeleteStateMachineResponse DeleteStateMachine(DeleteStateMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStateMachineResponseUnmarshaller.Instance;

            return Invoke<DeleteStateMachineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        public virtual IAsyncResult BeginDeleteStateMachine(DeleteStateMachineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStateMachineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStateMachine.</param>
        /// 
        /// <returns>Returns a  DeleteStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        public virtual DeleteStateMachineResponse EndDeleteStateMachine(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStateMachineResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeActivity

        /// <summary>
        /// Describes an activity.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivity service method.</param>
        /// 
        /// <returns>The response from the DescribeActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityDoesNotExistException">
        /// The specified activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        public virtual DescribeActivityResponse DescribeActivity(DescribeActivityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityResponseUnmarshaller.Instance;

            return Invoke<DescribeActivityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        public virtual IAsyncResult BeginDescribeActivity(DescribeActivityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivity.</param>
        /// 
        /// <returns>Returns a  DescribeActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        public virtual DescribeActivityResponse EndDescribeActivity(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActivityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExecution

        /// <summary>
        /// Provides all information about a state machine execution, such as the state machine
        /// associated with the execution, the execution input and output, and relevant execution
        /// metadata. Use this API action to return the Map Run ARN if the execution was dispatched
        /// by a Map Run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machine executions
        /// unless they were dispatched by a Map Run.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMapRun

        /// <summary>
        /// Provides information about a Map Run's configuration, progress, and results. For more
        /// information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-examine-map-run.html">Examining
        /// Map Run</a> in the <i>Step Functions Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMapRun service method.</param>
        /// 
        /// <returns>The response from the DescribeMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        public virtual DescribeMapRunResponse DescribeMapRun(DescribeMapRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMapRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMapRunResponseUnmarshaller.Instance;

            return Invoke<DescribeMapRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMapRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMapRun operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMapRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        public virtual IAsyncResult BeginDescribeMapRun(DescribeMapRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMapRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMapRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMapRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMapRun.</param>
        /// 
        /// <returns>Returns a  DescribeMapRunResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        public virtual DescribeMapRunResponse EndDescribeMapRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMapRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStateMachine

        /// <summary>
        /// Provides information about a state machine's definition, its IAM role Amazon Resource
        /// Name (ARN), and configuration. If the state machine ARN is a qualified state machine
        /// ARN, the response returned includes the <code>Map</code> state's label.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
        /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
        /// the state machine named <code>stateMachineName</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine service method.</param>
        /// 
        /// <returns>The response from the DescribeStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        public virtual DescribeStateMachineResponse DescribeStateMachine(DescribeStateMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStateMachineResponseUnmarshaller.Instance;

            return Invoke<DescribeStateMachineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        public virtual IAsyncResult BeginDescribeStateMachine(DescribeStateMachineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStateMachineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachine.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        public virtual DescribeStateMachineResponse EndDescribeStateMachine(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStateMachineResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStateMachineForExecution

        /// <summary>
        /// Provides information about a state machine's definition, its execution role ARN, and
        /// configuration. If an execution was dispatched by a Map Run, the Map Run is returned
        /// in the response. Additionally, the state machine returned will be the state machine
        /// associated with the Map Run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineForExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeStateMachineForExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        public virtual DescribeStateMachineForExecutionResponse DescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStateMachineForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStateMachineForExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeStateMachineForExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachineForExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineForExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStateMachineForExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        public virtual IAsyncResult BeginDescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStateMachineForExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStateMachineForExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachineForExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachineForExecution.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineForExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        public virtual DescribeStateMachineForExecutionResponse EndDescribeStateMachineForExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStateMachineForExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetActivityTask

        /// <summary>
        /// Used by workers to retrieve a task (with the specified activity ARN) which has been
        /// scheduled for execution by a running state machine. This initiates a long poll, where
        /// the service holds the HTTP connection open and responds as soon as a task becomes
        /// available (i.e. an execution of a task of this type is needed.) The maximum time the
        /// service holds on to the request before responding is 60 seconds. If no task is available
        /// within 60 seconds, the poll returns a <code>taskToken</code> with a null string.
        /// 
        ///  <note> 
        /// <para>
        /// This API action isn't logged in CloudTrail.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Workers should set their client side socket timeout to at least 65 seconds (5 seconds
        /// higher than the maximum time the service may hold the poll request).
        /// </para>
        ///  
        /// <para>
        /// Polling with <code>GetActivityTask</code> can cause latency in some implementations.
        /// See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/bp-activity-pollers.html">Avoid
        /// Latency When Polling for Activity Tasks</a> in the Step Functions Developer Guide.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask service method.</param>
        /// 
        /// <returns>The response from the GetActivityTask service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityDoesNotExistException">
        /// The specified activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityWorkerLimitExceededException">
        /// The maximum number of workers concurrently polling for activity tasks has been reached.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        public virtual GetActivityTaskResponse GetActivityTask(GetActivityTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActivityTaskResponseUnmarshaller.Instance;

            return Invoke<GetActivityTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetActivityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        public virtual IAsyncResult BeginGetActivityTask(GetActivityTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActivityTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActivityTask.</param>
        /// 
        /// <returns>Returns a  GetActivityTaskResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        public virtual GetActivityTaskResponse EndGetActivityTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetActivityTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExecutionHistory

        /// <summary>
        /// Returns the history of the specified execution as a list of events. By default, the
        /// results are returned in ascending order of the <code>timeStamp</code> of the events.
        /// Use the <code>reverseOrder</code> parameter to get the latest events first.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory service method.</param>
        /// 
        /// <returns>The response from the GetExecutionHistory service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        public virtual GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExecutionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetExecutionHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExecutionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        public virtual IAsyncResult BeginGetExecutionHistory(GetExecutionHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExecutionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExecutionHistory.</param>
        /// 
        /// <returns>Returns a  GetExecutionHistoryResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        public virtual GetExecutionHistoryResponse EndGetExecutionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExecutionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListActivities

        /// <summary>
        /// Lists the existing activities.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivities service method.</param>
        /// 
        /// <returns>The response from the ListActivities service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        public virtual ListActivitiesResponse ListActivities(ListActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivitiesResponseUnmarshaller.Instance;

            return Invoke<ListActivitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivities operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        public virtual IAsyncResult BeginListActivities(ListActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivities.</param>
        /// 
        /// <returns>Returns a  ListActivitiesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        public virtual ListActivitiesResponse EndListActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActivitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExecutions

        /// <summary>
        /// Lists all executions of a state machine or a Map Run. You can list all executions
        /// related to a state machine by specifying a state machine Amazon Resource Name (ARN),
        /// or those related to a Map Run by specifying a Map Run ARN.
        /// 
        ///  
        /// <para>
        /// Results are sorted by time, with the most recent execution first.
        /// </para>
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMapRuns

        /// <summary>
        /// Lists all Map Runs that were started by a given state machine execution. Use this
        /// API action to obtain Map Run ARNs, and then call <code>DescribeMapRun</code> to obtain
        /// more information, if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMapRuns service method.</param>
        /// 
        /// <returns>The response from the ListMapRuns service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        public virtual ListMapRunsResponse ListMapRuns(ListMapRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMapRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMapRunsResponseUnmarshaller.Instance;

            return Invoke<ListMapRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMapRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMapRuns operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMapRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        public virtual IAsyncResult BeginListMapRuns(ListMapRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMapRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMapRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMapRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMapRuns.</param>
        /// 
        /// <returns>Returns a  ListMapRunsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        public virtual ListMapRunsResponse EndListMapRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMapRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStateMachines

        /// <summary>
        /// Lists the existing state machines.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines service method.</param>
        /// 
        /// <returns>The response from the ListStateMachines service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        public virtual ListStateMachinesResponse ListStateMachines(ListStateMachinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStateMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStateMachinesResponseUnmarshaller.Instance;

            return Invoke<ListStateMachinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStateMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        public virtual IAsyncResult BeginListStateMachines(ListStateMachinesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStateMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStateMachinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStateMachines.</param>
        /// 
        /// <returns>Returns a  ListStateMachinesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        public virtual ListStateMachinesResponse EndListStateMachines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStateMachinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for a given resource.
        /// 
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <code>_
        /// . : / = + - @</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  SendTaskFailure

        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report that the task identified by the <code>taskToken</code> failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure service method.</param>
        /// 
        /// <returns>The response from the SendTaskFailure service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        public virtual SendTaskFailureResponse SendTaskFailure(SendTaskFailureRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskFailureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskFailureResponseUnmarshaller.Instance;

            return Invoke<SendTaskFailureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskFailure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        public virtual IAsyncResult BeginSendTaskFailure(SendTaskFailureRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskFailureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskFailureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskFailure.</param>
        /// 
        /// <returns>Returns a  SendTaskFailureResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        public virtual SendTaskFailureResponse EndSendTaskFailure(IAsyncResult asyncResult)
        {
            return EndInvoke<SendTaskFailureResponse>(asyncResult);
        }

        #endregion
        
        #region  SendTaskHeartbeat

        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report to Step Functions that the task represented by the specified <code>taskToken</code>
        /// is still making progress. This action resets the <code>Heartbeat</code> clock. The
        /// <code>Heartbeat</code> threshold is specified in the state machine's Amazon States
        /// Language definition (<code>HeartbeatSeconds</code>). This action does not in itself
        /// create an event in the execution history. However, if the task times out, the execution
        /// history contains an <code>ActivityTimedOut</code> entry for activities, or a <code>TaskTimedOut</code>
        /// entry for for tasks using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Timeout</code> of a task, defined in the state machine's Amazon States Language
        /// definition, is its maximum allowed duration, regardless of the number of <a>SendTaskHeartbeat</a>
        /// requests received. Use <code>HeartbeatSeconds</code> to configure the timeout interval
        /// for heartbeats.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat service method.</param>
        /// 
        /// <returns>The response from the SendTaskHeartbeat service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        public virtual SendTaskHeartbeatResponse SendTaskHeartbeat(SendTaskHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskHeartbeatResponseUnmarshaller.Instance;

            return Invoke<SendTaskHeartbeatResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        public virtual IAsyncResult BeginSendTaskHeartbeat(SendTaskHeartbeatRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskHeartbeatResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a  SendTaskHeartbeatResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        public virtual SendTaskHeartbeatResponse EndSendTaskHeartbeat(IAsyncResult asyncResult)
        {
            return EndInvoke<SendTaskHeartbeatResponse>(asyncResult);
        }

        #endregion
        
        #region  SendTaskSuccess

        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report that the task identified by the <code>taskToken</code> completed
        /// successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess service method.</param>
        /// 
        /// <returns>The response from the SendTaskSuccess service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidOutputException">
        /// The provided JSON output data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        public virtual SendTaskSuccessResponse SendTaskSuccess(SendTaskSuccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskSuccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskSuccessResponseUnmarshaller.Instance;

            return Invoke<SendTaskSuccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskSuccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        public virtual IAsyncResult BeginSendTaskSuccess(SendTaskSuccessRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendTaskSuccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTaskSuccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskSuccess.</param>
        /// 
        /// <returns>Returns a  SendTaskSuccessResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        public virtual SendTaskSuccessResponse EndSendTaskSuccess(IAsyncResult asyncResult)
        {
            return EndInvoke<SendTaskSuccessResponse>(asyncResult);
        }

        #endregion
        
        #region  StartExecution

        /// <summary>
        /// Starts a state machine execution. If the given state machine Amazon Resource Name
        /// (ARN) is a qualified state machine ARN, it will fail with ValidationException.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
        /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
        /// the state machine named <code>stateMachineName</code>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>StartExecution</code> is idempotent for <code>STANDARD</code> workflows. For
        /// a <code>STANDARD</code> workflow, if <code>StartExecution</code> is called with the
        /// same name and input as a running execution, the call will succeed and return the same
        /// response as the original request. If the execution is closed or if the input is different,
        /// it will return a <code>400 ExecutionAlreadyExists</code> error. Names can be reused
        /// after 90 days. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartExecution</code> is not idempotent for <code>EXPRESS</code> workflows.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExecution service method.</param>
        /// 
        /// <returns>The response from the StartExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionAlreadyExistsException">
        /// The execution has the same <code>name</code> as another execution (but a different
        /// <code>input</code>).
        /// 
        ///  <note> 
        /// <para>
        /// Executions with the same <code>name</code> and <code>input</code> are considered idempotent.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionLimitExceededException">
        /// The maximum number of running executions has been reached. Running executions must
        /// end or be stopped before a new execution can be started.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        public virtual StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExecutionResponseUnmarshaller.Instance;

            return Invoke<StartExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        public virtual IAsyncResult BeginStartExecution(StartExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExecution.</param>
        /// 
        /// <returns>Returns a  StartExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        public virtual StartExecutionResponse EndStartExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSyncExecution

        /// <summary>
        /// Starts a Synchronous Express state machine execution. <code>StartSyncExecution</code>
        /// is not available for <code>STANDARD</code> workflows.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>StartSyncExecution</code> will return a <code>200 OK</code> response, even
        /// if your execution fails, because the status code in the API response doesn't reflect
        /// function errors. Error codes are reserved for errors that prevent your execution from
        /// running, such as permissions errors, limit errors, or issues with your state machine
        /// code and configuration. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This API action isn't logged in CloudTrail.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution service method.</param>
        /// 
        /// <returns>The response from the StartSyncExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        public virtual StartSyncExecutionResponse StartSyncExecution(StartSyncExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSyncExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSyncExecutionResponseUnmarshaller.Instance;

            return Invoke<StartSyncExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSyncExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSyncExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        public virtual IAsyncResult BeginStartSyncExecution(StartSyncExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSyncExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSyncExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSyncExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSyncExecution.</param>
        /// 
        /// <returns>Returns a  StartSyncExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        public virtual StartSyncExecutionResponse EndStartSyncExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSyncExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopExecution

        /// <summary>
        /// Stops an execution.
        /// 
        ///  
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExecution service method.</param>
        /// 
        /// <returns>The response from the StopExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        public virtual StopExecutionResponse StopExecution(StopExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExecutionResponseUnmarshaller.Instance;

            return Invoke<StopExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        public virtual IAsyncResult BeginStopExecution(StopExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExecution.</param>
        /// 
        /// <returns>Returns a  StopExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        public virtual StopExecutionResponse EndStopExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StopExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Add a tag to a Step Functions resource.
        /// 
        ///  
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>, and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html">Controlling
        /// Access Using IAM Tags</a>.
        /// </para>
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <code>_
        /// . : / = + - @</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove a tag from a Step Functions resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMapRun

        /// <summary>
        /// Updates an in-progress Map Run's configuration to include changes to the settings
        /// that control maximum concurrency and Map Run failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMapRun service method.</param>
        /// 
        /// <returns>The response from the UpdateMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        public virtual UpdateMapRunResponse UpdateMapRun(UpdateMapRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMapRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMapRunResponseUnmarshaller.Instance;

            return Invoke<UpdateMapRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMapRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMapRun operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMapRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        public virtual IAsyncResult BeginUpdateMapRun(UpdateMapRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMapRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMapRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMapRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMapRun.</param>
        /// 
        /// <returns>Returns a  UpdateMapRunResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        public virtual UpdateMapRunResponse EndUpdateMapRun(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMapRunResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStateMachine

        /// <summary>
        /// Updates an existing state machine by modifying its <code>definition</code>, <code>roleArn</code>,
        /// or <code>loggingConfiguration</code>. Running executions will continue to use the
        /// previous <code>definition</code> and <code>roleArn</code>. You must include at least
        /// one of <code>definition</code> or <code>roleArn</code> or you will receive a <code>MissingRequiredParameter</code>
        /// error.
        /// 
        ///  
        /// <para>
        /// If the given state machine Amazon Resource Name (ARN) is a qualified state machine
        /// ARN, it will fail with ValidationException.
        /// </para>
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
        /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
        /// the state machine named <code>stateMachineName</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// All <code>StartExecution</code> calls within a few seconds will use the updated <code>definition</code>
        /// and <code>roleArn</code>. Executions started immediately after calling <code>UpdateStateMachine</code>
        /// may use the previous state machine <code>definition</code> and <code>roleArn</code>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachine service method.</param>
        /// 
        /// <returns>The response from the UpdateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <code>tracingConfiguration</code> key does not match, or <code>enabled</code>
        /// has not been set to <code>true</code> or <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.MissingRequiredParameterException">
        /// Request is missing a required parameter. This error occurs if both <code>definition</code>
        /// and <code>roleArn</code> are not specified.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        public virtual UpdateStateMachineResponse UpdateStateMachine(UpdateStateMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStateMachineResponseUnmarshaller.Instance;

            return Invoke<UpdateStateMachineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        public virtual IAsyncResult BeginUpdateStateMachine(UpdateStateMachineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStateMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStateMachineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStateMachine.</param>
        /// 
        /// <returns>Returns a  UpdateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        public virtual UpdateStateMachineResponse EndUpdateStateMachine(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStateMachineResponse>(asyncResult);
        }

        #endregion
        
    }
}
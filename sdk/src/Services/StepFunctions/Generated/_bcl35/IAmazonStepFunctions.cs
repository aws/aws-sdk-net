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

using Amazon.Runtime;
using Amazon.StepFunctions.Model;

namespace Amazon.StepFunctions
{
    /// <summary>
    /// Interface for accessing StepFunctions
    ///
    /// AWS Step Functions 
    /// <para>
    /// AWS Step Functions is a service that lets you coordinate the components of distributed
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
    /// is available at any scale. You can run tasks on AWS, your own servers, or any system
    /// that has access to AWS. You can access and use Step Functions using the console, the
    /// AWS SDKs, or an HTTP API. For more information about Step Functions, see the <i> <a
    /// href="https://docs.aws.amazon.com/step-functions/latest/dg/welcome.html">AWS Step
    /// Functions Developer Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonStepFunctions : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IStepFunctionsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateActivity


        /// <summary>
        /// Creates an activity. An activity is a task that you write in any programming language
        /// and host on any machine that has access to AWS Step Functions. Activities must poll
        /// Step Functions using the <code>GetActivityTask</code> API action and respond using
        /// <code>SendTask*</code> API actions. This function lets Step Functions know the existence
        /// of your activity and returns an identifier for use in a state machine and when polling
        /// from the activity.
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
        /// The provided name is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the AWS Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        CreateActivityResponse CreateActivity(CreateActivityRequest request);

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
        IAsyncResult BeginCreateActivity(CreateActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActivity.</param>
        /// 
        /// <returns>Returns a  CreateActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        CreateActivityResponse EndCreateActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStateMachine


        /// <summary>
        /// Creates a state machine. A state machine consists of a collection of states that can
        /// do work (<code>Task</code> states), determine to which states to transition next (<code>Choice</code>
        /// states), stop an execution with an error (<code>Fail</code> states), and so on. State
        /// machines are specified using a JSON-based, structured language. For more information,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> in the AWS Step Functions User Guide.
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is invalid.
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
        /// Limits Topic</a> in the AWS Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        CreateStateMachineResponse CreateStateMachine(CreateStateMachineRequest request);

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
        IAsyncResult BeginCreateStateMachine(CreateStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStateMachine.</param>
        /// 
        /// <returns>Returns a  CreateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        CreateStateMachineResponse EndCreateStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteActivity


        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity service method.</param>
        /// 
        /// <returns>The response from the DeleteActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        DeleteActivityResponse DeleteActivity(DeleteActivityRequest request);

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
        IAsyncResult BeginDeleteActivity(DeleteActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActivity.</param>
        /// 
        /// <returns>Returns a  DeleteActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        DeleteActivityResponse EndDeleteActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStateMachine


        /// <summary>
        /// Deletes a state machine. This is an asynchronous operation: It sets the state machine's
        /// status to <code>DELETING</code> and begins the deletion process. 
        /// 
        ///  <note> 
        /// <para>
        /// For <code>EXPRESS</code>state machines, the deletion will happen eventually (usually
        /// less than a minute). Running executions may emit logs after <code>DeleteStateMachine</code>
        /// API is called.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine service method.</param>
        /// 
        /// <returns>The response from the DeleteStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        DeleteStateMachineResponse DeleteStateMachine(DeleteStateMachineRequest request);

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
        IAsyncResult BeginDeleteStateMachine(DeleteStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStateMachine.</param>
        /// 
        /// <returns>Returns a  DeleteStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        DeleteStateMachineResponse EndDeleteStateMachine(IAsyncResult asyncResult);

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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        DescribeActivityResponse DescribeActivity(DescribeActivityRequest request);

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
        IAsyncResult BeginDescribeActivity(DescribeActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivity.</param>
        /// 
        /// <returns>Returns a  DescribeActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        DescribeActivityResponse EndDescribeActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExecution


        /// <summary>
        /// Describes an execution.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request);

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
        IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStateMachine


        /// <summary>
        /// Describes a state machine.
        /// 
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        DescribeStateMachineResponse DescribeStateMachine(DescribeStateMachineRequest request);

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
        IAsyncResult BeginDescribeStateMachine(DescribeStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachine.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        DescribeStateMachineResponse EndDescribeStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStateMachineForExecution


        /// <summary>
        /// Describes the state machine associated with a specific execution.
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        DescribeStateMachineForExecutionResponse DescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request);

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
        IAsyncResult BeginDescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachineForExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachineForExecution.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineForExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        DescribeStateMachineForExecutionResponse EndDescribeStateMachineForExecution(IAsyncResult asyncResult);

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
        ///  <important> 
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        GetActivityTaskResponse GetActivityTask(GetActivityTaskRequest request);

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
        IAsyncResult BeginGetActivityTask(GetActivityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActivityTask.</param>
        /// 
        /// <returns>Returns a  GetActivityTaskResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        GetActivityTaskResponse EndGetActivityTask(IAsyncResult asyncResult);

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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request);

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
        IAsyncResult BeginGetExecutionHistory(GetExecutionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExecutionHistory.</param>
        /// 
        /// <returns>Returns a  GetExecutionHistoryResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        GetExecutionHistoryResponse EndGetExecutionHistory(IAsyncResult asyncResult);

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
        /// The provided token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        ListActivitiesResponse ListActivities(ListActivitiesRequest request);

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
        IAsyncResult BeginListActivities(ListActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivities.</param>
        /// 
        /// <returns>Returns a  ListActivitiesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        ListActivitiesResponse EndListActivities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// Lists the executions of a state machine that meet the filtering criteria. Results
        /// are sorted by time, with the most recent execution first.
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
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);

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
        IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult);

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
        /// The provided token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        ListStateMachinesResponse ListStateMachines(ListStateMachinesRequest request);

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
        IAsyncResult BeginListStateMachines(ListStateMachinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStateMachines.</param>
        /// 
        /// <returns>Returns a  ListStateMachinesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        ListStateMachinesResponse EndListStateMachines(IAsyncResult asyncResult);

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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

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
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// The provided token is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        SendTaskFailureResponse SendTaskFailure(SendTaskFailureRequest request);

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
        IAsyncResult BeginSendTaskFailure(SendTaskFailureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskFailure.</param>
        /// 
        /// <returns>Returns a  SendTaskFailureResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        SendTaskFailureResponse EndSendTaskFailure(IAsyncResult asyncResult);

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
        /// The provided token is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        SendTaskHeartbeatResponse SendTaskHeartbeat(SendTaskHeartbeatRequest request);

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
        IAsyncResult BeginSendTaskHeartbeat(SendTaskHeartbeatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a  SendTaskHeartbeatResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        SendTaskHeartbeatResponse EndSendTaskHeartbeat(IAsyncResult asyncResult);

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
        /// The provided JSON output data is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        SendTaskSuccessResponse SendTaskSuccess(SendTaskSuccessRequest request);

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
        IAsyncResult BeginSendTaskSuccess(SendTaskSuccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskSuccess.</param>
        /// 
        /// <returns>Returns a  SendTaskSuccessResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        SendTaskSuccessResponse EndSendTaskSuccess(IAsyncResult asyncResult);

        #endregion
        
        #region  StartExecution


        /// <summary>
        /// Starts a state machine execution.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>StartExecution</code> is idempotent. If <code>StartExecution</code> is called
        /// with the same name and input as a running execution, the call will succeed and return
        /// the same response as the original request. If the execution is closed or if the input
        /// is different, it will return a 400 <code>ExecutionAlreadyExists</code> error. Names
        /// can be reused after 90 days. 
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        StartExecutionResponse StartExecution(StartExecutionRequest request);

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
        IAsyncResult BeginStartExecution(StartExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExecution.</param>
        /// 
        /// <returns>Returns a  StartExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        StartExecutionResponse EndStartExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSyncExecution


        /// <summary>
        /// Starts a Synchronous Express state machine execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution service method.</param>
        /// 
        /// <returns>The response from the StartSyncExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is invalid.
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
        StartSyncExecutionResponse StartSyncExecution(StartSyncExecutionRequest request);

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
        IAsyncResult BeginStartSyncExecution(StartSyncExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSyncExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSyncExecution.</param>
        /// 
        /// <returns>Returns a  StartSyncExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        StartSyncExecutionResponse EndStartSyncExecution(IAsyncResult asyncResult);

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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        StopExecutionResponse StopExecution(StopExecutionRequest request);

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
        IAsyncResult BeginStopExecution(StopExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExecution.</param>
        /// 
        /// <returns>Returns a  StopExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        StopExecutionResponse EndStopExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a tag to a Step Functions resource.
        /// 
        ///  
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>,
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html">Controlling
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the AWS Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

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
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove a tag from a Step Functions resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource. Only state machine and activity ARNs are supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

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
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStateMachine


        /// <summary>
        /// Updates an existing state machine by modifying its <code>definition</code>, <code>roleArn</code>,
        /// or <code>loggingConfiguration</code>. Running executions will continue to use the
        /// previous <code>definition</code> and <code>roleArn</code>. You must include at least
        /// one of <code>definition</code> or <code>roleArn</code> or you will receive a <code>MissingRequiredParameter</code>
        /// error.
        /// 
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
        /// The provided Amazon Resource Name (ARN) is invalid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        UpdateStateMachineResponse UpdateStateMachine(UpdateStateMachineRequest request);

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
        IAsyncResult BeginUpdateStateMachine(UpdateStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStateMachine.</param>
        /// 
        /// <returns>Returns a  UpdateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        UpdateStateMachineResponse EndUpdateStateMachine(IAsyncResult asyncResult);

        #endregion
        
    }
}
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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.StepFunctions.Model;

#pragma warning disable CS1570
namespace Amazon.StepFunctions
{
    /// <summary>
    /// <para>Interface for accessing StepFunctions</para>
    ///
    /// Step Functions 
    /// <para>
    /// With Step Functions, you can create workflows, also called <i>state machines</i>,
    /// to build distributed applications, automate processes, orchestrate microservices,
    /// and create data and machine learning pipelines.
    /// </para>
    ///  
    /// <para>
    /// Through the Step Functions API, you can create, list, update, and delete state machines,
    /// activities, and other data types. You can start, stop, and redrive your state machines.
    /// Your activity workers can send task success, heartbeat, and failure responses.
    /// </para>
    ///  
    /// <para>
    /// With API calls, you can also manage other aspects of your workflow, such as tags,
    /// versions, and aliases.
    /// </para>
    ///  
    /// <para>
    /// For more information about developing solutions with Step Functions, see the <i> <a
    /// href="https://docs.aws.amazon.com/step-functions/latest/dg/welcome.html">Step Functions
    /// Developer Guide</a> </i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you use the Step Functions API actions using Amazon Web Services SDK integrations,
    /// make sure the API actions are in camel case and parameter names are in Pascal case.
    /// For example, you might use Step Functions API action <c>startSyncExecution</c> and
    /// specify its parameter as <c>StateMachineArn</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial interface IAmazonStepFunctions : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IStepFunctionsPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateActivity



        /// <summary>
        /// Creates an activity. An activity is a task that you write in any programming language
        /// and host on any machine that has access to Step Functions. Activities must poll Step
        /// Functions using the <c>GetActivityTask</c> API action and respond using <c>SendTask*</c>
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
        ///  <c>CreateActivity</c> is an idempotent API. Subsequent requests won’t create a duplicate
        /// resource if it was already created. <c>CreateActivity</c>'s idempotency check is based
        /// on the activity <c>name</c>. If a following request has different <c>tags</c> values,
        /// Step Functions will ignore these differences and treat it as an idempotent request
        /// of the previous. In this case, <c>tags</c> will not be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityAlreadyExistsException">
        /// Activity already exists. <c>EncryptionConfiguration</c> may not be updated.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityLimitExceededException">
        /// The maximum number of activities has been reached. Existing activities must be deleted
        /// before a new activity can be created.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidEncryptionConfigurationException">
        /// Received when <c>encryptionConfiguration</c> is specified but various conditions exist
        /// which make the configuration invalid. For example, if <c>type</c> is set to <c>CUSTOMER_MANAGED_KMS_KEY</c>,
        /// but <c>kmsKeyId</c> is null, or <c>kmsDataKeyReusePeriodSeconds</c> is not between
        /// 60 and 900, or the KMS key is not symmetric or inactive.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        Task<CreateActivityResponse> CreateActivityAsync(CreateActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStateMachine



        /// <summary>
        /// Creates a state machine. A state machine consists of a collection of states that can
        /// do work (<c>Task</c> states), determine to which states to transition next (<c>Choice</c>
        /// states), stop an execution with an error (<c>Fail</c> states), and so on. State machines
        /// are specified using a JSON-based, structured language. For more information, see <a
        /// href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> in the Step Functions User Guide.
        /// 
        ///  
        /// <para>
        /// If you set the <c>publish</c> parameter of this API action to <c>true</c>, it publishes
        /// version <c>1</c> as the first revision of the state machine.
        /// </para>
        ///  
        /// <para>
        ///  For additional control over security, you can encrypt your data using a <b>customer-managed
        /// key</b> for Step Functions state machines. You can configure a symmetric KMS key and
        /// data key reuse period when creating or updating a <b>State Machine</b>. The execution
        /// history and state machine definition will be encrypted with the key applied to the
        /// State Machine. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <c>CreateStateMachine</c> is an idempotent API. Subsequent requests won’t create
        /// a duplicate resource if it was already created. <c>CreateStateMachine</c>'s idempotency
        /// check is based on the state machine <c>name</c>, <c>definition</c>, <c>type</c>, <c>LoggingConfiguration</c>,
        /// <c>TracingConfiguration</c>, and <c>EncryptionConfiguration</c> The check is also
        /// based on the <c>publish</c> and <c>versionDescription</c> parameters. If a following
        /// request has a different <c>roleArn</c> or <c>tags</c>, Step Functions will ignore
        /// these differences and treat it as an idempotent request of the previous. In this case,
        /// <c>roleArn</c> and <c>tags</c> will not be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidEncryptionConfigurationException">
        /// Received when <c>encryptionConfiguration</c> is specified but various conditions exist
        /// which make the configuration invalid. For example, if <c>type</c> is set to <c>CUSTOMER_MANAGED_KMS_KEY</c>,
        /// but <c>kmsKeyId</c> is null, or <c>kmsDataKeyReusePeriodSeconds</c> is not between
        /// 60 and 900, or the KMS key is not symmetric or inactive.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// Configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <c>tracingConfiguration</c> key does not match, or <c>enabled</c> has not been
        /// set to <c>true</c> or <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
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
        /// State machine type is not supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        Task<CreateStateMachineResponse> CreateStateMachineAsync(CreateStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStateMachineAlias



        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// for a state machine that points to one or two <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// of the same state machine. You can set your application to call <a>StartExecution</a>
        /// with an alias and update the version the alias uses without changing the client's
        /// code.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split <a>StartExecution</a> requests between two versions
        /// of a state machine. To do this, add a second <c>RoutingConfig</c> object in the <c>routingConfiguration</c>
        /// parameter. You must also specify the percentage of execution run requests each version
        /// should receive in both <c>RoutingConfig</c> objects. Step Functions randomly chooses
        /// which version runs a given execution based on the percentage you specify.
        /// </para>
        ///  
        /// <para>
        /// To create an alias that points to a single version, specify a single <c>RoutingConfig</c>
        /// object with a <c>weight</c> set to 100.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 100 aliases for each state machine. You must delete unused aliases
        /// using the <a>DeleteStateMachineAlias</a> API action.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateStateMachineAlias</c> is an idempotent API. Step Functions bases the idempotency
        /// check on the <c>stateMachineArn</c>, <c>description</c>, <c>name</c>, and <c>routingConfiguration</c>
        /// parameters. Requests that contain the same values for these parameters return a successful
        /// idempotent response without creating a duplicate resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachineAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachineAlias">REST API Reference for CreateStateMachineAlias Operation</seealso>
        Task<CreateStateMachineAliasResponse> CreateStateMachineAliasAsync(CreateStateMachineAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteActivity



        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        Task<DeleteActivityResponse> DeleteActivityAsync(DeleteActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStateMachine



        /// <summary>
        /// Deletes a state machine. This is an asynchronous operation. It sets the state machine's
        /// status to <c>DELETING</c> and begins the deletion process. A state machine is deleted
        /// only when all its executions are completed. On the next state transition, the state
        /// machine's executions are terminated.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <c>mapStateLabel</c> in a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <c>ValidationException</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This API action also deletes all <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// and <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">aliases</a>
        /// associated with a state machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <c>EXPRESS</c> state machines, the deletion happens eventually (usually in less
        /// than a minute). Running executions may emit logs after <c>DeleteStateMachine</c> API
        /// is called.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        Task<DeleteStateMachineResponse> DeleteStateMachineAsync(DeleteStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStateMachineAlias



        /// <summary>
        /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  
        /// <para>
        /// After you delete a state machine alias, you can't use it to start executions. When
        /// you delete a state machine alias, Step Functions doesn't delete the state machine
        /// versions that alias references.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineAlias">REST API Reference for DeleteStateMachineAlias Operation</seealso>
        Task<DeleteStateMachineAliasResponse> DeleteStateMachineAliasAsync(DeleteStateMachineAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStateMachineVersion



        /// <summary>
        /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
        /// After you delete a version, you can't call <a>StartExecution</a> using that version's
        /// ARN or use the version with a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting a state machine version won't terminate its in-progress executions.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// You can't delete a state machine version currently referenced by one or more aliases.
        /// Before you delete a version, you must either delete the aliases or update them to
        /// point to another state machine version.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PublishStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineVersions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStateMachineVersion service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineVersion">REST API Reference for DeleteStateMachineVersion Operation</seealso>
        Task<DeleteStateMachineVersionResponse> DeleteStateMachineVersionAsync(DeleteStateMachineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityDoesNotExistException">
        /// The specified activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        Task<DescribeActivityResponse> DescribeActivityAsync(DescribeActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExecution



        /// <summary>
        /// Provides information about a state machine execution, such as the state machine associated
        /// with the execution, the execution input and output, and relevant execution metadata.
        /// If you've <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-executions.html">redriven</a>
        /// an execution, you can use this API action to return information about the redrives
        /// of that execution. In addition, you can use this API action to return the Map Run
        /// Amazon Resource Name (ARN) if the execution was dispatched by a Map Run.
        /// 
        ///  
        /// <para>
        /// If you specify a version or alias ARN when you call the <a>StartExecution</a> API
        /// action, <c>DescribeExecution</c> returns that ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// Executions of an <c>EXPRESS</c> state machine aren't supported by <c>DescribeExecution</c>
        /// unless a Map Run dispatched them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMapRun



        /// <summary>
        /// Provides information about a Map Run's configuration, progress, and results. If you've
        /// <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-map-run.html">redriven</a>
        /// a Map Run, this API action also returns information about the redrives of that Map
        /// Run. For more information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-examine-map-run.html">Examining
        /// Map Run</a> in the <i>Step Functions Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMapRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        Task<DescribeMapRunResponse> DescribeMapRunAsync(DescribeMapRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStateMachine



        /// <summary>
        /// Provides information about a state machine's definition, its IAM role Amazon Resource
        /// Name (ARN), and configuration.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <c>mapStateLabel</c> in a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <c>ValidationException</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <c>PROD</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This API action returns the details for a state machine version if the <c>stateMachineArn</c>
        /// you specify is a state machine version ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        Task<DescribeStateMachineResponse> DescribeStateMachineAsync(DescribeStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStateMachineAlias



        /// <summary>
        /// Returns details about a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineAlias">REST API Reference for DescribeStateMachineAlias Operation</seealso>
        Task<DescribeStateMachineAliasResponse> DescribeStateMachineAliasAsync(DescribeStateMachineAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStateMachineForExecution



        /// <summary>
        /// Provides information about a state machine's definition, its execution role ARN, and
        /// configuration. If a Map Run dispatched the execution, this action returns the Map
        /// Run Amazon Resource Name (ARN) in the response. The state machine returned is the
        /// state machine associated with the Map Run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <c>EXPRESS</c> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineForExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStateMachineForExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        Task<DescribeStateMachineForExecutionResponse> DescribeStateMachineForExecutionAsync(DescribeStateMachineForExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetActivityTask



        /// <summary>
        /// Used by workers to retrieve a task (with the specified activity ARN) which has been
        /// scheduled for execution by a running state machine. This initiates a long poll, where
        /// the service holds the HTTP connection open and responds as soon as a task becomes
        /// available (i.e. an execution of a task of this type is needed.) The maximum time the
        /// service holds on to the request before responding is 60 seconds. If no task is available
        /// within 60 seconds, the poll returns a <c>taskToken</c> with a null string.
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
        /// Polling with <c>GetActivityTask</c> can cause latency in some implementations. See
        /// <a href="https://docs.aws.amazon.com/step-functions/latest/dg/bp-activity-pollers.html">Avoid
        /// Latency When Polling for Activity Tasks</a> in the Step Functions Developer Guide.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        Task<GetActivityTaskResponse> GetActivityTaskAsync(GetActivityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExecutionHistory



        /// <summary>
        /// Returns the history of the specified execution as a list of events. By default, the
        /// results are returned in ascending order of the <c>timeStamp</c> of the events. Use
        /// the <c>reverseOrder</c> parameter to get the latest events first.
        /// 
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        /// This API action is not supported by <c>EXPRESS</c> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        Task<GetExecutionHistoryResponse> GetExecutionHistoryAsync(GetExecutionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActivities



        /// <summary>
        /// Lists the existing activities.
        /// 
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActivities service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        Task<ListActivitiesResponse> ListActivitiesAsync(ListActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExecutions



        /// <summary>
        /// Lists all executions of a state machine or a Map Run. You can list all executions
        /// related to a state machine by specifying a state machine Amazon Resource Name (ARN),
        /// or those related to a Map Run by specifying a Map Run ARN. Using this API action,
        /// you can also list all <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-executions.html">redriven</a>
        /// executions.
        /// 
        ///  
        /// <para>
        /// You can also provide a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// ARN or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>
        /// ARN to list the executions associated with a specific alias or version.
        /// </para>
        ///  
        /// <para>
        /// Results are sorted by time, with the most recent execution first.
        /// </para>
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <c>EXPRESS</c> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// State machine type is not supported.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMapRuns



        /// <summary>
        /// Lists all Map Runs that were started by a given state machine execution. Use this
        /// API action to obtain Map Run ARNs, and then call <c>DescribeMapRun</c> to obtain more
        /// information, if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMapRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMapRunsResponse> ListMapRunsAsync(ListMapRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStateMachineAliases



        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">aliases</a>
        /// for a specified state machine ARN. Results are sorted by time, with the most recently
        /// created aliases listed first. 
        /// 
        ///  
        /// <para>
        /// To list aliases that reference a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>,
        /// you can specify the version ARN in the <c>stateMachineArn</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStateMachineAliases service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineAliases">REST API Reference for ListStateMachineAliases Operation</seealso>
        Task<ListStateMachineAliasesResponse> ListStateMachineAliasesAsync(ListStateMachineAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStateMachines



        /// <summary>
        /// Lists the existing state machines.
        /// 
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStateMachines service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        Task<ListStateMachinesResponse> ListStateMachinesAsync(ListStateMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStateMachineVersions



        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// for the specified state machine Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// The results are sorted in descending order of the version creation time.
        /// </para>
        ///  
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PublishStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineVersion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStateMachineVersions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineVersions">REST API Reference for ListStateMachineVersions Operation</seealso>
        Task<ListStateMachineVersionsResponse> ListStateMachineVersionsAsync(ListStateMachineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List tags for a given resource.
        /// 
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <c>_
        /// . : / = + - @</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PublishStateMachineVersion



        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>
        /// from the current revision of a state machine. Use versions to create immutable snapshots
        /// of your state machine. You can start executions from versions either directly or with
        /// an alias. To create an alias, use <a>CreateStateMachineAlias</a>.
        /// 
        ///  
        /// <para>
        /// You can publish up to 1000 versions for each state machine. You must manually delete
        /// unused versions using the <a>DeleteStateMachineVersion</a> API action.
        /// </para>
        ///  
        /// <para>
        ///  <c>PublishStateMachineVersion</c> is an idempotent API. It doesn't create a duplicate
        /// state machine version if it already exists for the current revision. Step Functions
        /// bases <c>PublishStateMachineVersion</c>'s idempotency check on the <c>stateMachineArn</c>,
        /// <c>name</c>, and <c>revisionId</c> parameters. Requests with the same parameters return
        /// a successful idempotent response. If you don't specify a <c>revisionId</c>, Step Functions
        /// checks for a previously published version of the state machine's current revision.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineVersions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishStateMachineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishStateMachineVersion service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/PublishStateMachineVersion">REST API Reference for PublishStateMachineVersion Operation</seealso>
        Task<PublishStateMachineVersionResponse> PublishStateMachineVersionAsync(PublishStateMachineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RedriveExecution



        /// <summary>
        /// Restarts unsuccessful executions of Standard workflows that didn't complete successfully
        /// in the last 14 days. These include failed, aborted, or timed out executions. When
        /// you <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-executions.html">redrive</a>
        /// an execution, it continues the failed execution from the unsuccessful step and uses
        /// the same input. Step Functions preserves the results and execution history of the
        /// successful steps, and doesn't rerun these steps when you redrive an execution. Redriven
        /// executions use the same state machine definition and execution ARN as the original
        /// execution attempt.
        /// 
        ///  
        /// <para>
        /// For workflows that include an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-map-state.html">Inline
        /// Map</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-parallel-state.html">Parallel</a>
        /// state, <c>RedriveExecution</c> API action reschedules and redrives only the iterations
        /// and branches that failed or aborted.
        /// </para>
        ///  
        /// <para>
        /// To redrive a workflow that includes a Distributed Map state whose Map Run failed,
        /// you must redrive the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/use-dist-map-orchestrate-large-scale-parallel-workloads.html#dist-map-orchestrate-parallel-workloads-key-terms">parent
        /// workflow</a>. The parent workflow redrives all the unsuccessful states, including
        /// a failed Map Run. If a Map Run was not started in the original execution attempt,
        /// the redriven parent workflow starts the Map Run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API action is not supported by <c>EXPRESS</c> state machines.
        /// </para>
        ///  
        /// <para>
        /// However, you can restart the unsuccessful executions of Express child workflows in
        /// a Distributed Map by redriving its Map Run. When you redrive a Map Run, the Express
        /// child workflows are rerun using the <a>StartExecution</a> API action. For more information,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/redrive-map-run.html">Redriving
        /// Map Runs</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can redrive executions if your original execution meets the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The execution status isn't <c>SUCCEEDED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your workflow execution has not exceeded the redrivable period of 14 days. Redrivable
        /// period refers to the time during which you can redrive a given execution. This period
        /// starts from the day a state machine completes its execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The workflow execution has not exceeded the maximum open time of one year. For more
        /// information about state machine quotas, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits-overview.html#service-limits-state-machine-executions">Quotas
        /// related to state machine executions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The execution event history count is less than 24,999. Redriven executions append
        /// their event history to the existing event history. Make sure your workflow execution
        /// contains less than 24,999 events to accommodate the <c>ExecutionRedriven</c> history
        /// event and at least one other history event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedriveExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RedriveExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionLimitExceededException">
        /// The maximum number of running executions has been reached. Running executions must
        /// end or be stopped before a new execution can be started.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionNotRedrivableException">
        /// The execution Amazon Resource Name (ARN) that you specified for <c>executionArn</c>
        /// cannot be redriven.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/RedriveExecution">REST API Reference for RedriveExecution Operation</seealso>
        Task<RedriveExecutionResponse> RedriveExecutionAsync(RedriveExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendTaskFailure



        /// <summary>
        /// Used by activity workers, Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern, and optionally Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> pattern to report that the task identified by the <c>taskToken</c> failed.
        /// 
        ///  
        /// <para>
        /// For an execution with encryption enabled, Step Functions will encrypt the error and
        /// cause fields using the KMS key for the execution role.
        /// </para>
        ///  
        /// <para>
        /// A caller can mark a task as fail without using any KMS permissions in the execution
        /// role if the caller provides a null value for both <c>error</c> and <c>cause</c> fields
        /// because no data needs to be encrypted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTaskFailure service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// The activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// The task token has either expired or the task associated with the token has already
        /// been closed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        Task<SendTaskFailureResponse> SendTaskFailureAsync(SendTaskFailureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendTaskHeartbeat



        /// <summary>
        /// Used by activity workers and Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern, and optionally Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> pattern to report to Step Functions that the task represented by the specified
        /// <c>taskToken</c> is still making progress. This action resets the <c>Heartbeat</c>
        /// clock. The <c>Heartbeat</c> threshold is specified in the state machine's Amazon States
        /// Language definition (<c>HeartbeatSeconds</c>). This action does not in itself create
        /// an event in the execution history. However, if the task times out, the execution history
        /// contains an <c>ActivityTimedOut</c> entry for activities, or a <c>TaskTimedOut</c>
        /// entry for tasks using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>Timeout</c> of a task, defined in the state machine's Amazon States Language
        /// definition, is its maximum allowed duration, regardless of the number of <a>SendTaskHeartbeat</a>
        /// requests received. Use <c>HeartbeatSeconds</c> to configure the timeout interval for
        /// heartbeats.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTaskHeartbeat service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// The activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// The task token has either expired or the task associated with the token has already
        /// been closed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        Task<SendTaskHeartbeatResponse> SendTaskHeartbeatAsync(SendTaskHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendTaskSuccess



        /// <summary>
        /// Used by activity workers, Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern, and optionally Task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> pattern to report that the task identified by the <c>taskToken</c> completed
        /// successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTaskSuccess service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidOutputException">
        /// The provided JSON output data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// The activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// The task token has either expired or the task associated with the token has already
        /// been closed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        Task<SendTaskSuccessResponse> SendTaskSuccessAsync(SendTaskSuccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartExecution



        /// <summary>
        /// Starts a state machine execution.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <c>mapStateLabel</c> in a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <c>ValidationException</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <c>PROD</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you start an execution with an unqualified state machine ARN, Step Functions uses
        /// the latest revision of the state machine for the execution.
        /// </para>
        ///  
        /// <para>
        /// To start executions of a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>,
        /// call <c>StartExecution</c> and provide the version ARN or the ARN of an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// that points to the version.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>StartExecution</c> is idempotent for <c>STANDARD</c> workflows. For a <c>STANDARD</c>
        /// workflow, if you call <c>StartExecution</c> with the same name and input as a running
        /// execution, the call succeeds and return the same response as the original request.
        /// If the execution is closed or if the input is different, it returns a <c>400 ExecutionAlreadyExists</c>
        /// error. You can reuse names after 90 days. 
        /// </para>
        ///  
        /// <para>
        ///  <c>StartExecution</c> isn't idempotent for <c>EXPRESS</c> workflows. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionAlreadyExistsException">
        /// The execution has the same <c>name</c> as another execution (but a different <c>input</c>).
        /// 
        ///  <note> 
        /// <para>
        /// Executions with the same <c>name</c> and <c>input</c> are considered idempotent.
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
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
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
        Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSyncExecution



        /// <summary>
        /// Starts a Synchronous Express state machine execution. <c>StartSyncExecution</c> is
        /// not available for <c>STANDARD</c> workflows.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>StartSyncExecution</c> will return a <c>200 OK</c> response, even if your execution
        /// fails, because the status code in the API response doesn't reflect function errors.
        /// Error codes are reserved for errors that prevent your execution from running, such
        /// as permissions errors, limit errors, or issues with your state machine code and configuration.
        /// 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This API action isn't logged in CloudTrail.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// State machine type is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        Task<StartSyncExecutionResponse> StartSyncExecutionAsync(StartSyncExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopExecution



        /// <summary>
        /// Stops an execution.
        /// 
        ///  
        /// <para>
        /// This API action is not supported by <c>EXPRESS</c> state machines.
        /// </para>
        ///  
        /// <para>
        /// For an execution with encryption enabled, Step Functions will encrypt the error and
        /// cause fields using the KMS key for the execution role.
        /// </para>
        ///  
        /// <para>
        /// A caller can stop an execution without using any KMS permissions in the execution
        /// role if the caller provides a null value for both <c>error</c> and <c>cause</c> fields
        /// because no data needs to be encrypted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsInvalidStateException">
        /// The KMS key is not in valid state, for example: Disabled or Deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        Task<StopExecutionResponse> StopExecutionAsync(StopExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <c>_
        /// . : / = + - @</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestState



        /// <summary>
        /// Accepts the definition of a single state and executes it. You can test a state without
        /// creating a state machine or updating an existing state machine. Using this API, you
        /// can test the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A state's <a href="https://docs.aws.amazon.com/step-functions/latest/dg/test-state-isolation.html#test-state-input-output-dataflow">input
        /// and output processing</a> data flow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-services.html">Amazon
        /// Web Services service integration</a> request and response
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/step-functions/latest/dg/call-https-apis.html">HTTP
        /// Task</a> request and response
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call this API on only one state at a time. The states that you can test include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-task-state.html#task-types">All
        /// Task types</a> except <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-activities.html">Activity</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-pass-state.html">Pass</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-wait-state.html">Wait</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-choice-state.html">Choice</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-succeed-state.html">Succeed</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-fail-state.html">Fail</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>TestState</c> API assumes an IAM role which must contain the required IAM permissions
        /// for the resources your state is accessing. For information about the permissions a
        /// state might need, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/test-state-isolation.html#test-state-permissions">IAM
        /// permissions to test a state</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>TestState</c> API can run for up to five minutes. If the execution of a state
        /// exceeds this duration, it fails with the <c>States.Timeout</c> error.
        /// </para>
        ///  
        /// <para>
        ///  <c>TestState</c> doesn't support <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-activities.html">Activity
        /// tasks</a>, <c>.sync</c> or <c>.waitForTaskToken</c> <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html">service
        /// integration patterns</a>, <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-parallel-state.html">Parallel</a>,
        /// or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/amazon-states-language-map-state.html">Map</a>
        /// states.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestState service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TestState">REST API Reference for TestState Operation</seealso>
        Task<TestStateResponse> TestStateAsync(TestStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Remove a tag from a Step Functions resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMapRun



        /// <summary>
        /// Updates an in-progress Map Run's configuration to include changes to the settings
        /// that control maximum concurrency and Map Run failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMapRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        Task<UpdateMapRunResponse> UpdateMapRunAsync(UpdateMapRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStateMachine



        /// <summary>
        /// Updates an existing state machine by modifying its <c>definition</c>, <c>roleArn</c>,
        /// <c>loggingConfiguration</c>, or <c>EncryptionConfiguration</c>. Running executions
        /// will continue to use the previous <c>definition</c> and <c>roleArn</c>. You must include
        /// at least one of <c>definition</c> or <c>roleArn</c> or you will receive a <c>MissingRequiredParameter</c>
        /// error.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <c>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</c>
        /// refers to a <i>Distributed Map state</i> with a label <c>mapStateLabel</c> in the
        /// state machine named <c>stateMachineName</c>.
        /// </para>
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <c>mapStateLabel</c> in a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <c>ValidationException</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <c>PROD</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <c>myStateMachine</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you update your state machine, you can set the <c>publish</c> parameter to <c>true</c>
        /// in the same action to publish a new <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
        /// This way, you can opt-in to strict versioning of your state machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// Step Functions assigns monotonically increasing integers for state machine versions,
        /// starting at version number 1.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// All <c>StartExecution</c> calls within a few seconds use the updated <c>definition</c>
        /// and <c>roleArn</c>. Executions started immediately after you call <c>UpdateStateMachine</c>
        /// may use the previous state machine <c>definition</c> and <c>roleArn</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidEncryptionConfigurationException">
        /// Received when <c>encryptionConfiguration</c> is specified but various conditions exist
        /// which make the configuration invalid. For example, if <c>type</c> is set to <c>CUSTOMER_MANAGED_KMS_KEY</c>,
        /// but <c>kmsKeyId</c> is null, or <c>kmsDataKeyReusePeriodSeconds</c> is not between
        /// 60 and 900, or the KMS key is not symmetric or inactive.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// Configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <c>tracingConfiguration</c> key does not match, or <c>enabled</c> has not been
        /// set to <c>true</c> or <c>false</c>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsAccessDeniedException">
        /// Either your KMS key policy or API caller does not have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.KmsThrottlingException">
        /// Received when KMS returns <c>ThrottlingException</c> for a KMS call that Step Functions
        /// makes on behalf of the caller.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.MissingRequiredParameterException">
        /// Request is missing a required parameter. This error occurs if both <c>definition</c>
        /// and <c>roleArn</c> are not specified.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
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
        Task<UpdateStateMachineResponse> UpdateStateMachineAsync(UpdateStateMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStateMachineAlias



        /// <summary>
        /// Updates the configuration of an existing state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// by modifying its <c>description</c> or <c>routingConfiguration</c>.
        /// 
        ///  
        /// <para>
        /// You must specify at least one of the <c>description</c> or <c>routingConfiguration</c>
        /// parameters to update a state machine alias.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>UpdateStateMachineAlias</c> is an idempotent API. Step Functions bases the idempotency
        /// check on the <c>stateMachineAliasArn</c>, <c>description</c>, and <c>routingConfiguration</c>
        /// parameters. Requests with the same parameters return an idempotent response.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This operation is eventually consistent. All <a>StartExecution</a> requests made within
        /// a few seconds use the latest alias configuration. Executions started immediately after
        /// calling <c>UpdateStateMachineAlias</c> may use the previous routing configuration.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachineAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <c>publish</c> parameter set to <c>true</c>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachineAlias">REST API Reference for UpdateStateMachineAlias Operation</seealso>
        Task<UpdateStateMachineAliasResponse> UpdateStateMachineAliasAsync(UpdateStateMachineAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateStateMachineDefinition



        /// <summary>
        /// Validates the syntax of a state machine definition specified in <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> (ASL), a JSON-based, structured language.
        /// 
        ///  
        /// <para>
        /// You can validate that a state machine definition is correct without creating a state
        /// machine resource.
        /// </para>
        ///  
        /// <para>
        /// Suggested uses for <c>ValidateStateMachineDefinition</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Integrate automated checks into your code review or Continuous Integration (CI) process
        /// to check state machine definitions before starting deployments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Run validation from a Git pre-commit hook to verify the definition before committing
        /// to your source repository.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Validation will look for problems in your state machine definition and return a <b>result</b>
        /// and a list of <b>diagnostic elements</b>.
        /// </para>
        ///  
        /// <para>
        /// The <b>result</b> value will be <c>OK</c> when your workflow definition can be successfully
        /// created or updated. Note the result can be <c>OK</c> even when diagnostic warnings
        /// are present in the response. The <b>result</b> value will be <c>FAIL</c> when the
        /// workflow definition contains errors that would prevent you from creating or updating
        /// your state machine. 
        /// </para>
        ///  
        /// <para>
        /// The list of <a href="https://docs.aws.amazon.com/step-functions/latest/apireference/API_ValidateStateMachineDefinitionDiagnostic.html">ValidateStateMachineDefinitionDiagnostic</a>
        /// data elements can contain zero or more <b>WARNING</b> and/or <b>ERROR</b> elements.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <b>ValidateStateMachineDefinition API</b> might add new diagnostics in the future,
        /// adjust diagnostic codes, or change the message wording. Your automated processes should
        /// only rely on the value of the <b>result</b> field value (OK, FAIL). Do <b>not</b>
        /// rely on the exact order, count, or wording of diagnostic messages.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateStateMachineDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateStateMachineDefinition service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ValidateStateMachineDefinition">REST API Reference for ValidateStateMachineDefinition Operation</seealso>
        Task<ValidateStateMachineDefinitionResponse> ValidateStateMachineDefinitionAsync(ValidateStateMachineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonStepFunctionsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonStepFunctionsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonStepFunctionsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonStepFunctionsConfig to create AmazonStepFunctionsClient");
            }

            return awsCredentials == null ? 
                    new AmazonStepFunctionsClient(serviceClientConfig) :
                    new AmazonStepFunctionsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
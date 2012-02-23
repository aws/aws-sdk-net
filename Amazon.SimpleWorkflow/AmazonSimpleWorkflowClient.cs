/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.SimpleWorkflow.Model;
using Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleWorkflow.
    ///  
    /// Amazon Simple Workflow Service <para> The Amazon Simple Workflow Service API Reference is intended for programmers who need detailed
    /// information about the Amazon SWF actions and data types. </para> <para> For an broader overview of the Amazon SWF programming model, please
    /// go to the Amazon SWF Developer Guide. </para> <para>This section provides an overview of Amazon SWF actions.</para> <para> <b>Action
    /// Categories</b> </para> <para>The Amazon SWF actions can be grouped into the following major categories.</para>
    /// <ul>
    /// <li> <para>Actions related to Activities</para> </li>
    /// <li> <para>Actions related to Deciders</para> </li>
    /// <li> <para>Actions related to Workflow Executions</para> </li>
    /// <li> <para>Actions related to Administration</para> </li>
    /// <li> <para>Actions related to Visibility</para> </li>
    /// 
    /// </ul>
    /// <para> <b>Actions related to Activities</b> </para> <para>The following are actions that are performed by activity workers:</para>
    /// <ul>
    /// <li> <para> PollForActivityTask </para> </li>
    /// <li> <para> RespondActivityTaskCompleted </para> </li>
    /// <li> <para> RespondActivityTaskFailed </para> </li>
    /// <li> <para> RespondActivityTaskCanceled </para> </li>
    /// <li> <para> RecordActivityTaskHeartbeat </para> </li>
    /// 
    /// </ul>
    /// <para>Activity workers use the PollForActivityTask to get new activity tasks. After a worker receives an activity task from Amazon SWF, it
    /// performs the task and responds using RespondActivityTaskCompleted if successful or RespondActivityTaskFailed if unsuccessful. </para> <para>
    /// <b>Actions related to Deciders</b> </para> <para>The following are actions that are performed by deciders:</para>
    /// <ul>
    /// <li> <para> PollForDecisionTask </para> </li>
    /// <li> <para> RespondDecisionTaskCompleted </para> </li>
    /// 
    /// </ul>
    /// <para>Deciders use PollForDecisionTask to get decision tasks. After a decider receives a decision task from Amazon SWF, it examines its
    /// workflow execution history and decides what to do next. It calls RespondDecisionTaskCompletedto complete the decision task and provide zero
    /// or more next decisions. </para> <para> <b>Actions related to Workflow Executions</b> </para> <para>The following actions operate on a
    /// workflow execution:</para>
    /// <ul>
    /// <li> <para> RequestCancelWorkflowExecution </para> </li>
    /// <li> <para> StartWorkflowExecution </para> </li>
    /// <li> <para> SignalWorkflowExecution </para> </li>
    /// <li> <para> TerminateWorkflowExecution </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Actions related to Administration</b> </para> <para>Although you can perform administrative tasks from the Amazon SWF console,
    /// you can use the actions in this section to automate functions or build your own administrative tools. </para> <para> <b>Activity
    /// Management</b> </para>
    /// <ul>
    /// <li> <para> RegisterActivityType </para> </li>
    /// <li> <para> DeprecateActivityType </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Management</b> </para>
    /// <ul>
    /// <li> <para> RegisterWorkflowType </para> </li>
    /// <li> <para> DeprecateWorkflowType </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Management</b> </para>
    /// <ul>
    /// <li> <para> RegisterDomain </para> </li>
    /// <li> <para> DeprecateDomain </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Management</b> </para>
    /// <ul>
    /// <li> <para> RequestCancelWorkflowExecution </para> </li>
    /// <li> <para> TerminateWorkflowExecution </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Visibility Actions</b> </para> <para>Although you can perform visibility actions from the Amazon SWF console, you can use the
    /// actions in this section to build your own console or administrative tools. </para>
    /// <ul>
    /// 
    /// </ul>
    /// <para> <b>Activity Visibility</b> </para>
    /// <ul>
    /// <li> <para> ListActivityTypes </para> </li>
    /// <li> <para> DescribeActivity </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Visibility</b> </para>
    /// <ul>
    /// <li> <para> ListWorkflowTypes </para> </li>
    /// <li> <para> DescribeWorkflowType </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Visibility</b> </para>
    /// <ul>
    /// <li> <para> DescribeWorkflowExecution </para> </li>
    /// <li> <para> ListOpenWorkflowExecutions </para> </li>
    /// <li> <para> ListClosedWorkflowExecutions </para> </li>
    /// <li> <para> CountOpenWorkflowExecutions </para> </li>
    /// <li> <para> CountClosedWorkflowExecutions </para> </li>
    /// <li> <para> GetWorkflowExecutionHistory </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Visibility</b> </para>
    /// <ul>
    /// <li> <para> ListDomains </para> </li>
    /// <li> <para> DescribeDomain </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Task List Visibility</b> </para>
    /// <ul>
    /// <li> <para> CountPendingActivityTasks </para> </li>
    /// <li> <para> CountPendingDecisionTasks </para> </li>
    /// 
    /// </ul>
    /// </summary>
    public class AmazonSimpleWorkflowClient : AmazonWebServiceClient, AmazonSimpleWorkflow
    {
    
        AbstractAWSSigner signer = new AWS3Signer();


        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleWorkflowClient()
            : base(new EnvironmentAWSCredentials(), new AmazonSimpleWorkflowConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSimpleWorkflow Configuration Object</param>
        public AmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials and an
        /// AmazonSimpleWorkflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

         /// <summary>
         /// <para> Deprecates the specified <i>workflow type</i> . After a workflow type has been deprecated, you cannot create new executions of that
         /// type. Executions that were started before the type was deprecated will continue to run. A deprecated workflow type may still be used when
         /// calling visibility actions. </para> <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not
         /// exactly reflect recent updates and changes. </para>
         /// </summary>
         /// 
         /// <param name="deprecateWorkflowTypeRequest">Container for the necessary parameters to execute the DeprecateWorkflowType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="TypeDeprecatedException"/>
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest deprecateWorkflowTypeRequest) 
        {
            IRequest<DeprecateWorkflowTypeRequest> request = new DeprecateWorkflowTypeRequestMarshaller().Marshall(deprecateWorkflowTypeRequest);
            DeprecateWorkflowTypeResponse response = Invoke<DeprecateWorkflowTypeRequest, DeprecateWorkflowTypeResponse> (request, this.signer, DeprecateWorkflowTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Deprecates the specified domain. After a domain has been deprecated it cannot be used to create new workflow executions or register
         /// new types. However, you can still use visibility actions on this domain. Deprecating a domain also deprecates all activity and workflow
         /// types registered in the domain. Executions that were started before the domain was deprecated will continue to run. </para>
         /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
         /// changes. </para>
         /// </summary>
         /// 
         /// <param name="deprecateDomainRequest">Container for the necessary parameters to execute the DeprecateDomain service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="DomainDeprecatedException"/>
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest deprecateDomainRequest) 
        {
            IRequest<DeprecateDomainRequest> request = new DeprecateDomainRequestMarshaller().Marshall(deprecateDomainRequest);
            DeprecateDomainResponse response = Invoke<DeprecateDomainRequest, DeprecateDomainResponse> (request, this.signer, DeprecateDomainResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Registers a new <i>workflow type</i> and its configuration settings in the specified domain. </para> <para><b>IMPORTANT:</b> If the
         /// type already exists, then a TypeAlreadyExists fault is returned. You cannot change the configuration settings of a workflow type once it is
         /// registered and it must be registered as a new version. </para>
         /// </summary>
         /// 
         /// <param name="registerWorkflowTypeRequest">Container for the necessary parameters to execute the RegisterWorkflowType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
         /// <exception cref="TypeAlreadyExistsException"/>
         /// <exception cref="LimitExceededException"/>
        public RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest registerWorkflowTypeRequest) 
        {
            IRequest<RegisterWorkflowTypeRequest> request = new RegisterWorkflowTypeRequestMarshaller().Marshall(registerWorkflowTypeRequest);
            RegisterWorkflowTypeResponse response = Invoke<RegisterWorkflowTypeRequest, RegisterWorkflowTypeResponse> (request, this.signer, RegisterWorkflowTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about workflow types in the specified domain. The results may be split into multiple pages that can be retrieved
         /// by making the call repeatedly. </para>
         /// </summary>
         /// 
         /// <param name="listWorkflowTypesRequest">Container for the necessary parameters to execute the ListWorkflowTypes service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the ListWorkflowTypes service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest listWorkflowTypesRequest) 
        {
            IRequest<ListWorkflowTypesRequest> request = new ListWorkflowTypesRequestMarshaller().Marshall(listWorkflowTypesRequest);
            ListWorkflowTypesResponse response = Invoke<ListWorkflowTypesRequest, ListWorkflowTypesResponse> (request, this.signer, ListWorkflowTypesResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Starts an execution of the workflow type in the specified domain using the provided <c>workflowId</c> and input data. </para> <para>
         /// This action returns the newly started workflow execution. </para>
         /// </summary>
         /// 
         /// <param name="startWorkflowExecutionRequest">Container for the necessary parameters to execute the StartWorkflowExecution service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the StartWorkflowExecution service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="TypeDeprecatedException"/>
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="DefaultUndefinedException"/>
         /// <exception cref="UnknownResourceException"/>
         /// <exception cref="WorkflowExecutionAlreadyStartedException"/>
         /// <exception cref="LimitExceededException"/>
        public StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest startWorkflowExecutionRequest) 
        {
            IRequest<StartWorkflowExecutionRequest> request = new StartWorkflowExecutionRequestMarshaller().Marshall(startWorkflowExecutionRequest);
            StartWorkflowExecutionResponse response = Invoke<StartWorkflowExecutionRequest, StartWorkflowExecutionResponse> (request, this.signer, StartWorkflowExecutionResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Records a <c>WorkflowExecutionSignaled</c> event in the workflow execution history and creates a decision task for the workflow
         /// execution identified by the given domain, workflowId and runId. The event is recorded with the specified user defined signalName and input
         /// (if provided). </para> <para><b>NOTE:</b> If a runId is not specified, then the WorkflowExecutionSignaled event is recorded in the history
         /// of the current open workflow with the matching workflowId in the domain. </para> <para><b>NOTE:</b> If the specified workflow execution is
         /// not open, this method fails with UnknownResource. </para>
         /// </summary>
         /// 
         /// <param name="signalWorkflowExecutionRequest">Container for the necessary parameters to execute the SignalWorkflowExecution service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest signalWorkflowExecutionRequest) 
        {
            IRequest<SignalWorkflowExecutionRequest> request = new SignalWorkflowExecutionRequestMarshaller().Marshall(signalWorkflowExecutionRequest);
            SignalWorkflowExecutionResponse response = Invoke<SignalWorkflowExecutionRequest, SignalWorkflowExecutionResponse> (request, this.signer, SignalWorkflowExecutionResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the list of domains registered in the account. The results may be split into multiple pages. To retrieve subsequent pages,
         /// make the call again using the nextPageToken returned by the initial call. </para> <para><b>NOTE:</b> This operation is eventually
         /// consistent. The results are best effort and may not exactly reflect recent updates and changes. </para>
         /// </summary>
         /// 
         /// <param name="listDomainsRequest">Container for the necessary parameters to execute the ListDomains service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest) 
        {
            IRequest<ListDomainsRequest> request = new ListDomainsRequestMarshaller().Marshall(listDomainsRequest);
            ListDomainsResponse response = Invoke<ListDomainsRequest, ListDomainsResponse> (request, this.signer, ListDomainsResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Records a <c>WorkflowExecutionCancelRequested</c> event in the currently running workflow execution identified by the given domain,
         /// workflowId, and runId. This logically requests the cancellation of the workflow execution as a whole. It is up to the decider to take
         /// appropriate actions when it receives an execution history with this event. </para> <para><b>NOTE:</b> If the runId is not specified, the
         /// WorkflowExecutionCancelRequested event is recorded in the history of the current open workflow execution with the specified workflowId in
         /// the domain. </para> <para><b>NOTE:</b> Because this action allows the workflow to properly clean up and gracefully close, it should be used
         /// instead of TerminateWorkflowExecution when possible. </para>
         /// </summary>
         /// 
         /// <param name="requestCancelWorkflowExecutionRequest">Container for the necessary parameters to execute the RequestCancelWorkflowExecution
         ///           service method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest requestCancelWorkflowExecutionRequest) 
        {
            IRequest<RequestCancelWorkflowExecutionRequest> request = new RequestCancelWorkflowExecutionRequestMarshaller().Marshall(requestCancelWorkflowExecutionRequest);
            RequestCancelWorkflowExecutionResponse response = Invoke<RequestCancelWorkflowExecutionRequest, RequestCancelWorkflowExecutionResponse> (request, this.signer, RequestCancelWorkflowExecutionResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about the specified <i>workflow type</i> . This includes configuration settings specified when the type was
         /// registered and other information such as creation date, current status, etc. </para>
         /// </summary>
         /// 
         /// <param name="describeWorkflowTypeRequest">Container for the necessary parameters to execute the DescribeWorkflowType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the DescribeWorkflowType service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest describeWorkflowTypeRequest) 
        {
            IRequest<DescribeWorkflowTypeRequest> request = new DescribeWorkflowTypeRequestMarshaller().Marshall(describeWorkflowTypeRequest);
            DescribeWorkflowTypeResponse response = Invoke<DescribeWorkflowTypeRequest, DescribeWorkflowTypeResponse> (request, this.signer, DescribeWorkflowTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Deprecates the specified <i>activity type</i> .
         /// After an activity type has been deprecated, you cannot create new tasks of that activity type. Tasks of this type that were scheduled
         /// before the type was deprecated will continue to run. </para> <para><b>NOTE:</b> This operation is eventually consistent. The results are
         /// best effort and may not exactly reflect recent updates and changes. </para>
         /// </summary>
         /// 
         /// <param name="deprecateActivityTypeRequest">Container for the necessary parameters to execute the DeprecateActivityType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="TypeDeprecatedException"/>
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest deprecateActivityTypeRequest) 
        {
            IRequest<DeprecateActivityTypeRequest> request = new DeprecateActivityTypeRequestMarshaller().Marshall(deprecateActivityTypeRequest);
            DeprecateActivityTypeResponse response = Invoke<DeprecateActivityTypeRequest, DeprecateActivityTypeResponse> (request, this.signer, DeprecateActivityTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the number of closed workflow executions within the given domain that meet the specified filtering criteria. </para>
         /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
         /// changes. </para>
         /// </summary>
         /// 
         /// <param name="countClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountClosedWorkflowExecutions
         ///           service method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest countClosedWorkflowExecutionsRequest) 
        {
            IRequest<CountClosedWorkflowExecutionsRequest> request = new CountClosedWorkflowExecutionsRequestMarshaller().Marshall(countClosedWorkflowExecutionsRequest);
            CountClosedWorkflowExecutionsResponse response = Invoke<CountClosedWorkflowExecutionsRequest, CountClosedWorkflowExecutionsResponse> (request, this.signer, CountClosedWorkflowExecutionsResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the estimated number of activity tasks in the specified task list. The count returned is an approximation and is not
         /// guaranteed to be exact. If you specify a task list that no activity task was ever scheduled in then 0 will be returned. </para>
         /// </summary>
         /// 
         /// <param name="countPendingActivityTasksRequest">Container for the necessary parameters to execute the CountPendingActivityTasks service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the CountPendingActivityTasks service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest countPendingActivityTasksRequest) 
        {
            IRequest<CountPendingActivityTasksRequest> request = new CountPendingActivityTasksRequestMarshaller().Marshall(countPendingActivityTasksRequest);
            CountPendingActivityTasksResponse response = Invoke<CountPendingActivityTasksRequest, CountPendingActivityTasksResponse> (request, this.signer, CountPendingActivityTasksResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> was successfully canceled. Additional
         /// <c>details</c> can be optionally provided using the <c>details</c> argument. </para> <para> These <c>details</c> (if provided) appear in the
         /// <c>ActivityTaskCanceled</c> event added to the workflow history. </para> <para><b>IMPORTANT:</b> Only use this operation if the canceled
         /// flag of a RecordActivityTaskHeartbeat request returns true and if the activity can be safely undone or abandoned. </para>
         /// </summary>
         /// 
         /// <param name="respondActivityTaskCanceledRequest">Container for the necessary parameters to execute the RespondActivityTaskCanceled service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest respondActivityTaskCanceledRequest) 
        {
            IRequest<RespondActivityTaskCanceledRequest> request = new RespondActivityTaskCanceledRequestMarshaller().Marshall(respondActivityTaskCanceledRequest);
            RespondActivityTaskCanceledResponse response = Invoke<RespondActivityTaskCanceledRequest, RespondActivityTaskCanceledResponse> (request, this.signer, RespondActivityTaskCanceledResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by deciders to tell the service that the DecisionTask identified by the <c>taskToken</c> has successfully completed. The
         /// <c>decisions</c> argument specifies the list of decisions made while processing the task. </para> <para> A
         /// <c>DecisionTaskCompleted</c> event is added to the workflow history. The <c>executionContext</c> specified is attached
         /// to the event in the workflow execution history. </para>
         /// </summary>
         /// 
         /// <param name="respondDecisionTaskCompletedRequest">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest respondDecisionTaskCompletedRequest) 
        {
            IRequest<RespondDecisionTaskCompletedRequest> request = new RespondDecisionTaskCompletedRequestMarshaller().Marshall(respondDecisionTaskCompletedRequest);
            RespondDecisionTaskCompletedResponse response = Invoke<RespondDecisionTaskCompletedRequest, RespondDecisionTaskCompletedResponse> (request, this.signer, RespondDecisionTaskCompletedResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> completed successfully with a
         /// <c>result</c> (if provided). </para> <para> The <c>result</c> appears in the <c>ActivityTaskCompleted</c> event in the workflow history.
         /// </para> <para><b>IMPORTANT:</b> If the requested task does not complete successfully, use RespondActivityTaskFailed instead. If the worker
         /// finds that the task is canceled through the canceled flag returned by RecordActivityTaskHeartbeat, it should cancel the task, clean up and
         /// then call RespondActivityTaskCanceled. </para>
         /// </summary>
         /// 
         /// <param name="respondActivityTaskCompletedRequest">Container for the necessary parameters to execute the RespondActivityTaskCompleted service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest respondActivityTaskCompletedRequest) 
        {
            IRequest<RespondActivityTaskCompletedRequest> request = new RespondActivityTaskCompletedRequestMarshaller().Marshall(respondActivityTaskCompletedRequest);
            RespondActivityTaskCompletedResponse response = Invoke<RespondActivityTaskCompletedRequest, RespondActivityTaskCompletedResponse> (request, this.signer, RespondActivityTaskCompletedResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by workers to get an ActivityTask from the specified activity <c>taskList</c> .
         /// This initiates a long poll, where the service holds the HTTP connection open and responds as soon as a task becomes available. The
         /// maximum time the service holds on to the request before responding is 60 seconds. If no task is available within 60 seconds, the poll will
         /// return an empty result. An empty result, in this context, means that an ActivityTask is returned, but that the value of taskToken is an
         /// empty string. If a task is returned, the worker should use its type to identify and process it correctly. </para> <para><b>IMPORTANT:</b>
         /// Workers should set their client side socket timeout to at least 70 seconds (10 seconds higher than the maximum time service may hold the
         /// poll request). </para>
         /// </summary>
         /// 
         /// <param name="pollForActivityTaskRequest">Container for the necessary parameters to execute the PollForActivityTask service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the PollForActivityTask service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest pollForActivityTaskRequest) 
        {
            IRequest<PollForActivityTaskRequest> request = new PollForActivityTaskRequestMarshaller().Marshall(pollForActivityTaskRequest);
            PollForActivityTaskResponse response = Invoke<PollForActivityTaskRequest, PollForActivityTaskResponse> (request, this.signer, PollForActivityTaskResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the number of open workflow executions within the given domain that meet the specified filtering criteria. </para>
         /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
         /// changes. </para>
         /// </summary>
         /// 
         /// <param name="countOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest countOpenWorkflowExecutionsRequest) 
        {
            IRequest<CountOpenWorkflowExecutionsRequest> request = new CountOpenWorkflowExecutionsRequestMarshaller().Marshall(countOpenWorkflowExecutionsRequest);
            CountOpenWorkflowExecutionsResponse response = Invoke<CountOpenWorkflowExecutionsRequest, CountOpenWorkflowExecutionsResponse> (request, this.signer, CountOpenWorkflowExecutionsResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about the specified activity type. This includes configuration settings provided at registration time as well as
         /// other general information about the type. </para>
         /// </summary>
         /// 
         /// <param name="describeActivityTypeRequest">Container for the necessary parameters to execute the DescribeActivityType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the DescribeActivityType service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest describeActivityTypeRequest) 
        {
            IRequest<DescribeActivityTypeRequest> request = new DescribeActivityTypeRequestMarshaller().Marshall(describeActivityTypeRequest);
            DescribeActivityTypeResponse response = Invoke<DescribeActivityTypeRequest, DescribeActivityTypeResponse> (request, this.signer, DescribeActivityTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns a list of open workflow executions in the specified domain that meet the filtering criteria. The results may be split into
         /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken returned by the initial call. </para>
         /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
         /// changes. </para>
         /// </summary>
         /// 
         /// <param name="listOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest listOpenWorkflowExecutionsRequest) 
        {
            IRequest<ListOpenWorkflowExecutionsRequest> request = new ListOpenWorkflowExecutionsRequestMarshaller().Marshall(listOpenWorkflowExecutionsRequest);
            ListOpenWorkflowExecutionsResponse response = Invoke<ListOpenWorkflowExecutionsRequest, ListOpenWorkflowExecutionsResponse> (request, this.signer, ListOpenWorkflowExecutionsResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the history of the specified workflow execution. The results may be split into multiple pages. To retrieve subsequent pages,
         /// make the call again using the <c>nextPageToken</c> returned by the initial call. </para> <para><b>NOTE:</b> This operation is eventually
         /// consistent. The results are best effort and may not exactly reflect recent updates and changes. </para>
         /// </summary>
         /// 
         /// <param name="getWorkflowExecutionHistoryRequest">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest getWorkflowExecutionHistoryRequest) 
        {
            IRequest<GetWorkflowExecutionHistoryRequest> request = new GetWorkflowExecutionHistoryRequestMarshaller().Marshall(getWorkflowExecutionHistoryRequest);
            GetWorkflowExecutionHistoryResponse response = Invoke<GetWorkflowExecutionHistoryRequest, GetWorkflowExecutionHistoryResponse> (request, this.signer, GetWorkflowExecutionHistoryResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Registers a new domain. </para>
         /// </summary>
         /// 
         /// <param name="registerDomainRequest">Container for the necessary parameters to execute the RegisterDomain service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="DomainAlreadyExistsException"/>
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="LimitExceededException"/>
        public RegisterDomainResponse RegisterDomain(RegisterDomainRequest registerDomainRequest) 
        {
            IRequest<RegisterDomainRequest> request = new RegisterDomainRequestMarshaller().Marshall(registerDomainRequest);
            RegisterDomainResponse response = Invoke<RegisterDomainRequest, RegisterDomainResponse> (request, this.signer, RegisterDomainResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Registers a new <i>activity type</i> along with its configuration settings in the specified domain. </para> <para><b>IMPORTANT:</b> A
         /// TypeAlreadyExists fault is returned if the type already exists in the domain. You cannot change any configuration settings of the type after
         /// its registration, and it must be registered as a new version. </para>
         /// </summary>
         /// 
         /// <param name="registerActivityTypeRequest">Container for the necessary parameters to execute the RegisterActivityType service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
         /// <exception cref="TypeAlreadyExistsException"/>
         /// <exception cref="LimitExceededException"/>
        public RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest registerActivityTypeRequest) 
        {
            IRequest<RegisterActivityTypeRequest> request = new RegisterActivityTypeRequestMarshaller().Marshall(registerActivityTypeRequest);
            RegisterActivityTypeResponse response = Invoke<RegisterActivityTypeRequest, RegisterActivityTypeResponse> (request, this.signer, RegisterActivityTypeResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns a list of closed workflow executions in the specified domain that meet the filtering criteria. The results may be split into
         /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken returned by the initial call. </para>
         /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
         /// changes. </para>
         /// </summary>
         /// 
         /// <param name="listClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest listClosedWorkflowExecutionsRequest) 
        {
            IRequest<ListClosedWorkflowExecutionsRequest> request = new ListClosedWorkflowExecutionsRequestMarshaller().Marshall(listClosedWorkflowExecutionsRequest);
            ListClosedWorkflowExecutionsResponse response = Invoke<ListClosedWorkflowExecutionsRequest, ListClosedWorkflowExecutionsResponse> (request, this.signer, ListClosedWorkflowExecutionsResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by activity workers to report to the service that the ActivityTask represented by the specified <c>taskToken</c> is still making
         /// progress. The worker can also (optionally) specify details of the progress, for example percent complete, using the <c>details</c>
         /// parameter. This action can also be used by the worker as a mechanism to check if cancellation is being requested for the activity task. If a
         /// cancellation is being attempted for the specified task, then the boolean <c>cancelRequested</c> flag returned by the service is set to
         /// <c>true</c> .
         /// </para> <para> This action resets the <c>taskHeartbeatTimeout</c> clock. The <c>taskHeartbeatTimeout</c> is specified in
         /// RegisterActivityType. </para> <para> This action does not in itself create an event in the workflow execution history. However, if the task
         /// times out, the workflow execution history will contain a <c>ActivityTaskTimedOut</c> event that contains the information from the last
         /// heartbeat generated by the activity worker. </para> <para><b>NOTE:</b> The taskStartToCloseTimeout of an activity type is the maximum
         /// duration of an activity task, regardless of the number of RecordActivityTaskHeartbeat requests received. The taskStartToCloseTimeout is also
         /// specified in RegisterActivityType. </para> <para><b>NOTE:</b> This operation is only useful for long-lived activities to report liveliness
         /// of the task and to determine if a cancellation is being attempted. </para> <para><b>IMPORTANT:</b> If the cancelRequested flag returns true,
         /// a cancellation is being attempted. If the worker can cancel the activity, it should respond with RespondActivityTaskCanceled. Otherwise, it
         /// should ignore the cancellation request. </para>
         /// </summary>
         /// 
         /// <param name="recordActivityTaskHeartbeatRequest">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest recordActivityTaskHeartbeatRequest) 
        {
            IRequest<RecordActivityTaskHeartbeatRequest> request = new RecordActivityTaskHeartbeatRequestMarshaller().Marshall(recordActivityTaskHeartbeatRequest);
            RecordActivityTaskHeartbeatResponse response = Invoke<RecordActivityTaskHeartbeatRequest, RecordActivityTaskHeartbeatResponse> (request, this.signer, RecordActivityTaskHeartbeatResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by deciders to get a DecisionTask from the specified decision <c>taskList</c> .
         /// A decision task may be returned for any open workflow execution that is using the specified task list. The task includes a paginated
         /// view of the history of the workflow execution. The decider should use the workflow type and the history to determine how to properly handle
         /// the task. </para> <para> This action initiates a long poll, where the service holds the HTTP connection open and responds as soon a task
         /// becomes available. If no decision task is available in the specified task list before the timeout of 60 seconds expires, an empty result is
         /// returned. An empty result, in this context, means that a DecisionTask is returned, but that the value of taskToken is an empty string.
         /// </para> <para><b>IMPORTANT:</b> Deciders should set their client side socket timeout to at least 70 seconds (10 seconds higher than the
         /// timeout). </para> <para><b>IMPORTANT:</b> Because the number of workflow history events for a single workflow execution might be very large,
         /// the result returned might be split up across a number of pages. To retrieve subsequent pages, make additional calls to PollForDecisionTask
         /// using the nextPageToken returned by the initial call. Note that you do not call GetWorkflowExecutionHistory with this nextPageToken.
         /// Instead, call PollForDecisionTask again. </para>
         /// </summary>
         /// 
         /// <param name="pollForDecisionTaskRequest">Container for the necessary parameters to execute the PollForDecisionTask service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the PollForDecisionTask service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest pollForDecisionTaskRequest) 
        {
            IRequest<PollForDecisionTaskRequest> request = new PollForDecisionTaskRequestMarshaller().Marshall(pollForDecisionTaskRequest);
            PollForDecisionTaskResponse response = Invoke<PollForDecisionTaskRequest, PollForDecisionTaskResponse> (request, this.signer, PollForDecisionTaskResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about all activities registered in the specified domain that match the specified name and registration status.
         /// The result includes information like creation date, current status of the activity, etc. The results may be split into multiple pages. To
         /// retrieve subsequent pages, make the call again using the <c>nextPageToken</c> returned by the initial call. </para>
         /// </summary>
         /// 
         /// <param name="listActivityTypesRequest">Container for the necessary parameters to execute the ListActivityTypes service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the ListActivityTypes service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest listActivityTypesRequest) 
        {
            IRequest<ListActivityTypesRequest> request = new ListActivityTypesRequestMarshaller().Marshall(listActivityTypesRequest);
            ListActivityTypesResponse response = Invoke<ListActivityTypesRequest, ListActivityTypesResponse> (request, this.signer, ListActivityTypesResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about the specified domain including description and status. </para>
         /// </summary>
         /// 
         /// <param name="describeDomainRequest">Container for the necessary parameters to execute the DescribeDomain service method on
         ///           AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the DescribeDomain service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest describeDomainRequest) 
        {
            IRequest<DescribeDomainRequest> request = new DescribeDomainRequestMarshaller().Marshall(describeDomainRequest);
            DescribeDomainResponse response = Invoke<DescribeDomainRequest, DescribeDomainResponse> (request, this.signer, DescribeDomainResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> has failed with <c>reason</c> (if
         /// specified). </para> <para> The <c>reason</c> and <c>details</c> appear in the <c>ActivityTaskFailed</c> event added to the workflow history.
         /// </para>
         /// </summary>
         /// 
         /// <param name="respondActivityTaskFailedRequest">Container for the necessary parameters to execute the RespondActivityTaskFailed service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest respondActivityTaskFailedRequest) 
        {
            IRequest<RespondActivityTaskFailedRequest> request = new RespondActivityTaskFailedRequestMarshaller().Marshall(respondActivityTaskFailedRequest);
            RespondActivityTaskFailedResponse response = Invoke<RespondActivityTaskFailedRequest, RespondActivityTaskFailedResponse> (request, this.signer, RespondActivityTaskFailedResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns the estimated number of decision tasks in the specified task list. The count returned is an approximation and is not
         /// guaranteed to be exact. If you specify a task list that no decision task was ever scheduled in then 0 will be returned. </para>
         /// </summary>
         /// 
         /// <param name="countPendingDecisionTasksRequest">Container for the necessary parameters to execute the CountPendingDecisionTasks service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the CountPendingDecisionTasks service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest countPendingDecisionTasksRequest) 
        {
            IRequest<CountPendingDecisionTasksRequest> request = new CountPendingDecisionTasksRequestMarshaller().Marshall(countPendingDecisionTasksRequest);
            CountPendingDecisionTasksResponse response = Invoke<CountPendingDecisionTasksRequest, CountPendingDecisionTasksResponse> (request, this.signer, CountPendingDecisionTasksResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Records a <c>WorkflowExecutionTerminated</c> event and forces closure of the workflow execution identified by the given domain,
         /// runId, and workflowId. The child policy, registered with the workflow type or specified when starting this execution, is applied to any open
         /// child workflow executions of this workflow execution. </para> <para><b>IMPORTANT:</b> If the identified workflow execution was in progress,
         /// it is terminated immediately. </para> <para><b>NOTE:</b> If a runId is not specified, then the WorkflowExecutionTerminated event is recorded
         /// in the history of the current open workflow with the matching workflowId in the domain. </para> <para><b>NOTE:</b> You should consider using
         /// RequestCancelWorkflowExecution action instead because it allows the workflow to gracefully close while TerminateWorkflowExecution does not.
         /// </para>
         /// </summary>
         /// 
         /// <param name="terminateWorkflowExecutionRequest">Container for the necessary parameters to execute the TerminateWorkflowExecution service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest terminateWorkflowExecutionRequest) 
        {
            IRequest<TerminateWorkflowExecutionRequest> request = new TerminateWorkflowExecutionRequestMarshaller().Marshall(terminateWorkflowExecutionRequest);
            TerminateWorkflowExecutionResponse response = Invoke<TerminateWorkflowExecutionRequest, TerminateWorkflowExecutionResponse> (request, this.signer, TerminateWorkflowExecutionResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para> Returns information about the specified workflow execution including its type and some statistics. </para> <para><b>NOTE:</b> This
         /// operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and changes. </para>
         /// </summary>
         /// 
         /// <param name="describeWorkflowExecutionRequest">Container for the necessary parameters to execute the DescribeWorkflowExecution service
         ///           method on AmazonSimpleWorkflow.</param>
         /// 
         /// <returns>The response from the DescribeWorkflowExecution service method, as returned by AmazonSimpleWorkflow.</returns>
         /// 
         /// <exception cref="OperationNotPermittedException"/>
         /// <exception cref="UnknownResourceException"/>
        public DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest describeWorkflowExecutionRequest) 
        {
            IRequest<DescribeWorkflowExecutionRequest> request = new DescribeWorkflowExecutionRequestMarshaller().Marshall(describeWorkflowExecutionRequest);
            DescribeWorkflowExecutionResponse response = Invoke<DescribeWorkflowExecutionRequest, DescribeWorkflowExecutionResponse> (request, this.signer, DescribeWorkflowExecutionResponseUnmarshaller.GetInstance());
            return response;
        }
        
    }
}
    

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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleWorkflow.Model;

namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Interface for accessing SimpleWorkflow
    ///
    /// Amazon Simple Workflow Service 
    /// <para>
    ///  The Amazon Simple Workflow Service API Reference is intended for programmers who
    /// need detailed information about the Amazon SWF actions and data types. 
    /// </para>
    ///  
    /// <para>
    ///  For an broader overview of the Amazon SWF programming model, please go to the <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/">Amazon SWF Developer
    /// Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// This section provides an overview of Amazon SWF actions.
    /// </para>
    ///  
    /// <para>
    /// <b>Action Categories</b>
    /// </para>
    ///  
    /// <para>
    /// The Amazon SWF actions can be grouped into the following major categories.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Actions related to Activities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions related to Deciders
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions related to Workflow Executions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions related to Administration
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions related to Visibility
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Actions related to Activities</b>
    /// </para>
    ///  
    /// <para>
    /// The following are actions that are performed by activity workers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_PollForActivityTask.html" title="PollForActivityTask">PollForActivityTask</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_RespondActivityTaskCompleted.html" title="RespondActivityTaskCompleted">RespondActivityTaskCompleted</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_RespondActivityTaskFailed.html" title="RespondActivityTaskFailed">RespondActivityTaskFailed</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_RespondActivityTaskCanceled.html" title="RespondActivityTaskCanceled">RespondActivityTaskCanceled</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_RecordActivityTaskHeartbeat.html" title="RecordActivityTaskHeartbeat">RecordActivityTaskHeartbeat</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Activity workers use the <a href="API_PollForActivityTask.html" title="PollForActivityTask">PollForActivityTask</a>
    /// to get new activity tasks. After a worker receives an activity task from Amazon SWF,
    /// it performs the task and responds using <a href="API_RespondActivityTaskCompleted.html"
    /// title="RespondActivityTaskCompleted">RespondActivityTaskCompleted</a> if successful
    /// or <a href="API_RespondActivityTaskFailed.html" title="RespondActivityTaskFailed">RespondActivityTaskFailed</a>
    /// if unsuccessful. 
    /// </para>
    ///  
    /// <para>
    /// <b>Actions related to Deciders</b>
    /// </para>
    ///  
    /// <para>
    /// The following are actions that are performed by deciders:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_PollForDecisionTask.html" title="PollForDecisionTask">PollForDecisionTask</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_RespondDecisionTaskCompleted.html" title="RespondDecisionTaskCompleted">RespondDecisionTaskCompleted</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Deciders use <a href="API_PollForDecisionTask.html" title="PollForDecisionTask">PollForDecisionTask</a>
    /// to get decision tasks. After a decider receives a decision task from Amazon SWF, it
    /// examines its workflow execution history and decides what to do next. It calls <a href="API_RespondDecisionTaskCompleted.html"
    /// title="RespondDecisionTaskCompleted">RespondDecisionTaskCompleted</a>to complete the
    /// decision task and provide zero or more next decisions. 
    /// </para>
    ///  
    /// <para>
    /// <b>Actions related to Workflow Executions</b>
    /// </para>
    ///  
    /// <para>
    /// The following actions operate on a workflow execution:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_RequestCancelWorkflowExecution.html" title="RequestCancelWorkflowExecution">RequestCancelWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_StartWorkflowExecution.html" title="StartWorkflowExecution">StartWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_SignalWorkflowExecution.html" title="SignalWorkflowExecution">SignalWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_TerminateWorkflowExecution.html" title="TerminateWorkflowExecution">TerminateWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Actions related to Administration</b>
    /// </para>
    ///  
    /// <para>
    /// Although you can perform administrative tasks from the Amazon SWF console, you can
    /// use the actions in this section to automate functions or build your own administrative
    /// tools. 
    /// </para>
    ///  
    /// <para>
    /// <b>Activity Management</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_RegisterActivityType.html" title="RegisterActivityType">RegisterActivityType</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DeprecateActivityType.html" title="DeprecateActivityType">DeprecateActivityType</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Workflow Management</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_RegisterWorkflowType.html" title="RegisterWorkflowType">RegisterWorkflowType</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DeprecateWorkflowType.html" title="DeprecateWorkflowType">DeprecateWorkflowType</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Domain Management</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_RegisterDomain.html" title="RegisterDomain">RegisterDomain</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DeprecateDomain.html" title="DeprecateDomain">DeprecateDomain</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Workflow Execution Management</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_RequestCancelWorkflowExecution.html" title="RequestCancelWorkflowExecution">RequestCancelWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_TerminateWorkflowExecution.html" title="TerminateWorkflowExecution">TerminateWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Visibility Actions</b>
    /// </para>
    ///  
    /// <para>
    /// Although you can perform visibility actions from the Amazon SWF console, you can use
    /// the actions in this section to build your own console or administrative tools. 
    /// </para>
    ///  <ul> </ul> 
    /// <para>
    /// <b>Activity Visibility</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_ListActivityTypes.html" title="ListActivities">ListActivityTypes</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DescribeActivityType.html" title="DescribeActivityType">DescribeActivity</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Workflow Visibility</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_ListWorkflowTypes.html" title="ListWorkflowTypes">ListWorkflowTypes</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DescribeWorkflowType.html" title="DescribeWorkflowType">DescribeWorkflowType</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Workflow Execution Visibility</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_DescribeWorkflowExecution.html" title="DescribeWorkflowExecution">DescribeWorkflowExecution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_ListOpenWorkflowExecutions.html" title="ListOpenWorkflowExecutions">ListOpenWorkflowExecutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_ListClosedWorkflowExecutions.html" title="ListClosedWorkflowExecutions">ListClosedWorkflowExecutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_CountOpenWorkflowExecutions.html" title="CountOpenWorkflowExecutions">CountOpenWorkflowExecutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_CountClosedWorkflowExecutions.html" title="CountClosedWorkflowExecutions">CountClosedWorkflowExecutions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_GetWorkflowExecutionHistory.html" title="GetWorkflowExecutionHistory">GetWorkflowExecutionHistory</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Domain Visibility</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_ListDomains.html" title="ListDomains">ListDomains</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_DescribeDomain.html" title="DescribeDomain">DescribeDomain</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// <b>Task List Visibility</b>
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="API_CountPendingActivityTasks.html" title="CountPendingActivityTasks">CountPendingActivityTasks</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="API_CountPendingDecisionTasks.html" title="CountPendingDecisionTasks">CountPendingDecisionTasks</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSimpleWorkflow : IDisposable
    {
                
        #region  CountClosedWorkflowExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CountClosedWorkflowExecutionsResponse> CountClosedWorkflowExecutionsAsync(CountClosedWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CountOpenWorkflowExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CountOpenWorkflowExecutionsResponse> CountOpenWorkflowExecutionsAsync(CountOpenWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CountPendingActivityTasks


        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingActivityTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CountPendingActivityTasksResponse> CountPendingActivityTasksAsync(CountPendingActivityTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CountPendingDecisionTasks


        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingDecisionTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CountPendingDecisionTasksResponse> CountPendingDecisionTasksAsync(CountPendingDecisionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprecateActivityType


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeprecateActivityTypeResponse> DeprecateActivityTypeAsync(DeprecateActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprecateDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeprecateDomainResponse> DeprecateDomainAsync(DeprecateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprecateWorkflowType


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeprecateWorkflowTypeResponse> DeprecateWorkflowTypeAsync(DeprecateWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeActivityType


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeActivityTypeResponse> DescribeActivityTypeAsync(DescribeActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomain


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkflowExecution


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeWorkflowExecutionResponse> DescribeWorkflowExecutionAsync(DescribeWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkflowType


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeWorkflowTypeResponse> DescribeWorkflowTypeAsync(DescribeWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkflowExecutionHistory


        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetWorkflowExecutionHistoryResponse> GetWorkflowExecutionHistoryAsync(GetWorkflowExecutionHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListActivityTypes


        /// <summary>
        /// Initiates the asynchronous execution of the ListActivityTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListActivityTypesResponse> ListActivityTypesAsync(ListActivityTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClosedWorkflowExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListClosedWorkflowExecutionsResponse> ListClosedWorkflowExecutionsAsync(ListClosedWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOpenWorkflowExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListOpenWorkflowExecutionsResponse> ListOpenWorkflowExecutionsAsync(ListOpenWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkflowTypes


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListWorkflowTypesResponse> ListWorkflowTypesAsync(ListWorkflowTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PollForActivityTask


        /// <summary>
        /// Initiates the asynchronous execution of the PollForActivityTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForActivityTaskResponse> PollForActivityTaskAsync(PollForActivityTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PollForDecisionTask


        /// <summary>
        /// Initiates the asynchronous execution of the PollForDecisionTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PollForDecisionTaskResponse> PollForDecisionTaskAsync(PollForDecisionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RecordActivityTaskHeartbeat


        /// <summary>
        /// Initiates the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RecordActivityTaskHeartbeatResponse> RecordActivityTaskHeartbeatAsync(RecordActivityTaskHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterActivityType


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterActivityTypeResponse> RegisterActivityTypeAsync(RegisterActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterDomain


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterWorkflowType


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterWorkflowTypeResponse> RegisterWorkflowTypeAsync(RegisterWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RequestCancelWorkflowExecution


        /// <summary>
        /// Initiates the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RequestCancelWorkflowExecutionResponse> RequestCancelWorkflowExecutionAsync(RequestCancelWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RespondActivityTaskCanceled


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RespondActivityTaskCanceledResponse> RespondActivityTaskCanceledAsync(RespondActivityTaskCanceledRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RespondActivityTaskCompleted


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RespondActivityTaskCompletedResponse> RespondActivityTaskCompletedAsync(RespondActivityTaskCompletedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RespondActivityTaskFailed


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskFailed operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RespondActivityTaskFailedResponse> RespondActivityTaskFailedAsync(RespondActivityTaskFailedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RespondDecisionTaskCompleted


        /// <summary>
        /// Initiates the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RespondDecisionTaskCompletedResponse> RespondDecisionTaskCompletedAsync(RespondDecisionTaskCompletedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SignalWorkflowExecution


        /// <summary>
        /// Initiates the asynchronous execution of the SignalWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SignalWorkflowExecutionResponse> SignalWorkflowExecutionAsync(SignalWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartWorkflowExecution


        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateWorkflowExecution


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateWorkflowExecutionResponse> TerminateWorkflowExecutionAsync(TerminateWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SimpleWorkflow.Model;
using Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Implementation for accessing SimpleWorkflow
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
    public partial class AmazonSimpleWorkflowClient : AmazonServiceClient, IAmazonSimpleWorkflow
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials and an
        /// AmazonSimpleWorkflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CountClosedWorkflowExecutions

        internal CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request)
        {
            var marshaller = new CountClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountClosedWorkflowExecutionsRequest,CountClosedWorkflowExecutionsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CountClosedWorkflowExecutionsResponse> CountClosedWorkflowExecutionsAsync(CountClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<CountClosedWorkflowExecutionsRequest,CountClosedWorkflowExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CountOpenWorkflowExecutions

        internal CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request)
        {
            var marshaller = new CountOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountOpenWorkflowExecutionsRequest,CountOpenWorkflowExecutionsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CountOpenWorkflowExecutionsResponse> CountOpenWorkflowExecutionsAsync(CountOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<CountOpenWorkflowExecutionsRequest,CountOpenWorkflowExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CountPendingActivityTasks

        internal CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request)
        {
            var marshaller = new CountPendingActivityTasksRequestMarshaller();
            var unmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingActivityTasksRequest,CountPendingActivityTasksResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CountPendingActivityTasksResponse> CountPendingActivityTasksAsync(CountPendingActivityTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountPendingActivityTasksRequestMarshaller();
            var unmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return InvokeAsync<CountPendingActivityTasksRequest,CountPendingActivityTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CountPendingDecisionTasks

        internal CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request)
        {
            var marshaller = new CountPendingDecisionTasksRequestMarshaller();
            var unmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingDecisionTasksRequest,CountPendingDecisionTasksResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<CountPendingDecisionTasksResponse> CountPendingDecisionTasksAsync(CountPendingDecisionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountPendingDecisionTasksRequestMarshaller();
            var unmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<CountPendingDecisionTasksRequest,CountPendingDecisionTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeprecateActivityType

        internal DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request)
        {
            var marshaller = new DeprecateActivityTypeRequestMarshaller();
            var unmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateActivityTypeRequest,DeprecateActivityTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeprecateActivityTypeResponse> DeprecateActivityTypeAsync(DeprecateActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateActivityTypeRequestMarshaller();
            var unmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateActivityTypeRequest,DeprecateActivityTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeprecateDomain

        internal DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request)
        {
            var marshaller = new DeprecateDomainRequestMarshaller();
            var unmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return Invoke<DeprecateDomainRequest,DeprecateDomainResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeprecateDomainResponse> DeprecateDomainAsync(DeprecateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateDomainRequestMarshaller();
            var unmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateDomainRequest,DeprecateDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeprecateWorkflowType

        internal DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request)
        {
            var marshaller = new DeprecateWorkflowTypeRequestMarshaller();
            var unmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateWorkflowTypeRequest,DeprecateWorkflowTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DeprecateWorkflowTypeResponse> DeprecateWorkflowTypeAsync(DeprecateWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateWorkflowTypeRequestMarshaller();
            var unmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateWorkflowTypeRequest,DeprecateWorkflowTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivityType

        internal DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request)
        {
            var marshaller = new DescribeActivityTypeRequestMarshaller();
            var unmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeActivityTypeRequest,DescribeActivityTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DescribeActivityTypeResponse> DescribeActivityTypeAsync(DescribeActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeActivityTypeRequestMarshaller();
            var unmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivityTypeRequest,DescribeActivityTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain

        internal DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var marshaller = new DescribeDomainRequestMarshaller();
            var unmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainRequest,DescribeDomainResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDomainRequestMarshaller();
            var unmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainRequest,DescribeDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowExecution

        internal DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request)
        {
            var marshaller = new DescribeWorkflowExecutionRequestMarshaller();
            var unmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowExecutionRequest,DescribeWorkflowExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DescribeWorkflowExecutionResponse> DescribeWorkflowExecutionAsync(DescribeWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkflowExecutionRequestMarshaller();
            var unmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkflowExecutionRequest,DescribeWorkflowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowType

        internal DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request)
        {
            var marshaller = new DescribeWorkflowTypeRequestMarshaller();
            var unmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowTypeRequest,DescribeWorkflowTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<DescribeWorkflowTypeResponse> DescribeWorkflowTypeAsync(DescribeWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkflowTypeRequestMarshaller();
            var unmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkflowTypeRequest,DescribeWorkflowTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowExecutionHistory

        internal GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request)
        {
            var marshaller = new GetWorkflowExecutionHistoryRequestMarshaller();
            var unmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowExecutionHistoryRequest,GetWorkflowExecutionHistoryResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<GetWorkflowExecutionHistoryResponse> GetWorkflowExecutionHistoryAsync(GetWorkflowExecutionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetWorkflowExecutionHistoryRequestMarshaller();
            var unmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowExecutionHistoryRequest,GetWorkflowExecutionHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListActivityTypes

        internal ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request)
        {
            var marshaller = new ListActivityTypesRequestMarshaller();
            var unmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return Invoke<ListActivityTypesRequest,ListActivityTypesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListActivityTypesResponse> ListActivityTypesAsync(ListActivityTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListActivityTypesRequestMarshaller();
            var unmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActivityTypesRequest,ListActivityTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListClosedWorkflowExecutions

        internal ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request)
        {
            var marshaller = new ListClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListClosedWorkflowExecutionsRequest,ListClosedWorkflowExecutionsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListClosedWorkflowExecutionsResponse> ListClosedWorkflowExecutionsAsync(ListClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListClosedWorkflowExecutionsRequest,ListClosedWorkflowExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsRequest,ListDomainsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsRequest,ListDomainsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOpenWorkflowExecutions

        internal ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request)
        {
            var marshaller = new ListOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListOpenWorkflowExecutionsRequest,ListOpenWorkflowExecutionsResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListOpenWorkflowExecutionsResponse> ListOpenWorkflowExecutionsAsync(ListOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpenWorkflowExecutionsRequest,ListOpenWorkflowExecutionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflowTypes

        internal ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request)
        {
            var marshaller = new ListWorkflowTypesRequestMarshaller();
            var unmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowTypesRequest,ListWorkflowTypesResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<ListWorkflowTypesResponse> ListWorkflowTypesAsync(ListWorkflowTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListWorkflowTypesRequestMarshaller();
            var unmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowTypesRequest,ListWorkflowTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForActivityTask

        internal PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request)
        {
            var marshaller = new PollForActivityTaskRequestMarshaller();
            var unmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return Invoke<PollForActivityTaskRequest,PollForActivityTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<PollForActivityTaskResponse> PollForActivityTaskAsync(PollForActivityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForActivityTaskRequestMarshaller();
            var unmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForActivityTaskRequest,PollForActivityTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PollForDecisionTask

        internal PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request)
        {
            var marshaller = new PollForDecisionTaskRequestMarshaller();
            var unmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return Invoke<PollForDecisionTaskRequest,PollForDecisionTaskResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<PollForDecisionTaskResponse> PollForDecisionTaskAsync(PollForDecisionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForDecisionTaskRequestMarshaller();
            var unmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForDecisionTaskRequest,PollForDecisionTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RecordActivityTaskHeartbeat

        internal RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request)
        {
            var marshaller = new RecordActivityTaskHeartbeatRequestMarshaller();
            var unmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordActivityTaskHeartbeatRequest,RecordActivityTaskHeartbeatResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RecordActivityTaskHeartbeatResponse> RecordActivityTaskHeartbeatAsync(RecordActivityTaskHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RecordActivityTaskHeartbeatRequestMarshaller();
            var unmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<RecordActivityTaskHeartbeatRequest,RecordActivityTaskHeartbeatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterActivityType

        internal RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request)
        {
            var marshaller = new RegisterActivityTypeRequestMarshaller();
            var unmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterActivityTypeRequest,RegisterActivityTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RegisterActivityTypeResponse> RegisterActivityTypeAsync(RegisterActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterActivityTypeRequestMarshaller();
            var unmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterActivityTypeRequest,RegisterActivityTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain

        internal RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDomainRequest,RegisterDomainResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterWorkflowType

        internal RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request)
        {
            var marshaller = new RegisterWorkflowTypeRequestMarshaller();
            var unmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterWorkflowTypeRequest,RegisterWorkflowTypeResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RegisterWorkflowTypeResponse> RegisterWorkflowTypeAsync(RegisterWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterWorkflowTypeRequestMarshaller();
            var unmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterWorkflowTypeRequest,RegisterWorkflowTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestCancelWorkflowExecution

        internal RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request)
        {
            var marshaller = new RequestCancelWorkflowExecutionRequestMarshaller();
            var unmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<RequestCancelWorkflowExecutionRequest,RequestCancelWorkflowExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RequestCancelWorkflowExecutionResponse> RequestCancelWorkflowExecutionAsync(RequestCancelWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestCancelWorkflowExecutionRequestMarshaller();
            var unmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<RequestCancelWorkflowExecutionRequest,RequestCancelWorkflowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCanceled

        internal RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request)
        {
            var marshaller = new RespondActivityTaskCanceledRequestMarshaller();
            var unmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCanceledRequest,RespondActivityTaskCanceledResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RespondActivityTaskCanceledResponse> RespondActivityTaskCanceledAsync(RespondActivityTaskCanceledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskCanceledRequestMarshaller();
            var unmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskCanceledRequest,RespondActivityTaskCanceledResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCompleted

        internal RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request)
        {
            var marshaller = new RespondActivityTaskCompletedRequestMarshaller();
            var unmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCompletedRequest,RespondActivityTaskCompletedResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RespondActivityTaskCompletedResponse> RespondActivityTaskCompletedAsync(RespondActivityTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskCompletedRequestMarshaller();
            var unmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskCompletedRequest,RespondActivityTaskCompletedResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskFailed

        internal RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request)
        {
            var marshaller = new RespondActivityTaskFailedRequestMarshaller();
            var unmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskFailedRequest,RespondActivityTaskFailedResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RespondActivityTaskFailedResponse> RespondActivityTaskFailedAsync(RespondActivityTaskFailedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskFailedRequestMarshaller();
            var unmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskFailedRequest,RespondActivityTaskFailedResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RespondDecisionTaskCompleted

        internal RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request)
        {
            var marshaller = new RespondDecisionTaskCompletedRequestMarshaller();
            var unmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondDecisionTaskCompletedRequest,RespondDecisionTaskCompletedResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<RespondDecisionTaskCompletedResponse> RespondDecisionTaskCompletedAsync(RespondDecisionTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondDecisionTaskCompletedRequestMarshaller();
            var unmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondDecisionTaskCompletedRequest,RespondDecisionTaskCompletedResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SignalWorkflowExecution

        internal SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request)
        {
            var marshaller = new SignalWorkflowExecutionRequestMarshaller();
            var unmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<SignalWorkflowExecutionRequest,SignalWorkflowExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<SignalWorkflowExecutionResponse> SignalWorkflowExecutionAsync(SignalWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SignalWorkflowExecutionRequestMarshaller();
            var unmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<SignalWorkflowExecutionRequest,SignalWorkflowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartWorkflowExecution

        internal StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request)
        {
            var marshaller = new StartWorkflowExecutionRequestMarshaller();
            var unmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowExecutionRequest,StartWorkflowExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartWorkflowExecutionRequestMarshaller();
            var unmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartWorkflowExecutionRequest,StartWorkflowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkflowExecution

        internal TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request)
        {
            var marshaller = new TerminateWorkflowExecutionRequestMarshaller();
            var unmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkflowExecutionRequest,TerminateWorkflowExecutionResponse>(request, marshaller, unmarshaller);
        }

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
        public Task<TerminateWorkflowExecutionResponse> TerminateWorkflowExecutionAsync(TerminateWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateWorkflowExecutionRequestMarshaller();
            var unmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateWorkflowExecutionRequest,TerminateWorkflowExecutionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
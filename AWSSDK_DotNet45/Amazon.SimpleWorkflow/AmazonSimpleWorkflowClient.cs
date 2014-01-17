/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading.Tasks;

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
    /// go to the <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/">Amazon SWF Developer Guide</a> .
    /// </para> <para>This section provides an overview of Amazon SWF actions.</para> <para> <b>Action Categories</b> </para> <para>The Amazon SWF
    /// actions can be grouped into the following major categories.</para>
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
    /// <li> <para> <a href="API_PollForActivityTask.html">PollForActivityTask</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskCompleted.html">RespondActivityTaskCompleted</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskFailed.html">RespondActivityTaskFailed</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskCanceled.html">RespondActivityTaskCanceled</a> </para> </li>
    /// <li> <para> <a href="API_RecordActivityTaskHeartbeat.html">RecordActivityTaskHeartbeat</a> </para> </li>
    /// 
    /// </ul>
    /// <para>Activity workers use the <a href="API_PollForActivityTask.html">PollForActivityTask</a> to get new activity tasks. After a worker
    /// receives an activity task from Amazon SWF, it performs the task and responds using <a href="API_RespondActivityTaskCompleted.html">RespondActivityTaskCompleted</a> if successful or <a href="API_RespondActivityTaskFailed.html">RespondActivityTaskFailed</a> if
    /// unsuccessful. </para> <para> <b>Actions related to Deciders</b> </para> <para>The following are actions that are performed by
    /// deciders:</para>
    /// <ul>
    /// <li> <para> <a href="API_PollForDecisionTask.html">PollForDecisionTask</a> </para> </li>
    /// <li> <para> <a href="API_RespondDecisionTaskCompleted.html">RespondDecisionTaskCompleted</a> </para> </li>
    /// 
    /// </ul>
    /// <para>Deciders use <a href="API_PollForDecisionTask.html">PollForDecisionTask</a> to get decision tasks. After a decider receives a
    /// decision task from Amazon SWF, it examines its workflow execution history and decides what to do next. It calls <a href="API_RespondDecisionTaskCompleted.html">RespondDecisionTaskCompleted</a> to complete the decision task and provide zero or more next
    /// decisions. </para> <para> <b>Actions related to Workflow Executions</b> </para> <para>The following actions operate on a workflow
    /// execution:</para>
    /// <ul>
    /// <li> <para> <a href="API_RequestCancelWorkflowExecution.html">RequestCancelWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_StartWorkflowExecution.html">StartWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_SignalWorkflowExecution.html">SignalWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_TerminateWorkflowExecution.html">TerminateWorkflowExecution</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Actions related to Administration</b> </para> <para>Although you can perform administrative tasks from the Amazon SWF console,
    /// you can use the actions in this section to automate functions or build your own administrative tools. </para> <para> <b>Activity
    /// Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterActivityType.html">RegisterActivityType</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateActivityType.html">DeprecateActivityType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterWorkflowType.html">RegisterWorkflowType</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateWorkflowType.html">DeprecateWorkflowType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterDomain.html">RegisterDomain</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateDomain.html">DeprecateDomain</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RequestCancelWorkflowExecution.html">RequestCancelWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_TerminateWorkflowExecution.html">TerminateWorkflowExecution</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Visibility Actions</b> </para> <para>Although you can perform visibility actions from the Amazon SWF console, you can use the
    /// actions in this section to build your own console or administrative tools. </para>
    /// <ul>
    /// 
    /// </ul>
    /// <para> <b>Activity Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListActivityTypes.html">ListActivityTypes</a> </para> </li>
    /// <li> <para> <a href="API_DescribeActivityType.html">DescribeActivity</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListWorkflowTypes.html">ListWorkflowTypes</a> </para> </li>
    /// <li> <para> <a href="API_DescribeWorkflowType.html">DescribeWorkflowType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_DescribeWorkflowExecution.html">DescribeWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_ListOpenWorkflowExecutions.html">ListOpenWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_ListClosedWorkflowExecutions.html">ListClosedWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_CountOpenWorkflowExecutions.html">CountOpenWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_CountClosedWorkflowExecutions.html">CountClosedWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_GetWorkflowExecutionHistory.html">GetWorkflowExecutionHistory</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListDomains.html">ListDomains</a> </para> </li>
    /// <li> <para> <a href="API_DescribeDomain.html">DescribeDomain</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Task List Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_CountPendingActivityTasks.html">CountPendingActivityTasks</a> </para> </li>
    /// <li> <para> <a href="API_CountPendingDecisionTasks.html">CountPendingDecisionTasks</a> </para> </li>
    /// 
    /// </ul>
    /// </summary>
	public partial class AmazonSimpleWorkflowClient : AmazonWebServiceClient, Amazon.SimpleWorkflow.IAmazonSimpleWorkflow
    {

        AWS3Signer signer = new AWS3Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonSimpleWorkflowConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials and an
        /// AmazonSimpleWorkflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonSimpleWorkflowClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig(){RegionEndpoint = region})
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
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para> Returns the number of closed workflow executions within the given domain that meet the specified filtering criteria. </para>
        /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
        /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
        /// as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>tagFilter.tag</c> : String constraint. The key is <c>swf:tagFilter.tag</c> .</li>
        /// <li> <c>typeFilter.name</c> : String constraint. The key is <c>swf:typeFilter.name</c> .</li>
        /// <li> <c>typeFilter.version</c> : String constraint. The key is <c>swf:typeFilter.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions
        /// service method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request)
        {
            var task = CountClosedWorkflowExecutionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CountClosedWorkflowExecutionsResponse> CountClosedWorkflowExecutionsAsync(CountClosedWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CountClosedWorkflowExecutionsRequest, CountClosedWorkflowExecutionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the number of open workflow executions within the given domain that meet the specified filtering criteria. </para>
        /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
        /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
        /// as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>tagFilter.tag</c> : String constraint. The key is <c>swf:tagFilter.tag</c> .</li>
        /// <li> <c>typeFilter.name</c> : String constraint. The key is <c>swf:typeFilter.name</c> .</li>
        /// <li> <c>typeFilter.version</c> : String constraint. The key is <c>swf:typeFilter.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request)
        {
            var task = CountOpenWorkflowExecutionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CountOpenWorkflowExecutionsResponse> CountOpenWorkflowExecutionsAsync(CountOpenWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CountOpenWorkflowExecutionsRequest, CountOpenWorkflowExecutionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the estimated number of activity tasks in the specified task list. The count returned is an approximation and is not
        /// guaranteed to be exact. If you specify a task list that no activity task was ever scheduled in then 0 will be returned. </para> <para>
        /// <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the <c>taskList.name</c> parameter by using a <b>Condition</b> element with the <c>swf:taskList.name</c> key to allow the
        /// action to access only certain task lists.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request)
        {
            var task = CountPendingActivityTasksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingActivityTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingActivityTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CountPendingActivityTasksResponse> CountPendingActivityTasksAsync(CountPendingActivityTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountPendingActivityTasksRequestMarshaller();
            var unmarshaller = CountPendingActivityTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CountPendingActivityTasksRequest, CountPendingActivityTasksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the estimated number of decision tasks in the specified task list. The count returned is an approximation and is not
        /// guaranteed to be exact. If you specify a task list that no decision task was ever scheduled in then 0 will be returned. </para> <para>
        /// <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the <c>taskList.name</c> parameter by using a <b>Condition</b> element with the <c>swf:taskList.name</c> key to allow the
        /// action to access only certain task lists.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request)
        {
            var task = CountPendingDecisionTasksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingDecisionTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingDecisionTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CountPendingDecisionTasksResponse> CountPendingDecisionTasksAsync(CountPendingDecisionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CountPendingDecisionTasksRequestMarshaller();
            var unmarshaller = CountPendingDecisionTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CountPendingDecisionTasksRequest, CountPendingDecisionTasksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Deprecates the specified <i>activity type</i> .
        /// After an activity type has been deprecated, you cannot create new tasks of that activity type. Tasks of this type that were scheduled
        /// before the type was deprecated will continue to run. </para> <para><b>NOTE:</b> This operation is eventually consistent. The results are
        /// best effort and may not exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM
        /// policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>activityType.name</c> : String constraint. The key is <c>swf:activityType.name</c> .</li>
        /// <li> <c>activityType.version</c> : String constraint. The key is <c>swf:activityType.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.TypeDeprecatedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request)
        {
            var task = DeprecateActivityTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateActivityType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeprecateActivityTypeResponse> DeprecateActivityTypeAsync(DeprecateActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateActivityTypeRequestMarshaller();
            var unmarshaller = DeprecateActivityTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeprecateActivityTypeRequest, DeprecateActivityTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Deprecates the specified domain. After a domain has been deprecated it cannot be used to create new workflow executions or register
        /// new types. However, you can still use visibility actions on this domain. Deprecating a domain also deprecates all activity and workflow
        /// types registered in the domain. Executions that were started before the domain was deprecated will continue to run. </para>
        /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
        /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
        /// as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.DomainDeprecatedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request)
        {
            var task = DeprecateDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeprecateDomainResponse> DeprecateDomainAsync(DeprecateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateDomainRequestMarshaller();
            var unmarshaller = DeprecateDomainResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeprecateDomainRequest, DeprecateDomainResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Deprecates the specified <i>workflow type</i> . After a workflow type has been deprecated, you cannot create new executions of that
        /// type. Executions that were started before the type was deprecated will continue to run. A deprecated workflow type may still be used when
        /// calling visibility actions. </para> <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not
        /// exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this
        /// action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>workflowType.name</c> : String constraint. The key is <c>swf:workflowType.name</c> .</li>
        /// <li> <c>workflowType.version</c> : String constraint. The key is <c>swf:workflowType.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.TypeDeprecatedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request)
        {
            var task = DeprecateWorkflowTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeprecateWorkflowTypeResponse> DeprecateWorkflowTypeAsync(DeprecateWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeprecateWorkflowTypeRequestMarshaller();
            var unmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeprecateWorkflowTypeRequest, DeprecateWorkflowTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about the specified activity type. This includes configuration settings provided at registration time as well as
        /// other general information about the type. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this
        /// action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>activityType.name</c> : String constraint. The key is <c>swf:activityType.name</c> .</li>
        /// <li> <c>activityType.version</c> : String constraint. The key is <c>swf:activityType.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request)
        {
            var task = DescribeActivityTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeActivityType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeActivityTypeResponse> DescribeActivityTypeAsync(DescribeActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeActivityTypeRequestMarshaller();
            var unmarshaller = DescribeActivityTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeActivityTypeRequest, DescribeActivityTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about the specified domain including description and status. </para> <para> <b>Access Control</b> </para>
        /// <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var task = DescribeDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDomainRequestMarshaller();
            var unmarshaller = DescribeDomainResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDomainRequest, DescribeDomainResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about the specified workflow execution including its type and some statistics. </para> <para><b>NOTE:</b> This
        /// operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and changes. </para> <para>
        /// <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request)
        {
            var task = DescribeWorkflowExecutionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeWorkflowExecutionResponse> DescribeWorkflowExecutionAsync(DescribeWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkflowExecutionRequestMarshaller();
            var unmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeWorkflowExecutionRequest, DescribeWorkflowExecutionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about the specified <i>workflow type</i> . This includes configuration settings specified when the type was
        /// registered and other information such as creation date, current status, etc. </para> <para> <b>Access Control</b> </para> <para>You can use
        /// IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>workflowType.name</c> : String constraint. The key is <c>swf:workflowType.name</c> .</li>
        /// <li> <c>workflowType.version</c> : String constraint. The key is <c>swf:workflowType.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request)
        {
            var task = DescribeWorkflowTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeWorkflowTypeResponse> DescribeWorkflowTypeAsync(DescribeWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkflowTypeRequestMarshaller();
            var unmarshaller = DescribeWorkflowTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeWorkflowTypeRequest, DescribeWorkflowTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the history of the specified workflow execution. The results may be split into multiple pages. To retrieve subsequent pages,
        /// make the call again using the <c>nextPageToken</c> returned by the initial call. </para> <para><b>NOTE:</b> This operation is eventually
        /// consistent. The results are best effort and may not exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para>
        /// <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request)
        {
            var task = GetWorkflowExecutionHistoryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.GetWorkflowExecutionHistory"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetWorkflowExecutionHistoryResponse> GetWorkflowExecutionHistoryAsync(GetWorkflowExecutionHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetWorkflowExecutionHistoryRequestMarshaller();
            var unmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetWorkflowExecutionHistoryRequest, GetWorkflowExecutionHistoryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about all activities registered in the specified domain that match the specified name and registration status.
        /// The result includes information like creation date, current status of the activity, etc. The results may be split into multiple pages. To
        /// retrieve subsequent pages, make the call again using the <c>nextPageToken</c> returned by the initial call. </para> <para> <b>Access
        /// Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request)
        {
            var task = ListActivityTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListActivityTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListActivityTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListActivityTypesResponse> ListActivityTypesAsync(ListActivityTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListActivityTypesRequestMarshaller();
            var unmarshaller = ListActivityTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListActivityTypesRequest, ListActivityTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns a list of closed workflow executions in the specified domain that meet the filtering criteria. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken returned by the initial call. </para>
        /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
        /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
        /// as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>tagFilter.tag</c> : String constraint. The key is <c>swf:tagFilter.tag</c> .</li>
        /// <li> <c>typeFilter.name</c> : String constraint. The key is <c>swf:typeFilter.name</c> .</li>
        /// <li> <c>typeFilter.version</c> : String constraint. The key is <c>swf:typeFilter.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request)
        {
            var task = ListClosedWorkflowExecutionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListClosedWorkflowExecutionsResponse> ListClosedWorkflowExecutionsAsync(ListClosedWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListClosedWorkflowExecutionsRequest, ListClosedWorkflowExecutionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the list of domains registered in the account. The results may be split into multiple pages. To retrieve subsequent pages,
        /// make the call again using the nextPageToken returned by the initial call. </para> <para><b>NOTE:</b> This operation is eventually
        /// consistent. The results are best effort and may not exactly reflect recent updates and changes. </para> <para> <b>Access Control</b> </para>
        /// <para>You can use IAM policies to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains. The element must be set to
        /// <c>arn:aws:swf::AccountID:domain/*"</c> , where “AccountID" is the account ID, with no dashes.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
		public ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var task = ListDomainsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListDomains"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListDomainsRequest, ListDomainsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns a list of open workflow executions in the specified domain that meet the filtering criteria. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken returned by the initial call. </para>
        /// <para><b>NOTE:</b> This operation is eventually consistent. The results are best effort and may not exactly reflect recent updates and
        /// changes. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources
        /// as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>tagFilter.tag</c> : String constraint. The key is <c>swf:tagFilter.tag</c> .</li>
        /// <li> <c>typeFilter.name</c> : String constraint. The key is <c>swf:typeFilter.name</c> .</li>
        /// <li> <c>typeFilter.version</c> : String constraint. The key is <c>swf:typeFilter.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request)
        {
            var task = ListOpenWorkflowExecutionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListOpenWorkflowExecutionsResponse> ListOpenWorkflowExecutionsAsync(ListOpenWorkflowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListOpenWorkflowExecutionsRequest, ListOpenWorkflowExecutionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns information about workflow types in the specified domain. The results may be split into multiple pages that can be retrieved
        /// by making the call repeatedly. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access
        /// to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request)
        {
            var task = ListWorkflowTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListWorkflowTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListWorkflowTypesResponse> ListWorkflowTypesAsync(ListWorkflowTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListWorkflowTypesRequestMarshaller();
            var unmarshaller = ListWorkflowTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListWorkflowTypesRequest, ListWorkflowTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Used by workers to get an ActivityTask from the specified activity <c>taskList</c> .
        /// This initiates a long poll, where the service holds the HTTP connection open and responds as soon as a task becomes available. The
        /// maximum time the service holds on to the request before responding is 60 seconds. If no task is available within 60 seconds, the poll will
        /// return an empty result. An empty result, in this context, means that an ActivityTask is returned, but that the value of taskToken is an
        /// empty string. If a task is returned, the worker should use its type to identify and process it correctly. </para> <para><b>IMPORTANT:</b>
        /// Workers should set their client side socket timeout to at least 70 seconds (10 seconds higher than the maximum time service may hold the
        /// poll request). </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF
        /// resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the <c>taskList.name</c> parameter by using a <b>Condition</b> element with the <c>swf:taskList.name</c> key to allow the
        /// action to access only certain task lists.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request)
        {
            var task = PollForActivityTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PollForActivityTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForActivityTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PollForActivityTaskResponse> PollForActivityTaskAsync(PollForActivityTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForActivityTaskRequestMarshaller();
            var unmarshaller = PollForActivityTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PollForActivityTaskRequest, PollForActivityTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// Instead, call PollForDecisionTask again. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this
        /// action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the <c>taskList.name</c> parameter by using a <b>Condition</b> element with the <c>swf:taskList.name</c> key to allow the
        /// action to access only certain task lists.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request)
        {
            var task = PollForDecisionTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PollForDecisionTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForDecisionTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PollForDecisionTaskResponse> PollForDecisionTaskAsync(PollForDecisionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForDecisionTaskRequestMarshaller();
            var unmarshaller = PollForDecisionTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PollForDecisionTaskRequest, PollForDecisionTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// should ignore the cancellation request. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's
        /// access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request)
        {
            var task = RecordActivityTaskHeartbeatAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RecordActivityTaskHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RecordActivityTaskHeartbeatResponse> RecordActivityTaskHeartbeatAsync(RecordActivityTaskHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RecordActivityTaskHeartbeatRequestMarshaller();
            var unmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RecordActivityTaskHeartbeatRequest, RecordActivityTaskHeartbeatResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Registers a new <i>activity type</i> along with its configuration settings in the specified domain. </para> <para><b>IMPORTANT:</b> A
        /// TypeAlreadyExists fault is returned if the type already exists in the domain. You cannot change any configuration settings of the type after
        /// its registration, and it must be registered as a new version. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to
        /// control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>defaultTaskList.name</c> : String constraint. The key is <c>swf:defaultTaskList.name</c> .</li>
        /// <li> <c>name</c> : String constraint. The key is <c>swf:name</c> .</li>
        /// <li> <c>version</c> : String constraint. The key is <c>swf:version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request)
        {
            var task = RegisterActivityTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RegisterActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterActivityType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RegisterActivityTypeResponse> RegisterActivityTypeAsync(RegisterActivityTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterActivityTypeRequestMarshaller();
            var unmarshaller = RegisterActivityTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterActivityTypeRequest, RegisterActivityTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Registers a new domain. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access
        /// to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>You cannot use an IAM policy to control domain access for this action. The name of the domain being registered is available as the
        /// resource of this action.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var task = RegisterDomainAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterDomain"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterDomainRequest, RegisterDomainResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Registers a new <i>workflow type</i> and its configuration settings in the specified domain. </para> <para> The retention period for
        /// the workflow history is set by the RegisterDomain action. </para> <para><b>IMPORTANT:</b> If the type already exists, then a
        /// TypeAlreadyExists fault is returned. You cannot change the configuration settings of a workflow type once it is registered and it must be
        /// registered as a new version. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to
        /// Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>defaultTaskList.name</c> : String constraint. The key is <c>swf:defaultTaskList.name</c> .</li>
        /// <li> <c>name</c> : String constraint. The key is <c>swf:name</c> .</li>
        /// <li> <c>version</c> : String constraint. The key is <c>swf:version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request)
        {
            var task = RegisterWorkflowTypeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RegisterWorkflowTypeResponse> RegisterWorkflowTypeAsync(RegisterWorkflowTypeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterWorkflowTypeRequestMarshaller();
            var unmarshaller = RegisterWorkflowTypeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterWorkflowTypeRequest, RegisterWorkflowTypeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Records a <c>WorkflowExecutionCancelRequested</c> event in the currently running workflow execution identified by the given domain,
        /// workflowId, and runId. This logically requests the cancellation of the workflow execution as a whole. It is up to the decider to take
        /// appropriate actions when it receives an execution history with this event. </para> <para><b>NOTE:</b> If the runId is not specified, the
        /// WorkflowExecutionCancelRequested event is recorded in the history of the current open workflow execution with the specified workflowId in
        /// the domain. </para> <para><b>NOTE:</b> Because this action allows the workflow to properly clean up and gracefully close, it should be used
        /// instead of TerminateWorkflowExecution when possible. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control
        /// this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution
        /// service method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request)
        {
            var task = RequestCancelWorkflowExecutionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RequestCancelWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RequestCancelWorkflowExecutionResponse> RequestCancelWorkflowExecutionAsync(RequestCancelWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestCancelWorkflowExecutionRequestMarshaller();
            var unmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RequestCancelWorkflowExecutionRequest, RequestCancelWorkflowExecutionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> was successfully canceled. Additional
        /// <c>details</c> can be optionally provided using the <c>details</c> argument. </para> <para> These <c>details</c> (if provided) appear in the
        /// <c>ActivityTaskCanceled</c> event added to the workflow history. </para> <para><b>IMPORTANT:</b> Only use this operation if the canceled
        /// flag of a RecordActivityTaskHeartbeat request returns true and if the activity can be safely undone or abandoned. </para> <para> A task is
        /// considered open from the time that it is scheduled until it is closed. Therefore a task is reported as open while a worker is processing it.
        /// A task is closed after it has been specified in a call to RespondActivityTaskCompleted, RespondActivityTaskCanceled,
        /// RespondActivityTaskFailed, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request)
        {
            var task = RespondActivityTaskCanceledAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCanceled"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RespondActivityTaskCanceledResponse> RespondActivityTaskCanceledAsync(RespondActivityTaskCanceledRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskCanceledRequestMarshaller();
            var unmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RespondActivityTaskCanceledRequest, RespondActivityTaskCanceledResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> completed successfully with a
        /// <c>result</c> (if provided). The <c>result</c> appears in the <c>ActivityTaskCompleted</c> event in the workflow history. </para>
        /// <para><b>IMPORTANT:</b> If the requested task does not complete successfully, use RespondActivityTaskFailed instead. If the worker finds
        /// that the task is canceled through the canceled flag returned by RecordActivityTaskHeartbeat, it should cancel the task, clean up and then
        /// call RespondActivityTaskCanceled. </para> <para> A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after it has been specified in a call to
        /// RespondActivityTaskCompleted, RespondActivityTaskCanceled, RespondActivityTaskFailed, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request)
        {
            var task = RespondActivityTaskCompletedAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RespondActivityTaskCompletedResponse> RespondActivityTaskCompletedAsync(RespondActivityTaskCompletedRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskCompletedRequestMarshaller();
            var unmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RespondActivityTaskCompletedRequest, RespondActivityTaskCompletedResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> has failed with <c>reason</c> (if
        /// specified). The <c>reason</c> and <c>details</c> appear in the <c>ActivityTaskFailed</c> event added to the workflow history. </para> <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore a task is reported as open while a worker is
        /// processing it. A task is closed after it has been specified in a call to RespondActivityTaskCompleted, RespondActivityTaskCanceled,
        /// RespondActivityTaskFailed, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request)
        {
            var task = RespondActivityTaskFailedAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskFailed operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskFailed"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RespondActivityTaskFailedResponse> RespondActivityTaskFailedAsync(RespondActivityTaskFailedRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondActivityTaskFailedRequestMarshaller();
            var unmarshaller = RespondActivityTaskFailedResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RespondActivityTaskFailedRequest, RespondActivityTaskFailedResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Used by deciders to tell the service that the DecisionTask identified by the <c>taskToken</c> has successfully completed. The
        /// <c>decisions</c> argument specifies the list of decisions made while processing the task. </para> <para> A
        /// <c>DecisionTaskCompleted</c> event is added to the workflow history. The <c>executionContext</c> specified is attached
        /// to the event in the workflow execution history. </para> <para> <b>Access Control</b> </para> <para>If an IAM policy grants permission to use
        /// <c>RespondDecisionTaskCompleted</c> , it can express permissions for the list of decisions in the <c>decisions</c> parameter. Each of the
        /// decisions has one or more parameters, much like a regular API call. To allow for policies to be as readable as possible, you can express
        /// permissions on decisions as if they were actual API calls, including applying conditions to some parameters. For more information, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request)
        {
            var task = RespondDecisionTaskCompletedAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondDecisionTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RespondDecisionTaskCompletedResponse> RespondDecisionTaskCompletedAsync(RespondDecisionTaskCompletedRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RespondDecisionTaskCompletedRequestMarshaller();
            var unmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RespondDecisionTaskCompletedRequest, RespondDecisionTaskCompletedResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Records a <c>WorkflowExecutionSignaled</c> event in the workflow execution history and creates a decision task for the workflow
        /// execution identified by the given domain, workflowId and runId. The event is recorded with the specified user defined signalName and input
        /// (if provided). </para> <para><b>NOTE:</b> If a runId is not specified, then the WorkflowExecutionSignaled event is recorded in the history
        /// of the current open workflow with the matching workflowId in the domain. </para> <para><b>NOTE:</b> If the specified workflow execution is
        /// not open, this method fails with UnknownResource. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control
        /// this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request)
        {
            var task = SignalWorkflowExecutionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SignalWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.SignalWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SignalWorkflowExecutionResponse> SignalWorkflowExecutionAsync(SignalWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SignalWorkflowExecutionRequestMarshaller();
            var unmarshaller = SignalWorkflowExecutionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SignalWorkflowExecutionRequest, SignalWorkflowExecutionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Starts an execution of the workflow type in the specified domain using the provided <c>workflowId</c> and input data. </para>
        /// <para>This action returns the newly started workflow execution.</para> <para> <b>Access Control</b> </para> <para>You can use IAM policies
        /// to control this action's access to Amazon SWF resources as follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>Constrain the following parameters by using a <c>Condition</c> element with the appropriate keys.
        /// <ul>
        /// <li> <c>tagList.member.0</c> : The key is <c>swf:tagList.member.0</c> .</li>
        /// <li> <c>tagList.member.1</c> : The key is <c>swf:tagList.member.1</c> .</li>
        /// <li> <c>tagList.member.2</c> : The key is <c>swf:tagList.member.2</c> .</li>
        /// <li> <c>tagList.member.3</c> : The key is <c>swf:tagList.member.3</c> .</li>
        /// <li> <c>tagList.member.4</c> : The key is <c>swf:tagList.member.4</c> .</li>
        /// <li> <c>taskList</c> : String constraint. The key is <c>swf:taskList.name</c> .</li>
        /// <li> <c>name</c> : String constraint. The key is <c>swf:workflowType.name</c> .</li>
        /// <li> <c>version</c> : String constraint. The key is <c>swf:workflowType.version</c> .</li>
        /// 
        /// </ul>
        /// </li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution service method on
        /// AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the StartWorkflowExecution service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.TypeDeprecatedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.DefaultUndefinedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.WorkflowExecutionAlreadyStartedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.LimitExceededException" />
		public StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request)
        {
            var task = StartWorkflowExecutionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.StartWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartWorkflowExecutionRequestMarshaller();
            var unmarshaller = StartWorkflowExecutionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, StartWorkflowExecutionRequest, StartWorkflowExecutionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Records a <c>WorkflowExecutionTerminated</c> event and forces closure of the workflow execution identified by the given domain,
        /// runId, and workflowId. The child policy, registered with the workflow type or specified when starting this execution, is applied to any open
        /// child workflow executions of this workflow execution. </para> <para><b>IMPORTANT:</b> If the identified workflow execution was in progress,
        /// it is terminated immediately. </para> <para><b>NOTE:</b> If a runId is not specified, then the WorkflowExecutionTerminated event is recorded
        /// in the history of the current open workflow with the matching workflowId in the domain. </para> <para><b>NOTE:</b> You should consider using
        /// RequestCancelWorkflowExecution action instead because it allows the workflow to gracefully close while TerminateWorkflowExecution does not.
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution service
        /// method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.OperationNotPermittedException" />
        /// <exception cref="T:Amazon.SimpleWorkflow.Model.UnknownResourceException" />
		public TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request)
        {
            var task = TerminateWorkflowExecutionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.TerminateWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<TerminateWorkflowExecutionResponse> TerminateWorkflowExecutionAsync(TerminateWorkflowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateWorkflowExecutionRequestMarshaller();
            var unmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, TerminateWorkflowExecutionRequest, TerminateWorkflowExecutionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}

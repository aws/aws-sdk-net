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
    /// go to the <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/" >Amazon SWF Developer Guide</a> .
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
    /// <li> <para> <a href="API_PollForActivityTask.html" >PollForActivityTask</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskCompleted.html" >RespondActivityTaskCompleted</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskFailed.html" >RespondActivityTaskFailed</a> </para> </li>
    /// <li> <para> <a href="API_RespondActivityTaskCanceled.html" >RespondActivityTaskCanceled</a> </para> </li>
    /// <li> <para> <a href="API_RecordActivityTaskHeartbeat.html" >RecordActivityTaskHeartbeat</a> </para> </li>
    /// 
    /// </ul>
    /// <para>Activity workers use the <a href="API_PollForActivityTask.html" >PollForActivityTask</a> to get new activity tasks. After a worker
    /// receives an activity task from Amazon SWF, it performs the task and responds using <a href="API_RespondActivityTaskCompleted.html"
    /// >RespondActivityTaskCompleted</a> if successful or <a href="API_RespondActivityTaskFailed.html" >RespondActivityTaskFailed</a> if
    /// unsuccessful. </para> <para> <b>Actions related to Deciders</b> </para> <para>The following are actions that are performed by
    /// deciders:</para>
    /// <ul>
    /// <li> <para> <a href="API_PollForDecisionTask.html" >PollForDecisionTask</a> </para> </li>
    /// <li> <para> <a href="API_RespondDecisionTaskCompleted.html" >RespondDecisionTaskCompleted</a> </para> </li>
    /// 
    /// </ul>
    /// <para>Deciders use <a href="API_PollForDecisionTask.html" >PollForDecisionTask</a> to get decision tasks. After a decider receives a
    /// decision task from Amazon SWF, it examines its workflow execution history and decides what to do next. It calls <a
    /// href="API_RespondDecisionTaskCompleted.html" >RespondDecisionTaskCompleted</a> to complete the decision task and provide zero or more next
    /// decisions. </para> <para> <b>Actions related to Workflow Executions</b> </para> <para>The following actions operate on a workflow
    /// execution:</para>
    /// <ul>
    /// <li> <para> <a href="API_RequestCancelWorkflowExecution.html" >RequestCancelWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_StartWorkflowExecution.html" >StartWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_SignalWorkflowExecution.html" >SignalWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_TerminateWorkflowExecution.html" >TerminateWorkflowExecution</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Actions related to Administration</b> </para> <para>Although you can perform administrative tasks from the Amazon SWF console,
    /// you can use the actions in this section to automate functions or build your own administrative tools. </para> <para> <b>Activity
    /// Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterActivityType.html" >RegisterActivityType</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateActivityType.html" >DeprecateActivityType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterWorkflowType.html" >RegisterWorkflowType</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateWorkflowType.html" >DeprecateWorkflowType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RegisterDomain.html" >RegisterDomain</a> </para> </li>
    /// <li> <para> <a href="API_DeprecateDomain.html" >DeprecateDomain</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Management</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_RequestCancelWorkflowExecution.html" >RequestCancelWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_TerminateWorkflowExecution.html" >TerminateWorkflowExecution</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Visibility Actions</b> </para> <para>Although you can perform visibility actions from the Amazon SWF console, you can use the
    /// actions in this section to build your own console or administrative tools. </para>
    /// <ul>
    /// 
    /// </ul>
    /// <para> <b>Activity Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListActivityTypes.html" >ListActivityTypes</a> </para> </li>
    /// <li> <para> <a href="API_DescribeActivityType.html" >DescribeActivity</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListWorkflowTypes.html" >ListWorkflowTypes</a> </para> </li>
    /// <li> <para> <a href="API_DescribeWorkflowType.html" >DescribeWorkflowType</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Workflow Execution Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_DescribeWorkflowExecution.html" >DescribeWorkflowExecution</a> </para> </li>
    /// <li> <para> <a href="API_ListOpenWorkflowExecutions.html" >ListOpenWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_ListClosedWorkflowExecutions.html" >ListClosedWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_CountOpenWorkflowExecutions.html" >CountOpenWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_CountClosedWorkflowExecutions.html" >CountClosedWorkflowExecutions</a> </para> </li>
    /// <li> <para> <a href="API_GetWorkflowExecutionHistory.html" >GetWorkflowExecutionHistory</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Domain Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_ListDomains.html" >ListDomains</a> </para> </li>
    /// <li> <para> <a href="API_DescribeDomain.html" >DescribeDomain</a> </para> </li>
    /// 
    /// </ul>
    /// <para> <b>Task List Visibility</b> </para>
    /// <ul>
    /// <li> <para> <a href="API_CountPendingActivityTasks.html" >CountPendingActivityTasks</a> </para> </li>
    /// <li> <para> <a href="API_CountPendingDecisionTasks.html" >CountPendingDecisionTasks</a> </para> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class AmazonSimpleWorkflowClient : AmazonWebServiceClient, IAmazonSimpleWorkflow
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// AmazonSimpleWorkflowClient Configuration object. 
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region CountClosedWorkflowExecutions

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="countClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountClosedWorkflowExecutions
        ///          service method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest countClosedWorkflowExecutionsRequest)
        {
            IAsyncResult asyncResult = invokeCountClosedWorkflowExecutions(countClosedWorkflowExecutionsRequest, null, null, true);
            return EndCountClosedWorkflowExecutions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="countClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountClosedWorkflowExecutions
        ///          operation on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCountClosedWorkflowExecutions operation.</returns>
        public IAsyncResult BeginCountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest countClosedWorkflowExecutionsRequest, AsyncCallback callback, object state)
        {
            return invokeCountClosedWorkflowExecutions(countClosedWorkflowExecutionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a WorkflowExecutionCount from AmazonSimpleWorkflow.</returns>
        public CountClosedWorkflowExecutionsResponse EndCountClosedWorkflowExecutions(IAsyncResult asyncResult)
        {
            return endOperation<CountClosedWorkflowExecutionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest countClosedWorkflowExecutionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CountClosedWorkflowExecutionsRequestMarshaller().Marshall(countClosedWorkflowExecutionsRequest);
            var unmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CountOpenWorkflowExecutions

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="countOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest countOpenWorkflowExecutionsRequest)
        {
            IAsyncResult asyncResult = invokeCountOpenWorkflowExecutions(countOpenWorkflowExecutionsRequest, null, null, true);
            return EndCountOpenWorkflowExecutions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="countOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCountOpenWorkflowExecutions operation.</returns>
        public IAsyncResult BeginCountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest countOpenWorkflowExecutionsRequest, AsyncCallback callback, object state)
        {
            return invokeCountOpenWorkflowExecutions(countOpenWorkflowExecutionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a WorkflowExecutionCount from AmazonSimpleWorkflow.</returns>
        public CountOpenWorkflowExecutionsResponse EndCountOpenWorkflowExecutions(IAsyncResult asyncResult)
        {
            return endOperation<CountOpenWorkflowExecutionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest countOpenWorkflowExecutionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CountOpenWorkflowExecutionsRequestMarshaller().Marshall(countOpenWorkflowExecutionsRequest);
            var unmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CountPendingActivityTasks

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="countPendingActivityTasksRequest">Container for the necessary parameters to execute the CountPendingActivityTasks service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest countPendingActivityTasksRequest)
        {
            IAsyncResult asyncResult = invokeCountPendingActivityTasks(countPendingActivityTasksRequest, null, null, true);
            return EndCountPendingActivityTasks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingActivityTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingActivityTasks"/>
        /// </summary>
        /// 
        /// <param name="countPendingActivityTasksRequest">Container for the necessary parameters to execute the CountPendingActivityTasks operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCountPendingActivityTasks operation.</returns>
        public IAsyncResult BeginCountPendingActivityTasks(CountPendingActivityTasksRequest countPendingActivityTasksRequest, AsyncCallback callback, object state)
        {
            return invokeCountPendingActivityTasks(countPendingActivityTasksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CountPendingActivityTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingActivityTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingActivityTasks.</param>
        /// 
        /// <returns>Returns a PendingTaskCount from AmazonSimpleWorkflow.</returns>
        public CountPendingActivityTasksResponse EndCountPendingActivityTasks(IAsyncResult asyncResult)
        {
            return endOperation<CountPendingActivityTasksResponse>(asyncResult);
        }
        
        IAsyncResult invokeCountPendingActivityTasks(CountPendingActivityTasksRequest countPendingActivityTasksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CountPendingActivityTasksRequestMarshaller().Marshall(countPendingActivityTasksRequest);
            var unmarshaller = CountPendingActivityTasksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CountPendingDecisionTasks

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="countPendingDecisionTasksRequest">Container for the necessary parameters to execute the CountPendingDecisionTasks service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest countPendingDecisionTasksRequest)
        {
            IAsyncResult asyncResult = invokeCountPendingDecisionTasks(countPendingDecisionTasksRequest, null, null, true);
            return EndCountPendingDecisionTasks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingDecisionTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingDecisionTasks"/>
        /// </summary>
        /// 
        /// <param name="countPendingDecisionTasksRequest">Container for the necessary parameters to execute the CountPendingDecisionTasks operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCountPendingDecisionTasks operation.</returns>
        public IAsyncResult BeginCountPendingDecisionTasks(CountPendingDecisionTasksRequest countPendingDecisionTasksRequest, AsyncCallback callback, object state)
        {
            return invokeCountPendingDecisionTasks(countPendingDecisionTasksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CountPendingDecisionTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.CountPendingDecisionTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingDecisionTasks.</param>
        /// 
        /// <returns>Returns a PendingTaskCount from AmazonSimpleWorkflow.</returns>
        public CountPendingDecisionTasksResponse EndCountPendingDecisionTasks(IAsyncResult asyncResult)
        {
            return endOperation<CountPendingDecisionTasksResponse>(asyncResult);
        }
        
        IAsyncResult invokeCountPendingDecisionTasks(CountPendingDecisionTasksRequest countPendingDecisionTasksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CountPendingDecisionTasksRequestMarshaller().Marshall(countPendingDecisionTasksRequest);
            var unmarshaller = CountPendingDecisionTasksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeprecateActivityType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="deprecateActivityTypeRequest">Container for the necessary parameters to execute the DeprecateActivityType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="TypeDeprecatedException"/>
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest deprecateActivityTypeRequest)
        {
            IAsyncResult asyncResult = invokeDeprecateActivityType(deprecateActivityTypeRequest, null, null, true);
            return EndDeprecateActivityType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateActivityType"/>
        /// </summary>
        /// 
        /// <param name="deprecateActivityTypeRequest">Container for the necessary parameters to execute the DeprecateActivityType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeprecateActivityType(DeprecateActivityTypeRequest deprecateActivityTypeRequest, AsyncCallback callback, object state)
        {
            return invokeDeprecateActivityType(deprecateActivityTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeprecateActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateActivityType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateActivityType.</param>
        public DeprecateActivityTypeResponse EndDeprecateActivityType(IAsyncResult asyncResult)
        {
            return endOperation<DeprecateActivityTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeprecateActivityType(DeprecateActivityTypeRequest deprecateActivityTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeprecateActivityTypeRequestMarshaller().Marshall(deprecateActivityTypeRequest);
            var unmarshaller = DeprecateActivityTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeprecateDomain

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="deprecateDomainRequest">Container for the necessary parameters to execute the DeprecateDomain service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="DomainDeprecatedException"/>
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest deprecateDomainRequest)
        {
            IAsyncResult asyncResult = invokeDeprecateDomain(deprecateDomainRequest, null, null, true);
            return EndDeprecateDomain(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateDomain"/>
        /// </summary>
        /// 
        /// <param name="deprecateDomainRequest">Container for the necessary parameters to execute the DeprecateDomain operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeprecateDomain(DeprecateDomainRequest deprecateDomainRequest, AsyncCallback callback, object state)
        {
            return invokeDeprecateDomain(deprecateDomainRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeprecateDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateDomain.</param>
        public DeprecateDomainResponse EndDeprecateDomain(IAsyncResult asyncResult)
        {
            return endOperation<DeprecateDomainResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeprecateDomain(DeprecateDomainRequest deprecateDomainRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeprecateDomainRequestMarshaller().Marshall(deprecateDomainRequest);
            var unmarshaller = DeprecateDomainResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeprecateWorkflowType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="deprecateWorkflowTypeRequest">Container for the necessary parameters to execute the DeprecateWorkflowType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="TypeDeprecatedException"/>
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest deprecateWorkflowTypeRequest)
        {
            IAsyncResult asyncResult = invokeDeprecateWorkflowType(deprecateWorkflowTypeRequest, null, null, true);
            return EndDeprecateWorkflowType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="deprecateWorkflowTypeRequest">Container for the necessary parameters to execute the DeprecateWorkflowType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeprecateWorkflowType(DeprecateWorkflowTypeRequest deprecateWorkflowTypeRequest, AsyncCallback callback, object state)
        {
            return invokeDeprecateWorkflowType(deprecateWorkflowTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeprecateWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DeprecateWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateWorkflowType.</param>
        public DeprecateWorkflowTypeResponse EndDeprecateWorkflowType(IAsyncResult asyncResult)
        {
            return endOperation<DeprecateWorkflowTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeprecateWorkflowType(DeprecateWorkflowTypeRequest deprecateWorkflowTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeprecateWorkflowTypeRequestMarshaller().Marshall(deprecateWorkflowTypeRequest);
            var unmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeActivityType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeActivityTypeRequest">Container for the necessary parameters to execute the DescribeActivityType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest describeActivityTypeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeActivityType(describeActivityTypeRequest, null, null, true);
            return EndDescribeActivityType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeActivityType"/>
        /// </summary>
        /// 
        /// <param name="describeActivityTypeRequest">Container for the necessary parameters to execute the DescribeActivityType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeActivityType operation.</returns>
        public IAsyncResult BeginDescribeActivityType(DescribeActivityTypeRequest describeActivityTypeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeActivityType(describeActivityTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeActivityType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivityType.</param>
        /// 
        /// <returns>Returns a ActivityTypeDetail from AmazonSimpleWorkflow.</returns>
        public DescribeActivityTypeResponse EndDescribeActivityType(IAsyncResult asyncResult)
        {
            return endOperation<DescribeActivityTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeActivityType(DescribeActivityTypeRequest describeActivityTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeActivityTypeRequestMarshaller().Marshall(describeActivityTypeRequest);
            var unmarshaller = DescribeActivityTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDomain

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeDomainRequest">Container for the necessary parameters to execute the DescribeDomain service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest describeDomainRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDomain(describeDomainRequest, null, null, true);
            return EndDescribeDomain(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeDomain"/>
        /// </summary>
        /// 
        /// <param name="describeDomainRequest">Container for the necessary parameters to execute the DescribeDomain operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDomain(DescribeDomainRequest describeDomainRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDomain(describeDomainRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a DomainDetail from AmazonSimpleWorkflow.</returns>
        public DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDomainResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDomain(DescribeDomainRequest describeDomainRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDomainRequestMarshaller().Marshall(describeDomainRequest);
            var unmarshaller = DescribeDomainResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeWorkflowExecution

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeWorkflowExecutionRequest">Container for the necessary parameters to execute the DescribeWorkflowExecution service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest describeWorkflowExecutionRequest)
        {
            IAsyncResult asyncResult = invokeDescribeWorkflowExecution(describeWorkflowExecutionRequest, null, null, true);
            return EndDescribeWorkflowExecution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="describeWorkflowExecutionRequest">Container for the necessary parameters to execute the DescribeWorkflowExecution operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeWorkflowExecution operation.</returns>
        public IAsyncResult BeginDescribeWorkflowExecution(DescribeWorkflowExecutionRequest describeWorkflowExecutionRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeWorkflowExecution(describeWorkflowExecutionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowExecution.</param>
        /// 
        /// <returns>Returns a WorkflowExecutionDetail from AmazonSimpleWorkflow.</returns>
        public DescribeWorkflowExecutionResponse EndDescribeWorkflowExecution(IAsyncResult asyncResult)
        {
            return endOperation<DescribeWorkflowExecutionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeWorkflowExecution(DescribeWorkflowExecutionRequest describeWorkflowExecutionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeWorkflowExecutionRequestMarshaller().Marshall(describeWorkflowExecutionRequest);
            var unmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeWorkflowType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeWorkflowTypeRequest">Container for the necessary parameters to execute the DescribeWorkflowType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest describeWorkflowTypeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeWorkflowType(describeWorkflowTypeRequest, null, null, true);
            return EndDescribeWorkflowType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="describeWorkflowTypeRequest">Container for the necessary parameters to execute the DescribeWorkflowType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeWorkflowType operation.</returns>
        public IAsyncResult BeginDescribeWorkflowType(DescribeWorkflowTypeRequest describeWorkflowTypeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeWorkflowType(describeWorkflowTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.DescribeWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowType.</param>
        /// 
        /// <returns>Returns a WorkflowTypeDetail from AmazonSimpleWorkflow.</returns>
        public DescribeWorkflowTypeResponse EndDescribeWorkflowType(IAsyncResult asyncResult)
        {
            return endOperation<DescribeWorkflowTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeWorkflowType(DescribeWorkflowTypeRequest describeWorkflowTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeWorkflowTypeRequestMarshaller().Marshall(describeWorkflowTypeRequest);
            var unmarshaller = DescribeWorkflowTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetWorkflowExecutionHistory

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="getWorkflowExecutionHistoryRequest">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest getWorkflowExecutionHistoryRequest)
        {
            IAsyncResult asyncResult = invokeGetWorkflowExecutionHistory(getWorkflowExecutionHistoryRequest, null, null, true);
            return EndGetWorkflowExecutionHistory(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.GetWorkflowExecutionHistory"/>
        /// </summary>
        /// 
        /// <param name="getWorkflowExecutionHistoryRequest">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetWorkflowExecutionHistory operation.</returns>
        public IAsyncResult BeginGetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest getWorkflowExecutionHistoryRequest, AsyncCallback callback, object state)
        {
            return invokeGetWorkflowExecutionHistory(getWorkflowExecutionHistoryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.GetWorkflowExecutionHistory"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowExecutionHistory.</param>
        /// 
        /// <returns>Returns a History from AmazonSimpleWorkflow.</returns>
        public GetWorkflowExecutionHistoryResponse EndGetWorkflowExecutionHistory(IAsyncResult asyncResult)
        {
            return endOperation<GetWorkflowExecutionHistoryResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest getWorkflowExecutionHistoryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetWorkflowExecutionHistoryRequestMarshaller().Marshall(getWorkflowExecutionHistoryRequest);
            var unmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListActivityTypes

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="listActivityTypesRequest">Container for the necessary parameters to execute the ListActivityTypes service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest listActivityTypesRequest)
        {
            IAsyncResult asyncResult = invokeListActivityTypes(listActivityTypesRequest, null, null, true);
            return EndListActivityTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListActivityTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListActivityTypes"/>
        /// </summary>
        /// 
        /// <param name="listActivityTypesRequest">Container for the necessary parameters to execute the ListActivityTypes operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActivityTypes
        ///         operation.</returns>
        public IAsyncResult BeginListActivityTypes(ListActivityTypesRequest listActivityTypesRequest, AsyncCallback callback, object state)
        {
            return invokeListActivityTypes(listActivityTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListActivityTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListActivityTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivityTypes.</param>
        /// 
        /// <returns>Returns a ActivityTypeInfos from AmazonSimpleWorkflow.</returns>
        public ListActivityTypesResponse EndListActivityTypes(IAsyncResult asyncResult)
        {
            return endOperation<ListActivityTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListActivityTypes(ListActivityTypesRequest listActivityTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListActivityTypesRequestMarshaller().Marshall(listActivityTypesRequest);
            var unmarshaller = ListActivityTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListClosedWorkflowExecutions

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="listClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest listClosedWorkflowExecutionsRequest)
        {
            IAsyncResult asyncResult = invokeListClosedWorkflowExecutions(listClosedWorkflowExecutionsRequest, null, null, true);
            return EndListClosedWorkflowExecutions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="listClosedWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListClosedWorkflowExecutions
        ///          operation on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListClosedWorkflowExecutions operation.</returns>
        public IAsyncResult BeginListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest listClosedWorkflowExecutionsRequest, AsyncCallback callback, object state)
        {
            return invokeListClosedWorkflowExecutions(listClosedWorkflowExecutionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListClosedWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a WorkflowExecutionInfos from AmazonSimpleWorkflow.</returns>
        public ListClosedWorkflowExecutionsResponse EndListClosedWorkflowExecutions(IAsyncResult asyncResult)
        {
            return endOperation<ListClosedWorkflowExecutionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest listClosedWorkflowExecutionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListClosedWorkflowExecutionsRequestMarshaller().Marshall(listClosedWorkflowExecutionsRequest);
            var unmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListDomains

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="listDomainsRequest">Container for the necessary parameters to execute the ListDomains service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            IAsyncResult asyncResult = invokeListDomains(listDomainsRequest, null, null, true);
            return EndListDomains(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListDomains"/>
        /// </summary>
        /// 
        /// <param name="listDomainsRequest">Container for the necessary parameters to execute the ListDomains operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        public IAsyncResult BeginListDomains(ListDomainsRequest listDomainsRequest, AsyncCallback callback, object state)
        {
            return invokeListDomains(listDomainsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListDomains operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListDomains"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a DomainInfos from AmazonSimpleWorkflow.</returns>
        public ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return endOperation<ListDomainsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListDomains(ListDomainsRequest listDomainsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListDomainsRequestMarshaller().Marshall(listDomainsRequest);
            var unmarshaller = ListDomainsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListOpenWorkflowExecutions

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="listOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest listOpenWorkflowExecutionsRequest)
        {
            IAsyncResult asyncResult = invokeListOpenWorkflowExecutions(listOpenWorkflowExecutionsRequest, null, null, true);
            return EndListOpenWorkflowExecutions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="listOpenWorkflowExecutionsRequest">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListOpenWorkflowExecutions operation.</returns>
        public IAsyncResult BeginListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest listOpenWorkflowExecutionsRequest, AsyncCallback callback, object state)
        {
            return invokeListOpenWorkflowExecutions(listOpenWorkflowExecutionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListOpenWorkflowExecutions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a WorkflowExecutionInfos from AmazonSimpleWorkflow.</returns>
        public ListOpenWorkflowExecutionsResponse EndListOpenWorkflowExecutions(IAsyncResult asyncResult)
        {
            return endOperation<ListOpenWorkflowExecutionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest listOpenWorkflowExecutionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListOpenWorkflowExecutionsRequestMarshaller().Marshall(listOpenWorkflowExecutionsRequest);
            var unmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListWorkflowTypes

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="listWorkflowTypesRequest">Container for the necessary parameters to execute the ListWorkflowTypes service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest listWorkflowTypesRequest)
        {
            IAsyncResult asyncResult = invokeListWorkflowTypes(listWorkflowTypesRequest, null, null, true);
            return EndListWorkflowTypes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListWorkflowTypes"/>
        /// </summary>
        /// 
        /// <param name="listWorkflowTypesRequest">Container for the necessary parameters to execute the ListWorkflowTypes operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowTypes
        ///         operation.</returns>
        public IAsyncResult BeginListWorkflowTypes(ListWorkflowTypesRequest listWorkflowTypesRequest, AsyncCallback callback, object state)
        {
            return invokeListWorkflowTypes(listWorkflowTypesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListWorkflowTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.ListWorkflowTypes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowTypes.</param>
        /// 
        /// <returns>Returns a WorkflowTypeInfos from AmazonSimpleWorkflow.</returns>
        public ListWorkflowTypesResponse EndListWorkflowTypes(IAsyncResult asyncResult)
        {
            return endOperation<ListWorkflowTypesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListWorkflowTypes(ListWorkflowTypesRequest listWorkflowTypesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListWorkflowTypesRequestMarshaller().Marshall(listWorkflowTypesRequest);
            var unmarshaller = ListWorkflowTypesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PollForActivityTask

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="pollForActivityTaskRequest">Container for the necessary parameters to execute the PollForActivityTask service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        /// <exception cref="LimitExceededException"/>
        public PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest pollForActivityTaskRequest)
        {
            IAsyncResult asyncResult = invokePollForActivityTask(pollForActivityTaskRequest, null, null, true);
            return EndPollForActivityTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PollForActivityTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForActivityTask"/>
        /// </summary>
        /// 
        /// <param name="pollForActivityTaskRequest">Container for the necessary parameters to execute the PollForActivityTask operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPollForActivityTask operation.</returns>
        public IAsyncResult BeginPollForActivityTask(PollForActivityTaskRequest pollForActivityTaskRequest, AsyncCallback callback, object state)
        {
            return invokePollForActivityTask(pollForActivityTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PollForActivityTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForActivityTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForActivityTask.</param>
        /// 
        /// <returns>Returns a ActivityTask from AmazonSimpleWorkflow.</returns>
        public PollForActivityTaskResponse EndPollForActivityTask(IAsyncResult asyncResult)
        {
            return endOperation<PollForActivityTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokePollForActivityTask(PollForActivityTaskRequest pollForActivityTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PollForActivityTaskRequestMarshaller().Marshall(pollForActivityTaskRequest);
            var unmarshaller = PollForActivityTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PollForDecisionTask

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="pollForDecisionTaskRequest">Container for the necessary parameters to execute the PollForDecisionTask service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        /// <exception cref="LimitExceededException"/>
        public PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest pollForDecisionTaskRequest)
        {
            IAsyncResult asyncResult = invokePollForDecisionTask(pollForDecisionTaskRequest, null, null, true);
            return EndPollForDecisionTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PollForDecisionTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForDecisionTask"/>
        /// </summary>
        /// 
        /// <param name="pollForDecisionTaskRequest">Container for the necessary parameters to execute the PollForDecisionTask operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPollForDecisionTask operation.</returns>
        public IAsyncResult BeginPollForDecisionTask(PollForDecisionTaskRequest pollForDecisionTaskRequest, AsyncCallback callback, object state)
        {
            return invokePollForDecisionTask(pollForDecisionTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PollForDecisionTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.PollForDecisionTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForDecisionTask.</param>
        /// 
        /// <returns>Returns a DecisionTask from AmazonSimpleWorkflow.</returns>
        public PollForDecisionTaskResponse EndPollForDecisionTask(IAsyncResult asyncResult)
        {
            return endOperation<PollForDecisionTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokePollForDecisionTask(PollForDecisionTaskRequest pollForDecisionTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PollForDecisionTaskRequestMarshaller().Marshall(pollForDecisionTaskRequest);
            var unmarshaller = PollForDecisionTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RecordActivityTaskHeartbeat

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="recordActivityTaskHeartbeatRequest">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by AmazonSimpleWorkflow.</returns>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest recordActivityTaskHeartbeatRequest)
        {
            IAsyncResult asyncResult = invokeRecordActivityTaskHeartbeat(recordActivityTaskHeartbeatRequest, null, null, true);
            return EndRecordActivityTaskHeartbeat(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RecordActivityTaskHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="recordActivityTaskHeartbeatRequest">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRecordActivityTaskHeartbeat operation.</returns>
        public IAsyncResult BeginRecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest recordActivityTaskHeartbeatRequest, AsyncCallback callback, object state)
        {
            return invokeRecordActivityTaskHeartbeat(recordActivityTaskHeartbeatRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RecordActivityTaskHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordActivityTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a ActivityTaskStatus from AmazonSimpleWorkflow.</returns>
        public RecordActivityTaskHeartbeatResponse EndRecordActivityTaskHeartbeat(IAsyncResult asyncResult)
        {
            return endOperation<RecordActivityTaskHeartbeatResponse>(asyncResult);
        }
        
        IAsyncResult invokeRecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest recordActivityTaskHeartbeatRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RecordActivityTaskHeartbeatRequestMarshaller().Marshall(recordActivityTaskHeartbeatRequest);
            var unmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterActivityType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="registerActivityTypeRequest">Container for the necessary parameters to execute the RegisterActivityType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        /// <exception cref="TypeAlreadyExistsException"/>
        /// <exception cref="LimitExceededException"/>
        public RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest registerActivityTypeRequest)
        {
            IAsyncResult asyncResult = invokeRegisterActivityType(registerActivityTypeRequest, null, null, true);
            return EndRegisterActivityType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterActivityType"/>
        /// </summary>
        /// 
        /// <param name="registerActivityTypeRequest">Container for the necessary parameters to execute the RegisterActivityType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRegisterActivityType(RegisterActivityTypeRequest registerActivityTypeRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterActivityType(registerActivityTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterActivityType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterActivityType.</param>
        public RegisterActivityTypeResponse EndRegisterActivityType(IAsyncResult asyncResult)
        {
            return endOperation<RegisterActivityTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterActivityType(RegisterActivityTypeRequest registerActivityTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterActivityTypeRequestMarshaller().Marshall(registerActivityTypeRequest);
            var unmarshaller = RegisterActivityTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterDomain

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="registerDomainRequest">Container for the necessary parameters to execute the RegisterDomain service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="DomainAlreadyExistsException"/>
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="LimitExceededException"/>
        public RegisterDomainResponse RegisterDomain(RegisterDomainRequest registerDomainRequest)
        {
            IAsyncResult asyncResult = invokeRegisterDomain(registerDomainRequest, null, null, true);
            return EndRegisterDomain(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterDomain"/>
        /// </summary>
        /// 
        /// <param name="registerDomainRequest">Container for the necessary parameters to execute the RegisterDomain operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRegisterDomain(RegisterDomainRequest registerDomainRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterDomain(registerDomainRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterDomain"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDomain.</param>
        public RegisterDomainResponse EndRegisterDomain(IAsyncResult asyncResult)
        {
            return endOperation<RegisterDomainResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterDomain(RegisterDomainRequest registerDomainRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterDomainRequestMarshaller().Marshall(registerDomainRequest);
            var unmarshaller = RegisterDomainResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterWorkflowType

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="registerWorkflowTypeRequest">Container for the necessary parameters to execute the RegisterWorkflowType service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        /// <exception cref="TypeAlreadyExistsException"/>
        /// <exception cref="LimitExceededException"/>
        public RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest registerWorkflowTypeRequest)
        {
            IAsyncResult asyncResult = invokeRegisterWorkflowType(registerWorkflowTypeRequest, null, null, true);
            return EndRegisterWorkflowType(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="registerWorkflowTypeRequest">Container for the necessary parameters to execute the RegisterWorkflowType operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRegisterWorkflowType(RegisterWorkflowTypeRequest registerWorkflowTypeRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterWorkflowType(registerWorkflowTypeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RegisterWorkflowType"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWorkflowType.</param>
        public RegisterWorkflowTypeResponse EndRegisterWorkflowType(IAsyncResult asyncResult)
        {
            return endOperation<RegisterWorkflowTypeResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterWorkflowType(RegisterWorkflowTypeRequest registerWorkflowTypeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterWorkflowTypeRequestMarshaller().Marshall(registerWorkflowTypeRequest);
            var unmarshaller = RegisterWorkflowTypeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RequestCancelWorkflowExecution

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="requestCancelWorkflowExecutionRequest">Container for the necessary parameters to execute the RequestCancelWorkflowExecution
        ///          service method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest requestCancelWorkflowExecutionRequest)
        {
            IAsyncResult asyncResult = invokeRequestCancelWorkflowExecution(requestCancelWorkflowExecutionRequest, null, null, true);
            return EndRequestCancelWorkflowExecution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RequestCancelWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="requestCancelWorkflowExecutionRequest">Container for the necessary parameters to execute the RequestCancelWorkflowExecution
        ///          operation on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest requestCancelWorkflowExecutionRequest, AsyncCallback callback, object state)
        {
            return invokeRequestCancelWorkflowExecution(requestCancelWorkflowExecutionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RequestCancelWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCancelWorkflowExecution.</param>
        public RequestCancelWorkflowExecutionResponse EndRequestCancelWorkflowExecution(IAsyncResult asyncResult)
        {
            return endOperation<RequestCancelWorkflowExecutionResponse>(asyncResult);
        }
        
        IAsyncResult invokeRequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest requestCancelWorkflowExecutionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RequestCancelWorkflowExecutionRequestMarshaller().Marshall(requestCancelWorkflowExecutionRequest);
            var unmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RespondActivityTaskCanceled

        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> was successfully canceled. Additional
        /// <c>details</c> can be optionally provided using the <c>details</c> argument. </para> <para> These <c>details</c> (if provided) appear in the
        /// <c>ActivityTaskCanceled</c> event added to the workflow history. </para> <para><b>IMPORTANT:</b> Only use this operation if the canceled
        /// flag of a RecordActivityTaskHeartbeat request returns true and if the activity can be safely undone or abandoned. </para> <para> A task is
        /// considered open from the time that it is scheduled until it is closed. Therefore a task is reported as open while a worker is processing it.
        /// A task is closed after it has been specified in a call to RespondActivityTaskCompleted, RespondActivityTaskCanceled,
        /// RespondActivityTaskFailed, or the task has <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types" >timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskCanceledRequest">Container for the necessary parameters to execute the RespondActivityTaskCanceled service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest respondActivityTaskCanceledRequest)
        {
            IAsyncResult asyncResult = invokeRespondActivityTaskCanceled(respondActivityTaskCanceledRequest, null, null, true);
            return EndRespondActivityTaskCanceled(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCanceled"/>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskCanceledRequest">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRespondActivityTaskCanceled(RespondActivityTaskCanceledRequest respondActivityTaskCanceledRequest, AsyncCallback callback, object state)
        {
            return invokeRespondActivityTaskCanceled(respondActivityTaskCanceledRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCanceled"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCanceled.</param>
        public RespondActivityTaskCanceledResponse EndRespondActivityTaskCanceled(IAsyncResult asyncResult)
        {
            return endOperation<RespondActivityTaskCanceledResponse>(asyncResult);
        }
        
        IAsyncResult invokeRespondActivityTaskCanceled(RespondActivityTaskCanceledRequest respondActivityTaskCanceledRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RespondActivityTaskCanceledRequestMarshaller().Marshall(respondActivityTaskCanceledRequest);
            var unmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RespondActivityTaskCompleted

        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> completed successfully with a
        /// <c>result</c> (if provided). The <c>result</c> appears in the <c>ActivityTaskCompleted</c> event in the workflow history. </para>
        /// <para><b>IMPORTANT:</b> If the requested task does not complete successfully, use RespondActivityTaskFailed instead. If the worker finds
        /// that the task is canceled through the canceled flag returned by RecordActivityTaskHeartbeat, it should cancel the task, clean up and then
        /// call RespondActivityTaskCanceled. </para> <para> A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after it has been specified in a call to
        /// RespondActivityTaskCompleted, RespondActivityTaskCanceled, RespondActivityTaskFailed, or the task has <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types" >timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskCompletedRequest">Container for the necessary parameters to execute the RespondActivityTaskCompleted service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest respondActivityTaskCompletedRequest)
        {
            IAsyncResult asyncResult = invokeRespondActivityTaskCompleted(respondActivityTaskCompletedRequest, null, null, true);
            return EndRespondActivityTaskCompleted(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskCompletedRequest">Container for the necessary parameters to execute the RespondActivityTaskCompleted
        ///          operation on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRespondActivityTaskCompleted(RespondActivityTaskCompletedRequest respondActivityTaskCompletedRequest, AsyncCallback callback, object state)
        {
            return invokeRespondActivityTaskCompleted(respondActivityTaskCompletedRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCompleted.</param>
        public RespondActivityTaskCompletedResponse EndRespondActivityTaskCompleted(IAsyncResult asyncResult)
        {
            return endOperation<RespondActivityTaskCompletedResponse>(asyncResult);
        }
        
        IAsyncResult invokeRespondActivityTaskCompleted(RespondActivityTaskCompletedRequest respondActivityTaskCompletedRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RespondActivityTaskCompletedRequestMarshaller().Marshall(respondActivityTaskCompletedRequest);
            var unmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RespondActivityTaskFailed

        /// <summary>
        /// <para> Used by workers to tell the service that the ActivityTask identified by the <c>taskToken</c> has failed with <c>reason</c> (if
        /// specified). The <c>reason</c> and <c>details</c> appear in the <c>ActivityTaskFailed</c> event added to the workflow history. </para> <para>
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore a task is reported as open while a worker is
        /// processing it. A task is closed after it has been specified in a call to RespondActivityTaskCompleted, RespondActivityTaskCanceled,
        /// RespondActivityTaskFailed, or the task has <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types" >timed out</a> .
        /// </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:</para>
        /// <ul>
        /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
        /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
        /// 
        /// </ul>
        /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskFailedRequest">Container for the necessary parameters to execute the RespondActivityTaskFailed service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest respondActivityTaskFailedRequest)
        {
            IAsyncResult asyncResult = invokeRespondActivityTaskFailed(respondActivityTaskFailedRequest, null, null, true);
            return EndRespondActivityTaskFailed(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskFailed operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskFailed"/>
        /// </summary>
        /// 
        /// <param name="respondActivityTaskFailedRequest">Container for the necessary parameters to execute the RespondActivityTaskFailed operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRespondActivityTaskFailed(RespondActivityTaskFailedRequest respondActivityTaskFailedRequest, AsyncCallback callback, object state)
        {
            return invokeRespondActivityTaskFailed(respondActivityTaskFailedRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RespondActivityTaskFailed operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondActivityTaskFailed"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskFailed.</param>
        public RespondActivityTaskFailedResponse EndRespondActivityTaskFailed(IAsyncResult asyncResult)
        {
            return endOperation<RespondActivityTaskFailedResponse>(asyncResult);
        }
        
        IAsyncResult invokeRespondActivityTaskFailed(RespondActivityTaskFailedRequest respondActivityTaskFailedRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RespondActivityTaskFailedRequestMarshaller().Marshall(respondActivityTaskFailedRequest);
            var unmarshaller = RespondActivityTaskFailedResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RespondDecisionTaskCompleted

        /// <summary>
        /// <para> Used by deciders to tell the service that the DecisionTask identified by the <c>taskToken</c> has successfully completed. The
        /// <c>decisions</c> argument specifies the list of decisions made while processing the task. </para> <para> A
        /// <c>DecisionTaskCompleted</c> event is added to the workflow history. The <c>executionContext</c> specified is attached
        /// to the event in the workflow execution history. </para> <para> <b>Access Control</b> </para> <para>If an IAM policy grants permission to use
        /// <c>RespondDecisionTaskCompleted</c> , it can express permissions for the list of decisions in the <c>decisions</c> parameter. Each of the
        /// decisions has one or more parameters, much like a regular API call. To allow for policies to be as readable as possible, you can express
        /// permissions on decisions as if they were actual API calls, including applying conditions to some parameters. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="respondDecisionTaskCompletedRequest">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest respondDecisionTaskCompletedRequest)
        {
            IAsyncResult asyncResult = invokeRespondDecisionTaskCompleted(respondDecisionTaskCompletedRequest, null, null, true);
            return EndRespondDecisionTaskCompleted(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondDecisionTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="respondDecisionTaskCompletedRequest">Container for the necessary parameters to execute the RespondDecisionTaskCompleted
        ///          operation on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest respondDecisionTaskCompletedRequest, AsyncCallback callback, object state)
        {
            return invokeRespondDecisionTaskCompleted(respondDecisionTaskCompletedRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.RespondDecisionTaskCompleted"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondDecisionTaskCompleted.</param>
        public RespondDecisionTaskCompletedResponse EndRespondDecisionTaskCompleted(IAsyncResult asyncResult)
        {
            return endOperation<RespondDecisionTaskCompletedResponse>(asyncResult);
        }
        
        IAsyncResult invokeRespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest respondDecisionTaskCompletedRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RespondDecisionTaskCompletedRequestMarshaller().Marshall(respondDecisionTaskCompletedRequest);
            var unmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SignalWorkflowExecution

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="signalWorkflowExecutionRequest">Container for the necessary parameters to execute the SignalWorkflowExecution service method on
        ///          AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest signalWorkflowExecutionRequest)
        {
            IAsyncResult asyncResult = invokeSignalWorkflowExecution(signalWorkflowExecutionRequest, null, null, true);
            return EndSignalWorkflowExecution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SignalWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.SignalWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="signalWorkflowExecutionRequest">Container for the necessary parameters to execute the SignalWorkflowExecution operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSignalWorkflowExecution(SignalWorkflowExecutionRequest signalWorkflowExecutionRequest, AsyncCallback callback, object state)
        {
            return invokeSignalWorkflowExecution(signalWorkflowExecutionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SignalWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.SignalWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalWorkflowExecution.</param>
        public SignalWorkflowExecutionResponse EndSignalWorkflowExecution(IAsyncResult asyncResult)
        {
            return endOperation<SignalWorkflowExecutionResponse>(asyncResult);
        }
        
        IAsyncResult invokeSignalWorkflowExecution(SignalWorkflowExecutionRequest signalWorkflowExecutionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SignalWorkflowExecutionRequestMarshaller().Marshall(signalWorkflowExecutionRequest);
            var unmarshaller = SignalWorkflowExecutionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartWorkflowExecution

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="startWorkflowExecutionRequest">Container for the necessary parameters to execute the StartWorkflowExecution service method on
        ///          AmazonSimpleWorkflow.</param>
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
            IAsyncResult asyncResult = invokeStartWorkflowExecution(startWorkflowExecutionRequest, null, null, true);
            return EndStartWorkflowExecution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.StartWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="startWorkflowExecutionRequest">Container for the necessary parameters to execute the StartWorkflowExecution operation on
        ///          AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndStartWorkflowExecution operation.</returns>
        public IAsyncResult BeginStartWorkflowExecution(StartWorkflowExecutionRequest startWorkflowExecutionRequest, AsyncCallback callback, object state)
        {
            return invokeStartWorkflowExecution(startWorkflowExecutionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.StartWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflowExecution.</param>
        /// 
        /// <returns>Returns a Run from AmazonSimpleWorkflow.</returns>
        public StartWorkflowExecutionResponse EndStartWorkflowExecution(IAsyncResult asyncResult)
        {
            return endOperation<StartWorkflowExecutionResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartWorkflowExecution(StartWorkflowExecutionRequest startWorkflowExecutionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartWorkflowExecutionRequestMarshaller().Marshall(startWorkflowExecutionRequest);
            var unmarshaller = StartWorkflowExecutionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TerminateWorkflowExecution

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
        /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
        /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="terminateWorkflowExecutionRequest">Container for the necessary parameters to execute the TerminateWorkflowExecution service
        ///          method on AmazonSimpleWorkflow.</param>
        /// 
        /// <exception cref="OperationNotPermittedException"/>
        /// <exception cref="UnknownResourceException"/>
        public TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest terminateWorkflowExecutionRequest)
        {
            IAsyncResult asyncResult = invokeTerminateWorkflowExecution(terminateWorkflowExecutionRequest, null, null, true);
            return EndTerminateWorkflowExecution(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.TerminateWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="terminateWorkflowExecutionRequest">Container for the necessary parameters to execute the TerminateWorkflowExecution operation
        ///          on AmazonSimpleWorkflow.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginTerminateWorkflowExecution(TerminateWorkflowExecutionRequest terminateWorkflowExecutionRequest, AsyncCallback callback, object state)
        {
            return invokeTerminateWorkflowExecution(terminateWorkflowExecutionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow.TerminateWorkflowExecution"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkflowExecution.</param>
        public TerminateWorkflowExecutionResponse EndTerminateWorkflowExecution(IAsyncResult asyncResult)
        {
            return endOperation<TerminateWorkflowExecutionResponse>(asyncResult);
        }
        
        IAsyncResult invokeTerminateWorkflowExecution(TerminateWorkflowExecutionRequest terminateWorkflowExecutionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateWorkflowExecutionRequestMarshaller().Marshall(terminateWorkflowExecutionRequest);
            var unmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    

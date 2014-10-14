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
    /// The Amazon Simple Workflow Service (Amazon SWF) makes it easy to build applications
    /// that use Amazon's cloud to coordinate work across distributed components. In Amazon
    /// SWF, a <i>task</i> represents a logical unit of work that is performed by a component
    /// of your workflow. Coordinating tasks in a workflow involves managing intertask dependencies,
    /// scheduling, and concurrency in accordance with the logical flow of the application.
    /// </para>
    ///  
    /// <para>
    /// Amazon SWF gives you full control over implementing tasks and coordinating them without
    /// worrying about underlying complexities such as tracking their progress and maintaining
    /// their state.
    /// </para>
    ///  
    /// <para>
    /// This documentation serves as reference only. For a broader overview of the Amazon
    /// SWF programming model, see the <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/">Amazon
    /// SWF Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSimpleWorkflowClient : AmazonServiceClient, IAmazonSimpleWorkflow
    {
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleWorkflowClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        public AmazonSimpleWorkflowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        /// <summary>
        /// Returns the number of closed workflow executions within the given domain that meet
        /// the specified filtering criteria.
        /// 
        ///  
        /// <para>
        /// <strong>Access Control</strong>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use a <code>Resource</code> element with the domain name to limit the action to only
        /// specified domains.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an <code>Action</code> element to allow or deny permission to call this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Constrain the following parameters by using a <code>Condition</code> element with
        /// the appropriate keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>tagFilter.tag</code>: String constraint. The key is <code>swf:tagFilter.tag</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>typeFilter.name</code>: String constraint. The key is <code>swf:typeFilter.name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>typeFilter.version</code>: String constraint. The key is <code>swf:typeFilter.version</code>.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountClosedWorkflowExecutions
        ///         operation.</returns>
        public IAsyncResult BeginCountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CountClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<CountClosedWorkflowExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CountClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  CountClosedWorkflowExecutionsResult from SimpleWorkflow.</returns>
        public  CountClosedWorkflowExecutionsResponse EndCountClosedWorkflowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<CountClosedWorkflowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CountOpenWorkflowExecutions

        /// <summary>
        /// Returns the number of open workflow executions within the given domain that meet the
        /// specified filtering criteria.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li> <code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li> <code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountOpenWorkflowExecutions
        ///         operation.</returns>
        public IAsyncResult BeginCountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CountOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<CountOpenWorkflowExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CountOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  CountOpenWorkflowExecutionsResult from SimpleWorkflow.</returns>
        public  CountOpenWorkflowExecutionsResponse EndCountOpenWorkflowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<CountOpenWorkflowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CountPendingActivityTasks

        /// <summary>
        /// Returns the estimated number of activity tasks in the specified task list. The count
        /// returned is an approximation and is not guaranteed to be exact. If you specify a task
        /// list that no activity task was ever scheduled in then 0 will be returned.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the <code>taskList.name</code>
        /// parameter by using a <b>Condition</b> element with the <code>swf:taskList.name</code>
        /// key to allow the action to access only certain task lists.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountPendingActivityTasks
        ///         operation.</returns>
        public IAsyncResult BeginCountPendingActivityTasks(CountPendingActivityTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CountPendingActivityTasksRequestMarshaller();
            var unmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return BeginInvoke<CountPendingActivityTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CountPendingActivityTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingActivityTasks.</param>
        /// 
        /// <returns>Returns a  CountPendingActivityTasksResult from SimpleWorkflow.</returns>
        public  CountPendingActivityTasksResponse EndCountPendingActivityTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<CountPendingActivityTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  CountPendingDecisionTasks

        /// <summary>
        /// Returns the estimated number of decision tasks in the specified task list. The count
        /// returned is an approximation and is not guaranteed to be exact. If you specify a task
        /// list that no decision task was ever scheduled in then 0 will be returned.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the <code>taskList.name</code>
        /// parameter by using a <b>Condition</b> element with the <code>swf:taskList.name</code>
        /// key to allow the action to access only certain task lists.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountPendingDecisionTasks
        ///         operation.</returns>
        public IAsyncResult BeginCountPendingDecisionTasks(CountPendingDecisionTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CountPendingDecisionTasksRequestMarshaller();
            var unmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return BeginInvoke<CountPendingDecisionTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CountPendingDecisionTasks operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingDecisionTasks.</param>
        /// 
        /// <returns>Returns a  CountPendingDecisionTasksResult from SimpleWorkflow.</returns>
        public  CountPendingDecisionTasksResponse EndCountPendingDecisionTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<CountPendingDecisionTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DeprecateActivityType

        /// <summary>
        /// Deprecates the specified <i>activity type</i>. After an activity type has been deprecated,
        /// you cannot create new tasks of that activity type. Tasks of this type that were scheduled
        /// before the type was deprecated will continue to run.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>activityType.name</code>:
        /// String constraint. The key is <code>swf:activityType.name</code>.</li> <li> <code>activityType.version</code>:
        /// String constraint. The key is <code>swf:activityType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType service method.</param>
        /// 
        /// <returns>The response from the DeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateActivityType
        ///         operation.</returns>
        public IAsyncResult BeginDeprecateActivityType(DeprecateActivityTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeprecateActivityTypeRequestMarshaller();
            var unmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DeprecateActivityTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateActivityType.</param>
        /// 
        /// <returns>Returns a  DeprecateActivityTypeResult from SimpleWorkflow.</returns>
        public  DeprecateActivityTypeResponse EndDeprecateActivityType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprecateActivityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeprecateDomain

        /// <summary>
        /// Deprecates the specified domain. After a domain has been deprecated it cannot be used
        /// to create new workflow executions or register new types. However, you can still use
        /// visibility actions on this domain. Deprecating a domain also deprecates all activity
        /// and workflow types registered in the domain. Executions that were started before the
        /// domain was deprecated will continue to run.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain service method.</param>
        /// 
        /// <returns>The response from the DeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="DomainDeprecatedException">
        /// Returned when the specified domain has been deprecated.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateDomain
        ///         operation.</returns>
        public IAsyncResult BeginDeprecateDomain(DeprecateDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeprecateDomainRequestMarshaller();
            var unmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DeprecateDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateDomain.</param>
        /// 
        /// <returns>Returns a  DeprecateDomainResult from SimpleWorkflow.</returns>
        public  DeprecateDomainResponse EndDeprecateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprecateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeprecateWorkflowType

        /// <summary>
        /// Deprecates the specified <i>workflow type</i>. After a workflow type has been deprecated,
        /// you cannot create new executions of that type. Executions that were started before
        /// the type was deprecated will continue to run. A deprecated workflow type may still
        /// be used when calling visibility actions.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>workflowType.name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li> <code>workflowType.version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateWorkflowType
        ///         operation.</returns>
        public IAsyncResult BeginDeprecateWorkflowType(DeprecateWorkflowTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeprecateWorkflowTypeRequestMarshaller();
            var unmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DeprecateWorkflowTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateWorkflowType.</param>
        /// 
        /// <returns>Returns a  DeprecateWorkflowTypeResult from SimpleWorkflow.</returns>
        public  DeprecateWorkflowTypeResponse EndDeprecateWorkflowType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprecateWorkflowTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeActivityType

        /// <summary>
        /// Returns information about the specified activity type. This includes configuration
        /// settings provided at registration time as well as other general information about
        /// the type.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>activityType.name</code>:
        /// String constraint. The key is <code>swf:activityType.name</code>.</li> <li> <code>activityType.version</code>:
        /// String constraint. The key is <code>swf:activityType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType service method.</param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivityType
        ///         operation.</returns>
        public IAsyncResult BeginDescribeActivityType(DescribeActivityTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeActivityTypeRequestMarshaller();
            var unmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeActivityTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivityType.</param>
        /// 
        /// <returns>Returns a  DescribeActivityTypeResult from SimpleWorkflow.</returns>
        public  DescribeActivityTypeResponse EndDescribeActivityType(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeActivityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDomain

        /// <summary>
        /// Returns information about the specified domain including description and status.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDomainRequestMarshaller();
            var unmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from SimpleWorkflow.</returns>
        public  DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkflowExecution

        /// <summary>
        /// Returns information about the specified workflow execution including its type and
        /// some statistics.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkflowExecution
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkflowExecution(DescribeWorkflowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkflowExecutionRequestMarshaller();
            var unmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkflowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  DescribeWorkflowExecutionResult from SimpleWorkflow.</returns>
        public  DescribeWorkflowExecutionResponse EndDescribeWorkflowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkflowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkflowType

        /// <summary>
        /// Returns information about the specified <i>workflow type</i>. This includes configuration
        /// settings specified when the type was registered and other information such as creation
        /// date, current status, etc.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>workflowType.name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li> <code>workflowType.version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkflowType
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkflowType(DescribeWorkflowTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkflowTypeRequestMarshaller();
            var unmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkflowTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowType.</param>
        /// 
        /// <returns>Returns a  DescribeWorkflowTypeResult from SimpleWorkflow.</returns>
        public  DescribeWorkflowTypeResponse EndDescribeWorkflowType(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkflowTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflowExecutionHistory

        /// <summary>
        /// Returns the history of the specified workflow execution. The results may be split
        /// into multiple pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call. 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowExecutionHistory
        ///         operation.</returns>
        public IAsyncResult BeginGetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetWorkflowExecutionHistoryRequestMarshaller();
            var unmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetWorkflowExecutionHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowExecutionHistory operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowExecutionHistory.</param>
        /// 
        /// <returns>Returns a  GetWorkflowExecutionHistoryResult from SimpleWorkflow.</returns>
        public  GetWorkflowExecutionHistoryResponse EndGetWorkflowExecutionHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowExecutionHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListActivityTypes

        /// <summary>
        /// Returns information about all activities registered in the specified domain that
        /// match the specified name and registration status. The result includes information
        /// like creation date, current status of the activity, etc. The results may be split
        /// into multiple pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call. 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes service method.</param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActivityTypes
        ///         operation.</returns>
        public IAsyncResult BeginListActivityTypes(ListActivityTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListActivityTypesRequestMarshaller();
            var unmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return BeginInvoke<ListActivityTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActivityTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivityTypes.</param>
        /// 
        /// <returns>Returns a  ListActivityTypesResult from SimpleWorkflow.</returns>
        public  ListActivityTypesResponse EndListActivityTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActivityTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClosedWorkflowExecutions

        /// <summary>
        /// Returns a list of closed workflow executions in the specified domain that meet the
        /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
        /// pages, make the call again using the nextPageToken returned by the initial call. 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li> <code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li> <code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClosedWorkflowExecutions
        ///         operation.</returns>
        public IAsyncResult BeginListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListClosedWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListClosedWorkflowExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClosedWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  ListClosedWorkflowExecutionsResult from SimpleWorkflow.</returns>
        public  ListClosedWorkflowExecutionsResponse EndListClosedWorkflowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClosedWorkflowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Returns the list of domains registered in the account. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken
        /// returned by the initial call. 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains. The element must be set to <code>arn:aws:swf::AccountID:domain/*"</code>,
        /// where "AccountID" is the account ID, with no dashes.</li> <li>Use an <code>Action</code>
        /// element to allow or deny permission to call this action.</li> <li>You cannot use an
        /// IAM policy to constrain this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        public ListDomainsResponse ListDomains(ListDomainsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        public IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDomainsRequestMarshaller();
            var unmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDomainsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from SimpleWorkflow.</returns>
        public  ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOpenWorkflowExecutions

        /// <summary>
        /// Returns a list of open workflow executions in the specified domain that meet the
        /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
        /// pages, make the call again using the nextPageToken returned by the initial call. 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li> <code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li> <code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenWorkflowExecutions
        ///         operation.</returns>
        public IAsyncResult BeginListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOpenWorkflowExecutionsRequestMarshaller();
            var unmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListOpenWorkflowExecutionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenWorkflowExecutions operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  ListOpenWorkflowExecutionsResult from SimpleWorkflow.</returns>
        public  ListOpenWorkflowExecutionsResponse EndListOpenWorkflowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOpenWorkflowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflowTypes

        /// <summary>
        /// Returns information about workflow types in the specified domain. The results may
        /// be split into multiple pages that can be retrieved by making the call repeatedly.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowTypes
        ///         operation.</returns>
        public IAsyncResult BeginListWorkflowTypes(ListWorkflowTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListWorkflowTypesRequestMarshaller();
            var unmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return BeginInvoke<ListWorkflowTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowTypes operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowTypes.</param>
        /// 
        /// <returns>Returns a  ListWorkflowTypesResult from SimpleWorkflow.</returns>
        public  ListWorkflowTypesResponse EndListWorkflowTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  PollForActivityTask

        /// <summary>
        /// Used by workers to get an <a>ActivityTask</a> from the specified activity <code>taskList</code>.
        /// This initiates a long poll, where the service holds the HTTP connection open and responds
        /// as soon as a task becomes available. The maximum time the service holds on to the
        /// request before responding is 60 seconds. If no task is available within 60 seconds,
        /// the poll will return an empty result. An empty result, in this context, means that
        /// an ActivityTask is returned, but that the value of taskToken is an empty string. If
        /// a task is returned, the worker should use its type to identify and process it correctly.
        /// 
        /// 
        ///  <important> Workers should set their client side socket timeout to at least 70 seconds
        /// (10 seconds higher than the maximum time service may hold the poll request). </important>
        /// 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the <code>taskList.name</code>
        /// parameter by using a <b>Condition</b> element with the <code>swf:taskList.name</code>
        /// key to allow the action to access only certain task lists.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask service method.</param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForActivityTask
        ///         operation.</returns>
        public IAsyncResult BeginPollForActivityTask(PollForActivityTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PollForActivityTaskRequestMarshaller();
            var unmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return BeginInvoke<PollForActivityTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PollForActivityTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForActivityTask.</param>
        /// 
        /// <returns>Returns a  PollForActivityTaskResult from SimpleWorkflow.</returns>
        public  PollForActivityTaskResponse EndPollForActivityTask(IAsyncResult asyncResult)
        {
            return EndInvoke<PollForActivityTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  PollForDecisionTask

        /// <summary>
        /// Used by deciders to get a <a>DecisionTask</a> from the specified decision <code>taskList</code>.
        /// A decision task may be returned for any open workflow execution that is using the
        /// specified task list. The task includes a paginated view of the history of the workflow
        /// execution. The decider should use the workflow type and the history to determine how
        /// to properly handle the task.
        /// 
        ///  
        /// <para>
        /// This action initiates a long poll, where the service holds the HTTP connection open
        /// and responds as soon a task becomes available. If no decision task is available in
        /// the specified task list before the timeout of 60 seconds expires, an empty result
        /// is returned. An empty result, in this context, means that a DecisionTask is returned,
        /// but that the value of taskToken is an empty string.
        /// </para>
        ///  <important>Deciders should set their client side socket timeout to at least 70 seconds
        /// (10 seconds higher than the timeout).</important> <important>Because the number of
        /// workflow history events for a single workflow execution might be very large, the result
        /// returned might be split up across a number of pages. To retrieve subsequent pages,
        /// make additional calls to <code>PollForDecisionTask</code> using the <code>nextPageToken</code>
        /// returned by the initial call. Note that you do <b>not</b> call <code>GetWorkflowExecutionHistory</code>
        /// with this <code>nextPageToken</code>. Instead, call <code>PollForDecisionTask</code>
        /// again.</important> 
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the <code>taskList.name</code>
        /// parameter by using a <b>Condition</b> element with the <code>swf:taskList.name</code>
        /// key to allow the action to access only certain task lists.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask service method.</param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForDecisionTask
        ///         operation.</returns>
        public IAsyncResult BeginPollForDecisionTask(PollForDecisionTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PollForDecisionTaskRequestMarshaller();
            var unmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return BeginInvoke<PollForDecisionTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PollForDecisionTask operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForDecisionTask.</param>
        /// 
        /// <returns>Returns a  PollForDecisionTaskResult from SimpleWorkflow.</returns>
        public  PollForDecisionTaskResponse EndPollForDecisionTask(IAsyncResult asyncResult)
        {
            return EndInvoke<PollForDecisionTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  RecordActivityTaskHeartbeat

        /// <summary>
        /// Used by activity workers to report to the service that the <a>ActivityTask</a> represented
        /// by the specified <code>taskToken</code> is still making progress. The worker can also
        /// (optionally) specify details of the progress, for example percent complete, using
        /// the <code>details</code> parameter. This action can also be used by the worker as
        /// a mechanism to check if cancellation is being requested for the activity task. If
        /// a cancellation is being attempted for the specified task, then the boolean <code>cancelRequested</code>
        /// flag returned by the service is set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// This action resets the <code>taskHeartbeatTimeout</code> clock. The <code>taskHeartbeatTimeout</code>
        /// is specified in <a>RegisterActivityType</a>. 
        /// </para>
        ///  
        /// <para>
        /// This action does not in itself create an event in the workflow execution history.
        /// However, if the task times out, the workflow execution history will contain a <code>ActivityTaskTimedOut</code>
        /// event that contains the information from the last heartbeat generated by the activity
        /// worker. 
        /// </para>
        ///  <important> If the <code>cancelRequested</code> flag returns <code>true</code>, a
        /// cancellation is being attempted. If the worker can cancel the activity, it should
        /// respond with <a>RespondActivityTaskCanceled</a>. Otherwise, it should ignore the cancellation
        /// request. </important> 
        /// <para>
        /// <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecordActivityTaskHeartbeat
        ///         operation.</returns>
        public IAsyncResult BeginRecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RecordActivityTaskHeartbeatRequestMarshaller();
            var unmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return BeginInvoke<RecordActivityTaskHeartbeatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecordActivityTaskHeartbeat operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordActivityTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a  RecordActivityTaskHeartbeatResult from SimpleWorkflow.</returns>
        public  RecordActivityTaskHeartbeatResponse EndRecordActivityTaskHeartbeat(IAsyncResult asyncResult)
        {
            return EndInvoke<RecordActivityTaskHeartbeatResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterActivityType

        /// <summary>
        /// Registers a new <i>activity type</i> along with its configuration settings in the
        /// specified domain. 
        /// 
        ///  <important> A <code>TypeAlreadyExists</code> fault is returned if the type already
        /// exists in the domain. You cannot change any configuration settings of the type after
        /// its registration, and it must be registered as a new version. </important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>defaultTaskList.name</code>:
        /// String constraint. The key is <code>swf:defaultTaskList.name</code>.</li> <li> <code>name</code>:
        /// String constraint. The key is <code>swf:name</code>.</li> <li> <code>version</code>:
        /// String constraint. The key is <code>swf:version</code>.</li> </ul> </li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType service method.</param>
        /// 
        /// <returns>The response from the RegisterActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You will get this fault
        /// even if the existing type is in deprecated status. You can specify another version
        /// if the intent is to create a new distinct version of the type.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterActivityType
        ///         operation.</returns>
        public IAsyncResult BeginRegisterActivityType(RegisterActivityTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterActivityTypeRequestMarshaller();
            var unmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterActivityTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterActivityType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterActivityType.</param>
        /// 
        /// <returns>Returns a  RegisterActivityTypeResult from SimpleWorkflow.</returns>
        public  RegisterActivityTypeResponse EndRegisterActivityType(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterActivityTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterDomain

        /// <summary>
        /// Registers a new domain.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>You cannot use an IAM policy to control domain access for this action. The
        /// name of the domain being registered is available as the resource of this action.</li>
        /// <li>Use an <code>Action</code> element to allow or deny permission to call this action.</li>
        /// <li>You cannot use an IAM policy to constrain this action's parameters.</li> </ul>
        /// 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="DomainAlreadyExistsException">
        /// Returned if the specified domain already exists. You will get this fault even if
        /// the existing domain is in deprecated status.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        public RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDomain
        ///         operation.</returns>
        public IAsyncResult BeginRegisterDomain(RegisterDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterDomainRequestMarshaller();
            var unmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDomain operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDomain.</param>
        /// 
        /// <returns>Returns a  RegisterDomainResult from SimpleWorkflow.</returns>
        public  RegisterDomainResponse EndRegisterDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterWorkflowType

        /// <summary>
        /// Registers a new <i>workflow type</i> and its configuration settings in the specified
        /// domain. 
        /// 
        ///  
        /// <para>
        ///  The retention period for the workflow history is set by the <a>RegisterDomain</a>
        /// action. 
        /// </para>
        ///  <important> If the type already exists, then a <code>TypeAlreadyExists</code> fault
        /// is returned. You cannot change the configuration settings of a workflow type once
        /// it is registered and it must be registered as a new version.</important> 
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>defaultTaskList.name</code>:
        /// String constraint. The key is <code>swf:defaultTaskList.name</code>.</li> <li> <code>name</code>:
        /// String constraint. The key is <code>swf:name</code>.</li> <li> <code>version</code>:
        /// String constraint. The key is <code>swf:version</code>.</li> </ul> </li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType service method.</param>
        /// 
        /// <returns>The response from the RegisterWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You will get this fault
        /// even if the existing type is in deprecated status. You can specify another version
        /// if the intent is to create a new distinct version of the type.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterWorkflowType
        ///         operation.</returns>
        public IAsyncResult BeginRegisterWorkflowType(RegisterWorkflowTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterWorkflowTypeRequestMarshaller();
            var unmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterWorkflowTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterWorkflowType operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWorkflowType.</param>
        /// 
        /// <returns>Returns a  RegisterWorkflowTypeResult from SimpleWorkflow.</returns>
        public  RegisterWorkflowTypeResponse EndRegisterWorkflowType(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterWorkflowTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestCancelWorkflowExecution

        /// <summary>
        /// Records a <code>WorkflowExecutionCancelRequested</code> event in the currently running
        /// workflow execution identified by the given domain, workflowId, and runId. This logically
        /// requests the cancellation of the workflow execution as a whole. It is up to the decider
        /// to take appropriate actions when it receives an execution history with this event.
        /// 
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the RequestCancelWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestCancelWorkflowExecution
        ///         operation.</returns>
        public IAsyncResult BeginRequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestCancelWorkflowExecutionRequestMarshaller();
            var unmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<RequestCancelWorkflowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestCancelWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCancelWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  RequestCancelWorkflowExecutionResult from SimpleWorkflow.</returns>
        public  RequestCancelWorkflowExecutionResponse EndRequestCancelWorkflowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestCancelWorkflowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  RespondActivityTaskCanceled

        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> was successfully canceled. Additional <code>details</code>
        /// can be optionally provided using the <code>details</code> argument.
        /// 
        ///  
        /// <para>
        /// These <code>details</code> (if provided) appear in the <code>ActivityTaskCanceled</code>
        /// event added to the workflow history.
        /// </para>
        ///  <important>Only use this operation if the <code>canceled</code> flag of a <a>RecordActivityTaskHeartbeat</a>
        /// request returns <code>true</code> and if the activity can be safely undone or abandoned.</important>
        /// 
        /// <para>
        ///  A task is considered open from the time that it is scheduled until it is closed.
        /// Therefore a task is reported as open while a worker is processing it. A task is closed
        /// after it has been specified in a call to <a>RespondActivityTaskCompleted</a>, RespondActivityTaskCanceled,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCanceled service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskCanceled
        ///         operation.</returns>
        public IAsyncResult BeginRespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RespondActivityTaskCanceledRequestMarshaller();
            var unmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return BeginInvoke<RespondActivityTaskCanceledRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskCanceled operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCanceled.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskCanceledResult from SimpleWorkflow.</returns>
        public  RespondActivityTaskCanceledResponse EndRespondActivityTaskCanceled(IAsyncResult asyncResult)
        {
            return EndInvoke<RespondActivityTaskCanceledResponse>(asyncResult);
        }

        #endregion
        
        #region  RespondActivityTaskCompleted

        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> completed successfully with a <code>result</code> (if provided).
        /// The <code>result</code> appears in the <code>ActivityTaskCompleted</code> event in
        /// the workflow history.
        /// 
        ///  <important> If the requested task does not complete successfully, use <a>RespondActivityTaskFailed</a>
        /// instead. If the worker finds that the task is canceled through the <code>canceled</code>
        /// flag returned by <a>RecordActivityTaskHeartbeat</a>, it should cancel the task, clean
        /// up and then call <a>RespondActivityTaskCanceled</a>.</important> 
        /// <para>
        ///  A task is considered open from the time that it is scheduled until it is closed.
        /// Therefore a task is reported as open while a worker is processing it. A task is closed
        /// after it has been specified in a call to RespondActivityTaskCompleted, <a>RespondActivityTaskCanceled</a>,
        /// <a>RespondActivityTaskFailed</a>, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskCompleted
        ///         operation.</returns>
        public IAsyncResult BeginRespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RespondActivityTaskCompletedRequestMarshaller();
            var unmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return BeginInvoke<RespondActivityTaskCompletedRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCompleted.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskCompletedResult from SimpleWorkflow.</returns>
        public  RespondActivityTaskCompletedResponse EndRespondActivityTaskCompleted(IAsyncResult asyncResult)
        {
            return EndInvoke<RespondActivityTaskCompletedResponse>(asyncResult);
        }

        #endregion
        
        #region  RespondActivityTaskFailed

        /// <summary>
        /// Used by workers to tell the service that the <a>ActivityTask</a> identified by the
        /// <code>taskToken</code> has failed with <code>reason</code> (if specified). The <code>reason</code>
        /// and <code>details</code> appear in the <code>ActivityTaskFailed</code> event added
        /// to the workflow history.
        /// 
        ///  
        /// <para>
        ///  A task is considered open from the time that it is scheduled until it is closed.
        /// Therefore a task is reported as open while a worker is processing it. A task is closed
        /// after it has been specified in a call to <a>RespondActivityTaskCompleted</a>, <a>RespondActivityTaskCanceled</a>,
        /// RespondActivityTaskFailed, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
        /// out</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskFailed service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskFailed
        ///         operation.</returns>
        public IAsyncResult BeginRespondActivityTaskFailed(RespondActivityTaskFailedRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RespondActivityTaskFailedRequestMarshaller();
            var unmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return BeginInvoke<RespondActivityTaskFailedRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskFailed operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskFailed.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskFailedResult from SimpleWorkflow.</returns>
        public  RespondActivityTaskFailedResponse EndRespondActivityTaskFailed(IAsyncResult asyncResult)
        {
            return EndInvoke<RespondActivityTaskFailedResponse>(asyncResult);
        }

        #endregion
        
        #region  RespondDecisionTaskCompleted

        /// <summary>
        /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
        /// <code>taskToken</code> has successfully completed. The <code>decisions</code> argument
        /// specifies the list of decisions made while processing the task.
        /// 
        ///  
        /// <para>
        ///  A <code>DecisionTaskCompleted</code> event is added to the workflow history. The
        /// <code>executionContext</code> specified is attached to the event in the workflow execution
        /// history.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// If an IAM policy grants permission to use <code>RespondDecisionTaskCompleted</code>,
        /// it can express permissions for the list of decisions in the <code>decisions</code>
        /// parameter. Each of the decisions has one or more parameters, much like a regular API
        /// call. To allow for policies to be as readable as possible, you can express permissions
        /// on decisions as if they were actual API calls, including applying conditions to some
        /// parameters. For more information, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted service method.</param>
        /// 
        /// <returns>The response from the RespondDecisionTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondDecisionTaskCompleted
        ///         operation.</returns>
        public IAsyncResult BeginRespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RespondDecisionTaskCompletedRequestMarshaller();
            var unmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return BeginInvoke<RespondDecisionTaskCompletedRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RespondDecisionTaskCompleted operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondDecisionTaskCompleted.</param>
        /// 
        /// <returns>Returns a  RespondDecisionTaskCompletedResult from SimpleWorkflow.</returns>
        public  RespondDecisionTaskCompletedResponse EndRespondDecisionTaskCompleted(IAsyncResult asyncResult)
        {
            return EndInvoke<RespondDecisionTaskCompletedResponse>(asyncResult);
        }

        #endregion
        
        #region  SignalWorkflowExecution

        /// <summary>
        /// Records a <code>WorkflowExecutionSignaled</code> event in the workflow execution
        /// history and creates a decision task for the workflow execution identified by the given
        /// domain, workflowId and runId. The event is recorded with the specified user defined
        /// signalName and input (if provided).
        /// 
        ///  
        /// <para>
        ///  <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the SignalWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalWorkflowExecution
        ///         operation.</returns>
        public IAsyncResult BeginSignalWorkflowExecution(SignalWorkflowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SignalWorkflowExecutionRequestMarshaller();
            var unmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<SignalWorkflowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SignalWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  SignalWorkflowExecutionResult from SimpleWorkflow.</returns>
        public  SignalWorkflowExecutionResponse EndSignalWorkflowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<SignalWorkflowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWorkflowExecution

        /// <summary>
        /// Starts an execution of the workflow type in the specified domain using the provided
        /// <code>workflowId</code> and input data.
        /// 
        ///  
        /// <para>
        /// This action returns the newly started workflow execution.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>Constrain the following parameters by
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tagList.member.0</code>:
        /// The key is <code>swf:tagList.member.0</code>.</li> <li> <code>tagList.member.1</code>:
        /// The key is <code>swf:tagList.member.1</code>.</li> <li> <code>tagList.member.2</code>:
        /// The key is <code>swf:tagList.member.2</code>.</li> <li> <code>tagList.member.3</code>:
        /// The key is <code>swf:tagList.member.3</code>.</li> <li> <code>tagList.member.4</code>:
        /// The key is <code>swf:tagList.member.4</code>.</li> <li> <code>taskList</code>: String
        /// constraint. The key is <code>swf:taskList.name</code>.</li> <li> <code>name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li> <code>version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the StartWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="DefaultUndefinedException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <exception cref="WorkflowExecutionAlreadyStartedException">
        /// Returned by <a>StartWorkflowExecution</a> when an open execution with the same workflowId
        /// is already running in the specified domain.
        /// </exception>
        public StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkflowExecution
        ///         operation.</returns>
        public IAsyncResult BeginStartWorkflowExecution(StartWorkflowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartWorkflowExecutionRequestMarshaller();
            var unmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<StartWorkflowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  StartWorkflowExecutionResult from SimpleWorkflow.</returns>
        public  StartWorkflowExecutionResponse EndStartWorkflowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWorkflowExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateWorkflowExecution

        /// <summary>
        /// Records a <code>WorkflowExecutionTerminated</code> event and forces closure of the
        /// workflow execution identified by the given domain, runId, and workflowId. The child
        /// policy, registered with the workflow type or specified when starting this execution,
        /// is applied to any open child workflow executions of this workflow execution.
        /// 
        ///  <important> If the identified workflow execution was in progress, it is terminated
        /// immediately.</important> 
        /// <para>
        ///  <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
        /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
        /// this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails by throwing <code>OperationNotPermitted</code>.
        /// For details and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        public TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkflowExecution
        ///         operation.</returns>
        public IAsyncResult BeginTerminateWorkflowExecution(TerminateWorkflowExecutionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateWorkflowExecutionRequestMarshaller();
            var unmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateWorkflowExecutionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkflowExecution operation.
        /// <seealso cref="Amazon.SimpleWorkflow.IAmazonSimpleWorkflow"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  TerminateWorkflowExecutionResult from SimpleWorkflow.</returns>
        public  TerminateWorkflowExecutionResponse EndTerminateWorkflowExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateWorkflowExecutionResponse>(asyncResult);
        }

        #endregion
        
    }
}
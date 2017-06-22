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

using Amazon.Runtime;
using Amazon.SimpleWorkflow.Model;

namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Interface for accessing SimpleWorkflow
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
    public partial interface IAmazonSimpleWorkflow : IAmazonService, IDisposable
    {

        
        #region  CountClosedWorkflowExecutions


        /// <summary>
        /// Returns the number of closed workflow executions within the given domain that meet
        /// the specified filtering criteria.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li><code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li><code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountClosedWorkflowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        IAsyncResult BeginCountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CountClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  CountClosedWorkflowExecutionsResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        CountClosedWorkflowExecutionsResponse EndCountClosedWorkflowExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  CountOpenWorkflowExecutions


        /// <summary>
        /// Returns the number of open workflow executions within the given domain that meet the
        /// specified filtering criteria.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li><code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li><code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the CountOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountOpenWorkflowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        IAsyncResult BeginCountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CountOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  CountOpenWorkflowExecutionsResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        CountOpenWorkflowExecutionsResponse EndCountOpenWorkflowExecutions(IAsyncResult asyncResult);

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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingActivityTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingActivityTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountPendingActivityTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        IAsyncResult BeginCountPendingActivityTasks(CountPendingActivityTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CountPendingActivityTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingActivityTasks.</param>
        /// 
        /// <returns>Returns a  CountPendingActivityTasksResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        CountPendingActivityTasksResponse EndCountPendingActivityTasks(IAsyncResult asyncResult);

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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks service method.</param>
        /// 
        /// <returns>The response from the CountPendingDecisionTasks service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingDecisionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCountPendingDecisionTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        IAsyncResult BeginCountPendingDecisionTasks(CountPendingDecisionTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CountPendingDecisionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCountPendingDecisionTasks.</param>
        /// 
        /// <returns>Returns a  CountPendingDecisionTasksResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        CountPendingDecisionTasksResponse EndCountPendingDecisionTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DeprecateActivityType


        /// <summary>
        /// Deprecates the specified <i>activity type</i>. After an activity type has been deprecated,
        /// you cannot create new tasks of that activity type. Tasks of this type that were scheduled
        /// before the type was deprecated will continue to run.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>activityType.name</code>:
        /// String constraint. The key is <code>swf:activityType.name</code>.</li> <li><code>activityType.version</code>:
        /// String constraint. The key is <code>swf:activityType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType service method.</param>
        /// 
        /// <returns>The response from the DeprecateActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateActivityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        IAsyncResult BeginDeprecateActivityType(DeprecateActivityTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateActivityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateActivityType.</param>
        /// 
        /// <returns>Returns a  DeprecateActivityTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        DeprecateActivityTypeResponse EndDeprecateActivityType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeprecateDomain


        /// <summary>
        /// Deprecates the specified domain. After a domain has been deprecated it cannot be used
        /// to create new workflow executions or register new types. However, you can still use
        /// visibility actions on this domain. Deprecating a domain also deprecates all activity
        /// and workflow types registered in the domain. Executions that were started before the
        /// domain was deprecated will continue to run.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain service method.</param>
        /// 
        /// <returns>The response from the DeprecateDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainDeprecatedException">
        /// Returned when the specified domain has been deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        IAsyncResult BeginDeprecateDomain(DeprecateDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateDomain.</param>
        /// 
        /// <returns>Returns a  DeprecateDomainResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        DeprecateDomainResponse EndDeprecateDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DeprecateWorkflowType


        /// <summary>
        /// Deprecates the specified <i>workflow type</i>. After a workflow type has been deprecated,
        /// you cannot create new executions of that type. Executions that were started before
        /// the type was deprecated will continue to run. A deprecated workflow type may still
        /// be used when calling visibility actions.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>workflowType.name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li><code>workflowType.version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DeprecateWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateWorkflowType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        IAsyncResult BeginDeprecateWorkflowType(DeprecateWorkflowTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateWorkflowType.</param>
        /// 
        /// <returns>Returns a  DeprecateWorkflowTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        DeprecateWorkflowTypeResponse EndDeprecateWorkflowType(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActivityType


        /// <summary>
        /// Returns information about the specified activity type. This includes configuration
        /// settings provided when the type was registered and other general information about
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>activityType.name</code>:
        /// String constraint. The key is <code>swf:activityType.name</code>.</li> <li><code>activityType.version</code>:
        /// String constraint. The key is <code>swf:activityType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType service method.</param>
        /// 
        /// <returns>The response from the DescribeActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        IAsyncResult BeginDescribeActivityType(DescribeActivityTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivityType.</param>
        /// 
        /// <returns>Returns a  DescribeActivityTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        DescribeActivityTypeResponse EndDescribeActivityType(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomain


        /// <summary>
        /// Returns information about the specified domain, including description and status.
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse DescribeDomain(DescribeDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        IAsyncResult BeginDescribeDomain(DescribeDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomain.</param>
        /// 
        /// <returns>Returns a  DescribeDomainResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        DescribeDomainResponse EndDescribeDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkflowExecution


        /// <summary>
        /// Returns information about the specified workflow execution including its type and
        /// some statistics.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkflowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        IAsyncResult BeginDescribeWorkflowExecution(DescribeWorkflowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  DescribeWorkflowExecutionResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        DescribeWorkflowExecutionResponse EndDescribeWorkflowExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkflowType


        /// <summary>
        /// Returns information about the specified <i>workflow type</i>. This includes configuration
        /// settings specified when the type was registered and other information such as creation
        /// date, current status, and so on.
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>workflowType.name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li><code>workflowType.version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkflowType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        IAsyncResult BeginDescribeWorkflowType(DescribeWorkflowTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkflowType.</param>
        /// 
        /// <returns>Returns a  DescribeWorkflowTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        DescribeWorkflowTypeResponse EndDescribeWorkflowType(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflowExecutionHistory


        /// <summary>
        /// Returns the history of the specified workflow execution. The results may be split
        /// into multiple pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowExecutionHistory service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowExecutionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        IAsyncResult BeginGetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowExecutionHistory.</param>
        /// 
        /// <returns>Returns a  GetWorkflowExecutionHistoryResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        GetWorkflowExecutionHistoryResponse EndGetWorkflowExecutionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActivityTypes


        /// <summary>
        /// Returns information about all activities registered in the specified domain that match
        /// the specified name and registration status. The result includes information like creation
        /// date, current status of the activity, etc. The results may be split into multiple
        /// pages. To retrieve subsequent pages, make the call again using the <code>nextPageToken</code>
        /// returned by the initial call.
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes service method.</param>
        /// 
        /// <returns>The response from the ListActivityTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActivityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActivityTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        IAsyncResult BeginListActivityTypes(ListActivityTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActivityTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivityTypes.</param>
        /// 
        /// <returns>Returns a  ListActivityTypesResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        ListActivityTypesResponse EndListActivityTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClosedWorkflowExecutions


        /// <summary>
        /// Returns a list of closed workflow executions in the specified domain that meet the
        /// filtering criteria. The results may be split into multiple pages. To retrieve subsequent
        /// pages, make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note>This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li><code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li><code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListClosedWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClosedWorkflowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        IAsyncResult BeginListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClosedWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  ListClosedWorkflowExecutionsResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        ListClosedWorkflowExecutionsResponse EndListClosedWorkflowExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns the list of domains registered in the account. The results may be split into
        /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken
        /// returned by the initial call.
        /// 
        ///  <note> This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
        /// <para>
        /// <b>Access Control</b>
        /// </para>
        ///  
        /// <para>
        /// You can use IAM policies to control this action's access to Amazon SWF resources as
        /// follows:
        /// </para>
        ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
        /// to only specified domains. The element must be set to <code>arn:aws:swf::AccountID:domain/*</code>,
        /// where <i>AccountID</i> is the account ID, with no dashes.</li> <li>Use an <code>Action</code>
        /// element to allow or deny permission to call this action.</li> <li>You cannot use an
        /// IAM policy to constrain this action's parameters.</li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse EndListDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOpenWorkflowExecutions


        /// <summary>
        /// Returns a list of open workflow executions in the specified domain that meet the filtering
        /// criteria. The results may be split into multiple pages. To retrieve subsequent pages,
        /// make the call again using the nextPageToken returned by the initial call.
        /// 
        ///  <note> This operation is eventually consistent. The results are best effort and may
        /// not exactly reflect recent updates and changes.</note> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li><code>tagFilter.tag</code>:
        /// String constraint. The key is <code>swf:tagFilter.tag</code>.</li> <li><code>typeFilter.name</code>:
        /// String constraint. The key is <code>swf:typeFilter.name</code>.</li> <li><code>typeFilter.version</code>:
        /// String constraint. The key is <code>swf:typeFilter.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions service method.</param>
        /// 
        /// <returns>The response from the ListOpenWorkflowExecutions service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenWorkflowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        IAsyncResult BeginListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenWorkflowExecutions.</param>
        /// 
        /// <returns>Returns a  ListOpenWorkflowExecutionsResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        ListOpenWorkflowExecutionsResponse EndListOpenWorkflowExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflowTypes


        /// <summary>
        /// Returns information about workflow types in the specified domain. The results may
        /// be split into multiple pages that can be retrieved by making the call repeatedly.
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowTypes service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        IAsyncResult BeginListWorkflowTypes(ListWorkflowTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowTypes.</param>
        /// 
        /// <returns>Returns a  ListWorkflowTypesResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        ListWorkflowTypesResponse EndListWorkflowTypes(IAsyncResult asyncResult);

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
        ///  <important>Workers should set their client side socket timeout to at least 70 seconds
        /// (10 seconds higher than the maximum time service may hold the poll request).</important>
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask service method.</param>
        /// 
        /// <returns>The response from the PollForActivityTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PollForActivityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForActivityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        IAsyncResult BeginPollForActivityTask(PollForActivityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PollForActivityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForActivityTask.</param>
        /// 
        /// <returns>Returns a  PollForActivityTaskResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        PollForActivityTaskResponse EndPollForActivityTask(IAsyncResult asyncResult);

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
        /// but that the value of <code>taskToken</code> is an empty string.
        /// </para>
        ///  <important>Deciders should set their client-side socket timeout to at least 70 seconds
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask service method.</param>
        /// 
        /// <returns>The response from the PollForDecisionTask service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PollForDecisionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPollForDecisionTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        IAsyncResult BeginPollForDecisionTask(PollForDecisionTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PollForDecisionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPollForDecisionTask.</param>
        /// 
        /// <returns>Returns a  PollForDecisionTaskResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        PollForDecisionTaskResponse EndPollForDecisionTask(IAsyncResult asyncResult);

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
        ///  <note>The <code>taskStartToCloseTimeout</code> of an activity type is the maximum
        /// duration of an activity task, regardless of the number of <a>RecordActivityTaskHeartbeat</a>
        /// requests received. The <code>taskStartToCloseTimeout</code> is also specified in <a>RegisterActivityType</a>.</note>
        /// <note>This operation is only useful for long-lived activities to report liveliness
        /// of the task and to determine if a cancellation is being attempted. </note> <important>If
        /// the <code>cancelRequested</code> flag returns <code>true</code>, a cancellation is
        /// being attempted. If the worker can cancel the activity, it should respond with <a>RespondActivityTaskCanceled</a>.
        /// Otherwise, it should ignore the cancellation request.</important> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordActivityTaskHeartbeat service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecordActivityTaskHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        IAsyncResult BeginRecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecordActivityTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordActivityTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a  RecordActivityTaskHeartbeatResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        RecordActivityTaskHeartbeatResponse EndRecordActivityTaskHeartbeat(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterActivityType


        /// <summary>
        /// Registers a new <i>activity type</i> along with its configuration settings in the
        /// specified domain.
        /// 
        ///  <important>A <code>TypeAlreadyExists</code> fault is returned if the type already
        /// exists in the domain. You cannot change any configuration settings of the type after
        /// its registration, and it must be registered as a new version.</important> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>defaultTaskList.name</code>:
        /// String constraint. The key is <code>swf:defaultTaskList.name</code>.</li> <li> <code>name</code>:
        /// String constraint. The key is <code>swf:name</code>.</li> <li> <code>version</code>:
        /// String constraint. The key is <code>swf:version</code>.</li> </ul> </li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType service method.</param>
        /// 
        /// <returns>The response from the RegisterActivityType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You will get this fault
        /// even if the existing type is in deprecated status. You can specify another version
        /// if the intent is to create a new distinct version of the type.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterActivityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        IAsyncResult BeginRegisterActivityType(RegisterActivityTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterActivityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterActivityType.</param>
        /// 
        /// <returns>Returns a  RegisterActivityTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        RegisterActivityTypeResponse EndRegisterActivityType(IAsyncResult asyncResult);

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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterDomain service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DomainAlreadyExistsException">
        /// Returned if the specified domain already exists. You will get this fault even if the
        /// existing domain is in deprecated status.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        RegisterDomainResponse RegisterDomain(RegisterDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        IAsyncResult BeginRegisterDomain(RegisterDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDomain.</param>
        /// 
        /// <returns>Returns a  RegisterDomainResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        RegisterDomainResponse EndRegisterDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterWorkflowType


        /// <summary>
        /// Registers a new <i>workflow type</i> and its configuration settings in the specified
        /// domain.
        /// 
        ///  
        /// <para>
        /// The retention period for the workflow history is set by the <a>RegisterDomain</a>
        /// action.
        /// </para>
        ///  <important>If the type already exists, then a <code>TypeAlreadyExists</code> fault
        /// is returned. You cannot change the configuration settings of a workflow type once
        /// it is registered and it must be registered as a new version.</important> 
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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>defaultTaskList.name</code>:
        /// String constraint. The key is <code>swf:defaultTaskList.name</code>.</li> <li> <code>name</code>:
        /// String constraint. The key is <code>swf:name</code>.</li> <li> <code>version</code>:
        /// String constraint. The key is <code>swf:version</code>.</li> </ul> </li> </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType service method.</param>
        /// 
        /// <returns>The response from the RegisterWorkflowType service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeAlreadyExistsException">
        /// Returned if the type already exists in the specified domain. You will get this fault
        /// even if the existing type is in deprecated status. You can specify another version
        /// if the intent is to create a new distinct version of the type.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterWorkflowType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        IAsyncResult BeginRegisterWorkflowType(RegisterWorkflowTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterWorkflowType.</param>
        /// 
        /// <returns>Returns a  RegisterWorkflowTypeResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        RegisterWorkflowTypeResponse EndRegisterWorkflowType(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestCancelWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionCancelRequested</code> event in the currently running
        /// workflow execution identified by the given domain, workflowId, and runId. This logically
        /// requests the cancellation of the workflow execution as a whole. It is up to the decider
        /// to take appropriate actions when it receives an execution history with this event.
        /// 
        ///  <note>If the runId is not specified, the <code>WorkflowExecutionCancelRequested</code>
        /// event is recorded in the history of the current open workflow execution with the specified
        /// workflowId in the domain.</note> <note>Because this action allows the workflow to
        /// properly clean up and gracefully close, it should be used instead of <a>TerminateWorkflowExecution</a>
        /// when possible.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the RequestCancelWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestCancelWorkflowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        IAsyncResult BeginRequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestCancelWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCancelWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  RequestCancelWorkflowExecutionResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        RequestCancelWorkflowExecutionResponse EndRequestCancelWorkflowExecution(IAsyncResult asyncResult);

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
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, RespondActivityTaskCanceled,
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCanceled service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskCanceled
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        IAsyncResult BeginRespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskCanceled operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCanceled.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskCanceledResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        RespondActivityTaskCanceledResponse EndRespondActivityTaskCanceled(IAsyncResult asyncResult);

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
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to RespondActivityTaskCompleted, <a>RespondActivityTaskCanceled</a>,
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskCompleted service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskCompleted
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        IAsyncResult BeginRespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskCompleted.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskCompletedResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        RespondActivityTaskCompletedResponse EndRespondActivityTaskCompleted(IAsyncResult asyncResult);

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
        /// A task is considered open from the time that it is scheduled until it is closed. Therefore
        /// a task is reported as open while a worker is processing it. A task is closed after
        /// it has been specified in a call to <a>RespondActivityTaskCompleted</a>, <a>RespondActivityTaskCanceled</a>,
        /// RespondActivityTaskFailed, or the task has <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dg-basic.html#swf-dev-timeout-types">timed
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed service method.</param>
        /// 
        /// <returns>The response from the RespondActivityTaskFailed service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskFailed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondActivityTaskFailed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        IAsyncResult BeginRespondActivityTaskFailed(RespondActivityTaskFailedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RespondActivityTaskFailed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondActivityTaskFailed.</param>
        /// 
        /// <returns>Returns a  RespondActivityTaskFailedResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        RespondActivityTaskFailedResponse EndRespondActivityTaskFailed(IAsyncResult asyncResult);

        #endregion
        
        #region  RespondDecisionTaskCompleted


        /// <summary>
        /// Used by deciders to tell the service that the <a>DecisionTask</a> identified by the
        /// <code>taskToken</code> has successfully completed. The <code>decisions</code> argument
        /// specifies the list of decisions made while processing the task.
        /// 
        ///  
        /// <para>
        /// A <code>DecisionTaskCompleted</code> event is added to the workflow history. The <code>executionContext</code>
        /// specified is attached to the event in the workflow execution history.
        /// </para>
        ///  
        /// <para>
        /// <b>Access Control</b>
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
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRespondDecisionTaskCompleted
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        IAsyncResult BeginRespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RespondDecisionTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRespondDecisionTaskCompleted.</param>
        /// 
        /// <returns>Returns a  RespondDecisionTaskCompletedResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        RespondDecisionTaskCompletedResponse EndRespondDecisionTaskCompleted(IAsyncResult asyncResult);

        #endregion
        
        #region  SignalWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionSignaled</code> event in the workflow execution history
        /// and creates a decision task for the workflow execution identified by the given domain,
        /// workflowId and runId. The event is recorded with the specified user defined signalName
        /// and input (if provided).
        /// 
        ///  <note> If a runId is not specified, then the <code>WorkflowExecutionSignaled</code>
        /// event is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.</note> <note> If the specified workflow execution is not open, this
        /// method fails with <code>UnknownResource</code>.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the SignalWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SignalWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalWorkflowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        IAsyncResult BeginSignalWorkflowExecution(SignalWorkflowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SignalWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  SignalWorkflowExecutionResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        SignalWorkflowExecutionResponse EndSignalWorkflowExecution(IAsyncResult asyncResult);

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
        /// using a <code>Condition</code> element with the appropriate keys. <ul> <li> <code>tagList.member.0</code>:
        /// The key is <code>swf:tagList.member.0</code>.</li> <li> <code>tagList.member.1</code>:
        /// The key is <code>swf:tagList.member.1</code>.</li> <li> <code>tagList.member.2</code>:
        /// The key is <code>swf:tagList.member.2</code>.</li> <li> <code>tagList.member.3</code>:
        /// The key is <code>swf:tagList.member.3</code>.</li> <li> <code>tagList.member.4</code>:
        /// The key is <code>swf:tagList.member.4</code>.</li> <li><code>taskList</code>: String
        /// constraint. The key is <code>swf:taskList.name</code>.</li> <li><code>workflowType.name</code>:
        /// String constraint. The key is <code>swf:workflowType.name</code>.</li> <li><code>workflowType.version</code>:
        /// String constraint. The key is <code>swf:workflowType.version</code>.</li> </ul> </li>
        /// </ul> 
        /// <para>
        /// If the caller does not have sufficient permissions to invoke the action, or the parameter
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the StartWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.DefaultUndefinedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.LimitExceededException">
        /// Returned by any operation if a system imposed limitation has been reached. To address
        /// this fault you should either clean up unused resources or increase the limit by contacting
        /// AWS.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.TypeDeprecatedException">
        /// Returned when the specified activity or workflow type was already deprecated.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.WorkflowExecutionAlreadyStartedException">
        /// Returned by <a>StartWorkflowExecution</a> when an open execution with the same workflowId
        /// is already running in the specified domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkflowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        IAsyncResult BeginStartWorkflowExecution(StartWorkflowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  StartWorkflowExecutionResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        StartWorkflowExecutionResponse EndStartWorkflowExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateWorkflowExecution


        /// <summary>
        /// Records a <code>WorkflowExecutionTerminated</code> event and forces closure of the
        /// workflow execution identified by the given domain, runId, and workflowId. The child
        /// policy, registered with the workflow type or specified when starting this execution,
        /// is applied to any open child workflow executions of this workflow execution.
        /// 
        ///  <important> If the identified workflow execution was in progress, it is terminated
        /// immediately.</important> <note> If a runId is not specified, then the <code>WorkflowExecutionTerminated</code>
        /// event is recorded in the history of the current open workflow with the matching workflowId
        /// in the domain.</note> <note> You should consider using <a>RequestCancelWorkflowExecution</a>
        /// action instead because it allows the workflow to gracefully close while <a>TerminateWorkflowExecution</a>
        /// does not.</note> 
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
        /// values fall outside the specified constraints, the action fails. The associated event
        /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
        /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
        /// IAM to Manage Access to Amazon SWF Workflows</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkflowExecution service method, as returned by SimpleWorkflow.</returns>
        /// <exception cref="Amazon.SimpleWorkflow.Model.OperationNotPermittedException">
        /// Returned when the caller does not have sufficient permissions to invoke the action.
        /// </exception>
        /// <exception cref="Amazon.SimpleWorkflow.Model.UnknownResourceException">
        /// Returned when the named resource cannot be found with in the scope of this operation
        /// (region or domain). This could happen if the named resource was never created or is
        /// no longer available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution operation on AmazonSimpleWorkflowClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkflowExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        IAsyncResult BeginTerminateWorkflowExecution(TerminateWorkflowExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkflowExecution.</param>
        /// 
        /// <returns>Returns a  TerminateWorkflowExecutionResult from SimpleWorkflow.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        TerminateWorkflowExecutionResponse EndTerminateWorkflowExecution(IAsyncResult asyncResult);

        #endregion
        
    }
}
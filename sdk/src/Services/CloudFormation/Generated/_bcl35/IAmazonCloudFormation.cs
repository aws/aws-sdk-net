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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Interface for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation allows you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. You can use AWS CloudFormation to leverage AWS products,
    /// such as Amazon Elastic Compute Cloud, Amazon Elastic Block Store, Amazon Simple Notification
    /// Service, Elastic Load Balancing, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost-effective applications without creating or configuring the underlying
    /// AWS infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With AWS CloudFormation, you declare all of your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// AWS CloudFormation creates and deletes all member resources of the stack together
    /// and manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">AWS
    /// CloudFormation Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="http://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFormation : IAmazonService, IDisposable
    {

        
        #region  CancelUpdateStack


        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the UPDATE_IN_PROGRESS state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack service method.</param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelUpdateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        IAsyncResult BeginCancelUpdateStack(CancelUpdateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelUpdateStack.</param>
        /// 
        /// <returns>Returns a  CancelUpdateStackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        CancelUpdateStackResponse EndCancelUpdateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  ContinueUpdateRollback


        /// <summary>
        /// For a specified stack that is in the <code>UPDATE_ROLLBACK_FAILED</code> state, continues
        /// rolling it back to the <code>UPDATE_ROLLBACK_COMPLETE</code> state. Depending on the
        /// cause of the failure, you can manually <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <code>UPDATE_ROLLBACK_COMPLETE</code> state), and
        /// then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <code>UPDATE_ROLLBACK_FAILED</code> state when AWS CloudFormation
        /// cannot roll back all changes after a failed stack update. For example, you might have
        /// a stack that is rolling back to an old database instance that was deleted outside
        /// of AWS CloudFormation. Because AWS CloudFormation doesn't know the database was deleted,
        /// it assumes that the database instance still exists and attempts to roll back to it,
        /// causing the update rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContinueUpdateRollback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        IAsyncResult BeginContinueUpdateRollback(ContinueUpdateRollbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginContinueUpdateRollback.</param>
        /// 
        /// <returns>Returns a  ContinueUpdateRollbackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        ContinueUpdateRollbackResponse EndContinueUpdateRollback(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChangeSet


        /// <summary>
        /// Creates a list of changes that will be applied to a stack so that you can review the
        /// changes before executing them. You can create a change set for a stack that doesn't
        /// exist or an existing stack. If you create a change set for a stack that doesn't exist,
        /// the change set shows all of the resources that AWS CloudFormation will create. If
        /// you create a change set for an existing stack, AWS CloudFormation compares the stack's
        /// information with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources AWS CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <code>ChangeSetType</code>
        /// parameter, specify <code>CREATE</code>. To create a change set for an existing stack,
        /// specify <code>UPDATE</code> for the <code>ChangeSetType</code> parameter. After the
        /// <code>CreateChangeSet</code> call successfully completes, AWS CloudFormation starts
        /// creating the change set. To check the status of the change set or to review it, use
        /// the <a>DescribeChangeSet</a> action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. AWS CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        IAsyncResult BeginCreateChangeSet(CreateChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChangeSet.</param>
        /// 
        /// <returns>Returns a  CreateChangeSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        CreateChangeSetResponse EndCreateChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// 
        /// <returns>The response from the CreateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse CreateStack(CreateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        IAsyncResult BeginCreateStack(CreateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStack.</param>
        /// 
        /// <returns>Returns a  CreateStackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        CreateStackResponse EndCreateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStackInstances


        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified regions.
        /// A stack instance refers to a stack in a specific account and region. <code>Accounts</code>
        /// and <code>Regions</code> are required parameters—you must specify at least one account
        /// and one region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances service method.</param>
        /// 
        /// <returns>The response from the CreateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStackInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        IAsyncResult BeginCreateStackInstances(CreateStackInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStackInstances.</param>
        /// 
        /// <returns>Returns a  CreateStackInstancesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        CreateStackInstancesResponse EndCreateStackInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStackSet


        /// <summary>
        /// Creates a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet service method.</param>
        /// 
        /// <returns>The response from the CreateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CreatedButModifiedException">
        /// The specified resource exists, but has been changed.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information on stack set limitations, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-limitations.html">Limitations
        /// of StackSets</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.NameAlreadyExistsException">
        /// The specified name is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        CreateStackSetResponse CreateStackSet(CreateStackSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStackSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        IAsyncResult BeginCreateStackSet(CreateStackSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStackSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStackSet.</param>
        /// 
        /// <returns>Returns a  CreateStackSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        CreateStackSetResponse EndCreateStackSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChangeSet


        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, AWS CloudFormation successfully deleted the change
        /// set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        IAsyncResult BeginDeleteChangeSet(DeleteChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChangeSet.</param>
        /// 
        /// <returns>Returns a  DeleteChangeSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        DeleteChangeSetResponse EndDeleteChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks do not show up in the <a>DescribeStacks</a> API if the deletion has
        /// been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse DeleteStack(DeleteStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        IAsyncResult BeginDeleteStack(DeleteStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStack.</param>
        /// 
        /// <returns>Returns a  DeleteStackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        DeleteStackResponse EndDeleteStack(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStackInstances


        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances service method.</param>
        /// 
        /// <returns>The response from the DeleteStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStackInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        IAsyncResult BeginDeleteStackInstances(DeleteStackInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStackInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStackInstances.</param>
        /// 
        /// <returns>Returns a  DeleteStackInstancesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        DeleteStackInstancesResponse EndDeleteStackInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStackSet


        /// <summary>
        /// Deletes a stack set. Before you can delete a stack set, all of its member stack instances
        /// must be deleted. For more information about how to do this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this stack set, because it still contains one or more stack instances.
        /// Delete all stack instances from the stack set before deleting the stack set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStackSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        IAsyncResult BeginDeleteStackSet(DeleteStackSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStackSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStackSet.</param>
        /// 
        /// <returns>Returns a  DeleteStackSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        DeleteStackSetResponse EndDeleteStackSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Retrieves your account's AWS CloudFormation limits, such as the maximum number of
        /// stacks that you can create in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChangeSet


        /// <summary>
        /// Returns the inputs for the change set and a list of changes that AWS CloudFormation
        /// will make if you execute the change set. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the AWS CloudFormation User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        IAsyncResult BeginDescribeChangeSet(DescribeChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChangeSet.</param>
        /// 
        /// <returns>Returns a  DescribeChangeSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        DescribeChangeSetResponse EndDescribeChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackEvents


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/concept-stack.html">Stacks</a>
        /// in the AWS CloudFormation User Guide.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        IAsyncResult BeginDescribeStackEvents(DescribeStackEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackEvents.</param>
        /// 
        /// <returns>Returns a  DescribeStackEventsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        DescribeStackEventsResponse EndDescribeStackEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackInstance


        /// <summary>
        /// Returns the stack instance that's associated with the specified stack set, AWS account,
        /// and region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific stack set, use <a>ListStackInstances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        IAsyncResult BeginDescribeStackInstance(DescribeStackInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackInstance.</param>
        /// 
        /// <returns>Returns a  DescribeStackInstanceResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        DescribeStackInstanceResponse EndDescribeStackInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackResource


        /// <summary>
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        IAsyncResult BeginDescribeStackResource(DescribeStackResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResource.</param>
        /// 
        /// <returns>Returns a  DescribeStackResourceResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        DescribeStackResourceResponse EndDescribeStackResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackResources


        /// <summary>
        /// Returns AWS resource descriptions for running and deleted stacks. If <code>StackName</code>
        /// is specified, all the associated resources that are part of the stack are returned.
        /// If <code>PhysicalResourceId</code> is specified, the associated resources of the stack
        /// that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <code>ListStackResources</code> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <code>DescribeStackResources</code> returns resource information
        /// for up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>StackName</code> or <code>PhysicalResourceId</code>,
        /// but not both. In addition, you can specify <code>LogicalResourceId</code> to filter
        /// the returned result. For more information about resources, the <code>LogicalResourceId</code>
        /// and <code>PhysicalResourceId</code>, go to the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">AWS
        /// CloudFormation User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <code>ValidationError</code> is returned if you specify both <code>StackName</code>
        /// and <code>PhysicalResourceId</code> in the same request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        IAsyncResult BeginDescribeStackResources(DescribeStackResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResources.</param>
        /// 
        /// <returns>Returns a  DescribeStackResourcesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        DescribeStackResourcesResponse EndDescribeStackResources(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks();

        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks(DescribeStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        IAsyncResult BeginDescribeStacks(DescribeStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStacks.</param>
        /// 
        /// <returns>Returns a  DescribeStacksResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse EndDescribeStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackSet


        /// <summary>
        /// Returns the description of the specified stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        IAsyncResult BeginDescribeStackSet(DescribeStackSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSet.</param>
        /// 
        /// <returns>Returns a  DescribeStackSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        DescribeStackSetResponse EndDescribeStackSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackSetOperation


        /// <summary>
        /// Returns the description of the specified stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackSetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        IAsyncResult BeginDescribeStackSetOperation(DescribeStackSetOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackSetOperation.</param>
        /// 
        /// <returns>Returns a  DescribeStackSetOperationResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        DescribeStackSetOperationResponse EndDescribeStackSetOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EstimateTemplateCost


        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an AWS Simple
        /// Monthly Calculator URL with a query string that describes the resources required to
        /// run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEstimateTemplateCost
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        IAsyncResult BeginEstimateTemplateCost(EstimateTemplateCostRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEstimateTemplateCost.</param>
        /// 
        /// <returns>Returns a  EstimateTemplateCostResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        EstimateTemplateCostResponse EndEstimateTemplateCost(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteChangeSet


        /// <summary>
        /// Updates a stack using the input information that was provided when the specified change
        /// set was created. After the call successfully completes, AWS CloudFormation starts
        /// updating the stack. Use the <a>DescribeStacks</a> action to view the status of the
        /// update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, AWS CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, AWS CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <code>CREATE_IN_PROGRESS</code>, or the stack status might be
        /// <code>UPDATE_IN_PROGRESS</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        IAsyncResult BeginExecuteChangeSet(ExecuteChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteChangeSet.</param>
        /// 
        /// <returns>Returns a  ExecuteChangeSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        ExecuteChangeSetResponse EndExecuteChangeSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStackPolicy


        /// <summary>
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStackPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        IAsyncResult BeginGetStackPolicy(GetStackPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStackPolicy.</param>
        /// 
        /// <returns>Returns a  GetStackPolicyResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        GetStackPolicyResponse EndGetStackPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Returns the template body for a specified stack. You can get the template for running
        /// or deleted stacks.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, GetTemplate returns the template for up to 90 days after the stack
        /// has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If the template does not exist, a <code>ValidationError</code> is returned. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <code>ListChangeSets</code> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTemplateSummary


        /// <summary>
        /// Returns information about a new or existing template. The <code>GetTemplateSummary</code>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetTemplateSummary</code> action when you submit a template,
        /// or you can get template information for a stack set, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <code>GetTemplateSummary</code> returns the template information
        /// for up to 90 days after the stack has been deleted. If the template does not exist,
        /// a <code>ValidationError</code> is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        IAsyncResult BeginGetTemplateSummary(GetTemplateSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateSummary.</param>
        /// 
        /// <returns>Returns a  GetTemplateSummaryResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        GetTemplateSummaryResponse EndGetTemplateSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, AWS
        /// CloudFormation lists change sets that are in the <code>CREATE_IN_PROGRESS</code> or
        /// <code>CREATE_PENDING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangeSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        IAsyncResult BeginListChangeSets(ListChangeSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangeSets.</param>
        /// 
        /// <returns>Returns a  ListChangeSetsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        ListChangeSetsResponse EndListChangeSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all exported output values in the account and region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// AWS CloudFormation Export Stack Output Values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        IAsyncResult BeginListExports(ListExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExports.</param>
        /// 
        /// <returns>Returns a  ListExportsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse EndListExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// <code>Fn::ImportValue</code> </a> function. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImports operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        IAsyncResult BeginListImports(ListImportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImports.</param>
        /// 
        /// <returns>Returns a  ListImportsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse EndListImports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackInstances


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// AWS account name or region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        IAsyncResult BeginListStackInstances(ListStackInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackInstances.</param>
        /// 
        /// <returns>Returns a  ListStackInstancesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        ListStackInstancesResponse EndListStackInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackResources


        /// <summary>
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        IAsyncResult BeginListStackResources(ListStackResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackResources.</param>
        /// 
        /// <returns>Returns a  ListStackResourcesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        ListStackResourcesResponse EndListStackResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStacks


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        ListStacksResponse ListStacks();

        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        ListStacksResponse ListStacks(ListStacksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStacks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        IAsyncResult BeginListStacks(ListStacksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStacks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStacks.</param>
        /// 
        /// <returns>Returns a  ListStacksResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        ListStacksResponse EndListStacks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackSetOperationResults


        /// <summary>
        /// Returns summary information about the results of a stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackSetOperationResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        IAsyncResult BeginListStackSetOperationResults(ListStackSetOperationResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackSetOperationResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackSetOperationResults.</param>
        /// 
        /// <returns>Returns a  ListStackSetOperationResultsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        ListStackSetOperationResultsResponse EndListStackSetOperationResults(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackSetOperations


        /// <summary>
        /// Returns summary information about operations performed on a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackSetOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        IAsyncResult BeginListStackSetOperations(ListStackSetOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackSetOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackSetOperations.</param>
        /// 
        /// <returns>Returns a  ListStackSetOperationsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        ListStackSetOperationsResponse EndListStackSetOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackSets


        /// <summary>
        /// Returns summary information about stack sets that are associated with the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets service method.</param>
        /// 
        /// <returns>The response from the ListStackSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        ListStackSetsResponse ListStackSets(ListStackSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        IAsyncResult BeginListStackSets(ListStackSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackSets.</param>
        /// 
        /// <returns>Returns a  ListStackSetsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        ListStackSetsResponse EndListStackSets(IAsyncResult asyncResult);

        #endregion
        
        #region  SetStackPolicy


        /// <summary>
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetStackPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        IAsyncResult BeginSetStackPolicy(SetStackPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetStackPolicy.</param>
        /// 
        /// <returns>Returns a  SetStackPolicyResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        SetStackPolicyResponse EndSetStackPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  SignalResource


        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the SignalResource API in conjunction with a creation policy or update policy.
        /// AWS CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The SignalResource
        /// API is useful in cases where you want to send signals from anywhere other than an
        /// Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        SignalResourceResponse SignalResource(SignalResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SignalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalResource operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSignalResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        IAsyncResult BeginSignalResource(SignalResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SignalResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSignalResource.</param>
        /// 
        /// <returns>Returns a  SignalResourceResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        SignalResourceResponse EndSignalResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StopStackSetOperation


        /// <summary>
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the StopStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStackSetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        IAsyncResult BeginStopStackSetOperation(StopStackSetOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStackSetOperation.</param>
        /// 
        /// <returns>Returns a  StopStackSetOperationResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        StopStackSetOperationResponse EndStopStackSetOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack via the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// 
        /// <returns>The response from the UpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse UpdateStack(UpdateStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        IAsyncResult BeginUpdateStack(UpdateStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStack.</param>
        /// 
        /// <returns>Returns a  UpdateStackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        UpdateStackResponse EndUpdateStack(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStackInstances


        /// <summary>
        /// Updates the parameter values for stack instances for the specified accounts, within
        /// the specified regions. A stack instance refers to a stack in a specific account and
        /// region. 
        /// 
        ///  
        /// <para>
        /// You can only update stack instances in regions and accounts where they already exist;
        /// to create additional stack instances, use <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateStackInstances.html">CreateStackInstances</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// During stack set updates, any parameters overridden for a stack instance are not updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the stack set;
        /// to add or delete a parameter itself, use <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the stack set you must first use <a
        /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the stack set. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <code>UpdateStackInstances</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances service method.</param>
        /// 
        /// <returns>The response from the UpdateStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStackInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        IAsyncResult BeginUpdateStackInstances(UpdateStackInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStackInstances.</param>
        /// 
        /// <returns>Returns a  UpdateStackInstancesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        UpdateStackInstancesResponse EndUpdateStackInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStackSet


        /// <summary>
        /// Updates the stack set, and associated stack instances in the specified accounts and
        /// regions.
        /// 
        ///  
        /// <para>
        /// Even if the stack set operation created by updating the stack set fails (completely
        /// or partially, below or above a specified failure tolerance), the stack set is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified stack
        /// set use the updated stack set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet service method.</param>
        /// 
        /// <returns>The response from the UpdateStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStackSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        IAsyncResult BeginUpdateStackSet(UpdateStackSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStackSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStackSet.</param>
        /// 
        /// <returns>Returns a  UpdateStackSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        UpdateStackSetResponse EndUpdateStackSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTerminationProtection


        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>AWS CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  For <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and cannot be changed
        /// directly on the nested stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateTerminationProtection service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        UpdateTerminationProtectionResponse UpdateTerminationProtection(UpdateTerminationProtectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTerminationProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        IAsyncResult BeginUpdateTerminationProtection(UpdateTerminationProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTerminationProtection.</param>
        /// 
        /// <returns>Returns a  UpdateTerminationProtectionResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        UpdateTerminationProtectionResponse EndUpdateTerminationProtection(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateTemplate


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        ValidateTemplateResponse ValidateTemplate();

        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        IAsyncResult BeginValidateTemplate(ValidateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateTemplate.</param>
        /// 
        /// <returns>Returns a  ValidateTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        ValidateTemplateResponse EndValidateTemplate(IAsyncResult asyncResult);

        #endregion
        
    }
}
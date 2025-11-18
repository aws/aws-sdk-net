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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudFormation.Model;

#pragma warning disable CS1570
namespace Amazon.CloudFormation
{
    /// <summary>
    /// <para>Interface for accessing CloudFormation</para>
    ///
    /// CloudFormation 
    /// <para>
    /// CloudFormation allows you to create and manage Amazon Web Services infrastructure
    /// deployments predictably and repeatedly. You can use CloudFormation to leverage Amazon
    /// Web Services products, such as Amazon Elastic Compute Cloud, Amazon Elastic Block
    /// Store, Amazon Simple Notification Service, Elastic Load Balancing, and Amazon EC2
    /// Auto Scaling to build highly reliable, highly scalable, cost-effective applications
    /// without creating or configuring the underlying Amazon Web Services infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With CloudFormation, you declare all your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// CloudFormation creates and deletes all member resources of the stack together and
    /// manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">CloudFormation
    /// product page</a>.
    /// </para>
    ///  
    /// <para>
    /// CloudFormation makes use of other Amazon Web Services products. If you need additional
    /// technical information about a specific Amazon Web Services product, you can find the
    /// product's technical documentation at <a href="https://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudFormation : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudFormationPaginatorFactory Paginators { get; }
#endif


        
        #region  ActivateOrganizationsAccess


        /// <summary>
        /// Activate trusted access with Organizations. With trusted access between StackSets
        /// and Organizations activated, the management account has permissions to create and
        /// manage StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the ActivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateOrganizationsAccess">REST API Reference for ActivateOrganizationsAccess Operation</seealso>
        ActivateOrganizationsAccessResponse ActivateOrganizationsAccess(ActivateOrganizationsAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateOrganizationsAccess operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateOrganizationsAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateOrganizationsAccess">REST API Reference for ActivateOrganizationsAccess Operation</seealso>
        IAsyncResult BeginActivateOrganizationsAccess(ActivateOrganizationsAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateOrganizationsAccess.</param>
        /// 
        /// <returns>Returns a  ActivateOrganizationsAccessResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateOrganizationsAccess">REST API Reference for ActivateOrganizationsAccess Operation</seealso>
        ActivateOrganizationsAccessResponse EndActivateOrganizationsAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ActivateType


        /// <summary>
        /// Activates a public third-party extension, such as a resource or module, to make it
        /// available for use in stack templates in your current account and Region. It can also
        /// create CloudFormation Hooks, which allow you to evaluate resource configurations before
        /// CloudFormation provisions them. Hooks integrate with both CloudFormation and Cloud
        /// Control API operations.
        /// 
        ///  
        /// <para>
        /// After you activate an extension, you can use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to set specific properties for the extension.
        /// </para>
        ///  
        /// <para>
        /// To see which extensions have been activated, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ListTypes.html">ListTypes</a>.
        /// To see configuration details for an extension, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public-activate-extension.html">Activate
        /// a third-party public extension in your account</a> in the <i>CloudFormation User Guide</i>.
        /// For information about creating Hooks, see the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/what-is-cloudformation-hooks.html">CloudFormation
        /// Hooks User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateType service method.</param>
        /// 
        /// <returns>The response from the ActivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateType">REST API Reference for ActivateType Operation</seealso>
        ActivateTypeResponse ActivateType(ActivateTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateType">REST API Reference for ActivateType Operation</seealso>
        IAsyncResult BeginActivateType(ActivateTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateType.</param>
        /// 
        /// <returns>Returns a  ActivateTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateType">REST API Reference for ActivateType Operation</seealso>
        ActivateTypeResponse EndActivateType(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDescribeTypeConfigurations


        /// <summary>
        /// Returns configuration data for the specified CloudFormation extensions, from the CloudFormation
        /// registry in your current account and Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeTypeConfigurations service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeTypeConfigurations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeConfigurationNotFoundException">
        /// The specified extension configuration can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/BatchDescribeTypeConfigurations">REST API Reference for BatchDescribeTypeConfigurations Operation</seealso>
        BatchDescribeTypeConfigurationsResponse BatchDescribeTypeConfigurations(BatchDescribeTypeConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDescribeTypeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeTypeConfigurations operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDescribeTypeConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/BatchDescribeTypeConfigurations">REST API Reference for BatchDescribeTypeConfigurations Operation</seealso>
        IAsyncResult BeginBatchDescribeTypeConfigurations(BatchDescribeTypeConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDescribeTypeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDescribeTypeConfigurations.</param>
        /// 
        /// <returns>Returns a  BatchDescribeTypeConfigurationsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/BatchDescribeTypeConfigurations">REST API Reference for BatchDescribeTypeConfigurations Operation</seealso>
        BatchDescribeTypeConfigurationsResponse EndBatchDescribeTypeConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelUpdateStack


        /// <summary>
        /// Cancels an update on the specified stack. If the call completes successfully, the
        /// stack rolls back the update and reverts to the previous stack configuration.
        /// 
        ///  <note> 
        /// <para>
        /// You can cancel only stacks that are in the <c>UPDATE_IN_PROGRESS</c> state.
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
        /// Continues rolling back a stack from <c>UPDATE_ROLLBACK_FAILED</c> to <c>UPDATE_ROLLBACK_COMPLETE</c>
        /// state. Depending on the cause of the failure, you can manually fix the error and continue
        /// the rollback. By continuing the rollback, you can return your stack to a working state
        /// (the <c>UPDATE_ROLLBACK_COMPLETE</c> state) and then try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack enters the <c>UPDATE_ROLLBACK_FAILED</c> state when CloudFormation can't roll
        /// back all changes after a failed stack update. For example, this might occur when a
        /// stack attempts to roll back to an old database that was deleted outside of CloudFormation.
        /// Because CloudFormation doesn't know the instance was deleted, it assumes the instance
        /// still exists and attempts to roll back to it, causing the update rollback to fail.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-continueupdaterollback.html">Continue
        /// rolling back an update</a> in the <i>CloudFormation User Guide</i>. For information
        /// for troubleshooting a failed update rollback, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">Update
        /// rollback failed</a>.
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
        /// the change set shows all of the resources that CloudFormation will create. If you
        /// create a change set for an existing stack, CloudFormation compares the stack's information
        /// with the information that you submit in the change set and lists the differences.
        /// Use change sets to understand which resources CloudFormation will create or change,
        /// and how it will change resources in an existing stack, before you create or update
        /// a stack.
        /// 
        ///  
        /// <para>
        /// To create a change set for a stack that doesn't exist, for the <c>ChangeSetType</c>
        /// parameter, specify <c>CREATE</c>. To create a change set for an existing stack, specify
        /// <c>UPDATE</c> for the <c>ChangeSetType</c> parameter. To create a change set for an
        /// import operation, specify <c>IMPORT</c> for the <c>ChangeSetType</c> parameter. After
        /// the <c>CreateChangeSet</c> call successfully completes, CloudFormation starts creating
        /// the change set. To check the status of the change set or to review it, use the <a>DescribeChangeSet</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// When you are satisfied with the changes the change set will make, execute the change
        /// set by using the <a>ExecuteChangeSet</a> action. CloudFormation doesn't make changes
        /// until you execute the change set.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierarchy, set <c>IncludeNestedStacks</c>
        /// to <c>True</c>.
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
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
        
        #region  CreateGeneratedTemplate


        /// <summary>
        /// Creates a template from existing resources that are not already managed with CloudFormation.
        /// You can check the status of the template generation using the <c>DescribeGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeneratedTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ConcurrentResourcesLimitExceededException">
        /// No more than 5 generated templates can be in an <c>InProgress</c> or <c>Pending</c>
        /// status at one time. This error is also returned if a generated template that is in
        /// an <c>InProgress</c> or <c>Pending</c> status is attempted to be updated or deleted.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateGeneratedTemplate">REST API Reference for CreateGeneratedTemplate Operation</seealso>
        CreateGeneratedTemplateResponse CreateGeneratedTemplate(CreateGeneratedTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGeneratedTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGeneratedTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateGeneratedTemplate">REST API Reference for CreateGeneratedTemplate Operation</seealso>
        IAsyncResult BeginCreateGeneratedTemplate(CreateGeneratedTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGeneratedTemplate.</param>
        /// 
        /// <returns>Returns a  CreateGeneratedTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateGeneratedTemplate">REST API Reference for CreateGeneratedTemplate Operation</seealso>
        CreateGeneratedTemplateResponse EndCreateGeneratedTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information about creating a stack and monitoring stack progress, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Managing
        /// Amazon Web Services resources as a single unit with CloudFormation stacks</a> in the
        /// <i>CloudFormation User Guide</i>.
        /// </para>
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
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
        /// Creates stack instances for the specified accounts, within the specified Amazon Web
        /// Services Regions. A stack instance refers to a stack in a specific account and Region.
        /// You must specify at least one value for either <c>Accounts</c> or <c>DeploymentTargets</c>,
        /// and you must specify at least one value for <c>Regions</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>CreateStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
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
        
        #region  CreateStackRefactor


        /// <summary>
        /// Creates a refactor across multiple stacks, with the list of stacks and resources that
        /// are affected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackRefactor service method.</param>
        /// 
        /// <returns>The response from the CreateStackRefactor service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackRefactor">REST API Reference for CreateStackRefactor Operation</seealso>
        CreateStackRefactorResponse CreateStackRefactor(CreateStackRefactorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackRefactor operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStackRefactor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackRefactor">REST API Reference for CreateStackRefactor Operation</seealso>
        IAsyncResult BeginCreateStackRefactor(CreateStackRefactorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStackRefactor.</param>
        /// 
        /// <returns>Returns a  CreateStackRefactorResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackRefactor">REST API Reference for CreateStackRefactor Operation</seealso>
        CreateStackRefactorResponse EndCreateStackRefactor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStackSet


        /// <summary>
        /// Creates a StackSet.
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
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
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
        
        #region  DeactivateOrganizationsAccess


        /// <summary>
        /// Deactivates trusted access with Organizations. If trusted access is deactivated, the
        /// management account does not have permissions to create and manage service-managed
        /// StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the DeactivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateOrganizationsAccess">REST API Reference for DeactivateOrganizationsAccess Operation</seealso>
        DeactivateOrganizationsAccessResponse DeactivateOrganizationsAccess(DeactivateOrganizationsAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateOrganizationsAccess operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateOrganizationsAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateOrganizationsAccess">REST API Reference for DeactivateOrganizationsAccess Operation</seealso>
        IAsyncResult BeginDeactivateOrganizationsAccess(DeactivateOrganizationsAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateOrganizationsAccess.</param>
        /// 
        /// <returns>Returns a  DeactivateOrganizationsAccessResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateOrganizationsAccess">REST API Reference for DeactivateOrganizationsAccess Operation</seealso>
        DeactivateOrganizationsAccessResponse EndDeactivateOrganizationsAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateType


        /// <summary>
        /// Deactivates a public third-party extension, such as a resource or module, or a CloudFormation
        /// Hook when you no longer use it.
        /// 
        ///  
        /// <para>
        /// Deactivating an extension deletes the configuration details that are associated with
        /// it. To temporarily disable a CloudFormation Hook instead, you can use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// Once deactivated, an extension can't be used in any CloudFormation operation. This
        /// includes stack update operations where the stack template includes the extension,
        /// even if no updates are being made to the extension. In addition, deactivated extensions
        /// aren't automatically updated if a new version of the extension is released.
        /// </para>
        ///  
        /// <para>
        /// To see which extensions are currently activated, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ListTypes.html">ListTypes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateType service method.</param>
        /// 
        /// <returns>The response from the DeactivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateType">REST API Reference for DeactivateType Operation</seealso>
        DeactivateTypeResponse DeactivateType(DeactivateTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateType">REST API Reference for DeactivateType Operation</seealso>
        IAsyncResult BeginDeactivateType(DeactivateTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateType.</param>
        /// 
        /// <returns>Returns a  DeactivateTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateType">REST API Reference for DeactivateType Operation</seealso>
        DeactivateTypeResponse EndDeactivateType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChangeSet


        /// <summary>
        /// Deletes the specified change set. Deleting change sets ensures that no one executes
        /// the wrong change set.
        /// 
        ///  
        /// <para>
        /// If the call successfully completes, CloudFormation successfully deleted the change
        /// set.
        /// </para>
        ///  
        /// <para>
        /// If <c>IncludeNestedStacks</c> specifies <c>True</c> during the creation of the nested
        /// change set, then <c>DeleteChangeSet</c> will delete all change sets that belong to
        /// the stacks hierarchy and will also delete all change sets for nested stacks with the
        /// status of <c>REVIEW_IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet service method.</param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <c>CREATE_IN_PROGRESS</c>, or the stack status might be <c>UPDATE_IN_PROGRESS</c>.
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
        
        #region  DeleteGeneratedTemplate


        /// <summary>
        /// Deleted a generated template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeneratedTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ConcurrentResourcesLimitExceededException">
        /// No more than 5 generated templates can be in an <c>InProgress</c> or <c>Pending</c>
        /// status at one time. This error is also returned if a generated template that is in
        /// an <c>InProgress</c> or <c>Pending</c> status is attempted to be updated or deleted.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteGeneratedTemplate">REST API Reference for DeleteGeneratedTemplate Operation</seealso>
        DeleteGeneratedTemplateResponse DeleteGeneratedTemplate(DeleteGeneratedTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeneratedTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGeneratedTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteGeneratedTemplate">REST API Reference for DeleteGeneratedTemplate Operation</seealso>
        IAsyncResult BeginDeleteGeneratedTemplate(DeleteGeneratedTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGeneratedTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteGeneratedTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteGeneratedTemplate">REST API Reference for DeleteGeneratedTemplate Operation</seealso>
        DeleteGeneratedTemplateResponse EndDeleteGeneratedTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks don't show up in the <a>DescribeStacks</a> operation if the deletion
        /// has been completed successfully.
        /// 
        ///  
        /// <para>
        /// For more information about deleting a stack, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-console-delete-stack.html">Delete
        /// a stack from the CloudFormation console</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
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
        /// Deletes stack instances for the specified accounts, in the specified Amazon Web Services
        /// Regions.
        /// 
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>DeleteStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
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
        /// Deletes a StackSet. Before you can delete a StackSet, all its member stack instances
        /// must be deleted. For more information about how to complete this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// 
        /// <returns>The response from the DeleteStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotEmptyException">
        /// You can't yet delete this StackSet, because it still contains one or more stack instances.
        /// Delete all stack instances from the StackSet before deleting the StackSet.
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
        
        #region  DeregisterType


        /// <summary>
        /// Marks an extension or extension version as <c>DEPRECATED</c> in the CloudFormation
        /// registry, removing it from active use. Deprecated extensions or extension versions
        /// cannot be used in CloudFormation operations.
        /// 
        ///  
        /// <para>
        /// To deregister an entire extension, you must individually deregister all active versions
        /// of that extension. If an extension has only a single active version, deregistering
        /// that version results in the extension itself being deregistered and marked as deprecated
        /// in the registry.
        /// </para>
        ///  
        /// <para>
        /// You can't deregister the default version of an extension if there are other active
        /// version of that extension. If you do deregister the default version of an extension,
        /// the extension type itself is deregistered as well and marked as deprecated.
        /// </para>
        ///  
        /// <para>
        /// To view the deprecation status of an extension or extension version, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private-deregister-extension.html">Remove
        /// third-party private extensions from your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterType service method.</param>
        /// 
        /// <returns>The response from the DeregisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        DeregisterTypeResponse DeregisterType(DeregisterTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        IAsyncResult BeginDeregisterType(DeregisterTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterType.</param>
        /// 
        /// <returns>Returns a  DeregisterTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        DeregisterTypeResponse EndDeregisterType(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Retrieves your account's CloudFormation limits, such as the maximum number of stacks
        /// that you can create in your account. For more information about account limits, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Understand
        /// CloudFormation quotas</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns the inputs for the change set and a list of changes that CloudFormation will
        /// make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Update
        /// CloudFormation stacks using change sets</a> in the <i>CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
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
        
        #region  DescribeChangeSetHooks


        /// <summary>
        /// Returns Hook-related information for the change set and a list of changes that CloudFormation
        /// makes when you run the change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSetHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSetHooks service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSetHooks">REST API Reference for DescribeChangeSetHooks Operation</seealso>
        DescribeChangeSetHooksResponse DescribeChangeSetHooks(DescribeChangeSetHooksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSetHooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSetHooks operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChangeSetHooks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSetHooks">REST API Reference for DescribeChangeSetHooks Operation</seealso>
        IAsyncResult BeginDescribeChangeSetHooks(DescribeChangeSetHooksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChangeSetHooks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChangeSetHooks.</param>
        /// 
        /// <returns>Returns a  DescribeChangeSetHooksResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSetHooks">REST API Reference for DescribeChangeSetHooks Operation</seealso>
        DescribeChangeSetHooksResponse EndDescribeChangeSetHooks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns CloudFormation events based on flexible query criteria. Groups events by operation
        /// ID, enabling you to focus on individual stack operations during deployment.
        /// 
        ///  
        /// <para>
        /// An operation is any action performed on a stack, including stack lifecycle actions
        /// (Create, Update, Delete, Rollback), change set creation, nested stack creation, and
        /// automatic rollbacks triggered by failures. Each operation has a unique identifier
        /// (Operation ID) and represents a discrete change attempt on the stack.
        /// </para>
        ///  
        /// <para>
        /// Returns different types of events including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Progress events</b> - Status updates during stack operation execution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Validation errors</b> - Failures from CloudFormation Early Validations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Provisioning errors</b> - Resource creation and update failures.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Hook invocation errors</b> - Failures from CloudFormation Hook during stack operations.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// One of <c>ChangeSetName</c>, <c>OperationId</c> or <c>StackName</c> must be specified
        /// as input.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGeneratedTemplate


        /// <summary>
        /// Describes a generated template. The output includes details about the progress of
        /// the creation of a generated template started by a <c>CreateGeneratedTemplate</c> API
        /// action or the update of a generated template started with an <c>UpdateGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeneratedTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeGeneratedTemplate">REST API Reference for DescribeGeneratedTemplate Operation</seealso>
        DescribeGeneratedTemplateResponse DescribeGeneratedTemplate(DescribeGeneratedTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeneratedTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGeneratedTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeGeneratedTemplate">REST API Reference for DescribeGeneratedTemplate Operation</seealso>
        IAsyncResult BeginDescribeGeneratedTemplate(DescribeGeneratedTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGeneratedTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeGeneratedTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeGeneratedTemplate">REST API Reference for DescribeGeneratedTemplate Operation</seealso>
        DescribeGeneratedTemplateResponse EndDescribeGeneratedTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrganizationsAccess


        /// <summary>
        /// Retrieves information about the account's <c>OrganizationAccess</c> status. This API
        /// can be called either by the management account or the delegated administrator by using
        /// the <c>CallAs</c> parameter. This API can also be called without the <c>CallAs</c>
        /// parameter by the management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeOrganizationsAccess">REST API Reference for DescribeOrganizationsAccess Operation</seealso>
        DescribeOrganizationsAccessResponse DescribeOrganizationsAccess(DescribeOrganizationsAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationsAccess operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationsAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeOrganizationsAccess">REST API Reference for DescribeOrganizationsAccess Operation</seealso>
        IAsyncResult BeginDescribeOrganizationsAccess(DescribeOrganizationsAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationsAccess.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationsAccessResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeOrganizationsAccess">REST API Reference for DescribeOrganizationsAccess Operation</seealso>
        DescribeOrganizationsAccessResponse EndDescribeOrganizationsAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePublisher


        /// <summary>
        /// Returns information about a CloudFormation extension publisher.
        /// 
        ///  
        /// <para>
        /// If you don't supply a <c>PublisherId</c>, and you have registered as an extension
        /// publisher, <c>DescribePublisher</c> returns information about your own publisher account.
        /// </para>
        ///  
        /// <para>
        /// For more information about registering as a publisher, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublisher service method.</param>
        /// 
        /// <returns>The response from the DescribePublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribePublisher">REST API Reference for DescribePublisher Operation</seealso>
        DescribePublisherResponse DescribePublisher(DescribePublisherRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePublisher operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePublisher operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePublisher
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribePublisher">REST API Reference for DescribePublisher Operation</seealso>
        IAsyncResult BeginDescribePublisher(DescribePublisherRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePublisher operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePublisher.</param>
        /// 
        /// <returns>Returns a  DescribePublisherResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribePublisher">REST API Reference for DescribePublisher Operation</seealso>
        DescribePublisherResponse EndDescribePublisher(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResourceScan


        /// <summary>
        /// Describes details of a resource scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceScan service method.</param>
        /// 
        /// <returns>The response from the DescribeResourceScan service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeResourceScan">REST API Reference for DescribeResourceScan Operation</seealso>
        DescribeResourceScanResponse DescribeResourceScan(DescribeResourceScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceScan operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourceScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeResourceScan">REST API Reference for DescribeResourceScan Operation</seealso>
        IAsyncResult BeginDescribeResourceScan(DescribeResourceScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourceScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourceScan.</param>
        /// 
        /// <returns>Returns a  DescribeResourceScanResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeResourceScan">REST API Reference for DescribeResourceScan Operation</seealso>
        DescribeResourceScanResponse EndDescribeResourceScan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackDriftDetectionStatus


        /// <summary>
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. A stack is considered to have drifted if one or more of its
        /// resources have drifted. For more information about stack and resource drift, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <a>DetectStackDrift</a> to initiate a stack drift detection operation. <c>DetectStackDrift</c>
        /// returns a <c>StackDriftDetectionId</c> you can use to monitor the progress of the
        /// operation using <c>DescribeStackDriftDetectionStatus</c>. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackDriftDetectionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeStackDriftDetectionStatus service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        DescribeStackDriftDetectionStatusResponse DescribeStackDriftDetectionStatus(DescribeStackDriftDetectionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackDriftDetectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackDriftDetectionStatus operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackDriftDetectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        IAsyncResult BeginDescribeStackDriftDetectionStatus(DescribeStackDriftDetectionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackDriftDetectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackDriftDetectionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeStackDriftDetectionStatusResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        DescribeStackDriftDetectionStatusResponse EndDescribeStackDriftDetectionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackEvents


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns the stack instance that's associated with the specified StackSet, Amazon Web
        /// Services account, and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// For a list of stack instances that are associated with a specific StackSet, use <a>ListStackInstances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        
        #region  DescribeStackRefactor


        /// <summary>
        /// Describes the stack refactor status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackRefactor service method.</param>
        /// 
        /// <returns>The response from the DescribeStackRefactor service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackRefactorNotFoundException">
        /// The specified stack refactor can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackRefactor">REST API Reference for DescribeStackRefactor Operation</seealso>
        DescribeStackRefactorResponse DescribeStackRefactor(DescribeStackRefactorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackRefactor operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackRefactor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackRefactor">REST API Reference for DescribeStackRefactor Operation</seealso>
        IAsyncResult BeginDescribeStackRefactor(DescribeStackRefactorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackRefactor.</param>
        /// 
        /// <returns>Returns a  DescribeStackRefactorResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackRefactor">REST API Reference for DescribeStackRefactor Operation</seealso>
        DescribeStackRefactorResponse EndDescribeStackRefactor(IAsyncResult asyncResult);

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
        
        #region  DescribeStackResourceDrifts


        /// <summary>
        /// Returns drift information for the resources that have been checked for drift in the
        /// specified stack. This includes actual and expected configuration values for resources
        /// where CloudFormation detects configuration drift.
        /// 
        ///  
        /// <para>
        /// For a given stack, there will be one <c>StackResourceDrift</c> for each stack resource
        /// that has been checked for drift. Resources that haven't yet been checked for drift
        /// aren't included. Resources that don't currently support drift detection aren't checked,
        /// and so not included. For a list of resources that support drift detection, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all supported resources for a given stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts service method.</param>
        /// 
        /// <returns>The response from the DescribeStackResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        DescribeStackResourceDriftsResponse DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResourceDrifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStackResourceDrifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        IAsyncResult BeginDescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStackResourceDrifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStackResourceDrifts.</param>
        /// 
        /// <returns>Returns a  DescribeStackResourceDriftsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        DescribeStackResourceDriftsResponse EndDescribeStackResourceDrifts(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStackResources


        /// <summary>
        /// Returns Amazon Web Services resource descriptions for running and deleted stacks.
        /// If <c>StackName</c> is specified, all the associated resources that are part of the
        /// stack are returned. If <c>PhysicalResourceId</c> is specified, the associated resources
        /// of the stack that the resource belongs to are returned.
        /// 
        ///  <note> 
        /// <para>
        /// Only the first 100 resources will be returned. If your stack has more resources than
        /// this, you should use <c>ListStackResources</c> instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// For deleted stacks, <c>DescribeStackResources</c> returns resource information for
        /// up to 90 days after the stack has been deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>StackName</c> or <c>PhysicalResourceId</c>, but not both.
        /// In addition, you can specify <c>LogicalResourceId</c> to filter the returned result.
        /// For more information about resources, the <c>LogicalResourceId</c> and <c>PhysicalResourceId</c>,
        /// see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">CloudFormation
        /// User Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>ValidationError</c> is returned if you specify both <c>StackName</c> and <c>PhysicalResourceId</c>
        /// in the same request.
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
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        DescribeStacksResponse DescribeStacks();

        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
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
        /// Returns the description of the specified StackSet.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        /// Returns the description of the specified StackSet operation.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        
        #region  DescribeType


        /// <summary>
        /// Returns detailed information about an extension from the CloudFormation registry in
        /// your current account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information about that
        /// specific extension version. Otherwise, it returns information about the default extension
        /// version.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeType service method.</param>
        /// 
        /// <returns>The response from the DescribeType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        DescribeTypeResponse DescribeType(DescribeTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        IAsyncResult BeginDescribeType(DescribeTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeType.</param>
        /// 
        /// <returns>Returns a  DescribeTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        DescribeTypeResponse EndDescribeType(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTypeRegistration


        /// <summary>
        /// Returns information about an extension's registration, including its current status
        /// and type and version identifiers.
        /// 
        ///  
        /// <para>
        /// When you initiate a registration request using <a>RegisterType</a>, you can then use
        /// <a>DescribeTypeRegistration</a> to monitor the progress of that registration request.
        /// </para>
        ///  
        /// <para>
        /// Once the registration request has completed, use <a>DescribeType</a> to return detailed
        /// information about an extension.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTypeRegistration service method.</param>
        /// 
        /// <returns>The response from the DescribeTypeRegistration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        DescribeTypeRegistrationResponse DescribeTypeRegistration(DescribeTypeRegistrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTypeRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTypeRegistration operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTypeRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        IAsyncResult BeginDescribeTypeRegistration(DescribeTypeRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTypeRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTypeRegistration.</param>
        /// 
        /// <returns>Returns a  DescribeTypeRegistrationResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        DescribeTypeRegistrationResponse EndDescribeTypeRegistration(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectStackDrift


        /// <summary>
        /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
        /// its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For each resource in the stack that supports drift detection,
        /// CloudFormation compares the actual configuration of the resource with its expected
        /// template configuration. Only resource properties explicitly defined in the stack template
        /// are checked for drift. A stack is considered to have drifted if one or more of its
        /// resources differ from their expected template configurations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackDrift</c> to detect drift on all supported resources for a given
        /// stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>DetectStackDrift</c> can take up to several minutes, depending on the number of
        /// resources contained within the stack. Use <a>DescribeStackDriftDetectionStatus</a>
        /// to monitor the progress of a detect stack drift operation. Once the drift detection
        /// operation has completed, use <a>DescribeStackResourceDrifts</a> to return drift information
        /// about the stack and its resources.
        /// </para>
        ///  
        /// <para>
        /// When detecting drift on a stack, CloudFormation doesn't detect drift on any nested
        /// stacks belonging to that stack. Perform <c>DetectStackDrift</c> directly on the nested
        /// stack itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectStackDrift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectStackDrift operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectStackDrift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        IAsyncResult BeginDetectStackDrift(DetectStackDriftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectStackDrift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectStackDrift.</param>
        /// 
        /// <returns>Returns a  DetectStackDriftResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        DetectStackDriftResponse EndDetectStackDrift(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectStackResourceDrift


        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from its expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
        /// unmanaged configuration changes to stacks and resources with drift detection</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackResourceDrift</c> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all resources in a given stack that support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that don't currently support drift detection can't be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackResourceDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectStackResourceDrift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectStackResourceDrift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        IAsyncResult BeginDetectStackResourceDrift(DetectStackResourceDriftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectStackResourceDrift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectStackResourceDrift.</param>
        /// 
        /// <returns>Returns a  DetectStackResourceDriftResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        DetectStackResourceDriftResponse EndDetectStackResourceDrift(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectStackSetDrift


        /// <summary>
        /// Detect drift on a StackSet. When CloudFormation performs drift detection on a StackSet,
        /// it performs drift detection on the stack associated with each stack instance in the
        /// StackSet. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Performing
        /// drift detection on CloudFormation StackSets</a>.
        /// 
        ///  
        /// <para>
        ///  <c>DetectStackSetDrift</c> returns the <c>OperationId</c> of the StackSet drift detection
        /// operation. Use this operation id with <a>DescribeStackSetOperation</a> to monitor
        /// the progress of the drift detection operation. The drift detection operation may take
        /// some time, depending on the number of stack instances included in the StackSet, in
        /// addition to the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a>DescribeStackSet</a> to return detailed information about the stack set, including
        /// detailed information about the last <i>completed</i> drift operation performed on
        /// the StackSet. (Information about drift operations that are in progress isn't included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>ListStackInstances</a> to return a list of stack instances belonging to the
        /// StackSet, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>DescribeStackInstance</a> to return detailed information about a specific stack
        /// instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can only run a single drift detection operation on a given StackSet at one time.
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection StackSet operation, use <a>StopStackSetOperation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackSetDrift service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        DetectStackSetDriftResponse DetectStackSetDrift(DetectStackSetDriftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectStackSetDrift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectStackSetDrift
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        IAsyncResult BeginDetectStackSetDrift(DetectStackSetDriftRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectStackSetDrift operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectStackSetDrift.</param>
        /// 
        /// <returns>Returns a  DetectStackSetDriftResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        DetectStackSetDriftResponse EndDetectStackSetDrift(IAsyncResult asyncResult);

        #endregion
        
        #region  EstimateTemplateCost


        /// <summary>
        /// Returns the estimated monthly cost of a template. The return value is an Amazon Web
        /// Services Simple Monthly Calculator URL with a query string that describes the resources
        /// required to run the template.
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
        /// set was created. After the call successfully completes, CloudFormation starts updating
        /// the stack. Use the <a>DescribeStacks</a> action to view the status of the update.
        /// 
        ///  
        /// <para>
        /// When you execute a change set, CloudFormation deletes all other change sets associated
        /// with the stack because they aren't valid for the updated stack.
        /// </para>
        ///  
        /// <para>
        /// If a stack policy is associated with the stack, CloudFormation enforces the policy
        /// during the update. You can't specify a temporary stack policy that overrides the current
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// To create a change set for the entire stack hierarchy, <c>IncludeNestedStacks</c>
        /// must have been set to <c>True</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet service method.</param>
        /// 
        /// <returns>The response from the ExecuteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InsufficientCapabilitiesException">
        /// The template contains resources with capabilities that weren't specified in the Capabilities
        /// parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <c>CREATE_IN_PROGRESS</c>, or the stack status might be <c>UPDATE_IN_PROGRESS</c>.
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
        
        #region  ExecuteStackRefactor


        /// <summary>
        /// Executes the stack refactor operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStackRefactor service method.</param>
        /// 
        /// <returns>The response from the ExecuteStackRefactor service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteStackRefactor">REST API Reference for ExecuteStackRefactor Operation</seealso>
        ExecuteStackRefactorResponse ExecuteStackRefactor(ExecuteStackRefactorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStackRefactor operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteStackRefactor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteStackRefactor">REST API Reference for ExecuteStackRefactor Operation</seealso>
        IAsyncResult BeginExecuteStackRefactor(ExecuteStackRefactorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteStackRefactor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteStackRefactor.</param>
        /// 
        /// <returns>Returns a  ExecuteStackRefactorResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteStackRefactor">REST API Reference for ExecuteStackRefactor Operation</seealso>
        ExecuteStackRefactorResponse EndExecuteStackRefactor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGeneratedTemplate


        /// <summary>
        /// Retrieves a generated template. If the template is in an <c>InProgress</c> or <c>Pending</c>
        /// status then the template returned will be the template when the template was last
        /// in a <c>Complete</c> status. If the template has not yet been in a <c>Complete</c>
        /// status then an empty template will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedTemplate service method.</param>
        /// 
        /// <returns>The response from the GetGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetGeneratedTemplate">REST API Reference for GetGeneratedTemplate Operation</seealso>
        GetGeneratedTemplateResponse GetGeneratedTemplate(GetGeneratedTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeneratedTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetGeneratedTemplate">REST API Reference for GetGeneratedTemplate Operation</seealso>
        IAsyncResult BeginGetGeneratedTemplate(GetGeneratedTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeneratedTemplate.</param>
        /// 
        /// <returns>Returns a  GetGeneratedTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetGeneratedTemplate">REST API Reference for GetGeneratedTemplate Operation</seealso>
        GetGeneratedTemplateResponse EndGetGeneratedTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHookResult


        /// <summary>
        /// Retrieves detailed information and remediation guidance for a Hook invocation result.
        /// 
        ///  
        /// <para>
        /// If the Hook uses a KMS key to encrypt annotations, callers of the <c>GetHookResult</c>
        /// operation must have <c>kms:Decrypt</c> permissions. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/hooks-kms-key-policy.html">KMS
        /// key policy and permissions for encrypting CloudFormation Hooks results at rest</a>
        /// in the <i>CloudFormation Hooks User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHookResult service method.</param>
        /// 
        /// <returns>The response from the GetHookResult service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.HookResultNotFoundException">
        /// The specified target doesn't have any requested Hook invocations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetHookResult">REST API Reference for GetHookResult Operation</seealso>
        GetHookResultResponse GetHookResult(GetHookResultRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHookResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHookResult operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHookResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetHookResult">REST API Reference for GetHookResult Operation</seealso>
        IAsyncResult BeginGetHookResult(GetHookResultRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHookResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHookResult.</param>
        /// 
        /// <returns>Returns a  GetHookResultResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetHookResult">REST API Reference for GetHookResult Operation</seealso>
        GetHookResultResponse EndGetHookResult(IAsyncResult asyncResult);

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
        /// For deleted stacks, <c>GetTemplate</c> returns the template for up to 90 days after
        /// the stack has been deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the template doesn't exist, a <c>ValidationError</c> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
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
        /// Returns information about a new or existing template. The <c>GetTemplateSummary</c>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or StackSet.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetTemplateSummary</c> action when you submit a template, or you
        /// can get template information for a StackSet, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <c>GetTemplateSummary</c> returns the template information for
        /// up to 90 days after the stack has been deleted. If the template doesn't exist, a <c>ValidationError</c>
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        
        #region  ImportStacksToStackSet


        /// <summary>
        /// Import existing stacks into a new StackSets. Use the stack import operation to import
        /// up to 10 stacks into a new StackSet in the same account as the source stack or in
        /// a different administrator account and Region, by specifying the stack ID of the stack
        /// you intend to import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportStacksToStackSet service method.</param>
        /// 
        /// <returns>The response from the ImportStacksToStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationIdAlreadyExistsException">
        /// The specified operation ID already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackNotFoundException">
        /// The specified stack ARN doesn't exist or stack doesn't exist corresponding to the
        /// ARN in input.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        ImportStacksToStackSetResponse ImportStacksToStackSet(ImportStacksToStackSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportStacksToStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportStacksToStackSet operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportStacksToStackSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        IAsyncResult BeginImportStacksToStackSet(ImportStacksToStackSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportStacksToStackSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportStacksToStackSet.</param>
        /// 
        /// <returns>Returns a  ImportStacksToStackSetResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        ImportStacksToStackSetResponse EndImportStacksToStackSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the ID and status of each active change set for a stack. For example, CloudFormation
        /// lists change sets that are in the <c>CREATE_IN_PROGRESS</c> or <c>CREATE_PENDING</c>
        /// state.
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
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/intrinsic-function-reference-importvalue.html">
        /// Fn::ImportValue</a> function.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">Get
        /// exported outputs from a deployed CloudFormation stack</a>.
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
        
        #region  ListGeneratedTemplates


        /// <summary>
        /// Lists your generated templates in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedTemplates service method.</param>
        /// 
        /// <returns>The response from the ListGeneratedTemplates service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListGeneratedTemplates">REST API Reference for ListGeneratedTemplates Operation</seealso>
        ListGeneratedTemplatesResponse ListGeneratedTemplates(ListGeneratedTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeneratedTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedTemplates operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeneratedTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListGeneratedTemplates">REST API Reference for ListGeneratedTemplates Operation</seealso>
        IAsyncResult BeginListGeneratedTemplates(ListGeneratedTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeneratedTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeneratedTemplates.</param>
        /// 
        /// <returns>Returns a  ListGeneratedTemplatesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListGeneratedTemplates">REST API Reference for ListGeneratedTemplates Operation</seealso>
        ListGeneratedTemplatesResponse EndListGeneratedTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHookResults


        /// <summary>
        /// Returns summaries of invoked Hooks. For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/hooks-view-invocations.html">View
        /// invocation summaries for CloudFormation Hooks</a> in the <i>CloudFormation Hooks User
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation supports the following parameter combinations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No parameters: Returns all Hook invocation summaries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TypeArn</c> only: Returns summaries for a specific Hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TypeArn</c> and <c>Status</c>: Returns summaries for a specific Hook filtered
        /// by status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetId</c> and <c>TargetType</c>: Returns summaries for a specific Hook invocation
        /// target.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHookResults service method.</param>
        /// 
        /// <returns>The response from the ListHookResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.HookResultNotFoundException">
        /// The specified target doesn't have any requested Hook invocations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListHookResults">REST API Reference for ListHookResults Operation</seealso>
        ListHookResultsResponse ListHookResults(ListHookResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHookResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHookResults operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHookResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListHookResults">REST API Reference for ListHookResults Operation</seealso>
        IAsyncResult BeginListHookResults(ListHookResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHookResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHookResults.</param>
        /// 
        /// <returns>Returns a  ListHookResultsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListHookResults">REST API Reference for ListHookResults Operation</seealso>
        ListHookResultsResponse EndListHookResults(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>.
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/intrinsic-function-reference-importvalue.html">Fn::ImportValue</a>
        /// function.
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
        
        #region  ListResourceScanRelatedResources


        /// <summary>
        /// Lists the related resources for a list of resources from a resource scan. The response
        /// indicates whether each returned resource is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanRelatedResources service method.</param>
        /// 
        /// <returns>The response from the ListResourceScanRelatedResources service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanRelatedResources">REST API Reference for ListResourceScanRelatedResources Operation</seealso>
        ListResourceScanRelatedResourcesResponse ListResourceScanRelatedResources(ListResourceScanRelatedResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceScanRelatedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanRelatedResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceScanRelatedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanRelatedResources">REST API Reference for ListResourceScanRelatedResources Operation</seealso>
        IAsyncResult BeginListResourceScanRelatedResources(ListResourceScanRelatedResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceScanRelatedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceScanRelatedResources.</param>
        /// 
        /// <returns>Returns a  ListResourceScanRelatedResourcesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanRelatedResources">REST API Reference for ListResourceScanRelatedResources Operation</seealso>
        ListResourceScanRelatedResourcesResponse EndListResourceScanRelatedResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceScanResources


        /// <summary>
        /// Lists the resources from a resource scan. The results can be filtered by resource
        /// identifier, resource type prefix, tag key, and tag value. Only resources that match
        /// all specified filters are returned. The response indicates whether each returned resource
        /// is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanResources service method.</param>
        /// 
        /// <returns>The response from the ListResourceScanResources service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanResources">REST API Reference for ListResourceScanResources Operation</seealso>
        ListResourceScanResourcesResponse ListResourceScanResources(ListResourceScanResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceScanResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanResources operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceScanResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanResources">REST API Reference for ListResourceScanResources Operation</seealso>
        IAsyncResult BeginListResourceScanResources(ListResourceScanResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceScanResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceScanResources.</param>
        /// 
        /// <returns>Returns a  ListResourceScanResourcesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScanResources">REST API Reference for ListResourceScanResources Operation</seealso>
        ListResourceScanResourcesResponse EndListResourceScanResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceScans


        /// <summary>
        /// List the resource scans from newest to oldest. By default it will return up to 10
        /// resource scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScans service method.</param>
        /// 
        /// <returns>The response from the ListResourceScans service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScans">REST API Reference for ListResourceScans Operation</seealso>
        ListResourceScansResponse ListResourceScans(ListResourceScansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceScans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScans operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceScans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScans">REST API Reference for ListResourceScans Operation</seealso>
        IAsyncResult BeginListResourceScans(ListResourceScansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceScans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceScans.</param>
        /// 
        /// <returns>Returns a  ListResourceScansResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScans">REST API Reference for ListResourceScans Operation</seealso>
        ListResourceScansResponse EndListResourceScans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackInstanceResourceDrifts


        /// <summary>
        /// Returns drift information for resources in a stack instance.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>ListStackInstanceResourceDrifts</c> returns drift information for the most recent
        /// drift detection operation. If an operation is in progress, it may only return partial
        /// results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstanceResourceDrifts service method.</param>
        /// 
        /// <returns>The response from the ListStackInstanceResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        ListStackInstanceResourceDriftsResponse ListStackInstanceResourceDrifts(ListStackInstanceResourceDriftsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackInstanceResourceDrifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstanceResourceDrifts operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackInstanceResourceDrifts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        IAsyncResult BeginListStackInstanceResourceDrifts(ListStackInstanceResourceDriftsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackInstanceResourceDrifts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackInstanceResourceDrifts.</param>
        /// 
        /// <returns>Returns a  ListStackInstanceResourceDriftsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        ListStackInstanceResourceDriftsResponse EndListStackInstanceResourceDrifts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackInstances


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// StackSet. You can filter for stack instances that are associated with a specific Amazon
        /// Web Services account name or Region, or that have a specific status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        
        #region  ListStackRefactorActions


        /// <summary>
        /// Lists the stack refactor actions that will be taken after calling the <a>ExecuteStackRefactor</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactorActions service method.</param>
        /// 
        /// <returns>The response from the ListStackRefactorActions service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactorActions">REST API Reference for ListStackRefactorActions Operation</seealso>
        ListStackRefactorActionsResponse ListStackRefactorActions(ListStackRefactorActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackRefactorActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactorActions operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackRefactorActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactorActions">REST API Reference for ListStackRefactorActions Operation</seealso>
        IAsyncResult BeginListStackRefactorActions(ListStackRefactorActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackRefactorActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackRefactorActions.</param>
        /// 
        /// <returns>Returns a  ListStackRefactorActionsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactorActions">REST API Reference for ListStackRefactorActions Operation</seealso>
        ListStackRefactorActionsResponse EndListStackRefactorActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackRefactors


        /// <summary>
        /// Lists all account stack refactor operations and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactors service method.</param>
        /// 
        /// <returns>The response from the ListStackRefactors service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactors">REST API Reference for ListStackRefactors Operation</seealso>
        ListStackRefactorsResponse ListStackRefactors(ListStackRefactorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackRefactors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackRefactors operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackRefactors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactors">REST API Reference for ListStackRefactors Operation</seealso>
        IAsyncResult BeginListStackRefactors(ListStackRefactorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackRefactors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackRefactors.</param>
        /// 
        /// <returns>Returns a  ListStackRefactorsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackRefactors">REST API Reference for ListStackRefactors Operation</seealso>
        ListStackRefactorsResponse EndListStackRefactors(IAsyncResult asyncResult);

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
        /// Returns the summary information for stacks whose status matches the specified <c>StackStatusFilter</c>.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no <c>StackStatusFilter</c> is specified, summary information
        /// for all stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        ListStacksResponse ListStacks();

        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified <c>StackStatusFilter</c>.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no <c>StackStatusFilter</c> is specified, summary information
        /// for all stacks is returned (including existing stacks and stacks that have been deleted).
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
        
        #region  ListStackSetAutoDeploymentTargets


        /// <summary>
        /// Returns summary information about deployment targets for a StackSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetAutoDeploymentTargets service method.</param>
        /// 
        /// <returns>The response from the ListStackSetAutoDeploymentTargets service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        ListStackSetAutoDeploymentTargetsResponse ListStackSetAutoDeploymentTargets(ListStackSetAutoDeploymentTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetAutoDeploymentTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetAutoDeploymentTargets operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackSetAutoDeploymentTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        IAsyncResult BeginListStackSetAutoDeploymentTargets(ListStackSetAutoDeploymentTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackSetAutoDeploymentTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackSetAutoDeploymentTargets.</param>
        /// 
        /// <returns>Returns a  ListStackSetAutoDeploymentTargetsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        ListStackSetAutoDeploymentTargetsResponse EndListStackSetAutoDeploymentTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackSetOperationResults


        /// <summary>
        /// Returns summary information about the results of a StackSet operation.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>eventually consistent</i> reads meaning it may take some time
        /// but will eventually return the most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        /// Returns summary information about operations performed on a StackSet.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>eventually consistent</i> reads meaning it may take some time
        /// but will eventually return the most up-to-date data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
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
        /// Returns summary information about StackSets that are associated with the user.
        /// 
        ///  <note> 
        /// <para>
        /// This API provides <i>strongly consistent</i> reads meaning it will always return the
        /// most up-to-date data.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// [Self-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c> while
        /// signed in to your Amazon Web Services account, <c>ListStackSets</c> returns all self-managed
        /// StackSets in your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c>
        /// while signed in to the organization's management account, <c>ListStackSets</c> returns
        /// all StackSets in the management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>DELEGATED_ADMIN</c>
        /// while signed in to your member account, <c>ListStackSets</c> returns all StackSets
        /// with service-managed permissions in the management account.
        /// </para>
        ///  </li> </ul>
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
        
        #region  ListTypeRegistrations


        /// <summary>
        /// Returns a list of registration tokens for the specified extension(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListTypeRegistrations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        ListTypeRegistrationsResponse ListTypeRegistrations(ListTypeRegistrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypeRegistrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypeRegistrations operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypeRegistrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        IAsyncResult BeginListTypeRegistrations(ListTypeRegistrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypeRegistrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypeRegistrations.</param>
        /// 
        /// <returns>Returns a  ListTypeRegistrationsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        ListTypeRegistrationsResponse EndListTypeRegistrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTypes


        /// <summary>
        /// Returns summary information about all extensions, including your private resource
        /// types, modules, and Hooks as well as all public extensions from Amazon Web Services
        /// and third-party publishers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        ListTypesResponse ListTypes(ListTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypes operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        IAsyncResult BeginListTypes(ListTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypes.</param>
        /// 
        /// <returns>Returns a  ListTypesResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        ListTypesResponse EndListTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTypeVersions


        /// <summary>
        /// Returns summary information about the versions of an extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeVersions service method.</param>
        /// 
        /// <returns>The response from the ListTypeVersions service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        ListTypeVersionsResponse ListTypeVersions(ListTypeVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTypeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTypeVersions operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTypeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        IAsyncResult BeginListTypeVersions(ListTypeVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTypeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTypeVersions.</param>
        /// 
        /// <returns>Returns a  ListTypeVersionsResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        ListTypeVersionsResponse EndListTypeVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishType


        /// <summary>
        /// Publishes the specified extension to the CloudFormation registry as a public extension
        /// in this Region. Public extensions are available for use by all CloudFormation users.
        /// For more information about publishing extensions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To publish an extension, you must be registered as a publisher with CloudFormation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishType service method.</param>
        /// 
        /// <returns>The response from the PublishType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/PublishType">REST API Reference for PublishType Operation</seealso>
        PublishTypeResponse PublishType(PublishTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/PublishType">REST API Reference for PublishType Operation</seealso>
        IAsyncResult BeginPublishType(PublishTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishType.</param>
        /// 
        /// <returns>Returns a  PublishTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/PublishType">REST API Reference for PublishType Operation</seealso>
        PublishTypeResponse EndPublishType(IAsyncResult asyncResult);

        #endregion
        
        #region  RecordHandlerProgress


        /// <summary>
        /// Reports progress of a resource handler to CloudFormation.
        /// 
        ///  
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. Don't use this API in your code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordHandlerProgress service method.</param>
        /// 
        /// <returns>The response from the RecordHandlerProgress service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidStateTransitionException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation doesn't return this error to users.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationStatusCheckFailedException">
        /// Error reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. CloudFormation doesn't return this error to users.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        RecordHandlerProgressResponse RecordHandlerProgress(RecordHandlerProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecordHandlerProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordHandlerProgress operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecordHandlerProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        IAsyncResult BeginRecordHandlerProgress(RecordHandlerProgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecordHandlerProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordHandlerProgress.</param>
        /// 
        /// <returns>Returns a  RecordHandlerProgressResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RecordHandlerProgress">REST API Reference for RecordHandlerProgress Operation</seealso>
        RecordHandlerProgressResponse EndRecordHandlerProgress(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterPublisher


        /// <summary>
        /// Registers your account as a publisher of public extensions in the CloudFormation registry.
        /// Public extensions are available for use by all CloudFormation users. This publisher
        /// ID applies to your account in all Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// For information about requirements for registering as a public extension publisher,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Prerequisite:
        /// Registering your account to publish CloudFormation extensions</a> in the <i>CloudFormation
        /// Command Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPublisher service method.</param>
        /// 
        /// <returns>The response from the RegisterPublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterPublisher">REST API Reference for RegisterPublisher Operation</seealso>
        RegisterPublisherResponse RegisterPublisher(RegisterPublisherRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterPublisher operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterPublisher operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterPublisher
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterPublisher">REST API Reference for RegisterPublisher Operation</seealso>
        IAsyncResult BeginRegisterPublisher(RegisterPublisherRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterPublisher operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterPublisher.</param>
        /// 
        /// <returns>Returns a  RegisterPublisherResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterPublisher">REST API Reference for RegisterPublisher Operation</seealso>
        RegisterPublisherResponse EndRegisterPublisher(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterType


        /// <summary>
        /// Registers an extension with the CloudFormation service. Registering an extension makes
        /// it available for use in CloudFormation templates in your Amazon Web Services account,
        /// and includes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Validating the extension schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Determining which handlers, if any, have been specified for the extension.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Making the extension available for use in your account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about how to develop extensions and ready them for registration,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-types.html">Creating
        /// resource types using the CloudFormation CLI</a> in the <i>CloudFormation Command Line
        /// Interface (CLI) User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have a maximum of 50 resource extension versions registered at a time. This
        /// maximum is per account and per Region. Use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeregisterType.html">DeregisterType</a>
        /// to deregister specific extension versions if necessary.
        /// </para>
        ///  
        /// <para>
        /// Once you have initiated a registration request using <a>RegisterType</a>, you can
        /// use <a>DescribeTypeRegistration</a> to monitor the progress of the registration request.
        /// </para>
        ///  
        /// <para>
        /// Once you have registered a private extension in your account and Region, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to specify configuration properties for the extension. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterType service method.</param>
        /// 
        /// <returns>The response from the RegisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        RegisterTypeResponse RegisterType(RegisterTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        IAsyncResult BeginRegisterType(RegisterTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterType.</param>
        /// 
        /// <returns>Returns a  RegisterTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        RegisterTypeResponse EndRegisterType(IAsyncResult asyncResult);

        #endregion
        
        #region  RollbackStack


        /// <summary>
        /// When specifying <c>RollbackStack</c>, you preserve the state of previously provisioned
        /// resources when an operation fails. You can check the status of the stack through the
        /// <a>DescribeStacks</a> operation.
        /// 
        ///  
        /// <para>
        /// Rolls back the specified stack to the last known stable state from <c>CREATE_FAILED</c>
        /// or <c>UPDATE_FAILED</c> stack statuses.
        /// </para>
        ///  
        /// <para>
        /// This operation will delete a stack if it doesn't contain a last known stable state.
        /// A last known stable state includes any status in a <c>*_COMPLETE</c>. This includes
        /// the following stack statuses.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_ROLLBACK_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORT_COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORT_ROLLBACK_COMPLETE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackStack service method.</param>
        /// 
        /// <returns>The response from the RollbackStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackStack">REST API Reference for RollbackStack Operation</seealso>
        RollbackStackResponse RollbackStack(RollbackStackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RollbackStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RollbackStack operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRollbackStack
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackStack">REST API Reference for RollbackStack Operation</seealso>
        IAsyncResult BeginRollbackStack(RollbackStackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RollbackStack operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRollbackStack.</param>
        /// 
        /// <returns>Returns a  RollbackStackResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackStack">REST API Reference for RollbackStack Operation</seealso>
        RollbackStackResponse EndRollbackStack(IAsyncResult asyncResult);

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
        
        #region  SetTypeConfiguration


        /// <summary>
        /// Specifies the configuration data for a CloudFormation extension, such as a resource
        /// or Hook, in the given account and Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
        /// configuration data for extensions in your account</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view the current configuration data for an extension, refer to the <c>ConfigurationSchema</c>
        /// element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It's strongly recommended that you use dynamic references to restrict sensitive configuration
        /// definitions, such as third-party credentials. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/dynamic-references.html">Specify
        /// values stored in other services using dynamic references</a> in the <i>CloudFormation
        /// User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about setting the configuration data for resource types, see
        /// <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-model.html#resource-type-howto-configuration">Defining
        /// the account-level configuration of an extension</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>. For more information about setting the configuration
        /// data for Hooks, see the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/hooks-userguide/what-is-cloudformation-hooks.html">CloudFormation
        /// Hooks User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetTypeConfiguration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeConfiguration">REST API Reference for SetTypeConfiguration Operation</seealso>
        SetTypeConfigurationResponse SetTypeConfiguration(SetTypeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTypeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTypeConfiguration operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTypeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeConfiguration">REST API Reference for SetTypeConfiguration Operation</seealso>
        IAsyncResult BeginSetTypeConfiguration(SetTypeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTypeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTypeConfiguration.</param>
        /// 
        /// <returns>Returns a  SetTypeConfigurationResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeConfiguration">REST API Reference for SetTypeConfiguration Operation</seealso>
        SetTypeConfigurationResponse EndSetTypeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTypeDefaultVersion


        /// <summary>
        /// Specify the default version of an extension. The default version of an extension will
        /// be used in CloudFormation operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeDefaultVersion service method.</param>
        /// 
        /// <returns>The response from the SetTypeDefaultVersion service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        SetTypeDefaultVersionResponse SetTypeDefaultVersion(SetTypeDefaultVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTypeDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTypeDefaultVersion operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTypeDefaultVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        IAsyncResult BeginSetTypeDefaultVersion(SetTypeDefaultVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTypeDefaultVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTypeDefaultVersion.</param>
        /// 
        /// <returns>Returns a  SetTypeDefaultVersionResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        SetTypeDefaultVersionResponse EndSetTypeDefaultVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  SignalResource


        /// <summary>
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the <c>SignalResource</c> operation in conjunction with a creation policy or update
        /// policy. CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The <c>SignalResource</c>
        /// operation is useful in cases where you want to send signals from anywhere other than
        /// an Amazon EC2 instance.
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
        
        #region  StartResourceScan


        /// <summary>
        /// Starts a scan of the resources in this account in this Region. You can the status
        /// of a scan using the <c>ListResourceScans</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
        /// 
        /// <returns>The response from the StartResourceScan service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanInProgressException">
        /// A resource scan is currently in progress. Only one can be run at a time for an account
        /// in a Region.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanLimitExceededException">
        /// The limit on resource scans has been exceeded. Reasons include:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeded the daily quota for resource scans.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A resource scan recently failed. You must wait 10 minutes before starting a new resource
        /// scan.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The last resource scan failed after exceeding 100,000 resources. When this happens,
        /// you must wait 24 hours before starting a new resource scan.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        StartResourceScanResponse StartResourceScan(StartResourceScanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartResourceScan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartResourceScan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        IAsyncResult BeginStartResourceScan(StartResourceScanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartResourceScan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartResourceScan.</param>
        /// 
        /// <returns>Returns a  StartResourceScanResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StartResourceScan">REST API Reference for StartResourceScan Operation</seealso>
        StartResourceScanResponse EndStartResourceScan(IAsyncResult asyncResult);

        #endregion
        
        #region  StopStackSetOperation


        /// <summary>
        /// Stops an in-progress operation on a StackSet and its associated stack instances. StackSets
        /// will cancel all the unstarted stack instance deployments and wait for those are in-progress
        /// to complete.
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
        /// The specified StackSet doesn't exist.
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
        
        #region  TestType


        /// <summary>
        /// Tests a registered extension to make sure it meets all necessary requirements for
        /// being published in the CloudFormation registry.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For resource types, this includes passing all contracts tests defined for the type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For modules, this includes determining if the module's model meets all necessary requirements.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-testing">Testing
        /// your public extension before publishing</a> in the <i>CloudFormation Command Line
        /// Interface (CLI) User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a version, CloudFormation uses the default version of the extension
        /// in your account and Region for testing.
        /// </para>
        ///  
        /// <para>
        /// To perform testing, CloudFormation assumes the execution role specified when the type
        /// was registered. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>.
        /// </para>
        ///  
        /// <para>
        /// Once you've initiated testing on an extension using <c>TestType</c>, you can pass
        /// the returned <c>TypeVersionArn</c> into <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>
        /// to monitor the current test status and test status description for the extension.
        /// </para>
        ///  
        /// <para>
        /// An extension must have a test status of <c>PASSED</c> before it can be published.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-publish.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation Command
        /// Line Interface (CLI) User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestType service method.</param>
        /// 
        /// <returns>The response from the TestType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/TestType">REST API Reference for TestType Operation</seealso>
        TestTypeResponse TestType(TestTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestType operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/TestType">REST API Reference for TestType Operation</seealso>
        IAsyncResult BeginTestType(TestTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestType.</param>
        /// 
        /// <returns>Returns a  TestTypeResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/TestType">REST API Reference for TestType Operation</seealso>
        TestTypeResponse EndTestType(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGeneratedTemplate


        /// <summary>
        /// Updates a generated template. This can be used to change the name, add and remove
        /// resources, refresh resources, and change the <c>DeletionPolicy</c> and <c>UpdateReplacePolicy</c>
        /// settings. You can check the status of the update to the generated template using the
        /// <c>DescribeGeneratedTemplate</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeneratedTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.AlreadyExistsException">
        /// The resource with the name requested already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.LimitExceededException">
        /// The quota for the resource has already been reached.
        /// 
        ///  
        /// <para>
        /// For information about resource and stack limitations, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateGeneratedTemplate">REST API Reference for UpdateGeneratedTemplate Operation</seealso>
        UpdateGeneratedTemplateResponse UpdateGeneratedTemplate(UpdateGeneratedTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeneratedTemplate operation on AmazonCloudFormationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGeneratedTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateGeneratedTemplate">REST API Reference for UpdateGeneratedTemplate Operation</seealso>
        IAsyncResult BeginUpdateGeneratedTemplate(UpdateGeneratedTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGeneratedTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGeneratedTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateGeneratedTemplateResult from CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateGeneratedTemplate">REST API Reference for UpdateGeneratedTemplate Operation</seealso>
        UpdateGeneratedTemplateResponse EndUpdateGeneratedTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStack


        /// <summary>
        /// Updates a stack as specified in the template. After the call completes successfully,
        /// the stack update starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// To get a copy of the template for an existing stack, you can use the <a>GetTemplate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information about updating a stack and monitoring the progress of the update,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacks.html">Managing
        /// Amazon Web Services resources as a single unit with CloudFormation stacks</a> in the
        /// <i>CloudFormation User Guide</i>.
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
        /// the specified Amazon Web Services Regions. A stack instance refers to a stack in a
        /// specific account and Region.
        /// 
        ///  
        /// <para>
        /// You can only update stack instances in Amazon Web Services Regions and accounts where
        /// they already exist; to create additional stack instances, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CreateStackInstances.html">CreateStackInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// During StackSet updates, any parameters overridden for a stack instance aren't updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the StackSet.
        /// To add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the StackSet template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the StackSet you must first use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the StackSet. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <c>UpdateStackInstances</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>UpdateStackInstances</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
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
        /// Updates the StackSet and associated stack instances in the specified accounts and
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// Even if the StackSet operation created by updating the StackSet fails (completely
        /// or partially, below or above a specified failure tolerance), the StackSet is updated
        /// with your changes. Subsequent <a>CreateStackInstances</a> calls on the specified StackSet
        /// use the updated StackSet.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of organizational unit (OUs) supported by a <c>UpdateStackSet</c>
        /// operation is 50.
        /// </para>
        ///  
        /// <para>
        /// If you need more than 50, consider the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
        /// the operations into multiple calls with less than 50 OUs each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
        /// parent OU that contains all desired child OUs.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Another operation is currently in progress for this StackSet. Only one operation can
        /// be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified StackSet doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this StackSet since the specified operation
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
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protect
        /// a CloudFormation stack from being deleted</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and can't be changed directly
        /// on the nested stack.
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
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
        /// </summary>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        ValidateTemplateResponse ValidateTemplate();

        /// <summary>
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
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
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}
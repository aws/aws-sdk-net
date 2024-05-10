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
using System.Threading;
using System.Threading.Tasks;
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
    /// Store, Amazon Simple Notification Service, Elastic Load Balancing, and Auto Scaling
    /// to build highly reliable, highly scalable, cost-effective applications without creating
    /// or configuring the underlying Amazon Web Services infrastructure.
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudFormationPaginatorFactory Paginators { get; }

        
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
        /// Activate trusted access with Organizations. With trusted access between StackSets
        /// and Organizations activated, the management account has permissions to create and
        /// manage StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateOrganizationsAccess">REST API Reference for ActivateOrganizationsAccess Operation</seealso>
        Task<ActivateOrganizationsAccessResponse> ActivateOrganizationsAccessAsync(ActivateOrganizationsAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ActivateType


        /// <summary>
        /// Activates a public third-party extension, making it available for use in stack templates.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html">Using
        /// public extensions</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Once you have activated a public third-party extension in your account and Region,
        /// use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to specify configuration properties for the extension. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
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
        /// Activates a public third-party extension, making it available for use in stack templates.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html">Using
        /// public extensions</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Once you have activated a public third-party extension in your account and Region,
        /// use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_SetTypeConfiguration.html">SetTypeConfiguration</a>
        /// to specify configuration properties for the extension. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ActivateType">REST API Reference for ActivateType Operation</seealso>
        Task<ActivateTypeResponse> ActivateTypeAsync(ActivateTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDescribeTypeConfigurations


        /// <summary>
        /// Returns configuration data for the specified CloudFormation extensions, from the CloudFormation
        /// registry for the account and Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns configuration data for the specified CloudFormation extensions, from the CloudFormation
        /// registry for the account and Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeTypeConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeTypeConfigurations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeConfigurationNotFoundException">
        /// The specified extension configuration can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/BatchDescribeTypeConfigurations">REST API Reference for BatchDescribeTypeConfigurations Operation</seealso>
        Task<BatchDescribeTypeConfigurationsResponse> BatchDescribeTypeConfigurationsAsync(BatchDescribeTypeConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelUpdateStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ContinueUpdateRollback


        /// <summary>
        /// For a specified stack that's in the <c>UPDATE_ROLLBACK_FAILED</c> state, continues
        /// rolling it back to the <c>UPDATE_ROLLBACK_COMPLETE</c> state. Depending on the cause
        /// of the failure, you can manually <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <c>UPDATE_ROLLBACK_COMPLETE</c> state), and then
        /// try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <c>UPDATE_ROLLBACK_FAILED</c> state when CloudFormation can't
        /// roll back all changes after a failed stack update. For example, you might have a stack
        /// that's rolling back to an old database instance that was deleted outside of CloudFormation.
        /// Because CloudFormation doesn't know the database was deleted, it assumes that the
        /// database instance still exists and attempts to roll back to it, causing the update
        /// rollback to fail.
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
        /// For a specified stack that's in the <c>UPDATE_ROLLBACK_FAILED</c> state, continues
        /// rolling it back to the <c>UPDATE_ROLLBACK_COMPLETE</c> state. Depending on the cause
        /// of the failure, you can manually <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/troubleshooting.html#troubleshooting-errors-update-rollback-failed">
        /// fix the error</a> and continue the rollback. By continuing the rollback, you can return
        /// your stack to a working state (the <c>UPDATE_ROLLBACK_COMPLETE</c> state), and then
        /// try to update the stack again.
        /// 
        ///  
        /// <para>
        /// A stack goes into the <c>UPDATE_ROLLBACK_FAILED</c> state when CloudFormation can't
        /// roll back all changes after a failed stack update. For example, you might have a stack
        /// that's rolling back to an old database instance that was deleted outside of CloudFormation.
        /// Because CloudFormation doesn't know the database was deleted, it assumes that the
        /// database instance still exists and attempts to roll back to it, causing the update
        /// rollback to fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ContinueUpdateRollback service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        Task<ContinueUpdateRollbackResponse> ContinueUpdateRollbackAsync(ContinueUpdateRollbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a template from existing resources that are not already managed with CloudFormation.
        /// You can check the status of the template generation using the <c>DescribeGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateGeneratedTemplateResponse> CreateGeneratedTemplateAsync(CreateGeneratedTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStack


        /// <summary>
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// operation.
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
        /// Creates a stack as specified in the template. After the call completes successfully,
        /// the stack creation starts. You can check the status of the stack through the <a>DescribeStacks</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStackInstances


        /// <summary>
        /// Creates stack instances for the specified accounts, within the specified Amazon Web
        /// Services Regions. A stack instance refers to a stack in a specific account and Region.
        /// You must specify at least one value for either <c>Accounts</c> or <c>DeploymentTargets</c>,
        /// and you must specify at least one value for <c>Regions</c>.
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
        /// Creates stack instances for the specified accounts, within the specified Amazon Web
        /// Services Regions. A stack instance refers to a stack in a specific account and Region.
        /// You must specify at least one value for either <c>Accounts</c> or <c>DeploymentTargets</c>,
        /// and you must specify at least one value for <c>Regions</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deactivates trusted access with Organizations. If trusted access is deactivated, the
        /// management account does not have permissions to create and manage service-managed
        /// StackSets for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateOrganizationsAccess">REST API Reference for DeactivateOrganizationsAccess Operation</seealso>
        Task<DeactivateOrganizationsAccessResponse> DeactivateOrganizationsAccessAsync(DeactivateOrganizationsAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeactivateType


        /// <summary>
        /// Deactivates a public extension that was previously activated in this account and Region.
        /// 
        ///  
        /// <para>
        /// Once deactivated, an extension can't be used in any CloudFormation operation. This
        /// includes stack update operations where the stack template includes the extension,
        /// even if no updates are being made to the extension. In addition, deactivated extensions
        /// aren't automatically updated if a new version of the extension is released.
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
        /// Deactivates a public extension that was previously activated in this account and Region.
        /// 
        ///  
        /// <para>
        /// Once deactivated, an extension can't be used in any CloudFormation operation. This
        /// includes stack update operations where the stack template includes the extension,
        /// even if no updates are being made to the extension. In addition, deactivated extensions
        /// aren't automatically updated if a new version of the extension is released.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeactivateType">REST API Reference for DeactivateType Operation</seealso>
        Task<DeactivateTypeResponse> DeactivateTypeAsync(DeactivateTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidChangeSetStatusException">
        /// The specified change set can't be used to update the stack. For example, the change
        /// set status might be <c>CREATE_IN_PROGRESS</c>, or the stack status might be <c>UPDATE_IN_PROGRESS</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deleted a generated template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGeneratedTemplateResponse> DeleteGeneratedTemplateAsync(DeleteGeneratedTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStack


        /// <summary>
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks don't show up in the <a>DescribeStacks</a> operation if the deletion
        /// has been completed successfully.
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
        /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
        /// Deleted stacks don't show up in the <a>DescribeStacks</a> operation if the deletion
        /// has been completed successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStackInstances


        /// <summary>
        /// Deletes stack instances for the specified accounts, in the specified Amazon Web Services
        /// Regions.
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
        /// Deletes stack instances for the specified accounts, in the specified Amazon Web Services
        /// Regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStackSet


        /// <summary>
        /// Deletes a stack set. Before you can delete a stack set, all its member stack instances
        /// must be deleted. For more information about how to complete this, see <a>DeleteStackInstances</a>.
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
        /// Deletes a stack set. Before you can delete a stack set, all its member stack instances
        /// must be deleted. For more information about how to complete this, see <a>DeleteStackInstances</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeregisterType">REST API Reference for DeregisterType Operation</seealso>
        Task<DeregisterTypeResponse> DeregisterTypeAsync(DeregisterTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Retrieves your account's CloudFormation limits, such as the maximum number of stacks
        /// that you can create in your account. For more information about account limits, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// Quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);



        /// <summary>
        /// Retrieves your account's CloudFormation limits, such as the maximum number of stacks
        /// that you can create in your account. For more information about account limits, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">CloudFormation
        /// Quotas</a> in the <i>CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChangeSet


        /// <summary>
        /// Returns the inputs for the change set and a list of changes that CloudFormation will
        /// make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns the inputs for the change set and a list of changes that CloudFormation will
        /// make if you execute the change set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks-changesets.html">Updating
        /// Stacks Using Change Sets</a> in the <i>CloudFormation User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChangeSetHooks


        /// <summary>
        /// Returns hook-related information for the change set and a list of changes that CloudFormation
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
        /// Returns hook-related information for the change set and a list of changes that CloudFormation
        /// makes when you run the change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSetHooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSetHooks service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSetHooks">REST API Reference for DescribeChangeSetHooks Operation</seealso>
        Task<DescribeChangeSetHooksResponse> DescribeChangeSetHooksAsync(DescribeChangeSetHooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes a generated template. The output includes details about the progress of
        /// the creation of a generated template started by a <c>CreateGeneratedTemplate</c> API
        /// action or the update of a generated template started with an <c>UpdateGeneratedTemplate</c>
        /// API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeGeneratedTemplate">REST API Reference for DescribeGeneratedTemplate Operation</seealso>
        Task<DescribeGeneratedTemplateResponse> DescribeGeneratedTemplateAsync(DescribeGeneratedTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about the account's <c>OrganizationAccess</c> status. This API
        /// can be called either by the management account or the delegated administrator by using
        /// the <c>CallAs</c> parameter. This API can also be called without the <c>CallAs</c>
        /// parameter by the management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationsAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationsAccess service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeOrganizationsAccess">REST API Reference for DescribeOrganizationsAccess Operation</seealso>
        Task<DescribeOrganizationsAccessResponse> DescribeOrganizationsAccessAsync(DescribeOrganizationsAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i> 
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
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribePublisher">REST API Reference for DescribePublisher Operation</seealso>
        Task<DescribePublisherResponse> DescribePublisherAsync(DescribePublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes details of a resource scan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceScan service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ResourceScanNotFoundException">
        /// The resource scan was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeResourceScan">REST API Reference for DescribeResourceScan Operation</seealso>
        Task<DescribeResourceScanResponse> DescribeResourceScanAsync(DescribeResourceScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackDriftDetectionStatus


        /// <summary>
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. A stack is considered to have drifted if one or more of its
        /// resources have drifted. For more information about stack and resource drift, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
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
        /// Returns information about a stack drift detection operation. A stack drift detection
        /// operation detects whether a stack's actual configuration differs, or has <i>drifted</i>,
        /// from its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. A stack is considered to have drifted if one or more of its
        /// resources have drifted. For more information about stack and resource drift, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackDriftDetectionStatus service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        Task<DescribeStackDriftDetectionStatusResponse> DescribeStackDriftDetectionStatusAsync(DescribeStackDriftDetectionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackEvents


        /// <summary>
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns all stack related events for a specified stack in reverse chronological order.
        /// For more information about a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// You can list events for stacks that have failed to create or have been deleted by
        /// specifying the unique stack identifier (stack ID).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackEvents service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackInstance service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a description of the specified resource in the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, DescribeStackResource returns resource information for up to 90
        /// days after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
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
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DetectStackResourceDrift</a> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all supported resources for a given stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        Task<DescribeStackResourceDriftsResponse> DescribeStackResourceDriftsAsync(DescribeStackResourceDriftsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// go to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">CloudFormation
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
        /// go to the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/">CloudFormation
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStacks


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
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
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
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
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created. For more information about
        /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">CloudFormation
        /// stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackSet


        /// <summary>
        /// Returns the description of the specified StackSet.
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
        /// Returns the description of the specified StackSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackSet service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStackSetOperation


        /// <summary>
        /// Returns the description of the specified StackSet operation.
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
        /// Returns the description of the specified StackSet operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStackSetOperation service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeType


        /// <summary>
        /// Returns detailed information about an extension that has been registered.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information about that
        /// specific extension version. Otherwise, it returns information about the default extension
        /// version.
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
        /// Returns detailed information about an extension that has been registered.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>VersionId</c>, <c>DescribeType</c> returns information about that
        /// specific extension version. Otherwise, it returns information about the default extension
        /// version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeType">REST API Reference for DescribeType Operation</seealso>
        Task<DescribeTypeResponse> DescribeTypeAsync(DescribeTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTypeRegistration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeTypeRegistration">REST API Reference for DescribeTypeRegistration Operation</seealso>
        Task<DescribeTypeRegistrationResponse> DescribeTypeRegistrationAsync(DescribeTypeRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackDrift</c> to detect drift on all supported resources for a given
        /// stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
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
        /// Detects whether a stack's actual configuration differs, or has <i>drifted</i>, from
        /// its expected configuration, as defined in the stack template and any values specified
        /// as template parameters. For each resource in the stack that supports drift detection,
        /// CloudFormation compares the actual configuration of the resource with its expected
        /// template configuration. Only resource properties explicitly defined in the stack template
        /// are checked for drift. A stack is considered to have drifted if one or more of its
        /// resources differ from their expected template configurations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackDrift</c> to detect drift on all supported resources for a given
        /// stack, or <a>DetectStackResourceDrift</a> to detect drift on individual resources.
        /// </para>
        ///  
        /// <para>
        /// For a list of stack resources that currently support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        Task<DetectStackDriftResponse> DetectStackDriftAsync(DetectStackDriftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectStackResourceDrift


        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from its expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackResourceDrift</c> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all resources in a given stack that support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that don't currently support drift detection can't be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackResourceDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request);



        /// <summary>
        /// Returns information about whether a resource's actual configuration differs, or has
        /// <i>drifted</i>, from its expected configuration, as defined in the stack template
        /// and any values specified as template parameters. This information includes actual
        /// and expected property values for resources in which CloudFormation detects drift.
        /// Only resource properties explicitly defined in the stack template are checked for
        /// drift. For more information about stack and resource drift, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detecting
        /// Unregulated Configuration Changes to Stacks and Resources</a>.
        /// 
        ///  
        /// <para>
        /// Use <c>DetectStackResourceDrift</c> to detect drift on individual resources, or <a>DetectStackDrift</a>
        /// to detect drift on all resources in a given stack that support drift detection.
        /// </para>
        ///  
        /// <para>
        /// Resources that don't currently support drift detection can't be checked. For a list
        /// of resources that support drift detection, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift-resource-list.html">Resources
        /// that Support Drift Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackResourceDrift service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        Task<DetectStackResourceDriftResponse> DetectStackResourceDriftAsync(DetectStackResourceDriftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectStackSetDrift


        /// <summary>
        /// Detect drift on a stack set. When CloudFormation performs drift detection on a stack
        /// set, it performs drift detection on the stack associated with each stack instance
        /// in the stack set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">How
        /// CloudFormation performs drift detection on a stack set</a>.
        /// 
        ///  
        /// <para>
        ///  <c>DetectStackSetDrift</c> returns the <c>OperationId</c> of the stack set drift
        /// detection operation. Use this operation id with <a>DescribeStackSetOperation</a> to
        /// monitor the progress of the drift detection operation. The drift detection operation
        /// may take some time, depending on the number of stack instances included in the stack
        /// set, in addition to the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a>DescribeStackSet</a> to return detailed information about the stack set, including
        /// detailed information about the last <i>completed</i> drift operation performed on
        /// the stack set. (Information about drift operations that are in progress isn't included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>ListStackInstances</a> to return a list of stack instances belonging to the
        /// stack set, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>DescribeStackInstance</a> to return detailed information about a specific stack
        /// instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about performing a drift detection operation on a stack set,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
        /// unmanaged changes in stack sets</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only run a single drift detection operation on a given stack set at one time.
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection stack set operation, use <a>StopStackSetOperation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift service method.</param>
        /// 
        /// <returns>The response from the DetectStackSetDrift service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        DetectStackSetDriftResponse DetectStackSetDrift(DetectStackSetDriftRequest request);



        /// <summary>
        /// Detect drift on a stack set. When CloudFormation performs drift detection on a stack
        /// set, it performs drift detection on the stack associated with each stack instance
        /// in the stack set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">How
        /// CloudFormation performs drift detection on a stack set</a>.
        /// 
        ///  
        /// <para>
        ///  <c>DetectStackSetDrift</c> returns the <c>OperationId</c> of the stack set drift
        /// detection operation. Use this operation id with <a>DescribeStackSetOperation</a> to
        /// monitor the progress of the drift detection operation. The drift detection operation
        /// may take some time, depending on the number of stack instances included in the stack
        /// set, in addition to the number of resources included in each stack.
        /// </para>
        ///  
        /// <para>
        /// Once the operation has completed, use the following actions to return drift information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <a>DescribeStackSet</a> to return detailed information about the stack set, including
        /// detailed information about the last <i>completed</i> drift operation performed on
        /// the stack set. (Information about drift operations that are in progress isn't included.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>ListStackInstances</a> to return a list of stack instances belonging to the
        /// stack set, including the drift status and last drift time checked of each instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <a>DescribeStackInstance</a> to return detailed information about a specific stack
        /// instance, including its drift status and last drift time checked.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about performing a drift detection operation on a stack set,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
        /// unmanaged changes in stack sets</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only run a single drift detection operation on a given stack set at one time.
        /// </para>
        ///  
        /// <para>
        /// To stop a drift detection stack set operation, use <a>StopStackSetOperation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectStackSetDrift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectStackSetDrift service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.InvalidOperationException">
        /// The specified operation isn't valid.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.OperationInProgressException">
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackSetDrift">REST API Reference for DetectStackSetDrift Operation</seealso>
        Task<DetectStackSetDriftResponse> DetectStackSetDriftAsync(DetectStackSetDriftRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the estimated monthly cost of a template. The return value is an Amazon Web
        /// Services Simple Monthly Calculator URL with a query string that describes the resources
        /// required to run the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EstimateTemplateCost service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a generated template. If the template is in an <c>InProgress</c> or <c>Pending</c>
        /// status then the template returned will be the template when the template was last
        /// in a <c>Complete</c> status. If the template has not yet been in a <c>Complete</c>
        /// status then an empty template will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeneratedTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.GeneratedTemplateNotFoundException">
        /// The generated template was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetGeneratedTemplate">REST API Reference for GetGeneratedTemplate Operation</seealso>
        Task<GetGeneratedTemplateResponse> GetGeneratedTemplateAsync(GetGeneratedTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the stack policy for a specified stack. If a stack doesn't have a policy,
        /// a null value is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.ChangeSetNotFoundException">
        /// The specified change set name or ID doesn't exit. To view valid change sets for a
        /// stack, use the <c>ListChangeSets</c> operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplateSummary


        /// <summary>
        /// Returns information about a new or existing template. The <c>GetTemplateSummary</c>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetTemplateSummary</c> action when you submit a template, or you
        /// can get template information for a stack set, or a running or deleted stack.
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
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request);



        /// <summary>
        /// Returns information about a new or existing template. The <c>GetTemplateSummary</c>
        /// action is useful for viewing parameter information, such as default parameter values
        /// and parameter types, before you create or update a stack or stack set.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetTemplateSummary</c> action when you submit a template, or you
        /// can get template information for a stack set, or a running or deleted stack.
        /// </para>
        ///  
        /// <para>
        /// For deleted stacks, <c>GetTemplateSummary</c> returns the template information for
        /// up to 90 days after the stack has been deleted. If the template doesn't exist, a <c>ValidationError</c>
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateSummary service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportStacksToStackSet


        /// <summary>
        /// Import existing stacks into a new stack sets. Use the stack import operation to import
        /// up to 10 stacks into a new stack set in the same account as the source stack or in
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
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackNotFoundException">
        /// The specified stack ARN doesn't exist or stack doesn't exist corresponding to the
        /// ARN in input.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        ImportStacksToStackSetResponse ImportStacksToStackSet(ImportStacksToStackSetRequest request);



        /// <summary>
        /// Import existing stacks into a new stack sets. Use the stack import operation to import
        /// up to 10 stacks into a new stack set in the same account as the source stack or in
        /// a different administrator account and Region, by specifying the stack ID of the stack
        /// you intend to import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportStacksToStackSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Another operation is currently in progress for this stack set. Only one operation
        /// can be performed for a stack set at a given time.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackNotFoundException">
        /// The specified stack ARN doesn't exist or stack doesn't exist corresponding to the
        /// ARN in input.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StaleRequestException">
        /// Another operation has been performed on this stack set since the specified operation
        /// was performed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ImportStacksToStackSet">REST API Reference for ImportStacksToStackSet Operation</seealso>
        Task<ImportStacksToStackSetResponse> ImportStacksToStackSetAsync(ImportStacksToStackSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the ID and status of each active change set for a stack. For example, CloudFormation
        /// lists change sets that are in the <c>CREATE_IN_PROGRESS</c> or <c>CREATE_PENDING</c>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// Fn::ImportValue</a> function.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// CloudFormation export stack output values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);



        /// <summary>
        /// Lists all exported output values in the account and Region in which you call this
        /// action. Use this action to see the exported output values that you can import into
        /// other stacks. To import values, use the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">
        /// Fn::ImportValue</a> function.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">
        /// CloudFormation export stack output values</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists your generated templates in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeneratedTemplates service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListGeneratedTemplates">REST API Reference for ListGeneratedTemplates Operation</seealso>
        Task<ListGeneratedTemplatesResponse> ListGeneratedTemplatesAsync(ListGeneratedTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>.
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">Fn::ImportValue</a>
        /// function.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);



        /// <summary>
        /// Lists all stacks that are importing an exported output value. To modify or remove
        /// an exported output value, first use this action to see which stacks are using it.
        /// To see the exported output values in your account, see <a>ListExports</a>.
        /// 
        ///  
        /// <para>
        /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-importvalue.html">Fn::ImportValue</a>
        /// function.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the related resources for a list of resources from a resource scan. The response
        /// indicates whether each returned resource is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanRelatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListResourceScanRelatedResourcesResponse> ListResourceScanRelatedResourcesAsync(ListResourceScanRelatedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the resources from a resource scan. The results can be filtered by resource
        /// identifier, resource type prefix, tag key, and tag value. Only resources that match
        /// all specified filters are returned. The response indicates whether each returned resource
        /// is already managed by CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScanResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListResourceScanResourcesResponse> ListResourceScanResourcesAsync(ListResourceScanResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// List the resource scans from newest to oldest. By default it will return up to 10
        /// resource scans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceScans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceScans service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListResourceScans">REST API Reference for ListResourceScans Operation</seealso>
        Task<ListResourceScansResponse> ListResourceScansAsync(ListResourceScansRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        ListStackInstanceResourceDriftsResponse ListStackInstanceResourceDrifts(ListStackInstanceResourceDriftsRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstanceResourceDrifts service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackInstanceNotFoundException">
        /// The specified stack instance doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstanceResourceDrifts">REST API Reference for ListStackInstanceResourceDrifts Operation</seealso>
        Task<ListStackInstanceResourceDriftsResponse> ListStackInstanceResourceDriftsAsync(ListStackInstanceResourceDriftsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStackInstances


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// Amazon Web Services account name or Region, or that have a specific status.
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
        /// Returns summary information about stack instances that are associated with the specified
        /// stack set. You can filter for stack instances that are associated with a specific
        /// Amazon Web Services account name or Region, or that have a specific status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackInstances service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns descriptions of all resources of the specified stack.
        /// 
        ///  
        /// <para>
        /// For deleted stacks, ListStackResources returns resource information for up to 90 days
        /// after the stack has been deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackResources service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        Task<ListStacksResponse> ListStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStackSetAutoDeploymentTargets


        /// <summary>
        /// Returns summary information about deployment targets for a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetAutoDeploymentTargets service method.</param>
        /// 
        /// <returns>The response from the ListStackSetAutoDeploymentTargets service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        ListStackSetAutoDeploymentTargetsResponse ListStackSetAutoDeploymentTargets(ListStackSetAutoDeploymentTargetsRequest request);



        /// <summary>
        /// Returns summary information about deployment targets for a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetAutoDeploymentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetAutoDeploymentTargets service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetAutoDeploymentTargets">REST API Reference for ListStackSetAutoDeploymentTargets Operation</seealso>
        Task<ListStackSetAutoDeploymentTargetsResponse> ListStackSetAutoDeploymentTargetsAsync(ListStackSetAutoDeploymentTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summary information about the results of a stack set operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetOperationResults service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.OperationNotFoundException">
        /// The specified ID refers to an operation that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summary information about operations performed on a stack set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSetOperations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.StackSetNotFoundException">
        /// The specified stack set doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStackSets


        /// <summary>
        /// Returns summary information about stack sets that are associated with the user.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// [Self-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c> while
        /// signed in to your Amazon Web Services account, <c>ListStackSets</c> returns all self-managed
        /// stack sets in your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c>
        /// while signed in to the organization's management account, <c>ListStackSets</c> returns
        /// all stack sets in the management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>DELEGATED_ADMIN</c>
        /// while signed in to your member account, <c>ListStackSets</c> returns all stack sets
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
        /// Returns summary information about stack sets that are associated with the user.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// [Self-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c> while
        /// signed in to your Amazon Web Services account, <c>ListStackSets</c> returns all self-managed
        /// stack sets in your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>SELF</c>
        /// while signed in to the organization's management account, <c>ListStackSets</c> returns
        /// all stack sets in the management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [Service-managed permissions] If you set the <c>CallAs</c> parameter to <c>DELEGATED_ADMIN</c>
        /// while signed in to your member account, <c>ListStackSets</c> returns all stack sets
        /// with service-managed permissions in the management account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStackSets service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        Task<ListStackSetsResponse> ListStackSetsAsync(ListStackSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns a list of registration tokens for the specified extension(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypeRegistrations service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeRegistrations">REST API Reference for ListTypeRegistrations Operation</seealso>
        Task<ListTypeRegistrationsResponse> ListTypeRegistrationsAsync(ListTypeRegistrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTypes


        /// <summary>
        /// Returns summary information about extension that have been registered with CloudFormation.
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
        /// Returns summary information about extension that have been registered with CloudFormation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypes">REST API Reference for ListTypes Operation</seealso>
        Task<ListTypesResponse> ListTypesAsync(ListTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summary information about the versions of an extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypeVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypeVersions service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListTypeVersions">REST API Reference for ListTypeVersions Operation</seealso>
        Task<ListTypeVersionsResponse> ListTypeVersionsAsync(ListTypeVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PublishType


        /// <summary>
        /// Publishes the specified extension to the CloudFormation registry as a public extension
        /// in this Region. Public extensions are available for use by all CloudFormation users.
        /// For more information about publishing extensions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
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
        /// Publishes the specified extension to the CloudFormation registry as a public extension
        /// in this Region. Public extensions are available for use by all CloudFormation users.
        /// For more information about publishing extensions, see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To publish an extension, you must be registered as a publisher with CloudFormation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/PublishType">REST API Reference for PublishType Operation</seealso>
        Task<PublishTypeResponse> PublishTypeAsync(PublishTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Reports progress of a resource handler to CloudFormation.
        /// 
        ///  
        /// <para>
        /// Reserved for use by the <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/what-is-cloudformation-cli.html">CloudFormation
        /// CLI</a>. Don't use this API in your code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordHandlerProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RecordHandlerProgressResponse> RecordHandlerProgressAsync(RecordHandlerProgressRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Registering
        /// your account to publish CloudFormation extensions</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
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
        /// Registers your account as a publisher of public extensions in the CloudFormation registry.
        /// Public extensions are available for use by all CloudFormation users. This publisher
        /// ID applies to your account in all Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// For information about requirements for registering as a public extension publisher,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html#publish-extension-prereqs">Registering
        /// your account to publish CloudFormation extensions</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPublisher service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPublisher service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterPublisher">REST API Reference for RegisterPublisher Operation</seealso>
        Task<RegisterPublisherResponse> RegisterPublisherAsync(RegisterPublisherRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Resource Providers</a> in the <i>CloudFormation CLI User Guide</i>.
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
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
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
        /// Resource Providers</a> in the <i>CloudFormation CLI User Guide</i>.
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
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RegisterType">REST API Reference for RegisterType Operation</seealso>
        Task<RegisterTypeResponse> RegisterTypeAsync(RegisterTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackStack service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.TokenAlreadyExistsException">
        /// A client request token already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/RollbackStack">REST API Reference for RollbackStack Operation</seealso>
        Task<RollbackStackResponse> RollbackStackAsync(RollbackStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Sets a stack policy for a specified stack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetStackPolicy service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetTypeConfiguration


        /// <summary>
        /// Specifies the configuration data for a registered CloudFormation extension, in the
        /// given account and Region.
        /// 
        ///  
        /// <para>
        /// To view the current configuration data for an extension, refer to the <c>ConfigurationSchema</c>
        /// element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It's strongly recommended that you use dynamic references to restrict sensitive configuration
        /// definitions, such as third-party credentials. For more details on dynamic references,
        /// see <a href="https://docs.aws.amazon.com/">Using dynamic references to specify template
        /// values</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </important>
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
        /// Specifies the configuration data for a registered CloudFormation extension, in the
        /// given account and Region.
        /// 
        ///  
        /// <para>
        /// To view the current configuration data for an extension, refer to the <c>ConfigurationSchema</c>
        /// element of <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DescribeType.html">DescribeType</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-private.html#registry-set-configuration">Configuring
        /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It's strongly recommended that you use dynamic references to restrict sensitive configuration
        /// definitions, such as third-party credentials. For more details on dynamic references,
        /// see <a href="https://docs.aws.amazon.com/">Using dynamic references to specify template
        /// values</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTypeConfiguration service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeConfiguration">REST API Reference for SetTypeConfiguration Operation</seealso>
        Task<SetTypeConfigurationResponse> SetTypeConfigurationAsync(SetTypeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Specify the default version of an extension. The default version of an extension will
        /// be used in CloudFormation operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTypeDefaultVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTypeDefaultVersion service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetTypeDefaultVersion">REST API Reference for SetTypeDefaultVersion Operation</seealso>
        Task<SetTypeDefaultVersionResponse> SetTypeDefaultVersionAsync(SetTypeDefaultVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Sends a signal to the specified resource with a success or failure status. You can
        /// use the <c>SignalResource</c> operation in conjunction with a creation policy or update
        /// policy. CloudFormation doesn't proceed with a stack creation or update until resources
        /// receive the required number of signals or the timeout period is exceeded. The <c>SignalResource</c>
        /// operation is useful in cases where you want to send signals from anywhere other than
        /// an Amazon EC2 instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SignalResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SignalResource service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a scan of the resources in this account in this Region. You can the status
        /// of a scan using the <c>ListResourceScans</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceScan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartResourceScanResponse> StartResourceScanAsync(StartResourceScanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopStackSetOperation


        /// <summary>
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// StackSets will cancel all the unstarted stack instance deployments and wait for those
        /// are in-progress to complete.
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
        /// Stops an in-progress operation on a stack set and its associated stack instances.
        /// StackSets will cancel all the unstarted stack instance deployments and wait for those
        /// are in-progress to complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// your public extension prior to publishing</a> in the <i>CloudFormation CLI User Guide</i>.
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
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
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
        /// your public extension prior to publishing</a> in the <i>CloudFormation CLI User Guide</i>.
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
        /// extensions to make them available for public use</a> in the <i>CloudFormation CLI
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestType service method, as returned by CloudFormation.</returns>
        /// <exception cref="Amazon.CloudFormation.Model.CFNRegistryException">
        /// An error occurred during a CloudFormation registry operation.
        /// </exception>
        /// <exception cref="Amazon.CloudFormation.Model.TypeNotFoundException">
        /// The specified extension doesn't exist in the CloudFormation registry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/TestType">REST API Reference for TestType Operation</seealso>
        Task<TestTypeResponse> TestTypeAsync(TestTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a generated template. This can be used to change the name, add and remove
        /// resources, refresh resources, and change the <c>DeletionPolicy</c> and <c>UpdateReplacePolicy</c>
        /// settings. You can check the status of the update to the generated template using the
        /// <c>DescribeGeneratedTemplate</c> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGeneratedTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateGeneratedTemplateResponse> UpdateGeneratedTemplateAsync(UpdateGeneratedTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
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
        /// For more information about creating an update template, updating a stack, and monitoring
        /// the progress of the update, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html">Updating
        /// a Stack</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// During stack set updates, any parameters overridden for a stack instance aren't updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the stack set;
        /// to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the stack set you must first use <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the stack set. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <c>UpdateStackInstances</c>.
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
        /// During stack set updates, any parameters overridden for a stack instance aren't updated,
        /// but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only update the parameter <i>values</i> that are specified in the stack set;
        /// to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template. If you add a parameter to a template, before you
        /// can override the parameter value specified in the stack set you must first use <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update all stack instances with the updated template and parameter value specified
        /// in the stack set. Once a stack instance has been updated with the new parameter, you
        /// can then override the parameter value using <c>UpdateStackInstances</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStackSet


        /// <summary>
        /// Updates the stack set, and associated stack instances in the specified accounts and
        /// Amazon Web Services Regions.
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
        /// Updates the stack set, and associated stack instances in the specified accounts and
        /// Amazon Web Services Regions.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTerminationProtection


        /// <summary>
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>CloudFormation User Guide</i>.
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
        /// Updates termination protection for the specified stack. If a user attempts to delete
        /// a stack with termination protection enabled, the operation fails and the stack remains
        /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protecting
        /// a Stack From Being Deleted</a> in the <i>CloudFormation User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
        /// stacks</a>, termination protection is set on the root stack and can't be changed directly
        /// on the nested stack.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTerminationProtection service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        Task<UpdateTerminationProtectionResponse> UpdateTerminationProtectionAsync(UpdateTerminationProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        Task<ValidateTemplateResponse> ValidateTemplateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Validates a specified template. CloudFormation first checks if the template is valid
        /// JSON. If it isn't, CloudFormation checks if the template is valid YAML. If both these
        /// checks fail, CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
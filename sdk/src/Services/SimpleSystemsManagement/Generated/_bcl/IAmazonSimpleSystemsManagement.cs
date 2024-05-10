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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleSystemsManagement.Model;

#pragma warning disable CS1570
namespace Amazon.SimpleSystemsManagement
{
    /// <summary>
    /// <para>Interface for accessing SimpleSystemsManagement</para>
    ///
    /// Amazon Web Services Systems Manager is the operations hub for your Amazon Web Services
    /// applications and resources and a secure end-to-end management solution for hybrid
    /// cloud environments that enables safe and secure operations at scale.
    /// 
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/">Amazon
    /// Web Services Systems Manager User Guide</a>. To get started, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Setting
    /// up Amazon Web Services Systems Manager</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For information about each of the capabilities that comprise Systems Manager, see
    /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/what-is-systems-manager.html#systems-manager-capabilities">Systems
    /// Manager capabilities</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For details about predefined runbooks for Automation, a capability of Amazon Web Services
    /// Systems Manager, see the <i> <a href="https://docs.aws.amazon.com/systems-manager-automation-runbooks/latest/userguide/automation-runbook-reference.html">Systems
    /// Manager Automation runbook reference</a> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about AppConfig, a capability of Systems Manager, see the <i> <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/">AppConfig
    /// User Guide</a> </i> and the <i> <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/">AppConfig
    /// API Reference</a> </i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For information about Incident Manager, a capability of Systems Manager, see the <i>
    /// <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/">Systems Manager
    /// Incident Manager User Guide</a> </i> and the <i> <a href="https://docs.aws.amazon.com/incident-manager/latest/APIReference/">Systems
    /// Manager Incident Manager API Reference</a> </i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSimpleSystemsManagement : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleSystemsManagementPaginatorFactory Paginators { get; }

        
        #region  AddTagsToResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource. <i>Tags</i> are metadata
        /// that you can assign to your automations, documents, managed nodes, maintenance windows,
        /// Parameter Store parameters, and patch baselines. Tags enable you to categorize your
        /// resources in different ways, for example, by purpose, owner, or environment. Each
        /// tag consists of a key and an optional value, both of which you define. For example,
        /// you could define a set of tags for your account's managed nodes that helps you track
        /// each node's owner and stack level. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=DbAdmin</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=SysAdmin</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=Dev</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Pre-Production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Test</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Most resources can have a maximum of 50 tags. Automations can have a maximum of 5
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you devise a set of tag keys that meets your needs for each resource
        /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
        /// You can search and filter the resources based on the tags you add. Tags don't have
        /// any semantic meaning to and are interpreted strictly as a string of characters.
        /// </para>
        ///  
        /// <para>
        /// For more information about using tags with Amazon Elastic Compute Cloud (Amazon EC2)
        /// instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
        /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyTagsErrorException">
        /// The <c>Targets</c> parameter includes too many tags. Remove one or more tags and try
        /// the command again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);



        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource. <i>Tags</i> are metadata
        /// that you can assign to your automations, documents, managed nodes, maintenance windows,
        /// Parameter Store parameters, and patch baselines. Tags enable you to categorize your
        /// resources in different ways, for example, by purpose, owner, or environment. Each
        /// tag consists of a key and an optional value, both of which you define. For example,
        /// you could define a set of tags for your account's managed nodes that helps you track
        /// each node's owner and stack level. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=DbAdmin</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=SysAdmin</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Owner,Value=Dev</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Pre-Production</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Stack,Value=Test</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Most resources can have a maximum of 50 tags. Automations can have a maximum of 5
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you devise a set of tag keys that meets your needs for each resource
        /// type. Using a consistent set of tag keys makes it easier for you to manage your resources.
        /// You can search and filter the resources based on the tags you add. Tags don't have
        /// any semantic meaning to and are interpreted strictly as a string of characters.
        /// </para>
        ///  
        /// <para>
        /// For more information about using tags with Amazon Elastic Compute Cloud (Amazon EC2)
        /// instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tag
        /// your Amazon EC2 resources</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyTagsErrorException">
        /// The <c>Targets</c> parameter includes too many tags. Remove one or more tags and try
        /// the command again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateOpsItemRelatedItem


        /// <summary>
        /// Associates a related item to a Systems Manager OpsCenter OpsItem. For example, you
        /// can associate an Incident Manager incident or analysis with an OpsItem. Incident Manager
        /// and OpsCenter are capabilities of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpsItemRelatedItem service method.</param>
        /// 
        /// <returns>The response from the AssociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAlreadyExistsException">
        /// The Amazon Resource Name (ARN) is already associated with the OpsItem.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AssociateOpsItemRelatedItem">REST API Reference for AssociateOpsItemRelatedItem Operation</seealso>
        AssociateOpsItemRelatedItemResponse AssociateOpsItemRelatedItem(AssociateOpsItemRelatedItemRequest request);



        /// <summary>
        /// Associates a related item to a Systems Manager OpsCenter OpsItem. For example, you
        /// can associate an Incident Manager incident or analysis with an OpsItem. Incident Manager
        /// and OpsCenter are capabilities of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpsItemRelatedItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAlreadyExistsException">
        /// The Amazon Resource Name (ARN) is already associated with the OpsItem.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/AssociateOpsItemRelatedItem">REST API Reference for AssociateOpsItemRelatedItem Operation</seealso>
        Task<AssociateOpsItemRelatedItemResponse> AssociateOpsItemRelatedItemAsync(AssociateOpsItemRelatedItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelCommand


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        CancelCommandResponse CancelCommand(string commandId);

        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of managed node IDs on which you want to cancel the command. If not provided, the command is canceled on every node on which it was requested.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        CancelCommandResponse CancelCommand(string commandId, List<string> instanceIds);

        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand service method.</param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        CancelCommandResponse CancelCommand(CancelCommandRequest request);


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        Task<CancelCommandResponse> CancelCommandAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of managed node IDs on which you want to cancel the command. If not provided, the command is canceled on every node on which it was requested.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        Task<CancelCommandResponse> CancelCommandAsync(string commandId, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Attempts to cancel the command specified by the Command ID. There is no guarantee
        /// that the command will be terminated and the underlying process stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelCommand">REST API Reference for CancelCommand Operation</seealso>
        Task<CancelCommandResponse> CancelCommandAsync(CancelCommandRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMaintenanceWindowExecution


        /// <summary>
        /// Stops a maintenance window execution that is already in progress and cancels any tasks
        /// in the window that haven't already starting running. Tasks already in progress will
        /// continue to completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution service method.</param>
        /// 
        /// <returns>The response from the CancelMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        CancelMaintenanceWindowExecutionResponse CancelMaintenanceWindowExecution(CancelMaintenanceWindowExecutionRequest request);



        /// <summary>
        /// Stops a maintenance window execution that is already in progress and cancels any tasks
        /// in the window that haven't already starting running. Tasks already in progress will
        /// continue to completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMaintenanceWindowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CancelMaintenanceWindowExecution">REST API Reference for CancelMaintenanceWindowExecution Operation</seealso>
        Task<CancelMaintenanceWindowExecutionResponse> CancelMaintenanceWindowExecutionAsync(CancelMaintenanceWindowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateActivation


        /// <summary>
        /// Generates an activation code and activation ID you can use to register your on-premises
        /// servers, edge devices, or virtual machine (VM) with Amazon Web Services Systems Manager.
        /// Registering these machines with Systems Manager makes it possible to manage them using
        /// Systems Manager capabilities. You use the activation code and ID when installing SSM
        /// Agent on machines in your hybrid environment. For more information about requirements
        /// for managing on-premises machines using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
        /// up Amazon Web Services Systems Manager for hybrid and multicloud environments</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Elastic Compute Cloud (Amazon EC2) instances, edge devices, and on-premises
        /// servers and VMs that are configured for Systems Manager are all called <i>managed
        /// nodes</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation service method.</param>
        /// 
        /// <returns>The response from the CreateActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        CreateActivationResponse CreateActivation(CreateActivationRequest request);



        /// <summary>
        /// Generates an activation code and activation ID you can use to register your on-premises
        /// servers, edge devices, or virtual machine (VM) with Amazon Web Services Systems Manager.
        /// Registering these machines with Systems Manager makes it possible to manage them using
        /// Systems Manager capabilities. You use the activation code and ID when installing SSM
        /// Agent on machines in your hybrid environment. For more information about requirements
        /// for managing on-premises machines using Systems Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
        /// up Amazon Web Services Systems Manager for hybrid and multicloud environments</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Elastic Compute Cloud (Amazon EC2) instances, edge devices, and on-premises
        /// servers and VMs that are configured for Systems Manager are all called <i>managed
        /// nodes</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateActivation">REST API Reference for CreateActivation Operation</seealso>
        Task<CreateActivationResponse> CreateActivationAsync(CreateActivationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAssociation


        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association, use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>, <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you must use the <c>Targets</c> parameter. </note></param>
        /// <param name="name">The name of the SSM Command document or Automation runbook that contains the configuration information for the managed node. You can specify Amazon Web Services-predefined documents, documents you created, or a document that is shared with you from another Amazon Web Services account. For Systems Manager documents (SSM documents) that are shared with you from other Amazon Web Services accounts, you must specify the complete SSM document ARN, in the following format:  <c>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </c>  For example:  <c>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</c>  For Amazon Web Services-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <c>AWS-ApplyPatchBaseline</c> or <c>My-Document</c>.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        CreateAssociationResponse CreateAssociation(string instanceId, string name);

        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        CreateAssociationResponse CreateAssociation(CreateAssociationRequest request);


        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association, use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>, <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you must use the <c>Targets</c> parameter. </note></param>
        /// <param name="name">The name of the SSM Command document or Automation runbook that contains the configuration information for the managed node. You can specify Amazon Web Services-predefined documents, documents you created, or a document that is shared with you from another Amazon Web Services account. For Systems Manager documents (SSM documents) that are shared with you from other Amazon Web Services accounts, you must specify the complete SSM document ARN, in the following format:  <c>arn:<i>partition</i>:ssm:<i>region</i>:<i>account-id</i>:document/<i>document-name</i> </c>  For example:  <c>arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document</c>  For Amazon Web Services-predefined documents and SSM documents you created in your account, you only need to specify the document name. For example, <c>AWS-ApplyPatchBaseline</c> or <c>My-Document</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        Task<CreateAssociationResponse> CreateAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// A State Manager association defines the state that you want to maintain on your managed
        /// nodes. For example, an association can specify that anti-virus software must be installed
        /// and running on your managed nodes, or that certain ports must be closed. For static
        /// targets, the association specifies a schedule for when the configuration is reapplied.
        /// For dynamic targets, such as an Amazon Web Services resource group or an Amazon Web
        /// Services autoscaling group, State Manager, a capability of Amazon Web Services Systems
        /// Manager applies the configuration when new managed nodes are added to the group. The
        /// association also specifies actions to take when applying the configuration. For example,
        /// an association for anti-virus software might run once a day. If the software isn't
        /// installed, then State Manager installs it. If the software is installed, but the service
        /// isn't running, then the association might instruct State Manager to start the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationAlreadyExistsException">
        /// The specified association already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTagException">
        /// The specified tag key or value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociation">REST API Reference for CreateAssociation Operation</seealso>
        Task<CreateAssociationResponse> CreateAssociationAsync(CreateAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAssociationBatch


        /// <summary>
        /// Associates the specified Amazon Web Services Systems Manager document (SSM document)
        /// with the specified managed nodes or targets.
        /// 
        ///  
        /// <para>
        /// When you associate a document with one or more managed nodes using IDs or tags, Amazon
        /// Web Services Systems Manager Agent (SSM Agent) running on the managed node processes
        /// the document and configures the node as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with a managed node that already has an associated document,
        /// the system returns the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        CreateAssociationBatchResponse CreateAssociationBatch(CreateAssociationBatchRequest request);



        /// <summary>
        /// Associates the specified Amazon Web Services Systems Manager document (SSM document)
        /// with the specified managed nodes or targets.
        /// 
        ///  
        /// <para>
        /// When you associate a document with one or more managed nodes using IDs or tags, Amazon
        /// Web Services Systems Manager Agent (SSM Agent) running on the managed node processes
        /// the document and configures the node as specified.
        /// </para>
        ///  
        /// <para>
        /// If you associate a document with a managed node that already has an associated document,
        /// the system returns the AssociationAlreadyExists exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssociationBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssociationBatch service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationLimitExceededException">
        /// You can have at most 2,000 active associations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateAssociationBatch">REST API Reference for CreateAssociationBatch Operation</seealso>
        Task<CreateAssociationBatchResponse> CreateAssociationBatchAsync(CreateAssociationBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDocument


        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command. For examples, see the following topics in the <i>Amazon Web Services Systems Manager User Guide</i>. <ul> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-console">Create an SSM document (console)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-cli">Create an SSM document (command line)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-api">Create an SSM document (API)</a>  </li> </ul></param>
        /// <param name="name">A name for the SSM document. <important> You can't use the following strings as document name prefixes. These are reserved by Amazon Web Services for use as document name prefixes: <ul> <li>  <c>aws</c>  </li> <li>  <c>amazon</c>  </li> <li>  <c>amzn</c>  </li> <li>  <c>AWSEC2</c>  </li> <li>  <c>AWSConfigRemediation</c>  </li> <li>  <c>AWSSupport</c>  </li> </ul> </important></param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        CreateDocumentResponse CreateDocument(string content, string name);

        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        CreateDocumentResponse CreateDocument(CreateDocumentRequest request);


        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="content">The content for the new SSM document in JSON or YAML format. The content of the document must not exceed 64KB. This quota also includes the content specified for input parameters at runtime. We recommend storing the contents for your new document in an external JSON or YAML file and referencing the file in a command. For examples, see the following topics in the <i>Amazon Web Services Systems Manager User Guide</i>. <ul> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-console">Create an SSM document (console)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-cli">Create an SSM document (command line)</a>  </li> <li>  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/documents-using.html#create-ssm-document-api">Create an SSM document (API)</a>  </li> </ul></param>
        /// <param name="name">A name for the SSM document. <important> You can't use the following strings as document name prefixes. These are reserved by Amazon Web Services for use as document name prefixes: <ul> <li>  <c>aws</c>  </li> <li>  <c>amazon</c>  </li> <li>  <c>amzn</c>  </li> <li>  <c>AWSEC2</c>  </li> <li>  <c>AWSConfigRemediation</c>  </li> <li>  <c>AWSSupport</c>  </li> </ul> </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        Task<CreateDocumentResponse> CreateDocumentAsync(string content, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Creates a Amazon Web Services Systems Manager (SSM document). An SSM document defines
        /// the actions that Systems Manager performs on your managed nodes. For more information
        /// about SSM documents, including information about supported schemas, features, and
        /// syntax, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-ssm-docs.html">Amazon
        /// Web Services Systems Manager Documents</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentAlreadyExistsException">
        /// The specified document already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateDocument">REST API Reference for CreateDocument Operation</seealso>
        Task<CreateDocumentResponse> CreateDocumentAsync(CreateDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMaintenanceWindow


        /// <summary>
        /// Creates a new maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <c>Duration</c> determines the specific end time for the
        /// maintenance window based on the time it begins. No maintenance window tasks are permitted
        /// to start after the resulting endtime minus the number of hours you specify for <c>Cutoff</c>.
        /// For example, if the maintenance window starts at 3 PM, the duration is three hours,
        /// and the value you specify for <c>Cutoff</c> is one hour, no maintenance window tasks
        /// can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the CreateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        CreateMaintenanceWindowResponse CreateMaintenanceWindow(CreateMaintenanceWindowRequest request);



        /// <summary>
        /// Creates a new maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <c>Duration</c> determines the specific end time for the
        /// maintenance window based on the time it begins. No maintenance window tasks are permitted
        /// to start after the resulting endtime minus the number of hours you specify for <c>Cutoff</c>.
        /// For example, if the maintenance window starts at 3 PM, the duration is three hours,
        /// and the value you specify for <c>Cutoff</c> is one hour, no maintenance window tasks
        /// can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateMaintenanceWindow">REST API Reference for CreateMaintenanceWindow Operation</seealso>
        Task<CreateMaintenanceWindowResponse> CreateMaintenanceWindowAsync(CreateMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOpsItem


        /// <summary>
        /// Creates a new OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to create a new OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsItem service method.</param>
        /// 
        /// <returns>The response from the CreateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsItem">REST API Reference for CreateOpsItem Operation</seealso>
        CreateOpsItemResponse CreateOpsItem(CreateOpsItemRequest request);



        /// <summary>
        /// Creates a new OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to create a new OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsItem">REST API Reference for CreateOpsItem Operation</seealso>
        Task<CreateOpsItemResponse> CreateOpsItemAsync(CreateOpsItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOpsMetadata


        /// <summary>
        /// If you create a new application in Application Manager, Amazon Web Services Systems
        /// Manager calls this API operation to specify information about the new application,
        /// including the application type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the CreateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataAlreadyExistsException">
        /// An OpsMetadata object already exists for the selected resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataLimitExceededException">
        /// Your account reached the maximum number of OpsMetadata objects allowed by Application
        /// Manager. The maximum is 200 OpsMetadata objects. Delete one or more OpsMetadata object
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsMetadata">REST API Reference for CreateOpsMetadata Operation</seealso>
        CreateOpsMetadataResponse CreateOpsMetadata(CreateOpsMetadataRequest request);



        /// <summary>
        /// If you create a new application in Application Manager, Amazon Web Services Systems
        /// Manager calls this API operation to specify information about the new application,
        /// including the application type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataAlreadyExistsException">
        /// An OpsMetadata object already exists for the selected resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataLimitExceededException">
        /// Your account reached the maximum number of OpsMetadata objects allowed by Application
        /// Manager. The maximum is 200 OpsMetadata objects. Delete one or more OpsMetadata object
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateOpsMetadata">REST API Reference for CreateOpsMetadata Operation</seealso>
        Task<CreateOpsMetadataResponse> CreateOpsMetadataAsync(CreateOpsMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePatchBaseline


        /// <summary>
        /// Creates a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
        /// operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the CreatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        CreatePatchBaselineResponse CreatePatchBaseline(CreatePatchBaselineRequest request);



        /// <summary>
        /// Creates a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
        /// operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreatePatchBaseline">REST API Reference for CreatePatchBaseline Operation</seealso>
        Task<CreatePatchBaselineResponse> CreatePatchBaselineAsync(CreatePatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResourceDataSync


        /// <summary>
        /// A resource data sync helps you view data from multiple sources in a single location.
        /// Amazon Web Services Systems Manager offers two types of resource data sync: <c>SyncToDestination</c>
        /// and <c>SyncFromSource</c>.
        /// 
        ///  
        /// <para>
        /// You can configure Systems Manager Inventory to use the <c>SyncToDestination</c> type
        /// to synchronize Inventory data from multiple Amazon Web Services Regions to a single
        /// Amazon Simple Storage Service (Amazon S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
        /// resource data sync for Inventory</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can configure Systems Manager Explorer to use the <c>SyncFromSource</c> type to
        /// synchronize operational work items (OpsItems) and operational data (OpsData) from
        /// multiple Amazon Web Services Regions to a single Amazon S3 bucket. This type can synchronize
        /// OpsItems and OpsData from multiple Amazon Web Services accounts and Amazon Web Services
        /// Regions or <c>EntireOrganization</c> by using Organizations. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
        /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A resource data sync is an asynchronous operation that returns immediately. After
        /// a successful initial sync is completed, the system continuously syncs data. To check
        /// the status of a sync, use the <a>ListResourceDataSync</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, data isn't encrypted in Amazon S3. We strongly recommend that you enable
        /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
        /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync service method.</param>
        /// 
        /// <returns>The response from the CreateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncAlreadyExistsException">
        /// A sync configuration with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncCountExceededException">
        /// You have exceeded the allowed maximum sync configurations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateResourceDataSync">REST API Reference for CreateResourceDataSync Operation</seealso>
        CreateResourceDataSyncResponse CreateResourceDataSync(CreateResourceDataSyncRequest request);



        /// <summary>
        /// A resource data sync helps you view data from multiple sources in a single location.
        /// Amazon Web Services Systems Manager offers two types of resource data sync: <c>SyncToDestination</c>
        /// and <c>SyncFromSource</c>.
        /// 
        ///  
        /// <para>
        /// You can configure Systems Manager Inventory to use the <c>SyncToDestination</c> type
        /// to synchronize Inventory data from multiple Amazon Web Services Regions to a single
        /// Amazon Simple Storage Service (Amazon S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
        /// resource data sync for Inventory</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can configure Systems Manager Explorer to use the <c>SyncFromSource</c> type to
        /// synchronize operational work items (OpsItems) and operational data (OpsData) from
        /// multiple Amazon Web Services Regions to a single Amazon S3 bucket. This type can synchronize
        /// OpsItems and OpsData from multiple Amazon Web Services accounts and Amazon Web Services
        /// Regions or <c>EntireOrganization</c> by using Organizations. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
        /// up Systems Manager Explorer to display data from multiple accounts and Regions</a>
        /// in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A resource data sync is an asynchronous operation that returns immediately. After
        /// a successful initial sync is completed, the system continuously syncs data. To check
        /// the status of a sync, use the <a>ListResourceDataSync</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, data isn't encrypted in Amazon S3. We strongly recommend that you enable
        /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
        /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncAlreadyExistsException">
        /// A sync configuration with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncCountExceededException">
        /// You have exceeded the allowed maximum sync configurations.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/CreateResourceDataSync">REST API Reference for CreateResourceDataSync Operation</seealso>
        Task<CreateResourceDataSyncResponse> CreateResourceDataSyncAsync(CreateResourceDataSyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteActivation


        /// <summary>
        /// Deletes an activation. You aren't required to delete an activation. If you delete
        /// an activation, you can no longer use it to register additional managed nodes. Deleting
        /// an activation doesn't de-register managed nodes. You must manually de-register managed
        /// nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation service method.</param>
        /// 
        /// <returns>The response from the DeleteActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationException">
        /// The activation isn't valid. The activation might have been deleted, or the ActivationId
        /// and the ActivationCode don't match.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID isn't valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        DeleteActivationResponse DeleteActivation(DeleteActivationRequest request);



        /// <summary>
        /// Deletes an activation. You aren't required to delete an activation. If you delete
        /// an activation, you can no longer use it to register additional managed nodes. Deleting
        /// an activation doesn't de-register managed nodes. You must manually de-register managed
        /// nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteActivation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationException">
        /// The activation isn't valid. The activation might have been deleted, or the ActivationId
        /// and the ActivationCode don't match.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID isn't valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteActivation">REST API Reference for DeleteActivation Operation</seealso>
        Task<DeleteActivationResponse> DeleteActivationAsync(DeleteActivationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssociation


        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <c>Targets</c>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association, use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>, <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you must use the <c>Targets</c> parameter. </note></param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        DeleteAssociationResponse DeleteAssociation(string instanceId, string name);

        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <c>Targets</c>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        DeleteAssociationResponse DeleteAssociation(DeleteAssociationRequest request);


        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <c>Targets</c>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="instanceId">The managed node ID. <note>  <c>InstanceId</c> has been deprecated. To specify a managed node ID for an association, use the <c>Targets</c> parameter. Requests that include the parameter <c>InstanceID</c> with Systems Manager documents (SSM documents) that use schema version 2.0 or later will fail. In addition, if you use the parameter <c>InstanceId</c>, you can't use the parameters <c>AssociationName</c>, <c>DocumentVersion</c>, <c>MaxErrors</c>, <c>MaxConcurrency</c>, <c>OutputLocation</c>, or <c>ScheduleExpression</c>. To use these parameters, you must use the <c>Targets</c> parameter. </note></param>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        Task<DeleteAssociationResponse> DeleteAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Disassociates the specified Amazon Web Services Systems Manager document (SSM document)
        /// from the specified managed node. If you created the association by using the <c>Targets</c>
        /// parameter, then you must delete the association by using the association ID.
        /// 
        ///  
        /// <para>
        /// When you disassociate a document from a managed node, it doesn't change the configuration
        /// of the node. To change the configuration state of a managed node after you disassociate
        /// a document, you must create a new document with the desired configuration and associate
        /// it with the node.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteAssociation">REST API Reference for DeleteAssociation Operation</seealso>
        Task<DeleteAssociationResponse> DeleteAssociationAsync(DeleteAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDocument


        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the document.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        DeleteDocumentResponse DeleteDocument(string name);

        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        DeleteDocumentResponse DeleteDocument(DeleteDocumentRequest request);


        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        Task<DeleteDocumentResponse> DeleteDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the Amazon Web Services Systems Manager document (SSM document) and all managed
        /// node associations to the document.
        /// 
        ///  
        /// <para>
        /// Before you delete the document, we recommend that you use <a>DeleteAssociation</a>
        /// to disassociate all managed nodes that are associated with the document.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociatedInstancesException">
        /// You must disassociate a document from all managed nodes before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteDocument">REST API Reference for DeleteDocument Operation</seealso>
        Task<DeleteDocumentResponse> DeleteDocumentAsync(DeleteDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInventory


        /// <summary>
        /// Delete a custom inventory type or the data associated with a custom Inventory type.
        /// Deleting a custom inventory type is also referred to as deleting a custom inventory
        /// schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory service method.</param>
        /// 
        /// <returns>The response from the DeleteInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeleteInventoryParametersException">
        /// One or more of the parameters specified for the delete operation isn't valid. Verify
        /// all parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryRequestException">
        /// The request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOptionException">
        /// The delete inventory option specified isn't valid. Verify the option and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        DeleteInventoryResponse DeleteInventory(DeleteInventoryRequest request);



        /// <summary>
        /// Delete a custom inventory type or the data associated with a custom Inventory type.
        /// Deleting a custom inventory type is also referred to as deleting a custom inventory
        /// schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeleteInventoryParametersException">
        /// One or more of the parameters specified for the delete operation isn't valid. Verify
        /// all parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryRequestException">
        /// The request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOptionException">
        /// The delete inventory option specified isn't valid. Verify the option and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteInventory">REST API Reference for DeleteInventory Operation</seealso>
        Task<DeleteInventoryResponse> DeleteInventoryAsync(DeleteInventoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMaintenanceWindow


        /// <summary>
        /// Deletes a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeleteMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        DeleteMaintenanceWindowResponse DeleteMaintenanceWindow(DeleteMaintenanceWindowRequest request);



        /// <summary>
        /// Deletes a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteMaintenanceWindow">REST API Reference for DeleteMaintenanceWindow Operation</seealso>
        Task<DeleteMaintenanceWindowResponse> DeleteMaintenanceWindowAsync(DeleteMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOpsItem


        /// <summary>
        /// Delete an OpsItem. You must have permission in Identity and Access Management (IAM)
        /// to delete an OpsItem. 
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information about this operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Deleting an OpsItem is irreversible. You can't restore a deleted OpsItem.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation uses an <i>eventual consistency model</i>, which means the system can
        /// take a few minutes to complete this operation. If you delete an OpsItem and immediately
        /// call, for example, <a>GetOpsItem</a>, the deleted OpsItem might still appear in the
        /// response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation is idempotent. The system doesn't throw an exception if you repeatedly
        /// call this operation for the same OpsItem. If the first call is successful, all additional
        /// calls return the same successful response as the first call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation doesn't support cross-account calls. A delegated administrator or management
        /// account can't delete OpsItems in other accounts, even if OpsCenter has been set up
        /// for cross-account administration. For more information about cross-account administration,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setting-up-cross-account.html">Setting
        /// up OpsCenter to centrally manage OpsItems across accounts</a> in the <i>Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsItem service method.</param>
        /// 
        /// <returns>The response from the DeleteOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsItem">REST API Reference for DeleteOpsItem Operation</seealso>
        DeleteOpsItemResponse DeleteOpsItem(DeleteOpsItemRequest request);



        /// <summary>
        /// Delete an OpsItem. You must have permission in Identity and Access Management (IAM)
        /// to delete an OpsItem. 
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information about this operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Deleting an OpsItem is irreversible. You can't restore a deleted OpsItem.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation uses an <i>eventual consistency model</i>, which means the system can
        /// take a few minutes to complete this operation. If you delete an OpsItem and immediately
        /// call, for example, <a>GetOpsItem</a>, the deleted OpsItem might still appear in the
        /// response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation is idempotent. The system doesn't throw an exception if you repeatedly
        /// call this operation for the same OpsItem. If the first call is successful, all additional
        /// calls return the same successful response as the first call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation doesn't support cross-account calls. A delegated administrator or management
        /// account can't delete OpsItems in other accounts, even if OpsCenter has been set up
        /// for cross-account administration. For more information about cross-account administration,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setting-up-cross-account.html">Setting
        /// up OpsCenter to centrally manage OpsItems across accounts</a> in the <i>Systems Manager
        /// User Guide</i>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsItem">REST API Reference for DeleteOpsItem Operation</seealso>
        Task<DeleteOpsItemResponse> DeleteOpsItemAsync(DeleteOpsItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOpsMetadata


        /// <summary>
        /// Delete OpsMetadata related to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the DeleteOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        DeleteOpsMetadataResponse DeleteOpsMetadata(DeleteOpsMetadataRequest request);



        /// <summary>
        /// Delete OpsMetadata related to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteOpsMetadata">REST API Reference for DeleteOpsMetadata Operation</seealso>
        Task<DeleteOpsMetadataResponse> DeleteOpsMetadataAsync(DeleteOpsMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteParameter


        /// <summary>
        /// Delete a parameter from the system. After deleting a parameter, wait for at least
        /// 30 seconds to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter service method.</param>
        /// 
        /// <returns>The response from the DeleteParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        DeleteParameterResponse DeleteParameter(DeleteParameterRequest request);



        /// <summary>
        /// Delete a parameter from the system. After deleting a parameter, wait for at least
        /// 30 seconds to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameter">REST API Reference for DeleteParameter Operation</seealso>
        Task<DeleteParameterResponse> DeleteParameterAsync(DeleteParameterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteParameters


        /// <summary>
        /// Delete a list of parameters. After deleting a parameter, wait for at least 30 seconds
        /// to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters service method.</param>
        /// 
        /// <returns>The response from the DeleteParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        DeleteParametersResponse DeleteParameters(DeleteParametersRequest request);



        /// <summary>
        /// Delete a list of parameters. After deleting a parameter, wait for at least 30 seconds
        /// to create a parameter with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteParameters">REST API Reference for DeleteParameters Operation</seealso>
        Task<DeleteParametersResponse> DeleteParametersAsync(DeleteParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePatchBaseline


        /// <summary>
        /// Deletes a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the DeletePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceInUseException">
        /// Error returned if an attempt is made to delete a patch baseline that is registered
        /// for a patch group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        DeletePatchBaselineResponse DeletePatchBaseline(DeletePatchBaselineRequest request);



        /// <summary>
        /// Deletes a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceInUseException">
        /// Error returned if an attempt is made to delete a patch baseline that is registered
        /// for a patch group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeletePatchBaseline">REST API Reference for DeletePatchBaseline Operation</seealso>
        Task<DeletePatchBaselineResponse> DeletePatchBaselineAsync(DeletePatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourceDataSync


        /// <summary>
        /// Deletes a resource data sync configuration. After the configuration is deleted, changes
        /// to data on managed nodes are no longer synced to or from the target. Deleting a sync
        /// configuration doesn't delete data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        DeleteResourceDataSyncResponse DeleteResourceDataSync(DeleteResourceDataSyncRequest request);



        /// <summary>
        /// Deletes a resource data sync configuration. After the configuration is deleted, changes
        /// to data on managed nodes are no longer synced to or from the target. Deleting a sync
        /// configuration doesn't delete data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourceDataSync">REST API Reference for DeleteResourceDataSync Operation</seealso>
        Task<DeleteResourceDataSyncResponse> DeleteResourceDataSyncAsync(DeleteResourceDataSyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a Systems Manager resource policy. A resource policy helps you to define the
        /// IAM entity (for example, an Amazon Web Services account) that can manage your Systems
        /// Manager resources. The following resources support Systems Manager resource policies.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
        /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
        /// using Resource Access Manager (RAM). For more information about cross-account sharing
        /// of parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
        /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MalformedResourcePolicyDocumentException">
        /// The specified policy document is malformed or invalid, or excessive <c>PutResourcePolicy</c>
        /// or <c>DeleteResourcePolicy</c> calls have been made.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyNotFoundException">
        /// No policies with the specified policy ID and hash could be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Deletes a Systems Manager resource policy. A resource policy helps you to define the
        /// IAM entity (for example, an Amazon Web Services account) that can manage your Systems
        /// Manager resources. The following resources support Systems Manager resource policies.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
        /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
        /// using Resource Access Manager (RAM). For more information about cross-account sharing
        /// of parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
        /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MalformedResourcePolicyDocumentException">
        /// The specified policy document is malformed or invalid, or excessive <c>PutResourcePolicy</c>
        /// or <c>DeleteResourcePolicy</c> calls have been made.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyNotFoundException">
        /// No policies with the specified policy ID and hash could be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterManagedInstance


        /// <summary>
        /// Removes the server or virtual machine from the list of registered servers. You can
        /// reregister the node again at any time. If you don't plan to use Run Command on the
        /// server, we suggest uninstalling SSM Agent first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterManagedInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        DeregisterManagedInstanceResponse DeregisterManagedInstance(DeregisterManagedInstanceRequest request);



        /// <summary>
        /// Removes the server or virtual machine from the list of registered servers. You can
        /// reregister the node again at any time. If you don't plan to use Run Command on the
        /// server, we suggest uninstalling SSM Agent first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterManagedInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterManagedInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterManagedInstance">REST API Reference for DeregisterManagedInstance Operation</seealso>
        Task<DeregisterManagedInstanceResponse> DeregisterManagedInstanceAsync(DeregisterManagedInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterPatchBaselineForPatchGroup


        /// <summary>
        /// Removes a patch group from a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DeregisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        DeregisterPatchBaselineForPatchGroupResponse DeregisterPatchBaselineForPatchGroup(DeregisterPatchBaselineForPatchGroupRequest request);



        /// <summary>
        /// Removes a patch group from a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterPatchBaselineForPatchGroup">REST API Reference for DeregisterPatchBaselineForPatchGroup Operation</seealso>
        Task<DeregisterPatchBaselineForPatchGroupResponse> DeregisterPatchBaselineForPatchGroupAsync(DeregisterPatchBaselineForPatchGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterTargetFromMaintenanceWindow


        /// <summary>
        /// Removes a target from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargetFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetInUseException">
        /// You specified the <c>Safe</c> option for the DeregisterTargetFromMaintenanceWindow
        /// operation, but the target is still referenced in a task.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        DeregisterTargetFromMaintenanceWindowResponse DeregisterTargetFromMaintenanceWindow(DeregisterTargetFromMaintenanceWindowRequest request);



        /// <summary>
        /// Removes a target from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargetFromMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTargetFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetInUseException">
        /// You specified the <c>Safe</c> option for the DeregisterTargetFromMaintenanceWindow
        /// operation, but the target is still referenced in a task.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTargetFromMaintenanceWindow">REST API Reference for DeregisterTargetFromMaintenanceWindow Operation</seealso>
        Task<DeregisterTargetFromMaintenanceWindowResponse> DeregisterTargetFromMaintenanceWindowAsync(DeregisterTargetFromMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterTaskFromMaintenanceWindow


        /// <summary>
        /// Removes a task from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the DeregisterTaskFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        DeregisterTaskFromMaintenanceWindowResponse DeregisterTaskFromMaintenanceWindow(DeregisterTaskFromMaintenanceWindowRequest request);



        /// <summary>
        /// Removes a task from a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTaskFromMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTaskFromMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DeregisterTaskFromMaintenanceWindow">REST API Reference for DeregisterTaskFromMaintenanceWindow Operation</seealso>
        Task<DeregisterTaskFromMaintenanceWindowResponse> DeregisterTaskFromMaintenanceWindowAsync(DeregisterTaskFromMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeActivations


        /// <summary>
        /// Describes details about the activation, such as the date and time the activation was
        /// created, its expiration date, the Identity and Access Management (IAM) role assigned
        /// to the managed nodes in the activation, and the number of nodes registered by using
        /// this activation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations service method.</param>
        /// 
        /// <returns>The response from the DescribeActivations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        DescribeActivationsResponse DescribeActivations(DescribeActivationsRequest request);



        /// <summary>
        /// Describes details about the activation, such as the date and time the activation was
        /// created, its expiration date, the Identity and Access Management (IAM) role assigned
        /// to the managed nodes in the activation, and the number of nodes registered by using
        /// this activation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeActivations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeActivations">REST API Reference for DescribeActivations Operation</seealso>
        Task<DescribeActivationsResponse> DescribeActivationsAsync(DescribeActivationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssociation


        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <c>Targets</c> parameter, then you must retrieve the
        /// association by using the association ID.
        /// </summary>
        /// <param name="instanceId">The managed node ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        DescribeAssociationResponse DescribeAssociation(string instanceId, string name);

        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <c>Targets</c> parameter, then you must retrieve the
        /// association by using the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        DescribeAssociationResponse DescribeAssociation(DescribeAssociationRequest request);


        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <c>Targets</c> parameter, then you must retrieve the
        /// association by using the association ID.
        /// </summary>
        /// <param name="instanceId">The managed node ID.</param>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        Task<DescribeAssociationResponse> DescribeAssociationAsync(string instanceId, string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Describes the association for the specified target or managed node. If you created
        /// the association by using the <c>Targets</c> parameter, then you must retrieve the
        /// association by using the association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociation">REST API Reference for DescribeAssociation Operation</seealso>
        Task<DescribeAssociationResponse> DescribeAssociationAsync(DescribeAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssociationExecutions


        /// <summary>
        /// Views all executions for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        DescribeAssociationExecutionsResponse DescribeAssociationExecutions(DescribeAssociationExecutionsRequest request);



        /// <summary>
        /// Views all executions for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutions">REST API Reference for DescribeAssociationExecutions Operation</seealso>
        Task<DescribeAssociationExecutionsResponse> DescribeAssociationExecutionsAsync(DescribeAssociationExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAssociationExecutionTargets


        /// <summary>
        /// Views information about a specific execution of a specific association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutionTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationExecutionDoesNotExistException">
        /// The specified execution ID doesn't exist. Verify the ID number and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        DescribeAssociationExecutionTargetsResponse DescribeAssociationExecutionTargets(DescribeAssociationExecutionTargetsRequest request);



        /// <summary>
        /// Views information about a specific execution of a specific association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssociationExecutionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssociationExecutionTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationExecutionDoesNotExistException">
        /// The specified execution ID doesn't exist. Verify the ID number and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAssociationExecutionTargets">REST API Reference for DescribeAssociationExecutionTargets Operation</seealso>
        Task<DescribeAssociationExecutionTargetsResponse> DescribeAssociationExecutionTargetsAsync(DescribeAssociationExecutionTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAutomationExecutions


        /// <summary>
        /// Provides details about all active and terminated Automation executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAutomationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        DescribeAutomationExecutionsResponse DescribeAutomationExecutions(DescribeAutomationExecutionsRequest request);



        /// <summary>
        /// Provides details about all active and terminated Automation executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutomationExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationExecutions">REST API Reference for DescribeAutomationExecutions Operation</seealso>
        Task<DescribeAutomationExecutionsResponse> DescribeAutomationExecutionsAsync(DescribeAutomationExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAutomationStepExecutions


        /// <summary>
        /// Information about all active and terminated step executions in an Automation workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeAutomationStepExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        DescribeAutomationStepExecutionsResponse DescribeAutomationStepExecutions(DescribeAutomationStepExecutionsRequest request);



        /// <summary>
        /// Information about all active and terminated step executions in an Automation workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutomationStepExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutomationStepExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAutomationStepExecutions">REST API Reference for DescribeAutomationStepExecutions Operation</seealso>
        Task<DescribeAutomationStepExecutionsResponse> DescribeAutomationStepExecutionsAsync(DescribeAutomationStepExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAvailablePatches


        /// <summary>
        /// Lists all patches eligible to be included in a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, <c>DescribeAvailablePatches</c> supports only the Amazon Linux 1, Amazon
        /// Linux 2, and Windows Server operating systems.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailablePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        DescribeAvailablePatchesResponse DescribeAvailablePatches(DescribeAvailablePatchesRequest request);



        /// <summary>
        /// Lists all patches eligible to be included in a patch baseline.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, <c>DescribeAvailablePatches</c> supports only the Amazon Linux 1, Amazon
        /// Linux 2, and Windows Server operating systems.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailablePatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailablePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeAvailablePatches">REST API Reference for DescribeAvailablePatches Operation</seealso>
        Task<DescribeAvailablePatchesResponse> DescribeAvailablePatchesAsync(DescribeAvailablePatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDocument


        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        DescribeDocumentResponse DescribeDocument(string name);

        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        DescribeDocumentResponse DescribeDocument(DescribeDocumentRequest request);


        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        Task<DescribeDocumentResponse> DescribeDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Describes the specified Amazon Web Services Systems Manager document (SSM document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocument">REST API Reference for DescribeDocument Operation</seealso>
        Task<DescribeDocumentResponse> DescribeDocumentAsync(DescribeDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDocumentPermission


        /// <summary>
        /// Describes the permissions for a Amazon Web Services Systems Manager document (SSM
        /// document). If you created the document, you are the owner. If a document is shared,
        /// it can either be shared privately (by specifying a user's Amazon Web Services account
        /// ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the DescribeDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        DescribeDocumentPermissionResponse DescribeDocumentPermission(DescribeDocumentPermissionRequest request);



        /// <summary>
        /// Describes the permissions for a Amazon Web Services Systems Manager document (SSM
        /// document). If you created the document, you are the owner. If a document is shared,
        /// it can either be shared privately (by specifying a user's Amazon Web Services account
        /// ID) or publicly (<i>All</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeDocumentPermission">REST API Reference for DescribeDocumentPermission Operation</seealso>
        Task<DescribeDocumentPermissionResponse> DescribeDocumentPermissionAsync(DescribeDocumentPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEffectiveInstanceAssociations


        /// <summary>
        /// All associations for the managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectiveInstanceAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        DescribeEffectiveInstanceAssociationsResponse DescribeEffectiveInstanceAssociations(DescribeEffectiveInstanceAssociationsRequest request);



        /// <summary>
        /// All associations for the managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectiveInstanceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEffectiveInstanceAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectiveInstanceAssociations">REST API Reference for DescribeEffectiveInstanceAssociations Operation</seealso>
        Task<DescribeEffectiveInstanceAssociationsResponse> DescribeEffectiveInstanceAssociationsAsync(DescribeEffectiveInstanceAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEffectivePatchesForPatchBaseline


        /// <summary>
        /// Retrieves the current effective patches (the patch and the approval state) for the
        /// specified patch baseline. Applies to patch baselines for Windows only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the DescribeEffectivePatchesForPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        DescribeEffectivePatchesForPatchBaselineResponse DescribeEffectivePatchesForPatchBaseline(DescribeEffectivePatchesForPatchBaselineRequest request);



        /// <summary>
        /// Retrieves the current effective patches (the patch and the approval state) for the
        /// specified patch baseline. Applies to patch baselines for Windows only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePatchesForPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEffectivePatchesForPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeEffectivePatchesForPatchBaseline">REST API Reference for DescribeEffectivePatchesForPatchBaseline Operation</seealso>
        Task<DescribeEffectivePatchesForPatchBaselineResponse> DescribeEffectivePatchesForPatchBaselineAsync(DescribeEffectivePatchesForPatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceAssociationsStatus


        /// <summary>
        /// The status of the associations for the managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAssociationsStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        DescribeInstanceAssociationsStatusResponse DescribeInstanceAssociationsStatus(DescribeInstanceAssociationsStatusRequest request);



        /// <summary>
        /// The status of the associations for the managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAssociationsStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceAssociationsStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceAssociationsStatus">REST API Reference for DescribeInstanceAssociationsStatus Operation</seealso>
        Task<DescribeInstanceAssociationsStatusResponse> DescribeInstanceAssociationsStatusAsync(DescribeInstanceAssociationsStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceInformation


        /// <summary>
        /// Provides information about one or more of your managed nodes, including the operating
        /// system platform, SSM Agent version, association status, and IP address. This operation
        /// does not return information for nodes that are either Stopped or Terminated.
        /// 
        ///  
        /// <para>
        /// If you specify one or more node IDs, the operation returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>IamRole</c> field returned for this API operation is the Identity and Access
        /// Management (IAM) role assigned to on-premises managed nodes. This operation does not
        /// return the IAM role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        DescribeInstanceInformationResponse DescribeInstanceInformation();


        /// <summary>
        /// Provides information about one or more of your managed nodes, including the operating
        /// system platform, SSM Agent version, association status, and IP address. This operation
        /// does not return information for nodes that are either Stopped or Terminated.
        /// 
        ///  
        /// <para>
        /// If you specify one or more node IDs, the operation returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>IamRole</c> field returned for this API operation is the Identity and Access
        /// Management (IAM) role assigned to on-premises managed nodes. This operation does not
        /// return the IAM role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        DescribeInstanceInformationResponse DescribeInstanceInformation(DescribeInstanceInformationRequest request);


        /// <summary>
        /// Provides information about one or more of your managed nodes, including the operating
        /// system platform, SSM Agent version, association status, and IP address. This operation
        /// does not return information for nodes that are either Stopped or Terminated.
        /// 
        ///  
        /// <para>
        /// If you specify one or more node IDs, the operation returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>IamRole</c> field returned for this API operation is the Identity and Access
        /// Management (IAM) role assigned to on-premises managed nodes. This operation does not
        /// return the IAM role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Provides information about one or more of your managed nodes, including the operating
        /// system platform, SSM Agent version, association status, and IP address. This operation
        /// does not return information for nodes that are either Stopped or Terminated.
        /// 
        ///  
        /// <para>
        /// If you specify one or more node IDs, the operation returns information for those managed
        /// nodes. If you don't specify node IDs, it returns information for all your managed
        /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
        /// receive an error.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>IamRole</c> field returned for this API operation is the Identity and Access
        /// Management (IAM) role assigned to on-premises managed nodes. This operation does not
        /// return the IAM role for EC2 instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceInformation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceInformationFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceInformation">REST API Reference for DescribeInstanceInformation Operation</seealso>
        Task<DescribeInstanceInformationResponse> DescribeInstanceInformationAsync(DescribeInstanceInformationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstancePatches


        /// <summary>
        /// Retrieves information about the patches on the specified managed node and their state
        /// relative to the patch baseline being used for the node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        DescribeInstancePatchesResponse DescribeInstancePatches(DescribeInstancePatchesRequest request);



        /// <summary>
        /// Retrieves information about the patches on the specified managed node and their state
        /// relative to the patch baseline being used for the node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatches service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatches">REST API Reference for DescribeInstancePatches Operation</seealso>
        Task<DescribeInstancePatchesResponse> DescribeInstancePatchesAsync(DescribeInstancePatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstancePatchStates


        /// <summary>
        /// Retrieves the high-level patch state of one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStates service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        DescribeInstancePatchStatesResponse DescribeInstancePatchStates(DescribeInstancePatchStatesRequest request);



        /// <summary>
        /// Retrieves the high-level patch state of one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStates service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStates">REST API Reference for DescribeInstancePatchStates Operation</seealso>
        Task<DescribeInstancePatchStatesResponse> DescribeInstancePatchStatesAsync(DescribeInstancePatchStatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstancePatchStatesForPatchGroup


        /// <summary>
        /// Retrieves the high-level patch state for the managed nodes in the specified patch
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStatesForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        DescribeInstancePatchStatesForPatchGroupResponse DescribeInstancePatchStatesForPatchGroup(DescribeInstancePatchStatesForPatchGroupRequest request);



        /// <summary>
        /// Retrieves the high-level patch state for the managed nodes in the specified patch
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancePatchStatesForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstancePatchStatesForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstancePatchStatesForPatchGroup">REST API Reference for DescribeInstancePatchStatesForPatchGroup Operation</seealso>
        Task<DescribeInstancePatchStatesForPatchGroupResponse> DescribeInstancePatchStatesForPatchGroupAsync(DescribeInstancePatchStatesForPatchGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInstanceProperties


        /// <summary>
        /// An API operation used by the Systems Manager console to display information about
        /// Systems Manager managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceProperties service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID isn't valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstancePropertyFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceProperties">REST API Reference for DescribeInstanceProperties Operation</seealso>
        DescribeInstancePropertiesResponse DescribeInstanceProperties(DescribeInstancePropertiesRequest request);



        /// <summary>
        /// An API operation used by the Systems Manager console to display information about
        /// Systems Manager managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidActivationIdException">
        /// The activation ID isn't valid. Verify the you entered the correct ActivationId or
        /// ActivationCode and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstancePropertyFilterValueException">
        /// The specified filter value isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInstanceProperties">REST API Reference for DescribeInstanceProperties Operation</seealso>
        Task<DescribeInstancePropertiesResponse> DescribeInstancePropertiesAsync(DescribeInstancePropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeInventoryDeletions


        /// <summary>
        /// Describes a specific delete inventory operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions service method.</param>
        /// 
        /// <returns>The response from the DescribeInventoryDeletions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeletionIdException">
        /// The ID specified for the delete operation doesn't exist or isn't valid. Verify the
        /// ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        DescribeInventoryDeletionsResponse DescribeInventoryDeletions(DescribeInventoryDeletionsRequest request);



        /// <summary>
        /// Describes a specific delete inventory operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInventoryDeletions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInventoryDeletions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDeletionIdException">
        /// The ID specified for the delete operation doesn't exist or isn't valid. Verify the
        /// ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeInventoryDeletions">REST API Reference for DescribeInventoryDeletions Operation</seealso>
        Task<DescribeInventoryDeletionsResponse> DescribeInventoryDeletionsAsync(DescribeInventoryDeletionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowExecutions


        /// <summary>
        /// Lists the executions of a maintenance window. This includes information about when
        /// the maintenance window was scheduled to be active, and information about tasks registered
        /// and run with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        DescribeMaintenanceWindowExecutionsResponse DescribeMaintenanceWindowExecutions(DescribeMaintenanceWindowExecutionsRequest request);



        /// <summary>
        /// Lists the executions of a maintenance window. This includes information about when
        /// the maintenance window was scheduled to be active, and information about tasks registered
        /// and run with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutions">REST API Reference for DescribeMaintenanceWindowExecutions Operation</seealso>
        Task<DescribeMaintenanceWindowExecutionsResponse> DescribeMaintenanceWindowExecutionsAsync(DescribeMaintenanceWindowExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTaskInvocations


        /// <summary>
        /// Retrieves the individual task executions (one per target) for a particular task run
        /// as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTaskInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        DescribeMaintenanceWindowExecutionTaskInvocationsResponse DescribeMaintenanceWindowExecutionTaskInvocations(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request);



        /// <summary>
        /// Retrieves the individual task executions (one per target) for a particular task run
        /// as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTaskInvocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTaskInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTaskInvocations">REST API Reference for DescribeMaintenanceWindowExecutionTaskInvocations Operation</seealso>
        Task<DescribeMaintenanceWindowExecutionTaskInvocationsResponse> DescribeMaintenanceWindowExecutionTaskInvocationsAsync(DescribeMaintenanceWindowExecutionTaskInvocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowExecutionTasks


        /// <summary>
        /// For a given maintenance window execution, lists the tasks that were run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        DescribeMaintenanceWindowExecutionTasksResponse DescribeMaintenanceWindowExecutionTasks(DescribeMaintenanceWindowExecutionTasksRequest request);



        /// <summary>
        /// For a given maintenance window execution, lists the tasks that were run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowExecutionTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowExecutionTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowExecutionTasks">REST API Reference for DescribeMaintenanceWindowExecutionTasks Operation</seealso>
        Task<DescribeMaintenanceWindowExecutionTasksResponse> DescribeMaintenanceWindowExecutionTasksAsync(DescribeMaintenanceWindowExecutionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindows


        /// <summary>
        /// Retrieves the maintenance windows in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindows service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        DescribeMaintenanceWindowsResponse DescribeMaintenanceWindows(DescribeMaintenanceWindowsRequest request);



        /// <summary>
        /// Retrieves the maintenance windows in an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindows service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindows">REST API Reference for DescribeMaintenanceWindows Operation</seealso>
        Task<DescribeMaintenanceWindowsResponse> DescribeMaintenanceWindowsAsync(DescribeMaintenanceWindowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowSchedule


        /// <summary>
        /// Retrieves information about upcoming executions of a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowSchedule service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        DescribeMaintenanceWindowScheduleResponse DescribeMaintenanceWindowSchedule(DescribeMaintenanceWindowScheduleRequest request);



        /// <summary>
        /// Retrieves information about upcoming executions of a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowSchedule service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowSchedule">REST API Reference for DescribeMaintenanceWindowSchedule Operation</seealso>
        Task<DescribeMaintenanceWindowScheduleResponse> DescribeMaintenanceWindowScheduleAsync(DescribeMaintenanceWindowScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowsForTarget


        /// <summary>
        /// Retrieves information about the maintenance window targets or tasks that a managed
        /// node is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowsForTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        DescribeMaintenanceWindowsForTargetResponse DescribeMaintenanceWindowsForTarget(DescribeMaintenanceWindowsForTargetRequest request);



        /// <summary>
        /// Retrieves information about the maintenance window targets or tasks that a managed
        /// node is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowsForTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowsForTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowsForTarget">REST API Reference for DescribeMaintenanceWindowsForTarget Operation</seealso>
        Task<DescribeMaintenanceWindowsForTargetResponse> DescribeMaintenanceWindowsForTargetAsync(DescribeMaintenanceWindowsForTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowTargets


        /// <summary>
        /// Lists the targets registered with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        DescribeMaintenanceWindowTargetsResponse DescribeMaintenanceWindowTargets(DescribeMaintenanceWindowTargetsRequest request);



        /// <summary>
        /// Lists the targets registered with the maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTargets service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTargets">REST API Reference for DescribeMaintenanceWindowTargets Operation</seealso>
        Task<DescribeMaintenanceWindowTargetsResponse> DescribeMaintenanceWindowTargetsAsync(DescribeMaintenanceWindowTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMaintenanceWindowTasks


        /// <summary>
        /// Lists the tasks in a maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <c>--max-errors</c> and <c>--max-concurrency</c>. Instead, the system inserts a placeholder
        /// value of <c>1</c>, which may be reported in the response to this command. These values
        /// don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        DescribeMaintenanceWindowTasksResponse DescribeMaintenanceWindowTasks(DescribeMaintenanceWindowTasksRequest request);



        /// <summary>
        /// Lists the tasks in a maintenance window.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <c>--max-errors</c> and <c>--max-concurrency</c>. Instead, the system inserts a placeholder
        /// value of <c>1</c>, which may be reported in the response to this command. These values
        /// don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMaintenanceWindowTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMaintenanceWindowTasks service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeMaintenanceWindowTasks">REST API Reference for DescribeMaintenanceWindowTasks Operation</seealso>
        Task<DescribeMaintenanceWindowTasksResponse> DescribeMaintenanceWindowTasksAsync(DescribeMaintenanceWindowTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOpsItems


        /// <summary>
        /// Query a set of OpsItems. You must have permission in Identity and Access Management
        /// (IAM) to query a list of OpsItems. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOpsItems service method.</param>
        /// 
        /// <returns>The response from the DescribeOpsItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        DescribeOpsItemsResponse DescribeOpsItems(DescribeOpsItemsRequest request);



        /// <summary>
        /// Query a set of OpsItems. You must have permission in Identity and Access Management
        /// (IAM) to query a list of OpsItems. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOpsItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOpsItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeOpsItems">REST API Reference for DescribeOpsItems Operation</seealso>
        Task<DescribeOpsItemsResponse> DescribeOpsItemsAsync(DescribeOpsItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeParameters


        /// <summary>
        /// Lists the parameters in your Amazon Web Services account or the parameters shared
        /// with you when you enable the <a href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html#systemsmanager-DescribeParameters-request-Shared">Shared</a>
        /// option.
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <c>MaxResults</c>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <c>MaxResults</c>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <c>NextToken</c>.
        /// You can specify the <c>NextToken</c> in a subsequent call to get the next set of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <c>DescribeParameters</c> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        DescribeParametersResponse DescribeParameters(DescribeParametersRequest request);



        /// <summary>
        /// Lists the parameters in your Amazon Web Services account or the parameters shared
        /// with you when you enable the <a href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html#systemsmanager-DescribeParameters-request-Shared">Shared</a>
        /// option.
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <c>MaxResults</c>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <c>MaxResults</c>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <c>NextToken</c>.
        /// You can specify the <c>NextToken</c> in a subsequent call to get the next set of results.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <c>DescribeParameters</c> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePatchBaselines


        /// <summary>
        /// Lists the patch baselines in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines service method.</param>
        /// 
        /// <returns>The response from the DescribePatchBaselines service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        DescribePatchBaselinesResponse DescribePatchBaselines(DescribePatchBaselinesRequest request);



        /// <summary>
        /// Lists the patch baselines in your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchBaselines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchBaselines service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchBaselines">REST API Reference for DescribePatchBaselines Operation</seealso>
        Task<DescribePatchBaselinesResponse> DescribePatchBaselinesAsync(DescribePatchBaselinesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePatchGroups


        /// <summary>
        /// Lists all patch groups that have been registered with patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroups service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        DescribePatchGroupsResponse DescribePatchGroups(DescribePatchGroupsRequest request);



        /// <summary>
        /// Lists all patch groups that have been registered with patch baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchGroups service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroups">REST API Reference for DescribePatchGroups Operation</seealso>
        Task<DescribePatchGroupsResponse> DescribePatchGroupsAsync(DescribePatchGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePatchGroupState


        /// <summary>
        /// Returns high-level aggregated patch compliance state information for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState service method.</param>
        /// 
        /// <returns>The response from the DescribePatchGroupState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        DescribePatchGroupStateResponse DescribePatchGroupState(DescribePatchGroupStateRequest request);



        /// <summary>
        /// Returns high-level aggregated patch compliance state information for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchGroupState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchGroupState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchGroupState">REST API Reference for DescribePatchGroupState Operation</seealso>
        Task<DescribePatchGroupStateResponse> DescribePatchGroupStateAsync(DescribePatchGroupStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePatchProperties


        /// <summary>
        /// Lists the properties of available patches organized by product, product family, classification,
        /// severity, and other properties of available patches. You can use the reported properties
        /// in the filters you specify in requests for operations such as <a>CreatePatchBaseline</a>,
        /// <a>UpdatePatchBaseline</a>, <a>DescribeAvailablePatches</a>, and <a>DescribePatchBaselines</a>.
        /// 
        ///  
        /// <para>
        /// The following section lists the properties that can be used in filters for each major
        /// operating system type:
        /// </para>
        ///  <dl> <dt>AMAZON_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>AMAZON_LINUX_2</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>CENTOS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>DEBIAN</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
        /// </para>
        ///  </dd> <dt>MACOS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> 
        /// </para>
        ///  </dd> <dt>ORACLE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>REDHAT_ENTERPRISE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>SUSE</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>UBUNTU</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
        /// </para>
        ///  </dd> <dt>WINDOWS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRODUCT_FAMILY</c> | <c>CLASSIFICATION</c> |
        /// <c>MSRC_SEVERITY</c> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchProperties service method.</param>
        /// 
        /// <returns>The response from the DescribePatchProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        DescribePatchPropertiesResponse DescribePatchProperties(DescribePatchPropertiesRequest request);



        /// <summary>
        /// Lists the properties of available patches organized by product, product family, classification,
        /// severity, and other properties of available patches. You can use the reported properties
        /// in the filters you specify in requests for operations such as <a>CreatePatchBaseline</a>,
        /// <a>UpdatePatchBaseline</a>, <a>DescribeAvailablePatches</a>, and <a>DescribePatchBaselines</a>.
        /// 
        ///  
        /// <para>
        /// The following section lists the properties that can be used in filters for each major
        /// operating system type:
        /// </para>
        ///  <dl> <dt>AMAZON_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>AMAZON_LINUX_2</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>CENTOS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>DEBIAN</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
        /// </para>
        ///  </dd> <dt>MACOS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> 
        /// </para>
        ///  </dd> <dt>ORACLE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>REDHAT_ENTERPRISE_LINUX</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>SUSE</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
        /// </para>
        ///  </dd> <dt>UBUNTU</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
        /// </para>
        ///  </dd> <dt>WINDOWS</dt> <dd> 
        /// <para>
        /// Valid properties: <c>PRODUCT</c> | <c>PRODUCT_FAMILY</c> | <c>CLASSIFICATION</c> |
        /// <c>MSRC_SEVERITY</c> 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePatchProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePatchProperties service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribePatchProperties">REST API Reference for DescribePatchProperties Operation</seealso>
        Task<DescribePatchPropertiesResponse> DescribePatchPropertiesAsync(DescribePatchPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSessions


        /// <summary>
        /// Retrieves a list of all active sessions (both connected and disconnected) or terminated
        /// sessions from the past 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        DescribeSessionsResponse DescribeSessions(DescribeSessionsRequest request);



        /// <summary>
        /// Retrieves a list of all active sessions (both connected and disconnected) or terminated
        /// sessions from the past 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSessions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DescribeSessions">REST API Reference for DescribeSessions Operation</seealso>
        Task<DescribeSessionsResponse> DescribeSessionsAsync(DescribeSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateOpsItemRelatedItem


        /// <summary>
        /// Deletes the association between an OpsItem and a related item. For example, this API
        /// operation can delete an Incident Manager incident from an OpsItem. Incident Manager
        /// is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpsItemRelatedItem service method.</param>
        /// 
        /// <returns>The response from the DisassociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAssociationNotFoundException">
        /// The association wasn't found using the parameters you specified in the call. Verify
        /// the information and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DisassociateOpsItemRelatedItem">REST API Reference for DisassociateOpsItemRelatedItem Operation</seealso>
        DisassociateOpsItemRelatedItemResponse DisassociateOpsItemRelatedItem(DisassociateOpsItemRelatedItemRequest request);



        /// <summary>
        /// Deletes the association between an OpsItem and a related item. For example, this API
        /// operation can delete an Incident Manager incident from an OpsItem. Incident Manager
        /// is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpsItemRelatedItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOpsItemRelatedItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemRelatedItemAssociationNotFoundException">
        /// The association wasn't found using the parameters you specified in the call. Verify
        /// the information and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/DisassociateOpsItemRelatedItem">REST API Reference for DisassociateOpsItemRelatedItem Operation</seealso>
        Task<DisassociateOpsItemRelatedItemResponse> DisassociateOpsItemRelatedItemAsync(DisassociateOpsItemRelatedItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAutomationExecution


        /// <summary>
        /// Get detailed information about a particular Automation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the GetAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        GetAutomationExecutionResponse GetAutomationExecution(GetAutomationExecutionRequest request);



        /// <summary>
        /// Get detailed information about a particular Automation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetAutomationExecution">REST API Reference for GetAutomationExecution Operation</seealso>
        Task<GetAutomationExecutionResponse> GetAutomationExecutionAsync(GetAutomationExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCalendarState


        /// <summary>
        /// Gets the state of a Amazon Web Services Systems Manager change calendar at the current
        /// time or a specified time. If you specify a time, <c>GetCalendarState</c> returns the
        /// state of the calendar at that specific time, and returns the next time that the change
        /// calendar state will transition. If you don't specify a time, <c>GetCalendarState</c>
        /// uses the current time. Change Calendar entries have two possible states: <c>OPEN</c>
        /// or <c>CLOSED</c>.
        /// 
        ///  
        /// <para>
        /// If you specify more than one calendar in a request, the command returns the status
        /// of <c>OPEN</c> only if all calendars in the request are open. If one or more calendars
        /// in the request are closed, the status returned is <c>CLOSED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Change Calendar, a capability of Amazon Web Services Systems
        /// Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">Amazon
        /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalendarState service method.</param>
        /// 
        /// <returns>The response from the GetCalendarState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentTypeException">
        /// The SSM document type isn't valid. Valid document types are described in the <c>DocumentType</c>
        /// property.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedCalendarException">
        /// The calendar entry contained in the specified SSM document isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        GetCalendarStateResponse GetCalendarState(GetCalendarStateRequest request);



        /// <summary>
        /// Gets the state of a Amazon Web Services Systems Manager change calendar at the current
        /// time or a specified time. If you specify a time, <c>GetCalendarState</c> returns the
        /// state of the calendar at that specific time, and returns the next time that the change
        /// calendar state will transition. If you don't specify a time, <c>GetCalendarState</c>
        /// uses the current time. Change Calendar entries have two possible states: <c>OPEN</c>
        /// or <c>CLOSED</c>.
        /// 
        ///  
        /// <para>
        /// If you specify more than one calendar in a request, the command returns the status
        /// of <c>OPEN</c> only if all calendars in the request are open. If one or more calendars
        /// in the request are closed, the status returned is <c>CLOSED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Change Calendar, a capability of Amazon Web Services Systems
        /// Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">Amazon
        /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalendarState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalendarState service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentTypeException">
        /// The SSM document type isn't valid. Valid document types are described in the <c>DocumentType</c>
        /// property.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedCalendarException">
        /// The calendar entry contained in the specified SSM document isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCalendarState">REST API Reference for GetCalendarState Operation</seealso>
        Task<GetCalendarStateResponse> GetCalendarStateAsync(GetCalendarStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCommandInvocation


        /// <summary>
        /// Returns detailed information about command execution for an invocation or plugin.
        /// 
        ///  
        /// <para>
        ///  <c>GetCommandInvocation</c> only gives the execution status of a plugin in a document.
        /// To get the command execution status on a specific managed node, use <a>ListCommandInvocations</a>.
        /// To get the command execution status across managed nodes, use <a>ListCommands</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation service method.</param>
        /// 
        /// <returns>The response from the GetCommandInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPluginNameException">
        /// The plugin name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvocationDoesNotExistException">
        /// The command ID and managed node ID you specified didn't match any invocations. Verify
        /// the command ID and the managed node ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        GetCommandInvocationResponse GetCommandInvocation(GetCommandInvocationRequest request);



        /// <summary>
        /// Returns detailed information about command execution for an invocation or plugin.
        /// 
        ///  
        /// <para>
        ///  <c>GetCommandInvocation</c> only gives the execution status of a plugin in a document.
        /// To get the command execution status on a specific managed node, use <a>ListCommandInvocations</a>.
        /// To get the command execution status across managed nodes, use <a>ListCommands</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommandInvocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommandInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPluginNameException">
        /// The plugin name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvocationDoesNotExistException">
        /// The command ID and managed node ID you specified didn't match any invocations. Verify
        /// the command ID and the managed node ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetCommandInvocation">REST API Reference for GetCommandInvocation Operation</seealso>
        Task<GetCommandInvocationResponse> GetCommandInvocationAsync(GetCommandInvocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnectionStatus


        /// <summary>
        /// Retrieves the Session Manager connection status for a managed node to determine whether
        /// it is running and ready to receive Session Manager connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus service method.</param>
        /// 
        /// <returns>The response from the GetConnectionStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        GetConnectionStatusResponse GetConnectionStatus(GetConnectionStatusRequest request);



        /// <summary>
        /// Retrieves the Session Manager connection status for a managed node to determine whether
        /// it is running and ready to receive Session Manager connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetConnectionStatus">REST API Reference for GetConnectionStatus Operation</seealso>
        Task<GetConnectionStatusResponse> GetConnectionStatusAsync(GetConnectionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDefaultPatchBaseline


        /// <summary>
        /// Retrieves the default patch baseline. Amazon Web Services Systems Manager supports
        /// creating multiple default patch baselines. For example, you can create a default patch
        /// baseline for each operating system.
        /// 
        ///  
        /// <para>
        /// If you don't specify an operating system value, the default patch baseline for Windows
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        GetDefaultPatchBaselineResponse GetDefaultPatchBaseline(GetDefaultPatchBaselineRequest request);



        /// <summary>
        /// Retrieves the default patch baseline. Amazon Web Services Systems Manager supports
        /// creating multiple default patch baselines. For example, you can create a default patch
        /// baseline for each operating system.
        /// 
        ///  
        /// <para>
        /// If you don't specify an operating system value, the default patch baseline for Windows
        /// is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDefaultPatchBaseline">REST API Reference for GetDefaultPatchBaseline Operation</seealso>
        Task<GetDefaultPatchBaselineResponse> GetDefaultPatchBaselineAsync(GetDefaultPatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeployablePatchSnapshotForInstance


        /// <summary>
        /// Retrieves the current snapshot for the patch baseline the managed node uses. This
        /// API is primarily used by the <c>AWS-RunPatchBaseline</c> Systems Manager document
        /// (SSM document).
        /// 
        ///  <note> 
        /// <para>
        /// If you run the command locally, such as with the Command Line Interface (CLI), the
        /// system attempts to use your local Amazon Web Services credentials and the operation
        /// fails. To avoid this, you can run the command in the Amazon Web Services Systems Manager
        /// console. Use Run Command, a capability of Amazon Web Services Systems Manager, with
        /// an SSM document that enables you to target a managed node with a script or command.
        /// For example, run the command using the <c>AWS-RunShellScript</c> document or the <c>AWS-RunPowerShellScript</c>
        /// document.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeployablePatchSnapshotForInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedFeatureRequiredException">
        /// Patching for applications released by Microsoft is only available on EC2 instances
        /// and advanced instances. To patch applications released by Microsoft on on-premises
        /// servers and VMs, you must enable advanced instances. For more information, see <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances-advanced.html">Turning
        /// on the advanced-instances tier</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        GetDeployablePatchSnapshotForInstanceResponse GetDeployablePatchSnapshotForInstance(GetDeployablePatchSnapshotForInstanceRequest request);



        /// <summary>
        /// Retrieves the current snapshot for the patch baseline the managed node uses. This
        /// API is primarily used by the <c>AWS-RunPatchBaseline</c> Systems Manager document
        /// (SSM document).
        /// 
        ///  <note> 
        /// <para>
        /// If you run the command locally, such as with the Command Line Interface (CLI), the
        /// system attempts to use your local Amazon Web Services credentials and the operation
        /// fails. To avoid this, you can run the command in the Amazon Web Services Systems Manager
        /// console. Use Run Command, a capability of Amazon Web Services Systems Manager, with
        /// an SSM document that enables you to target a managed node with a script or command.
        /// For example, run the command using the <c>AWS-RunShellScript</c> document or the <c>AWS-RunPowerShellScript</c>
        /// document.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployablePatchSnapshotForInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployablePatchSnapshotForInstance service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedFeatureRequiredException">
        /// Patching for applications released by Microsoft is only available on EC2 instances
        /// and advanced instances. To patch applications released by Microsoft on on-premises
        /// servers and VMs, you must enable advanced instances. For more information, see <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances-advanced.html">Turning
        /// on the advanced-instances tier</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedOperatingSystemException">
        /// The operating systems you specified isn't supported, or the operation isn't supported
        /// for the operating system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDeployablePatchSnapshotForInstance">REST API Reference for GetDeployablePatchSnapshotForInstance Operation</seealso>
        Task<GetDeployablePatchSnapshotForInstanceResponse> GetDeployablePatchSnapshotForInstanceAsync(GetDeployablePatchSnapshotForInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDocument


        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        GetDocumentResponse GetDocument(string name);

        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        GetDocumentResponse GetDocument(GetDocumentRequest request);


        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        Task<GetDocumentResponse> GetDocumentAsync(string name, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the contents of the specified Amazon Web Services Systems Manager document (SSM
        /// document).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetDocument">REST API Reference for GetDocument Operation</seealso>
        Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInventory


        /// <summary>
        /// Query inventory information. This includes managed node status, such as <c>Stopped</c>
        /// or <c>Terminated</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventory service method.</param>
        /// 
        /// <returns>The response from the GetInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <c>AWS:Application</c> or <c>AWS:InstanceInformation</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryGroupException">
        /// The specified inventory group isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResultAttributeException">
        /// The specified inventory item result attribute isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        GetInventoryResponse GetInventory(GetInventoryRequest request);



        /// <summary>
        /// Query inventory information. This includes managed node status, such as <c>Stopped</c>
        /// or <c>Terminated</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <c>AWS:Application</c> or <c>AWS:InstanceInformation</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryGroupException">
        /// The specified inventory group isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResultAttributeException">
        /// The specified inventory item result attribute isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventory">REST API Reference for GetInventory Operation</seealso>
        Task<GetInventoryResponse> GetInventoryAsync(GetInventoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInventorySchema


        /// <summary>
        /// Return a list of inventory type names for the account, or return a list of attribute
        /// names for a specific Inventory item type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema service method.</param>
        /// 
        /// <returns>The response from the GetInventorySchema service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request);



        /// <summary>
        /// Return a list of inventory type names for the account, or return a list of attribute
        /// names for a specific Inventory item type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInventorySchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInventorySchema service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetInventorySchema">REST API Reference for GetInventorySchema Operation</seealso>
        Task<GetInventorySchemaResponse> GetInventorySchemaAsync(GetInventorySchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMaintenanceWindow


        /// <summary>
        /// Retrieves a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        GetMaintenanceWindowResponse GetMaintenanceWindow(GetMaintenanceWindowRequest request);



        /// <summary>
        /// Retrieves a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindow">REST API Reference for GetMaintenanceWindow Operation</seealso>
        Task<GetMaintenanceWindowResponse> GetMaintenanceWindowAsync(GetMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMaintenanceWindowExecution


        /// <summary>
        /// Retrieves details about a specific a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        GetMaintenanceWindowExecutionResponse GetMaintenanceWindowExecution(GetMaintenanceWindowExecutionRequest request);



        /// <summary>
        /// Retrieves details about a specific a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecution">REST API Reference for GetMaintenanceWindowExecution Operation</seealso>
        Task<GetMaintenanceWindowExecutionResponse> GetMaintenanceWindowExecutionAsync(GetMaintenanceWindowExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMaintenanceWindowExecutionTask


        /// <summary>
        /// Retrieves the details about a specific task run as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        GetMaintenanceWindowExecutionTaskResponse GetMaintenanceWindowExecutionTask(GetMaintenanceWindowExecutionTaskRequest request);



        /// <summary>
        /// Retrieves the details about a specific task run as part of a maintenance window execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTask">REST API Reference for GetMaintenanceWindowExecutionTask Operation</seealso>
        Task<GetMaintenanceWindowExecutionTaskResponse> GetMaintenanceWindowExecutionTaskAsync(GetMaintenanceWindowExecutionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMaintenanceWindowExecutionTaskInvocation


        /// <summary>
        /// Retrieves information about a specific task running on a specific target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTaskInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        GetMaintenanceWindowExecutionTaskInvocationResponse GetMaintenanceWindowExecutionTaskInvocation(GetMaintenanceWindowExecutionTaskInvocationRequest request);



        /// <summary>
        /// Retrieves information about a specific task running on a specific target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowExecutionTaskInvocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowExecutionTaskInvocation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowExecutionTaskInvocation">REST API Reference for GetMaintenanceWindowExecutionTaskInvocation Operation</seealso>
        Task<GetMaintenanceWindowExecutionTaskInvocationResponse> GetMaintenanceWindowExecutionTaskInvocationAsync(GetMaintenanceWindowExecutionTaskInvocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMaintenanceWindowTask


        /// <summary>
        /// Retrieves the details of a maintenance window task.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <c>--max-errors</c> and <c>--max-concurrency</c>. Instead, the system inserts a placeholder
        /// value of <c>1</c>, which may be reported in the response to this command. These values
        /// don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note> 
        /// <para>
        /// To retrieve a list of tasks in a maintenance window, instead use the <a>DescribeMaintenanceWindowTasks</a>
        /// command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask service method.</param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        GetMaintenanceWindowTaskResponse GetMaintenanceWindowTask(GetMaintenanceWindowTaskRequest request);



        /// <summary>
        /// Retrieves the details of a maintenance window task.
        /// 
        ///  <note> 
        /// <para>
        /// For maintenance window tasks without a specified target, you can't supply values for
        /// <c>--max-errors</c> and <c>--max-concurrency</c>. Instead, the system inserts a placeholder
        /// value of <c>1</c>, which may be reported in the response to this command. These values
        /// don't affect the running of your task and can be ignored.
        /// </para>
        ///  </note> 
        /// <para>
        /// To retrieve a list of tasks in a maintenance window, instead use the <a>DescribeMaintenanceWindowTasks</a>
        /// command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMaintenanceWindowTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetMaintenanceWindowTask">REST API Reference for GetMaintenanceWindowTask Operation</seealso>
        Task<GetMaintenanceWindowTaskResponse> GetMaintenanceWindowTaskAsync(GetMaintenanceWindowTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOpsItem


        /// <summary>
        /// Get information about an OpsItem by using the ID. You must have permission in Identity
        /// and Access Management (IAM) to view information about an OpsItem. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsItem service method.</param>
        /// 
        /// <returns>The response from the GetOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        GetOpsItemResponse GetOpsItem(GetOpsItemRequest request);



        /// <summary>
        /// Get information about an OpsItem by using the ID. You must have permission in Identity
        /// and Access Management (IAM) to view information about an OpsItem. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsItem">REST API Reference for GetOpsItem Operation</seealso>
        Task<GetOpsItemResponse> GetOpsItemAsync(GetOpsItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOpsMetadata


        /// <summary>
        /// View operational metadata related to an application in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the GetOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        GetOpsMetadataResponse GetOpsMetadata(GetOpsMetadataRequest request);



        /// <summary>
        /// View operational metadata related to an application in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsMetadata">REST API Reference for GetOpsMetadata Operation</seealso>
        Task<GetOpsMetadataResponse> GetOpsMetadataAsync(GetOpsMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOpsSummary


        /// <summary>
        /// View a summary of operations metadata (OpsData) based on specified filters and aggregators.
        /// OpsData can include information about Amazon Web Services Systems Manager OpsCenter
        /// operational workitems (OpsItems) as well as information about any Amazon Web Services
        /// resource or service configured to report OpsData to Amazon Web Services Systems Manager
        /// Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsSummary service method.</param>
        /// 
        /// <returns>The response from the GetOpsSummary service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <c>AWS:Application</c> or <c>AWS:InstanceInformation</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        GetOpsSummaryResponse GetOpsSummary(GetOpsSummaryRequest request);



        /// <summary>
        /// View a summary of operations metadata (OpsData) based on specified filters and aggregators.
        /// OpsData can include information about Amazon Web Services Systems Manager OpsCenter
        /// operational workitems (OpsItems) as well as information about any Amazon Web Services
        /// resource or service configured to report OpsData to Amazon Web Services Systems Manager
        /// Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpsSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpsSummary service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAggregatorException">
        /// The specified aggregator isn't valid for inventory groups. Verify that the aggregator
        /// uses a valid inventory type such as <c>AWS:Application</c> or <c>AWS:InstanceInformation</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetOpsSummary">REST API Reference for GetOpsSummary Operation</seealso>
        Task<GetOpsSummaryResponse> GetOpsSummaryAsync(GetOpsSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParameter


        /// <summary>
        /// Get information about a single parameter by specifying the parameter name.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about more than one parameter at a time, use the <a>GetParameters</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameter service method.</param>
        /// 
        /// <returns>The response from the GetParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        GetParameterResponse GetParameter(GetParameterRequest request);



        /// <summary>
        /// Get information about a single parameter by specifying the parameter name.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about more than one parameter at a time, use the <a>GetParameters</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameter">REST API Reference for GetParameter Operation</seealso>
        Task<GetParameterResponse> GetParameterAsync(GetParameterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParameterHistory


        /// <summary>
        /// Retrieves the history of all changes to a parameter.
        /// 
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <c>GetParameterHistory</c> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory service method.</param>
        /// 
        /// <returns>The response from the GetParameterHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        GetParameterHistoryResponse GetParameterHistory(GetParameterHistoryRequest request);



        /// <summary>
        /// Retrieves the history of all changes to a parameter.
        /// 
        ///  <important> 
        /// <para>
        /// If you change the KMS key alias for the KMS key used to encrypt a parameter, then
        /// you must also update the key alias the parameter uses to reference KMS. Otherwise,
        /// <c>GetParameterHistory</c> retrieves whatever the original key alias was referencing.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameterHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameterHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameterHistory">REST API Reference for GetParameterHistory Operation</seealso>
        Task<GetParameterHistoryResponse> GetParameterHistoryAsync(GetParameterHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParameters


        /// <summary>
        /// Get information about one or more parameters by specifying multiple parameter names.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about a single parameter, you can use the <a>GetParameter</a> operation
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameters service method.</param>
        /// 
        /// <returns>The response from the GetParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        GetParametersResponse GetParameters(GetParametersRequest request);



        /// <summary>
        /// Get information about one or more parameters by specifying multiple parameter names.
        /// 
        ///  <note> 
        /// <para>
        /// To get information about a single parameter, you can use the <a>GetParameter</a> operation
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParameters service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParameters">REST API Reference for GetParameters Operation</seealso>
        Task<GetParametersResponse> GetParametersAsync(GetParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParametersByPath


        /// <summary>
        /// Retrieve information about one or more parameters in a specific hierarchy. 
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <c>MaxResults</c>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <c>MaxResults</c>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <c>NextToken</c>.
        /// You can specify the <c>NextToken</c> in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath service method.</param>
        /// 
        /// <returns>The response from the GetParametersByPath service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        GetParametersByPathResponse GetParametersByPath(GetParametersByPathRequest request);



        /// <summary>
        /// Retrieve information about one or more parameters in a specific hierarchy. 
        /// 
        ///  
        /// <para>
        /// Request results are returned on a best-effort basis. If you specify <c>MaxResults</c>
        /// in the request, the response includes information up to the limit specified. The number
        /// of items returned, however, can be between zero and the value of <c>MaxResults</c>.
        /// If the service reaches an internal limit while processing the results, it stops the
        /// operation and returns the matching values up to that point and a <c>NextToken</c>.
        /// You can specify the <c>NextToken</c> in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersByPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersByPath service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterOptionException">
        /// The specified filter option isn't valid. Valid options are Equals and BeginsWith.
        /// For Path filter, valid options are Recursive and OneLevel.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterValueException">
        /// The filter value isn't valid. Verify the value and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetParametersByPath">REST API Reference for GetParametersByPath Operation</seealso>
        Task<GetParametersByPathResponse> GetParametersByPathAsync(GetParametersByPathRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPatchBaseline


        /// <summary>
        /// Retrieves information about a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        GetPatchBaselineResponse GetPatchBaseline(GetPatchBaselineRequest request);



        /// <summary>
        /// Retrieves information about a patch baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaseline">REST API Reference for GetPatchBaseline Operation</seealso>
        Task<GetPatchBaselineResponse> GetPatchBaselineAsync(GetPatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPatchBaselineForPatchGroup


        /// <summary>
        /// Retrieves the patch baseline that should be used for the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the GetPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        GetPatchBaselineForPatchGroupResponse GetPatchBaselineForPatchGroup(GetPatchBaselineForPatchGroupRequest request);



        /// <summary>
        /// Retrieves the patch baseline that should be used for the specified patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetPatchBaselineForPatchGroup">REST API Reference for GetPatchBaselineForPatchGroup Operation</seealso>
        Task<GetPatchBaselineForPatchGroupResponse> GetPatchBaselineForPatchGroupAsync(GetPatchBaselineForPatchGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicies


        /// <summary>
        /// Returns an array of the <c>Policy</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request);



        /// <summary>
        /// Returns an array of the <c>Policy</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceSetting


        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of <c>false</c>. This means the user can't use this feature
        /// unless they change the setting to <c>true</c> and intentionally opt in for a paid
        /// feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>UpdateServiceSetting</a> API operation to change
        /// the default setting. Or use the <a>ResetServiceSetting</a> to change the value back
        /// to the original value defined by the Amazon Web Services service team.
        /// </para>
        ///  
        /// <para>
        /// Query the current service setting for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSetting service method.</param>
        /// 
        /// <returns>The response from the GetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        GetServiceSettingResponse GetServiceSetting(GetServiceSettingRequest request);



        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of <c>false</c>. This means the user can't use this feature
        /// unless they change the setting to <c>true</c> and intentionally opt in for a paid
        /// feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>UpdateServiceSetting</a> API operation to change
        /// the default setting. Or use the <a>ResetServiceSetting</a> to change the value back
        /// to the original value defined by the Amazon Web Services service team.
        /// </para>
        ///  
        /// <para>
        /// Query the current service setting for the Amazon Web Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/GetServiceSetting">REST API Reference for GetServiceSetting Operation</seealso>
        Task<GetServiceSettingResponse> GetServiceSettingAsync(GetServiceSettingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  LabelParameterVersion


        /// <summary>
        /// A parameter label is a user-defined alias to help you manage different versions of
        /// a parameter. When you modify a parameter, Amazon Web Services Systems Manager automatically
        /// saves a new version and increments the version number by one. A label can help you
        /// remember the purpose of a parameter when there are multiple versions. 
        /// 
        ///  
        /// <para>
        /// Parameter labels have the following requirements and restrictions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A version of a parameter can have a maximum of 10 labels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't attach the same label to different versions of the same parameter. For example,
        /// if version 1 has the label Production, then you can't attach Production to version
        /// 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can move a label from one version of a parameter to another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't create a label when you create a new parameter. You must attach a label
        /// to a specific version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you no longer want to use a parameter label, then you can either delete it or move
        /// it to a different version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A label can have a maximum of 100 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can contain letters (case sensitive), numbers, periods (.), hyphens (-), or
        /// underscores (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can't begin with a number, "<c>aws</c>" or "<c>ssm</c>" (not case sensitive).
        /// If a label fails to meet these requirements, then the label isn't associated with
        /// a parameter and the system displays it in the list of InvalidLabels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion service method.</param>
        /// 
        /// <returns>The response from the LabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionLabelLimitExceededException">
        /// A parameter version can have a maximum of ten labels.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        LabelParameterVersionResponse LabelParameterVersion(LabelParameterVersionRequest request);



        /// <summary>
        /// A parameter label is a user-defined alias to help you manage different versions of
        /// a parameter. When you modify a parameter, Amazon Web Services Systems Manager automatically
        /// saves a new version and increments the version number by one. A label can help you
        /// remember the purpose of a parameter when there are multiple versions. 
        /// 
        ///  
        /// <para>
        /// Parameter labels have the following requirements and restrictions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A version of a parameter can have a maximum of 10 labels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't attach the same label to different versions of the same parameter. For example,
        /// if version 1 has the label Production, then you can't attach Production to version
        /// 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can move a label from one version of a parameter to another.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't create a label when you create a new parameter. You must attach a label
        /// to a specific version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you no longer want to use a parameter label, then you can either delete it or move
        /// it to a different version of a parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A label can have a maximum of 100 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can contain letters (case sensitive), numbers, periods (.), hyphens (-), or
        /// underscores (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Labels can't begin with a number, "<c>aws</c>" or "<c>ssm</c>" (not case sensitive).
        /// If a label fails to meet these requirements, then the label isn't associated with
        /// a parameter and the system displays it in the list of InvalidLabels.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LabelParameterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionLabelLimitExceededException">
        /// A parameter version can have a maximum of ten labels.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/LabelParameterVersion">REST API Reference for LabelParameterVersion Operation</seealso>
        Task<LabelParameterVersionResponse> LabelParameterVersionAsync(LabelParameterVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociations


        /// <summary>
        /// Returns all State Manager associations in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results to a specific State Manager
        /// association document or managed node by specifying a filter. State Manager is a capability
        /// of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);



        /// <summary>
        /// Returns all State Manager associations in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results to a specific State Manager
        /// association document or managed node by specifying a filter. State Manager is a capability
        /// of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociationVersions


        /// <summary>
        /// Retrieves all versions of an association for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions service method.</param>
        /// 
        /// <returns>The response from the ListAssociationVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        ListAssociationVersionsResponse ListAssociationVersions(ListAssociationVersionsRequest request);



        /// <summary>
        /// Retrieves all versions of an association for a specific association ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociationVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListAssociationVersions">REST API Reference for ListAssociationVersions Operation</seealso>
        Task<ListAssociationVersionsResponse> ListAssociationVersionsAsync(ListAssociationVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCommandInvocations


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        ListCommandInvocationsResponse ListCommandInvocations();


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        ListCommandInvocationsResponse ListCommandInvocations(string commandId);

        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        ListCommandInvocationsResponse ListCommandInvocations(ListCommandInvocationsRequest request);


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// <param name="commandId">(Optional) The invocations for a specific command ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// An invocation is copy of a command sent to a specific managed node. A command can
        /// apply to one or more managed nodes. A command invocation applies to one managed node.
        /// For example, if a user runs <c>SendCommand</c> against three managed nodes, then a
        /// command invocation is created for each requested managed node ID. <c>ListCommandInvocations</c>
        /// provide status about command execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommandInvocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommandInvocations service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommandInvocations">REST API Reference for ListCommandInvocations Operation</seealso>
        Task<ListCommandInvocationsResponse> ListCommandInvocationsAsync(ListCommandInvocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCommands


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        ListCommandsResponse ListCommands();


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        ListCommandsResponse ListCommands(string commandId);

        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        ListCommandsResponse ListCommands(ListCommandsRequest request);


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        Task<ListCommandsResponse> ListCommandsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="commandId">(Optional) If provided, lists only the specified command.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        Task<ListCommandsResponse> ListCommandsAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Lists the commands requested by users of the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommands service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommands service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidCommandIdException">
        /// The specified command ID isn't valid. Verify the ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListCommands">REST API Reference for ListCommands Operation</seealso>
        Task<ListCommandsResponse> ListCommandsAsync(ListCommandsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComplianceItems


        /// <summary>
        /// For a specified resource ID, this API operation returns a list of compliance statuses
        /// for different resource types. Currently, you can only specify one resource ID per
        /// call. List results depend on the criteria specified in the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems service method.</param>
        /// 
        /// <returns>The response from the ListComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        ListComplianceItemsResponse ListComplianceItems(ListComplianceItemsRequest request);



        /// <summary>
        /// For a specified resource ID, this API operation returns a list of compliance statuses
        /// for different resource types. Currently, you can only specify one resource ID per
        /// call. List results depend on the criteria specified in the filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceItems">REST API Reference for ListComplianceItems Operation</seealso>
        Task<ListComplianceItemsResponse> ListComplianceItemsAsync(ListComplianceItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComplianceSummaries


        /// <summary>
        /// Returns a summary count of compliant and non-compliant resources for a compliance
        /// type. For example, this call can return State Manager associations, patches, or custom
        /// compliance types according to the filter criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries service method.</param>
        /// 
        /// <returns>The response from the ListComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        ListComplianceSummariesResponse ListComplianceSummaries(ListComplianceSummariesRequest request);



        /// <summary>
        /// Returns a summary count of compliant and non-compliant resources for a compliance
        /// type. For example, this call can return State Manager associations, patches, or custom
        /// compliance types according to the filter criteria that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListComplianceSummaries">REST API Reference for ListComplianceSummaries Operation</seealso>
        Task<ListComplianceSummariesResponse> ListComplianceSummariesAsync(ListComplianceSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDocumentMetadataHistory


        /// <summary>
        /// Information about approval reviews for a version of a change template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentMetadataHistory service method.</param>
        /// 
        /// <returns>The response from the ListDocumentMetadataHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        ListDocumentMetadataHistoryResponse ListDocumentMetadataHistory(ListDocumentMetadataHistoryRequest request);



        /// <summary>
        /// Information about approval reviews for a version of a change template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentMetadataHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentMetadataHistory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentMetadataHistory">REST API Reference for ListDocumentMetadataHistory Operation</seealso>
        Task<ListDocumentMetadataHistoryResponse> ListDocumentMetadataHistoryAsync(ListDocumentMetadataHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDocuments


        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        ListDocumentsResponse ListDocuments();


        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        ListDocumentsResponse ListDocuments(ListDocumentsRequest request);


        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        Task<ListDocumentsResponse> ListDocumentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
        /// and Amazon Web Services Region. You can limit the results of this request by using
        /// a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterKeyException">
        /// The specified key isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDocumentVersions


        /// <summary>
        /// List all versions for a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions service method.</param>
        /// 
        /// <returns>The response from the ListDocumentVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        ListDocumentVersionsResponse ListDocumentVersions(ListDocumentVersionsRequest request);



        /// <summary>
        /// List all versions for a document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentVersions service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListDocumentVersions">REST API Reference for ListDocumentVersions Operation</seealso>
        Task<ListDocumentVersionsResponse> ListDocumentVersionsAsync(ListDocumentVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInventoryEntries


        /// <summary>
        /// A list of inventory items returned by the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries service method.</param>
        /// 
        /// <returns>The response from the ListInventoryEntries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request);



        /// <summary>
        /// A list of inventory items returned by the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInventoryEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInventoryEntries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListInventoryEntries">REST API Reference for ListInventoryEntries Operation</seealso>
        Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOpsItemEvents


        /// <summary>
        /// Returns a list of all OpsItem events in the current Amazon Web Services Region and
        /// Amazon Web Services account. You can limit the results to events associated with specific
        /// OpsItems by specifying a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemEvents service method.</param>
        /// 
        /// <returns>The response from the ListOpsItemEvents service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemEvents">REST API Reference for ListOpsItemEvents Operation</seealso>
        ListOpsItemEventsResponse ListOpsItemEvents(ListOpsItemEventsRequest request);



        /// <summary>
        /// Returns a list of all OpsItem events in the current Amazon Web Services Region and
        /// Amazon Web Services account. You can limit the results to events associated with specific
        /// OpsItems by specifying a filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpsItemEvents service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemEvents">REST API Reference for ListOpsItemEvents Operation</seealso>
        Task<ListOpsItemEventsResponse> ListOpsItemEventsAsync(ListOpsItemEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOpsItemRelatedItems


        /// <summary>
        /// Lists all related-item resources associated with a Systems Manager OpsCenter OpsItem.
        /// OpsCenter is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemRelatedItems service method.</param>
        /// 
        /// <returns>The response from the ListOpsItemRelatedItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemRelatedItems">REST API Reference for ListOpsItemRelatedItems Operation</seealso>
        ListOpsItemRelatedItemsResponse ListOpsItemRelatedItems(ListOpsItemRelatedItemsRequest request);



        /// <summary>
        /// Lists all related-item resources associated with a Systems Manager OpsCenter OpsItem.
        /// OpsCenter is a capability of Amazon Web Services Systems Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsItemRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpsItemRelatedItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsItemRelatedItems">REST API Reference for ListOpsItemRelatedItems Operation</seealso>
        Task<ListOpsItemRelatedItemsResponse> ListOpsItemRelatedItemsAsync(ListOpsItemRelatedItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOpsMetadata


        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when displaying all Application
        /// Manager OpsMetadata objects or blobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the ListOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        ListOpsMetadataResponse ListOpsMetadata(ListOpsMetadataRequest request);



        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when displaying all Application
        /// Manager OpsMetadata objects or blobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListOpsMetadata">REST API Reference for ListOpsMetadata Operation</seealso>
        Task<ListOpsMetadataResponse> ListOpsMetadataAsync(ListOpsMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceComplianceSummaries


        /// <summary>
        /// Returns a resource-level summary count. The summary includes information about compliant
        /// and non-compliant statuses and detailed compliance-item severity counts, according
        /// to the filter criteria you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries service method.</param>
        /// 
        /// <returns>The response from the ListResourceComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        ListResourceComplianceSummariesResponse ListResourceComplianceSummaries(ListResourceComplianceSummariesRequest request);



        /// <summary>
        /// Returns a resource-level summary count. The summary includes information about compliant
        /// and non-compliant statuses and detailed compliance-item severity counts, according
        /// to the filter criteria you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceComplianceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceComplianceSummaries service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidFilterException">
        /// The filter name isn't valid. Verify the you entered the correct name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceComplianceSummaries">REST API Reference for ListResourceComplianceSummaries Operation</seealso>
        Task<ListResourceComplianceSummariesResponse> ListResourceComplianceSummariesAsync(ListResourceComplianceSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourceDataSync


        /// <summary>
        /// Lists your resource data sync configurations. Includes information about the last
        /// time a sync attempted to start, the last sync status, and the last time a sync successfully
        /// completed.
        /// 
        ///  
        /// <para>
        /// The number of sync configurations might be too large to return using a single call
        /// to <c>ListResourceDataSync</c>. You can limit the number of sync configurations returned
        /// by using the <c>MaxResults</c> parameter. To determine whether there are more sync
        /// configurations to list, check the value of <c>NextToken</c> in the output. If there
        /// are more sync configurations to list, you can request them by specifying the <c>NextToken</c>
        /// returned in the call to the parameter of a subsequent call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDataSync service method.</param>
        /// 
        /// <returns>The response from the ListResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        ListResourceDataSyncResponse ListResourceDataSync(ListResourceDataSyncRequest request);



        /// <summary>
        /// Lists your resource data sync configurations. Includes information about the last
        /// time a sync attempted to start, the last sync status, and the last time a sync successfully
        /// completed.
        /// 
        ///  
        /// <para>
        /// The number of sync configurations might be too large to return using a single call
        /// to <c>ListResourceDataSync</c>. You can limit the number of sync configurations returned
        /// by using the <c>MaxResults</c> parameter. To determine whether there are more sync
        /// configurations to list, check the value of <c>NextToken</c> in the output. If there
        /// are more sync configurations to list, you can request them by specifying the <c>NextToken</c>
        /// returned in the call to the parameter of a subsequent call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNextTokenException">
        /// The specified token isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListResourceDataSync">REST API Reference for ListResourceDataSync Operation</seealso>
        Task<ListResourceDataSyncResponse> ListResourceDataSyncAsync(ListResourceDataSyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// 
        ///  
        /// <para>
        /// For information about the ID format for each supported resource type, see <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// 
        ///  
        /// <para>
        /// For information about the ID format for each supported resource type, see <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyDocumentPermission


        /// <summary>
        /// Shares a Amazon Web Services Systems Manager document (SSM document)publicly or privately.
        /// If you share a document privately, you must specify the Amazon Web Services user IDs
        /// for those people who can use the document. If you share a document publicly, you must
        /// specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentPermissionLimitException">
        /// The document can't be shared with more Amazon Web Services accounts. You can specify
        /// a maximum of 20 accounts per API operation to share a private document.
        /// 
        ///  
        /// <para>
        /// By default, you can share a private document with a maximum of 1,000 accounts and
        /// publicly share up to five documents.
        /// </para>
        ///  
        /// <para>
        /// If you need to increase the quota for privately or publicly shared Systems Manager
        /// documents, contact Amazon Web Services Support.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        ModifyDocumentPermissionResponse ModifyDocumentPermission(ModifyDocumentPermissionRequest request);



        /// <summary>
        /// Shares a Amazon Web Services Systems Manager document (SSM document)publicly or privately.
        /// If you share a document privately, you must specify the Amazon Web Services user IDs
        /// for those people who can use the document. If you share a document publicly, you must
        /// specify <i>All</i> as the account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDocumentPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDocumentPermission service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentLimitExceededException">
        /// You can have at most 500 active SSM documents.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentPermissionLimitException">
        /// The document can't be shared with more Amazon Web Services accounts. You can specify
        /// a maximum of 20 accounts per API operation to share a private document.
        /// 
        ///  
        /// <para>
        /// By default, you can share a private document with a maximum of 1,000 accounts and
        /// publicly share up to five documents.
        /// </para>
        ///  
        /// <para>
        /// If you need to increase the quota for privately or publicly shared Systems Manager
        /// documents, contact Amazon Web Services Support.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPermissionTypeException">
        /// The permission type isn't supported. <i>Share</i> is the only supported permission
        /// type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ModifyDocumentPermission">REST API Reference for ModifyDocumentPermission Operation</seealso>
        Task<ModifyDocumentPermissionResponse> ModifyDocumentPermissionAsync(ModifyDocumentPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutComplianceItems


        /// <summary>
        /// Registers a compliance type and other compliance details on a designated resource.
        /// This operation lets you register custom compliance details with a resource. This call
        /// overwrites existing compliance information on the resource, so you must provide a
        /// full list of compliance items each time that you send the request.
        /// 
        ///  
        /// <para>
        /// ComplianceType can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ExecutionId: The execution ID when the patch, association, or custom compliance item
        /// was applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionType: Specify patch, association, or Custom:<c>string</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionTime. The time the patch, association, or custom compliance item was applied
        /// to the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Id: The patch, association, or custom compliance ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Title: A title.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status: The status of the compliance item. For example, <c>approved</c> for patches,
        /// or <c>Failed</c> for associations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Severity: A patch severity. For example, <c>Critical</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentName: An SSM document name. For example, <c>AWS-RunPatchBaseline</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentVersion: An SSM document version number. For example, 4.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classification: A patch classification. For example, <c>security updates</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchBaselineId: A patch baseline ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchSeverity: A patch severity. For example, <c>Critical</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchState: A patch state. For example, <c>InstancesWithFailedPatches</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchGroup: The name of a patch group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstalledTime: The time the association, patch, or custom compliance item was applied
        /// to the resource. Specify the time by using the following format: <c>yyyy-MM-dd'T'HH:mm:ss'Z'</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceItems service method.</param>
        /// 
        /// <returns>The response from the PutComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ComplianceTypeCountLimitExceededException">
        /// You specified too many custom compliance types. You can specify a maximum of 10 different
        /// types.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        PutComplianceItemsResponse PutComplianceItems(PutComplianceItemsRequest request);



        /// <summary>
        /// Registers a compliance type and other compliance details on a designated resource.
        /// This operation lets you register custom compliance details with a resource. This call
        /// overwrites existing compliance information on the resource, so you must provide a
        /// full list of compliance items each time that you send the request.
        /// 
        ///  
        /// <para>
        /// ComplianceType can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ExecutionId: The execution ID when the patch, association, or custom compliance item
        /// was applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionType: Specify patch, association, or Custom:<c>string</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionTime. The time the patch, association, or custom compliance item was applied
        /// to the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Id: The patch, association, or custom compliance ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Title: A title.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status: The status of the compliance item. For example, <c>approved</c> for patches,
        /// or <c>Failed</c> for associations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Severity: A patch severity. For example, <c>Critical</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentName: An SSM document name. For example, <c>AWS-RunPatchBaseline</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DocumentVersion: An SSM document version number. For example, 4.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classification: A patch classification. For example, <c>security updates</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchBaselineId: A patch baseline ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchSeverity: A patch severity. For example, <c>Critical</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchState: A patch state. For example, <c>InstancesWithFailedPatches</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PatchGroup: The name of a patch group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InstalledTime: The time the association, patch, or custom compliance item was applied
        /// to the resource. Specify the time by using the following format: <c>yyyy-MM-dd'T'HH:mm:ss'Z'</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutComplianceItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutComplianceItems service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ComplianceTypeCountLimitExceededException">
        /// You specified too many custom compliance types. You can specify a maximum of 10 different
        /// types.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutComplianceItems">REST API Reference for PutComplianceItems Operation</seealso>
        Task<PutComplianceItemsResponse> PutComplianceItemsAsync(PutComplianceItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutInventory


        /// <summary>
        /// Bulk update custom inventory items on one or more managed nodes. The request adds
        /// an inventory item, if it doesn't already exist, or updates an inventory item, if it
        /// does exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInventory service method.</param>
        /// 
        /// <returns>The response from the PutInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.CustomSchemaCountLimitExceededException">
        /// You have exceeded the limit for custom schemas. Delete one or more custom schemas
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryItemContextException">
        /// You specified invalid keys or values in the <c>Context</c> attribute for <c>InventoryItem</c>.
        /// Verify the keys and values, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemContentMismatchException">
        /// The inventory item has invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.SubTypeCountLimitExceededException">
        /// The sub-type count exceeded the limit for the inventory type.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventoryItemContextException">
        /// The <c>Context</c> attribute that you specified for the <c>InventoryItem</c> isn't
        /// allowed for this inventory type. You can only use the <c>Context</c> attribute with
        /// inventory types like <c>AWS:ComplianceItem</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventorySchemaVersionException">
        /// Inventory item type schema version has to match supported versions in the service.
        /// Check output of GetInventorySchema to see the available schema version for each type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        PutInventoryResponse PutInventory(PutInventoryRequest request);



        /// <summary>
        /// Bulk update custom inventory items on one or more managed nodes. The request adds
        /// an inventory item, if it doesn't already exist, or updates an inventory item, if it
        /// does exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutInventory service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.CustomSchemaCountLimitExceededException">
        /// You have exceeded the limit for custom schemas. Delete one or more custom schemas
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInventoryItemContextException">
        /// You specified invalid keys or values in the <c>Context</c> attribute for <c>InventoryItem</c>.
        /// Verify the keys and values, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidItemContentException">
        /// One or more content items isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTypeNameException">
        /// The parameter type name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemContentMismatchException">
        /// The inventory item has invalid content.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ItemSizeLimitExceededException">
        /// The inventory item size has exceeded the size limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.SubTypeCountLimitExceededException">
        /// The sub-type count exceeded the limit for the inventory type.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TotalSizeLimitExceededException">
        /// The size of inventory data has exceeded the total size limit for the resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventoryItemContextException">
        /// The <c>Context</c> attribute that you specified for the <c>InventoryItem</c> isn't
        /// allowed for this inventory type. You can only use the <c>Context</c> attribute with
        /// inventory types like <c>AWS:ComplianceItem</c>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedInventorySchemaVersionException">
        /// Inventory item type schema version has to match supported versions in the service.
        /// Check output of GetInventorySchema to see the available schema version for each type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutInventory">REST API Reference for PutInventory Operation</seealso>
        Task<PutInventoryResponse> PutInventoryAsync(PutInventoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutParameter


        /// <summary>
        /// Add a parameter to the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutParameter service method.</param>
        /// 
        /// <returns>The response from the PutParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyLevelLimitExceededException">
        /// A hierarchy can have a maximum of 15 levels. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-parameter-name-constraints.html">Requirements
        /// and constraints for parameter names</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyTypeMismatchException">
        /// Parameter Store doesn't support changing a parameter type in a hierarchy. For example,
        /// you can't change a parameter from a <c>String</c> type to a <c>SecureString</c> type.
        /// You must create a new, unique parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IncompatiblePolicyException">
        /// There is a conflict in the policies specified for this parameter. You can't, for example,
        /// specify two Expiration policies for a parameter. Review your policies, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAllowedPatternException">
        /// The request doesn't meet the regular expression requirement.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyAttributeException">
        /// A policy attribute or its value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyTypeException">
        /// The policy type isn't supported. Parameter Store supports the following policy types:
        /// Expiration, ExpirationNotification, and NoChangeNotification.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterAlreadyExistsException">
        /// The parameter already exists. You can't create duplicate parameters.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterLimitExceededException">
        /// You have exceeded the number of parameters for this Amazon Web Services account. Delete
        /// one or more parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterMaxVersionLimitExceededException">
        /// Parameter Store retains the 100 most recently created versions of a parameter. After
        /// this number of versions has been created, Parameter Store deletes the oldest version
        /// when a new one is created. However, if the oldest version has a <i>label</i> attached
        /// to it, Parameter Store won't delete the version and instead presents this error message:
        /// 
        ///  
        /// <para>
        ///  <c>An error occurred (ParameterMaxVersionLimitExceeded) when calling the PutParameter
        /// operation: You attempted to create a new version of <i>parameter-name</i> by calling
        /// the PutParameter API with the overwrite flag. Version <i>version-number</i>, the oldest
        /// version, can't be deleted because it has a label associated with it. Move the label
        /// to another version of the parameter, and try again.</c> 
        /// </para>
        ///  
        /// <para>
        /// This safeguard is to prevent parameter versions with mission critical labels assigned
        /// to them from being deleted. To continue creating new parameters, first move the label
        /// from the oldest version of the parameter to a newer one for use in your operations.
        /// For information about moving parameter labels, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-console-move">Move
        /// a parameter label (console)</a> or <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-cli-move">Move
        /// a parameter label (CLI)</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterPatternMismatchException">
        /// The parameter name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.PoliciesLimitExceededException">
        /// You specified more than the maximum number of allowed policies for the parameter.
        /// The maximum is 10.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedParameterTypeException">
        /// The parameter type isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        PutParameterResponse PutParameter(PutParameterRequest request);



        /// <summary>
        /// Add a parameter to the system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutParameter service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyLevelLimitExceededException">
        /// A hierarchy can have a maximum of 15 levels. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-parameter-name-constraints.html">Requirements
        /// and constraints for parameter names</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.HierarchyTypeMismatchException">
        /// Parameter Store doesn't support changing a parameter type in a hierarchy. For example,
        /// you can't change a parameter from a <c>String</c> type to a <c>SecureString</c> type.
        /// You must create a new, unique parameter.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IncompatiblePolicyException">
        /// There is a conflict in the policies specified for this parameter. You can't, for example,
        /// specify two Expiration policies for a parameter. Review your policies, and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAllowedPatternException">
        /// The request doesn't meet the regular expression requirement.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidKeyIdException">
        /// The query key ID isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyAttributeException">
        /// A policy attribute or its value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidPolicyTypeException">
        /// The policy type isn't supported. Parameter Store supports the following policy types:
        /// Expiration, ExpirationNotification, and NoChangeNotification.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterAlreadyExistsException">
        /// The parameter already exists. You can't create duplicate parameters.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterLimitExceededException">
        /// You have exceeded the number of parameters for this Amazon Web Services account. Delete
        /// one or more parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterMaxVersionLimitExceededException">
        /// Parameter Store retains the 100 most recently created versions of a parameter. After
        /// this number of versions has been created, Parameter Store deletes the oldest version
        /// when a new one is created. However, if the oldest version has a <i>label</i> attached
        /// to it, Parameter Store won't delete the version and instead presents this error message:
        /// 
        ///  
        /// <para>
        ///  <c>An error occurred (ParameterMaxVersionLimitExceeded) when calling the PutParameter
        /// operation: You attempted to create a new version of <i>parameter-name</i> by calling
        /// the PutParameter API with the overwrite flag. Version <i>version-number</i>, the oldest
        /// version, can't be deleted because it has a label associated with it. Move the label
        /// to another version of the parameter, and try again.</c> 
        /// </para>
        ///  
        /// <para>
        /// This safeguard is to prevent parameter versions with mission critical labels assigned
        /// to them from being deleted. To continue creating new parameters, first move the label
        /// from the oldest version of the parameter to a newer one for use in your operations.
        /// For information about moving parameter labels, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-console-move">Move
        /// a parameter label (console)</a> or <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-paramstore-labels.html#sysman-paramstore-labels-cli-move">Move
        /// a parameter label (CLI)</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterPatternMismatchException">
        /// The parameter name isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.PoliciesLimitExceededException">
        /// You specified more than the maximum number of allowed policies for the parameter.
        /// The maximum is 10.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedParameterTypeException">
        /// The parameter type isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutParameter">REST API Reference for PutParameter Operation</seealso>
        Task<PutParameterResponse> PutParameterAsync(PutParameterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a Systems Manager resource policy. A resource policy helps you
        /// to define the IAM entity (for example, an Amazon Web Services account) that can manage
        /// your Systems Manager resources. The following resources support Systems Manager resource
        /// policies.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
        /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
        /// using Resource Access Manager (RAM). 
        /// </para>
        ///  
        /// <para>
        /// To share a parameter, it must be in the advanced parameter tier. For information about
        /// parameter tiers, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html">Managing
        /// parameter tiers</a>. For information about changing an existing standard parameter
        /// to an advanced parameter, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html#parameter-store-advanced-parameters-enabling">Changing
        /// a standard parameter to an advanced parameter</a>.
        /// </para>
        ///  
        /// <para>
        /// To share a <c>SecureString</c> parameter, it must be encrypted with a customer managed
        /// key, and you must share the key separately through Key Management Service. Amazon
        /// Web Services managed keys cannot be shared. Parameters encrypted with the default
        /// Amazon Web Services managed key can be updated to use a customer managed key instead.
        /// For KMS key definitions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">KMS
        /// concepts</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// While you can share a parameter using the Systems Manager <c>PutResourcePolicy</c>
        /// operation, we recommend using Resource Access Manager (RAM) instead. This is because
        /// using <c>PutResourcePolicy</c> requires the extra step of promoting the parameter
        /// to a standard RAM Resource Share using the RAM <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// API operation. Otherwise, the parameter won't be returned by the Systems Manager <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html">DescribeParameters</a>
        /// API operation using the <c>--shared</c> option.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html#share">Sharing
        /// a parameter</a> in the <i>Amazon Web Services Systems Manager User Guide</i> 
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MalformedResourcePolicyDocumentException">
        /// The specified policy document is malformed or invalid, or excessive <c>PutResourcePolicy</c>
        /// or <c>DeleteResourcePolicy</c> calls have been made.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyLimitExceededException">
        /// The <a>PutResourcePolicy</a> API action enforces two limits. A policy can't be greater
        /// than 1024 bytes in size. And only one policy can be attached to <c>OpsItemGroup</c>.
        /// Verify these limits and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyNotFoundException">
        /// No policies with the specified policy ID and hash could be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Creates or updates a Systems Manager resource policy. A resource policy helps you
        /// to define the IAM entity (for example, an Amazon Web Services account) that can manage
        /// your Systems Manager resources. The following resources support Systems Manager resource
        /// policies.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
        /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
        /// using Resource Access Manager (RAM). 
        /// </para>
        ///  
        /// <para>
        /// To share a parameter, it must be in the advanced parameter tier. For information about
        /// parameter tiers, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html">Managing
        /// parameter tiers</a>. For information about changing an existing standard parameter
        /// to an advanced parameter, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html#parameter-store-advanced-parameters-enabling">Changing
        /// a standard parameter to an advanced parameter</a>.
        /// </para>
        ///  
        /// <para>
        /// To share a <c>SecureString</c> parameter, it must be encrypted with a customer managed
        /// key, and you must share the key separately through Key Management Service. Amazon
        /// Web Services managed keys cannot be shared. Parameters encrypted with the default
        /// Amazon Web Services managed key can be updated to use a customer managed key instead.
        /// For KMS key definitions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">KMS
        /// concepts</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// While you can share a parameter using the Systems Manager <c>PutResourcePolicy</c>
        /// operation, we recommend using Resource Access Manager (RAM) instead. This is because
        /// using <c>PutResourcePolicy</c> requires the extra step of promoting the parameter
        /// to a standard RAM Resource Share using the RAM <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// API operation. Otherwise, the parameter won't be returned by the Systems Manager <a
        /// href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html">DescribeParameters</a>
        /// API operation using the <c>--shared</c> option.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html#share">Sharing
        /// a parameter</a> in the <i>Amazon Web Services Systems Manager User Guide</i> 
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MalformedResourcePolicyDocumentException">
        /// The specified policy document is malformed or invalid, or excessive <c>PutResourcePolicy</c>
        /// or <c>DeleteResourcePolicy</c> calls have been made.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceNotFoundException">
        /// The specified parameter to be shared could not be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyConflictException">
        /// The hash provided in the call doesn't match the stored hash. This exception is thrown
        /// when trying to update an obsolete policy version or when multiple requests to update
        /// a policy are sent.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyInvalidParameterException">
        /// One or more parameters specified for the call aren't valid. Verify the parameters
        /// and their values and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyLimitExceededException">
        /// The <a>PutResourcePolicy</a> API action enforces two limits. A policy can't be greater
        /// than 1024 bytes in size. And only one policy can be attached to <c>OpsItemGroup</c>.
        /// Verify these limits and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourcePolicyNotFoundException">
        /// No policies with the specified policy ID and hash could be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterDefaultPatchBaseline


        /// <summary>
        /// Defines the default patch baseline for the relevant operating system.
        /// 
        ///  
        /// <para>
        /// To reset the Amazon Web Services-predefined patch baseline as the default, specify
        /// the full patch baseline Amazon Resource Name (ARN) as the baseline ID value. For example,
        /// for CentOS, specify <c>arn:aws:ssm:us-east-2:733109147000:patchbaseline/pb-0574b43a65ea646ed</c>
        /// instead of <c>pb-0574b43a65ea646ed</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline service method.</param>
        /// 
        /// <returns>The response from the RegisterDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        RegisterDefaultPatchBaselineResponse RegisterDefaultPatchBaseline(RegisterDefaultPatchBaselineRequest request);



        /// <summary>
        /// Defines the default patch baseline for the relevant operating system.
        /// 
        ///  
        /// <para>
        /// To reset the Amazon Web Services-predefined patch baseline as the default, specify
        /// the full patch baseline Amazon Resource Name (ARN) as the baseline ID value. For example,
        /// for CentOS, specify <c>arn:aws:ssm:us-east-2:733109147000:patchbaseline/pb-0574b43a65ea646ed</c>
        /// instead of <c>pb-0574b43a65ea646ed</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDefaultPatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDefaultPatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterDefaultPatchBaseline">REST API Reference for RegisterDefaultPatchBaseline Operation</seealso>
        Task<RegisterDefaultPatchBaselineResponse> RegisterDefaultPatchBaselineAsync(RegisterDefaultPatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterPatchBaselineForPatchGroup


        /// <summary>
        /// Registers a patch baseline for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup service method.</param>
        /// 
        /// <returns>The response from the RegisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AlreadyExistsException">
        /// Error returned if an attempt is made to register a patch group with a patch baseline
        /// that is already registered with a different patch baseline.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        RegisterPatchBaselineForPatchGroupResponse RegisterPatchBaselineForPatchGroup(RegisterPatchBaselineForPatchGroupRequest request);



        /// <summary>
        /// Registers a patch baseline for a patch group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterPatchBaselineForPatchGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterPatchBaselineForPatchGroup service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AlreadyExistsException">
        /// Error returned if an attempt is made to register a patch group with a patch baseline
        /// that is already registered with a different patch baseline.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterPatchBaselineForPatchGroup">REST API Reference for RegisterPatchBaselineForPatchGroup Operation</seealso>
        Task<RegisterPatchBaselineForPatchGroupResponse> RegisterPatchBaselineForPatchGroupAsync(RegisterPatchBaselineForPatchGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterTargetWithMaintenanceWindow


        /// <summary>
        /// Registers a target with a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTargetWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        RegisterTargetWithMaintenanceWindowResponse RegisterTargetWithMaintenanceWindow(RegisterTargetWithMaintenanceWindowRequest request);



        /// <summary>
        /// Registers a target with a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargetWithMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTargetWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTargetWithMaintenanceWindow">REST API Reference for RegisterTargetWithMaintenanceWindow Operation</seealso>
        Task<RegisterTargetWithMaintenanceWindowResponse> RegisterTargetWithMaintenanceWindowAsync(RegisterTargetWithMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterTaskWithMaintenanceWindow


        /// <summary>
        /// Adds a new task to a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the RegisterTaskWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.FeatureNotAvailableException">
        /// You attempted to register a <c>LAMBDA</c> or <c>STEP_FUNCTIONS</c> task in a region
        /// where the corresponding service isn't available.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        RegisterTaskWithMaintenanceWindowResponse RegisterTaskWithMaintenanceWindow(RegisterTaskWithMaintenanceWindowRequest request);



        /// <summary>
        /// Adds a new task to a maintenance window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTaskWithMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTaskWithMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.FeatureNotAvailableException">
        /// You attempted to register a <c>LAMBDA</c> or <c>STEP_FUNCTIONS</c> task in a region
        /// where the corresponding service isn't available.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceLimitExceededException">
        /// Error returned when the caller has exceeded the default resource quotas. For example,
        /// too many maintenance windows or patch baselines have been created.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Systems Manager, see <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RegisterTaskWithMaintenanceWindow">REST API Reference for RegisterTaskWithMaintenanceWindow Operation</seealso>
        Task<RegisterTaskWithMaintenanceWindowResponse> RegisterTaskWithMaintenanceWindowAsync(RegisterTaskWithMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes tag keys from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);



        /// <summary>
        /// Removes tag keys from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceIdException">
        /// The resource ID isn't valid. Verify that you entered the correct ID and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidResourceTypeException">
        /// The resource type isn't valid. For example, if you are attempting to tag an EC2 instance,
        /// the instance must be a registered managed node.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetServiceSetting


        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of "false". This means the user can't use this feature unless
        /// they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API operation to view
        /// the current value. Use the <a>UpdateServiceSetting</a> API operation to change the
        /// default setting. 
        /// </para>
        ///  
        /// <para>
        /// Reset the service setting for the account to the default value as provisioned by the
        /// Amazon Web Services service team. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSetting service method.</param>
        /// 
        /// <returns>The response from the ResetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        ResetServiceSettingResponse ResetServiceSetting(ResetServiceSettingRequest request);



        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of "false". This means the user can't use this feature unless
        /// they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API operation to view
        /// the current value. Use the <a>UpdateServiceSetting</a> API operation to change the
        /// default setting. 
        /// </para>
        ///  
        /// <para>
        /// Reset the service setting for the account to the default value as provisioned by the
        /// Amazon Web Services service team. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResetServiceSetting">REST API Reference for ResetServiceSetting Operation</seealso>
        Task<ResetServiceSettingResponse> ResetServiceSettingAsync(ResetServiceSettingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResumeSession


        /// <summary>
        /// Reconnects a session to a managed node after it has been disconnected. Connections
        /// can be resumed for disconnected sessions, but not terminated sessions.
        /// 
        ///  <note> 
        /// <para>
        /// This command is primarily for use by client machines to automatically reconnect during
        /// intermittent network issues. It isn't intended for any other use.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession service method.</param>
        /// 
        /// <returns>The response from the ResumeSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        ResumeSessionResponse ResumeSession(ResumeSessionRequest request);



        /// <summary>
        /// Reconnects a session to a managed node after it has been disconnected. Connections
        /// can be resumed for disconnected sessions, but not terminated sessions.
        /// 
        ///  <note> 
        /// <para>
        /// This command is primarily for use by client machines to automatically reconnect during
        /// intermittent network issues. It isn't intended for any other use.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/ResumeSession">REST API Reference for ResumeSession Operation</seealso>
        Task<ResumeSessionResponse> ResumeSessionAsync(ResumeSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendAutomationSignal


        /// <summary>
        /// Sends a signal to an Automation execution to change the current behavior or status
        /// of the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal service method.</param>
        /// 
        /// <returns>The response from the SendAutomationSignal service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationStepNotFoundException">
        /// The specified step name and execution ID don't exist. Verify the information and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationSignalException">
        /// The signal isn't valid for the current Automation execution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        SendAutomationSignalResponse SendAutomationSignal(SendAutomationSignalRequest request);



        /// <summary>
        /// Sends a signal to an Automation execution to change the current behavior or status
        /// of the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAutomationSignal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAutomationSignal service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationStepNotFoundException">
        /// The specified step name and execution ID don't exist. Verify the information and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationSignalException">
        /// The signal isn't valid for the current Automation execution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendAutomationSignal">REST API Reference for SendAutomationSignal Operation</seealso>
        Task<SendAutomationSignalResponse> SendAutomationSignalAsync(SendAutomationSignalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendCommand


        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="documentName">The name of the Amazon Web Services Systems Manager document (SSM document) to run. This can be a public document or a custom document. To run a shared document belonging to another account, specify the document Amazon Resource Name (ARN). For more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Sharing SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>. <note> If you specify a document name or ARN that hasn't been shared with your account, you receive an <c>InvalidDocument</c> error.  </note></param>
        /// <param name="instanceIds">The IDs of the managed nodes where the command should run. Specifying managed node IDs is most useful when you are targeting a limited number of managed nodes, though you can specify up to 50 IDs. To target a larger number of managed nodes, or if you prefer not to list individual node IDs, we recommend using the <c>Targets</c> option instead. Using <c>Targets</c>, which accepts tag key-value pairs to identify the managed nodes to send commands to, you can a send command to tens, hundreds, or thousands of nodes at once. For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Run commands at scale</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        SendCommandResponse SendCommand(string documentName, List<string> instanceIds);

        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        SendCommandResponse SendCommand(SendCommandRequest request);


        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="documentName">The name of the Amazon Web Services Systems Manager document (SSM document) to run. This can be a public document or a custom document. To run a shared document belonging to another account, specify the document Amazon Resource Name (ARN). For more information about how to use shared documents, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/ssm-using-shared.html">Sharing SSM documents</a> in the <i>Amazon Web Services Systems Manager User Guide</i>. <note> If you specify a document name or ARN that hasn't been shared with your account, you receive an <c>InvalidDocument</c> error.  </note></param>
        /// <param name="instanceIds">The IDs of the managed nodes where the command should run. Specifying managed node IDs is most useful when you are targeting a limited number of managed nodes, though you can specify up to 50 IDs. To target a larger number of managed nodes, or if you prefer not to list individual node IDs, we recommend using the <c>Targets</c> option instead. Using <c>Targets</c>, which accepts tag key-value pairs to identify the managed nodes to send commands to, you can a send command to tens, hundreds, or thousands of nodes at once. For more information about how to use targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html">Run commands at scale</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        Task<SendCommandResponse> SendCommandAsync(string documentName, List<string> instanceIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Runs commands on one or more managed nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendCommand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendCommand service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateInstanceIdException">
        /// You can't specify a managed node ID in more than one association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidNotificationConfigException">
        /// One or more configuration items isn't valid. Verify that a valid Amazon Resource Name
        /// (ARN) was provided for an Amazon Simple Notification Service topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputFolderException">
        /// The S3 bucket doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidRoleException">
        /// The role name can't contain invalid characters. Also verify that you specified an
        /// IAM role for notifications that includes the required trust policy. For information
        /// about configuring the IAM role for Run Command notifications, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.UnsupportedPlatformTypeException">
        /// The document doesn't support the platform type of the given managed node IDs. For
        /// example, you sent an document for a Windows managed node to a Linux node.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/SendCommand">REST API Reference for SendCommand Operation</seealso>
        Task<SendCommandResponse> SendCommandAsync(SendCommandRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartAssociationsOnce


        /// <summary>
        /// Runs an association immediately and only one time. This operation can be helpful when
        /// troubleshooting associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce service method.</param>
        /// 
        /// <returns>The response from the StartAssociationsOnce service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationException">
        /// The association isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        StartAssociationsOnceResponse StartAssociationsOnce(StartAssociationsOnceRequest request);



        /// <summary>
        /// Runs an association immediately and only one time. This operation can be helpful when
        /// troubleshooting associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssociationsOnce service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAssociationsOnce service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationException">
        /// The association isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAssociationsOnce">REST API Reference for StartAssociationsOnce Operation</seealso>
        Task<StartAssociationsOnceResponse> StartAssociationsOnceAsync(StartAssociationsOnceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartAutomationExecution


        /// <summary>
        /// Initiates execution of an Automation runbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the StartAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        StartAutomationExecutionResponse StartAutomationExecution(StartAutomationExecutionRequest request);



        /// <summary>
        /// Initiates execution of an Automation runbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartAutomationExecution">REST API Reference for StartAutomationExecution Operation</seealso>
        Task<StartAutomationExecutionResponse> StartAutomationExecutionAsync(StartAutomationExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartChangeRequestExecution


        /// <summary>
        /// Creates a change request for Change Manager. The Automation runbooks specified in
        /// the change request run only after all required approvals for the change request have
        /// been received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeRequestExecution service method.</param>
        /// 
        /// <returns>The response from the StartChangeRequestExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotApprovedException">
        /// Indicates that the Change Manager change template used in the change request was rejected
        /// or is still in a pending state.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        StartChangeRequestExecutionResponse StartChangeRequestExecution(StartChangeRequestExecutionRequest request);



        /// <summary>
        /// Creates a change request for Change Manager. The Automation runbooks specified in
        /// the change request run only after all required approvals for the change request have
        /// been received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeRequestExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChangeRequestExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotApprovedException">
        /// Indicates that the Change Manager change template used in the change request was rejected
        /// or is still in a pending state.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionNotFoundException">
        /// An Automation runbook with the specified name couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationDefinitionVersionNotFoundException">
        /// An Automation runbook with the specified name and version couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionLimitExceededException">
        /// The number of simultaneously running Automation executions exceeded the allowable
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.IdempotentParameterMismatchException">
        /// Error returned when an idempotent operation is retried and the parameters don't match
        /// the original call to the API with the same idempotency token.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationExecutionParametersException">
        /// The supplied parameters for invoking the specified Automation runbook are incorrect.
        /// For example, they may not match the set of parameters permitted for the specified
        /// Automation document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartChangeRequestExecution">REST API Reference for StartChangeRequestExecution Operation</seealso>
        Task<StartChangeRequestExecutionResponse> StartChangeRequestExecutionAsync(StartChangeRequestExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSession


        /// <summary>
        /// Initiates a connection to a target (for example, a managed node) for a Session Manager
        /// session. Returns a URL and token that can be used to open a WebSocket connection for
        /// sending input and receiving outputs.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Web Services CLI usage: <c>start-session</c> is an interactive command that
        /// requires the Session Manager plugin to be installed on the client machine making the
        /// call. For information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Install
        /// the Session Manager plugin for the Amazon Web Services CLI</a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Tools for PowerShell usage: Start-SSMSession isn't currently supported
        /// by Amazon Web Services Tools for PowerShell on Windows local machines.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetNotConnectedException">
        /// The specified target managed node for the session isn't fully configured for use with
        /// Session Manager. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-getting-started.html">Getting
        /// started with Session Manager</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>. This error is also returned if you attempt to start a session on a managed
        /// node that is located in a different account or Region
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        StartSessionResponse StartSession(StartSessionRequest request);



        /// <summary>
        /// Initiates a connection to a target (for example, a managed node) for a Session Manager
        /// session. Returns a URL and token that can be used to open a WebSocket connection for
        /// sending input and receiving outputs.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Web Services CLI usage: <c>start-session</c> is an interactive command that
        /// requires the Session Manager plugin to be installed on the client machine making the
        /// call. For information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Install
        /// the Session Manager plugin for the Amazon Web Services CLI</a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Tools for PowerShell usage: Start-SSMSession isn't currently supported
        /// by Amazon Web Services Tools for PowerShell on Windows local machines.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TargetNotConnectedException">
        /// The specified target managed node for the session isn't fully configured for use with
        /// Session Manager. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-getting-started.html">Getting
        /// started with Session Manager</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>. This error is also returned if you attempt to start a session on a managed
        /// node that is located in a different account or Region
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StartSession">REST API Reference for StartSession Operation</seealso>
        Task<StartSessionResponse> StartSessionAsync(StartSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopAutomationExecution


        /// <summary>
        /// Stop an Automation that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution service method.</param>
        /// 
        /// <returns>The response from the StopAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationStatusUpdateException">
        /// The specified update status operation isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        StopAutomationExecutionResponse StopAutomationExecution(StopAutomationExecutionRequest request);



        /// <summary>
        /// Stop an Automation that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAutomationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopAutomationExecution service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AutomationExecutionNotFoundException">
        /// There is no automation execution information for the requested automation execution
        /// ID.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAutomationStatusUpdateException">
        /// The specified update status operation isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/StopAutomationExecution">REST API Reference for StopAutomationExecution Operation</seealso>
        Task<StopAutomationExecutionResponse> StopAutomationExecutionAsync(StopAutomationExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateSession


        /// <summary>
        /// Permanently ends a session and closes the data connection between the Session Manager
        /// client and SSM Agent on the managed node. A terminated session can't be resumed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        TerminateSessionResponse TerminateSession(TerminateSessionRequest request);



        /// <summary>
        /// Permanently ends a session and closes the data connection between the Session Manager
        /// client and SSM Agent on the managed node. A terminated session can't be resumed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        Task<TerminateSessionResponse> TerminateSessionAsync(TerminateSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnlabelParameterVersion


        /// <summary>
        /// Remove a label or labels from a parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlabelParameterVersion service method.</param>
        /// 
        /// <returns>The response from the UnlabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UnlabelParameterVersion">REST API Reference for UnlabelParameterVersion Operation</seealso>
        UnlabelParameterVersionResponse UnlabelParameterVersion(UnlabelParameterVersionRequest request);



        /// <summary>
        /// Remove a label or labels from a parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlabelParameterVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnlabelParameterVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterNotFoundException">
        /// The parameter couldn't be found. Verify the name and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ParameterVersionNotFoundException">
        /// The specified parameter version wasn't found. Verify the parameter name and version,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UnlabelParameterVersion">REST API Reference for UnlabelParameterVersion Operation</seealso>
        Task<UnlabelParameterVersionResponse> UnlabelParameterVersionAsync(UnlabelParameterVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssociation


        /// <summary>
        /// Updates an association. You can update the association name and version, the document
        /// version, schedule, parameters, and Amazon Simple Storage Service (Amazon S3) output.
        /// When you call <c>UpdateAssociation</c>, the system removes all optional parameters
        /// from the request and overwrites the association with null values for those parameters.
        /// This is by design. You must specify all optional parameters in the call, even if you
        /// are not changing the parameters. This includes the <c>Name</c> parameter. Before calling
        /// this API action, we recommend that you call the <a>DescribeAssociation</a> API operation
        /// and make a note of all optional parameters required for your <c>UpdateAssociation</c>
        /// call.
        /// 
        ///  
        /// <para>
        /// In order to call this API operation, a user, group, or role must be granted permission
        /// to call the <a>DescribeAssociation</a> API operation. If you don't have permission
        /// to call <c>DescribeAssociation</c>, then you receive the following error: <c>An error
        /// occurred (AccessDeniedException) when calling the UpdateAssociation operation: User:
        /// &lt;user_arn&gt; isn't authorized to perform: ssm:DescribeAssociation on resource:
        /// &lt;resource_arn&gt;</c> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update an association, the association immediately runs against the specified
        /// targets. You can add the <c>ApplyOnlyAtCronInterval</c> parameter to run the association
        /// during the next schedule run.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationVersionLimitExceededException">
        /// You have reached the maximum number versions allowed for an association. Each association
        /// has a limit of 1,000 versions.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidUpdateException">
        /// The update isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request);



        /// <summary>
        /// Updates an association. You can update the association name and version, the document
        /// version, schedule, parameters, and Amazon Simple Storage Service (Amazon S3) output.
        /// When you call <c>UpdateAssociation</c>, the system removes all optional parameters
        /// from the request and overwrites the association with null values for those parameters.
        /// This is by design. You must specify all optional parameters in the call, even if you
        /// are not changing the parameters. This includes the <c>Name</c> parameter. Before calling
        /// this API action, we recommend that you call the <a>DescribeAssociation</a> API operation
        /// and make a note of all optional parameters required for your <c>UpdateAssociation</c>
        /// call.
        /// 
        ///  
        /// <para>
        /// In order to call this API operation, a user, group, or role must be granted permission
        /// to call the <a>DescribeAssociation</a> API operation. If you don't have permission
        /// to call <c>DescribeAssociation</c>, then you receive the following error: <c>An error
        /// occurred (AccessDeniedException) when calling the UpdateAssociation operation: User:
        /// &lt;user_arn&gt; isn't authorized to perform: ssm:DescribeAssociation on resource:
        /// &lt;resource_arn&gt;</c> 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update an association, the association immediately runs against the specified
        /// targets. You can add the <c>ApplyOnlyAtCronInterval</c> parameter to run the association
        /// during the next schedule run.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationVersionLimitExceededException">
        /// You have reached the maximum number versions allowed for an association. Each association
        /// has a limit of 1,000 versions.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidAssociationVersionException">
        /// The version you specified isn't valid. Use ListAssociationVersions to view all versions
        /// of an association according to the association ID. Or, use the <c>$LATEST</c> parameter
        /// to view the latest version of the association.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidOutputLocationException">
        /// The output location isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidParametersException">
        /// You must specify values for all required parameters in the Amazon Web Services Systems
        /// Manager document (SSM document). You can only supply values to parameters defined
        /// in the SSM document.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidScheduleException">
        /// The schedule is invalid. Verify your cron or rate expression and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetException">
        /// The target isn't valid or doesn't exist. It might not be configured for Systems Manager
        /// or you might not have permission to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidTargetMapsException">
        /// TargetMap parameter isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidUpdateException">
        /// The update isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        Task<UpdateAssociationResponse> UpdateAssociationAsync(UpdateAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssociationStatus


        /// <summary>
        /// Updates the status of the Amazon Web Services Systems Manager document (SSM document)
        /// associated with the specified managed node.
        /// 
        ///  
        /// <para>
        ///  <c>UpdateAssociationStatus</c> is primarily used by the Amazon Web Services Systems
        /// Manager Agent (SSM Agent) to report status updates about your associations and is
        /// only used for associations created with the <c>InstanceId</c> legacy parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        UpdateAssociationStatusResponse UpdateAssociationStatus(UpdateAssociationStatusRequest request);



        /// <summary>
        /// Updates the status of the Amazon Web Services Systems Manager document (SSM document)
        /// associated with the specified managed node.
        /// 
        ///  
        /// <para>
        ///  <c>UpdateAssociationStatus</c> is primarily used by the Amazon Web Services Systems
        /// Manager Agent (SSM Agent) to report status updates about your associations and is
        /// only used for associations created with the <c>InstanceId</c> legacy parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociationStatus service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.AssociationDoesNotExistException">
        /// The specified association doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.StatusUnchangedException">
        /// The updated status is the same as the current status.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateAssociationStatus">REST API Reference for UpdateAssociationStatus Operation</seealso>
        Task<UpdateAssociationStatusResponse> UpdateAssociationStatusAsync(UpdateAssociationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDocument


        /// <summary>
        /// Updates one or more values for an SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentVersionLimitExceededException">
        /// The document has too many versions. Delete one or more document versions and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentContentException">
        /// The content of the association document matches another document. Change the content
        /// of the document and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentVersionNameException">
        /// The version name has already been used in this document. Specify a different version
        /// name, and then try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        UpdateDocumentResponse UpdateDocument(UpdateDocumentRequest request);



        /// <summary>
        /// Updates one or more values for an SSM document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocument service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DocumentVersionLimitExceededException">
        /// The document has too many versions. Delete one or more document versions and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentContentException">
        /// The content of the association document matches another document. Change the content
        /// of the document and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DuplicateDocumentVersionNameException">
        /// The version name has already been used in this document. Specify a different version
        /// name, and then try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentContentException">
        /// The content for the document isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.MaxDocumentSizeExceededException">
        /// The size limit of a document is 64 KB.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocument">REST API Reference for UpdateDocument Operation</seealso>
        Task<UpdateDocumentResponse> UpdateDocumentAsync(UpdateDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDocumentDefaultVersion


        /// <summary>
        /// Set the default version of a document. 
        /// 
        ///  <note> 
        /// <para>
        /// If you change a document version for a State Manager association, Systems Manager
        /// immediately runs the association unless you previously specifed the <c>apply-only-at-cron-interval</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentDefaultVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        UpdateDocumentDefaultVersionResponse UpdateDocumentDefaultVersion(UpdateDocumentDefaultVersionRequest request);



        /// <summary>
        /// Set the default version of a document. 
        /// 
        ///  <note> 
        /// <para>
        /// If you change a document version for a State Manager association, Systems Manager
        /// immediately runs the association unless you previously specifed the <c>apply-only-at-cron-interval</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentDefaultVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentDefaultVersion service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentSchemaVersionException">
        /// The version of the document schema isn't supported.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentDefaultVersion">REST API Reference for UpdateDocumentDefaultVersion Operation</seealso>
        Task<UpdateDocumentDefaultVersionResponse> UpdateDocumentDefaultVersionAsync(UpdateDocumentDefaultVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDocumentMetadata


        /// <summary>
        /// Updates information related to approval reviews for a specific version of a change
        /// template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        UpdateDocumentMetadataResponse UpdateDocumentMetadata(UpdateDocumentMetadataRequest request);



        /// <summary>
        /// Updates information related to approval reviews for a specific version of a change
        /// template in Change Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentException">
        /// The specified SSM document doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentOperationException">
        /// You attempted to delete a document while it is still shared. You must stop sharing
        /// the document before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidDocumentVersionException">
        /// The document version isn't valid or doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateDocumentMetadata">REST API Reference for UpdateDocumentMetadata Operation</seealso>
        Task<UpdateDocumentMetadataResponse> UpdateDocumentMetadataAsync(UpdateDocumentMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMaintenanceWindow


        /// <summary>
        /// Updates an existing maintenance window. Only specified parameters are modified.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <c>Duration</c> determines the specific end time for the
        /// maintenance window based on the time it begins. No maintenance window tasks are permitted
        /// to start after the resulting endtime minus the number of hours you specify for <c>Cutoff</c>.
        /// For example, if the maintenance window starts at 3 PM, the duration is three hours,
        /// and the value you specify for <c>Cutoff</c> is one hour, no maintenance window tasks
        /// can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        UpdateMaintenanceWindowResponse UpdateMaintenanceWindow(UpdateMaintenanceWindowRequest request);



        /// <summary>
        /// Updates an existing maintenance window. Only specified parameters are modified.
        /// 
        ///  <note> 
        /// <para>
        /// The value you specify for <c>Duration</c> determines the specific end time for the
        /// maintenance window based on the time it begins. No maintenance window tasks are permitted
        /// to start after the resulting endtime minus the number of hours you specify for <c>Cutoff</c>.
        /// For example, if the maintenance window starts at 3 PM, the duration is three hours,
        /// and the value you specify for <c>Cutoff</c> is one hour, no maintenance window tasks
        /// can start after 5 PM.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindow service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindow">REST API Reference for UpdateMaintenanceWindow Operation</seealso>
        Task<UpdateMaintenanceWindowResponse> UpdateMaintenanceWindowAsync(UpdateMaintenanceWindowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMaintenanceWindowTarget


        /// <summary>
        /// Modifies the target of an existing maintenance window. You can change the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IDs for an ID target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags for a Tag target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// From any supported tag type to another. The three supported tag types are ID target,
        /// Tag target, and resource group. For more information, see <a>Target</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If a parameter is null, then the corresponding field isn't modified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        UpdateMaintenanceWindowTargetResponse UpdateMaintenanceWindowTarget(UpdateMaintenanceWindowTargetRequest request);



        /// <summary>
        /// Modifies the target of an existing maintenance window. You can change the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Description
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IDs for an ID target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags for a Tag target
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// From any supported tag type to another. The three supported tag types are ID target,
        /// Tag target, and resource group. For more information, see <a>Target</a>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If a parameter is null, then the corresponding field isn't modified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTarget service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTarget">REST API Reference for UpdateMaintenanceWindowTarget Operation</seealso>
        Task<UpdateMaintenanceWindowTargetResponse> UpdateMaintenanceWindowTargetAsync(UpdateMaintenanceWindowTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMaintenanceWindowTask


        /// <summary>
        /// Modifies a task assigned to a maintenance window. You can't change the task type,
        /// but you can change the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>TaskARN</c>. For example, you can change a <c>RUN_COMMAND</c> task from <c>AWS-RunPowerShellScript</c>
        /// to <c>AWS-RunShellScript</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServiceRoleArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TaskInvocationParameters</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Priority</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxConcurrency</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxErrors</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// One or more targets must be specified for maintenance window Run Command-type tasks.
        /// Depending on the task, targets are optional for other maintenance window task types
        /// (Automation, Lambda, and Step Functions). For more information about running tasks
        /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
        /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the value for a parameter in <c>UpdateMaintenanceWindowTask</c> is null, then the
        /// corresponding field isn't modified. If you set <c>Replace</c> to true, then all fields
        /// required by the <a>RegisterTaskWithMaintenanceWindow</a> operation are required for
        /// this request. Optional fields that aren't specified are set to null.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update a maintenance window task that has options specified in <c>TaskInvocationParameters</c>,
        /// you must provide again all the <c>TaskInvocationParameters</c> values that you want
        /// to retain. The values you don't specify again are removed. For example, suppose that
        /// when you registered a Run Command task, you specified <c>TaskInvocationParameters</c>
        /// values for <c>Comment</c>, <c>NotificationConfig</c>, and <c>OutputS3BucketName</c>.
        /// If you update the maintenance window task and specify only a different <c>OutputS3BucketName</c>
        /// value, the values for <c>Comment</c> and <c>NotificationConfig</c> are removed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask service method.</param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        UpdateMaintenanceWindowTaskResponse UpdateMaintenanceWindowTask(UpdateMaintenanceWindowTaskRequest request);



        /// <summary>
        /// Modifies a task assigned to a maintenance window. You can't change the task type,
        /// but you can change the following values:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>TaskARN</c>. For example, you can change a <c>RUN_COMMAND</c> task from <c>AWS-RunPowerShellScript</c>
        /// to <c>AWS-RunShellScript</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ServiceRoleArn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TaskInvocationParameters</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Priority</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxConcurrency</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaxErrors</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// One or more targets must be specified for maintenance window Run Command-type tasks.
        /// Depending on the task, targets are optional for other maintenance window task types
        /// (Automation, Lambda, and Step Functions). For more information about running tasks
        /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
        /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the value for a parameter in <c>UpdateMaintenanceWindowTask</c> is null, then the
        /// corresponding field isn't modified. If you set <c>Replace</c> to true, then all fields
        /// required by the <a>RegisterTaskWithMaintenanceWindow</a> operation are required for
        /// this request. Optional fields that aren't specified are set to null.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update a maintenance window task that has options specified in <c>TaskInvocationParameters</c>,
        /// you must provide again all the <c>TaskInvocationParameters</c> values that you want
        /// to retain. The values you don't specify again are removed. For example, suppose that
        /// when you registered a Run Command task, you specified <c>TaskInvocationParameters</c>
        /// values for <c>Comment</c>, <c>NotificationConfig</c>, and <c>OutputS3BucketName</c>.
        /// If you update the maintenance window task and specify only a different <c>OutputS3BucketName</c>
        /// value, the values for <c>Comment</c> and <c>NotificationConfig</c> are removed.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMaintenanceWindowTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMaintenanceWindowTask service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateMaintenanceWindowTask">REST API Reference for UpdateMaintenanceWindowTask Operation</seealso>
        Task<UpdateMaintenanceWindowTaskResponse> UpdateMaintenanceWindowTaskAsync(UpdateMaintenanceWindowTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateManagedInstanceRole


        /// <summary>
        /// Changes the Identity and Access Management (IAM) role that is assigned to the on-premises
        /// server, edge device, or virtual machines (VM). IAM roles are first assigned to these
        /// hybrid nodes during the activation process. For more information, see <a>CreateActivation</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole service method.</param>
        /// 
        /// <returns>The response from the UpdateManagedInstanceRole service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        UpdateManagedInstanceRoleResponse UpdateManagedInstanceRole(UpdateManagedInstanceRoleRequest request);



        /// <summary>
        /// Changes the Identity and Access Management (IAM) role that is assigned to the on-premises
        /// server, edge device, or virtual machines (VM). IAM roles are first assigned to these
        /// hybrid nodes during the activation process. For more information, see <a>CreateActivation</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateManagedInstanceRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateManagedInstanceRole service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InvalidInstanceIdException">
        /// The following problems can cause this exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You don't have permission to access the managed node.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager Agent (SSM Agent) isn't running. Verify that SSM
        /// Agent is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Agent isn't registered with the SSM endpoint. Try reinstalling SSM Agent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The managed node isn't in a valid state. Valid states are: <c>Running</c>, <c>Pending</c>,
        /// <c>Stopped</c>, and <c>Stopping</c>. Invalid states are: <c>Shutting-down</c> and
        /// <c>Terminated</c>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateManagedInstanceRole">REST API Reference for UpdateManagedInstanceRole Operation</seealso>
        Task<UpdateManagedInstanceRoleResponse> UpdateManagedInstanceRoleAsync(UpdateManagedInstanceRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOpsItem


        /// <summary>
        /// Edit or change an OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to update an OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsItem service method.</param>
        /// 
        /// <returns>The response from the UpdateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsItem">REST API Reference for UpdateOpsItem Operation</seealso>
        UpdateOpsItemResponse UpdateOpsItem(UpdateOpsItemRequest request);



        /// <summary>
        /// Edit or change an OpsItem. You must have permission in Identity and Access Management
        /// (IAM) to update an OpsItem. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
        /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
        /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
        /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpsItem service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAccessDeniedException">
        /// You don't have permission to view OpsItems in the specified account. Verify that your
        /// account is configured either as a Systems Manager delegated administrator or that
        /// you are logged into the Organizations management account.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemAlreadyExistsException">
        /// The OpsItem already exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemConflictException">
        /// The specified OpsItem is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemInvalidParameterException">
        /// A specified parameter argument isn't valid. Verify the available arguments and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemLimitExceededException">
        /// The request caused OpsItems to exceed one or more quotas.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsItemNotFoundException">
        /// The specified OpsItem ID doesn't exist. Verify the ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsItem">REST API Reference for UpdateOpsItem Operation</seealso>
        Task<UpdateOpsItemResponse> UpdateOpsItemAsync(UpdateOpsItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOpsMetadata


        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when you edit OpsMetadata
        /// in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataKeyLimitExceededException">
        /// The OpsMetadata object exceeds the maximum number of OpsMetadata keys that you can
        /// assign to an application in Application Manager.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        UpdateOpsMetadataResponse UpdateOpsMetadata(UpdateOpsMetadataRequest request);



        /// <summary>
        /// Amazon Web Services Systems Manager calls this API operation when you edit OpsMetadata
        /// in Application Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpsMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpsMetadata service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataInvalidArgumentException">
        /// One of the arguments passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataKeyLimitExceededException">
        /// The OpsMetadata object exceeds the maximum number of OpsMetadata keys that you can
        /// assign to an application in Application Manager.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataNotFoundException">
        /// The OpsMetadata object doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.OpsMetadataTooManyUpdatesException">
        /// The system is processing too many concurrent updates. Wait a few moments and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateOpsMetadata">REST API Reference for UpdateOpsMetadata Operation</seealso>
        Task<UpdateOpsMetadataResponse> UpdateOpsMetadataAsync(UpdateOpsMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePatchBaseline


        /// <summary>
        /// Modifies an existing patch baseline. Fields not specified in the request are left
        /// unchanged.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
        /// operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline service method.</param>
        /// 
        /// <returns>The response from the UpdatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        UpdatePatchBaselineResponse UpdatePatchBaseline(UpdatePatchBaselineRequest request);



        /// <summary>
        /// Modifies an existing patch baseline. Fields not specified in the request are left
        /// unchanged.
        /// 
        ///  <note> 
        /// <para>
        /// For information about valid key-value pairs in <c>PatchFilters</c> for each supported
        /// operating system type, see <a>PatchFilter</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePatchBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePatchBaseline service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.DoesNotExistException">
        /// Error returned when the ID specified for a resource, such as a maintenance window
        /// or patch baseline, doesn't exist.
        /// 
        ///  
        /// <para>
        /// For information about resource quotas in Amazon Web Services Systems Manager, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#limits_ssm">Systems
        /// Manager service quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdatePatchBaseline">REST API Reference for UpdatePatchBaseline Operation</seealso>
        Task<UpdatePatchBaselineResponse> UpdatePatchBaselineAsync(UpdatePatchBaselineRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResourceDataSync


        /// <summary>
        /// Update a resource data sync. After you create a resource data sync for a Region, you
        /// can't change the account options for that sync. For example, if you create a sync
        /// in the us-east-2 (Ohio) Region and you choose the <c>Include only the current account</c>
        /// option, you can't edit that sync later and choose the <c>Include all accounts from
        /// my Organizations configuration</c> option. Instead, you must delete the first resource
        /// data sync, and create a new one.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation only supports a resource data sync that was created with a SyncFromSource
        /// <c>SyncType</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDataSync service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncConflictException">
        /// Another <c>UpdateResourceDataSync</c> request is being processed. Wait a few minutes
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        UpdateResourceDataSyncResponse UpdateResourceDataSync(UpdateResourceDataSyncRequest request);



        /// <summary>
        /// Update a resource data sync. After you create a resource data sync for a Region, you
        /// can't change the account options for that sync. For example, if you create a sync
        /// in the us-east-2 (Ohio) Region and you choose the <c>Include only the current account</c>
        /// option, you can't edit that sync later and choose the <c>Include all accounts from
        /// my Organizations configuration</c> option. Instead, you must delete the first resource
        /// data sync, and create a new one.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation only supports a resource data sync that was created with a SyncFromSource
        /// <c>SyncType</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceDataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceDataSync service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncConflictException">
        /// Another <c>UpdateResourceDataSync</c> request is being processed. Wait a few minutes
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncInvalidConfigurationException">
        /// The specified sync configuration is invalid.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ResourceDataSyncNotFoundException">
        /// The specified sync name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateResourceDataSync">REST API Reference for UpdateResourceDataSync Operation</seealso>
        Task<UpdateResourceDataSyncResponse> UpdateResourceDataSyncAsync(UpdateResourceDataSyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceSetting


        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of "false". This means the user can't use this feature unless
        /// they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API operation to view
        /// the current value. Or, use the <a>ResetServiceSetting</a> to change the value back
        /// to the original value defined by the Amazon Web Services service team.
        /// </para>
        ///  
        /// <para>
        /// Update the service setting for the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSetting service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        UpdateServiceSettingResponse UpdateServiceSetting(UpdateServiceSettingRequest request);



        /// <summary>
        /// <c>ServiceSetting</c> is an account-level setting for an Amazon Web Services service.
        /// This setting defines how a user interacts with or uses a service or a feature of a
        /// service. For example, if an Amazon Web Services service charges money to the account
        /// based on feature or service usage, then the Amazon Web Services service team might
        /// create a default setting of "false". This means the user can't use this feature unless
        /// they change the setting to "true" and intentionally opt in for a paid feature.
        /// 
        ///  
        /// <para>
        /// Services map a <c>SettingId</c> object to a setting value. Amazon Web Services services
        /// teams define the default value for a <c>SettingId</c>. You can't create a new <c>SettingId</c>,
        /// but you can overwrite the default value if you have the <c>ssm:UpdateServiceSetting</c>
        /// permission for the setting. Use the <a>GetServiceSetting</a> API operation to view
        /// the current value. Or, use the <a>ResetServiceSetting</a> to change the value back
        /// to the original value defined by the Amazon Web Services service team.
        /// </para>
        ///  
        /// <para>
        /// Update the service setting for the account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSetting service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSetting service method, as returned by SimpleSystemsManagement.</returns>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.ServiceSettingNotFoundException">
        /// The specified service setting wasn't found. Either the service name or the setting
        /// hasn't been provisioned by the Amazon Web Services service team.
        /// </exception>
        /// <exception cref="Amazon.SimpleSystemsManagement.Model.TooManyUpdatesException">
        /// There are concurrent updates for a resource that supports one update at a time.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-2014-11-06/UpdateServiceSetting">REST API Reference for UpdateServiceSetting Operation</seealso>
        Task<UpdateServiceSettingResponse> UpdateServiceSettingAsync(UpdateServiceSettingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
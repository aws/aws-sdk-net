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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SupportApp.Model;

#pragma warning disable CS1570
namespace Amazon.SupportApp
{
    /// <summary>
    /// <para>Interface for accessing SupportApp</para>
    ///
    /// Amazon Web Services Support App in Slack 
    /// <para>
    /// You can use the Amazon Web Services Support App in Slack API to manage your support
    /// cases in Slack for your Amazon Web Services account. After you configure your Slack
    /// workspace and channel with the Amazon Web Services Support App, you can perform the
    /// following tasks directly in your Slack channel:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Create, search, update, and resolve your support cases
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Request service quota increases for your account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Invite Amazon Web Services Support agents to your channel so that you can chat directly
    /// about your support cases
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how to perform these actions in Slack, see the following
    /// documentation in the <i>Amazon Web Services Support User Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awssupport/latest/user/aws-support-app-for-slack.html">Amazon
    /// Web Services Support App in Slack</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awssupport/latest/user/joining-a-live-chat-session.html">Joining
    /// a live chat session with Amazon Web Services Support</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awssupport/latest/user/service-quota-increase.html">Requesting
    /// service quota increases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awssupport/latest/user/support-app-commands.html">Amazon
    /// Web Services Support App commands in Slack</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also use the Amazon Web Services Management Console instead of the Amazon
    /// Web Services Support App API to manage your Slack configurations. For more information,
    /// see <a href="https://docs.aws.amazon.com/awssupport/latest/user/authorize-slack-workspace.html">Authorize
    /// a Slack workspace to enable the Amazon Web Services Support App</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have a Business or Enterprise Support plan to use the Amazon Web Services
    /// Support App API. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about the Amazon Web Services Support App endpoints, see the
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/awssupport.html#awssupport_app_region">Amazon
    /// Web Services Support App in Slack endpoints</a> in the <i>Amazon Web Services General
    /// Reference</i>.
    /// </para>
    ///  </li> </ul> </note>
    /// </para>
    /// </summary>
    public partial interface IAmazonSupportApp : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISupportAppPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateSlackChannelConfiguration



        /// <summary>
        /// Creates a Slack channel configuration for your Amazon Web Services account.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// You can add up to 5 Slack workspaces for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can add up to 20 Slack channels for your account.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// A Slack channel can have up to 100 Amazon Web Services accounts. This means that only
        /// 100 accounts can add the same Slack channel to the Amazon Web Services Support App.
        /// We recommend that you only add the accounts that you need to manage support cases
        /// for your organization. This can reduce the notifications about case updates that you
        /// receive in the Slack channel.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you choose a private Slack channel so that only members in that
        /// channel have read and write access to your support cases. Anyone in your Slack channel
        /// can create, update, or resolve support cases for your account. Users require an invitation
        /// to join private channels. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ConflictException">
        /// Your request has a conflict. For example, you might receive this error if you try
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add, update, or delete a Slack channel configuration before you add a Slack workspace
        /// to your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add a Slack channel configuration that already exists in your Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack channel configuration for a live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack workspace from your Amazon Web Services account that has an active
        /// live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from an Amazon Web Services
        /// account that doesn't belong to an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from a member account, but
        /// the management account hasn't registered that workspace yet for the organization.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ServiceQuotaExceededException">
        /// Your Service Quotas request exceeds the quota for the service. For example, your Service
        /// Quotas request to Amazon Web Services Support App might exceed the maximum number
        /// of workspaces or channels per account, or the maximum number of accounts per Slack
        /// channel.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        Task<CreateSlackChannelConfigurationResponse> CreateSlackChannelConfigurationAsync(CreateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccountAlias



        /// <summary>
        /// Deletes an alias for an Amazon Web Services account ID. The alias appears in the Amazon
        /// Web Services Support App page of the Amazon Web Services Support Center. The alias
        /// also appears in Slack messages from the Amazon Web Services Support App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ResourceNotFoundException">
        /// The specified resource is missing or doesn't exist, such as an account alias, Slack
        /// channel configuration, or Slack workspace configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSlackChannelConfiguration



        /// <summary>
        /// Deletes a Slack channel configuration from your Amazon Web Services account. This
        /// operation doesn't delete your Slack channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ConflictException">
        /// Your request has a conflict. For example, you might receive this error if you try
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add, update, or delete a Slack channel configuration before you add a Slack workspace
        /// to your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add a Slack channel configuration that already exists in your Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack channel configuration for a live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack workspace from your Amazon Web Services account that has an active
        /// live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from an Amazon Web Services
        /// account that doesn't belong to an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from a member account, but
        /// the management account hasn't registered that workspace yet for the organization.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ResourceNotFoundException">
        /// The specified resource is missing or doesn't exist, such as an account alias, Slack
        /// channel configuration, or Slack workspace configuration.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        Task<DeleteSlackChannelConfigurationResponse> DeleteSlackChannelConfigurationAsync(DeleteSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSlackWorkspaceConfiguration



        /// <summary>
        /// Deletes a Slack workspace configuration from your Amazon Web Services account. This
        /// operation doesn't delete your Slack workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceConfiguration service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ConflictException">
        /// Your request has a conflict. For example, you might receive this error if you try
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add, update, or delete a Slack channel configuration before you add a Slack workspace
        /// to your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add a Slack channel configuration that already exists in your Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack channel configuration for a live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack workspace from your Amazon Web Services account that has an active
        /// live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from an Amazon Web Services
        /// account that doesn't belong to an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from a member account, but
        /// the management account hasn't registered that workspace yet for the organization.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ResourceNotFoundException">
        /// The specified resource is missing or doesn't exist, such as an account alias, Slack
        /// channel configuration, or Slack workspace configuration.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/DeleteSlackWorkspaceConfiguration">REST API Reference for DeleteSlackWorkspaceConfiguration Operation</seealso>
        Task<DeleteSlackWorkspaceConfigurationResponse> DeleteSlackWorkspaceConfigurationAsync(DeleteSlackWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccountAlias



        /// <summary>
        /// Retrieves the alias from an Amazon Web Services account ID. The alias appears in the
        /// Amazon Web Services Support App page of the Amazon Web Services Support Center. The
        /// alias also appears in Slack messages from the Amazon Web Services Support App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountAlias service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/GetAccountAlias">REST API Reference for GetAccountAlias Operation</seealso>
        Task<GetAccountAliasResponse> GetAccountAliasAsync(GetAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSlackChannelConfigurations



        /// <summary>
        /// Lists the Slack channel configurations for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlackChannelConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSlackChannelConfigurations service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/ListSlackChannelConfigurations">REST API Reference for ListSlackChannelConfigurations Operation</seealso>
        Task<ListSlackChannelConfigurationsResponse> ListSlackChannelConfigurationsAsync(ListSlackChannelConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSlackWorkspaceConfigurations



        /// <summary>
        /// Lists the Slack workspace configurations for an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlackWorkspaceConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSlackWorkspaceConfigurations service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/ListSlackWorkspaceConfigurations">REST API Reference for ListSlackWorkspaceConfigurations Operation</seealso>
        Task<ListSlackWorkspaceConfigurationsResponse> ListSlackWorkspaceConfigurationsAsync(ListSlackWorkspaceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAccountAlias



        /// <summary>
        /// Creates or updates an individual alias for each Amazon Web Services account ID. The
        /// alias appears in the Amazon Web Services Support App page of the Amazon Web Services
        /// Support Center. The alias also appears in Slack messages from the Amazon Web Services
        /// Support App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountAlias service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/PutAccountAlias">REST API Reference for PutAccountAlias Operation</seealso>
        Task<PutAccountAliasResponse> PutAccountAliasAsync(PutAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterSlackWorkspaceForOrganization



        /// <summary>
        /// Registers a Slack workspace for your Amazon Web Services account. To call this API,
        /// your account must be part of an organization in Organizations.
        /// 
        ///  
        /// <para>
        /// If you're the <i>management account</i> and you want to register Slack workspaces
        /// for your organization, you must complete the following tasks:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Sign in to the <a href="https://console.aws.amazon.com/support/app">Amazon Web Services
        /// Support Center</a> and authorize the Slack workspaces where you want your organization
        /// to have access to. See <a href="https://docs.aws.amazon.com/awssupport/latest/user/authorize-slack-workspace.html">Authorize
        /// a Slack workspace</a> in the <i>Amazon Web Services Support User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API to authorize each Slack
        /// workspace for the organization.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After the management account authorizes the Slack workspace, member accounts can call
        /// this API to authorize the same Slack workspace for their individual accounts. Member
        /// accounts don't need to authorize the Slack workspace manually through the <a href="https://console.aws.amazon.com/support/app">Amazon
        /// Web Services Support Center</a>.
        /// </para>
        ///  
        /// <para>
        /// To use the Amazon Web Services Support App, each account must then complete the following
        /// tasks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create an Identity and Access Management (IAM) role with the required permission.
        /// For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/support-app-permissions.html">Managing
        /// access to the Amazon Web Services Support App</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Configure a Slack channel to use the Amazon Web Services Support App for support cases
        /// for that account. For more information, see <a href="https://docs.aws.amazon.com/awssupport/latest/user/add-your-slack-channel.html">Configuring
        /// a Slack channel</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterSlackWorkspaceForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterSlackWorkspaceForOrganization service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ConflictException">
        /// Your request has a conflict. For example, you might receive this error if you try
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add, update, or delete a Slack channel configuration before you add a Slack workspace
        /// to your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add a Slack channel configuration that already exists in your Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack channel configuration for a live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack workspace from your Amazon Web Services account that has an active
        /// live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from an Amazon Web Services
        /// account that doesn't belong to an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from a member account, but
        /// the management account hasn't registered that workspace yet for the organization.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ResourceNotFoundException">
        /// The specified resource is missing or doesn't exist, such as an account alias, Slack
        /// channel configuration, or Slack workspace configuration.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/RegisterSlackWorkspaceForOrganization">REST API Reference for RegisterSlackWorkspaceForOrganization Operation</seealso>
        Task<RegisterSlackWorkspaceForOrganizationResponse> RegisterSlackWorkspaceForOrganizationAsync(RegisterSlackWorkspaceForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSlackChannelConfiguration



        /// <summary>
        /// Updates the configuration for a Slack channel, such as case update notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by SupportApp.</returns>
        /// <exception cref="Amazon.SupportApp.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ConflictException">
        /// Your request has a conflict. For example, you might receive this error if you try
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add, update, or delete a Slack channel configuration before you add a Slack workspace
        /// to your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add a Slack channel configuration that already exists in your Amazon Web Services
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack channel configuration for a live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a Slack workspace from your Amazon Web Services account that has an active
        /// live chat channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from an Amazon Web Services
        /// account that doesn't belong to an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>RegisterSlackWorkspaceForOrganization</c> API from a member account, but
        /// the management account hasn't registered that workspace yet for the organization.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.InternalServerException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ResourceNotFoundException">
        /// The specified resource is missing or doesn't exist, such as an account alias, Slack
        /// channel configuration, or Slack workspace configuration.
        /// </exception>
        /// <exception cref="Amazon.SupportApp.Model.ValidationException">
        /// Your request input doesn't meet the constraints that the Amazon Web Services Support
        /// App specifies.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/support-app-2021-08-20/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        Task<UpdateSlackChannelConfigurationResponse> UpdateSlackChannelConfigurationAsync(UpdateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSupportAppConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSupportAppConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSupportAppConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSupportAppConfig to create AmazonSupportAppClient");
            }

            return awsCredentials == null ? 
                    new AmazonSupportAppClient(serviceClientConfig) :
                    new AmazonSupportAppClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
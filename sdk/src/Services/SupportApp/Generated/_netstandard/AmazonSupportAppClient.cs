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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SupportApp.Model;
using Amazon.SupportApp.Model.Internal.MarshallTransformations;
using Amazon.SupportApp.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SupportApp
{
    /// <summary>
    /// <para>Implementation for accessing SupportApp</para>
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
    public partial class AmazonSupportAppClient : AmazonServiceClient, IAmazonSupportApp
    {
        private static IServiceMetadata serviceMetadata = new AmazonSupportAppMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSupportAppClient with the credentials loaded from the application's
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
        public AmazonSupportAppClient()
            : base(new AmazonSupportAppConfig()) { }

        /// <summary>
        /// Constructs AmazonSupportAppClient with the credentials loaded from the application's
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
        public AmazonSupportAppClient(RegionEndpoint region)
            : base(new AmazonSupportAppConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSupportAppClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSupportAppClient Configuration Object</param>
        public AmazonSupportAppClient(AmazonSupportAppConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSupportAppClient(AWSCredentials credentials)
            : this(credentials, new AmazonSupportAppConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAppClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSupportAppConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Credentials and an
        /// AmazonSupportAppClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSupportAppClient Configuration Object</param>
        public AmazonSupportAppClient(AWSCredentials credentials, AmazonSupportAppConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupportAppConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupportAppConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupportAppClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSupportAppClient Configuration Object</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSupportAppConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupportAppConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupportAppConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAppClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupportAppClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSupportAppClient Configuration Object</param>
        public AmazonSupportAppClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSupportAppConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISupportAppPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISupportAppPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SupportAppPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSupportAppEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSupportAppAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateSlackChannelConfiguration

        internal virtual CreateSlackChannelConfigurationResponse CreateSlackChannelConfiguration(CreateSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSlackChannelConfigurationResponse>(request, options);
        }



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
        public virtual Task<CreateSlackChannelConfigurationResponse> CreateSlackChannelConfigurationAsync(CreateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSlackChannelConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccountAlias

        internal virtual DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAliasResponse>(request, options);
        }



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
        public virtual Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSlackChannelConfiguration

        internal virtual DeleteSlackChannelConfigurationResponse DeleteSlackChannelConfiguration(DeleteSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSlackChannelConfigurationResponse>(request, options);
        }



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
        public virtual Task<DeleteSlackChannelConfigurationResponse> DeleteSlackChannelConfigurationAsync(DeleteSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlackChannelConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSlackWorkspaceConfiguration

        internal virtual DeleteSlackWorkspaceConfigurationResponse DeleteSlackWorkspaceConfiguration(DeleteSlackWorkspaceConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackWorkspaceConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSlackWorkspaceConfigurationResponse>(request, options);
        }



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
        public virtual Task<DeleteSlackWorkspaceConfigurationResponse> DeleteSlackWorkspaceConfigurationAsync(DeleteSlackWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackWorkspaceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSlackWorkspaceConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAccountAlias

        internal virtual GetAccountAliasResponse GetAccountAlias(GetAccountAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAliasResponseUnmarshaller.Instance;

            return Invoke<GetAccountAliasResponse>(request, options);
        }



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
        public virtual Task<GetAccountAliasResponse> GetAccountAliasAsync(GetAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSlackChannelConfigurations

        internal virtual ListSlackChannelConfigurationsResponse ListSlackChannelConfigurations(ListSlackChannelConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSlackChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSlackChannelConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSlackChannelConfigurationsResponse>(request, options);
        }



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
        public virtual Task<ListSlackChannelConfigurationsResponse> ListSlackChannelConfigurationsAsync(ListSlackChannelConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSlackChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSlackChannelConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSlackChannelConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSlackWorkspaceConfigurations

        internal virtual ListSlackWorkspaceConfigurationsResponse ListSlackWorkspaceConfigurations(ListSlackWorkspaceConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSlackWorkspaceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSlackWorkspaceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSlackWorkspaceConfigurationsResponse>(request, options);
        }



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
        public virtual Task<ListSlackWorkspaceConfigurationsResponse> ListSlackWorkspaceConfigurationsAsync(ListSlackWorkspaceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSlackWorkspaceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSlackWorkspaceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSlackWorkspaceConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAccountAlias

        internal virtual PutAccountAliasResponse PutAccountAlias(PutAccountAliasRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountAliasResponseUnmarshaller.Instance;

            return Invoke<PutAccountAliasResponse>(request, options);
        }



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
        public virtual Task<PutAccountAliasResponse> PutAccountAliasAsync(PutAccountAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAccountAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountAliasResponseUnmarshaller.Instance;

            return InvokeAsync<PutAccountAliasResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterSlackWorkspaceForOrganization

        internal virtual RegisterSlackWorkspaceForOrganizationResponse RegisterSlackWorkspaceForOrganization(RegisterSlackWorkspaceForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterSlackWorkspaceForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSlackWorkspaceForOrganizationResponseUnmarshaller.Instance;

            return Invoke<RegisterSlackWorkspaceForOrganizationResponse>(request, options);
        }



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
        public virtual Task<RegisterSlackWorkspaceForOrganizationResponse> RegisterSlackWorkspaceForOrganizationAsync(RegisterSlackWorkspaceForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterSlackWorkspaceForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterSlackWorkspaceForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterSlackWorkspaceForOrganizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSlackChannelConfiguration

        internal virtual UpdateSlackChannelConfigurationResponse UpdateSlackChannelConfiguration(UpdateSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSlackChannelConfigurationResponse>(request, options);
        }



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
        public virtual Task<UpdateSlackChannelConfigurationResponse> UpdateSlackChannelConfigurationAsync(UpdateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSlackChannelConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}
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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeCatalyst.Model;
using Amazon.CodeCatalyst.Model.Internal.MarshallTransformations;
using Amazon.CodeCatalyst.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CodeCatalyst
{
    /// <summary>
    /// <para>Implementation for accessing CodeCatalyst</para>
    ///
    /// Welcome to the Amazon CodeCatalyst API reference. This reference provides descriptions
    /// of operations and data types for Amazon CodeCatalyst. You can use the Amazon CodeCatalyst
    /// API to work with the following objects. 
    /// 
    ///  
    /// <para>
    /// Spaces, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteSpace</a>, which deletes a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSpace</a>, which returns information about a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSubscription</a>, which returns information about the Amazon Web Services account
    /// used for billing purposes and the billing plan for the space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSpaces</a>, which retrieves a list of spaces.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateSpace</a>, which changes one or more values for a space.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Projects, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateProject</a> which creates a project in a specified space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetProject</a>, which returns information about a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which retrieves a list of projects in a space.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Users, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetUserDetails</a>, which returns information about a user in Amazon CodeCatalyst.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Source repositories, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateSourceRepository</a>, which creates an empty Git-based source repository
    /// in a specified project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSourceRepositoryBranch</a>, which creates a branch in a specified repository
    /// where you can work on code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteSourceRepository</a>, which deletes a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepository</a>, which returns information about a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepositoryCloneUrls</a>, which returns information about the URLs that
    /// can be used with a Git client to clone a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSourceRepositories</a>, which retrieves a list of source repositories in a
    /// project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSourceRepositoryBranches</a>, which retrieves a list of branches in a source
    /// repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Dev Environments and the Amazon Web Services Toolkits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateDevEnvironment</a>, which creates a Dev Environment, where you can quickly
    /// work on the code stored in the source repositories of your project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteDevEnvironment</a>, which deletes a Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDevEnvironment</a>, which returns information about a Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironments</a>, which retrieves a list of Dev Environments in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironmentSessions</a>, which retrieves a list of active Dev Environment
    /// sessions in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartDevEnvironment</a>, which starts a specified Dev Environment and puts it
    /// into an active state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartDevEnvironmentSession</a>, which starts a session to a specified Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopDevEnvironment</a>, which stops a specified Dev Environment and puts it into
    /// an stopped state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopDevEnvironmentSession</a>, which stops a session for a specified Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateDevEnvironment</a>, which changes one or more values for a Dev Environment.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Workflows, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetWorkflow</a>, which returns information about a workflow.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetWorkflowRun</a>, which returns information about a specified run of a workflow.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListWorkflowRuns</a>, which retrieves a list of runs of a specified workflow.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListWorkflows</a>, which retrieves a list of workflows in a specified project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartWorkflowRun</a>, which starts a run of a specified workflow.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Security, activity, and resource management in Amazon CodeCatalyst, by calling the
    /// following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAccessToken</a>, which creates a personal access token (PAT) for the current
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteAccessToken</a>, which deletes a specified personal access token (PAT).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAccessTokens</a>, which lists all personal access tokens (PATs) associated
    /// with a user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListEventLogs</a>, which retrieves a list of events that occurred during a specified
    /// time period in a space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifySession</a>, which verifies whether the calling user has a valid Amazon
    /// CodeCatalyst login and session.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If you are using the Amazon CodeCatalyst APIs with an SDK or the CLI, you must configure
    /// your computer to work with Amazon CodeCatalyst and single sign-on (SSO). For more
    /// information, see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/set-up-cli.html">Setting
    /// up to use the CLI with Amazon CodeCatalyst</a> and the SSO documentation for your
    /// SDK.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonCodeCatalystClient : AmazonServiceClient, IAmazonCodeCatalyst
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeCatalystMetadata();
        private ICodeCatalystPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeCatalystPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeCatalystPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with the credentials loaded from the application's
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
        public AmazonCodeCatalystClient()
            : base(new AmazonCodeCatalystConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with the credentials loaded from the application's
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
        public AmazonCodeCatalystClient(RegionEndpoint region)
            : base(new AmazonCodeCatalystConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeCatalystClient Configuration Object</param>
        public AmazonCodeCatalystClient(AmazonCodeCatalystConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeCatalystClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeCatalystConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCatalystClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeCatalystConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Credentials and an
        /// AmazonCodeCatalystClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeCatalystClient Configuration Object</param>
        public AmazonCodeCatalystClient(AWSCredentials credentials, AmazonCodeCatalystConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeCatalystConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeCatalystConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeCatalystClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeCatalystClient Configuration Object</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeCatalystConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeCatalystConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeCatalystConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCatalystClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeCatalystClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeCatalystClient Configuration Object</param>
        public AmazonCodeCatalystClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeCatalystConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeCatalystEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeCatalystAuthSchemeHandler());
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


        #region  CreateAccessToken


        /// <summary>
        /// Creates a personal access token (PAT) for the current user. A personal access token
        /// (PAT) is similar to a password. It is associated with your user identity for use across
        /// all spaces and projects in Amazon CodeCatalyst. You use PATs to access CodeCatalyst
        /// from resources that include integrated development environments (IDEs) and Git-based
        /// source repositories. PATs represent you in Amazon CodeCatalyst and you can manage
        /// them in your user settings.For more information, see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
        /// personal access tokens in Amazon CodeCatalyst</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// 
        /// <returns>The response from the CreateAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual CreateAccessTokenResponse CreateAccessToken(CreateAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<CreateAccessTokenResponse>(request, options);
        }


        /// <summary>
        /// Creates a personal access token (PAT) for the current user. A personal access token
        /// (PAT) is similar to a password. It is associated with your user identity for use across
        /// all spaces and projects in Amazon CodeCatalyst. You use PATs to access CodeCatalyst
        /// from resources that include integrated development environments (IDEs) and Git-based
        /// source repositories. PATs represent you in Amazon CodeCatalyst and you can manage
        /// them in your user settings.For more information, see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
        /// personal access tokens in Amazon CodeCatalyst</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual Task<CreateAccessTokenResponse> CreateAccessTokenAsync(CreateAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDevEnvironment


        /// <summary>
        /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development environment
        /// that you can use to quickly work on the code stored in the source repositories of
        /// your project. 
        /// 
        ///  <note> 
        /// <para>
        /// When created in the Amazon CodeCatalyst console, by default a Dev Environment is configured
        /// to have a 2 core processor, 4GB of RAM, and 16GB of persistent storage. None of these
        /// defaults apply to a Dev Environment created programmatically.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        public virtual CreateDevEnvironmentResponse CreateDevEnvironment(CreateDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development environment
        /// that you can use to quickly work on the code stored in the source repositories of
        /// your project. 
        /// 
        ///  <note> 
        /// <para>
        /// When created in the Amazon CodeCatalyst console, by default a Dev Environment is configured
        /// to have a 2 core processor, 4GB of RAM, and 16GB of persistent storage. None of these
        /// defaults apply to a Dev Environment created programmatically.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        public virtual Task<CreateDevEnvironmentResponse> CreateDevEnvironmentAsync(CreateDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a project in a specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }


        /// <summary>
        /// Creates a project in a specified space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSourceRepository


        /// <summary>
        /// Creates an empty Git-based source repository in a specified project. The repository
        /// is created with an initial empty commit with a default branch named <c>main</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepository service method.</param>
        /// 
        /// <returns>The response from the CreateSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepository">REST API Reference for CreateSourceRepository Operation</seealso>
        public virtual CreateSourceRepositoryResponse CreateSourceRepository(CreateSourceRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateSourceRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Creates an empty Git-based source repository in a specified project. The repository
        /// is created with an initial empty commit with a default branch named <c>main</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepository">REST API Reference for CreateSourceRepository Operation</seealso>
        public virtual Task<CreateSourceRepositoryResponse> CreateSourceRepositoryAsync(CreateSourceRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSourceRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSourceRepositoryBranch


        /// <summary>
        /// Creates a branch in a specified source repository in Amazon CodeCatalyst. 
        /// 
        ///  <note> 
        /// <para>
        /// This API only creates a branch in a source repository hosted in Amazon CodeCatalyst.
        /// You cannot use this API to create a branch in a linked repository.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepositoryBranch service method.</param>
        /// 
        /// <returns>The response from the CreateSourceRepositoryBranch service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        public virtual CreateSourceRepositoryBranchResponse CreateSourceRepositoryBranch(CreateSourceRepositoryBranchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryBranchResponseUnmarshaller.Instance;

            return Invoke<CreateSourceRepositoryBranchResponse>(request, options);
        }


        /// <summary>
        /// Creates a branch in a specified source repository in Amazon CodeCatalyst. 
        /// 
        ///  <note> 
        /// <para>
        /// This API only creates a branch in a source repository hosted in Amazon CodeCatalyst.
        /// You cannot use this API to create a branch in a linked repository.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepositoryBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSourceRepositoryBranch service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        public virtual Task<CreateSourceRepositoryBranchResponse> CreateSourceRepositoryBranchAsync(CreateSourceRepositoryBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSourceRepositoryBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessToken


        /// <summary>
        /// Deletes a specified personal access token (PAT). A personal access token can only
        /// be deleted by the user who created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual DeleteAccessTokenResponse DeleteAccessToken(DeleteAccessTokenRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessTokenResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified personal access token (PAT). A personal access token can only
        /// be deleted by the user who created it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessToken service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual Task<DeleteAccessTokenResponse> DeleteAccessTokenAsync(DeleteAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevEnvironment


        /// <summary>
        /// Deletes a Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        public virtual DeleteDevEnvironmentResponse DeleteDevEnvironment(DeleteDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        public virtual Task<DeleteDevEnvironmentResponse> DeleteDevEnvironmentAsync(DeleteDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a project in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }


        /// <summary>
        /// Deletes a project in a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSourceRepository


        /// <summary>
        /// Deletes a source repository in Amazon CodeCatalyst. You cannot use this API to delete
        /// a linked repository. It can only be used to delete a Amazon CodeCatalyst source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSourceRepository">REST API Reference for DeleteSourceRepository Operation</seealso>
        public virtual DeleteSourceRepositoryResponse DeleteSourceRepository(DeleteSourceRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a source repository in Amazon CodeCatalyst. You cannot use this API to delete
        /// a linked repository. It can only be used to delete a Amazon CodeCatalyst source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSourceRepository">REST API Reference for DeleteSourceRepository Operation</seealso>
        public virtual Task<DeleteSourceRepositoryResponse> DeleteSourceRepositoryAsync(DeleteSourceRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSourceRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpace


        /// <summary>
        /// Deletes a space.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a space cannot be undone. Additionally, since space names must be unique
        /// across Amazon CodeCatalyst, you cannot reuse names of deleted spaces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteSpaceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a space.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a space cannot be undone. Additionally, since space names must be unique
        /// across Amazon CodeCatalyst, you cannot reuse names of deleted spaces.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteSpace">REST API Reference for DeleteSpace Operation</seealso>
        public virtual Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevEnvironment


        /// <summary>
        /// Returns information about a Dev Environment for a source repository in a project.
        /// Dev Environments are specific to the user who creates them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        public virtual GetDevEnvironmentResponse GetDevEnvironment(GetDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a Dev Environment for a source repository in a project.
        /// Dev Environments are specific to the user who creates them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        public virtual Task<GetDevEnvironmentResponse> GetDevEnvironmentAsync(GetDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProject


        /// <summary>
        /// Returns information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSourceRepository


        /// <summary>
        /// Returns information about a source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepository service method.</param>
        /// 
        /// <returns>The response from the GetSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepository">REST API Reference for GetSourceRepository Operation</seealso>
        public virtual GetSourceRepositoryResponse GetSourceRepository(GetSourceRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetSourceRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSourceRepository service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepository">REST API Reference for GetSourceRepository Operation</seealso>
        public virtual Task<GetSourceRepositoryResponse> GetSourceRepositoryAsync(GetSourceRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSourceRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSourceRepositoryCloneUrls


        /// <summary>
        /// Returns information about the URLs that can be used with a Git client to clone a source
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls service method.</param>
        /// 
        /// <returns>The response from the GetSourceRepositoryCloneUrls service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        public virtual GetSourceRepositoryCloneUrlsResponse GetSourceRepositoryCloneUrls(GetSourceRepositoryCloneUrlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryCloneUrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryCloneUrlsResponseUnmarshaller.Instance;

            return Invoke<GetSourceRepositoryCloneUrlsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the URLs that can be used with a Git client to clone a source
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSourceRepositoryCloneUrls service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        public virtual Task<GetSourceRepositoryCloneUrlsResponse> GetSourceRepositoryCloneUrlsAsync(GetSourceRepositoryCloneUrlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryCloneUrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryCloneUrlsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSourceRepositoryCloneUrlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSpace


        /// <summary>
        /// Returns information about an space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual GetSpaceResponse GetSpace(GetSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return Invoke<GetSpaceResponse>(request, options);
        }


        /// <summary>
        /// Returns information about an space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual Task<GetSpaceResponse> GetSpaceAsync(GetSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Returns information about the Amazon Web Services account used for billing purposes
        /// and the billing plan for the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the Amazon Web Services account used for billing purposes
        /// and the billing plan for the space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserDetails


        /// <summary>
        /// Returns information about a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails service method.</param>
        /// 
        /// <returns>The response from the GetUserDetails service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        public virtual GetUserDetailsResponse GetUserDetails(GetUserDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDetailsResponseUnmarshaller.Instance;

            return Invoke<GetUserDetailsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserDetails service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        public virtual Task<GetUserDetailsResponse> GetUserDetailsAsync(GetUserDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetUserDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflow


        /// <summary>
        /// Returns information about a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkflowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowRun


        /// <summary>
        /// Returns information about a specified run of a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowRunResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a specified run of a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowRun service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        public virtual Task<GetWorkflowRunResponse> GetWorkflowRunAsync(GetWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkflowRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessTokens


        /// <summary>
        /// Lists all personal access tokens (PATs) associated with the user who calls the API.
        /// You can only list PATs associated with your Amazon Web Services Builder ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// 
        /// <returns>The response from the ListAccessTokens service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual ListAccessTokensResponse ListAccessTokens(ListAccessTokensRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return Invoke<ListAccessTokensResponse>(request, options);
        }


        /// <summary>
        /// Lists all personal access tokens (PATs) associated with the user who calls the API.
        /// You can only list PATs associated with your Amazon Web Services Builder ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessTokens service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual Task<ListAccessTokensResponse> ListAccessTokensAsync(ListAccessTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessTokensResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevEnvironments


        /// <summary>
        /// Retrieves a list of Dev Environments in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListDevEnvironments service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        public virtual ListDevEnvironmentsResponse ListDevEnvironments(ListDevEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListDevEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of Dev Environments in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevEnvironments service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        public virtual Task<ListDevEnvironmentsResponse> ListDevEnvironmentsAsync(ListDevEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDevEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevEnvironmentSessions


        /// <summary>
        /// Retrieves a list of active sessions for a Dev Environment in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironmentSessions service method.</param>
        /// 
        /// <returns>The response from the ListDevEnvironmentSessions service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironmentSessions">REST API Reference for ListDevEnvironmentSessions Operation</seealso>
        public virtual ListDevEnvironmentSessionsResponse ListDevEnvironmentSessions(ListDevEnvironmentSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentSessionsResponseUnmarshaller.Instance;

            return Invoke<ListDevEnvironmentSessionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of active sessions for a Dev Environment in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironmentSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevEnvironmentSessions service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironmentSessions">REST API Reference for ListDevEnvironmentSessions Operation</seealso>
        public virtual Task<ListDevEnvironmentSessionsResponse> ListDevEnvironmentSessionsAsync(ListDevEnvironmentSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDevEnvironmentSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventLogs


        /// <summary>
        /// Retrieves a list of events that occurred during a specific time in a space. You can
        /// use these events to audit user and system activity in a space. For more information,
        /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-monitoring.html">Monitoring</a>
        /// in the <i>Amazon CodeCatalyst User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// ListEventLogs guarantees events for the last 30 days in a given space. You can also
        /// view and retrieve a list of management events over the last 90 days for Amazon CodeCatalyst
        /// in the CloudTrail console by viewing Event history, or by creating a trail to create
        /// and maintain a record of events that extends past 90 days. For more information, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/view-cloudtrail-events.html">Working
        /// with CloudTrail Event History</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-getting-started.html">Working
        /// with CloudTrail trails</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs service method.</param>
        /// 
        /// <returns>The response from the ListEventLogs service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        public virtual ListEventLogsResponse ListEventLogs(ListEventLogsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogsResponseUnmarshaller.Instance;

            return Invoke<ListEventLogsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of events that occurred during a specific time in a space. You can
        /// use these events to audit user and system activity in a space. For more information,
        /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-monitoring.html">Monitoring</a>
        /// in the <i>Amazon CodeCatalyst User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// ListEventLogs guarantees events for the last 30 days in a given space. You can also
        /// view and retrieve a list of management events over the last 90 days for Amazon CodeCatalyst
        /// in the CloudTrail console by viewing Event history, or by creating a trail to create
        /// and maintain a record of events that extends past 90 days. For more information, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/view-cloudtrail-events.html">Working
        /// with CloudTrail Event History</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-getting-started.html">Working
        /// with CloudTrail trails</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventLogs service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        public virtual Task<ListEventLogsResponse> ListEventLogsAsync(ListEventLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEventLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Retrieves a list of projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSourceRepositories


        /// <summary>
        /// Retrieves a list of source repositories in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories service method.</param>
        /// 
        /// <returns>The response from the ListSourceRepositories service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        public virtual ListSourceRepositoriesResponse ListSourceRepositories(ListSourceRepositoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListSourceRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of source repositories in a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceRepositories service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        public virtual Task<ListSourceRepositoriesResponse> ListSourceRepositoriesAsync(ListSourceRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSourceRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSourceRepositoryBranches


        /// <summary>
        /// Retrieves a list of branches in a specified source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches service method.</param>
        /// 
        /// <returns>The response from the ListSourceRepositoryBranches service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        public virtual ListSourceRepositoryBranchesResponse ListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoryBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoryBranchesResponseUnmarshaller.Instance;

            return Invoke<ListSourceRepositoryBranchesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of branches in a specified source repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceRepositoryBranches service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        public virtual Task<ListSourceRepositoryBranchesResponse> ListSourceRepositoryBranchesAsync(ListSourceRepositoryBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoryBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoryBranchesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSourceRepositoryBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSpaces


        /// <summary>
        /// Retrieves a list of spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual ListSpacesResponse ListSpaces(ListSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSpaces service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual Task<ListSpacesResponse> ListSpacesAsync(ListSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSpacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflowRuns


        /// <summary>
        /// Retrieves a list of workflow runs of a specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowRuns service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual ListWorkflowRunsResponse ListWorkflowRuns(ListWorkflowRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowRunsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of workflow runs of a specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowRuns service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        public virtual Task<ListWorkflowRunsResponse> ListWorkflowRunsAsync(ListWorkflowRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowRunsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkflowRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflows


        /// <summary>
        /// Retrieves a list of workflows in a specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of workflows in a specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkflowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDevEnvironment


        /// <summary>
        /// Starts a specified Dev Environment and puts it into an active state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the StartDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        public virtual StartDevEnvironmentResponse StartDevEnvironment(StartDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<StartDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Starts a specified Dev Environment and puts it into an active state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        public virtual Task<StartDevEnvironmentResponse> StartDevEnvironmentAsync(StartDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDevEnvironmentSession


        /// <summary>
        /// Starts a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession service method.</param>
        /// 
        /// <returns>The response from the StartDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        public virtual StartDevEnvironmentSessionResponse StartDevEnvironmentSession(StartDevEnvironmentSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentSessionResponseUnmarshaller.Instance;

            return Invoke<StartDevEnvironmentSessionResponse>(request, options);
        }


        /// <summary>
        /// Starts a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        public virtual Task<StartDevEnvironmentSessionResponse> StartDevEnvironmentSessionAsync(StartDevEnvironmentSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDevEnvironmentSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkflowRun


        /// <summary>
        /// Begins a run of a specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun service method.</param>
        /// 
        /// <returns>The response from the StartWorkflowRun service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual StartWorkflowRunResponse StartWorkflowRun(StartWorkflowRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowRunResponse>(request, options);
        }


        /// <summary>
        /// Begins a run of a specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflowRun service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartWorkflowRun">REST API Reference for StartWorkflowRun Operation</seealso>
        public virtual Task<StartWorkflowRunResponse> StartWorkflowRunAsync(StartWorkflowRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartWorkflowRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartWorkflowRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDevEnvironment


        /// <summary>
        /// Pauses a specified Dev Environment and places it in a non-running state. Stopped Dev
        /// Environments do not consume compute minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the StopDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        public virtual StopDevEnvironmentResponse StopDevEnvironment(StopDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<StopDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Pauses a specified Dev Environment and places it in a non-running state. Stopped Dev
        /// Environments do not consume compute minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        public virtual Task<StopDevEnvironmentResponse> StopDevEnvironmentAsync(StopDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDevEnvironmentSession


        /// <summary>
        /// Stops a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironmentSession service method.</param>
        /// 
        /// <returns>The response from the StopDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironmentSession">REST API Reference for StopDevEnvironmentSession Operation</seealso>
        public virtual StopDevEnvironmentSessionResponse StopDevEnvironmentSession(StopDevEnvironmentSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentSessionResponseUnmarshaller.Instance;

            return Invoke<StopDevEnvironmentSessionResponse>(request, options);
        }


        /// <summary>
        /// Stops a session for a specified Dev Environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironmentSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDevEnvironmentSession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironmentSession">REST API Reference for StopDevEnvironmentSession Operation</seealso>
        public virtual Task<StopDevEnvironmentSessionResponse> StopDevEnvironmentSessionAsync(StopDevEnvironmentSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDevEnvironmentSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevEnvironment


        /// <summary>
        /// Changes one or more values for a Dev Environment. Updating certain values of the Dev
        /// Environment will cause a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        public virtual UpdateDevEnvironmentResponse UpdateDevEnvironment(UpdateDevEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Changes one or more values for a Dev Environment. Updating certain values of the Dev
        /// Environment will cause a restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevEnvironment service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        public virtual Task<UpdateDevEnvironmentResponse> UpdateDevEnvironmentAsync(UpdateDevEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDevEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Changes one or more values for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }


        /// <summary>
        /// Changes one or more values for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSpace


        /// <summary>
        /// Changes one or more values for a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateSpaceResponse>(request, options);
        }


        /// <summary>
        /// Changes one or more values for a space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSpace service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateSpace">REST API Reference for UpdateSpace Operation</seealso>
        public virtual Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSpaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSpaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifySession


        /// <summary>
        /// Verifies whether the calling user has a valid Amazon CodeCatalyst login and session.
        /// If successful, this returns the ID of the user in Amazon CodeCatalyst.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySession service method.</param>
        /// 
        /// <returns>The response from the VerifySession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        public virtual VerifySessionResponse VerifySession(VerifySessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySessionResponseUnmarshaller.Instance;

            return Invoke<VerifySessionResponse>(request, options);
        }


        /// <summary>
        /// Verifies whether the calling user has a valid Amazon CodeCatalyst login and session.
        /// If successful, this returns the ID of the user in Amazon CodeCatalyst.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifySession service method, as returned by CodeCatalyst.</returns>
        /// <exception cref="Amazon.CodeCatalyst.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient access to perform this action.
        /// Verify that you are a member of a role that allows this action.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ConflictException">
        /// The request was denied because the requested operation would cause a conflict with
        /// the current state of a service resource associated with the request. Another user
        /// might have updated the resource. Reload, make sure you have the latest data, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ResourceNotFoundException">
        /// The request was denied because the specified resource was not found. Verify that the
        /// spelling is correct and that you have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ServiceQuotaExceededException">
        /// The request was denied because one or more resources has reached its limits for the
        /// tier the space belongs to. Either reduce the number of resources, or change the tier
        /// if applicable.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeCatalyst.Model.ValidationException">
        /// The request was denied because an input failed to satisfy the constraints specified
        /// by the service. Check the spelling and input requirements, and then try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        public virtual Task<VerifySessionResponse> VerifySessionAsync(VerifySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<VerifySessionResponse>(request, options, cancellationToken);
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
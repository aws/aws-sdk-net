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
using System.Collections.Generic;
using System.Net;

using Amazon.CodeCatalyst.Model;
using Amazon.CodeCatalyst.Model.Internal.MarshallTransformations;
using Amazon.CodeCatalyst.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeCatalyst
{
    /// <summary>
    /// Implementation for accessing CodeCatalyst
    ///
    /// <note> 
    /// <para>
    ///  <b>Amazon CodeCatalyst is in preview release and subject to change.</b> 
    /// </para>
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon CodeCatalyst API reference. This reference provides descriptions
    /// of operations and data types for Amazon CodeCatalyst. You can use the Amazon CodeCatalyst
    /// API to work with the following objects. 
    /// </para>
    ///  
    /// <para>
    /// Dev Environments and the Amazon Web Services Toolkits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAccessToken</a>, which creates a personal access token (PAT) for the current
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateDevEnvironment</a>, which creates a Dev Environment, where you can quickly
    /// work on the code stored in the source repositories of your project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateProject</a> which creates a project in a specified space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSourceRepositoryBranch</a>, which creates a branch in a specified repository
    /// where you can work on code.
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
    ///  <a>GetProject</a>, which returns information about a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSourceRepositoryCloneUrls</a>, which returns information about the URLs that
    /// can be used with a Git client to clone a source repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetSubscription</a>, which returns information about the Amazon Web Services account
    /// used for billing purposes and the billing plan for the space.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetUserDetails</a>, which returns information about a user in Amazon CodeCatalyst.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListDevEnvironments</a>, which retrives a list of Dev Environments in a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListProjects</a>, which retrieves a list of projects in a space.
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
    ///  </li> <li> 
    /// <para>
    ///  <a>ListSpaces</a>, which retrieves a list of spaces.
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
    ///  <a>UpdateDevEnvironment</a>, which changes one or more values for a Dev Environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>VerifySession</a>, which verifies whether the calling user has a valid Amazon
    /// CodeCatalyst login and session.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Security, activity, and resource management in Amazon CodeCatalyst, by calling the
    /// following:
    /// </para>
    ///  <ul> <li> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeCatalystClient : AmazonServiceClient, IAmazonCodeCatalyst
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeCatalystMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), new AmazonCodeCatalystConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), new AmazonCodeCatalystConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(fallbackToAnonymous: true), config) { }

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new BearerTokenSigner();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeCatalystEndpointResolver());
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
        /// (PAT) is similar to a password. It is associated with your user account. You use PATs
        /// to access Amazon CodeCatalyst resources such as source repositories from third-party
        /// applications like Git and integrated development environments (IDEs). For more information,
        /// see <a href="https://docs.aws.amazon.com/codecatalyst/latest/userguide/ipa-tokens-keys.html">Managing
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return Invoke<CreateAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessToken operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual IAsyncResult BeginCreateAccessToken(CreateAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessToken.</param>
        /// 
        /// <returns>Returns a  CreateAccessTokenResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateAccessToken">REST API Reference for CreateAccessToken Operation</seealso>
        public virtual CreateAccessTokenResponse EndCreateAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDevEnvironment

        /// <summary>
        /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development Dev Environment
        /// that you can use to quickly work on the code stored in the source repositories of
        /// your project. By default, a Dev Environment is configured to have a 2 core processor,
        /// 4GB of RAM, and 16GB of persistent storage.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateDevEnvironment(CreateDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateDevEnvironment">REST API Reference for CreateDevEnvironment Operation</seealso>
        public virtual CreateDevEnvironmentResponse EndCreateDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryBranchResponseUnmarshaller.Instance;

            return Invoke<CreateSourceRepositoryBranchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSourceRepositoryBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSourceRepositoryBranch operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSourceRepositoryBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        public virtual IAsyncResult BeginCreateSourceRepositoryBranch(CreateSourceRepositoryBranchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSourceRepositoryBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSourceRepositoryBranchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSourceRepositoryBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSourceRepositoryBranch.</param>
        /// 
        /// <returns>Returns a  CreateSourceRepositoryBranchResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/CreateSourceRepositoryBranch">REST API Reference for CreateSourceRepositoryBranch Operation</seealso>
        public virtual CreateSourceRepositoryBranchResponse EndCreateSourceRepositoryBranch(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSourceRepositoryBranchResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessToken operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccessToken(DeleteAccessTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessToken.</param>
        /// 
        /// <returns>Returns a  DeleteAccessTokenResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteAccessToken">REST API Reference for DeleteAccessToken Operation</seealso>
        public virtual DeleteAccessTokenResponse EndDeleteAccessToken(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessTokenResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevEnvironment(DeleteDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/DeleteDevEnvironment">REST API Reference for DeleteDevEnvironment Operation</seealso>
        public virtual DeleteDevEnvironmentResponse EndDeleteDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetDevEnvironment(GetDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevEnvironment.</param>
        /// 
        /// <returns>Returns a  GetDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetDevEnvironment">REST API Reference for GetDevEnvironment Operation</seealso>
        public virtual GetDevEnvironmentResponse EndGetDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse EndGetProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProjectResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryCloneUrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryCloneUrlsResponseUnmarshaller.Instance;

            return Invoke<GetSourceRepositoryCloneUrlsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSourceRepositoryCloneUrls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSourceRepositoryCloneUrls operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSourceRepositoryCloneUrls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        public virtual IAsyncResult BeginGetSourceRepositoryCloneUrls(GetSourceRepositoryCloneUrlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSourceRepositoryCloneUrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSourceRepositoryCloneUrlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSourceRepositoryCloneUrls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSourceRepositoryCloneUrls.</param>
        /// 
        /// <returns>Returns a  GetSourceRepositoryCloneUrlsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSourceRepositoryCloneUrls">REST API Reference for GetSourceRepositoryCloneUrls Operation</seealso>
        public virtual GetSourceRepositoryCloneUrlsResponse EndGetSourceRepositoryCloneUrls(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSourceRepositoryCloneUrlsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return Invoke<GetSpaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpace operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual IAsyncResult BeginGetSpace(GetSpaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpace.</param>
        /// 
        /// <returns>Returns a  GetSpaceResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSpace">REST API Reference for GetSpace Operation</seealso>
        public virtual GetSpaceResponse EndGetSpace(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpaceResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual IAsyncResult BeginGetSubscription(GetSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscription.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse EndGetSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDetailsResponseUnmarshaller.Instance;

            return Invoke<GetUserDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserDetails operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        public virtual IAsyncResult BeginGetUserDetails(GetUserDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserDetails.</param>
        /// 
        /// <returns>Returns a  GetUserDetailsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/GetUserDetails">REST API Reference for GetUserDetails Operation</seealso>
        public virtual GetUserDetailsResponse EndGetUserDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccessTokens

        /// <summary>
        /// Lists all personal access tokens (PATs) associated with the user who calls the API.
        /// You can only list PATs associated with your user account.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return Invoke<ListAccessTokensResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessTokens operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual IAsyncResult BeginListAccessTokens(ListAccessTokensRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessTokensRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessTokensResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessTokens.</param>
        /// 
        /// <returns>Returns a  ListAccessTokensResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListAccessTokens">REST API Reference for ListAccessTokens Operation</seealso>
        public virtual ListAccessTokensResponse EndListAccessTokens(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessTokensResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDevEnvironments

        /// <summary>
        /// Retrives a list of Dev Environments in a project.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListDevEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevEnvironments operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListDevEnvironments(ListDevEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevEnvironments.</param>
        /// 
        /// <returns>Returns a  ListDevEnvironmentsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListDevEnvironments">REST API Reference for ListDevEnvironments Operation</seealso>
        public virtual ListDevEnvironmentsResponse EndListDevEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDevEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventLogs

        /// <summary>
        /// Retrieves a list of events that occurred during a specified time period in a space.
        /// You can use these events to audit user and system activity in a space.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogsResponseUnmarshaller.Instance;

            return Invoke<ListEventLogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventLogs operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        public virtual IAsyncResult BeginListEventLogs(ListEventLogsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventLogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventLogs.</param>
        /// 
        /// <returns>Returns a  ListEventLogsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListEventLogs">REST API Reference for ListEventLogs Operation</seealso>
        public virtual ListEventLogsResponse EndListEventLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventLogsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListSourceRepositoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositories operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        public virtual IAsyncResult BeginListSourceRepositories(ListSourceRepositoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceRepositories.</param>
        /// 
        /// <returns>Returns a  ListSourceRepositoriesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositories">REST API Reference for ListSourceRepositories Operation</seealso>
        public virtual ListSourceRepositoriesResponse EndListSourceRepositories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceRepositoriesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoryBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoryBranchesResponseUnmarshaller.Instance;

            return Invoke<ListSourceRepositoryBranchesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceRepositoryBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceRepositoryBranches operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceRepositoryBranches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        public virtual IAsyncResult BeginListSourceRepositoryBranches(ListSourceRepositoryBranchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceRepositoryBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceRepositoryBranchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceRepositoryBranches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceRepositoryBranches.</param>
        /// 
        /// <returns>Returns a  ListSourceRepositoryBranchesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSourceRepositoryBranches">REST API Reference for ListSourceRepositoryBranches Operation</seealso>
        public virtual ListSourceRepositoryBranchesResponse EndListSourceRepositoryBranches(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceRepositoryBranchesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return Invoke<ListSpacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpaces operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual IAsyncResult BeginListSpaces(ListSpacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpaces.</param>
        /// 
        /// <returns>Returns a  ListSpacesResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/ListSpaces">REST API Reference for ListSpaces Operation</seealso>
        public virtual ListSpacesResponse EndListSpaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSpacesResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<StartDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginStartDevEnvironment(StartDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDevEnvironment.</param>
        /// 
        /// <returns>Returns a  StartDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironment">REST API Reference for StartDevEnvironment Operation</seealso>
        public virtual StartDevEnvironmentResponse EndStartDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentSessionResponseUnmarshaller.Instance;

            return Invoke<StartDevEnvironmentSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDevEnvironmentSession operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDevEnvironmentSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        public virtual IAsyncResult BeginStartDevEnvironmentSession(StartDevEnvironmentSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDevEnvironmentSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDevEnvironmentSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDevEnvironmentSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDevEnvironmentSession.</param>
        /// 
        /// <returns>Returns a  StartDevEnvironmentSessionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StartDevEnvironmentSession">REST API Reference for StartDevEnvironmentSession Operation</seealso>
        public virtual StartDevEnvironmentSessionResponse EndStartDevEnvironmentSession(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDevEnvironmentSessionResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<StopDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginStopDevEnvironment(StopDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDevEnvironment.</param>
        /// 
        /// <returns>Returns a  StopDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/StopDevEnvironment">REST API Reference for StopDevEnvironment Operation</seealso>
        public virtual StopDevEnvironmentResponse EndStopDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateDevEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevEnvironment operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevEnvironment(UpdateDevEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateDevEnvironmentResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/UpdateDevEnvironment">REST API Reference for UpdateDevEnvironment Operation</seealso>
        public virtual UpdateDevEnvironmentResponse EndUpdateDevEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDevEnvironmentResponse>(asyncResult);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySessionResponseUnmarshaller.Instance;

            return Invoke<VerifySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySession operation on AmazonCodeCatalystClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        public virtual IAsyncResult BeginVerifySession(VerifySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifySession.</param>
        /// 
        /// <returns>Returns a  VerifySessionResult from CodeCatalyst.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecatalyst-2022-09-28/VerifySession">REST API Reference for VerifySession Operation</seealso>
        public virtual VerifySessionResponse EndVerifySession(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifySessionResponse>(asyncResult);
        }

        #endregion
        
    }
}
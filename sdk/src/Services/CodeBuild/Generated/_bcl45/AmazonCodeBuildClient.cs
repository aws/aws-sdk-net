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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeBuild.Model;
using Amazon.CodeBuild.Model.Internal.MarshallTransformations;
using Amazon.CodeBuild.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeBuild
{
    /// <summary>
    /// Implementation for accessing CodeBuild
    ///
    /// AWS CodeBuild 
    /// <para>
    /// AWS CodeBuild is a fully managed build service in the cloud. AWS CodeBuild compiles
    /// your source code, runs unit tests, and produces artifacts that are ready to deploy.
    /// AWS CodeBuild eliminates the need to provision, manage, and scale your own build servers.
    /// It provides prepackaged build environments for the most popular programming languages
    /// and build tools, such as Apache Maven, Gradle, and more. You can also fully customize
    /// build environments in AWS CodeBuild to use your own build tools. AWS CodeBuild scales
    /// automatically to meet peak build requests. You pay only for the build time you consume.
    /// For more information about AWS CodeBuild, see the <i>AWS CodeBuild User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS CodeBuild supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>BatchDeleteBuilds</code>: Deletes one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetProjects</code>: Gets information about one or more build projects.
    /// A <i>build project</i> defines how AWS CodeBuild runs a build. This includes information
    /// such as where to get the source code to build, the build environment to use, the build
    /// commands to run, and where to store the build output. A <i>build environment</i> is
    /// a representation of operating system, programming language runtime, and tools that
    /// AWS CodeBuild uses to run a build. You can add tags to build projects to help manage
    /// your resources and costs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateProject</code>: Creates a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, enables AWS CodeBuild
    /// to start rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateWebhook</code>: Changes the settings of an existing webhook.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteProject</code>: Deletes a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, stops AWS CodeBuild from
    /// rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>: Gets a list of build project names, with each build project
    /// name representing a single build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateProject</code>: Changes the settings of an existing build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetBuilds</code>: Gets information about one or more builds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuilds</code>: Gets a list of build IDs, with each build ID representing
    /// a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListBuildsForProject</code>: Gets a list of build IDs for the specified build
    /// project, with each build ID representing a single build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StartBuild</code>: Starts running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StopBuild</code>: Attempts to stop running a build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListCuratedEnvironmentImages</code>: Gets information about Docker images that
    /// are managed by AWS CodeBuild.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteSourceCredentials</code>: Deletes a set of GitHub, GitHub Enterprise,
    /// or Bitbucket source credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportSourceCredentials</code>: Imports the source repository credentials for
    /// an AWS CodeBuild project that has its source code stored in a GitHub, GitHub Enterprise,
    /// or Bitbucket repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSourceCredentials</code>: Returns a list of <code>SourceCredentialsInfo</code>
    /// objects. Each <code>SourceCredentialsInfo</code> object includes the authentication
    /// type, token ARN, and type of source provider for one set of credentials.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeBuildClient : AmazonServiceClient, IAmazonCodeBuild
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeBuildMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        public AmazonCodeBuildClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeBuildConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        public AmazonCodeBuildClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeBuildConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(AmazonCodeBuildConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeBuildClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeBuildConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Credentials and an
        /// AmazonCodeBuildClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(AWSCredentials credentials, AmazonCodeBuildConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeBuildConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeBuildClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeBuildConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeBuildConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeBuildConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeBuildClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeBuildClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeBuildClient Configuration Object</param>
        public AmazonCodeBuildClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeBuildConfig clientConfig)
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
            return new AWS4Signer();
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


        #region  BatchDeleteBuilds


        /// <summary>
        /// Deletes one or more builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        public virtual BatchDeleteBuildsResponse BatchDeleteBuilds(BatchDeleteBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBuildsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteBuildsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        public virtual Task<BatchDeleteBuildsResponse> BatchDeleteBuildsAsync(BatchDeleteBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBuildsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteBuildsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetBuilds


        /// <summary>
        /// Gets information about builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        public virtual BatchGetBuildsResponse BatchGetBuilds(BatchGetBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBuildsResponseUnmarshaller.Instance;

            return Invoke<BatchGetBuildsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        public virtual Task<BatchGetBuildsResponse> BatchGetBuildsAsync(BatchGetBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBuildsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetBuildsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetProjects


        /// <summary>
        /// Gets information about build projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects service method.</param>
        /// 
        /// <returns>The response from the BatchGetProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        public virtual BatchGetProjectsResponse BatchGetProjects(BatchGetProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetProjectsResponseUnmarshaller.Instance;

            return Invoke<BatchGetProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        public virtual Task<BatchGetProjectsResponse> BatchGetProjectsAsync(BatchGetProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProject


        /// <summary>
        /// Creates a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebhook


        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, enables AWS CodeBuild to start rebuilding the source code
        /// every time a code change is pushed to the repository.
        /// 
        ///  <important> 
        /// <para>
        /// If you enable webhooks for an AWS CodeBuild project, and the project is used as a
        /// build step in AWS CodePipeline, then two identical builds are created for each commit.
        /// One build is triggered through webhooks, and one through AWS CodePipeline. Because
        /// billing is on a per-build basis, you are billed for both builds. Therefore, if you
        /// are using AWS CodePipeline, we recommend that you disable webhooks in AWS CodeBuild.
        /// In the AWS CodeBuild console, clear the Webhook box. For more information, see step
        /// 5 in <a href="http://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
        /// a Build Project's Settings</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual CreateWebhookResponse CreateWebhook(CreateWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebhookResponseUnmarshaller.Instance;

            return Invoke<CreateWebhookResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual Task<CreateWebhookResponse> CreateWebhookAsync(CreateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProject


        /// <summary>
        /// Deletes a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSourceCredentials


        /// <summary>
        /// Deletes a set of GitHub, GitHub Enterprise, or Bitbucket source credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        public virtual DeleteSourceCredentialsResponse DeleteSourceCredentials(DeleteSourceCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteSourceCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        public virtual Task<DeleteSourceCredentialsResponse> DeleteSourceCredentialsAsync(DeleteSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSourceCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
        /// or Bitbucket repository, stops AWS CodeBuild from rebuilding the source code every
        /// time a code change is pushed to the repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return Invoke<DeleteWebhookResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportSourceCredentials


        /// <summary>
        /// Imports the source repository credentials for an AWS CodeBuild project that has its
        /// source code stored in a GitHub, GitHub Enterprise, or Bitbucket repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ImportSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        public virtual ImportSourceCredentialsResponse ImportSourceCredentials(ImportSourceCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSourceCredentialsResponseUnmarshaller.Instance;

            return Invoke<ImportSourceCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        public virtual Task<ImportSourceCredentialsResponse> ImportSourceCredentialsAsync(ImportSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSourceCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportSourceCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvalidateProjectCache


        /// <summary>
        /// Resets the cache for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache service method.</param>
        /// 
        /// <returns>The response from the InvalidateProjectCache service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        public virtual InvalidateProjectCacheResponse InvalidateProjectCache(InvalidateProjectCacheRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvalidateProjectCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvalidateProjectCacheResponseUnmarshaller.Instance;

            return Invoke<InvalidateProjectCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvalidateProjectCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        public virtual Task<InvalidateProjectCacheResponse> InvalidateProjectCacheAsync(InvalidateProjectCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvalidateProjectCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvalidateProjectCacheResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvalidateProjectCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuilds


        /// <summary>
        /// Gets a list of build IDs, with each build ID representing a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds service method.</param>
        /// 
        /// <returns>The response from the ListBuilds service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBuildsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuildsForProject


        /// <summary>
        /// Gets a list of build IDs for the specified build project, with each build ID representing
        /// a single build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildsForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        public virtual ListBuildsForProjectResponse ListBuildsForProject(ListBuildsForProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsForProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsForProjectResponseUnmarshaller.Instance;

            return Invoke<ListBuildsForProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildsForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        public virtual Task<ListBuildsForProjectResponse> ListBuildsForProjectAsync(ListBuildsForProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsForProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsForProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBuildsForProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCuratedEnvironmentImages


        /// <summary>
        /// Gets information about Docker images that are managed by AWS CodeBuild.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages service method.</param>
        /// 
        /// <returns>The response from the ListCuratedEnvironmentImages service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        public virtual ListCuratedEnvironmentImagesResponse ListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCuratedEnvironmentImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCuratedEnvironmentImagesResponseUnmarshaller.Instance;

            return Invoke<ListCuratedEnvironmentImagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCuratedEnvironmentImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        public virtual Task<ListCuratedEnvironmentImagesResponse> ListCuratedEnvironmentImagesAsync(ListCuratedEnvironmentImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCuratedEnvironmentImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCuratedEnvironmentImagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCuratedEnvironmentImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProjects


        /// <summary>
        /// Gets a list of build project names, with each build project name representing a single
        /// build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSourceCredentials


        /// <summary>
        /// Returns a list of <code>SourceCredentialsInfo</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        public virtual ListSourceCredentialsResponse ListSourceCredentials(ListSourceCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListSourceCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        public virtual Task<ListSourceCredentialsResponse> ListSourceCredentialsAsync(ListSourceCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceCredentialsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSourceCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBuild


        /// <summary>
        /// Starts running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuild service method.</param>
        /// 
        /// <returns>The response from the StartBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        public virtual StartBuildResponse StartBuild(StartBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBuildResponseUnmarshaller.Instance;

            return Invoke<StartBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        public virtual Task<StartBuildResponse> StartBuildAsync(StartBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBuildResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopBuild


        /// <summary>
        /// Attempts to stop running a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuild service method.</param>
        /// 
        /// <returns>The response from the StopBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        public virtual StopBuildResponse StopBuild(StopBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBuildResponseUnmarshaller.Instance;

            return Invoke<StopBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        public virtual Task<StopBuildResponse> StopBuildAsync(StopBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBuildResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProject


        /// <summary>
        /// Changes the settings of a build project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebhook


        /// <summary>
        /// Updates the webhook associated with an AWS CodeBuild build project. 
        /// 
        ///  <note> 
        /// <para>
        ///  If you use Bitbucket for your repository, <code>rotateSecret</code> is ignored. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.OAuthProviderException">
        /// There was a problem with the underlying OAuth provider.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebhookResponseUnmarshaller.Instance;

            return Invoke<UpdateWebhookResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebhook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */


using System;
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
    /// For more information about AWS CodeBuild, see the <i> <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/welcome.html">AWS
    /// CodeBuild User Guide</a>.</i> 
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
    ///  <code>BatchGetBuilds</code>: Gets information about one or more builds.
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
    ///  <code>BatchGetReportGroups</code>: Returns an array of report groups. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>BatchGetReports</code>: Returns an array of reports. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateProject</code>: Creates a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateReportGroup</code>: Creates a report group. A report group contains a
    /// collection of reports. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, enables AWS CodeBuild
    /// to start rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteProject</code>: Deletes a build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteReport</code>: Deletes a report. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteReportGroup</code>: Deletes a report group. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteResourcePolicy</code>: Deletes a resource policy that is identified by
    /// its resource ARN. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteSourceCredentials</code>: Deletes a set of GitHub, GitHub Enterprise,
    /// or Bitbucket source credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteWebhook</code>: For an existing AWS CodeBuild build project that has
    /// its source code stored in a GitHub or Bitbucket repository, stops AWS CodeBuild from
    /// rebuilding the source code every time a code change is pushed to the repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeTestCases</code>: Returns a list of details about test cases for a
    /// report. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>GetResourcePolicy</code>: Gets a resource policy that is identified by its
    /// resource ARN. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportSourceCredentials</code>: Imports the source repository credentials for
    /// an AWS CodeBuild project that has its source code stored in a GitHub, GitHub Enterprise,
    /// or Bitbucket repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>InvalidateProjectCache</code>: Resets the cache for a project.
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
    ///  <code>ListCuratedEnvironmentImages</code>: Gets information about Docker images that
    /// are managed by AWS CodeBuild.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListProjects</code>: Gets a list of build project names, with each build project
    /// name representing a single build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReportGroups</code>: Gets a list ARNs for the report groups in the current
    /// AWS account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReports</code>: Gets a list ARNs for the reports in the current AWS account.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListReportsForReportGroup</code>: Returns a list of ARNs for the reports that
    /// belong to a <code>ReportGroup</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSharedProjects</code>: Gets a list of ARNs associated with projects shared
    /// with the current AWS account or user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSharedReportGroups</code>: Gets a list of ARNs associated with report groups
    /// shared with the current AWS account or user
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListSourceCredentials</code>: Returns a list of <code>SourceCredentialsInfo</code>
    /// objects. Each <code>SourceCredentialsInfo</code> object includes the authentication
    /// type, token ARN, and type of source provider for one set of credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PutResourcePolicy</code>: Stores a resource policy for the ARN of a <code>Project</code>
    /// or <code>ReportGroup</code> object. 
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
    ///  <code>UpdateProject</code>: Changes the settings of an existing build project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateReportGroup</code>: Changes a report group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateWebhook</code>: Changes the settings of an existing webhook.
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
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteBuilds(BatchDeleteBuildsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteBuildsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBuilds.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchDeleteBuilds">REST API Reference for BatchDeleteBuilds Operation</seealso>
        public virtual BatchDeleteBuildsResponse EndBatchDeleteBuilds(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteBuildsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetBuildBatches

        /// <summary>
        /// Retrieves information about one or more batch builds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches service method.</param>
        /// 
        /// <returns>The response from the BatchGetBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        public virtual BatchGetBuildBatchesResponse BatchGetBuildBatches(BatchGetBuildBatchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBuildBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBuildBatchesResponseUnmarshaller.Instance;

            return Invoke<BatchGetBuildBatchesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuildBatches operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetBuildBatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        public virtual IAsyncResult BeginBatchGetBuildBatches(BatchGetBuildBatchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBuildBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBuildBatchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetBuildBatches.</param>
        /// 
        /// <returns>Returns a  BatchGetBuildBatchesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuildBatches">REST API Reference for BatchGetBuildBatches Operation</seealso>
        public virtual BatchGetBuildBatchesResponse EndBatchGetBuildBatches(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetBuildBatchesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetBuilds

        /// <summary>
        /// Gets information about one or more builds.
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
        /// <param name="request">Container for the necessary parameters to execute the BatchGetBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        public virtual IAsyncResult BeginBatchGetBuilds(BatchGetBuildsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetBuildsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetBuilds.</param>
        /// 
        /// <returns>Returns a  BatchGetBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetBuilds">REST API Reference for BatchGetBuilds Operation</seealso>
        public virtual BatchGetBuildsResponse EndBatchGetBuilds(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetBuildsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetProjects

        /// <summary>
        /// Gets information about one or more build projects.
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
        /// <param name="request">Container for the necessary parameters to execute the BatchGetProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        public virtual IAsyncResult BeginBatchGetProjects(BatchGetProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetProjects.</param>
        /// 
        /// <returns>Returns a  BatchGetProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetProjects">REST API Reference for BatchGetProjects Operation</seealso>
        public virtual BatchGetProjectsResponse EndBatchGetProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetReportGroups

        /// <summary>
        /// Returns an array of report groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups service method.</param>
        /// 
        /// <returns>The response from the BatchGetReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        public virtual BatchGetReportGroupsResponse BatchGetReportGroups(BatchGetReportGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetReportGroupsResponseUnmarshaller.Instance;

            return Invoke<BatchGetReportGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        public virtual IAsyncResult BeginBatchGetReportGroups(BatchGetReportGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetReportGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetReportGroups.</param>
        /// 
        /// <returns>Returns a  BatchGetReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReportGroups">REST API Reference for BatchGetReportGroups Operation</seealso>
        public virtual BatchGetReportGroupsResponse EndBatchGetReportGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetReportGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetReports

        /// <summary>
        /// Returns an array of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports service method.</param>
        /// 
        /// <returns>The response from the BatchGetReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        public virtual BatchGetReportsResponse BatchGetReports(BatchGetReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetReportsResponseUnmarshaller.Instance;

            return Invoke<BatchGetReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetReports operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        public virtual IAsyncResult BeginBatchGetReports(BatchGetReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetReports.</param>
        /// 
        /// <returns>Returns a  BatchGetReportsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/BatchGetReports">REST API Reference for BatchGetReports Operation</seealso>
        public virtual BatchGetReportsResponse EndBatchGetReports(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetReportsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
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
        /// <returns>Returns a  CreateProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReportGroup

        /// <summary>
        /// Creates a report group. A report group contains a collection of reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReportGroup service method, as returned by CodeBuild.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        public virtual CreateReportGroupResponse CreateReportGroup(CreateReportGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReportGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateReportGroup(CreateReportGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReportGroup.</param>
        /// 
        /// <returns>Returns a  CreateReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateReportGroup">REST API Reference for CreateReportGroup Operation</seealso>
        public virtual CreateReportGroupResponse EndCreateReportGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReportGroupResponse>(asyncResult);
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
        /// 5 in <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
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
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual IAsyncResult BeginCreateWebhook(CreateWebhookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebhookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebhook.</param>
        /// 
        /// <returns>Returns a  CreateWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual CreateWebhookResponse EndCreateWebhook(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWebhookResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBuildBatch

        /// <summary>
        /// Deletes a batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch service method.</param>
        /// 
        /// <returns>The response from the DeleteBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        public virtual DeleteBuildBatchResponse DeleteBuildBatch(DeleteBuildBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildBatchResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        public virtual IAsyncResult BeginDeleteBuildBatch(DeleteBuildBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBuildBatch.</param>
        /// 
        /// <returns>Returns a  DeleteBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteBuildBatch">REST API Reference for DeleteBuildBatch Operation</seealso>
        public virtual DeleteBuildBatchResponse EndDeleteBuildBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBuildBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes a build project. When you delete a project, its builds are not deleted.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReport

        /// <summary>
        /// Deletes a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport service method.</param>
        /// 
        /// <returns>The response from the DeleteReport service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        public virtual DeleteReportResponse DeleteReport(DeleteReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportResponseUnmarshaller.Instance;

            return Invoke<DeleteReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReport operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        public virtual IAsyncResult BeginDeleteReport(DeleteReportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReport.</param>
        /// 
        /// <returns>Returns a  DeleteReportResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReport">REST API Reference for DeleteReport Operation</seealso>
        public virtual DeleteReportResponse EndDeleteReport(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReportResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReportGroup

        /// <summary>
        /// Deletes a report group. Before you delete a report group, you must delete its reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        public virtual DeleteReportGroupResponse DeleteReportGroup(DeleteReportGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReportGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteReportGroup(DeleteReportGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReportGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteReportGroup">REST API Reference for DeleteReportGroup Operation</seealso>
        public virtual DeleteReportGroupResponse EndDeleteReportGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReportGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        public virtual IAsyncResult BeginDeleteSourceCredentials(DeleteSourceCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSourceCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteSourceCredentials">REST API Reference for DeleteSourceCredentials Operation</seealso>
        public virtual DeleteSourceCredentialsResponse EndDeleteSourceCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSourceCredentialsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual IAsyncResult BeginDeleteWebhook(DeleteWebhookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebhook.</param>
        /// 
        /// <returns>Returns a  DeleteWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual DeleteWebhookResponse EndDeleteWebhook(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWebhookResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCodeCoverages

        /// <summary>
        /// Retrieves one or more code coverage reports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeCoverages service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        public virtual DescribeCodeCoveragesResponse DescribeCodeCoverages(DescribeCodeCoveragesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeCoveragesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeCoveragesResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeCoveragesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeCoverages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeCoverages operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeCoverages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        public virtual IAsyncResult BeginDescribeCodeCoverages(DescribeCodeCoveragesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeCoveragesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeCoveragesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeCoverages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeCoverages.</param>
        /// 
        /// <returns>Returns a  DescribeCodeCoveragesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeCodeCoverages">REST API Reference for DescribeCodeCoverages Operation</seealso>
        public virtual DescribeCodeCoveragesResponse EndDescribeCodeCoverages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCodeCoveragesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTestCases

        /// <summary>
        /// Returns a list of details about test cases for a report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases service method.</param>
        /// 
        /// <returns>The response from the DescribeTestCases service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        public virtual DescribeTestCasesResponse DescribeTestCases(DescribeTestCasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTestCasesResponseUnmarshaller.Instance;

            return Invoke<DescribeTestCasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTestCases operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        public virtual IAsyncResult BeginDescribeTestCases(DescribeTestCasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTestCasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTestCases.</param>
        /// 
        /// <returns>Returns a  DescribeTestCasesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/DescribeTestCases">REST API Reference for DescribeTestCases Operation</seealso>
        public virtual DescribeTestCasesResponse EndDescribeTestCases(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTestCasesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReportGroupTrend

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportGroupTrend service method.</param>
        /// 
        /// <returns>The response from the GetReportGroupTrend service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        public virtual GetReportGroupTrendResponse GetReportGroupTrend(GetReportGroupTrendRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReportGroupTrendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportGroupTrendResponseUnmarshaller.Instance;

            return Invoke<GetReportGroupTrendResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReportGroupTrend operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReportGroupTrend operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReportGroupTrend
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        public virtual IAsyncResult BeginGetReportGroupTrend(GetReportGroupTrendRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReportGroupTrendRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportGroupTrendResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReportGroupTrend operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReportGroupTrend.</param>
        /// 
        /// <returns>Returns a  GetReportGroupTrendResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetReportGroupTrend">REST API Reference for GetReportGroupTrend Operation</seealso>
        public virtual GetReportGroupTrendResponse EndGetReportGroupTrend(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReportGroupTrendResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Gets a resource policy that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
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
        /// <exception cref="Amazon.CodeBuild.Model.ResourceAlreadyExistsException">
        /// The specified AWS resource cannot be created, because an AWS resource with the same
        /// settings already exists.
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
        /// <param name="request">Container for the necessary parameters to execute the ImportSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        public virtual IAsyncResult BeginImportSourceCredentials(ImportSourceCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSourceCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSourceCredentials.</param>
        /// 
        /// <returns>Returns a  ImportSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ImportSourceCredentials">REST API Reference for ImportSourceCredentials Operation</seealso>
        public virtual ImportSourceCredentialsResponse EndImportSourceCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportSourceCredentialsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the InvalidateProjectCache operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvalidateProjectCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        public virtual IAsyncResult BeginInvalidateProjectCache(InvalidateProjectCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvalidateProjectCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvalidateProjectCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvalidateProjectCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvalidateProjectCache.</param>
        /// 
        /// <returns>Returns a  InvalidateProjectCacheResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/InvalidateProjectCache">REST API Reference for InvalidateProjectCache Operation</seealso>
        public virtual InvalidateProjectCacheResponse EndInvalidateProjectCache(IAsyncResult asyncResult)
        {
            return EndInvoke<InvalidateProjectCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuildBatches

        /// <summary>
        /// Retrieves the identifiers of your build batches in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatches service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        public virtual ListBuildBatchesResponse ListBuildBatches(ListBuildBatchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildBatchesResponseUnmarshaller.Instance;

            return Invoke<ListBuildBatchesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatches operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildBatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        public virtual IAsyncResult BeginListBuildBatches(ListBuildBatchesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildBatchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildBatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildBatches.</param>
        /// 
        /// <returns>Returns a  ListBuildBatchesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatches">REST API Reference for ListBuildBatches Operation</seealso>
        public virtual ListBuildBatchesResponse EndListBuildBatches(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildBatchesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBuildBatchesForProject

        /// <summary>
        /// Retrieves the identifiers of the build batches for a specific project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject service method.</param>
        /// 
        /// <returns>The response from the ListBuildBatchesForProject service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        public virtual ListBuildBatchesForProjectResponse ListBuildBatchesForProject(ListBuildBatchesForProjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildBatchesForProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildBatchesForProjectResponseUnmarshaller.Instance;

            return Invoke<ListBuildBatchesForProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuildBatchesForProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuildBatchesForProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildBatchesForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        public virtual IAsyncResult BeginListBuildBatchesForProject(ListBuildBatchesForProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildBatchesForProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildBatchesForProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildBatchesForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildBatchesForProject.</param>
        /// 
        /// <returns>Returns a  ListBuildBatchesForProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildBatchesForProject">REST API Reference for ListBuildBatchesForProject Operation</seealso>
        public virtual ListBuildBatchesForProjectResponse EndListBuildBatchesForProject(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildBatchesForProjectResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuilds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual IAsyncResult BeginListBuilds(ListBuildsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuilds.</param>
        /// 
        /// <returns>Returns a  ListBuildsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual ListBuildsResponse EndListBuilds(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListBuildsForProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuildsForProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        public virtual IAsyncResult BeginListBuildsForProject(ListBuildsForProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsForProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsForProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBuildsForProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuildsForProject.</param>
        /// 
        /// <returns>Returns a  ListBuildsForProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListBuildsForProject">REST API Reference for ListBuildsForProject Operation</seealso>
        public virtual ListBuildsForProjectResponse EndListBuildsForProject(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBuildsForProjectResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListCuratedEnvironmentImages operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCuratedEnvironmentImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        public virtual IAsyncResult BeginListCuratedEnvironmentImages(ListCuratedEnvironmentImagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCuratedEnvironmentImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCuratedEnvironmentImagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCuratedEnvironmentImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCuratedEnvironmentImages.</param>
        /// 
        /// <returns>Returns a  ListCuratedEnvironmentImagesResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListCuratedEnvironmentImages">REST API Reference for ListCuratedEnvironmentImages Operation</seealso>
        public virtual ListCuratedEnvironmentImagesResponse EndListCuratedEnvironmentImages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCuratedEnvironmentImagesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
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
        /// <returns>Returns a  ListProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReportGroups

        /// <summary>
        /// Gets a list ARNs for the report groups in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        public virtual ListReportGroupsResponse ListReportGroups(ListReportGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportGroupsResponseUnmarshaller.Instance;

            return Invoke<ListReportGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        public virtual IAsyncResult BeginListReportGroups(ListReportGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportGroups.</param>
        /// 
        /// <returns>Returns a  ListReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportGroups">REST API Reference for ListReportGroups Operation</seealso>
        public virtual ListReportGroupsResponse EndListReportGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReports

        /// <summary>
        /// Returns a list of ARNs for the reports in the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual ListReportsResponse ListReports(ListReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;

            return Invoke<ListReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReports operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual IAsyncResult BeginListReports(ListReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReports.</param>
        /// 
        /// <returns>Returns a  ListReportsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReports">REST API Reference for ListReports Operation</seealso>
        public virtual ListReportsResponse EndListReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReportsForReportGroup

        /// <summary>
        /// Returns a list of ARNs for the reports that belong to a <code>ReportGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup service method.</param>
        /// 
        /// <returns>The response from the ListReportsForReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        public virtual ListReportsForReportGroupResponse ListReportsForReportGroup(ListReportsForReportGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportsForReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsForReportGroupResponseUnmarshaller.Instance;

            return Invoke<ListReportsForReportGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportsForReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportsForReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportsForReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        public virtual IAsyncResult BeginListReportsForReportGroup(ListReportsForReportGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportsForReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportsForReportGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportsForReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportsForReportGroup.</param>
        /// 
        /// <returns>Returns a  ListReportsForReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListReportsForReportGroup">REST API Reference for ListReportsForReportGroup Operation</seealso>
        public virtual ListReportsForReportGroupResponse EndListReportsForReportGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportsForReportGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSharedProjects

        /// <summary>
        /// Gets a list of projects that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects service method.</param>
        /// 
        /// <returns>The response from the ListSharedProjects service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        public virtual ListSharedProjectsResponse ListSharedProjects(ListSharedProjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedProjectsResponseUnmarshaller.Instance;

            return Invoke<ListSharedProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSharedProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSharedProjects operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSharedProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        public virtual IAsyncResult BeginListSharedProjects(ListSharedProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSharedProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSharedProjects.</param>
        /// 
        /// <returns>Returns a  ListSharedProjectsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedProjects">REST API Reference for ListSharedProjects Operation</seealso>
        public virtual ListSharedProjectsResponse EndListSharedProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSharedProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSharedReportGroups

        /// <summary>
        /// Gets a list of report groups that are shared with other AWS accounts or users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups service method.</param>
        /// 
        /// <returns>The response from the ListSharedReportGroups service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        public virtual ListSharedReportGroupsResponse ListSharedReportGroups(ListSharedReportGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedReportGroupsResponseUnmarshaller.Instance;

            return Invoke<ListSharedReportGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSharedReportGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSharedReportGroups operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSharedReportGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        public virtual IAsyncResult BeginListSharedReportGroups(ListSharedReportGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSharedReportGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSharedReportGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSharedReportGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSharedReportGroups.</param>
        /// 
        /// <returns>Returns a  ListSharedReportGroupsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSharedReportGroups">REST API Reference for ListSharedReportGroups Operation</seealso>
        public virtual ListSharedReportGroupsResponse EndListSharedReportGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSharedReportGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSourceCredentials

        /// <summary>
        /// Returns a list of <code>SourceCredentialsInfo</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials service method.</param>
        /// 
        /// <returns>The response from the ListSourceCredentials service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the ListSourceCredentials operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        public virtual IAsyncResult BeginListSourceCredentials(ListSourceCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSourceCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceCredentials.</param>
        /// 
        /// <returns>Returns a  ListSourceCredentialsResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/ListSourceCredentials">REST API Reference for ListSourceCredentials Operation</seealso>
        public virtual ListSourceCredentialsResponse EndListSourceCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSourceCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Stores a resource policy for the ARN of a <code>Project</code> or <code>ReportGroup</code>
        /// object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RetryBuild

        /// <summary>
        /// Restarts a build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild service method.</param>
        /// 
        /// <returns>The response from the RetryBuild service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.AccountLimitExceededException">
        /// An AWS service limit was exceeded for the calling AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        public virtual RetryBuildResponse RetryBuild(RetryBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryBuildResponseUnmarshaller.Instance;

            return Invoke<RetryBuildResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        public virtual IAsyncResult BeginRetryBuild(RetryBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetryBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryBuild.</param>
        /// 
        /// <returns>Returns a  RetryBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuild">REST API Reference for RetryBuild Operation</seealso>
        public virtual RetryBuildResponse EndRetryBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<RetryBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  RetryBuildBatch

        /// <summary>
        /// Restarts a failed batch build. Only batch builds that have failed can be retried.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch service method.</param>
        /// 
        /// <returns>The response from the RetryBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        public virtual RetryBuildBatchResponse RetryBuildBatch(RetryBuildBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryBuildBatchResponseUnmarshaller.Instance;

            return Invoke<RetryBuildBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetryBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        public virtual IAsyncResult BeginRetryBuildBatch(RetryBuildBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetryBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetryBuildBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RetryBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryBuildBatch.</param>
        /// 
        /// <returns>Returns a  RetryBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/RetryBuildBatch">REST API Reference for RetryBuildBatch Operation</seealso>
        public virtual RetryBuildBatchResponse EndRetryBuildBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<RetryBuildBatchResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StartBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        public virtual IAsyncResult BeginStartBuild(StartBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBuild.</param>
        /// 
        /// <returns>Returns a  StartBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuild">REST API Reference for StartBuild Operation</seealso>
        public virtual StartBuildResponse EndStartBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  StartBuildBatch

        /// <summary>
        /// Starts a batch build for a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StartBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        public virtual StartBuildBatchResponse StartBuildBatch(StartBuildBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBuildBatchResponseUnmarshaller.Instance;

            return Invoke<StartBuildBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        public virtual IAsyncResult BeginStartBuildBatch(StartBuildBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBuildBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBuildBatch.</param>
        /// 
        /// <returns>Returns a  StartBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StartBuildBatch">REST API Reference for StartBuildBatch Operation</seealso>
        public virtual StartBuildBatchResponse EndStartBuildBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBuildBatchResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the StopBuild operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBuild
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        public virtual IAsyncResult BeginStopBuild(StopBuildRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBuildResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopBuild operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBuild.</param>
        /// 
        /// <returns>Returns a  StopBuildResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuild">REST API Reference for StopBuild Operation</seealso>
        public virtual StopBuildResponse EndStopBuild(IAsyncResult asyncResult)
        {
            return EndInvoke<StopBuildResponse>(asyncResult);
        }

        #endregion
        
        #region  StopBuildBatch

        /// <summary>
        /// Stops a running batch build.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch service method.</param>
        /// 
        /// <returns>The response from the StopBuildBatch service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        public virtual StopBuildBatchResponse StopBuildBatch(StopBuildBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBuildBatchResponseUnmarshaller.Instance;

            return Invoke<StopBuildBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBuildBatch operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBuildBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        public virtual IAsyncResult BeginStopBuildBatch(StopBuildBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBuildBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBuildBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopBuildBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBuildBatch.</param>
        /// 
        /// <returns>Returns a  StopBuildBatchResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/StopBuildBatch">REST API Reference for StopBuildBatch Operation</seealso>
        public virtual StopBuildBatchResponse EndStopBuildBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<StopBuildBatchResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReportGroup

        /// <summary>
        /// Updates a report group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateReportGroup service method, as returned by CodeBuild.</returns>
        /// <exception cref="Amazon.CodeBuild.Model.InvalidInputException">
        /// The input value that was provided is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeBuild.Model.ResourceNotFoundException">
        /// The specified AWS resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        public virtual UpdateReportGroupResponse UpdateReportGroup(UpdateReportGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateReportGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportGroup operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReportGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateReportGroup(UpdateReportGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReportGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReportGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReportGroup.</param>
        /// 
        /// <returns>Returns a  UpdateReportGroupResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateReportGroup">REST API Reference for UpdateReportGroup Operation</seealso>
        public virtual UpdateReportGroupResponse EndUpdateReportGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReportGroupResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook operation on AmazonCodeBuildClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebhook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual IAsyncResult BeginUpdateWebhook(UpdateWebhookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebhookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebhook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebhook.</param>
        /// 
        /// <returns>Returns a  UpdateWebhookResult from CodeBuild.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codebuild-2016-10-06/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual UpdateWebhookResponse EndUpdateWebhook(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWebhookResponse>(asyncResult);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CodeDeploy.Model;
using Amazon.CodeDeploy.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeDeploy
{
    /// <summary>
    /// Implementation for accessing CodeDeploy
    ///
    /// AWS CodeDeploy <b>Overview</b> 
    /// <para>
    /// This is the AWS CodeDeploy API Reference. This guide provides descriptions of the
    /// AWS CodeDeploy APIs. For additional information, see the <a href="http://docs.aws.amazon.com/codedeploy/latest/userguide">AWS
    /// CodeDeploy User Guide</a>.
    /// </para>
    ///  <b>Using the APIs</b> 
    /// <para>
    /// You can use the AWS CodeDeploy APIs to work with the following items:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>Applications</i>, which are unique identifiers that AWS CodeDeploy uses to ensure
    /// that the correct combinations of revisions, deployment configurations, and deployment
    /// groups are being referenced during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can work with applications by calling <a>CreateApplication</a>, <a>DeleteApplication</a>,
    /// <a>GetApplication</a>, <a>ListApplications</a>, <a>BatchGetApplications</a>, and <a>UpdateApplication</a>
    /// to create, delete, and get information about applications, and to change information
    /// about an application, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment configurations</i>, which are sets of deployment rules and deployment
    /// success and failure conditions that AWS CodeDeploy uses during deployments.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment configurations by calling <a>CreateDeploymentConfig</a>,
    /// <a>DeleteDeploymentConfig</a>, <a>GetDeploymentConfig</a>, and <a>ListDeploymentConfigs</a>
    /// to create, delete, and get information about deployment configurations, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment groups</i>, which represent groups of Amazon EC2 instances to which
    /// application revisions can be deployed.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment groups by calling <a>CreateDeploymentGroup</a>, <a>DeleteDeploymentGroup</a>,
    /// <a>GetDeploymentGroup</a>, <a>ListDeploymentGroups</a>, and <a>UpdateDeploymentGroup</a>
    /// to create, delete, and get information about single and multiple deployment groups,
    /// and to change information about a deployment group, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployment instances</i> (also known simply as <i>instances</i>), which represent
    /// Amazon EC2 instances to which application revisions are deployed. Deployment instances
    /// are identified by their Amazon EC2 tags or Auto Scaling group names. Deployment instances
    /// belong to deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployment instances by calling <a>GetDeploymentInstance</a> and
    /// <a>ListDeploymentInstances</a> to get information about single and multiple deployment
    /// instances, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Deployments</i>, which represent the process of deploying revisions to deployment
    /// groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with deployments by calling <a>CreateDeployment</a>, <a>GetDeployment</a>,
    /// <a>ListDeployments</a>, <a>BatchGetDeployments</a>, and <a>StopDeployment</a> to create
    /// and get information about deployments, and to stop a deployment, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Application revisions</i> (also known simply as <i>revisions</i>), which are archive
    /// files that are stored in Amazon S3 buckets or GitHub repositories. These revisions
    /// contain source content (such as source code, web pages, executable files, any deployment
    /// scripts, and similar) along with an Application Specification file (AppSpec file).
    /// (The AppSpec file is unique to AWS CodeDeploy; it defines a series of deployment actions
    /// that you want AWS CodeDeploy to execute.) An application revision is uniquely identified
    /// by its Amazon S3 object key and its ETag, version, or both. Application revisions
    /// are deployed to deployment groups.
    /// </para>
    ///  
    /// <para>
    /// You can work with application revisions by calling <a>GetApplicationRevision</a>,
    /// <a>ListApplicationRevisions</a>, and <a>RegisterApplicationRevision</a> to get information
    /// about application revisions and to inform AWS CodeDeploy about an application revision,
    /// respectively.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeDeployClient : AmazonServiceClient, IAmazonCodeDeploy
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeDeployClient with the credentials loaded from the application's
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
        public AmazonCodeDeployClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeDeployConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with the credentials loaded from the application's
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
        public AmazonCodeDeployClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeDeployConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCodeDeployClient Configuration Object</param>
        public AmazonCodeDeployClient(AmazonCodeDeployConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeDeployClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeDeployConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeDeployClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeDeployConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Credentials and an
        /// AmazonCodeDeployClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeDeployClient Configuration Object</param>
        public AmazonCodeDeployClient(AWSCredentials credentials, AmazonCodeDeployConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeDeployConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeDeployConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeDeployClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeDeployClient Configuration Object</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeDeployConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeDeployConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeDeployConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeDeployClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeDeployClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeDeployClient Configuration Object</param>
        public AmazonCodeDeployClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeDeployConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BatchGetApplications

        /// <summary>
        /// Gets information about one or more applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        public BatchGetApplicationsResponse BatchGetApplications(BatchGetApplicationsRequest request)
        {
            var marshaller = new BatchGetApplicationsRequestMarshaller();
            var unmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetApplicationsRequest,BatchGetApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetApplications
        ///         operation.</returns>
        public IAsyncResult BeginBatchGetApplications(BatchGetApplicationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BatchGetApplicationsRequestMarshaller();
            var unmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke<BatchGetApplicationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetApplications.</param>
        /// 
        /// <returns>Returns a  BatchGetApplicationsResult from CodeDeploy.</returns>
        public  BatchGetApplicationsResponse EndBatchGetApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetDeployments

        /// <summary>
        /// Gets information about one or more deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        public BatchGetDeploymentsResponse BatchGetDeployments(BatchGetDeploymentsRequest request)
        {
            var marshaller = new BatchGetDeploymentsRequestMarshaller();
            var unmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentsRequest,BatchGetDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetDeployments
        ///         operation.</returns>
        public IAsyncResult BeginBatchGetDeployments(BatchGetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BatchGetDeploymentsRequestMarshaller();
            var unmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<BatchGetDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetDeployments.</param>
        /// 
        /// <returns>Returns a  BatchGetDeploymentsResult from CodeDeploy.</returns>
        public  BatchGetDeploymentsResponse EndBatchGetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApplication

        /// <summary>
        /// Creates a new application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationLimitExceededException">
        /// More applications were attempted to be created than were allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        public IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from CodeDeploy.</returns>
        public  CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Deploys an application revision to the specified deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentLimitExceededException">
        /// The number of allowed deployments was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description that was provided is too long.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        public CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from CodeDeploy.</returns>
        public  CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeploymentConfig

        /// <summary>
        /// Creates a new deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigAlreadyExistsException">
        /// A deployment configuration with the specified name already exists within the AWS user
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigLimitExceededException">
        /// The deployment configurations limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidMinimumHealthyHostValueException">
        /// The minimum healthy instances value was specified in an invalid format.
        /// </exception>
        public CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request)
        {
            var marshaller = new CreateDeploymentConfigRequestMarshaller();
            var unmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentConfigRequest,CreateDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeploymentConfig
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeploymentConfig(CreateDeploymentConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDeploymentConfigRequestMarshaller();
            var unmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeploymentConfig.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentConfigResult from CodeDeploy.</returns>
        public  CreateDeploymentConfigResponse EndCreateDeploymentConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeploymentGroup

        /// <summary>
        /// Creates a new deployment group for application revisions to be deployed to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group group with the specified name already exists within the AWS user
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupLimitExceededException">
        /// The deployment groups limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The Amazon EC2 tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RoleRequiredException">
        /// The role ID was not specified.
        /// </exception>
        public CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request)
        {
            var marshaller = new CreateDeploymentGroupRequestMarshaller();
            var unmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentGroupRequest,CreateDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeploymentGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateDeploymentGroup(CreateDeploymentGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDeploymentGroupRequestMarshaller();
            var unmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeploymentGroup.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentGroupResult from CodeDeploy.</returns>
        public  CreateDeploymentGroupResponse EndCreateDeploymentGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApplication

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        public IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from CodeDeploy.</returns>
        public  DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeploymentConfig

        /// <summary>
        /// Deletes a deployment configuration.
        /// 
        ///  <note>A deployment configuration cannot be deleted if it is currently in use. Also,
        /// predefined configurations cannot be deleted.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigInUseException">
        /// The deployment configuration is still in use.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidOperationException">
        /// An invalid operation was detected.
        /// </exception>
        public DeleteDeploymentConfigResponse DeleteDeploymentConfig(DeleteDeploymentConfigRequest request)
        {
            var marshaller = new DeleteDeploymentConfigRequestMarshaller();
            var unmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentConfigRequest,DeleteDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentConfig operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeploymentConfig
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDeploymentConfig(DeleteDeploymentConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDeploymentConfigRequestMarshaller();
            var unmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeploymentConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeploymentConfig.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentConfigResult from CodeDeploy.</returns>
        public  DeleteDeploymentConfigResponse EndDeleteDeploymentConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeploymentGroup

        /// <summary>
        /// Deletes a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        public DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request)
        {
            var marshaller = new DeleteDeploymentGroupRequestMarshaller();
            var unmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentGroupRequest,DeleteDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeploymentGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDeploymentGroup(DeleteDeploymentGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDeploymentGroupRequestMarshaller();
            var unmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeploymentGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeploymentGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentGroupResult from CodeDeploy.</returns>
        public  DeleteDeploymentGroupResponse EndDeleteDeploymentGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplication

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var marshaller = new GetApplicationRequestMarshaller();
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRequest,GetApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        public IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetApplicationRequestMarshaller();
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<GetApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from CodeDeploy.</returns>
        public  GetApplicationResponse EndGetApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationRevision

        /// <summary>
        /// Gets information about an application revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision service method.</param>
        /// 
        /// <returns>The response from the GetApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionDoesNotExistException">
        /// The named revision does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        public GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request)
        {
            var marshaller = new GetApplicationRevisionRequestMarshaller();
            var unmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRevisionRequest,GetApplicationRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationRevision
        ///         operation.</returns>
        public IAsyncResult BeginGetApplicationRevision(GetApplicationRevisionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetApplicationRevisionRequestMarshaller();
            var unmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return BeginInvoke<GetApplicationRevisionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationRevision.</param>
        /// 
        /// <returns>Returns a  GetApplicationRevisionResult from CodeDeploy.</returns>
        public  GetApplicationRevisionResponse EndGetApplicationRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets information about a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        public GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        public IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from CodeDeploy.</returns>
        public  GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeploymentConfig

        /// <summary>
        /// Gets information about a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        public GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request)
        {
            var marshaller = new GetDeploymentConfigRequestMarshaller();
            var unmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigRequest,GetDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentConfig
        ///         operation.</returns>
        public IAsyncResult BeginGetDeploymentConfig(GetDeploymentConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentConfigRequestMarshaller();
            var unmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentConfig.</param>
        /// 
        /// <returns>Returns a  GetDeploymentConfigResult from CodeDeploy.</returns>
        public  GetDeploymentConfigResponse EndGetDeploymentConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeploymentGroup

        /// <summary>
        /// Gets information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        public GetDeploymentGroupResponse GetDeploymentGroup(GetDeploymentGroupRequest request)
        {
            var marshaller = new GetDeploymentGroupRequestMarshaller();
            var unmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentGroupRequest,GetDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentGroup
        ///         operation.</returns>
        public IAsyncResult BeginGetDeploymentGroup(GetDeploymentGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentGroupRequestMarshaller();
            var unmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentGroup.</param>
        /// 
        /// <returns>Returns a  GetDeploymentGroupResult from CodeDeploy.</returns>
        public  GetDeploymentGroupResponse EndGetDeploymentGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeploymentInstance

        /// <summary>
        /// Gets information about an Amazon EC2 instance as part of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceDoesNotExistException">
        /// The specified instance does not exist in the deployment group.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        public GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request)
        {
            var marshaller = new GetDeploymentInstanceRequestMarshaller();
            var unmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentInstanceRequest,GetDeploymentInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeploymentInstance
        ///         operation.</returns>
        public IAsyncResult BeginGetDeploymentInstance(GetDeploymentInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentInstanceRequestMarshaller();
            var unmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeploymentInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeploymentInstance.</param>
        /// 
        /// <returns>Returns a  GetDeploymentInstanceResult from CodeDeploy.</returns>
        public  GetDeploymentInstanceResponse EndGetDeploymentInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplicationRevisions

        /// <summary>
        /// Lists information about revisions for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions service method.</param>
        /// 
        /// <returns>The response from the ListApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BucketNameFilterRequiredException">
        /// A bucket name is required but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidBucketNameFilterException">
        /// The bucket name either doesn't exist or was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeployedStateFilterException">
        /// The deployed state filter was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidKeyPrefixFilterException">
        /// The specified key prefix filter was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidSortByException">
        /// The column name to sort by is either not present or was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidSortOrderException">
        /// The sort order was specified in an invalid format.
        /// </exception>
        public ListApplicationRevisionsResponse ListApplicationRevisions(ListApplicationRevisionsRequest request)
        {
            var marshaller = new ListApplicationRevisionsRequestMarshaller();
            var unmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationRevisionsRequest,ListApplicationRevisionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationRevisions
        ///         operation.</returns>
        public IAsyncResult BeginListApplicationRevisions(ListApplicationRevisionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListApplicationRevisionsRequestMarshaller();
            var unmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListApplicationRevisionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationRevisions.</param>
        /// 
        /// <returns>Returns a  ListApplicationRevisionsResult from CodeDeploy.</returns>
        public  ListApplicationRevisionsResponse EndListApplicationRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApplications

        /// <summary>
        /// Lists the applications registered within the AWS user account.
        /// </summary>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListApplicationsResponse ListApplications()
        {
            return ListApplications(new ListApplicationsRequest());
        }

        /// <summary>
        /// Lists the applications registered within the AWS user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        public IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke<ListApplicationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from CodeDeploy.</returns>
        public  ListApplicationsResponse EndListApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeploymentConfigs

        /// <summary>
        /// Lists the deployment configurations within the AWS user account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListDeploymentConfigsResponse ListDeploymentConfigs()
        {
            return ListDeploymentConfigs(new ListDeploymentConfigsRequest());
        }

        /// <summary>
        /// Lists the deployment configurations within the AWS user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListDeploymentConfigsResponse ListDeploymentConfigs(ListDeploymentConfigsRequest request)
        {
            var marshaller = new ListDeploymentConfigsRequestMarshaller();
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigsRequest,ListDeploymentConfigsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentConfigs
        ///         operation.</returns>
        public IAsyncResult BeginListDeploymentConfigs(ListDeploymentConfigsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDeploymentConfigsRequestMarshaller();
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeploymentConfigsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentConfigs.</param>
        /// 
        /// <returns>Returns a  ListDeploymentConfigsResult from CodeDeploy.</returns>
        public  ListDeploymentConfigsResponse EndListDeploymentConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeploymentGroups

        /// <summary>
        /// Lists the deployment groups for an application registered within the AWS user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListDeploymentGroupsResponse ListDeploymentGroups(ListDeploymentGroupsRequest request)
        {
            var marshaller = new ListDeploymentGroupsRequestMarshaller();
            var unmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentGroupsRequest,ListDeploymentGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentGroups
        ///         operation.</returns>
        public IAsyncResult BeginListDeploymentGroups(ListDeploymentGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDeploymentGroupsRequestMarshaller();
            var unmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeploymentGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentGroups.</param>
        /// 
        /// <returns>Returns a  ListDeploymentGroupsResult from CodeDeploy.</returns>
        public  ListDeploymentGroupsResponse EndListDeploymentGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeploymentInstances

        /// <summary>
        /// Lists the Amazon EC2 instances for a deployment within the AWS user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceStatusException">
        /// The specified instance status does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        public ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request)
        {
            var marshaller = new ListDeploymentInstancesRequestMarshaller();
            var unmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentInstancesRequest,ListDeploymentInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentInstances
        ///         operation.</returns>
        public IAsyncResult BeginListDeploymentInstances(ListDeploymentInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDeploymentInstancesRequestMarshaller();
            var unmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeploymentInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentInstances.</param>
        /// 
        /// <returns>Returns a  ListDeploymentInstancesResult from CodeDeploy.</returns>
        public  ListDeploymentInstancesResponse EndListDeploymentInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeployments

        /// <summary>
        /// Lists the deployments under a deployment group for an application registered within
        /// the AWS user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStatusException">
        /// The specified deployment status doesn't exist or cannot be determined.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTimeRangeException">
        /// The specified time range was specified in an invalid format.
        /// </exception>
        public ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        public IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from CodeDeploy.</returns>
        public  ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterApplicationRevision

        /// <summary>
        /// Registers with AWS CodeDeploy a revision for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision service method.</param>
        /// 
        /// <returns>The response from the RegisterApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description that was provided is too long.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        public RegisterApplicationRevisionResponse RegisterApplicationRevision(RegisterApplicationRevisionRequest request)
        {
            var marshaller = new RegisterApplicationRevisionRequestMarshaller();
            var unmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<RegisterApplicationRevisionRequest,RegisterApplicationRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterApplicationRevision
        ///         operation.</returns>
        public IAsyncResult BeginRegisterApplicationRevision(RegisterApplicationRevisionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterApplicationRevisionRequestMarshaller();
            var unmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterApplicationRevisionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterApplicationRevision.</param>
        /// 
        /// <returns>Returns a  RegisterApplicationRevisionResult from CodeDeploy.</returns>
        public  RegisterApplicationRevisionResponse EndRegisterApplicationRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterApplicationRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDeployment

        /// <summary>
        /// Attempts to stop an ongoing deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment service method.</param>
        /// 
        /// <returns>The response from the StopDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already completed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        public StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
        {
            var marshaller = new StopDeploymentRequestMarshaller();
            var unmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return Invoke<StopDeploymentRequest,StopDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDeployment
        ///         operation.</returns>
        public IAsyncResult BeginStopDeployment(StopDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopDeploymentRequestMarshaller();
            var unmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<StopDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDeployment.</param>
        /// 
        /// <returns>Returns a  StopDeploymentResult from CodeDeploy.</returns>
        public  StopDeploymentResponse EndStopDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplication

        /// <summary>
        /// Changes an existing application's name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        public IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApplicationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from CodeDeploy.</returns>
        public  UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeploymentGroup

        /// <summary>
        /// Changes information about an existing deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist within the AWS user account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group group with the specified name already exists within the AWS user
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The Amazon EC2 tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        public UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request)
        {
            var marshaller = new UpdateDeploymentGroupRequestMarshaller();
            var unmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentGroupRequest,UpdateDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup operation on AmazonCodeDeployClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeploymentGroup
        ///         operation.</returns>
        public IAsyncResult BeginUpdateDeploymentGroup(UpdateDeploymentGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDeploymentGroupRequestMarshaller();
            var unmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDeploymentGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeploymentGroup.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentGroupResult from CodeDeploy.</returns>
        public  UpdateDeploymentGroupResponse EndUpdateDeploymentGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeploymentGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}
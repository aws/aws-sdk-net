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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// AWS CodeDeploy 
    /// <para>
    /// AWS CodeDeploy is a deployment service that automates application deployments to Amazon
    /// EC2 instances, on-premises instances running in your own facility, or serverless AWS
    /// Lambda functions.
    /// </para>
    ///  
    /// <para>
    /// You can deploy a nearly unlimited variety of application content, such as an updated
    /// Lambda function, code, web and configuration files, executables, packages, scripts,
    /// multimedia files, and so on. AWS CodeDeploy can deploy application content stored
    /// in Amazon S3 buckets, GitHub repositories, or Bitbucket repositories. You do not need
    /// to make changes to your existing code before you can use AWS CodeDeploy.
    /// </para>
    ///  
    /// <para>
    /// AWS CodeDeploy makes it easier for you to rapidly release new features, helps you
    /// avoid downtime during application deployment, and handles the complexity of updating
    /// your applications, without many of the risks associated with error-prone manual deployments.
    /// </para>
    ///  
    /// <para>
    ///  <b>AWS CodeDeploy Components</b> 
    /// </para>
    ///  
    /// <para>
    /// Use the information in this guide to help you work with the following AWS CodeDeploy
    /// components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Application</b>: A name that uniquely identifies the application you want to deploy.
    /// AWS CodeDeploy uses this name, which functions as a container, to ensure the correct
    /// combination of revision, deployment configuration, and deployment group are referenced
    /// during a deployment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment group</b>: A set of individual instances or CodeDeploy Lambda applications.
    /// A Lambda deployment group contains a group of applications. An EC2/On-premises deployment
    /// group contains individually tagged instances, Amazon EC2 instances in Auto Scaling
    /// groups, or both. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment configuration</b>: A set of deployment rules and deployment success
    /// and failure conditions used by AWS CodeDeploy during a deployment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment</b>: The process and the components used in the process of updating
    /// a Lambda function or of installing content on one or more instances. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Application revisions</b>: For an AWS Lambda deployment, this is an AppSpec file
    /// that specifies the Lambda function to update and one or more functions to validate
    /// deployment lifecycle events. For an EC2/On-premises deployment, this is an archive
    /// file containing source content—source code, web pages, executable files, and deployment
    /// scripts—along with an AppSpec file. Revisions are stored in Amazon S3 buckets or GitHub
    /// repositories. For Amazon S3, a revision is uniquely identified by its Amazon S3 object
    /// key and its ETag, version, or both. For GitHub, a revision is uniquely identified
    /// by its commit ID.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This guide also contains information to help you get details about the instances in
    /// your deployments, to make on-premises instances available for AWS CodeDeploy deployments,
    /// and to get details about a Lambda function deployment.
    /// </para>
    ///  
    /// <para>
    ///  <b>AWS CodeDeploy Information Resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/codedeploy/latest/userguide">AWS CodeDeploy User
    /// Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/codedeploy/latest/APIReference/">AWS CodeDeploy
    /// API Reference Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/cli/latest/reference/deploy/index.html">AWS CLI
    /// Reference for AWS CodeDeploy</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://forums.aws.amazon.com/forum.jspa?forumID=179">AWS CodeDeploy Developer
    /// Forum</a> 
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

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        
        #region  AddTagsToOnPremisesInstances


        /// <summary>
        /// Adds tags to on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the AddTagsToOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceLimitExceededException">
        /// The maximum number of allowed on-premises instances in a single call was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/AddTagsToOnPremisesInstances">REST API Reference for AddTagsToOnPremisesInstances Operation</seealso>
        public virtual AddTagsToOnPremisesInstancesResponse AddTagsToOnPremisesInstances(AddTagsToOnPremisesInstancesRequest request)
        {
            var marshaller = AddTagsToOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = AddTagsToOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<AddTagsToOnPremisesInstancesRequest,AddTagsToOnPremisesInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/AddTagsToOnPremisesInstances">REST API Reference for AddTagsToOnPremisesInstances Operation</seealso>
        public virtual Task<AddTagsToOnPremisesInstancesResponse> AddTagsToOnPremisesInstancesAsync(AddTagsToOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsToOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = AddTagsToOnPremisesInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToOnPremisesInstancesRequest,AddTagsToOnPremisesInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetApplicationRevisions


        /// <summary>
        /// Gets information about one or more application revisions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetApplicationRevisions">REST API Reference for BatchGetApplicationRevisions Operation</seealso>
        public virtual BatchGetApplicationRevisionsResponse BatchGetApplicationRevisions(BatchGetApplicationRevisionsRequest request)
        {
            var marshaller = BatchGetApplicationRevisionsRequestMarshaller.Instance;
            var unmarshaller = BatchGetApplicationRevisionsResponseUnmarshaller.Instance;

            return Invoke<BatchGetApplicationRevisionsRequest,BatchGetApplicationRevisionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetApplicationRevisions">REST API Reference for BatchGetApplicationRevisions Operation</seealso>
        public virtual Task<BatchGetApplicationRevisionsResponse> BatchGetApplicationRevisionsAsync(BatchGetApplicationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetApplicationRevisionsRequestMarshaller.Instance;
            var unmarshaller = BatchGetApplicationRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetApplicationRevisionsRequest,BatchGetApplicationRevisionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetApplications">REST API Reference for BatchGetApplications Operation</seealso>
        public virtual BatchGetApplicationsResponse BatchGetApplications(BatchGetApplicationsRequest request)
        {
            var marshaller = BatchGetApplicationsRequestMarshaller.Instance;
            var unmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetApplicationsRequest,BatchGetApplicationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetApplications">REST API Reference for BatchGetApplications Operation</seealso>
        public virtual Task<BatchGetApplicationsResponse> BatchGetApplicationsAsync(BatchGetApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetApplicationsRequestMarshaller.Instance;
            var unmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetApplicationsRequest,BatchGetApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeploymentGroups


        /// <summary>
        /// Gets information about one or more deployment groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentGroups">REST API Reference for BatchGetDeploymentGroups Operation</seealso>
        public virtual BatchGetDeploymentGroupsResponse BatchGetDeploymentGroups(BatchGetDeploymentGroupsRequest request)
        {
            var marshaller = BatchGetDeploymentGroupsRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentGroupsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentGroupsRequest,BatchGetDeploymentGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentGroups">REST API Reference for BatchGetDeploymentGroups Operation</seealso>
        public virtual Task<BatchGetDeploymentGroupsResponse> BatchGetDeploymentGroupsAsync(BatchGetDeploymentGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetDeploymentGroupsRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDeploymentGroupsRequest,BatchGetDeploymentGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeploymentInstances


        /// <summary>
        /// Gets information about one or more instance that are part of a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentInstances">REST API Reference for BatchGetDeploymentInstances Operation</seealso>
        public virtual BatchGetDeploymentInstancesResponse BatchGetDeploymentInstances(BatchGetDeploymentInstancesRequest request)
        {
            var marshaller = BatchGetDeploymentInstancesRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentInstancesResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentInstancesRequest,BatchGetDeploymentInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentInstances">REST API Reference for BatchGetDeploymentInstances Operation</seealso>
        public virtual Task<BatchGetDeploymentInstancesResponse> BatchGetDeploymentInstancesAsync(BatchGetDeploymentInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetDeploymentInstancesRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDeploymentInstancesRequest,BatchGetDeploymentInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeployments


        /// <summary>
        /// Gets information about one or more deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeployments">REST API Reference for BatchGetDeployments Operation</seealso>
        public virtual BatchGetDeploymentsResponse BatchGetDeployments(BatchGetDeploymentsRequest request)
        {
            var marshaller = BatchGetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentsRequest,BatchGetDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeployments">REST API Reference for BatchGetDeployments Operation</seealso>
        public virtual Task<BatchGetDeploymentsResponse> BatchGetDeploymentsAsync(BatchGetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDeploymentsRequest,BatchGetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetOnPremisesInstances


        /// <summary>
        /// Gets information about one or more on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the BatchGetOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetOnPremisesInstances">REST API Reference for BatchGetOnPremisesInstances Operation</seealso>
        public virtual BatchGetOnPremisesInstancesResponse BatchGetOnPremisesInstances(BatchGetOnPremisesInstancesRequest request)
        {
            var marshaller = BatchGetOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = BatchGetOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<BatchGetOnPremisesInstancesRequest,BatchGetOnPremisesInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetOnPremisesInstances">REST API Reference for BatchGetOnPremisesInstances Operation</seealso>
        public virtual Task<BatchGetOnPremisesInstancesResponse> BatchGetOnPremisesInstancesAsync(BatchGetOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchGetOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = BatchGetOnPremisesInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetOnPremisesInstancesRequest,BatchGetOnPremisesInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ContinueDeployment


        /// <summary>
        /// For a blue/green deployment, starts the process of rerouting traffic from instances
        /// in the original environment to instances in the replacement environment without waiting
        /// for a specified wait time to elapse. (Traffic rerouting, which is achieved by registering
        /// instances in the replacement environment with the load balancer, can start as soon
        /// as all instances have a status of Ready.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueDeployment service method.</param>
        /// 
        /// <returns>The response from the ContinueDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIsNotInReadyStateException">
        /// The deployment does not have a status of Ready and can't continue yet.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ContinueDeployment">REST API Reference for ContinueDeployment Operation</seealso>
        public virtual ContinueDeploymentResponse ContinueDeployment(ContinueDeploymentRequest request)
        {
            var marshaller = ContinueDeploymentRequestMarshaller.Instance;
            var unmarshaller = ContinueDeploymentResponseUnmarshaller.Instance;

            return Invoke<ContinueDeploymentRequest,ContinueDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ContinueDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContinueDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ContinueDeployment">REST API Reference for ContinueDeployment Operation</seealso>
        public virtual Task<ContinueDeploymentResponse> ContinueDeploymentAsync(ContinueDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ContinueDeploymentRequestMarshaller.Instance;
            var unmarshaller = ContinueDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<ContinueDeploymentRequest,ContinueDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists with the applicable IAM user
        /// or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationLimitExceededException">
        /// More applications were attempted to be created than are allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <code>Lambda</code>
        /// or <code>Server</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Deploys an application revision through the specified deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentLimitExceededException">
        /// The number of allowed deployments was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description is too long.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled but an invalid triggering event type or no event types
        /// were listed.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidFileExistsBehaviorException">
        /// An invalid fileExistsBehavior option was specified to determine how AWS CodeDeploy
        /// handles files or directories that already exist in a deployment target location but
        /// weren't part of the previous successful deployment. Valid values include "DISALLOW",
        /// "OVERWRITE", and "RETAIN".
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidGitHubAccountTokenException">
        /// The GitHub token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIgnoreApplicationStopFailuresValueException">
        /// The IgnoreApplicationStopFailures value is invalid. For AWS Lambda deployments, <code>false</code>
        /// is expected. For EC2/On-premises deployments, <code>true</code> or <code>false</code>
        /// is expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLoadBalancerInfoException">
        /// An invalid load balancer name, or no load balancer name, was specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRevisionException">
        /// The revision was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetInstancesException">
        /// The target instance configuration is invalid. Possible causes include:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Configuration data for target instances was entered for an in-place deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The limit of 10 tags for a tag type was exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The combined length of the tag names exceeded the limit. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A specified tag is not currently applied to any instances.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidUpdateOutdatedInstancesOnlyValueException">
        /// The UpdateOutdatedInstancesOnly value is invalid. For AWS Lambda deployments, <code>false</code>
        /// is expected. For EC2/On-premises deployments, <code>true</code> or <code>false</code>
        /// is expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionDoesNotExistException">
        /// The named revision does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeploymentConfig


        /// <summary>
        /// Creates a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigAlreadyExistsException">
        /// A deployment configuration with the specified name already exists with the applicable
        /// IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigLimitExceededException">
        /// The deployment configurations limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <code>Lambda</code>
        /// or <code>Server</code>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidMinimumHealthyHostValueException">
        /// The minimum healthy instance value was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentConfig">REST API Reference for CreateDeploymentConfig Operation</seealso>
        public virtual CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request)
        {
            var marshaller = CreateDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentConfigRequest,CreateDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentConfig">REST API Reference for CreateDeploymentConfig Operation</seealso>
        public virtual Task<CreateDeploymentConfigResponse> CreateDeploymentConfigAsync(CreateDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentConfigRequest,CreateDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeploymentGroup


        /// <summary>
        /// Creates a deployment group to which application revisions will be deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name already exists with the applicable IAM
        /// user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupLimitExceededException">
        /// The deployment groups limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAlarmConfigException">
        /// The format of the alarm configuration is invalid. Possible causes include:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The alarm list is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm object is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm name is empty or null or exceeds the 255 character limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled but an invalid triggering event type or no event types
        /// were listed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidBlueGreenDeploymentConfigurationException">
        /// The configuration for the blue/green deployment group was provided in an invalid format.
        /// For information about deployment configuration format, see <a>CreateDeploymentConfig</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStyleException">
        /// An invalid deployment style was specified. Valid deployment types include "IN_PLACE"
        /// and "BLUE_GREEN". Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL".
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The specified input was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLoadBalancerInfoException">
        /// An invalid load balancer name, or no load balancer name, was specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidOnPremisesTagCombinationException">
        /// A call was submitted that specified both OnPremisesTagFilters and OnPremisesTagSet,
        /// but only one of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTriggerConfigException">
        /// The trigger was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleHookLimitExceededException">
        /// The limit for lifecycle hooks was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RoleRequiredException">
        /// The role ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagSetListLimitExceededException">
        /// The number of tag groups included in the tag set list exceeded the maximum allowed
        /// limit of 3.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentGroup">REST API Reference for CreateDeploymentGroup Operation</seealso>
        public virtual CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request)
        {
            var marshaller = CreateDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentGroupRequest,CreateDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentGroup">REST API Reference for CreateDeploymentGroup Operation</seealso>
        public virtual Task<CreateDeploymentGroupResponse> CreateDeploymentGroupAsync(CreateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentGroupRequest,CreateDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeploymentConfig


        /// <summary>
        /// Deletes a deployment configuration.
        /// 
        ///  <note> 
        /// <para>
        /// A deployment configuration cannot be deleted if it is currently in use. Predefined
        /// configurations cannot be deleted.
        /// </para>
        ///  </note>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentConfig">REST API Reference for DeleteDeploymentConfig Operation</seealso>
        public virtual DeleteDeploymentConfigResponse DeleteDeploymentConfig(DeleteDeploymentConfigRequest request)
        {
            var marshaller = DeleteDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentConfigRequest,DeleteDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentConfig">REST API Reference for DeleteDeploymentConfig Operation</seealso>
        public virtual Task<DeleteDeploymentConfigResponse> DeleteDeploymentConfigAsync(DeleteDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentConfigRequest,DeleteDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentGroup">REST API Reference for DeleteDeploymentGroup Operation</seealso>
        public virtual DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request)
        {
            var marshaller = DeleteDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentGroupRequest,DeleteDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentGroup">REST API Reference for DeleteDeploymentGroup Operation</seealso>
        public virtual Task<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentGroupRequest,DeleteDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGitHubAccountToken


        /// <summary>
        /// Deletes a GitHub account connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGitHubAccountToken service method.</param>
        /// 
        /// <returns>The response from the DeleteGitHubAccountToken service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.GitHubAccountTokenDoesNotExistException">
        /// No GitHub account connection exists with the named specified in the call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.GitHubAccountTokenNameRequiredException">
        /// The call is missing a required GitHub account connection name.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidGitHubAccountTokenNameException">
        /// The format of the specified GitHub account connection name is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.OperationNotSupportedException">
        /// The API used does not support the deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceValidationException">
        /// The specified resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteGitHubAccountToken">REST API Reference for DeleteGitHubAccountToken Operation</seealso>
        public virtual DeleteGitHubAccountTokenResponse DeleteGitHubAccountToken(DeleteGitHubAccountTokenRequest request)
        {
            var marshaller = DeleteGitHubAccountTokenRequestMarshaller.Instance;
            var unmarshaller = DeleteGitHubAccountTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteGitHubAccountTokenRequest,DeleteGitHubAccountTokenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGitHubAccountToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGitHubAccountToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteGitHubAccountToken">REST API Reference for DeleteGitHubAccountToken Operation</seealso>
        public virtual Task<DeleteGitHubAccountTokenResponse> DeleteGitHubAccountTokenAsync(DeleteGitHubAccountTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGitHubAccountTokenRequestMarshaller.Instance;
            var unmarshaller = DeleteGitHubAccountTokenResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGitHubAccountTokenRequest,DeleteGitHubAccountTokenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterOnPremisesInstance


        /// <summary>
        /// Deregisters an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the DeregisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeregisterOnPremisesInstance">REST API Reference for DeregisterOnPremisesInstance Operation</seealso>
        public virtual DeregisterOnPremisesInstanceResponse DeregisterOnPremisesInstance(DeregisterOnPremisesInstanceRequest request)
        {
            var marshaller = DeregisterOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterOnPremisesInstanceRequest,DeregisterOnPremisesInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeregisterOnPremisesInstance">REST API Reference for DeregisterOnPremisesInstance Operation</seealso>
        public virtual Task<DeregisterOnPremisesInstanceResponse> DeregisterOnPremisesInstanceAsync(DeregisterOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = DeregisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterOnPremisesInstanceRequest,DeregisterOnPremisesInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var marshaller = GetApplicationRequestMarshaller.Instance;
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRequest,GetApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApplicationRequestMarshaller.Instance;
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationRequest,GetApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
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
        /// The named revision does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplicationRevision">REST API Reference for GetApplicationRevision Operation</seealso>
        public virtual GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request)
        {
            var marshaller = GetApplicationRevisionRequestMarshaller.Instance;
            var unmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRevisionRequest,GetApplicationRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplicationRevision">REST API Reference for GetApplicationRevision Operation</seealso>
        public virtual Task<GetApplicationRevisionResponse> GetApplicationRevisionAsync(GetApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApplicationRevisionRequestMarshaller.Instance;
            var unmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationRevisionRequest,GetApplicationRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentConfig">REST API Reference for GetDeploymentConfig Operation</seealso>
        public virtual GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request)
        {
            var marshaller = GetDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigRequest,GetDeploymentConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentConfig">REST API Reference for GetDeploymentConfig Operation</seealso>
        public virtual Task<GetDeploymentConfigResponse> GetDeploymentConfigAsync(GetDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentConfigRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentConfigRequest,GetDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentGroup">REST API Reference for GetDeploymentGroup Operation</seealso>
        public virtual GetDeploymentGroupResponse GetDeploymentGroup(GetDeploymentGroupRequest request)
        {
            var marshaller = GetDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentGroupRequest,GetDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentGroup">REST API Reference for GetDeploymentGroup Operation</seealso>
        public virtual Task<GetDeploymentGroupResponse> GetDeploymentGroupAsync(GetDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentGroupRequest,GetDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentInstance


        /// <summary>
        /// Gets information about an instance as part of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentInstance">REST API Reference for GetDeploymentInstance Operation</seealso>
        public virtual GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request)
        {
            var marshaller = GetDeploymentInstanceRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentInstanceRequest,GetDeploymentInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeploymentInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentInstance">REST API Reference for GetDeploymentInstance Operation</seealso>
        public virtual Task<GetDeploymentInstanceResponse> GetDeploymentInstanceAsync(GetDeploymentInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentInstanceRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentInstanceRequest,GetDeploymentInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetOnPremisesInstance


        /// <summary>
        /// Gets information about an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the GetOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetOnPremisesInstance">REST API Reference for GetOnPremisesInstance Operation</seealso>
        public virtual GetOnPremisesInstanceResponse GetOnPremisesInstance(GetOnPremisesInstanceRequest request)
        {
            var marshaller = GetOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = GetOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<GetOnPremisesInstanceRequest,GetOnPremisesInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetOnPremisesInstance">REST API Reference for GetOnPremisesInstance Operation</seealso>
        public virtual Task<GetOnPremisesInstanceResponse> GetOnPremisesInstanceAsync(GetOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = GetOnPremisesInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetOnPremisesInstanceRequest,GetOnPremisesInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BucketNameFilterRequiredException">
        /// A bucket name is required, but was not provided.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplicationRevisions">REST API Reference for ListApplicationRevisions Operation</seealso>
        public virtual ListApplicationRevisionsResponse ListApplicationRevisions(ListApplicationRevisionsRequest request)
        {
            var marshaller = ListApplicationRevisionsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationRevisionsRequest,ListApplicationRevisionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplicationRevisions">REST API Reference for ListApplicationRevisions Operation</seealso>
        public virtual Task<ListApplicationRevisionsResponse> ListApplicationRevisionsAsync(ListApplicationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListApplicationRevisionsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationRevisionsRequest,ListApplicationRevisionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications()
        {
            return ListApplications(new ListApplicationsRequest());
        }


        /// <summary>
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the applications registered with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListApplicationsAsync(new ListApplicationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentConfigs


        /// <summary>
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentConfigs">REST API Reference for ListDeploymentConfigs Operation</seealso>
        public virtual ListDeploymentConfigsResponse ListDeploymentConfigs()
        {
            return ListDeploymentConfigs(new ListDeploymentConfigsRequest());
        }


        /// <summary>
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentConfigs">REST API Reference for ListDeploymentConfigs Operation</seealso>
        public virtual ListDeploymentConfigsResponse ListDeploymentConfigs(ListDeploymentConfigsRequest request)
        {
            var marshaller = ListDeploymentConfigsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigsRequest,ListDeploymentConfigsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the deployment configurations with the applicable IAM user or AWS account.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentConfigs">REST API Reference for ListDeploymentConfigs Operation</seealso>
        public virtual Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListDeploymentConfigsAsync(new ListDeploymentConfigsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentConfigs">REST API Reference for ListDeploymentConfigs Operation</seealso>
        public virtual Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(ListDeploymentConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentConfigsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentConfigsRequest,ListDeploymentConfigsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentGroups


        /// <summary>
        /// Lists the deployment groups for an application registered with the applicable IAM
        /// user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentGroups">REST API Reference for ListDeploymentGroups Operation</seealso>
        public virtual ListDeploymentGroupsResponse ListDeploymentGroups(ListDeploymentGroupsRequest request)
        {
            var marshaller = ListDeploymentGroupsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentGroupsRequest,ListDeploymentGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentGroups">REST API Reference for ListDeploymentGroups Operation</seealso>
        public virtual Task<ListDeploymentGroupsResponse> ListDeploymentGroupsAsync(ListDeploymentGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentGroupsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentGroupsRequest,ListDeploymentGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentInstances


        /// <summary>
        /// Lists the instance for a deployment associated with the applicable IAM user or AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentInstanceTypeException">
        /// An instance type was specified for an in-place deployment. Instance types are supported
        /// for blue/green deployments only.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceStatusException">
        /// The specified instance status does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceTypeException">
        /// An invalid instance type was specified for instances in a blue/green deployment. Valid
        /// values include "Blue" for an original environment and "Green" for a replacement environment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentInstances">REST API Reference for ListDeploymentInstances Operation</seealso>
        public virtual ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request)
        {
            var marshaller = ListDeploymentInstancesRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentInstancesRequest,ListDeploymentInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeploymentInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentInstances">REST API Reference for ListDeploymentInstances Operation</seealso>
        public virtual Task<ListDeploymentInstancesResponse> ListDeploymentInstancesAsync(ListDeploymentInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentInstancesRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentInstancesRequest,ListDeploymentInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Lists the deployments in a deployment group for an application registered with the
        /// applicable IAM user or AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var marshaller = ListDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeploymentsRequestMarshaller.Instance;
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGitHubAccountTokenNames


        /// <summary>
        /// Lists the names of stored connections to GitHub accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGitHubAccountTokenNames service method.</param>
        /// 
        /// <returns>The response from the ListGitHubAccountTokenNames service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.OperationNotSupportedException">
        /// The API used does not support the deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceValidationException">
        /// The specified resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListGitHubAccountTokenNames">REST API Reference for ListGitHubAccountTokenNames Operation</seealso>
        public virtual ListGitHubAccountTokenNamesResponse ListGitHubAccountTokenNames(ListGitHubAccountTokenNamesRequest request)
        {
            var marshaller = ListGitHubAccountTokenNamesRequestMarshaller.Instance;
            var unmarshaller = ListGitHubAccountTokenNamesResponseUnmarshaller.Instance;

            return Invoke<ListGitHubAccountTokenNamesRequest,ListGitHubAccountTokenNamesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGitHubAccountTokenNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGitHubAccountTokenNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListGitHubAccountTokenNames">REST API Reference for ListGitHubAccountTokenNames Operation</seealso>
        public virtual Task<ListGitHubAccountTokenNamesResponse> ListGitHubAccountTokenNamesAsync(ListGitHubAccountTokenNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListGitHubAccountTokenNamesRequestMarshaller.Instance;
            var unmarshaller = ListGitHubAccountTokenNamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGitHubAccountTokenNamesRequest,ListGitHubAccountTokenNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOnPremisesInstances


        /// <summary>
        /// Gets a list of names for one or more on-premises instances.
        /// 
        ///  
        /// <para>
        /// Unless otherwise specified, both registered and deregistered on-premises instance
        /// names will be listed. To list only registered or deregistered on-premises instance
        /// names, use the registration status parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the ListOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRegistrationStatusException">
        /// The registration status was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagFilterException">
        /// The specified tag filter was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListOnPremisesInstances">REST API Reference for ListOnPremisesInstances Operation</seealso>
        public virtual ListOnPremisesInstancesResponse ListOnPremisesInstances(ListOnPremisesInstancesRequest request)
        {
            var marshaller = ListOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = ListOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<ListOnPremisesInstancesRequest,ListOnPremisesInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListOnPremisesInstances">REST API Reference for ListOnPremisesInstances Operation</seealso>
        public virtual Task<ListOnPremisesInstancesResponse> ListOnPremisesInstancesAsync(ListOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = ListOnPremisesInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOnPremisesInstancesRequest,ListOnPremisesInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleEventHookExecutionStatus


        /// <summary>
        /// Sets the result of a Lambda validation function. The function validates one or both
        /// lifecycle events (<code>BeforeAllowTraffic</code> and <code>AfterAllowTraffic</code>)
        /// and returns <code>Succeeded</code> or <code>Failed</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleEventHookExecutionStatus service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleEventHookExecutionStatus service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionIdException">
        /// A lifecycle event hook is invalid. Review the <code>hooks</code> section in your AppSpec
        /// file to ensure the lifecycle events and <code>hooks</code> functions are valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionStatusException">
        /// The result of a Lambda validation function that verifies a lifecycle event is invalid.
        /// It should return <code>Succeeded</code> or <code>Failed</code>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleEventAlreadyCompletedException">
        /// An attempt to return the status of an already completed lifecycle event occurred.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/PutLifecycleEventHookExecutionStatus">REST API Reference for PutLifecycleEventHookExecutionStatus Operation</seealso>
        public virtual PutLifecycleEventHookExecutionStatusResponse PutLifecycleEventHookExecutionStatus(PutLifecycleEventHookExecutionStatusRequest request)
        {
            var marshaller = PutLifecycleEventHookExecutionStatusRequestMarshaller.Instance;
            var unmarshaller = PutLifecycleEventHookExecutionStatusResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleEventHookExecutionStatusRequest,PutLifecycleEventHookExecutionStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleEventHookExecutionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleEventHookExecutionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/PutLifecycleEventHookExecutionStatus">REST API Reference for PutLifecycleEventHookExecutionStatus Operation</seealso>
        public virtual Task<PutLifecycleEventHookExecutionStatusResponse> PutLifecycleEventHookExecutionStatusAsync(PutLifecycleEventHookExecutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutLifecycleEventHookExecutionStatusRequestMarshaller.Instance;
            var unmarshaller = PutLifecycleEventHookExecutionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleEventHookExecutionStatusRequest,PutLifecycleEventHookExecutionStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DescriptionTooLongException">
        /// The description is too long.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterApplicationRevision">REST API Reference for RegisterApplicationRevision Operation</seealso>
        public virtual RegisterApplicationRevisionResponse RegisterApplicationRevision(RegisterApplicationRevisionRequest request)
        {
            var marshaller = RegisterApplicationRevisionRequestMarshaller.Instance;
            var unmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<RegisterApplicationRevisionRequest,RegisterApplicationRevisionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterApplicationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterApplicationRevision">REST API Reference for RegisterApplicationRevision Operation</seealso>
        public virtual Task<RegisterApplicationRevisionResponse> RegisterApplicationRevisionAsync(RegisterApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterApplicationRevisionRequestMarshaller.Instance;
            var unmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterApplicationRevisionRequest,RegisterApplicationRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterOnPremisesInstance


        /// <summary>
        /// Registers an on-premises instance.
        /// 
        ///  <note> 
        /// <para>
        /// Only one IAM ARN (an IAM session ARN or IAM user ARN) is supported in the request.
        /// You cannot use both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOnPremisesInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.IamArnRequiredException">
        /// No IAM ARN was included in the request. You must use an IAM session ARN or IAM user
        /// ARN in the request.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamSessionArnAlreadyRegisteredException">
        /// The request included an IAM session ARN that has already been used to register a different
        /// instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnAlreadyRegisteredException">
        /// The specified IAM user ARN is already registered with an on-premises instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnRequiredException">
        /// An IAM user ARN was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameAlreadyRegisteredException">
        /// The specified on-premises instance name is already registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIamSessionArnException">
        /// The IAM session ARN was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIamUserArnException">
        /// The IAM user ARN was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.MultipleIamArnsProvidedException">
        /// Both an IAM user ARN and an IAM session ARN were included in the request. Use only
        /// one ARN type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterOnPremisesInstance">REST API Reference for RegisterOnPremisesInstance Operation</seealso>
        public virtual RegisterOnPremisesInstanceResponse RegisterOnPremisesInstance(RegisterOnPremisesInstanceRequest request)
        {
            var marshaller = RegisterOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterOnPremisesInstanceRequest,RegisterOnPremisesInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOnPremisesInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOnPremisesInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterOnPremisesInstance">REST API Reference for RegisterOnPremisesInstance Operation</seealso>
        public virtual Task<RegisterOnPremisesInstanceResponse> RegisterOnPremisesInstanceAsync(RegisterOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterOnPremisesInstanceRequestMarshaller.Instance;
            var unmarshaller = RegisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterOnPremisesInstanceRequest,RegisterOnPremisesInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromOnPremisesInstances


        /// <summary>
        /// Removes one or more tags from one or more on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromOnPremisesInstances service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceLimitExceededException">
        /// The maximum number of allowed on-premises instances in a single call was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The specified on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RemoveTagsFromOnPremisesInstances">REST API Reference for RemoveTagsFromOnPremisesInstances Operation</seealso>
        public virtual RemoveTagsFromOnPremisesInstancesResponse RemoveTagsFromOnPremisesInstances(RemoveTagsFromOnPremisesInstancesRequest request)
        {
            var marshaller = RemoveTagsFromOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromOnPremisesInstancesRequest,RemoveTagsFromOnPremisesInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromOnPremisesInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromOnPremisesInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RemoveTagsFromOnPremisesInstances">REST API Reference for RemoveTagsFromOnPremisesInstances Operation</seealso>
        public virtual Task<RemoveTagsFromOnPremisesInstancesResponse> RemoveTagsFromOnPremisesInstancesAsync(RemoveTagsFromOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsFromOnPremisesInstancesRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromOnPremisesInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromOnPremisesInstancesRequest,RemoveTagsFromOnPremisesInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SkipWaitTimeForInstanceTermination


        /// <summary>
        /// In a blue/green deployment, overrides any specified wait time and starts terminating
        /// instances immediately after the traffic routing is completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SkipWaitTimeForInstanceTermination service method.</param>
        /// 
        /// <returns>The response from the SkipWaitTimeForInstanceTermination service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
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
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/SkipWaitTimeForInstanceTermination">REST API Reference for SkipWaitTimeForInstanceTermination Operation</seealso>
        public virtual SkipWaitTimeForInstanceTerminationResponse SkipWaitTimeForInstanceTermination(SkipWaitTimeForInstanceTerminationRequest request)
        {
            var marshaller = SkipWaitTimeForInstanceTerminationRequestMarshaller.Instance;
            var unmarshaller = SkipWaitTimeForInstanceTerminationResponseUnmarshaller.Instance;

            return Invoke<SkipWaitTimeForInstanceTerminationRequest,SkipWaitTimeForInstanceTerminationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SkipWaitTimeForInstanceTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SkipWaitTimeForInstanceTermination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/SkipWaitTimeForInstanceTermination">REST API Reference for SkipWaitTimeForInstanceTermination Operation</seealso>
        public virtual Task<SkipWaitTimeForInstanceTerminationResponse> SkipWaitTimeForInstanceTerminationAsync(SkipWaitTimeForInstanceTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SkipWaitTimeForInstanceTerminationRequestMarshaller.Instance;
            var unmarshaller = SkipWaitTimeForInstanceTerminationResponseUnmarshaller.Instance;

            return InvokeAsync<SkipWaitTimeForInstanceTerminationRequest,SkipWaitTimeForInstanceTerminationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        public virtual StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
        {
            var marshaller = StopDeploymentRequestMarshaller.Instance;
            var unmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return Invoke<StopDeploymentRequest,StopDeploymentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        public virtual Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopDeploymentRequestMarshaller.Instance;
            var unmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StopDeploymentRequest,StopDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Changes the name of an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name already exists with the applicable IAM user
        /// or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeploymentGroup


        /// <summary>
        /// Changes information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name already exists with the applicable IAM
        /// user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group does not exist with the applicable IAM user or AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAlarmConfigException">
        /// The format of the alarm configuration is invalid. Possible causes include:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The alarm list is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm object is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm name is empty or null or exceeds the 255 character limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled but an invalid triggering event type or no event types
        /// were listed.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoScalingGroupException">
        /// The Auto Scaling group was specified in an invalid format or does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidBlueGreenDeploymentConfigurationException">
        /// The configuration for the blue/green deployment group was provided in an invalid format.
        /// For information about deployment configuration format, see <a>CreateDeploymentConfig</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentGroupNameException">
        /// The deployment group name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStyleException">
        /// An invalid deployment style was specified. Valid deployment types include "IN_PLACE"
        /// and "BLUE_GREEN". Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL".
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The specified input was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLoadBalancerInfoException">
        /// An invalid load balancer name, or no load balancer name, was specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidOnPremisesTagCombinationException">
        /// A call was submitted that specified both OnPremisesTagFilters and OnPremisesTagSet,
        /// but only one of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The specified tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTriggerConfigException">
        /// The trigger was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleHookLimitExceededException">
        /// The limit for lifecycle hooks was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagSetListLimitExceededException">
        /// The number of tag groups included in the tag set list exceeded the maximum allowed
        /// limit of 3.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateDeploymentGroup">REST API Reference for UpdateDeploymentGroup Operation</seealso>
        public virtual UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request)
        {
            var marshaller = UpdateDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentGroupRequest,UpdateDeploymentGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeploymentGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateDeploymentGroup">REST API Reference for UpdateDeploymentGroup Operation</seealso>
        public virtual Task<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDeploymentGroupRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentGroupRequest,UpdateDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
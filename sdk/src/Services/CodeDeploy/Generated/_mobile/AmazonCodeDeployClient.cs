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

#if CORECLR
    
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

#endif

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

        internal virtual AddTagsToOnPremisesInstancesResponse AddTagsToOnPremisesInstances(AddTagsToOnPremisesInstancesRequest request)
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

        internal virtual BatchGetApplicationRevisionsResponse BatchGetApplicationRevisions(BatchGetApplicationRevisionsRequest request)
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

        internal virtual BatchGetApplicationsResponse BatchGetApplications(BatchGetApplicationsRequest request)
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

        internal virtual BatchGetDeploymentGroupsResponse BatchGetDeploymentGroups(BatchGetDeploymentGroupsRequest request)
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

        internal virtual BatchGetDeploymentInstancesResponse BatchGetDeploymentInstances(BatchGetDeploymentInstancesRequest request)
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

        internal virtual BatchGetDeploymentsResponse BatchGetDeployments(BatchGetDeploymentsRequest request)
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

        internal virtual BatchGetOnPremisesInstancesResponse BatchGetOnPremisesInstances(BatchGetOnPremisesInstancesRequest request)
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

        internal virtual ContinueDeploymentResponse ContinueDeployment(ContinueDeploymentRequest request)
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

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
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

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
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

        internal virtual CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request)
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

        internal virtual CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request)
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

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
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

        internal virtual DeleteDeploymentConfigResponse DeleteDeploymentConfig(DeleteDeploymentConfigRequest request)
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

        internal virtual DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request)
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

        internal virtual DeleteGitHubAccountTokenResponse DeleteGitHubAccountToken(DeleteGitHubAccountTokenRequest request)
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

        internal virtual DeregisterOnPremisesInstanceResponse DeregisterOnPremisesInstance(DeregisterOnPremisesInstanceRequest request)
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

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
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

        internal virtual GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request)
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

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
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

        internal virtual GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request)
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

        internal virtual GetDeploymentGroupResponse GetDeploymentGroup(GetDeploymentGroupRequest request)
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

        internal virtual GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request)
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

        internal virtual GetOnPremisesInstanceResponse GetOnPremisesInstance(GetOnPremisesInstanceRequest request)
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

        internal virtual ListApplicationRevisionsResponse ListApplicationRevisions(ListApplicationRevisionsRequest request)
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

        internal virtual ListApplicationsResponse ListApplications()
        {
            return ListApplications(new ListApplicationsRequest());
        }
        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
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

        internal virtual ListDeploymentConfigsResponse ListDeploymentConfigs()
        {
            return ListDeploymentConfigs(new ListDeploymentConfigsRequest());
        }
        internal virtual ListDeploymentConfigsResponse ListDeploymentConfigs(ListDeploymentConfigsRequest request)
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

        internal virtual ListDeploymentGroupsResponse ListDeploymentGroups(ListDeploymentGroupsRequest request)
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

        internal virtual ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request)
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

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
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

        internal virtual ListGitHubAccountTokenNamesResponse ListGitHubAccountTokenNames(ListGitHubAccountTokenNamesRequest request)
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

        internal virtual ListOnPremisesInstancesResponse ListOnPremisesInstances(ListOnPremisesInstancesRequest request)
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

        internal virtual PutLifecycleEventHookExecutionStatusResponse PutLifecycleEventHookExecutionStatus(PutLifecycleEventHookExecutionStatusRequest request)
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

        internal virtual RegisterApplicationRevisionResponse RegisterApplicationRevision(RegisterApplicationRevisionRequest request)
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

        internal virtual RegisterOnPremisesInstanceResponse RegisterOnPremisesInstance(RegisterOnPremisesInstanceRequest request)
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

        internal virtual RemoveTagsFromOnPremisesInstancesResponse RemoveTagsFromOnPremisesInstances(RemoveTagsFromOnPremisesInstancesRequest request)
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

        internal virtual SkipWaitTimeForInstanceTerminationResponse SkipWaitTimeForInstanceTermination(SkipWaitTimeForInstanceTerminationRequest request)
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

        internal virtual StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
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

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
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

        internal virtual UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request)
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
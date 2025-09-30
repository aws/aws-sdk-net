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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeDeploy.Model;
using Amazon.CodeDeploy.Model.Internal.MarshallTransformations;
using Amazon.CodeDeploy.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CodeDeploy
{
    /// <summary>
    /// <para>Implementation for accessing CodeDeploy</para>
    ///
    /// CodeDeploy is a deployment service that automates application deployments to Amazon
    /// EC2 instances, on-premises instances running in your own facility, serverless Lambda
    /// functions, or applications in an Amazon ECS service.
    /// 
    ///  
    /// <para>
    /// You can deploy a nearly unlimited variety of application content, such as an updated
    /// Lambda function, updated applications in an Amazon ECS service, code, web and configuration
    /// files, executables, packages, scripts, multimedia files, and so on. CodeDeploy can
    /// deploy application content stored in Amazon S3 buckets, GitHub repositories, or Bitbucket
    /// repositories. You do not need to make changes to your existing code before you can
    /// use CodeDeploy.
    /// </para>
    ///  
    /// <para>
    /// CodeDeploy makes it easier for you to rapidly release new features, helps you avoid
    /// downtime during application deployment, and handles the complexity of updating your
    /// applications, without many of the risks associated with error-prone manual deployments.
    /// </para>
    ///  
    /// <para>
    ///  <b>CodeDeploy Components</b> 
    /// </para>
    ///  
    /// <para>
    /// Use the information in this guide to help you work with the following CodeDeploy components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Application</b>: A name that uniquely identifies the application you want to deploy.
    /// CodeDeploy uses this name, which functions as a container, to ensure the correct combination
    /// of revision, deployment configuration, and deployment group are referenced during
    /// a deployment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment group</b>: A set of individual instances, CodeDeploy Lambda deployment
    /// configuration settings, or an Amazon ECS service and network details. A Lambda deployment
    /// group specifies how to route traffic to a new version of a Lambda function. An Amazon
    /// ECS deployment group specifies the service created in Amazon ECS to deploy, a load
    /// balancer, and a listener to reroute production traffic to an updated containerized
    /// application. An Amazon EC2/On-premises deployment group contains individually tagged
    /// instances, Amazon EC2 instances in Amazon EC2 Auto Scaling groups, or both. All deployment
    /// groups can specify optional trigger, alarm, and rollback settings.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment configuration</b>: A set of deployment rules and deployment success
    /// and failure conditions used by CodeDeploy during a deployment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Deployment</b>: The process and the components used when updating a Lambda function,
    /// a containerized application in an Amazon ECS service, or of installing content on
    /// one or more instances. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Application revisions</b>: For an Lambda deployment, this is an AppSpec file that
    /// specifies the Lambda function to be updated and one or more functions to validate
    /// deployment lifecycle events. For an Amazon ECS deployment, this is an AppSpec file
    /// that specifies the Amazon ECS task definition, container, and port where production
    /// traffic is rerouted. For an EC2/On-premises deployment, this is an archive file that
    /// contains source content—source code, webpages, executable files, and deployment scripts—along
    /// with an AppSpec file. Revisions are stored in Amazon S3 buckets or GitHub repositories.
    /// For Amazon S3, a revision is uniquely identified by its Amazon S3 object key and its
    /// ETag, version, or both. For GitHub, a revision is uniquely identified by its commit
    /// ID.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This guide also contains information to help you get details about the instances in
    /// your deployments, to make on-premises instances available for CodeDeploy deployments,
    /// to get details about a Lambda function deployment, and to get details about Amazon
    /// ECS service deployments.
    /// </para>
    ///  
    /// <para>
    ///  <b>CodeDeploy Information Resources</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide">CodeDeploy User
    /// Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/">CodeDeploy
    /// API Reference Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cli/latest/reference/deploy/index.html">CLI
    /// Reference for CodeDeploy</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://forums.aws.amazon.com/forum.jspa?forumID=179">CodeDeploy Developer
    /// Forum</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCodeDeployClient : AmazonServiceClient, IAmazonCodeDeploy
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeDeployMetadata();
        private ICodeDeployPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeDeployPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeDeployPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
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
            : base(new AmazonCodeDeployConfig()) { }

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
            : base(new AmazonCodeDeployConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeDeployEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeDeployAuthSchemeHandler());
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<AddTagsToOnPremisesInstancesResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToOnPremisesInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/AddTagsToOnPremisesInstances">REST API Reference for AddTagsToOnPremisesInstances Operation</seealso>
        public virtual Task<AddTagsToOnPremisesInstancesResponse> AddTagsToOnPremisesInstancesAsync(AddTagsToOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToOnPremisesInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToOnPremisesInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetApplicationRevisions


        /// <summary>
        /// Gets information about one or more application revisions. The maximum number of application
        /// revisions that can be returned is 25.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetApplicationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetApplicationRevisionsResponseUnmarshaller.Instance;

            return Invoke<BatchGetApplicationRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more application revisions. The maximum number of application
        /// revisions that can be returned is 25.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplicationRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        public virtual Task<BatchGetApplicationRevisionsResponse> BatchGetApplicationRevisionsAsync(BatchGetApplicationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetApplicationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetApplicationRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetApplicationRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetApplications


        /// <summary>
        /// Gets information about one or more applications. The maximum number of applications
        /// that can be returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications service method.</param>
        /// 
        /// <returns>The response from the BatchGetApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return Invoke<BatchGetApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more applications. The maximum number of applications
        /// that can be returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        public virtual Task<BatchGetApplicationsResponse> BatchGetApplicationsAsync(BatchGetApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetApplicationsResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentGroupsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentGroupsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more deployment groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
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
        public virtual Task<BatchGetDeploymentGroupsResponse> BatchGetDeploymentGroupsAsync(BatchGetDeploymentGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDeploymentGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeploymentInstances


        /// <summary>
        /// <note> 
        /// <para>
        ///  This method works, but is deprecated. Use <c>BatchGetDeploymentTargets</c> instead.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Returns an array of one or more instances associated with a deployment. This method
        /// works with EC2/On-premises and Lambda compute platforms. The newer <c>BatchGetDeploymentTargets</c>
        /// works with all compute platforms. The maximum number of instances that can be returned
        /// is 25.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentInstances">REST API Reference for BatchGetDeploymentInstances Operation</seealso>
        [Obsolete("This operation is deprecated, use BatchGetDeploymentTargets instead.")]
        public virtual BatchGetDeploymentInstancesResponse BatchGetDeploymentInstances(BatchGetDeploymentInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentInstancesResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentInstancesResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        ///  This method works, but is deprecated. Use <c>BatchGetDeploymentTargets</c> instead.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Returns an array of one or more instances associated with a deployment. This method
        /// works with EC2/On-premises and Lambda compute platforms. The newer <c>BatchGetDeploymentTargets</c>
        /// works with all compute platforms. The maximum number of instances that can be returned
        /// is 25.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceIdRequiredException">
        /// The instance ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentInstances">REST API Reference for BatchGetDeploymentInstances Operation</seealso>
        [Obsolete("This operation is deprecated, use BatchGetDeploymentTargets instead.")]
        public virtual Task<BatchGetDeploymentInstancesResponse> BatchGetDeploymentInstancesAsync(BatchGetDeploymentInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDeploymentInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeployments


        /// <summary>
        /// Gets information about one or more deployments. The maximum number of deployments
        /// that can be returned is 25.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more deployments. The maximum number of deployments
        /// that can be returned is 25.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<BatchGetDeploymentsResponse> BatchGetDeploymentsAsync(BatchGetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeploymentTargets


        /// <summary>
        /// Returns an array of one or more targets associated with a deployment. This method
        /// works with all compute types and should be used instead of the deprecated <c>BatchGetDeploymentInstances</c>.
        /// The maximum number of targets that can be returned is 25.
        /// 
        ///  
        /// <para>
        ///  The type of targets returned depends on the deployment's compute platform or deployment
        /// method: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>EC2/On-premises</b>: Information about Amazon EC2 instance targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Lambda</b>: Information about Lambda functions targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon ECS</b>: Information about Amazon ECS service targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudFormation</b>: Information about targets of blue/green deployments initiated
        /// by a CloudFormation stack update.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentTargets service method.</param>
        /// 
        /// <returns>The response from the BatchGetDeploymentTargets service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetDoesNotExistException">
        /// The provided target ID does not belong to the attempted deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetIdRequiredException">
        /// A deployment target ID was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetListSizeExceededException">
        /// The maximum number of targets that can be associated with an Amazon ECS or Lambda
        /// deployment was exceeded. The target list of both types of deployments must have exactly
        /// one item. This exception does not apply to EC2/On-premises deployments.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceDoesNotExistException">
        /// The specified instance does not exist in the deployment group.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentTargetIdException">
        /// The target ID provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentTargets">REST API Reference for BatchGetDeploymentTargets Operation</seealso>
        public virtual BatchGetDeploymentTargetsResponse BatchGetDeploymentTargets(BatchGetDeploymentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentTargetsResponseUnmarshaller.Instance;

            return Invoke<BatchGetDeploymentTargetsResponse>(request, options);
        }


        /// <summary>
        /// Returns an array of one or more targets associated with a deployment. This method
        /// works with all compute types and should be used instead of the deprecated <c>BatchGetDeploymentInstances</c>.
        /// The maximum number of targets that can be returned is 25.
        /// 
        ///  
        /// <para>
        ///  The type of targets returned depends on the deployment's compute platform or deployment
        /// method: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>EC2/On-premises</b>: Information about Amazon EC2 instance targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Lambda</b>: Information about Lambda functions targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon ECS</b>: Information about Amazon ECS service targets. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudFormation</b>: Information about targets of blue/green deployments initiated
        /// by a CloudFormation stack update.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDeploymentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDeploymentTargets service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetDoesNotExistException">
        /// The provided target ID does not belong to the attempted deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetIdRequiredException">
        /// A deployment target ID was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetListSizeExceededException">
        /// The maximum number of targets that can be associated with an Amazon ECS or Lambda
        /// deployment was exceeded. The target list of both types of deployments must have exactly
        /// one item. This exception does not apply to EC2/On-premises deployments.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceDoesNotExistException">
        /// The specified instance does not exist in the deployment group.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentTargetIdException">
        /// The target ID provided was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetDeploymentTargets">REST API Reference for BatchGetDeploymentTargets Operation</seealso>
        public virtual Task<BatchGetDeploymentTargetsResponse> BatchGetDeploymentTargetsAsync(BatchGetDeploymentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetDeploymentTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetDeploymentTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetOnPremisesInstances


        /// <summary>
        /// Gets information about one or more on-premises instances. The maximum number of on-premises
        /// instances that can be returned is 25.
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetOnPremisesInstances">REST API Reference for BatchGetOnPremisesInstances Operation</seealso>
        public virtual BatchGetOnPremisesInstancesResponse BatchGetOnPremisesInstances(BatchGetOnPremisesInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<BatchGetOnPremisesInstancesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more on-premises instances. The maximum number of on-premises
        /// instances that can be returned is 25.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetOnPremisesInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.BatchLimitExceededException">
        /// The maximum number of names or IDs allowed for this request (100) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/BatchGetOnPremisesInstances">REST API Reference for BatchGetOnPremisesInstances Operation</seealso>
        public virtual Task<BatchGetOnPremisesInstancesResponse> BatchGetOnPremisesInstancesAsync(BatchGetOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetOnPremisesInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetOnPremisesInstancesResponse>(request, options, cancellationToken);
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
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStatusException">
        /// The specified deployment status doesn't exist or cannot be determined.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentWaitTypeException">
        /// The wait type is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ContinueDeployment">REST API Reference for ContinueDeployment Operation</seealso>
        public virtual ContinueDeploymentResponse ContinueDeployment(ContinueDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContinueDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueDeploymentResponseUnmarshaller.Instance;

            return Invoke<ContinueDeploymentResponse>(request, options);
        }


        /// <summary>
        /// For a blue/green deployment, starts the process of rerouting traffic from instances
        /// in the original environment to instances in the replacement environment without waiting
        /// for a specified wait time to elapse. (Traffic rerouting, which is achieved by registering
        /// instances in the replacement environment with the load balancer, can start as soon
        /// as all instances have a status of Ready.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContinueDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ContinueDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentStatusException">
        /// The specified deployment status doesn't exist or cannot be determined.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentWaitTypeException">
        /// The wait type is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ContinueDeployment">REST API Reference for ContinueDeployment Operation</seealso>
        public virtual Task<ContinueDeploymentResponse> ContinueDeploymentAsync(ContinueDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ContinueDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<ContinueDeploymentResponse>(request, options, cancellationToken);
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
        /// An application with the specified name with the user or Amazon Web Services account
        /// already exists.
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
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name with the user or Amazon Web Services account
        /// already exists.
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
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Deploys an application revision through the specified deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// An invalid fileExistsBehavior option was specified to determine how CodeDeploy handles
        /// files or directories that already exist in a deployment target location, but weren't
        /// part of the previous successful deployment. Valid values include "DISALLOW," "OVERWRITE,"
        /// and "RETAIN."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidGitHubAccountTokenException">
        /// The GitHub token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIgnoreApplicationStopFailuresValueException">
        /// The IgnoreApplicationStopFailures value is invalid. For Lambda deployments, <c>false</c>
        /// is expected. For EC2/On-premises deployments, <c>true</c> or <c>false</c> is expected.
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
        /// to Amazon EC2 Auto Scaling.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidUpdateOutdatedInstancesOnlyValueException">
        /// The UpdateOutdatedInstancesOnly value is invalid. For Lambda deployments, <c>false</c>
        /// is expected. For EC2/On-premises deployments, <c>true</c> or <c>false</c> is expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionDoesNotExistException">
        /// The named revision does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Deploys an application revision through the specified deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// An invalid fileExistsBehavior option was specified to determine how CodeDeploy handles
        /// files or directories that already exist in a deployment target location, but weren't
        /// part of the previous successful deployment. Valid values include "DISALLOW," "OVERWRITE,"
        /// and "RETAIN."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidGitHubAccountTokenException">
        /// The GitHub token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidIgnoreApplicationStopFailuresValueException">
        /// The IgnoreApplicationStopFailures value is invalid. For Lambda deployments, <c>false</c>
        /// is expected. For EC2/On-premises deployments, <c>true</c> or <c>false</c> is expected.
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
        /// to Amazon EC2 Auto Scaling.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidUpdateOutdatedInstancesOnlyValueException">
        /// The UpdateOutdatedInstancesOnly value is invalid. For Lambda deployments, <c>false</c>
        /// is expected. For EC2/On-premises deployments, <c>true</c> or <c>false</c> is expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionDoesNotExistException">
        /// The named revision does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
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
        /// A deployment configuration with the specified name with the user or Amazon Web Services
        /// account already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigLimitExceededException">
        /// The deployment configurations limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidZonalDeploymentConfigurationException">
        /// The <c>ZonalConfig</c> object is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentConfig">REST API Reference for CreateDeploymentConfig Operation</seealso>
        public virtual CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentConfigResponse>(request, options);
        }


        /// <summary>
        /// Creates a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigAlreadyExistsException">
        /// A deployment configuration with the specified name with the user or Amazon Web Services
        /// account already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigLimitExceededException">
        /// The deployment configurations limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidZonalDeploymentConfigurationException">
        /// The <c>ZonalConfig</c> object is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentConfig">REST API Reference for CreateDeploymentConfig Operation</seealso>
        public virtual Task<CreateDeploymentConfigResponse> CreateDeploymentConfigAsync(CreateDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeploymentGroup


        /// <summary>
        /// Creates a deployment group to which application revisions are deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupLimitExceededException">
        /// The deployment groups limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ECSServiceMappingLimitExceededException">
        /// The Amazon ECS service is associated with more than one deployment groups. An Amazon
        /// ECS service can be associated with only one deployment group.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// and "BLUE_GREEN." Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidECSServiceException">
        /// The Amazon ECS service identifier is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetGroupPairException">
        /// A target group pair associated with this deployment is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
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
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentGroup">REST API Reference for CreateDeploymentGroup Operation</seealso>
        public virtual CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a deployment group to which application revisions are deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupLimitExceededException">
        /// The deployment groups limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ECSServiceMappingLimitExceededException">
        /// The Amazon ECS service is associated with more than one deployment groups. An Amazon
        /// ECS service can be associated with only one deployment group.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// and "BLUE_GREEN." Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidECSServiceException">
        /// The Amazon ECS service identifier is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetGroupPairException">
        /// A target group pair associated with this deployment is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
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
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/CreateDeploymentGroup">REST API Reference for CreateDeploymentGroup Operation</seealso>
        public virtual Task<CreateDeploymentGroupResponse> CreateDeploymentGroupAsync(CreateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentGroupResponse>(request, options, cancellationToken);
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRoleException">
        /// The service role ARN was specified in an invalid format. Or, if an Auto Scaling group
        /// was specified, the specified service role does not grant the appropriate permissions
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentConfigResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteDeploymentConfigResponse> DeleteDeploymentConfigAsync(DeleteDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDeploymentConfigResponse>(request, options, cancellationToken);
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentGroup">REST API Reference for DeleteDeploymentGroup Operation</seealso>
        public virtual DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeploymentGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteDeploymentGroup">REST API Reference for DeleteDeploymentGroup Operation</seealso>
        public virtual Task<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDeploymentGroupResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGitHubAccountTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGitHubAccountTokenResponseUnmarshaller.Instance;

            return Invoke<DeleteGitHubAccountTokenResponse>(request, options);
        }


        /// <summary>
        /// Deletes a GitHub account connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGitHubAccountToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteGitHubAccountTokenResponse> DeleteGitHubAccountTokenAsync(DeleteGitHubAccountTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGitHubAccountTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGitHubAccountTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGitHubAccountTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcesByExternalId


        /// <summary>
        /// Deletes resources linked to an external ID. This action only applies if you have configured
        /// blue/green deployments through CloudFormation. 
        /// 
        ///  <note> 
        /// <para>
        /// It is not necessary to call this action directly. CloudFormation calls it on your
        /// behalf when it needs to delete stack resources. This action is offered publicly in
        /// case you need to delete resources to comply with General Data Protection Regulation
        /// (GDPR) requirements.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcesByExternalId service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcesByExternalId service method, as returned by CodeDeploy.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteResourcesByExternalId">REST API Reference for DeleteResourcesByExternalId Operation</seealso>
        public virtual DeleteResourcesByExternalIdResponse DeleteResourcesByExternalId(DeleteResourcesByExternalIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcesByExternalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcesByExternalIdResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcesByExternalIdResponse>(request, options);
        }


        /// <summary>
        /// Deletes resources linked to an external ID. This action only applies if you have configured
        /// blue/green deployments through CloudFormation. 
        /// 
        ///  <note> 
        /// <para>
        /// It is not necessary to call this action directly. CloudFormation calls it on your
        /// behalf when it needs to delete stack resources. This action is offered publicly in
        /// case you need to delete resources to comply with General Data Protection Regulation
        /// (GDPR) requirements.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcesByExternalId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcesByExternalId service method, as returned by CodeDeploy.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeleteResourcesByExternalId">REST API Reference for DeleteResourcesByExternalId Operation</seealso>
        public virtual Task<DeleteResourcesByExternalIdResponse> DeleteResourcesByExternalIdAsync(DeleteResourcesByExternalIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcesByExternalIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcesByExternalIdResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcesByExternalIdResponse>(request, options, cancellationToken);
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeregisterOnPremisesInstance">REST API Reference for DeregisterOnPremisesInstance Operation</seealso>
        public virtual DeregisterOnPremisesInstanceResponse DeregisterOnPremisesInstance(DeregisterOnPremisesInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<DeregisterOnPremisesInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deregisters an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOnPremisesInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/DeregisterOnPremisesInstance">REST API Reference for DeregisterOnPremisesInstance Operation</seealso>
        public virtual Task<DeregisterOnPremisesInstanceResponse> DeregisterOnPremisesInstanceAsync(DeregisterOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOnPremisesInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterOnPremisesInstanceResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
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
        /// The named revision does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplicationRevision">REST API Reference for GetApplicationRevision Operation</seealso>
        public virtual GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<GetApplicationRevisionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an application revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        /// The named revision does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.RevisionRequiredException">
        /// The revision ID was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetApplicationRevision">REST API Reference for GetApplicationRevision Operation</seealso>
        public virtual Task<GetApplicationRevisionResponse> GetApplicationRevisionAsync(GetApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApplicationRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Gets information about a deployment.
        /// 
        ///  <note> 
        /// <para>
        ///  The <c>content</c> property of the <c>appSpecContent</c> object in the returned revision
        /// is always null. Use <c>GetApplicationRevision</c> and the <c>sha256</c> property of
        /// the returned <c>appSpecContent</c> object to get the content of the deployment’s AppSpec
        /// file. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a deployment.
        /// 
        ///  <note> 
        /// <para>
        ///  The <c>content</c> property of the <c>appSpecContent</c> object in the returned revision
        /// is always null. Use <c>GetApplicationRevision</c> and the <c>sha256</c> property of
        /// the returned <c>appSpecContent</c> object to get the content of the deployment’s AppSpec
        /// file. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
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
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentConfig">REST API Reference for GetDeploymentConfig Operation</seealso>
        public virtual GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentConfigResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a deployment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentConfig service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigNameRequiredException">
        /// The deployment configuration name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentConfigNameException">
        /// The deployment configuration name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentConfig">REST API Reference for GetDeploymentConfig Operation</seealso>
        public virtual Task<GetDeploymentConfigResponse> GetDeploymentConfigAsync(GetDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentConfigResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentGroupResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
        public virtual Task<GetDeploymentGroupResponse> GetDeploymentGroupAsync(GetDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentGroupResponse>(request, options, cancellationToken);
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
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentInstance">REST API Reference for GetDeploymentInstance Operation</seealso>
        [Obsolete("This operation is deprecated, use GetDeploymentTarget instead.")]
        public virtual GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentInstanceResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an instance as part of a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentInstance">REST API Reference for GetDeploymentInstance Operation</seealso>
        [Obsolete("This operation is deprecated, use GetDeploymentTarget instead.")]
        public virtual Task<GetDeploymentInstanceResponse> GetDeploymentInstanceAsync(GetDeploymentInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentTarget


        /// <summary>
        /// Returns information about a deployment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentTarget service method.</param>
        /// 
        /// <returns>The response from the GetDeploymentTarget service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetDoesNotExistException">
        /// The provided target ID does not belong to the attempted deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetIdRequiredException">
        /// A deployment target ID was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentTargetIdException">
        /// The target ID provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentTarget">REST API Reference for GetDeploymentTarget Operation</seealso>
        public virtual GetDeploymentTargetResponse GetDeploymentTarget(GetDeploymentTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentTargetResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentTargetResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a deployment target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeploymentTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeploymentTarget service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetDoesNotExistException">
        /// The provided target ID does not belong to the attempted deployment.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentTargetIdRequiredException">
        /// A deployment target ID was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentTargetIdException">
        /// The target ID provided was not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetDeploymentTarget">REST API Reference for GetDeploymentTarget Operation</seealso>
        public virtual Task<GetDeploymentTargetResponse> GetDeploymentTargetAsync(GetDeploymentTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentTargetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentTargetResponse>(request, options, cancellationToken);
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetOnPremisesInstance">REST API Reference for GetOnPremisesInstance Operation</seealso>
        public virtual GetOnPremisesInstanceResponse GetOnPremisesInstance(GetOnPremisesInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<GetOnPremisesInstanceResponse>(request, options);
        }


        /// <summary>
        /// Gets information about an on-premises instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnPremisesInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNameRequiredException">
        /// An on-premises instance name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InstanceNotRegisteredException">
        /// The specified on-premises instance is not registered.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/GetOnPremisesInstance">REST API Reference for GetOnPremisesInstance Operation</seealso>
        public virtual Task<GetOnPremisesInstanceResponse> GetOnPremisesInstanceAsync(GetOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnPremisesInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOnPremisesInstanceResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Lists information about revisions for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationRevisions service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        public virtual Task<ListApplicationRevisionsResponse> ListApplicationRevisionsAsync(ListApplicationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists the applications registered with the user or Amazon Web Services account.
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
        /// Lists the applications registered with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the applications registered with the user or Amazon Web Services account.
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
        /// Lists the applications registered with the user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentConfigs


        /// <summary>
        /// Lists the deployment configurations with the user or Amazon Web Services account.
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
        /// Lists the deployment configurations with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigsResponse>(request, options);
        }


        /// <summary>
        /// Lists the deployment configurations with the user or Amazon Web Services account.
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
        /// Lists the deployment configurations with the user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentConfigs service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentConfigs">REST API Reference for ListDeploymentConfigs Operation</seealso>
        public virtual Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(ListDeploymentConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentGroups


        /// <summary>
        /// Lists the deployment groups for an application registered with the Amazon Web Services
        /// user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentGroupsResponse>(request, options);
        }


        /// <summary>
        /// Lists the deployment groups for an application registered with the Amazon Web Services
        /// user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentGroups service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        public virtual Task<ListDeploymentGroupsResponse> ListDeploymentGroupsAsync(ListDeploymentGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentInstances


        /// <summary>
        /// <note> 
        /// <para>
        ///  The newer <c>BatchGetDeploymentTargets</c> should be used instead because it works
        /// with all compute types. <c>ListDeploymentInstances</c> throws an exception if it is
        /// used with a compute platform other than EC2/On-premises or Lambda. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Lists the instance for a deployment associated with the user or Amazon Web Services
        /// account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetFilterNameException">
        /// The target filter name is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentInstances">REST API Reference for ListDeploymentInstances Operation</seealso>
        [Obsolete("This operation is deprecated, use ListDeploymentTargets instead.")]
        public virtual ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentInstancesResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        ///  The newer <c>BatchGetDeploymentTargets</c> should be used instead because it works
        /// with all compute types. <c>ListDeploymentInstances</c> throws an exception if it is
        /// used with a compute platform other than EC2/On-premises or Lambda. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Lists the instance for a deployment associated with the user or Amazon Web Services
        /// account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentNotStartedException">
        /// The specified deployment has not started.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidComputePlatformException">
        /// The computePlatform is invalid. The computePlatform should be <c>Lambda</c>, <c>Server</c>,
        /// or <c>ECS</c>.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetFilterNameException">
        /// The target filter name is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentInstances">REST API Reference for ListDeploymentInstances Operation</seealso>
        [Obsolete("This operation is deprecated, use ListDeploymentTargets instead.")]
        public virtual Task<ListDeploymentInstancesResponse> ListDeploymentInstancesAsync(ListDeploymentInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments


        /// <summary>
        /// Lists the deployments in a deployment group for an application registered with the
        /// user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidExternalIdException">
        /// The external ID was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Lists the deployments in a deployment group for an application registered with the
        /// user or Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidExternalIdException">
        /// The external ID was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTimeRangeException">
        /// The specified time range was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentTargets


        /// <summary>
        /// Returns an array of target IDs that are associated a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentTargets service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentTargets service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetFilterNameException">
        /// The target filter name is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentTargets">REST API Reference for ListDeploymentTargets Operation</seealso>
        public virtual ListDeploymentTargetsResponse ListDeploymentTargets(ListDeploymentTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentTargetsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentTargetsResponse>(request, options);
        }


        /// <summary>
        /// Returns an array of target IDs that are associated a deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentTargets service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetFilterNameException">
        /// The target filter name is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListDeploymentTargets">REST API Reference for ListDeploymentTargets Operation</seealso>
        public virtual Task<ListDeploymentTargetsResponse> ListDeploymentTargetsAsync(ListDeploymentTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDeploymentTargetsResponse>(request, options, cancellationToken);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGitHubAccountTokenNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGitHubAccountTokenNamesResponseUnmarshaller.Instance;

            return Invoke<ListGitHubAccountTokenNamesResponse>(request, options);
        }


        /// <summary>
        /// Lists the names of stored connections to GitHub accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGitHubAccountTokenNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListGitHubAccountTokenNamesResponse> ListGitHubAccountTokenNamesAsync(ListGitHubAccountTokenNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGitHubAccountTokenNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGitHubAccountTokenNamesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGitHubAccountTokenNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOnPremisesInstances


        /// <summary>
        /// Gets a list of names for one or more on-premises instances.
        /// 
        ///  
        /// <para>
        /// Unless otherwise specified, both registered and deregistered on-premises instance
        /// names are listed. To list only registered or deregistered on-premises instance names,
        /// use the registration status parameter.
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
        /// The tag filter was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListOnPremisesInstances">REST API Reference for ListOnPremisesInstances Operation</seealso>
        public virtual ListOnPremisesInstancesResponse ListOnPremisesInstances(ListOnPremisesInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<ListOnPremisesInstancesResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of names for one or more on-premises instances.
        /// 
        ///  
        /// <para>
        /// Unless otherwise specified, both registered and deregistered on-premises instance
        /// names are listed. To list only registered or deregistered on-premises instance names,
        /// use the registration status parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOnPremisesInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOnPremisesInstances service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidNextTokenException">
        /// The next token was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidRegistrationStatusException">
        /// The registration status was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagFilterException">
        /// The tag filter was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListOnPremisesInstances">REST API Reference for ListOnPremisesInstances Operation</seealso>
        public virtual Task<ListOnPremisesInstancesResponse> ListOnPremisesInstancesAsync(ListOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOnPremisesInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOnPremisesInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for the resource identified by a specified Amazon Resource
        /// Name (ARN). Tags are used to organize and categorize your CodeDeploy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags for the resource identified by a specified Amazon Resource
        /// Name (ARN). Tags are used to organize and categorize your CodeDeploy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleEventHookExecutionStatus


        /// <summary>
        /// Sets the result of a Lambda validation function. The function validates lifecycle
        /// hooks during a deployment that uses the Lambda or Amazon ECS compute platform. For
        /// Lambda deployments, the available lifecycle hooks are <c>BeforeAllowTraffic</c> and
        /// <c>AfterAllowTraffic</c>. For Amazon ECS deployments, the available lifecycle hooks
        /// are <c>BeforeInstall</c>, <c>AfterInstall</c>, <c>AfterAllowTestTraffic</c>, <c>BeforeAllowTraffic</c>,
        /// and <c>AfterAllowTraffic</c>. Lambda validation functions return <c>Succeeded</c>
        /// or <c>Failed</c>. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-lambda">AppSpec
        /// 'hooks' Section for an Lambda Deployment </a> and <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-ecs">AppSpec
        /// 'hooks' Section for an Amazon ECS Deployment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleEventHookExecutionStatus service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleEventHookExecutionStatus service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionIdException">
        /// A lifecycle event hook is invalid. Review the <c>hooks</c> section in your AppSpec
        /// file to ensure the lifecycle events and <c>hooks</c> functions are valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionStatusException">
        /// The result of a Lambda validation function that verifies a lifecycle event is invalid.
        /// It should return <c>Succeeded</c> or <c>Failed</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLifecycleEventHookExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleEventHookExecutionStatusResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleEventHookExecutionStatusResponse>(request, options);
        }


        /// <summary>
        /// Sets the result of a Lambda validation function. The function validates lifecycle
        /// hooks during a deployment that uses the Lambda or Amazon ECS compute platform. For
        /// Lambda deployments, the available lifecycle hooks are <c>BeforeAllowTraffic</c> and
        /// <c>AfterAllowTraffic</c>. For Amazon ECS deployments, the available lifecycle hooks
        /// are <c>BeforeInstall</c>, <c>AfterInstall</c>, <c>AfterAllowTestTraffic</c>, <c>BeforeAllowTraffic</c>,
        /// and <c>AfterAllowTraffic</c>. Lambda validation functions return <c>Succeeded</c>
        /// or <c>Failed</c>. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-lambda">AppSpec
        /// 'hooks' Section for an Lambda Deployment </a> and <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-ecs">AppSpec
        /// 'hooks' Section for an Amazon ECS Deployment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleEventHookExecutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleEventHookExecutionStatus service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionIdException">
        /// A lifecycle event hook is invalid. Review the <c>hooks</c> section in your AppSpec
        /// file to ensure the lifecycle events and <c>hooks</c> functions are valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidLifecycleEventHookExecutionStatusException">
        /// The result of a Lambda validation function that verifies a lifecycle event is invalid.
        /// It should return <c>Succeeded</c> or <c>Failed</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.LifecycleEventAlreadyCompletedException">
        /// An attempt to return the status of an already completed lifecycle event occurred.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/PutLifecycleEventHookExecutionStatus">REST API Reference for PutLifecycleEventHookExecutionStatus Operation</seealso>
        public virtual Task<PutLifecycleEventHookExecutionStatusResponse> PutLifecycleEventHookExecutionStatusAsync(PutLifecycleEventHookExecutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLifecycleEventHookExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleEventHookExecutionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLifecycleEventHookExecutionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterApplicationRevision


        /// <summary>
        /// Registers with CodeDeploy a revision for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision service method.</param>
        /// 
        /// <returns>The response from the RegisterApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return Invoke<RegisterApplicationRevisionResponse>(request, options);
        }


        /// <summary>
        /// Registers with CodeDeploy a revision for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterApplicationRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterApplicationRevision service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
        public virtual Task<RegisterApplicationRevisionResponse> RegisterApplicationRevisionAsync(RegisterApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterApplicationRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterApplicationRevisionResponse>(request, options, cancellationToken);
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
        /// No IAM ARN was included in the request. You must use an IAM session ARN or user ARN
        /// in the request.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamSessionArnAlreadyRegisteredException">
        /// The request included an IAM session ARN that has already been used to register a different
        /// instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnAlreadyRegisteredException">
        /// The specified user ARN is already registered with an on-premises instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnRequiredException">
        /// An user ARN was not specified.
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
        /// The user ARN was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.MultipleIamArnsProvidedException">
        /// Both an user ARN and an IAM session ARN were included in the request. Use only one
        /// ARN type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterOnPremisesInstance">REST API Reference for RegisterOnPremisesInstance Operation</seealso>
        public virtual RegisterOnPremisesInstanceResponse RegisterOnPremisesInstance(RegisterOnPremisesInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOnPremisesInstanceResponseUnmarshaller.Instance;

            return Invoke<RegisterOnPremisesInstanceResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOnPremisesInstance service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.IamArnRequiredException">
        /// No IAM ARN was included in the request. You must use an IAM session ARN or user ARN
        /// in the request.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamSessionArnAlreadyRegisteredException">
        /// The request included an IAM session ARN that has already been used to register a different
        /// instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnAlreadyRegisteredException">
        /// The specified user ARN is already registered with an on-premises instance.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.IamUserArnRequiredException">
        /// An user ARN was not specified.
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
        /// The user ARN was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInstanceNameException">
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.MultipleIamArnsProvidedException">
        /// Both an user ARN and an IAM session ARN were included in the request. Use only one
        /// ARN type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RegisterOnPremisesInstance">REST API Reference for RegisterOnPremisesInstance Operation</seealso>
        public virtual Task<RegisterOnPremisesInstanceResponse> RegisterOnPremisesInstanceAsync(RegisterOnPremisesInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterOnPremisesInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOnPremisesInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterOnPremisesInstanceResponse>(request, options, cancellationToken);
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromOnPremisesInstancesResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromOnPremisesInstancesResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from one or more on-premises instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromOnPremisesInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The on-premises instance name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagLimitExceededException">
        /// The maximum allowed number of tags was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/RemoveTagsFromOnPremisesInstances">REST API Reference for RemoveTagsFromOnPremisesInstances Operation</seealso>
        public virtual Task<RemoveTagsFromOnPremisesInstancesResponse> RemoveTagsFromOnPremisesInstancesAsync(RemoveTagsFromOnPremisesInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromOnPremisesInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromOnPremisesInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromOnPremisesInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SkipWaitTimeForInstanceTermination


        /// <summary>
        /// In a blue/green deployment, overrides any specified wait time and starts terminating
        /// instances immediately after the traffic routing is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SkipWaitTimeForInstanceTermination service method.</param>
        /// 
        /// <returns>The response from the SkipWaitTimeForInstanceTermination service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        [Obsolete("This operation is deprecated, use ContinueDeployment with DeploymentWaitType instead.")]
        public virtual SkipWaitTimeForInstanceTerminationResponse SkipWaitTimeForInstanceTermination(SkipWaitTimeForInstanceTerminationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SkipWaitTimeForInstanceTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SkipWaitTimeForInstanceTerminationResponseUnmarshaller.Instance;

            return Invoke<SkipWaitTimeForInstanceTerminationResponse>(request, options);
        }


        /// <summary>
        /// In a blue/green deployment, overrides any specified wait time and starts terminating
        /// instances immediately after the traffic routing is complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SkipWaitTimeForInstanceTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SkipWaitTimeForInstanceTermination service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
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
        [Obsolete("This operation is deprecated, use ContinueDeployment with DeploymentWaitType instead.")]
        public virtual Task<SkipWaitTimeForInstanceTerminationResponse> SkipWaitTimeForInstanceTerminationAsync(SkipWaitTimeForInstanceTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SkipWaitTimeForInstanceTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SkipWaitTimeForInstanceTerminationResponseUnmarshaller.Instance;
            
            return InvokeAsync<SkipWaitTimeForInstanceTerminationResponse>(request, options, cancellationToken);
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
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        public virtual StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return Invoke<StopDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Attempts to stop an ongoing deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDeployment service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentAlreadyCompletedException">
        /// The deployment is already complete.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentDoesNotExistException">
        /// The deployment with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentIdRequiredException">
        /// At least one deployment ID must be specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidDeploymentIdException">
        /// At least one of the deployment IDs was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.UnsupportedActionForDeploymentTypeException">
        /// A call was submitted that is not supported for the specified deployment type.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/StopDeployment">REST API Reference for StopDeployment Operation</seealso>
        public virtual Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the list of tags in the input <c>Tags</c> parameter with the resource
        /// identified by the <c>ResourceArn</c> input parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associates the list of tags in the input <c>Tags</c> parameter with the resource
        /// identified by the <c>ResourceArn</c> input parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Disassociates a resource from a list of tags. The resource is identified by the <c>ResourceArn</c>
        /// input parameter. The tags are identified by the list of keys in the <c>TagKeys</c>
        /// input parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a resource from a list of tags. The resource is identified by the <c>ResourceArn</c>
        /// input parameter. The tags are identified by the list of keys in the <c>TagKeys</c>
        /// input parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ArnNotSupportedException">
        /// The specified ARN is not supported. For example, it might be an ARN for a resource
        /// that is not expected.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidArnException">
        /// The specified ARN is not in a valid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagsToAddException">
        /// The specified tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ResourceArnRequiredException">
        /// The ARN of a resource is required, but was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TagRequiredException">
        /// A tag was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// An application with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Changes the name of an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationAlreadyExistsException">
        /// An application with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
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
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ECSServiceMappingLimitExceededException">
        /// The Amazon ECS service is associated with more than one deployment groups. An Amazon
        /// ECS service can be associated with only one deployment group.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// and "BLUE_GREEN." Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidECSServiceException">
        /// The Amazon ECS service identifier is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetGroupPairException">
        /// A target group pair associated with this deployment is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
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
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateDeploymentGroup">REST API Reference for UpdateDeploymentGroup Operation</seealso>
        public virtual UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentGroupResponse>(request, options);
        }


        /// <summary>
        /// Changes information about a deployment group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeploymentGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeploymentGroup service method, as returned by CodeDeploy.</returns>
        /// <exception cref="Amazon.CodeDeploy.Model.AlarmsLimitExceededException">
        /// The maximum number of alarms for a deployment group (10) was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationDoesNotExistException">
        /// The application does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ApplicationNameRequiredException">
        /// The minimum number of required application names was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentConfigDoesNotExistException">
        /// The deployment configuration does not exist with the user or Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupAlreadyExistsException">
        /// A deployment group with the specified name with the user or Amazon Web Services account
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupDoesNotExistException">
        /// The named deployment group with the user or Amazon Web Services account does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.DeploymentGroupNameRequiredException">
        /// The deployment group name was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.ECSServiceMappingLimitExceededException">
        /// The Amazon ECS service is associated with more than one deployment groups. An Amazon
        /// ECS service can be associated with only one deployment group.
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
        /// The alarm name is empty or null or exceeds the limit of 255 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Two alarms with the same name have been specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alarm configuration is enabled, but the alarm list is empty.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidApplicationNameException">
        /// The application name was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidAutoRollbackConfigException">
        /// The automatic rollback configuration was specified in an invalid format. For example,
        /// automatic rollback is enabled, but an invalid triggering event type or no event types
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
        /// and "BLUE_GREEN." Valid deployment options include "WITH_TRAFFIC_CONTROL" and "WITHOUT_TRAFFIC_CONTROL."
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagCombinationException">
        /// A call was submitted that specified both Ec2TagFilters and Ec2TagSet, but only one
        /// of these data types can be used in a single call.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidEC2TagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidECSServiceException">
        /// The Amazon ECS service identifier is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidInputException">
        /// The input was specified in an invalid format.
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
        /// to Amazon EC2 Auto Scaling.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTagException">
        /// The tag was specified in an invalid format.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTargetGroupPairException">
        /// A target group pair associated with this deployment is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.InvalidTrafficRoutingConfigurationException">
        /// The configuration that specifies how traffic is routed during a deployment is invalid.
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
        /// <exception cref="Amazon.CodeDeploy.Model.ThrottlingException">
        /// An API function was called too frequently.
        /// </exception>
        /// <exception cref="Amazon.CodeDeploy.Model.TriggerTargetsLimitExceededException">
        /// The maximum allowed number of triggers was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codedeploy-2014-10-06/UpdateDeploymentGroup">REST API Reference for UpdateDeploymentGroup Operation</seealso>
        public virtual Task<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDeploymentGroupResponse>(request, options, cancellationToken);
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
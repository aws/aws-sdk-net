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

        internal BatchGetApplicationsResponse BatchGetApplications(BatchGetApplicationsRequest request)
        {
            var marshaller = new BatchGetApplicationsRequestMarshaller();
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
        public Task<BatchGetApplicationsResponse> BatchGetApplicationsAsync(BatchGetApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetApplicationsRequestMarshaller();
            var unmarshaller = BatchGetApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetApplicationsRequest,BatchGetApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchGetDeployments

        internal BatchGetDeploymentsResponse BatchGetDeployments(BatchGetDeploymentsRequest request)
        {
            var marshaller = new BatchGetDeploymentsRequestMarshaller();
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
        public Task<BatchGetDeploymentsResponse> BatchGetDeploymentsAsync(BatchGetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetDeploymentsRequestMarshaller();
            var unmarshaller = BatchGetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetDeploymentsRequest,BatchGetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = new CreateApplicationRequestMarshaller();
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
        public Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApplicationRequestMarshaller();
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
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
        public Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeploymentConfig

        internal CreateDeploymentConfigResponse CreateDeploymentConfig(CreateDeploymentConfigRequest request)
        {
            var marshaller = new CreateDeploymentConfigRequestMarshaller();
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
        public Task<CreateDeploymentConfigResponse> CreateDeploymentConfigAsync(CreateDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentConfigRequestMarshaller();
            var unmarshaller = CreateDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentConfigRequest,CreateDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeploymentGroup

        internal CreateDeploymentGroupResponse CreateDeploymentGroup(CreateDeploymentGroupRequest request)
        {
            var marshaller = new CreateDeploymentGroupRequestMarshaller();
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
        public Task<CreateDeploymentGroupResponse> CreateDeploymentGroupAsync(CreateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentGroupRequestMarshaller();
            var unmarshaller = CreateDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentGroupRequest,CreateDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
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
        public Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApplicationRequestMarshaller();
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeploymentConfig

        internal DeleteDeploymentConfigResponse DeleteDeploymentConfig(DeleteDeploymentConfigRequest request)
        {
            var marshaller = new DeleteDeploymentConfigRequestMarshaller();
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
        public Task<DeleteDeploymentConfigResponse> DeleteDeploymentConfigAsync(DeleteDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDeploymentConfigRequestMarshaller();
            var unmarshaller = DeleteDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentConfigRequest,DeleteDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeploymentGroup

        internal DeleteDeploymentGroupResponse DeleteDeploymentGroup(DeleteDeploymentGroupRequest request)
        {
            var marshaller = new DeleteDeploymentGroupRequestMarshaller();
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
        public Task<DeleteDeploymentGroupResponse> DeleteDeploymentGroupAsync(DeleteDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDeploymentGroupRequestMarshaller();
            var unmarshaller = DeleteDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentGroupRequest,DeleteDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApplication

        internal GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var marshaller = new GetApplicationRequestMarshaller();
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
        public Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetApplicationRequestMarshaller();
            var unmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationRequest,GetApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationRevision

        internal GetApplicationRevisionResponse GetApplicationRevision(GetApplicationRevisionRequest request)
        {
            var marshaller = new GetApplicationRevisionRequestMarshaller();
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
        public Task<GetApplicationRevisionResponse> GetApplicationRevisionAsync(GetApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetApplicationRevisionRequestMarshaller();
            var unmarshaller = GetApplicationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationRevisionRequest,GetApplicationRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment

        internal GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
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
        public Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentRequestMarshaller();
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentConfig

        internal GetDeploymentConfigResponse GetDeploymentConfig(GetDeploymentConfigRequest request)
        {
            var marshaller = new GetDeploymentConfigRequestMarshaller();
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
        public Task<GetDeploymentConfigResponse> GetDeploymentConfigAsync(GetDeploymentConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentConfigRequestMarshaller();
            var unmarshaller = GetDeploymentConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentConfigRequest,GetDeploymentConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentGroup

        internal GetDeploymentGroupResponse GetDeploymentGroup(GetDeploymentGroupRequest request)
        {
            var marshaller = new GetDeploymentGroupRequestMarshaller();
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
        public Task<GetDeploymentGroupResponse> GetDeploymentGroupAsync(GetDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentGroupRequestMarshaller();
            var unmarshaller = GetDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentGroupRequest,GetDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeploymentInstance

        internal GetDeploymentInstanceResponse GetDeploymentInstance(GetDeploymentInstanceRequest request)
        {
            var marshaller = new GetDeploymentInstanceRequestMarshaller();
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
        public Task<GetDeploymentInstanceResponse> GetDeploymentInstanceAsync(GetDeploymentInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentInstanceRequestMarshaller();
            var unmarshaller = GetDeploymentInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentInstanceRequest,GetDeploymentInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationRevisions

        internal ListApplicationRevisionsResponse ListApplicationRevisions(ListApplicationRevisionsRequest request)
        {
            var marshaller = new ListApplicationRevisionsRequestMarshaller();
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
        public Task<ListApplicationRevisionsResponse> ListApplicationRevisionsAsync(ListApplicationRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListApplicationRevisionsRequestMarshaller();
            var unmarshaller = ListApplicationRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationRevisionsRequest,ListApplicationRevisionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal ListApplicationsResponse ListApplications()
        {
            return ListApplications(new ListApplicationsRequest());
        }
        internal ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListApplicationsRequestMarshaller();
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentConfigs

        internal ListDeploymentConfigsResponse ListDeploymentConfigs()
        {
            return ListDeploymentConfigs(new ListDeploymentConfigsRequest());
        }
        internal ListDeploymentConfigsResponse ListDeploymentConfigs(ListDeploymentConfigsRequest request)
        {
            var marshaller = new ListDeploymentConfigsRequestMarshaller();
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentConfigsRequest,ListDeploymentConfigsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListDeploymentConfigsResponse> ListDeploymentConfigsAsync(ListDeploymentConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeploymentConfigsRequestMarshaller();
            var unmarshaller = ListDeploymentConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentConfigsRequest,ListDeploymentConfigsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentGroups

        internal ListDeploymentGroupsResponse ListDeploymentGroups(ListDeploymentGroupsRequest request)
        {
            var marshaller = new ListDeploymentGroupsRequestMarshaller();
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
        public Task<ListDeploymentGroupsResponse> ListDeploymentGroupsAsync(ListDeploymentGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeploymentGroupsRequestMarshaller();
            var unmarshaller = ListDeploymentGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentGroupsRequest,ListDeploymentGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeploymentInstances

        internal ListDeploymentInstancesResponse ListDeploymentInstances(ListDeploymentInstancesRequest request)
        {
            var marshaller = new ListDeploymentInstancesRequestMarshaller();
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
        public Task<ListDeploymentInstancesResponse> ListDeploymentInstancesAsync(ListDeploymentInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeploymentInstancesRequestMarshaller();
            var unmarshaller = ListDeploymentInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentInstancesRequest,ListDeploymentInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments

        internal ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
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
        public Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeploymentsRequestMarshaller();
            var unmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsRequest,ListDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterApplicationRevision

        internal RegisterApplicationRevisionResponse RegisterApplicationRevision(RegisterApplicationRevisionRequest request)
        {
            var marshaller = new RegisterApplicationRevisionRequestMarshaller();
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
        public Task<RegisterApplicationRevisionResponse> RegisterApplicationRevisionAsync(RegisterApplicationRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterApplicationRevisionRequestMarshaller();
            var unmarshaller = RegisterApplicationRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterApplicationRevisionRequest,RegisterApplicationRevisionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDeployment

        internal StopDeploymentResponse StopDeployment(StopDeploymentRequest request)
        {
            var marshaller = new StopDeploymentRequestMarshaller();
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
        public Task<StopDeploymentResponse> StopDeploymentAsync(StopDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopDeploymentRequestMarshaller();
            var unmarshaller = StopDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StopDeploymentRequest,StopDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
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
        public Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApplicationRequestMarshaller();
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeploymentGroup

        internal UpdateDeploymentGroupResponse UpdateDeploymentGroup(UpdateDeploymentGroupRequest request)
        {
            var marshaller = new UpdateDeploymentGroupRequestMarshaller();
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
        public Task<UpdateDeploymentGroupResponse> UpdateDeploymentGroupAsync(UpdateDeploymentGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDeploymentGroupRequestMarshaller();
            var unmarshaller = UpdateDeploymentGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentGroupRequest,UpdateDeploymentGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
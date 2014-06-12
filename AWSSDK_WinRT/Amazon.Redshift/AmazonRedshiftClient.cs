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


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift        <b>Overview</b>        
    /// <para>
    ///             This is an interface reference for Amazon Redshift. It contains documentation
    /// for one of the            programming or command line interfaces you can use to manage
    /// Amazon Redshift clusters. Note            that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques,            such as polling or asynchronous
    /// callback handlers, to determine when a command has been            applied. In this
    /// reference, the parameter descriptions indicate whether a change is            applied
    /// immediately, on the next instance reboot, or during the next maintenance         
    ///   window. For a summary of the Amazon Redshift cluster management interfaces, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces            </a>.
    /// </para>
    ///         
    /// <para>
    ///             Amazon Redshift manages all the work of setting up, operating, and scaling
    /// a data warehouse:             provisioning capacity, monitoring and backing up the
    /// cluster, and applying patches and             upgrades to the Amazon Redshift engine.
    /// You can focus on using your data to acquire new             insights for your business
    /// and customers.        
    /// </para>
    ///         
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the            The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>
    /// </para>
    ///         
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a>            explains how to design, build, query,
    /// and maintain the databases that make up your            data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonWebServiceClient, IAmazonRedshift
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AuthorizeClusterSecurityGroupIngress

        internal AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var task = AuthorizeClusterSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;
            return Invoke<IRequest, AuthorizeClusterSecurityGroupIngressRequest, AuthorizeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess

        internal AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var task = AuthorizeSnapshotAccessAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;
            return Invoke<IRequest, AuthorizeSnapshotAccessRequest, AuthorizeSnapshotAccessResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CopyClusterSnapshot

        internal CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var task = CopyClusterSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;
            return Invoke<IRequest, CopyClusterSnapshotRequest, CopyClusterSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateCluster

        internal CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var task = CreateClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateClusterRequest, CreateClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateClusterParameterGroup

        internal CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var task = CreateClusterParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateClusterParameterGroupRequest, CreateClusterParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateClusterSecurityGroup

        internal CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var task = CreateClusterSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateClusterSecurityGroupRequest, CreateClusterSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateClusterSnapshot

        internal CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var task = CreateClusterSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateClusterSnapshotRequest, CreateClusterSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateClusterSubnetGroup

        internal CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var task = CreateClusterSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateClusterSubnetGroupRequest, CreateClusterSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateEventSubscription

        internal CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var task = CreateEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateEventSubscriptionRequest, CreateEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateHsmClientCertificate

        internal CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var task = CreateHsmClientCertificateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateHsmClientCertificateRequest, CreateHsmClientCertificateResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateHsmConfiguration

        internal CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var task = CreateHsmConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateHsmConfigurationRequest, CreateHsmConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteCluster

        internal DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var task = DeleteClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteClusterRequest, DeleteClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteClusterParameterGroup

        internal DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var task = DeleteClusterParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteClusterParameterGroupRequest, DeleteClusterParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup

        internal DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var task = DeleteClusterSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteClusterSecurityGroupRequest, DeleteClusterSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteClusterSnapshot

        internal DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var task = DeleteClusterSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteClusterSnapshotRequest, DeleteClusterSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup

        internal DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var task = DeleteClusterSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteClusterSubnetGroupRequest, DeleteClusterSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var task = DeleteEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteEventSubscriptionRequest, DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteHsmClientCertificate

        internal DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var task = DeleteHsmClientCertificateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteHsmClientCertificateRequest, DeleteHsmClientCertificateResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteHsmConfiguration

        internal DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var task = DeleteHsmConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteHsmConfigurationRequest, DeleteHsmConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterParameterGroups

        internal DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }
        internal DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var task = DescribeClusterParameterGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterParameterGroupsRequest, DescribeClusterParameterGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterParameters

        internal DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var task = DescribeClusterParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterParametersRequest, DescribeClusterParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusters

        internal DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }
        internal DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var task = DescribeClustersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClustersRequest, DescribeClustersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups

        internal DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }
        internal DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var task = DescribeClusterSecurityGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterSecurityGroupsRequest, DescribeClusterSecurityGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterSnapshots

        internal DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }
        internal DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var task = DescribeClusterSnapshotsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterSnapshotsRequest, DescribeClusterSnapshotsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups

        internal DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }
        internal DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var task = DescribeClusterSubnetGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterSubnetGroupsRequest, DescribeClusterSubnetGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeClusterVersions

        internal DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }
        internal DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var task = DescribeClusterVersionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeClusterVersionsRequest, DescribeClusterVersionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters

        internal DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var task = DescribeDefaultClusterParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeDefaultClusterParametersRequest, DescribeDefaultClusterParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeEventCategories

        internal DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var task = DescribeEventCategoriesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeEventCategoriesRequest, DescribeEventCategoriesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeEvents

        internal DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var task = DescribeEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var task = DescribeEventSubscriptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeEventSubscriptionsRequest, DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeHsmClientCertificates

        internal DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }
        internal DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var task = DescribeHsmClientCertificatesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeHsmClientCertificatesRequest, DescribeHsmClientCertificatesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeHsmConfigurations

        internal DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }
        internal DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var task = DescribeHsmConfigurationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeHsmConfigurationsRequest, DescribeHsmConfigurationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoggingStatus

        internal DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var task = DescribeLoggingStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoggingStatusRequest, DescribeLoggingStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions

        internal DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }
        internal DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var task = DescribeOrderableClusterOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeOrderableClusterOptionsRequest, DescribeOrderableClusterOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings

        internal DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }
        internal DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var task = DescribeReservedNodeOfferingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeReservedNodeOfferingsRequest, DescribeReservedNodeOfferingsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeReservedNodes

        internal DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }
        internal DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var task = DescribeReservedNodesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeReservedNodesRequest, DescribeReservedNodesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeResize

        internal DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var task = DescribeResizeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeResizeRequest, DescribeResizeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DisableLogging

        internal DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var task = DisableLoggingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;
            return Invoke<IRequest, DisableLoggingRequest, DisableLoggingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DisableSnapshotCopy

        internal DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var task = DisableSnapshotCopyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;
            return Invoke<IRequest, DisableSnapshotCopyRequest, DisableSnapshotCopyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  EnableLogging

        internal EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var task = EnableLoggingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;
            return Invoke<IRequest, EnableLoggingRequest, EnableLoggingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  EnableSnapshotCopy

        internal EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var task = EnableSnapshotCopyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;
            return Invoke<IRequest, EnableSnapshotCopyRequest, EnableSnapshotCopyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifyCluster

        internal ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var task = ModifyClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifyClusterRequest, ModifyClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifyClusterParameterGroup

        internal ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var task = ModifyClusterParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifyClusterParameterGroupRequest, ModifyClusterParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup

        internal ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var task = ModifyClusterSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifyClusterSubnetGroupRequest, ModifyClusterSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var task = ModifyEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifyEventSubscriptionRequest, ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod

        internal ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var task = ModifySnapshotCopyRetentionPeriodAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifySnapshotCopyRetentionPeriodRequest, ModifySnapshotCopyRetentionPeriodResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering

        internal PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var task = PurchaseReservedNodeOfferingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;
            return Invoke<IRequest, PurchaseReservedNodeOfferingRequest, PurchaseReservedNodeOfferingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RebootCluster

        internal RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var task = RebootClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;
            return Invoke<IRequest, RebootClusterRequest, RebootClusterResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ResetClusterParameterGroup

        internal ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var task = ResetClusterParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;
            return Invoke<IRequest, ResetClusterParameterGroupRequest, ResetClusterParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot

        internal RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var task = RestoreFromClusterSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;
            return Invoke<IRequest, RestoreFromClusterSnapshotRequest, RestoreFromClusterSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress

        internal RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var task = RevokeClusterSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;
            return Invoke<IRequest, RevokeClusterSecurityGroupIngressRequest, RevokeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RevokeSnapshotAccess

        internal RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var task = RevokeSnapshotAccessAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;
            return Invoke<IRequest, RevokeSnapshotAccessRequest, RevokeSnapshotAccessResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RotateEncryptionKey

        internal RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var task = RotateEncryptionKeyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;
            return Invoke<IRequest, RotateEncryptionKeyRequest, RotateEncryptionKeyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}
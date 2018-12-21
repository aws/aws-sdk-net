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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Redshift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonServiceClient, IAmazonRedshift
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        public AmazonRedshiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        public AmazonRedshiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AmazonRedshiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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


        #region  AcceptReservedNodeExchange

        internal virtual AcceptReservedNodeExchangeResponse AcceptReservedNodeExchange(AcceptReservedNodeExchangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedNodeExchangeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedNodeExchange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        public virtual Task<AcceptReservedNodeExchangeResponse> AcceptReservedNodeExchangeAsync(AcceptReservedNodeExchangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedNodeExchangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedNodeExchangeResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptReservedNodeExchangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeClusterSecurityGroupIngress

        internal virtual AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClusterSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClusterSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess

        internal virtual AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSnapshotAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        public virtual Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSnapshotAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteClusterSnapshots

        internal virtual BatchDeleteClusterSnapshotsResponse BatchDeleteClusterSnapshots(BatchDeleteClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteClusterSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        public virtual Task<BatchDeleteClusterSnapshotsResponse> BatchDeleteClusterSnapshotsAsync(BatchDeleteClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchModifyClusterSnapshots

        internal virtual BatchModifyClusterSnapshotsResponse BatchModifyClusterSnapshots(BatchModifyClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<BatchModifyClusterSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchModifyClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        public virtual Task<BatchModifyClusterSnapshotsResponse> BatchModifyClusterSnapshotsAsync(BatchModifyClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchModifyClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchModifyClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchModifyClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelResize

        internal virtual CancelResizeResponse CancelResize(CancelResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return Invoke<CancelResizeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        public virtual Task<CancelResizeResponse> CancelResizeAsync(CancelResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelResizeResponseUnmarshaller.Instance;

            return InvokeAsync<CancelResizeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyClusterSnapshot

        internal virtual CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterParameterGroup

        internal virtual CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        public virtual Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSecurityGroup

        internal virtual CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        public virtual Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSnapshot

        internal virtual CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSubnetGroup

        internal virtual CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        public virtual Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmClientCertificate

        internal virtual CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateHsmClientCertificateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        public virtual Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmClientCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmConfiguration

        internal virtual CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateHsmConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        public virtual Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotCopyGrant

        internal virtual CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyGrantResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        public virtual Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotCopyGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotSchedule

        internal virtual CreateSnapshotScheduleResponse CreateSnapshotSchedule(CreateSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        public virtual Task<CreateSnapshotScheduleResponse> CreateSnapshotScheduleAsync(CreateSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterParameterGroup

        internal virtual DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup

        internal virtual DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        public virtual Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSnapshot

        internal virtual DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup

        internal virtual DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        public virtual Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmClientCertificate

        internal virtual DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmClientCertificateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        public virtual Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmClientCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmConfiguration

        internal virtual DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        public virtual Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotCopyGrant

        internal virtual DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyGrantResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        public virtual Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotCopyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotCopyGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotSchedule

        internal virtual DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        public virtual Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterDbRevisions

        internal virtual DescribeClusterDbRevisionsResponse DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterDbRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterDbRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        public virtual Task<DescribeClusterDbRevisionsResponse> DescribeClusterDbRevisionsAsync(DescribeClusterDbRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterDbRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterDbRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterDbRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameterGroups

        internal virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }
        internal virtual DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterParameterGroupsAsync(new DescribeClusterParameterGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameters

        internal virtual DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        public virtual Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }
        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClustersAsync(new DescribeClustersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups

        internal virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }
        internal virtual DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        public virtual Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSnapshots

        internal virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }
        internal virtual DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSnapshotsAsync(new DescribeClusterSnapshotsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        public virtual Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups

        internal virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }
        internal virtual DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSubnetGroupsAsync(new DescribeClusterSubnetGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        public virtual Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterTracks

        internal virtual DescribeClusterTracksResponse DescribeClusterTracks(DescribeClusterTracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterTracksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterTracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        public virtual Task<DescribeClusterTracksResponse> DescribeClusterTracksAsync(DescribeClusterTracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterTracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterTracksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterTracksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterVersions

        internal virtual DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }
        internal virtual DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterVersionsAsync(new DescribeClusterVersionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        public virtual Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters

        internal virtual DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultClusterParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        public virtual Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventSubscriptionsAsync(new DescribeEventSubscriptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmClientCertificates

        internal virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }
        internal virtual DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmClientCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmClientCertificatesAsync(new DescribeHsmClientCertificatesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        public virtual Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmClientCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmConfigurations

        internal virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }
        internal virtual DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmConfigurationsAsync(new DescribeHsmConfigurationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        public virtual Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingStatus

        internal virtual DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        public virtual Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions

        internal virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }
        internal virtual DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableClusterOptionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeOrderableClusterOptionsAsync(new DescribeOrderableClusterOptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        public virtual Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableClusterOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableClusterOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings

        internal virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }
        internal virtual DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodeOfferingsAsync(new DescribeReservedNodeOfferingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        public virtual Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodeOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodes

        internal virtual DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }
        internal virtual DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesResponse>(request, options);
        }


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodesAsync(new DescribeReservedNodesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        public virtual Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResize

        internal virtual DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke<DescribeResizeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        public virtual Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResizeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResizeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotCopyGrants

        internal virtual DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotCopyGrantsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        public virtual Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotCopyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotCopyGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotSchedules

        internal virtual DescribeSnapshotSchedulesResponse DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotSchedulesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        public virtual Task<DescribeSnapshotSchedulesResponse> DescribeSnapshotSchedulesAsync(DescribeSnapshotSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotSchedulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorage

        internal virtual DescribeStorageResponse DescribeStorage(DescribeStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        public virtual Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTableRestoreStatus

        internal virtual DescribeTableRestoreStatusResponse DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeTableRestoreStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        public virtual Task<DescribeTableRestoreStatusResponse> DescribeTableRestoreStatusAsync(DescribeTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableRestoreStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTableRestoreStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableLogging

        internal virtual DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke<DisableLoggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        public virtual Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<DisableLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableSnapshotCopy

        internal virtual DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<DisableSnapshotCopyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        public virtual Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSnapshotCopyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableLogging

        internal virtual EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke<EnableLoggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        public virtual Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<EnableLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSnapshotCopy

        internal virtual EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<EnableSnapshotCopyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        public virtual Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSnapshotCopyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSnapshotCopyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetClusterCredentials

        internal virtual GetClusterCredentialsResponse GetClusterCredentials(GetClusterCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetClusterCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        public virtual Task<GetClusterCredentialsResponse> GetClusterCredentialsAsync(GetClusterCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetClusterCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservedNodeExchangeOfferings

        internal virtual GetReservedNodeExchangeOfferingsResponse GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return Invoke<GetReservedNodeExchangeOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedNodeExchangeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        public virtual Task<GetReservedNodeExchangeOfferingsResponse> GetReservedNodeExchangeOfferingsAsync(GetReservedNodeExchangeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedNodeExchangeOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedNodeExchangeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedNodeExchangeOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCluster

        internal virtual ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterDbRevision

        internal virtual ModifyClusterDbRevisionResponse ModifyClusterDbRevision(ModifyClusterDbRevisionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterDbRevisionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterDbRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        public virtual Task<ModifyClusterDbRevisionResponse> ModifyClusterDbRevisionAsync(ModifyClusterDbRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterDbRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterDbRevisionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterDbRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterIamRoles

        internal virtual ModifyClusterIamRolesResponse ModifyClusterIamRoles(ModifyClusterIamRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterIamRolesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterIamRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        public virtual Task<ModifyClusterIamRolesResponse> ModifyClusterIamRolesAsync(ModifyClusterIamRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterIamRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterIamRolesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterIamRolesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterMaintenance

        internal virtual ModifyClusterMaintenanceResponse ModifyClusterMaintenance(ModifyClusterMaintenanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterMaintenanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        public virtual Task<ModifyClusterMaintenanceResponse> ModifyClusterMaintenanceAsync(ModifyClusterMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterMaintenanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterParameterGroup

        internal virtual ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterSnapshot

        internal virtual ModifyClusterSnapshotResponse ModifyClusterSnapshot(ModifyClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        public virtual Task<ModifyClusterSnapshotResponse> ModifyClusterSnapshotAsync(ModifyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterSnapshotSchedule

        internal virtual ModifyClusterSnapshotScheduleResponse ModifyClusterSnapshotSchedule(ModifyClusterSnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        public virtual Task<ModifyClusterSnapshotScheduleResponse> ModifyClusterSnapshotScheduleAsync(ModifyClusterSnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup

        internal virtual ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        public virtual Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod

        internal virtual ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotCopyRetentionPeriodResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        public virtual Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotCopyRetentionPeriodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotCopyRetentionPeriodResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotSchedule

        internal virtual ModifySnapshotScheduleResponse ModifySnapshotSchedule(ModifySnapshotScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotScheduleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        public virtual Task<ModifySnapshotScheduleResponse> ModifySnapshotScheduleAsync(ModifySnapshotScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering

        internal virtual PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodeOfferingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        public virtual Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedNodeOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedNodeOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootCluster

        internal virtual RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke<RebootClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        public virtual Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetClusterParameterGroup

        internal virtual ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        public virtual Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResizeCluster

        internal virtual ResizeClusterResponse ResizeCluster(ResizeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return Invoke<ResizeClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResizeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        public virtual Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResizeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResizeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ResizeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot

        internal virtual RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        public virtual Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreTableFromClusterSnapshot

        internal virtual RestoreTableFromClusterSnapshotResponse RestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        public virtual Task<RestoreTableFromClusterSnapshotResponse> RestoreTableFromClusterSnapshotAsync(RestoreTableFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableFromClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableFromClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress

        internal virtual RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClusterSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClusterSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClusterSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSnapshotAccess

        internal virtual RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeSnapshotAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        public virtual Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSnapshotAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSnapshotAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RotateEncryptionKey

        internal virtual RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<RotateEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        public virtual Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return InvokeAsync<RotateEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
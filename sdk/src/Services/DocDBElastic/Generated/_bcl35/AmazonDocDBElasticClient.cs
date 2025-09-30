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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DocDBElastic.Model;
using Amazon.DocDBElastic.Model.Internal.MarshallTransformations;
using Amazon.DocDBElastic.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DocDBElastic
{
    /// <summary>
    /// <para>Implementation for accessing DocDBElastic</para>
    ///
    /// Amazon DocumentDB elastic clusters 
    /// <para>
    /// Amazon DocumentDB elastic-clusters support workloads with millions of reads/writes
    /// per second and petabytes of storage capacity. Amazon DocumentDB elastic clusters also
    /// simplify how developers interact with Amazon DocumentDB elastic-clusters by eliminating
    /// the need to choose, manage or upgrade instances.
    /// 
    ///  
    /// <para>
    /// Amazon DocumentDB elastic-clusters were created to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// provide a solution for customers looking for a database that provides virtually limitless
    /// scale with rich query capabilities and MongoDB API compatibility.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// give customers higher connection limits, and to reduce downtime from patching.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// continue investing in a cloud-native, elastic, and class leading architecture for
    /// JSON workloads.
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial class AmazonDocDBElasticClient : AmazonServiceClient, IAmazonDocDBElastic
    {
        private static IServiceMetadata serviceMetadata = new AmazonDocDBElasticMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDocDBElasticPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDocDBElasticPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DocDBElasticPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        public AmazonDocDBElasticClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocDBElasticConfig()) { }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        public AmazonDocDBElasticClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocDBElasticConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(AmazonDocDBElasticConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials)
            : this(credentials, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDocDBElasticConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Credentials and an
        /// AmazonDocDBElasticClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(AWSCredentials credentials, AmazonDocDBElasticConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBElasticConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBElasticClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDocDBElasticConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBElasticConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBElasticConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBElasticClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBElasticClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDocDBElasticClient Configuration Object</param>
        public AmazonDocDBElasticClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDocDBElasticConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDocDBElasticEndpointResolver());
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


        #region  ApplyPendingMaintenanceAction

        /// <summary>
        /// The type of pending maintenance action to be applied to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual IAsyncResult BeginApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyPendingMaintenanceAction.</param>
        /// 
        /// <returns>Returns a  ApplyPendingMaintenanceActionResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse EndApplyPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyClusterSnapshot

        /// <summary>
        /// Copies a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyClusterSnapshot(CopyClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        public virtual CopyClusterSnapshotResponse EndCopyClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCluster

        /// <summary>
        /// Creates a new Amazon DocumentDB elastic cluster and returns its cluster structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateClusterSnapshot

        /// <summary>
        /// Creates a snapshot of an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        public virtual CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Delete an elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClusterSnapshot

        /// <summary>
        /// Delete an elastic cluster snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        public virtual DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCluster

        /// <summary>
        /// Returns information about a specific elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual GetClusterResponse GetCluster(GetClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return Invoke<GetClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual IAsyncResult BeginGetCluster(GetClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCluster.</param>
        /// 
        /// <returns>Returns a  GetClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual GetClusterResponse EndGetCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClusterSnapshot

        /// <summary>
        /// Returns information about a specific elastic cluster snapshot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetClusterSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        public virtual GetClusterSnapshotResponse GetClusterSnapshot(GetClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginGetClusterSnapshot(GetClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  GetClusterSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetClusterSnapshot">REST API Reference for GetClusterSnapshot Operation</seealso>
        public virtual GetClusterSnapshotResponse EndGetClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPendingMaintenanceAction

        /// <summary>
        /// Retrieves all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the GetPendingMaintenanceAction service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetPendingMaintenanceAction">REST API Reference for GetPendingMaintenanceAction Operation</seealso>
        public virtual GetPendingMaintenanceActionResponse GetPendingMaintenanceAction(GetPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<GetPendingMaintenanceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPendingMaintenanceAction operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetPendingMaintenanceAction">REST API Reference for GetPendingMaintenanceAction Operation</seealso>
        public virtual IAsyncResult BeginGetPendingMaintenanceAction(GetPendingMaintenanceActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPendingMaintenanceActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPendingMaintenanceAction.</param>
        /// 
        /// <returns>Returns a  GetPendingMaintenanceActionResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/GetPendingMaintenanceAction">REST API Reference for GetPendingMaintenanceAction Operation</seealso>
        public virtual GetPendingMaintenanceActionResponse EndGetPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB elastic clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusterSnapshots

        /// <summary>
        /// Returns information about snapshots for a specified elastic cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListClusterSnapshots service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        public virtual ListClusterSnapshotsResponse ListClusterSnapshots(ListClusterSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterSnapshots operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginListClusterSnapshots(ListClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  ListClusterSnapshotsResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListClusterSnapshots">REST API Reference for ListClusterSnapshots Operation</seealso>
        public virtual ListClusterSnapshotsResponse EndListClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPendingMaintenanceActions

        /// <summary>
        /// Retrieves a list of all maintenance actions that are pending.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the ListPendingMaintenanceActions service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListPendingMaintenanceActions">REST API Reference for ListPendingMaintenanceActions Operation</seealso>
        public virtual ListPendingMaintenanceActionsResponse ListPendingMaintenanceActions(ListPendingMaintenanceActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<ListPendingMaintenanceActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMaintenanceActions operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPendingMaintenanceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListPendingMaintenanceActions">REST API Reference for ListPendingMaintenanceActions Operation</seealso>
        public virtual IAsyncResult BeginListPendingMaintenanceActions(ListPendingMaintenanceActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPendingMaintenanceActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPendingMaintenanceActions.</param>
        /// 
        /// <returns>Returns a  ListPendingMaintenanceActionsResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListPendingMaintenanceActions">REST API Reference for ListPendingMaintenanceActions Operation</seealso>
        public virtual ListPendingMaintenanceActionsResponse EndListPendingMaintenanceActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPendingMaintenanceActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on a elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreClusterFromSnapshot

        /// <summary>
        /// Restores an elastic cluster from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreClusterFromSnapshot service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ServiceQuotaExceededException">
        /// The service quota for the action was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        public virtual RestoreClusterFromSnapshotResponse RestoreClusterFromSnapshot(RestoreClusterFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreClusterFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreClusterFromSnapshot operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreClusterFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreClusterFromSnapshot(RestoreClusterFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreClusterFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreClusterFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreClusterFromSnapshotResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/RestoreClusterFromSnapshot">REST API Reference for RestoreClusterFromSnapshot Operation</seealso>
        public virtual RestoreClusterFromSnapshotResponse EndRestoreClusterFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreClusterFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCluster

        /// <summary>
        /// Restarts the stopped elastic cluster that is specified by <c>clusterARN</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCluster service method.</param>
        /// 
        /// <returns>The response from the StartCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StartCluster">REST API Reference for StartCluster Operation</seealso>
        public virtual StartClusterResponse StartCluster(StartClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClusterResponseUnmarshaller.Instance;

            return Invoke<StartClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StartCluster">REST API Reference for StartCluster Operation</seealso>
        public virtual IAsyncResult BeginStartCluster(StartClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCluster.</param>
        /// 
        /// <returns>Returns a  StartClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StartCluster">REST API Reference for StartCluster Operation</seealso>
        public virtual StartClusterResponse EndStartCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StartClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCluster

        /// <summary>
        /// Stops the running elastic cluster that is specified by <c>clusterArn</c>. The elastic
        /// cluster must be in the <i>available</i> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCluster service method.</param>
        /// 
        /// <returns>The response from the StopCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StopCluster">REST API Reference for StopCluster Operation</seealso>
        public virtual StopClusterResponse StopCluster(StopClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClusterResponseUnmarshaller.Instance;

            return Invoke<StopClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StopCluster">REST API Reference for StopCluster Operation</seealso>
        public virtual IAsyncResult BeginStopCluster(StopClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCluster.</param>
        /// 
        /// <returns>Returns a  StopClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/StopCluster">REST API Reference for StopCluster Operation</seealso>
        public virtual StopClusterResponse EndStopCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StopClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds metadata tags to an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes metadata tags from an elastic cluster resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCluster

        /// <summary>
        /// Modifies an elastic cluster. This includes updating admin-username/password, upgrading
        /// the API version, and setting up a backup window and maintenance window
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DocDBElastic.</returns>
        /// <exception cref="Amazon.DocDBElastic.Model.AccessDeniedException">
        /// An exception that occurs when there are not sufficient permissions to perform an action.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ConflictException">
        /// There was an access conflict.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.InternalServerException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ResourceNotFoundException">
        /// The specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ThrottlingException">
        /// ThrottlingException will be thrown when request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DocDBElastic.Model.ValidationException">
        /// A structure defining a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonDocDBElasticClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from DocDBElastic.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-elastic-2022-11-28/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClusterResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonDocDBElasticEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
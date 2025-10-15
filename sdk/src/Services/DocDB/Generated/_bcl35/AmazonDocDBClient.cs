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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DocDB.Model;
using Amazon.DocDB.Model.Internal.MarshallTransformations;
using Amazon.DocDB.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DocDB
{
    /// <summary>
    /// <para>Implementation for accessing DocDB</para>
    ///
    /// Amazon DocumentDB is a fast, reliable, and fully managed database service. Amazon
    /// DocumentDB makes it easy to set up, operate, and scale MongoDB-compatible databases
    /// in the cloud. With Amazon DocumentDB, you can run the same application code and use
    /// the same drivers and tools that you use with MongoDB.
    /// </summary>
    public partial class AmazonDocDBClient : AmazonServiceClient, IAmazonDocDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonDocDBMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDocDBPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDocDBPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DocDBPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDocDBClient with the credentials loaded from the application's
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
        public AmazonDocDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocDBConfig()) { }

        /// <summary>
        /// Constructs AmazonDocDBClient with the credentials loaded from the application's
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
        public AmazonDocDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDocDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDocDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDocDBClient Configuration Object</param>
        public AmazonDocDBClient(AmazonDocDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDocDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonDocDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDocDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Credentials and an
        /// AmazonDocDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDocDBClient Configuration Object</param>
        public AmazonDocDBClient(AWSCredentials credentials, AmazonDocDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDocDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDocDBClient Configuration Object</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDocDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDocDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDocDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDocDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDocDBClient Configuration Object</param>
        public AmazonDocDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDocDBConfig clientConfig)
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
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.DocDB.Internal.PreSignedUrlRequestHandler(this.Credentials));
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDocDBEndpointResolver());
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


        #region  AddSourceIdentifierToSubscription

        /// <summary>
        /// Adds a source identifier to an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddSourceIdentifierToSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual IAsyncResult BeginAddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddSourceIdentifierToSubscription.</param>
        /// 
        /// <returns>Returns a  AddSourceIdentifierToSubscriptionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse EndAddSourceIdentifierToSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<AddSourceIdentifierToSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds metadata tags to an Amazon DocumentDB resource. You can use these tags with cost
        /// allocation reporting to track costs that are associated with Amazon DocumentDB resources
        /// or in a <c>Condition</c> statement in an Identity and Access Management (IAM) policy
        /// for Amazon DocumentDB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction

        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to an Amazon DocumentDB
        /// instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
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
        /// <returns>Returns a  ApplyPendingMaintenanceActionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse EndApplyPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup

        /// <summary>
        /// Copies the specified cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupAlreadyExistsException">
        /// A parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupQuotaExceededException">
        /// This request would cause you to exceed the allowed number of parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CopyDBClusterParameterGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse EndCopyDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBClusterSnapshot

        /// <summary>
        /// Copies a snapshot of a cluster.
        /// 
        ///  
        /// <para>
        /// To copy a cluster snapshot from a shared manual cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
        /// must be the Amazon Resource Name (ARN) of the shared cluster snapshot. You can only
        /// copy a shared DB cluster snapshot, whether encrypted or not, in the same Amazon Web
        /// Services Region.
        /// </para>
        ///  
        /// <para>
        /// To cancel the copy operation after it is in progress, delete the target cluster snapshot
        /// identified by <c>TargetDBClusterSnapshotIdentifier</c> while that cluster snapshot
        /// is in the <i>copying</i> status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyDBClusterSnapshotResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual CopyDBClusterSnapshotResponse EndCopyDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBCluster

        /// <summary>
        /// Creates a new Amazon DocumentDB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.NetworkTypeNotSupportedException">
        /// The network type is not supported by either <c>DBSubnetGroup</c> or the DB engine
        /// version.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateDBCluster(CreateDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBCluster.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse EndCreateDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterParameterGroup

        /// <summary>
        /// Creates a new cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a cluster parameter group apply to all of the instances in a cluster.
        /// </para>
        ///  
        /// <para>
        /// A cluster parameter group is initially created with the default parameters for the
        /// database engine used by instances in the cluster. In Amazon DocumentDB, you cannot
        /// make modifications directly to the <c>default.docdb3.6</c> cluster parameter group.
        /// If your Amazon DocumentDB cluster is using the default cluster parameter group and
        /// you want to modify a value in it, you must first <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-create.html">
        /// create a new parameter group</a> or <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-copy.html">
        /// copy an existing parameter group</a>, modify it, and then apply the modified parameter
        /// group to your cluster. For the new cluster parameter group and associated settings
        /// to take effect, you must then reboot the instances in the cluster without failover.
        /// For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/cluster_parameter_group-modify.html">
        /// Modifying Amazon DocumentDB Cluster Parameter Groups</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupAlreadyExistsException">
        /// A parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupQuotaExceededException">
        /// This request would cause you to exceed the allowed number of parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterParameterGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse EndCreateDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot

        /// <summary>
        /// Creates a snapshot of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterSnapshotResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual CreateDBClusterSnapshotResponse EndCreateDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBInstance

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP or Amazon EC2 security group isn't authorized for the specified
        /// security group.
        /// 
        ///  
        /// <para>
        /// Amazon DocumentDB also might not be authorized to perform necessary actions on your
        /// behalf using IAM.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceAlreadyExistsException">
        /// You already have a instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing security group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InstanceQuotaExceededException">
        /// The request would cause you to exceed the allowed number of instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBInstanceCapacityException">
        /// The specified instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageTypeNotSupportedException">
        /// Storage of the specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateDBInstance(CreateDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstance.</param>
        /// 
        /// <returns>Returns a  CreateDBInstanceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse EndCreateDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        /// <summary>
        /// Creates a new subnet group. subnet groups must contain at least one subnet in at least
        /// two Availability Zones in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupAlreadyExistsException">
        /// <c>DBSubnetGroupName</c> is already being used by an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnet groups.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnets in a subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBSubnetGroup(CreateDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBSubnetGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse EndCreateDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an Amazon DocumentDB event notification subscription. This action requires
        /// a topic Amazon Resource Name (ARN) created by using the Amazon DocumentDB console,
        /// the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon SNS, you
        /// must create a topic in Amazon SNS and subscribe to the topic. The ARN is displayed
        /// in the Amazon SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
        /// of. You can also provide a list of Amazon DocumentDB sources (<c>SourceIds</c>) that
        /// trigger the events, and you can provide a list of event categories (<c>EventCategories</c>)
        /// for events that you want to be notified of. For example, you can specify <c>SourceType
        /// = db-instance</c>, <c>SourceIds = mydbinstance1, mydbinstance2</c> and <c>EventCategories
        /// = Availability, Backup</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <c>SourceType</c> and <c>SourceIds</c> (such as <c>SourceType
        /// = db-instance</c> and <c>SourceIdentifier = myDBInstance1</c>), you are notified of
        /// all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
        /// but do not specify a <c>SourceIdentifier</c>, you receive notice of the events for
        /// that source type for all your Amazon DocumentDB sources. If you do not specify either
        /// the <c>SourceType</c> or the <c>SourceIdentifier</c>, you are notified of events generated
        /// from all Amazon DocumentDB sources belonging to your customer account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified topic.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSTopicArnNotFoundException">
        /// The SNS topic Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionAlreadyExistException">
        /// The provided subscription name already exists.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionCategoryNotFoundException">
        /// The provided category does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlobalCluster

        /// <summary>
        /// Creates an Amazon DocumentDB global cluster that can span multiple multiple Amazon
        /// Web Services Regions. The global cluster contains one primary cluster with read-write
        /// capability, and up-to 10 read-only secondary clusters. Global clusters uses storage-based
        /// fast replication across regions with latencies less than one second, using dedicated
        /// infrastructure with no impact to your workload’s performance.
        /// 
        ///   
        /// <para>
        /// You can create a global cluster that is initially empty, and then add a primary and
        /// a secondary to it. Or you can specify an existing cluster during the create operation,
        /// and this cluster becomes the primary of the global cluster. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Choose a new global cluster identifier
        /// (unique name) to create a new global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterQuotaExceededException">
        /// The number of global clusters for this account is already at the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual CreateGlobalClusterResponse CreateGlobalCluster(CreateGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateGlobalCluster(CreateGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlobalCluster.</param>
        /// 
        /// <returns>Returns a  CreateGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual CreateGlobalClusterResponse EndCreateGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBCluster

        /// <summary>
        /// Deletes a previously provisioned cluster. When you delete a cluster, all automated
        /// backups for that cluster are deleted and can't be recovered. Manual DB cluster snapshots
        /// of the specified cluster are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotAlreadyExistsException">
        /// You already have a cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBCluster(DeleteDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBCluster.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse EndDeleteDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup

        /// <summary>
        /// Deletes a specified cluster parameter group. The cluster parameter group to be deleted
        /// can't be associated with any clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterParameterGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse EndDeleteDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterSnapshot

        /// <summary>
        /// Deletes a cluster snapshot. If the snapshot is being copied, the copy operation is
        /// terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The cluster snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterSnapshotResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse EndDeleteDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBInstance

        /// <summary>
        /// Deletes a previously provisioned instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already being used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SnapshotQuotaExceededException">
        /// The request would cause you to exceed the allowed number of snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBInstance(DeleteDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBInstance.</param>
        /// 
        /// <returns>Returns a  DeleteDBInstanceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse EndDeleteDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        /// <summary>
        /// Deletes a subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetStateException">
        /// The subnet isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBSubnetGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse EndDeleteDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an Amazon DocumentDB event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.InvalidEventSubscriptionStateException">
        /// Someone else might be modifying a subscription. Wait a few seconds, and try again.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlobalCluster

        /// <summary>
        /// Deletes a global cluster. The primary and secondary clusters must already be detached
        /// or deleted before attempting to delete a global cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual DeleteGlobalClusterResponse DeleteGlobalCluster(DeleteGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlobalCluster(DeleteGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlobalCluster.</param>
        /// 
        /// <returns>Returns a  DeleteGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual DeleteGlobalClusterResponse EndDeleteGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificates

        /// <summary>
        /// Returns a list of certificate authority (CA) certificates provided by Amazon DocumentDB
        /// for this Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificates(DescribeCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeCertificatesResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse EndDescribeCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups

        /// <summary>
        /// Returns a list of <c>DBClusterParameterGroup</c> descriptions. If a <c>DBClusterParameterGroupName</c>
        /// parameter is specified, the list contains only the description of the specified cluster
        /// parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterParameterGroupsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse EndDescribeDBClusterParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameters

        /// <summary>
        /// Returns the detailed parameter list for a particular cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameters(DescribeDBClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterParametersResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse EndDescribeDBClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusters

        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB clusters. This API operation
        /// supports pagination. For certain management features such as cluster and instance
        /// lifecycle management, Amazon DocumentDB leverages operational technology that is shared
        /// with Amazon RDS and Amazon Neptune. Use the <c>filterName=engine,Values=docdb</c>
        /// filter parameter to return only Amazon DocumentDB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusters(DescribeDBClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusters.</param>
        /// 
        /// <returns>Returns a  DescribeDBClustersResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse EndDescribeDBClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes

        /// <summary>
        /// Returns a list of cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When you share snapshots with other Amazon Web Services accounts, <c>DescribeDBClusterSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual cluster snapshot. If <c>all</c>
        /// is included in the list of values for the <c>restore</c> attribute, then the manual
        /// cluster snapshot is public and can be copied or restored by all Amazon Web Services
        /// accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshotAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterSnapshotAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterSnapshotAttributesResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse EndDescribeDBClusterSnapshotAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots

        /// <summary>
        /// Returns information about cluster snapshots. This API operation supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterSnapshotsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse EndDescribeDBClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        /// <summary>
        /// Returns a list of the available engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBEngineVersions(DescribeDBEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeDBEngineVersionsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse EndDescribeDBEngineVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBEngineVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBInstances

        /// <summary>
        /// Returns information about provisioned Amazon DocumentDB instances. This API supports
        /// pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBInstances(DescribeDBInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBInstances.</param>
        /// 
        /// <returns>Returns a  DescribeDBInstancesResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse EndDescribeDBInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        /// <summary>
        /// Returns a list of <c>DBSubnetGroup</c> descriptions. If a <c>DBSubnetGroupName</c>
        /// is specified, the list will contain only the descriptions of the specified <c>DBSubnetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBSubnetGroupsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse EndDescribeDBSubnetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBSubnetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters

        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultClusterParametersResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse EndDescribeEngineDefaultClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngineDefaultClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to instances, security groups, snapshots, and DB parameter
        /// groups for the past 14 days. You can obtain events specific to a particular DB instance,
        /// security group, snapshot, or parameter group by providing the name as a parameter.
        /// By default, the events of the past hour are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGlobalClusters

        /// <summary>
        /// Returns information about Amazon DocumentDB global clusters. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual DescribeGlobalClustersResponse DescribeGlobalClusters(DescribeGlobalClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGlobalClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGlobalClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeGlobalClusters(DescribeGlobalClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGlobalClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGlobalClusters.</param>
        /// 
        /// <returns>Returns a  DescribeGlobalClustersResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual DescribeGlobalClustersResponse EndDescribeGlobalClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGlobalClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        /// <summary>
        /// Returns a list of orderable instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableDBInstanceOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableDBInstanceOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableDBInstanceOptionsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse EndDescribeOrderableDBInstanceOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrderableDBInstanceOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions

        /// <summary>
        /// Returns a list of resources (for example, instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePendingMaintenanceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual IAsyncResult BeginDescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePendingMaintenanceActions.</param>
        /// 
        /// <returns>Returns a  DescribePendingMaintenanceActionsResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse EndDescribePendingMaintenanceActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePendingMaintenanceActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  FailoverDBCluster

        /// <summary>
        /// Forces a failover for a cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a cluster promotes one of the Amazon DocumentDB replicas (read-only
        /// instances) in the cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// If the primary instance fails, Amazon DocumentDB automatically fails over to an Amazon
        /// DocumentDB replica, if one exists. You can force a failover when you want to simulate
        /// a failure of a primary instance for testing.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFailoverDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual IAsyncResult BeginFailoverDBCluster(FailoverDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFailoverDBCluster.</param>
        /// 
        /// <returns>Returns a  FailoverDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse EndFailoverDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<FailoverDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  FailoverGlobalCluster

        /// <summary>
        /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
        /// cluster when failing over a global cluster occurs.
        /// 
        ///  
        /// <para>
        /// Use this operation to respond to an unplanned event, such as a regional disaster in
        /// the primary region. Failing over can result in a loss of write transaction data that
        /// wasn't replicated to the chosen secondary before the failover event occurred. However,
        /// the recovery process that promotes a DB instance on the chosen seconday DB cluster
        /// to be the primary writer DB instance guarantees that the data is in a transactionally
        /// consistent state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual FailoverGlobalClusterResponse FailoverGlobalCluster(FailoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FailoverGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFailoverGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginFailoverGlobalCluster(FailoverGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FailoverGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFailoverGlobalCluster.</param>
        /// 
        /// <returns>Returns a  FailoverGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual FailoverGlobalClusterResponse EndFailoverGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<FailoverGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an Amazon DocumentDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBCluster

        /// <summary>
        /// Modifies a setting for an Amazon DocumentDB cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSecurityGroupStateException">
        /// The state of the security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSubnetGroupStateException">
        /// The subnet group can't be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.NetworkTypeNotSupportedException">
        /// The network type is not supported by either <c>DBSubnetGroup</c> or the DB engine
        /// version.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyDBCluster(ModifyDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBCluster.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse EndModifyDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a cluster parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request. 
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot or maintenance window before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you create a cluster parameter group, you should wait at least 5 minutes before
        /// creating your first cluster that uses that cluster parameter group as the default
        /// parameter group. This allows Amazon DocumentDB to fully complete the create action
        /// before the parameter group is used as the default for a new cluster. This step is
        /// especially important for parameters that are critical when creating the default database
        /// for a cluster, such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterParameterGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse EndModifyDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute

        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual cluster snapshot with other Amazon Web Services accounts, specify
        /// <c>restore</c> as the <c>AttributeName</c>, and use the <c>ValuesToAdd</c> parameter
        /// to add a list of IDs of the Amazon Web Services accounts that are authorized to restore
        /// the manual cluster snapshot. Use the value <c>all</c> to make the manual cluster snapshot
        /// public, which means that it can be copied or restored by all Amazon Web Services accounts.
        /// Do not add the <c>all</c> value for any manual cluster snapshots that contain private
        /// information that you don't want available to all Amazon Web Services accounts. If
        /// a manual cluster snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBClusterSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterSnapshotAttributeResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse EndModifyDBClusterSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBInstance

        /// <summary>
        /// Modifies settings for an instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP or Amazon EC2 security group isn't authorized for the specified
        /// security group.
        /// 
        ///  
        /// <para>
        /// Amazon DocumentDB also might not be authorized to perform necessary actions on your
        /// behalf using IAM.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceAlreadyExistsException">
        /// You already have a instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing security group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBUpgradeDependencyFailureException">
        /// The upgrade failed because a resource that the depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBInstanceCapacityException">
        /// The specified instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSecurityGroupStateException">
        /// The state of the security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageTypeNotSupportedException">
        /// Storage of the specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual IAsyncResult BeginModifyDBInstance(ModifyDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBInstance.</param>
        /// 
        /// <returns>Returns a  ModifyDBInstanceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse EndModifyDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        /// <summary>
        /// Modifies an existing subnet group. subnet groups must contain at least one subnet
        /// in at least two Availability Zones in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the subnet group should cover at least two Availability Zones unless there
        /// is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetQuotaExceededException">
        /// The request would cause you to exceed the allowed number of subnets in a subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubnetAlreadyInUseException">
        /// The subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBSubnetGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse EndModifyDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing Amazon DocumentDB event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified topic.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic Amazon Resource Name (ARN).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SNSTopicArnNotFoundException">
        /// The SNS topic Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionCategoryNotFoundException">
        /// The provided category does not exist.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyGlobalCluster

        /// <summary>
        /// Modify a setting for an Amazon DocumentDB global cluster. You can change one or more
        /// configuration parameters (for example: deletion protection), or the global cluster
        /// identifier by specifying these parameters and the new values in the request.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual ModifyGlobalClusterResponse ModifyGlobalCluster(ModifyGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyGlobalCluster(ModifyGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyGlobalCluster.</param>
        /// 
        /// <returns>Returns a  ModifyGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual ModifyGlobalClusterResponse EndModifyGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootDBInstance

        /// <summary>
        /// You might need to reboot your instance, usually for maintenance reasons. For example,
        /// if you make certain changes, or if you change the cluster parameter group that is
        /// associated with the instance, you must reboot the instance for the changes to take
        /// effect. 
        /// 
        ///  
        /// <para>
        /// Rebooting an instance restarts the database engine service. Rebooting an instance
        /// results in a momentary outage, during which the instance status is set to <i>rebooting</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual IAsyncResult BeginRebootDBInstance(RebootDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDBInstance.</param>
        /// 
        /// <returns>Returns a  RebootDBInstanceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse EndRebootDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFromGlobalCluster

        /// <summary>
        /// Detaches an Amazon DocumentDB secondary cluster from a global cluster. The cluster
        /// becomes a standalone cluster with read-write capability instead of being read-only
        /// and receiving data from a primary in a different region. 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Amazon DocumentDB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual RemoveFromGlobalClusterResponse RemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveFromGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFromGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFromGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginRemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveFromGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveFromGlobalCluster.</param>
        /// 
        /// <returns>Returns a  RemoveFromGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual RemoveFromGlobalClusterResponse EndRemoveFromGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFromGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        /// <summary>
        /// Removes a source identifier from an existing Amazon DocumentDB event notification
        /// subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSourceIdentifierFromSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual IAsyncResult BeginRemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSourceIdentifierFromSubscription.</param>
        /// 
        /// <returns>Returns a  RemoveSourceIdentifierFromSubscriptionResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse EndRemoveSourceIdentifierFromSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveSourceIdentifierFromSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes metadata tags from an Amazon DocumentDB resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetDBClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a cluster parameter group to the default value. To reset
        /// specific parameters, submit a list of the following: <c>ParameterName</c> and <c>ApplyMethod</c>.
        /// To reset the entire cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
        /// and <c>ResetAllParameters</c> parameters. 
        /// 
        ///  
        /// <para>
        ///  When you reset the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
        /// reboot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBParameterGroupStateException">
        /// The parameter group is in use, or it is in a state that is not valid. If you are trying
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetDBClusterParameterGroupResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse EndResetDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        /// <summary>
        /// Creates a new cluster from a snapshot or cluster snapshot.
        /// 
        ///  
        /// <para>
        /// If a snapshot is specified, the target cluster is created from the source DB snapshot
        /// with a default configuration and default security group.
        /// </para>
        ///  
        /// <para>
        /// If a cluster snapshot is specified, the target cluster is created from the source
        /// cluster restore point with the same configuration as the original source DB cluster,
        /// except that the new cluster is created with the default security group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBClusterCapacityException">
        /// The cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSnapshotStateException">
        /// The state of the snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidRestoreException">
        /// You cannot restore from a virtual private cloud (VPC) backup to a non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.NetworkTypeNotSupportedException">
        /// The network type is not supported by either <c>DBSubnetGroup</c> or the DB engine
        /// version.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBClusterFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreDBClusterFromSnapshotResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse EndRestoreDBClusterFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterToPointInTime

        /// <summary>
        /// Restores a cluster to an arbitrary point in time. Users can restore to any point in
        /// time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c> days.
        /// The target cluster is created from the source cluster with the same configuration
        /// as the original cluster, except that the new cluster is created with the default security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterAlreadyExistsException">
        /// You already have a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterQuotaExceededException">
        /// The cluster can't be created because you have reached the maximum allowed quota of
        /// clusters.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientDBClusterCapacityException">
        /// The cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InsufficientStorageClusterCapacityException">
        /// There is not enough storage available for the current action. You might be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterSnapshotStateException">
        /// The provided value isn't a valid cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBSnapshotStateException">
        /// The state of the snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidRestoreException">
        /// You cannot restore from a virtual private cloud (VPC) backup to a non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or multiple subnets were requested that are not
        /// all in a common virtual private cloud (VPC).
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidVPCNetworkStateException">
        /// The subnet group doesn't cover all Availability Zones after it is created because
        /// of changes that were made.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.KMSKeyNotAccessibleException">
        /// An error occurred when accessing an KMS key.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.NetworkTypeNotSupportedException">
        /// The network type is not supported by either <c>DBSubnetGroup</c> or the DB engine
        /// version.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.StorageQuotaExceededException">
        /// The request would cause you to exceed the allowed amount of storage available across
        /// all instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterToPointInTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBClusterToPointInTime.</param>
        /// 
        /// <returns>Returns a  RestoreDBClusterToPointInTimeResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse EndRestoreDBClusterToPointInTime(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterToPointInTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDBCluster

        /// <summary>
        /// Restarts the stopped cluster that is specified by <c>DBClusterIdentifier</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/db-cluster-stop-start.html">Stopping
        /// and Starting an Amazon DocumentDB Cluster</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual StartDBClusterResponse StartDBCluster(StartDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return Invoke<StartDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual IAsyncResult BeginStartDBCluster(StartDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDBCluster.</param>
        /// 
        /// <returns>Returns a  StartDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual StartDBClusterResponse EndStartDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDBCluster

        /// <summary>
        /// Stops the running cluster that is specified by <c>DBClusterIdentifier</c>. The cluster
        /// must be in the <i>available</i> state. For more information, see <a href="https://docs.aws.amazon.com/documentdb/latest/developerguide/db-cluster-stop-start.html">Stopping
        /// and Starting an Amazon DocumentDB Cluster</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBInstanceStateException">
        /// The specified instance isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual StopDBClusterResponse StopDBCluster(StopDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return Invoke<StopDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual IAsyncResult BeginStopDBCluster(StopDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDBCluster.</param>
        /// 
        /// <returns>Returns a  StopDBClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual StopDBClusterResponse EndStopDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  SwitchoverGlobalCluster

        /// <summary>
        /// Switches over the specified secondary Amazon DocumentDB cluster to be the new primary
        /// Amazon DocumentDB cluster in the global database cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the SwitchoverGlobalCluster service method, as returned by DocDB.</returns>
        /// <exception cref="Amazon.DocDB.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global cluster.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidDBClusterStateException">
        /// The cluster isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.DocDB.Model.InvalidGlobalClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual SwitchoverGlobalClusterResponse SwitchoverGlobalCluster(SwitchoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<SwitchoverGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SwitchoverGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster operation on AmazonDocDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSwitchoverGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginSwitchoverGlobalCluster(SwitchoverGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SwitchoverGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSwitchoverGlobalCluster.</param>
        /// 
        /// <returns>Returns a  SwitchoverGlobalClusterResult from DocDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/docdb-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual SwitchoverGlobalClusterResponse EndSwitchoverGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<SwitchoverGlobalClusterResponse>(asyncResult);
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
            var resolver = new AmazonDocDBEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
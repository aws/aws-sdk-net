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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Neptune.Model;
using Amazon.Neptune.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Neptune
{
    /// <summary>
    /// Implementation for accessing Neptune
    ///
    /// Amazon Neptune 
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    ///  Amazon Neptune is a fast, reliable, fully-managed graph database service that makes
    /// it easy to build and run applications that work with highly connected datasets. The
    /// core of Amazon Neptune is a purpose-built, high-performance graph database engine
    /// optimized for storing billions of relationships and querying the graph with milliseconds
    /// latency. Amazon Neptune supports popular graph models Property Graph and W3C's RDF,
    /// and their respective query languages Apache TinkerPop Gremlin and SPARQL, allowing
    /// you to easily build queries that efficiently navigate highly connected datasets. Neptune
    /// powers graph use cases such as recommendation engines, fraud detection, knowledge
    /// graphs, drug discovery, and network security. 
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon Neptune contains documentation for a programming
    /// or command line interface you can use to manage Amazon Neptune. Note that Amazon Neptune
    /// is asynchronous, which means that some interfaces might require techniques such as
    /// polling or callback functions to determine when a command has been applied. In this
    /// reference, the parameter descriptions indicate whether a command is applied immediately,
    /// on the next instance reboot, or during the maintenance window. The reference structure
    /// is as follows, and we list following some related topics from the user guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon Neptune API Reference</b> 
    /// </para>
    /// </summary>
    public partial class AmazonNeptuneClient : AmazonServiceClient, IAmazonNeptune
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        public AmazonNeptuneClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNeptuneConfig()) { }

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        public AmazonNeptuneClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNeptuneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNeptuneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(AmazonNeptuneConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNeptuneClient(AWSCredentials credentials)
            : this(credentials, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNeptuneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Credentials and an
        /// AmazonNeptuneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(AWSCredentials credentials, AmazonNeptuneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptuneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNeptuneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptuneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptuneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptuneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNeptuneClient Configuration Object</param>
        public AmazonNeptuneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNeptuneConfig clientConfig)
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

        
        #region  AddRoleToDBCluster

        /// <summary>
        /// Associates an Identity and Access Management (IAM) role from an Neptune DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleAlreadyExistsException">
        /// The specified IAM role Amazon Resource Name (ARN) is already associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleQuotaExceededException">
        /// You have exceeded the maximum number of IAM roles that can be associated with the
        /// specified DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request)
        {
            var marshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            var unmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBClusterRequest,AddRoleToDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRoleToDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual IAsyncResult BeginAddRoleToDBCluster(AddRoleToDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            var unmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<AddRoleToDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToDBCluster.</param>
        /// 
        /// <returns>Returns a  AddRoleToDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual AddRoleToDBClusterResponse EndAddRoleToDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<AddRoleToDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  AddSourceIdentifierToSubscription

        /// <summary>
        /// Adds a source identifier to an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var marshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddSourceIdentifierToSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual IAsyncResult BeginAddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<AddSourceIdentifierToSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddSourceIdentifierToSubscription.</param>
        /// 
        /// <returns>Returns a  AddSourceIdentifierToSubscriptionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse EndAddSourceIdentifierToSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<AddSourceIdentifierToSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds metadata tags to an Amazon Neptune resource. These tags can also be used with
        /// cost allocation reporting to track cost associated with Amazon Neptune resources,
        /// or used in a Condition statement in an IAM policy for Amazon Neptune.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction

        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var marshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            var unmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionRequest,ApplyPendingMaintenanceActionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual IAsyncResult BeginApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            var unmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return BeginInvoke<ApplyPendingMaintenanceActionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApplyPendingMaintenanceAction.</param>
        /// 
        /// <returns>Returns a  ApplyPendingMaintenanceActionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse EndApplyPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup

        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var marshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupRequest,CopyDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CopyDBClusterParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CopyDBClusterParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse EndCopyDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBClusterSnapshot

        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <code>SourceDBClusterSnapshotIdentifier</code>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can copy an encrypted DB cluster snapshot from another AWS Region. In that case,
        /// the AWS Region where you call the <code>CopyDBClusterSnapshot</code> action is the
        /// destination AWS Region for the encrypted DB cluster snapshot to be copied to. To copy
        /// an encrypted DB cluster snapshot from another AWS Region, you must provide the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS Key Management System (AWS KMS) key identifier for
        /// the key to use to encrypt the copy of the DB cluster snapshot in the destination AWS
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PreSignedUrl</code> - A URL that contains a Signature Version 4 signed request
        /// for the <code>CopyDBClusterSnapshot</code> action to be called in the source AWS Region
        /// where the DB cluster snapshot is copied from. The pre-signed URL must be a valid request
        /// for the <code>CopyDBClusterSnapshot</code> API action that can be executed in the
        /// source AWS Region that contains the encrypted DB cluster snapshot to be copied.
        /// </para>
        ///  
        /// <para>
        /// The pre-signed URL request must contain the following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
        /// copy of the DB cluster snapshot in the destination AWS Region. This is the same identifier
        /// for both the <code>CopyDBClusterSnapshot</code> action that is called in the destination
        /// AWS Region, and the action contained in the pre-signed URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
        /// will be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
        /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
        /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:neptune-cluster1-snapshot-20161115</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html"> Signature
        /// Version 4 Signing Process</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TargetDBClusterSnapshotIdentifier</code> - The identifier for the new copy
        /// of the DB cluster snapshot in the destination AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// ARN format for the source AWS Region and is the same value as the <code>SourceDBClusterSnapshotIdentifier</code>
        /// in the pre-signed URL. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To cancel the copy operation once it is in progress, delete the target DB cluster
        /// snapshot identified by <code>TargetDBClusterSnapshotIdentifier</code> while that DB
        /// cluster snapshot is in "copying" status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var marshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotRequest,CopyDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CopyDBClusterSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyDBClusterSnapshotResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual CopyDBClusterSnapshotResponse EndCopyDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBParameterGroup

        /// <summary>
        /// Copies the specified DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var marshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyDBParameterGroup(CopyDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CopyDBParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  CopyDBParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual CopyDBParameterGroupResponse EndCopyDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBCluster

        /// <summary>
        /// Creates a new Amazon Neptune DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
        /// cluster as a Read Replica of another DB cluster or Amazon Neptune DB instance. For
        /// cross-region replication where the DB cluster identified by <code>ReplicationSourceIdentifier</code>
        /// is encrypted, you must also specify the <code>PreSignedUrl</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var marshaller = CreateDBClusterRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterRequest,CreateDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateDBCluster(CreateDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBClusterRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBCluster.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse EndCreateDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterParameterGroup

        /// <summary>
        /// Creates a new DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
        /// </para>
        ///  
        /// <para>
        ///  A DB cluster parameter group is initially created with the default parameters for
        /// the database engine used by instances in the DB cluster. To provide custom values
        /// for any of the parameters, you must modify the group after creating it using <a>ModifyDBClusterParameterGroup</a>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <a>ModifyDBCluster</a>. When you associate a new DB cluster parameter
        /// group with a running DB cluster, you need to reboot the DB instances in the DB cluster
        /// without failover for the new DB cluster parameter group and associated settings to
        /// take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune
        /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
        /// DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var marshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupRequest,CreateDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBClusterParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse EndCreateDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot

        /// <summary>
        /// Creates a snapshot of a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var marshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotRequest,CreateDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBClusterSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterSnapshotResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual CreateDBClusterSnapshotResponse EndCreateDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBInstance

        /// <summary>
        /// Creates a new DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InstanceQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var marshaller = CreateDBInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateDBInstance(CreateDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstance.</param>
        /// 
        /// <returns>Returns a  CreateDBInstanceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse EndCreateDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBParameterGroup

        /// <summary>
        /// Creates a new DB parameter group.
        /// 
        ///  
        /// <para>
        ///  A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <i>ModifyDBParameterGroup</i>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <i>ModifyDBInstance</i>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon Neptune to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the Amazon Neptune console
        /// or the <i>DescribeDBParameters</i> command to verify that your DB parameter group
        /// has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB parameter groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var marshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBParameterGroup(CreateDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual CreateDBParameterGroupResponse EndCreateDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupAlreadyExistsException">
        /// <i>DBSubnetGroupName</i> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var marshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBSubnetGroup(CreateDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDBSubnetGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBSubnetGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse EndCreateDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an event notification subscription. This action requires a topic ARN (Amazon
        /// Resource Name) created by either the Neptune console, the SNS console, or the SNS
        /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
        /// to the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (SourceType) you want to be notified of, provide
        /// a list of Neptune sources (SourceIds) that triggers the events, and provide a list
        /// of event categories (EventCategories) for events you want to be notified of. For example,
        /// you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2
        /// and EventCategories = Availability, Backup.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the SourceType and SourceIds, such as SourceType = db-instance
        /// and SourceIdentifier = myDBInstance1, you are notified of all the db-instance events
        /// for the specified source. If you specify a SourceType but do not specify a SourceIdentifier,
        /// you receive notice of the events for that source type for all your Neptune sources.
        /// If you do not specify either the SourceType nor the SourceIdentifier, you are notified
        /// of events generated from all Neptune sources belonging to your customer account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionAlreadyExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateEventSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBCluster

        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotAlreadyExistsException">
        /// User already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var marshaller = DeleteDBClusterRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterRequest,DeleteDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBCluster(DeleteDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBClusterRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBCluster.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse EndDeleteDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup

        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted can't be associated with any DB clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var marshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupRequest,DeleteDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBClusterParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse EndDeleteDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterSnapshot

        /// <summary>
        /// Deletes a DB cluster snapshot. If the snapshot is being copied, the copy operation
        /// is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB cluster snapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var marshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotRequest,DeleteDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBClusterSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterSnapshotResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse EndDeleteDBClusterSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBInstance

        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
        /// delete a DB instance, all automated backups for that instance are deleted and can't
        /// be recovered. Manual DB snapshots of the DB instance to be deleted by <code>DeleteDBInstance</code>
        /// are not deleted.
        /// 
        ///  
        /// <para>
        ///  If you request a final DB snapshot the status of the Amazon Neptune DB instance is
        /// <code>deleting</code> until the DB snapshot is created. The API action <code>DescribeDBInstance</code>
        /// is used to monitor the status of this operation. The action can't be canceled or reverted
        /// once submitted. 
        /// </para>
        ///  
        /// <para>
        /// Note that when a DB instance is in a failure state and has a status of <code>failed</code>,
        /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
        /// delete it when the <code>SkipFinalSnapshot</code> parameter is set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If the specified DB instance is part of a DB cluster, you can't delete the DB instance
        /// if both of the following conditions are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB cluster is a Read Replica of another DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB instance is the only instance in the DB cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a DB instance in this case, first call the <a>PromoteReadReplicaDBCluster</a>
        /// API action to promote the DB cluster so it's no longer a Read Replica. After the promotion
        /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
        /// instance in the DB cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotAlreadyExistsException">
        /// <i>DBSnapshotIdentifier</i> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SnapshotQuotaExceededException">
        /// Request would result in user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var marshaller = DeleteDBInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBInstance(DeleteDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBInstance.</param>
        /// 
        /// <returns>Returns a  DeleteDBInstanceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse EndDeleteDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        /// <summary>
        /// Deletes a specified DBParameterGroup. The DBParameterGroup to be deleted can't be
        /// associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var marshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBParameterGroup(DeleteDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual DeleteDBParameterGroupResponse EndDeleteDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        /// <summary>
        /// Deletes a DB subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetStateException">
        /// The DB subnet is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var marshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDBSubnetGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBSubnetGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse EndDeleteDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.InvalidEventSubscriptionStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEventSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups

        /// <summary>
        /// Returns a list of <code>DBClusterParameterGroup</code> descriptions. If a <code>DBClusterParameterGroupName</code>
        /// parameter is specified, the list will contain only the description of the specified
        /// DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var marshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsRequest,DescribeDBClusterParameterGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBClusterParameterGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterParameterGroupsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse EndDescribeDBClusterParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameters

        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var marshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersRequest,DescribeDBClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameters(DescribeDBClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBClusterParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterParametersResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse EndDescribeDBClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusters

        /// <summary>
        /// Returns information about provisioned DB clusters. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var marshaller = DescribeDBClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersRequest,DescribeDBClustersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusters(DescribeDBClustersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBClustersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusters.</param>
        /// 
        /// <returns>Returns a  DescribeDBClustersResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse EndDescribeDBClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes

        /// <summary>
        /// Returns a list of DB cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other AWS accounts, <code>DescribeDBClusterSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the AWS accounts
        /// that are authorized to copy or restore the manual DB cluster snapshot. If <code>all</code>
        /// is included in the list of values for the <code>restore</code> attribute, then the
        /// manual DB cluster snapshot is public and can be copied or restored by all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an AWS account to copy or restore a manual DB cluster
        /// snapshot, or to make the manual DB cluster snapshot public or private, use the <a>ModifyDBClusterSnapshotAttribute</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var marshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesRequest,DescribeDBClusterSnapshotAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshotAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBClusterSnapshotAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterSnapshotAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterSnapshotAttributesResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse EndDescribeDBClusterSnapshotAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots

        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var marshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsRequest,DescribeDBClusterSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBClusterSnapshotsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterSnapshotsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse EndDescribeDBClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var marshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBEngineVersions(DescribeDBEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBEngineVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeDBEngineVersionsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse EndDescribeDBEngineVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBEngineVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBInstances

        /// <summary>
        /// Returns information about provisioned instances. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var marshaller = DescribeDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBInstances(DescribeDBInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBInstances.</param>
        /// 
        /// <returns>Returns a  DescribeDBInstancesResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse EndDescribeDBInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var marshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBParameterGroups(DescribeDBParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBParameterGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBParameterGroupsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse EndDescribeDBParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBParameters

        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var marshaller = DescribeDBParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBParameters(DescribeDBParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDBParametersResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual DescribeDBParametersResponse EndDescribeDBParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var marshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDBSubnetGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBSubnetGroupsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
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
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var marshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersRequest,DescribeEngineDefaultClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEngineDefaultClusterParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultClusterParametersResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse EndDescribeEngineDefaultClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngineDefaultClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var marshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEngineDefaultParametersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultParametersResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngineDefaultParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventCategoriesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEventSubscriptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var marshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableDBInstanceOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeOrderableDBInstanceOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableDBInstanceOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableDBInstanceOptionsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse EndDescribeOrderableDBInstanceOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrderableDBInstanceOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions

        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var marshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            var unmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsRequest,DescribePendingMaintenanceActionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePendingMaintenanceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual IAsyncResult BeginDescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            var unmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePendingMaintenanceActionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePendingMaintenanceActions.</param>
        /// 
        /// <returns>Returns a  DescribePendingMaintenanceActionsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse EndDescribePendingMaintenanceActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePendingMaintenanceActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeValidDBInstanceModifications

        /// <summary>
        /// You can call <a>DescribeValidDBInstanceModifications</a> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var marshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsRequest,DescribeValidDBInstanceModificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeValidDBInstanceModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual IAsyncResult BeginDescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeValidDBInstanceModificationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeValidDBInstanceModifications.</param>
        /// 
        /// <returns>Returns a  DescribeValidDBInstanceModificationsResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual DescribeValidDBInstanceModificationsResponse EndDescribeValidDBInstanceModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeValidDBInstanceModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  FailoverDBCluster

        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a DB cluster promotes one of the Read Replicas (read-only instances)
        /// in the DB cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// Amazon Neptune will automatically fail over to a Read Replica, if one exists, when
        /// the primary instance fails. You can force a failover when you want to simulate a failure
        /// of a primary instance for testing. Because each instance in a DB cluster has its own
        /// endpoint address, you will need to clean up and re-establish any existing connections
        /// that use those endpoint addresses when the failover is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var marshaller = FailoverDBClusterRequestMarshaller.Instance;
            var unmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterRequest,FailoverDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFailoverDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual IAsyncResult BeginFailoverDBCluster(FailoverDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = FailoverDBClusterRequestMarshaller.Instance;
            var unmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<FailoverDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFailoverDBCluster.</param>
        /// 
        /// <returns>Returns a  FailoverDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse EndFailoverDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<FailoverDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an Amazon Neptune resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBCluster

        /// <summary>
        /// Modify a setting for a DB cluster. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterParameterGroupNotFoundException">
        /// <i>DBClusterParameterGroupName</i> does not refer to an existing DB Cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var marshaller = ModifyDBClusterRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterRequest,ModifyDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyDBCluster(ModifyDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBClusterRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBCluster.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse EndModifyDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one
        /// parameter, submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB cluster associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon Neptune to fully complete the create
        /// action before the parameter group is used as the default for a new DB cluster. This
        /// is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the Amazon Neptune console or the <a>DescribeDBClusterParameters</a>
        /// command to verify that your DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var marshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupRequest,ModifyDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBClusterParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse EndModifyDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute

        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB cluster snapshot with other AWS accounts, specify <code>restore</code>
        /// as the <code>AttributeName</code> and use the <code>ValuesToAdd</code> parameter to
        /// add a list of IDs of the AWS accounts that are authorized to restore the manual DB
        /// cluster snapshot. Use the value <code>all</code> to make the manual DB cluster snapshot
        /// public, which means that it can be copied or restored by all AWS accounts. Do not
        /// add the <code>all</code> value for any manual DB cluster snapshots that contain private
        /// information that you don't want available to all AWS accounts. If a manual DB cluster
        /// snapshot is encrypted, it can be shared, but only by specifying a list of authorized
        /// AWS account IDs for the <code>ValuesToAdd</code> parameter. You can't use <code>all</code>
        /// as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB cluster snapshot,
        /// or whether a manual DB cluster snapshot public or private, use the <a>DescribeDBClusterSnapshotAttributes</a>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var marshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeRequest,ModifyDBClusterSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBClusterSnapshotAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBClusterSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterSnapshotAttributeResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse EndModifyDBClusterSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBInstance

        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <a>DescribeValidDBInstanceModifications</a>
        /// before you call <a>ModifyDBInstance</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.AuthorizationNotFoundException">
        /// Specified CIDRIP or EC2 security group is not authorized for the specified DB security
        /// group.
        /// 
        ///  
        /// <para>
        /// Neptune may not also be authorized via IAM to perform necessary actions on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.CertificateNotFoundException">
        /// <i>CertificateIdentifier</i> does not refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceAlreadyExistsException">
        /// User already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> does not refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on could not be modified.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DomainNotFoundException">
        /// <i>Domain</i> does not refer to an existing Active Directory Domain.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBInstanceCapacityException">
        /// Specified DB instance class is not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageTypeNotSupportedException">
        /// <i>StorageType</i> specified cannot be associated with the DB Instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var marshaller = ModifyDBInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual IAsyncResult BeginModifyDBInstance(ModifyDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBInstance.</param>
        /// 
        /// <returns>Returns a  ModifyDBInstanceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse EndModifyDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  <note> 
        /// <para>
        /// Changes to dynamic parameters are applied immediately. Changes to static parameters
        /// require a reboot without failover to the DB instance associated with the parameter
        /// group before the change can take effect.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon Neptune to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the Amazon Neptune console
        /// or the <i>DescribeDBParameters</i> command to verify that your DB parameter group
        /// has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var marshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBParameterGroup(ModifyDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual ModifyDBParameterGroupResponse EndModifyDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetQuotaExceededException">
        /// Request would result in user exceeding the allowed number of subnets in a DB subnet
        /// groups.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var marshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyDBSubnetGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBSubnetGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse EndModifyDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing event notification subscription. Note that you can't modify the
        /// source identifiers using this call; to change source identifiers for a subscription,
        /// use the <a>AddSourceIdentifierToSubscription</a> and <a>RemoveSourceIdentifierFromSubscription</a>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given SourceType by using the <b>DescribeEventCategories</b>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.EventSubscriptionQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSInvalidTopicException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSNoAuthorizationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SNSTopicArnNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionCategoryNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyEventSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  PromoteReadReplicaDBCluster

        /// <summary>
        /// Promotes a Read Replica DB cluster to a standalone DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var marshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaDBClusterRequest,PromoteReadReplicaDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromoteReadReplicaDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual IAsyncResult BeginPromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<PromoteReadReplicaDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteReadReplicaDBCluster.</param>
        /// 
        /// <returns>Returns a  PromoteReadReplicaDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual PromoteReadReplicaDBClusterResponse EndPromoteReadReplicaDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<PromoteReadReplicaDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootDBInstance

        /// <summary>
        /// You might need to reboot your DB instance, usually for maintenance reasons. For example,
        /// if you make certain modifications, or if you change the DB parameter group associated
        /// with the DB instance, you must reboot the instance for the changes to take effect.
        /// 
        /// 
        ///  
        /// <para>
        /// Rebooting a DB instance restarts the database engine service. Rebooting a DB instance
        /// results in a momentary outage, during which the DB instance status is set to rebooting.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBInstanceStateException">
        /// The specified DB instance is not in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var marshaller = RebootDBInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual IAsyncResult BeginRebootDBInstance(RebootDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RebootDBInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<RebootDBInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDBInstance.</param>
        /// 
        /// <returns>Returns a  RebootDBInstanceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse EndRebootDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveRoleFromDBCluster

        /// <summary>
        /// Disassociates an Identity and Access Management (IAM) role from a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) is not associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var marshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            var unmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBClusterRequest,RemoveRoleFromDBClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRoleFromDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual IAsyncResult BeginRemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            var unmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveRoleFromDBClusterRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromDBCluster.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromDBClusterResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual RemoveRoleFromDBClusterResponse EndRemoveRoleFromDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveRoleFromDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        /// <summary>
        /// Removes a source identifier from an existing event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.SourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.SubscriptionNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var marshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSourceIdentifierFromSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual IAsyncResult BeginRemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveSourceIdentifierFromSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSourceIdentifierFromSubscription.</param>
        /// 
        /// <returns>Returns a  RemoveSourceIdentifierFromSubscriptionResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse EndRemoveSourceIdentifierFromSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveSourceIdentifierFromSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes metadata tags from an Amazon Neptune resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> does not refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetDBClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To
        /// reset specific parameters submit a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB cluster parameter group, specify
        /// the <code>DBClusterParameterGroupName</code> and <code>ResetAllParameters</code> parameters.
        /// 
        /// 
        ///  
        /// <para>
        ///  When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <a>RebootDBInstance</a> request. You must call <a>RebootDBInstance</a>
        /// for every DB instance in your DB cluster that you want the updated static parameter
        /// to apply to.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var marshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupRequest,ResetDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<ResetDBClusterParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetDBClusterParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse EndResetDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetDBParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
        /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBParameterGroupNotFoundException">
        /// <i>DBParameterGroupName</i> does not refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you cannot delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var marshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetDBParameterGroup(ResetDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke<ResetDBParameterGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetDBParameterGroupResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual ResetDBParameterGroupResponse EndResetDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        /// <summary>
        /// Creates a new DB cluster from a DB snapshot or DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// If a DB snapshot is specified, the target DB cluster is created from the source DB
        /// snapshot with a default configuration and default security group.
        /// </para>
        ///  
        /// <para>
        /// If a DB cluster snapshot is specified, the target DB cluster is created from the source
        /// DB cluster restore point with the same configuration as the original source DB cluster,
        /// except that the new DB cluster is created with the default security group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSnapshotNotFoundException">
        /// <i>DBSnapshotIdentifier</i> does not refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var marshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotRequest,RestoreDBClusterFromSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreDBClusterFromSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBClusterFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreDBClusterFromSnapshotResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse EndRestoreDBClusterFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterToPointInTime

        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <code>LatestRestorableTime</code> for up to <code>BackupRetentionPeriod</code>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group. 
        /// 
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <a>CreateDBInstance</a> action to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
        /// action has completed and the DB cluster is available.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by Neptune.</returns>
        /// <exception cref="Amazon.Neptune.Model.DBClusterAlreadyExistsException">
        /// User already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterNotFoundException">
        /// <i>DBClusterIdentifier</i> does not refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterQuotaExceededException">
        /// User attempted to create a new DB cluster and the user has already reached the maximum
        /// allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBClusterSnapshotNotFoundException">
        /// <i>DBClusterSnapshotIdentifier</i> does not refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.DBSubnetGroupNotFoundException">
        /// <i>DBSubnetGroupName</i> does not refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster does not have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You may be able to
        /// resolve this error by updating your subnet group to use different Availability Zones
        /// that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value is not a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBClusterStateException">
        /// The DB cluster is not in a valid state.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot does not allow deletion.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidRestoreException">
        /// Cannot restore from vpc backup to non-vpc DB instance.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.InvalidVPCNetworkStateException">
        /// DB subnet group does not cover all Availability Zones after it is created because
        /// users' change.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.KMSKeyNotAccessibleException">
        /// Error accessing KMS key.
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.OptionGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Neptune.Model.StorageQuotaExceededException">
        /// Request would result in user exceeding the allowed amount of storage available across
        /// all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var marshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeRequest,RestoreDBClusterToPointInTimeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation on AmazonNeptuneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterToPointInTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreDBClusterToPointInTimeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBClusterToPointInTime.</param>
        /// 
        /// <returns>Returns a  RestoreDBClusterToPointInTimeResult from Neptune.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse EndRestoreDBClusterToPointInTime(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterToPointInTimeResponse>(asyncResult);
        }

        #endregion
        
    }
}
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.RDS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing RDS
    ///
    /// Amazon Relational Database Service 
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizeable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique.
    /// </para>
    ///  
    /// <para>
    /// Amazon RDS gives you access to the capabilities of a MySQL, MariaDB, PostgreSQL, Microsoft
    /// SQL Server, Oracle, or Amazon Aurora database server. These capabilities mean that
    /// the code, applications, and tools you already use today with your existing databases
    /// work with Amazon RDS without modification. Amazon RDS automatically backs up your
    /// database and maintains the database software that powers your DB instance. Amazon
    /// RDS is flexible: you can scale your DB instance's compute resources and storage capacity
    /// to meet your application's demand. As with all Amazon Web Services, there are no up-front
    /// investments, and you pay only for the resources you use.
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon RDS contains documentation for a programming or
    /// command line interface you can use to manage Amazon RDS. Amazon RDS is asynchronous,
    /// which means that some interfaces might require techniques such as polling or callback
    /// functions to determine when a command has been applied. In this reference, the parameter
    /// descriptions indicate whether a command is applied immediately, on the next instance
    /// reboot, or during the maintenance window. The reference structure is as follows, and
    /// we list following some related topics from the user guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon RDS API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon RDS User Guide</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a summary of the Amazon RDS interfaces, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about how to use the Query API, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonRDSClient : AmazonServiceClient, IAmazonRDS
    {
        private static IServiceMetadata serviceMetadata = new AmazonRDSMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
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
        public AmazonRDSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig()) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
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
        public AmazonRDSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials and an
        /// AmazonRDSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSConfig clientConfig)
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
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.RDS.Internal.PreSignedUrlRequestHandler(this.Credentials));
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


        #region  AddRoleToDBCluster

        /// <summary>
        /// Associates an Identity and Access Management (IAM) role from an Amazon Aurora DB cluster.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Integrating.Authorizing.html">Authorizing
        /// Amazon Aurora MySQL to Access Other AWS Services on Your Behalf</a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleAlreadyExistsException">
        /// The specified IAM role Amazon Resource Name (ARN) is already associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleQuotaExceededException">
        /// You have exceeded the maximum number of IAM roles that can be associated with the
        /// specified DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRoleToDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual IAsyncResult BeginAddRoleToDBCluster(AddRoleToDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToDBCluster.</param>
        /// 
        /// <returns>Returns a  AddRoleToDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual AddRoleToDBClusterResponse EndAddRoleToDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<AddRoleToDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  AddRoleToDBInstance

        /// <summary>
        /// Associates an AWS Identity and Access Management (IAM) role with a DB instance.
        /// 
        ///  <note> 
        /// <para>
        /// To add a role to a DB instance, the status of the DB instance must be <code>available</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBInstance service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleAlreadyExistsException">
        /// The specified <code>RoleArn</code> or <code>FeatureName</code> value is already associated
        /// with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleQuotaExceededException">
        /// You can't associate any more AWS Identity and Access Management (IAM) roles with the
        /// DB instance because the quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBInstance">REST API Reference for AddRoleToDBInstance Operation</seealso>
        public virtual AddRoleToDBInstanceResponse AddRoleToDBInstance(AddRoleToDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBInstanceResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRoleToDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBInstance">REST API Reference for AddRoleToDBInstance Operation</seealso>
        public virtual IAsyncResult BeginAddRoleToDBInstance(AddRoleToDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToDBInstance.</param>
        /// 
        /// <returns>Returns a  AddRoleToDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBInstance">REST API Reference for AddRoleToDBInstance Operation</seealso>
        public virtual AddRoleToDBInstanceResponse EndAddRoleToDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<AddRoleToDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  AddSourceIdentifierToSubscription

        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddSourceIdentifierToSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual IAsyncResult BeginAddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  AddSourceIdentifierToSubscriptionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse EndAddSourceIdentifierToSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<AddSourceIdentifierToSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddTagsToResource

        /// <summary>
        /// Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost
        /// allocation reporting to track cost associated with Amazon RDS resources, or used in
        /// a Condition statement in an IAM policy for Amazon RDS.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging Amazon RDS resources, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  AddTagsToResourceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
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
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApplyPendingMaintenanceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual IAsyncResult BeginApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ApplyPendingMaintenanceActionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual ApplyPendingMaintenanceActionResponse EndApplyPendingMaintenanceAction(IAsyncResult asyncResult)
        {
            return EndInvoke<ApplyPendingMaintenanceActionResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress

        /// <summary>
        /// Enables ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 or VPC security groups can be added to the DBSecurityGroup if the application
        /// using the database is running on EC2 or VPC instances. Second, IP ranges are available
        /// if the application accessing your database is running on the Internet. Required parameters
        /// for this API are one of CIDR range, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId
        /// and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC).
        /// 
        ///  <note> 
        /// <para>
        /// You can't authorize ingress from an EC2 security group in one AWS Region to an Amazon
        /// RDS DB instance in another. You can't authorize ingress from a VPC security group
        /// in one VPC to an Amazon RDS DB instance in another.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR IP range or Amazon EC2 security group is already authorized for
        /// the specified DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.AuthorizationQuotaExceededException">
        /// The DB security group authorization quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDBSecurityGroupIngressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeDBSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual IAsyncResult BeginAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeDBSecurityGroupIngressResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual AuthorizeDBSecurityGroupIngressResponse EndAuthorizeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeDBSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  BacktrackDBCluster

        /// <summary>
        /// Backtracks a DB cluster to a specific time, without creating a new DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on backtracking, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Managing.Backtrack.html">
        /// Backtracking an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora MySQL DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BacktrackDBCluster service method.</param>
        /// 
        /// <returns>The response from the BacktrackDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual BacktrackDBClusterResponse BacktrackDBCluster(BacktrackDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BacktrackDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return Invoke<BacktrackDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BacktrackDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BacktrackDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBacktrackDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual IAsyncResult BeginBacktrackDBCluster(BacktrackDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BacktrackDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BacktrackDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBacktrackDBCluster.</param>
        /// 
        /// <returns>Returns a  BacktrackDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual BacktrackDBClusterResponse EndBacktrackDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<BacktrackDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelExportTask

        /// <summary>
        /// Cancels an export task in progress that is exporting a snapshot to Amazon S3. Any
        /// data that has already been written to the S3 bucket isn't removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportTaskStateException">
        /// You can't cancel an export task that has completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup

        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CopyDBClusterParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
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
        ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the customer master key (CMK)
        /// to use to encrypt the copy of the DB cluster snapshot in the destination AWS Region.
        /// This is the same identifier for both the <code>CopyDBClusterSnapshot</code> action
        /// that is called in the destination AWS Region, and the action contained in the pre-signed
        /// URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
        /// is to be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
        /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
        /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
        /// is a valid request for the operation that can be executed in the source AWS Region.
        /// </para>
        ///  </note> </li> <li> 
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
        ///  
        /// <para>
        /// For more information on copying encrypted DB cluster snapshots from one AWS Region
        /// to another, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html">
        /// Copying a Snapshot</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CopyDBClusterSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
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
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyDBParameterGroup(CopyDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  CopyDBParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual CopyDBParameterGroupResponse EndCopyDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyDBSnapshot

        /// <summary>
        /// Copies the specified DB snapshot. The source DB snapshot must be in the <code>available</code>
        /// state.
        /// 
        ///  
        /// <para>
        /// You can copy a snapshot from one AWS Region to another. In that case, the AWS Region
        /// where you call the <code>CopyDBSnapshot</code> action is the destination AWS Region
        /// for the DB snapshot copy. 
        /// </para>
        ///  
        /// <para>
        /// For more information about copying snapshots, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopyDBSnapshot">Copying
        /// a DB Snapshot</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <code>CustomAvailabilityZoneId</code> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBSnapshot">REST API Reference for CopyDBSnapshot Operation</seealso>
        public virtual CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBSnapshot">REST API Reference for CopyDBSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCopyDBSnapshot(CopyDBSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyDBSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBSnapshot">REST API Reference for CopyDBSnapshot Operation</seealso>
        public virtual CopyDBSnapshotResponse EndCopyDBSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyDBSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyOptionGroup

        /// <summary>
        /// Copies the specified option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CopyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyOptionGroup">REST API Reference for CopyOptionGroup Operation</seealso>
        public virtual CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CopyOptionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyOptionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyOptionGroup">REST API Reference for CopyOptionGroup Operation</seealso>
        public virtual IAsyncResult BeginCopyOptionGroup(CopyOptionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyOptionGroup.</param>
        /// 
        /// <returns>Returns a  CopyOptionGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyOptionGroup">REST API Reference for CopyOptionGroup Operation</seealso>
        public virtual CopyOptionGroupResponse EndCopyOptionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyOptionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomAvailabilityZone

        /// <summary>
        /// Creates a custom Availability Zone (AZ).
        /// 
        ///  
        /// <para>
        /// A custom AZ is an on-premises AZ that is integrated with a VMware vSphere cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
        /// RDS on VMware User Guide.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAvailabilityZone service method.</param>
        /// 
        /// <returns>The response from the CreateCustomAvailabilityZone service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneAlreadyExistsException">
        /// <code>CustomAvailabilityZoneName</code> is already used by an existing custom Availability
        /// Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneQuotaExceededException">
        /// You have exceeded the maximum number of custom Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomAvailabilityZone">REST API Reference for CreateCustomAvailabilityZone Operation</seealso>
        public virtual CreateCustomAvailabilityZoneResponse CreateCustomAvailabilityZone(CreateCustomAvailabilityZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomAvailabilityZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomAvailabilityZoneResponseUnmarshaller.Instance;

            return Invoke<CreateCustomAvailabilityZoneResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomAvailabilityZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAvailabilityZone operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomAvailabilityZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomAvailabilityZone">REST API Reference for CreateCustomAvailabilityZone Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomAvailabilityZone(CreateCustomAvailabilityZoneRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomAvailabilityZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomAvailabilityZoneResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomAvailabilityZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomAvailabilityZone.</param>
        /// 
        /// <returns>Returns a  CreateCustomAvailabilityZoneResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomAvailabilityZone">REST API Reference for CreateCustomAvailabilityZone Operation</seealso>
        public virtual CreateCustomAvailabilityZoneResponse EndCreateCustomAvailabilityZone(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomAvailabilityZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBCluster

        /// <summary>
        /// Creates a new Amazon Aurora DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
        /// cluster as a read replica of another DB cluster or Amazon RDS MySQL DB instance. For
        /// cross-region replication where the DB cluster identified by <code>ReplicationSourceIdentifier</code>
        /// is encrypted, you must also specify the <code>PreSignedUrl</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateDBCluster(CreateDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse EndCreateDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterEndpoint

        /// <summary>
        /// Creates a new custom endpoint and associates it with an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointAlreadyExistsException">
        /// The specified custom endpoint can't be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointQuotaExceededException">
        /// The cluster already has the maximum number of custom endpoints.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual CreateDBClusterEndpointResponse CreateDBClusterEndpoint(CreateDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterEndpoint operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterEndpoint(CreateDBClusterEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBClusterEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateDBClusterEndpointResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual CreateDBClusterEndpointResponse EndCreateDBClusterEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterEndpointResponse>(asyncResult);
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
        /// for any of the parameters, you must modify the group after creating it using <code>ModifyDBClusterParameterGroup</code>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <code>ModifyDBCluster</code>. When you associate a new DB cluster
        /// parameter group with a running DB cluster, you need to reboot the DB instances in
        /// the DB cluster without failover for the new DB cluster parameter group and associated
        /// settings to take effect. 
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS
        /// console</a> or the <code>DescribeDBClusterParameters</code> action to verify that
        /// your DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateDBClusterParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual CreateDBClusterParameterGroupResponse EndCreateDBClusterParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBClusterParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot

        /// <summary>
        /// Creates a snapshot of a DB cluster. For more information on Amazon Aurora, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateDBClusterSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
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
        /// <returns>The response from the CreateDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateDBInstance(CreateDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse EndCreateDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica

        /// <summary>
        /// Creates a new DB instance that acts as a read replica for an existing source DB instance.
        /// You can create a read replica for a DB instance running MySQL, MariaDB, Oracle, PostgreSQL,
        /// or SQL Server. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
        /// with Read Replicas</a> in the <i>Amazon RDS User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// Amazon Aurora doesn't support this action. Call the <code>CreateDBInstance</code>
        /// action to create a DB instance for an Aurora DB cluster.
        /// </para>
        ///  
        /// <para>
        /// All read replica DB instances are created with backups disabled. All other DB instance
        /// attributes (including DB security groups and DB parameter groups) are inherited from
        /// the source DB instance, except as specified.
        /// </para>
        ///  <important> 
        /// <para>
        /// Your source DB instance must have backup retention enabled. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotAllowedException">
        /// The DBSubnetGroup shouldn't be specified while creating read replicas that lie in
        /// the same region as the source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupException">
        /// The DBSubnetGroup doesn't belong to the same VPC as that of an existing cross-region
        /// read replica of the same source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstanceReadReplica
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual IAsyncResult BeginCreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBInstanceReadReplica operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstanceReadReplica.</param>
        /// 
        /// <returns>Returns a  CreateDBInstanceReadReplicaResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual CreateDBInstanceReadReplicaResponse EndCreateDBInstanceReadReplica(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBInstanceReadReplicaResponse>(asyncResult);
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
        /// group. This allows Amazon RDS to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBParameterGroup(CreateDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual CreateDBParameterGroupResponse EndCreateDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBProxy

        /// <summary>
        /// Creates a new DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxy service method.</param>
        /// 
        /// <returns>The response from the CreateDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyAlreadyExistsException">
        /// The specified proxy name must be unique for all proxies owned by your AWS account
        /// in the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyQuotaExceededException">
        /// Your AWS account already has the maximum number of proxies in the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBProxy">REST API Reference for CreateDBProxy Operation</seealso>
        public virtual CreateDBProxyResponse CreateDBProxy(CreateDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyResponseUnmarshaller.Instance;

            return Invoke<CreateDBProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxy operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBProxy">REST API Reference for CreateDBProxy Operation</seealso>
        public virtual IAsyncResult BeginCreateDBProxy(CreateDBProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBProxy.</param>
        /// 
        /// <returns>Returns a  CreateDBProxyResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBProxy">REST API Reference for CreateDBProxy Operation</seealso>
        public virtual CreateDBProxyResponse EndCreateDBProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBSecurityGroup

        /// <summary>
        /// Creates a new DB security group. DB security groups control access to a DB instance.
        /// 
        ///  <note> 
        /// <para>
        /// A DB security group controls access to EC2-Classic DB instances that are not in a
        /// VPC.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException">
        /// A DB security group with the name specified in <code>DBSecurityGroupName</code> already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotSupportedException">
        /// A DB security group isn't allowed for this action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB security groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBSecurityGroup(CreateDBSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateDBSecurityGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual CreateDBSecurityGroupResponse EndCreateDBSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBSnapshot

        /// <summary>
        /// Creates a snapshot of a DB instance. The source DB instance must be in the <code>available</code>
        /// or <code>storage-optimization</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateDBSnapshot(CreateDBSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateDBSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual CreateDBSnapshotResponse EndCreateDBSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException">
        /// <code>DBSubnetGroupName</code> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateDBSubnetGroup(CreateDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateDBSubnetGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual CreateDBSubnetGroupResponse EndCreateDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSubscription

        /// <summary>
        /// Creates an RDS event notification subscription. This action requires a topic Amazon
        /// Resource Name (ARN) created by either the RDS console, the SNS console, or the SNS
        /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
        /// to the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<code>SourceType</code>) that you want to be notified
        /// of and provide a list of RDS sources (<code>SourceIds</code>) that triggers the events.
        /// You can also provide a list of event categories (<code>EventCategories</code>) for
        /// events that you want to be notified of. For example, you can specify <code>SourceType</code>
        /// = <code>db-instance</code>, <code>SourceIds</code> = <code>mydbinstance1</code>, <code>mydbinstance2</code>
        /// and <code>EventCategories</code> = <code>Availability</code>, <code>Backup</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <code>SourceType</code> and <code>SourceIds</code>, such as
        /// <code>SourceType</code> = <code>db-instance</code> and <code>SourceIdentifier</code>
        /// = <code>myDBInstance1</code>, you are notified of all the <code>db-instance</code>
        /// events for the specified source. If you specify a <code>SourceType</code> but do not
        /// specify a <code>SourceIdentifier</code>, you receive notice of the events for that
        /// source type for all your RDS sources. If you don't specify either the SourceType or
        /// the <code>SourceIdentifier</code>, you are notified of events generated from all RDS
        /// sources belonging to your customer account.
        /// </para>
        ///  <note> 
        /// <para>
        /// RDS event notification is only available for unencrypted SNS topics. If you specify
        /// an encrypted SNS topic, event notifications aren't sent for the topic.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionAlreadyExistException">
        /// The supplied subscription name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateEventSubscriptionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlobalCluster

        /// <summary>
        /// Creates an Aurora global database spread across multiple AWS Regions. The global
        /// database contains a single primary cluster with read-write capability, and a read-only
        /// secondary cluster that receives data from the primary cluster through high-speed replication
        /// performed by the Aurora storage subsystem. 
        /// 
        ///  
        /// <para>
        ///  You can create a global database that is initially empty, and then add a primary
        /// cluster and a secondary cluster to it. Or you can specify an existing Aurora cluster
        /// during the create operation, and this cluster becomes the primary cluster of the global
        /// database. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <code>GlobalClusterIdentifier</code> already exists. Choose a new global database
        /// identifier (unique name) to create a new global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterQuotaExceededException">
        /// The number of global database clusters for this account is already at the maximum
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual CreateGlobalClusterResponse CreateGlobalCluster(CreateGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateGlobalCluster(CreateGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  CreateGlobalClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual CreateGlobalClusterResponse EndCreateGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOptionGroup

        /// <summary>
        /// Creates a new option group. You can create up to 20 option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this AWS account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateOptionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOptionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateOptionGroup(CreateOptionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOptionGroup.</param>
        /// 
        /// <returns>Returns a  CreateOptionGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual CreateOptionGroupResponse EndCreateOptionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOptionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomAvailabilityZone

        /// <summary>
        /// Deletes a custom Availability Zone (AZ).
        /// 
        ///  
        /// <para>
        /// A custom AZ is an on-premises AZ that is integrated with a VMware vSphere cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
        /// RDS on VMware User Guide.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAvailabilityZone service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomAvailabilityZone service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <code>CustomAvailabilityZoneId</code> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteCustomAvailabilityZone">REST API Reference for DeleteCustomAvailabilityZone Operation</seealso>
        public virtual DeleteCustomAvailabilityZoneResponse DeleteCustomAvailabilityZone(DeleteCustomAvailabilityZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomAvailabilityZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomAvailabilityZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomAvailabilityZoneResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomAvailabilityZone operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAvailabilityZone operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomAvailabilityZone
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteCustomAvailabilityZone">REST API Reference for DeleteCustomAvailabilityZone Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomAvailabilityZone(DeleteCustomAvailabilityZoneRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomAvailabilityZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomAvailabilityZoneResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomAvailabilityZone operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomAvailabilityZone.</param>
        /// 
        /// <returns>Returns a  DeleteCustomAvailabilityZoneResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteCustomAvailabilityZone">REST API Reference for DeleteCustomAvailabilityZone Operation</seealso>
        public virtual DeleteCustomAvailabilityZoneResponse EndDeleteCustomAvailabilityZone(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomAvailabilityZoneResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBCluster

        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///   
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBCluster(DeleteDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse EndDeleteDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterEndpoint

        /// <summary>
        /// Deletes a custom endpoint and removes it from an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation can't be performed on the endpoint while the endpoint is in
        /// this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterEndpoint">REST API Reference for DeleteDBClusterEndpoint Operation</seealso>
        public virtual DeleteDBClusterEndpointResponse DeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterEndpoint operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterEndpoint">REST API Reference for DeleteDBClusterEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBClusterEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteDBClusterEndpointResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterEndpoint">REST API Reference for DeleteDBClusterEndpoint Operation</seealso>
        public virtual DeleteDBClusterEndpointResponse EndDeleteDBClusterEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBClusterEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup

        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted can't be associated with any DB clusters.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteDBClusterParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
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
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBClusterSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteDBClusterSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
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
        ///  If you request a final DB snapshot the status of the Amazon RDS DB instance is <code>deleting</code>
        /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
        /// used to monitor the status of this operation. The action can't be canceled or reverted
        /// once submitted. 
        /// </para>
        ///  
        /// <para>
        /// When a DB instance is in a failure state and has a status of <code>failed</code>,
        /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
        /// delete it when you skip creation of the final snapshot with the <code>SkipFinalSnapshot</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If the specified DB instance is part of an Amazon Aurora DB cluster, you can't delete
        /// the DB instance if both of the following conditions are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB cluster is a read replica of another Amazon Aurora DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB instance is the only instance in the DB cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a DB instance in this case, first call the <code>PromoteReadReplicaDBCluster</code>
        /// API action to promote the DB cluster so it's no longer a read replica. After the promotion
        /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
        /// instance in the DB cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBInstance(DeleteDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse EndDeleteDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBInstanceAutomatedBackup

        /// <summary>
        /// Deletes automated backups using the <code>DbiResourceId</code> value of the source
        /// DB instance or the Amazon Resource Name (ARN) of the automated backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstanceAutomatedBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstanceAutomatedBackup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstanceAutomatedBackup">REST API Reference for DeleteDBInstanceAutomatedBackup Operation</seealso>
        public virtual DeleteDBInstanceAutomatedBackupResponse DeleteDBInstanceAutomatedBackup(DeleteDBInstanceAutomatedBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceAutomatedBackupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstanceAutomatedBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstanceAutomatedBackup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstanceAutomatedBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstanceAutomatedBackup">REST API Reference for DeleteDBInstanceAutomatedBackup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBInstanceAutomatedBackup(DeleteDBInstanceAutomatedBackupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBInstanceAutomatedBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBInstanceAutomatedBackup.</param>
        /// 
        /// <returns>Returns a  DeleteDBInstanceAutomatedBackupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstanceAutomatedBackup">REST API Reference for DeleteDBInstanceAutomatedBackup Operation</seealso>
        public virtual DeleteDBInstanceAutomatedBackupResponse EndDeleteDBInstanceAutomatedBackup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBInstanceAutomatedBackupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        /// <summary>
        /// Deletes a specified DB parameter group. The DB parameter group to be deleted can't
        /// be associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBParameterGroup(DeleteDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual DeleteDBParameterGroupResponse EndDeleteDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBProxy

        /// <summary>
        /// Deletes an existing proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxy service method.</param>
        /// 
        /// <returns>The response from the DeleteDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxy">REST API Reference for DeleteDBProxy Operation</seealso>
        public virtual DeleteDBProxyResponse DeleteDBProxy(DeleteDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteDBProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxy operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxy">REST API Reference for DeleteDBProxy Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBProxy(DeleteDBProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBProxy.</param>
        /// 
        /// <returns>Returns a  DeleteDBProxyResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxy">REST API Reference for DeleteDBProxy Operation</seealso>
        public virtual DeleteDBProxyResponse EndDeleteDBProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup

        /// <summary>
        /// Deletes a DB security group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified DB security group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSecurityGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDBSecurityGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual DeleteDBSecurityGroupResponse EndDeleteDBSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDBSnapshot

        /// <summary>
        /// Deletes a DB snapshot. If the snapshot is being copied, the copy operation is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB snapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBSnapshot(DeleteDBSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteDBSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual DeleteDBSnapshotResponse EndDeleteDBSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBSnapshotResponse>(asyncResult);
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
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetStateException">
        /// The DB subnet isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteDBSubnetGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse EndDeleteDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSubscription

        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidEventSubscriptionStateException">
        /// This error can occur if someone else is modifying a subscription. You should retry
        /// the action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteEventSubscriptionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlobalCluster

        /// <summary>
        /// Deletes a global database cluster. The primary and secondary clusters must already
        /// be detached or destroyed first. 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual DeleteGlobalClusterResponse DeleteGlobalCluster(DeleteGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlobalCluster(DeleteGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DeleteGlobalClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual DeleteGlobalClusterResponse EndDeleteGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstallationMedia

        /// <summary>
        /// Deletes the installation medium for a DB engine that requires an on-premises customer
        /// provided license, such as Microsoft SQL Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstallationMedia service method.</param>
        /// 
        /// <returns>The response from the DeleteInstallationMedia service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InstallationMediaNotFoundException">
        /// <code>InstallationMediaID</code> doesn't refer to an existing installation medium.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteInstallationMedia">REST API Reference for DeleteInstallationMedia Operation</seealso>
        public virtual DeleteInstallationMediaResponse DeleteInstallationMedia(DeleteInstallationMediaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstallationMediaResponseUnmarshaller.Instance;

            return Invoke<DeleteInstallationMediaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstallationMedia operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstallationMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteInstallationMedia">REST API Reference for DeleteInstallationMedia Operation</seealso>
        public virtual IAsyncResult BeginDeleteInstallationMedia(DeleteInstallationMediaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInstallationMediaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstallationMedia.</param>
        /// 
        /// <returns>Returns a  DeleteInstallationMediaResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteInstallationMedia">REST API Reference for DeleteInstallationMedia Operation</seealso>
        public virtual DeleteInstallationMediaResponse EndDeleteInstallationMedia(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstallationMediaResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOptionGroup

        /// <summary>
        /// Deletes an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteOptionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOptionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteOptionGroup(DeleteOptionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOptionGroup.</param>
        /// 
        /// <returns>Returns a  DeleteOptionGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual DeleteOptionGroupResponse EndDeleteOptionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOptionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterDBProxyTargets

        /// <summary>
        /// Remove the association between one or more <code>DBProxyTarget</code> data structures
        /// and a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDBProxyTargets service method.</param>
        /// 
        /// <returns>The response from the DeregisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetNotFoundException">
        /// The specified RDS DB instance or Aurora DB cluster isn't available for a proxy owned
        /// by your AWS account in the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeregisterDBProxyTargets">REST API Reference for DeregisterDBProxyTargets Operation</seealso>
        public virtual DeregisterDBProxyTargetsResponse DeregisterDBProxyTargets(DeregisterDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterDBProxyTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDBProxyTargets operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterDBProxyTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeregisterDBProxyTargets">REST API Reference for DeregisterDBProxyTargets Operation</seealso>
        public virtual IAsyncResult BeginDeregisterDBProxyTargets(DeregisterDBProxyTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterDBProxyTargets.</param>
        /// 
        /// <returns>Returns a  DeregisterDBProxyTargetsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeregisterDBProxyTargets">REST API Reference for DeregisterDBProxyTargets Operation</seealso>
        public virtual DeregisterDBProxyTargetsResponse EndDeregisterDBProxyTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterDBProxyTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command doesn't take any parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }

        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command doesn't take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificates

        /// <summary>
        /// Lists the set of CA certificates provided by Amazon RDS for this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificates(DescribeCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeCertificatesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse EndDescribeCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomAvailabilityZones

        /// <summary>
        /// Returns information about custom Availability Zones (AZs).
        /// 
        ///  
        /// <para>
        /// A custom AZ is an on-premises AZ that is integrated with a VMware vSphere cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
        /// RDS on VMware User Guide.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomAvailabilityZones service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomAvailabilityZones service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <code>CustomAvailabilityZoneId</code> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCustomAvailabilityZones">REST API Reference for DescribeCustomAvailabilityZones Operation</seealso>
        public virtual DescribeCustomAvailabilityZonesResponse DescribeCustomAvailabilityZones(DescribeCustomAvailabilityZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomAvailabilityZonesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomAvailabilityZones operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomAvailabilityZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCustomAvailabilityZones">REST API Reference for DescribeCustomAvailabilityZones Operation</seealso>
        public virtual IAsyncResult BeginDescribeCustomAvailabilityZones(DescribeCustomAvailabilityZonesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomAvailabilityZonesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  DescribeCustomAvailabilityZonesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCustomAvailabilityZones">REST API Reference for DescribeCustomAvailabilityZones Operation</seealso>
        public virtual DescribeCustomAvailabilityZonesResponse EndDescribeCustomAvailabilityZones(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomAvailabilityZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterBacktracks

        /// <summary>
        /// Returns information about backtracks for a DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora MySQL DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterBacktracks service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterBacktracks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterBacktrackNotFoundException">
        /// <code>BacktrackIdentifier</code> doesn't refer to an existing backtrack.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual DescribeDBClusterBacktracksResponse DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterBacktracksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterBacktracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterBacktracks operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterBacktracks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterBacktracks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterBacktracks.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterBacktracksResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual DescribeDBClusterBacktracksResponse EndDescribeDBClusterBacktracks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterBacktracksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterEndpoints

        /// <summary>
        /// Returns information about endpoints for an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterEndpoints service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual DescribeDBClusterEndpointsResponse DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterEndpoints operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBClusterEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBClusterEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeDBClusterEndpointsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual DescribeDBClusterEndpointsResponse EndDescribeDBClusterEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups

        /// <summary>
        /// Returns a list of <code>DBClusterParameterGroup</code> descriptions. If a <code>DBClusterParameterGroupName</code>
        /// parameter is specified, the list will contain only the description of the specified
        /// DB cluster parameter group. 
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBClusterParameterGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse EndDescribeDBClusterParameterGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParameterGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterParameters

        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterParameters(DescribeDBClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBClusterParametersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse EndDescribeDBClusterParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusters

        /// <summary>
        /// Returns information about provisioned Aurora DB clusters. This API supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusters(DescribeDBClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBClustersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
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
        /// snapshot, or to make the manual DB cluster snapshot public or private, use the <code>ModifyDBClusterSnapshotAttribute</code>
        /// API action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshotAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBClusterSnapshotAttributesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse EndDescribeDBClusterSnapshotAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots

        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBClusterSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBClusterSnapshotsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse EndDescribeDBClusterSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBClusterSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }

        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBEngineVersions(DescribeDBEngineVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBEngineVersionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse EndDescribeDBEngineVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBEngineVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBInstanceAutomatedBackups

        /// <summary>
        /// Displays backups for both current and deleted instances. For example, use this operation
        /// to find details about automated backups for previously deleted instances. Current
        /// instances with retention periods greater than zero (0) are returned for both the <code>DescribeDBInstanceAutomatedBackups</code>
        /// and <code>DescribeDBInstances</code> operations.
        /// 
        ///  
        /// <para>
        /// All parameters are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstanceAutomatedBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstanceAutomatedBackups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstanceAutomatedBackups">REST API Reference for DescribeDBInstanceAutomatedBackups Operation</seealso>
        public virtual DescribeDBInstanceAutomatedBackupsResponse DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstanceAutomatedBackupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstanceAutomatedBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstanceAutomatedBackups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBInstanceAutomatedBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstanceAutomatedBackups">REST API Reference for DescribeDBInstanceAutomatedBackups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBInstanceAutomatedBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBInstanceAutomatedBackups.</param>
        /// 
        /// <returns>Returns a  DescribeDBInstanceAutomatedBackupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstanceAutomatedBackups">REST API Reference for DescribeDBInstanceAutomatedBackups Operation</seealso>
        public virtual DescribeDBInstanceAutomatedBackupsResponse EndDescribeDBInstanceAutomatedBackups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBInstanceAutomatedBackupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBInstances

        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }

        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBInstances(DescribeDBInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBInstancesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse EndDescribeDBInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBLogFiles

        /// <summary>
        /// Returns a list of DB log files for the DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles service method.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBLogFilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBLogFiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBLogFiles(DescribeDBLogFilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBLogFiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBLogFiles.</param>
        /// 
        /// <returns>Returns a  DescribeDBLogFilesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual DescribeDBLogFilesResponse EndDescribeDBLogFiles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBLogFilesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }

        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBParameterGroups(DescribeDBParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBParameterGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
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
        /// <returns>The response from the DescribeDBParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBParameters(DescribeDBParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDBParametersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual DescribeDBParametersResponse EndDescribeDBParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBProxies

        /// <summary>
        /// Returns information about DB proxies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxies service method.</param>
        /// 
        /// <returns>The response from the DescribeDBProxies service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxies">REST API Reference for DescribeDBProxies Operation</seealso>
        public virtual DescribeDBProxiesResponse DescribeDBProxies(DescribeDBProxiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxiesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBProxies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxies operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBProxies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxies">REST API Reference for DescribeDBProxies Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBProxies(DescribeDBProxiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBProxies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBProxies.</param>
        /// 
        /// <returns>Returns a  DescribeDBProxiesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxies">REST API Reference for DescribeDBProxies Operation</seealso>
        public virtual DescribeDBProxiesResponse EndDescribeDBProxies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBProxiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBProxyTargetGroups

        /// <summary>
        /// Returns information about DB proxy target groups, represented by <code>DBProxyTargetGroup</code>
        /// data structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBProxyTargetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargetGroups">REST API Reference for DescribeDBProxyTargetGroups Operation</seealso>
        public virtual DescribeDBProxyTargetGroupsResponse DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBProxyTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargetGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBProxyTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargetGroups">REST API Reference for DescribeDBProxyTargetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBProxyTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBProxyTargetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBProxyTargetGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargetGroups">REST API Reference for DescribeDBProxyTargetGroups Operation</seealso>
        public virtual DescribeDBProxyTargetGroupsResponse EndDescribeDBProxyTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBProxyTargetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBProxyTargets

        /// <summary>
        /// Returns information about <code>DBProxyTarget</code> objects. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetNotFoundException">
        /// The specified RDS DB instance or Aurora DB cluster isn't available for a proxy owned
        /// by your AWS account in the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargets">REST API Reference for DescribeDBProxyTargets Operation</seealso>
        public virtual DescribeDBProxyTargetsResponse DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargets operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBProxyTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargets">REST API Reference for DescribeDBProxyTargets Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBProxyTargets(DescribeDBProxyTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBProxyTargets.</param>
        /// 
        /// <returns>Returns a  DescribeDBProxyTargetsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargets">REST API Reference for DescribeDBProxyTargets Operation</seealso>
        public virtual DescribeDBProxyTargetsResponse EndDescribeDBProxyTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBProxyTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups

        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }

        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeDBSecurityGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual DescribeDBSecurityGroupsResponse EndDescribeDBSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBSnapshotAttributes

        /// <summary>
        /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other AWS accounts, <code>DescribeDBSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the AWS accounts
        /// that are authorized to copy or restore the manual DB snapshot. If <code>all</code>
        /// is included in the list of values for the <code>restore</code> attribute, then the
        /// manual DB snapshot is public and can be copied or restored by all AWS accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an AWS account to copy or restore a manual DB snapshot,
        /// or to make the manual DB snapshot public or private, use the <code>ModifyDBSnapshotAttribute</code>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual DescribeDBSnapshotAttributesResponse DescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSnapshotAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSnapshotAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeDBSnapshotAttributesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual DescribeDBSnapshotAttributesResponse EndDescribeDBSnapshotAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBSnapshotAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDBSnapshots

        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }

        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSnapshots(DescribeDBSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDBSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeDBSnapshotsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual DescribeDBSnapshotsResponse EndDescribeDBSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBSnapshotsResponse>(asyncResult);
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
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }

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
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDBSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeDBSubnetGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse EndDescribeDBSubnetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDBSubnetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters

        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultClusterParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeEngineDefaultClusterParametersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
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
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineDefaultParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a  DescribeEngineDefaultParametersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEngineDefaultParametersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }

        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeEventCategoriesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventCategoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to DB instances, DB clusters, DB parameter groups, DB security
        /// groups, DB snapshots, and DB cluster snapshots for the past 14 days. Events specific
        /// to a particular DB instances, DB clusters, DB parameter groups, DB security groups,
        /// DB snapshots, and DB cluster snapshots group can be obtained by providing the name
        /// as a parameter.
        /// 
        ///  <note> 
        /// <para>
        /// By default, the past hour of events are returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// Returns events related to DB instances, DB clusters, DB parameter groups, DB security
        /// groups, DB snapshots, and DB cluster snapshots for the past 14 days. Events specific
        /// to a particular DB instances, DB clusters, DB parameter groups, DB security groups,
        /// DB snapshots, and DB cluster snapshots group can be obtained by providing the name
        /// as a parameter.
        /// 
        ///  <note> 
        /// <para>
        /// By default, the past hour of events are returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeEventsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>SubscriptionName</code>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }

        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>SubscriptionName</code>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeEventSubscriptionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExportTasks

        /// <summary>
        /// Returns information about a snapshot export to Amazon S3. This API operation supports
        /// pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExportTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGlobalClusters

        /// <summary>
        /// Returns information about Aurora global database clusters. This API supports pagination.
        /// 
        /// 
        ///  
        /// <para>
        ///  For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual DescribeGlobalClustersResponse DescribeGlobalClusters(DescribeGlobalClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGlobalClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGlobalClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual IAsyncResult BeginDescribeGlobalClusters(DescribeGlobalClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeGlobalClustersResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual DescribeGlobalClustersResponse EndDescribeGlobalClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGlobalClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstallationMedia

        /// <summary>
        /// Describes the available installation media for a DB engine that requires an on-premises
        /// customer provided license, such as Microsoft SQL Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstallationMedia service method.</param>
        /// 
        /// <returns>The response from the DescribeInstallationMedia service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InstallationMediaNotFoundException">
        /// <code>InstallationMediaID</code> doesn't refer to an existing installation medium.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeInstallationMedia">REST API Reference for DescribeInstallationMedia Operation</seealso>
        public virtual DescribeInstallationMediaResponse DescribeInstallationMedia(DescribeInstallationMediaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstallationMediaResponseUnmarshaller.Instance;

            return Invoke<DescribeInstallationMediaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstallationMedia operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstallationMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeInstallationMedia">REST API Reference for DescribeInstallationMedia Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstallationMedia(DescribeInstallationMediaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstallationMediaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstallationMedia.</param>
        /// 
        /// <returns>Returns a  DescribeInstallationMediaResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeInstallationMedia">REST API Reference for DescribeInstallationMedia Operation</seealso>
        public virtual DescribeInstallationMediaResponse EndDescribeInstallationMedia(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstallationMediaResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions

        /// <summary>
        /// Describes all available options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOptionGroupOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOptionGroupOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptionGroupOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOptionGroupOptionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual DescribeOptionGroupOptionsResponse EndDescribeOptionGroupOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOptionGroupOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOptionGroups

        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }

        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOptionGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeOptionGroups(DescribeOptionGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOptionGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptionGroups.</param>
        /// 
        /// <returns>Returns a  DescribeOptionGroupsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual DescribeOptionGroupsResponse EndDescribeOptionGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOptionGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        /// <summary>
        /// Returns a list of orderable DB instance options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableDBInstanceOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribeOrderableDBInstanceOptionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
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
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePendingMaintenanceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual IAsyncResult BeginDescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  DescribePendingMaintenanceActionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse EndDescribePendingMaintenanceActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePendingMaintenanceActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedDBInstances

        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }

        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedDBInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedDBInstances(DescribeReservedDBInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedDBInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedDBInstancesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual DescribeReservedDBInstancesResponse EndDescribeReservedDBInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedDBInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings

        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }

        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedDBInstancesOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual IAsyncResult BeginDescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedDBInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstancesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedDBInstancesOfferingsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual DescribeReservedDBInstancesOfferingsResponse EndDescribeReservedDBInstancesOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedDBInstancesOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSourceRegions

        /// <summary>
        /// Returns a list of the source AWS Regions where the current AWS Region can create a
        /// read replica, copy a DB snapshot from, or replicate automated backups from. This API
        /// action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceRegions service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceRegions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual DescribeSourceRegionsResponse DescribeSourceRegions(DescribeSourceRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceRegionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceRegions operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual IAsyncResult BeginDescribeSourceRegions(DescribeSourceRegionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceRegions.</param>
        /// 
        /// <returns>Returns a  DescribeSourceRegionsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual DescribeSourceRegionsResponse EndDescribeSourceRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSourceRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeValidDBInstanceModifications

        /// <summary>
        /// You can call <code>DescribeValidDBInstanceModifications</code> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <code>ModifyDBInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeValidDBInstanceModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual IAsyncResult BeginDescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeValidDBInstanceModifications.</param>
        /// 
        /// <returns>Returns a  DescribeValidDBInstanceModificationsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual DescribeValidDBInstanceModificationsResponse EndDescribeValidDBInstanceModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeValidDBInstanceModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion

        /// <summary>
        /// Downloads all or a portion of the specified log file, up to 1 MB in size.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBLogFileNotFoundException">
        /// <code>LogFileName</code> doesn't refer to an existing DB log file.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return Invoke<DownloadDBLogFilePortionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDownloadDBLogFilePortion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual IAsyncResult BeginDownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DownloadDBLogFilePortion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadDBLogFilePortion.</param>
        /// 
        /// <returns>Returns a  DownloadDBLogFilePortionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual DownloadDBLogFilePortionResponse EndDownloadDBLogFilePortion(IAsyncResult asyncResult)
        {
            return EndInvoke<DownloadDBLogFilePortionResponse>(asyncResult);
        }

        #endregion
        
        #region  FailoverDBCluster

        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// A failover for a DB cluster promotes one of the Aurora Replicas (read-only instances)
        /// in the DB cluster to be the primary instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// Amazon Aurora will automatically fail over to an Aurora Replica, if one exists, when
        /// the primary instance fails. You can force a failover when you want to simulate a failure
        /// of a primary instance for testing. Because each instance in a DB cluster has its own
        /// endpoint address, you will need to clean up and re-establish any existing connections
        /// that use those endpoint addresses when the failover is complete.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFailoverDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual IAsyncResult BeginFailoverDBCluster(FailoverDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  FailoverDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse EndFailoverDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<FailoverDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportInstallationMedia

        /// <summary>
        /// Imports the installation media for a DB engine that requires an on-premises customer
        /// provided license, such as SQL Server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstallationMedia service method.</param>
        /// 
        /// <returns>The response from the ImportInstallationMedia service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <code>CustomAvailabilityZoneId</code> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstallationMediaAlreadyExistsException">
        /// The specified installation medium has already been imported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ImportInstallationMedia">REST API Reference for ImportInstallationMedia Operation</seealso>
        public virtual ImportInstallationMediaResponse ImportInstallationMedia(ImportInstallationMediaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstallationMediaResponseUnmarshaller.Instance;

            return Invoke<ImportInstallationMediaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstallationMedia operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportInstallationMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ImportInstallationMedia">REST API Reference for ImportInstallationMedia Operation</seealso>
        public virtual IAsyncResult BeginImportInstallationMedia(ImportInstallationMediaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstallationMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstallationMediaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportInstallationMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstallationMedia.</param>
        /// 
        /// <returns>Returns a  ImportInstallationMediaResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ImportInstallationMedia">REST API Reference for ImportInstallationMedia Operation</seealso>
        public virtual ImportInstallationMediaResponse EndImportInstallationMedia(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportInstallationMediaResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyCertificates

        /// <summary>
        /// Override the system-default Secure Sockets Layer/Transport Layer Security (SSL/TLS)
        /// certificate for Amazon RDS for new DB instances temporarily, or remove the override.
        /// 
        ///  
        /// <para>
        /// By using this operation, you can specify an RDS-approved SSL/TLS certificate for new
        /// DB instances that is different from the default certificate provided by RDS. You can
        /// also use this operation to remove the override, so that new DB instances use the default
        /// certificate provided by RDS.
        /// </para>
        ///  
        /// <para>
        /// You might need to override the default certificate in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You already migrated your applications to support the latest certificate authority
        /// (CA) certificate, but the new CA certificate is not yet the RDS default CA certificate
        /// for the specified AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS has already moved to a new default CA certificate for the specified AWS Region,
        /// but you are still in the process of supporting the new CA certificate. In this case,
        /// you temporarily need additional time to finish your application changes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for RDS DB engines, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for Aurora DB engines,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificates service method.</param>
        /// 
        /// <returns>The response from the ModifyCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual ModifyCertificatesResponse ModifyCertificates(ModifyCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificatesResponseUnmarshaller.Instance;

            return Invoke<ModifyCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificates operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual IAsyncResult BeginModifyCertificates(ModifyCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCertificates.</param>
        /// 
        /// <returns>Returns a  ModifyCertificatesResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual ModifyCertificatesResponse EndModifyCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyCurrentDBClusterCapacity

        /// <summary>
        /// Set the capacity of an Aurora Serverless DB cluster to a specific value.
        /// 
        ///  
        /// <para>
        /// Aurora Serverless scales seamlessly based on the workload on the DB cluster. In some
        /// cases, the capacity might not scale fast enough to meet a sudden change in workload,
        /// such as a large number of new transactions. Call <code>ModifyCurrentDBClusterCapacity</code>
        /// to set the capacity explicitly.
        /// </para>
        ///  
        /// <para>
        /// After this call sets the DB cluster capacity, Aurora Serverless can automatically
        /// scale the DB cluster based on the cooldown period for scaling up and the cooldown
        /// period for scaling down.
        /// </para>
        ///  
        /// <para>
        /// For more information about Aurora Serverless, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
        /// Amazon Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you call <code>ModifyCurrentDBClusterCapacity</code> with the default <code>TimeoutAction</code>,
        /// connections that prevent Aurora Serverless from finding a scaling point might be dropped.
        /// For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
        /// Autoscaling for Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCurrentDBClusterCapacity service method.</param>
        /// 
        /// <returns>The response from the ModifyCurrentDBClusterCapacity service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterCapacityException">
        /// <code>Capacity</code> isn't a valid Aurora Serverless DB cluster capacity. Valid
        /// capacity values are <code>2</code>, <code>4</code>, <code>8</code>, <code>16</code>,
        /// <code>32</code>, <code>64</code>, <code>128</code>, and <code>256</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual ModifyCurrentDBClusterCapacityResponse ModifyCurrentDBClusterCapacity(ModifyCurrentDBClusterCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCurrentDBClusterCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance;

            return Invoke<ModifyCurrentDBClusterCapacityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCurrentDBClusterCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCurrentDBClusterCapacity operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCurrentDBClusterCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual IAsyncResult BeginModifyCurrentDBClusterCapacity(ModifyCurrentDBClusterCapacityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCurrentDBClusterCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCurrentDBClusterCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCurrentDBClusterCapacity.</param>
        /// 
        /// <returns>Returns a  ModifyCurrentDBClusterCapacityResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual ModifyCurrentDBClusterCapacityResponse EndModifyCurrentDBClusterCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyCurrentDBClusterCapacityResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBCluster

        /// <summary>
        /// Modify a setting for an Amazon Aurora DB cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyDBCluster(ModifyDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse EndModifyDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterEndpoint

        /// <summary>
        /// Modifies the properties of an endpoint in an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation can't be performed on the endpoint while the endpoint is in
        /// this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterEndpoint">REST API Reference for ModifyDBClusterEndpoint Operation</seealso>
        public virtual ModifyDBClusterEndpointResponse ModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterEndpoint operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterEndpoint">REST API Reference for ModifyDBClusterEndpoint Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBClusterEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBClusterEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyDBClusterEndpointResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterEndpoint">REST API Reference for ModifyDBClusterEndpoint Operation</seealso>
        public virtual ModifyDBClusterEndpointResponse EndModifyDBClusterEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup

        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one
        /// parameter, submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request. 
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
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
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the parameter group is used as the default for a new DB cluster. This is especially
        /// important for parameters that are critical when creating the default database for
        /// a DB cluster, such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <code>DescribeDBClusterParameters</code> action to verify that
        /// your DB cluster parameter group has been created or modified.
        /// </para>
        ///  
        /// <para>
        /// If the modified DB cluster parameter group is used by an Aurora Serverless cluster,
        /// Aurora applies the update immediately. The cluster restart might interrupt your workload.
        /// In that case, your application must reopen any connections and retry any transactions
        /// that were active when the parameter changes took effect.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyDBClusterParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
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
        /// public, which means that it can be copied or restored by all AWS accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <code>all</code> value for any manual DB cluster snapshots that contain
        /// private information that you don't want available to all AWS accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If a manual DB cluster snapshot is encrypted, it can be shared, but only by specifying
        /// a list of authorized AWS account IDs for the <code>ValuesToAdd</code> parameter. You
        /// can't use <code>all</code> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB cluster snapshot,
        /// or whether a manual DB cluster snapshot is public or private, use the <a>DescribeDBClusterSnapshotAttributes</a>
        /// API action. The accounts are returned as values for the <code>restore</code> attribute.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBClusterSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual IAsyncResult BeginModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyDBClusterSnapshotAttributeResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse EndModifyDBClusterSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBClusterSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBInstance

        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <code>DescribeValidDBInstanceModifications</code>
        /// before you call <code>ModifyDBInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual IAsyncResult BeginModifyDBInstance(ModifyDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
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
        /// group. This allows Amazon RDS to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBParameterGroup(ModifyDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual ModifyDBParameterGroupResponse EndModifyDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBProxy

        /// <summary>
        /// Changes the settings for an existing DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxy service method.</param>
        /// 
        /// <returns>The response from the ModifyDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyAlreadyExistsException">
        /// The specified proxy name must be unique for all proxies owned by your AWS account
        /// in the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxy">REST API Reference for ModifyDBProxy Operation</seealso>
        public virtual ModifyDBProxyResponse ModifyDBProxy(ModifyDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxy operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxy">REST API Reference for ModifyDBProxy Operation</seealso>
        public virtual IAsyncResult BeginModifyDBProxy(ModifyDBProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBProxy.</param>
        /// 
        /// <returns>Returns a  ModifyDBProxyResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxy">REST API Reference for ModifyDBProxy Operation</seealso>
        public virtual ModifyDBProxyResponse EndModifyDBProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBProxyTargetGroup

        /// <summary>
        /// Modifies the properties of a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyTargetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBProxyTargetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxyTargetGroup">REST API Reference for ModifyDBProxyTargetGroup Operation</seealso>
        public virtual ModifyDBProxyTargetGroupResponse ModifyDBProxyTargetGroup(ModifyDBProxyTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyTargetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBProxyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyTargetGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBProxyTargetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxyTargetGroup">REST API Reference for ModifyDBProxyTargetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBProxyTargetGroup(ModifyDBProxyTargetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBProxyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBProxyTargetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyDBProxyTargetGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxyTargetGroup">REST API Reference for ModifyDBProxyTargetGroup Operation</seealso>
        public virtual ModifyDBProxyTargetGroupResponse EndModifyDBProxyTargetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBProxyTargetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBSnapshot

        /// <summary>
        /// Updates a manual DB snapshot with a new engine version. The snapshot can be encrypted
        /// or unencrypted, but not shared or public. 
        /// 
        ///  
        /// <para>
        /// Amazon RDS supports upgrading DB snapshots for MySQL, Oracle, and PostgreSQL. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual ModifyDBSnapshotResponse ModifyDBSnapshot(ModifyDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual IAsyncResult BeginModifyDBSnapshot(ModifyDBSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSnapshot.</param>
        /// 
        /// <returns>Returns a  ModifyDBSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual ModifyDBSnapshotResponse EndModifyDBSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBSnapshotAttribute

        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB snapshot with other AWS accounts, specify <code>restore</code>
        /// as the <code>AttributeName</code> and use the <code>ValuesToAdd</code> parameter to
        /// add a list of IDs of the AWS accounts that are authorized to restore the manual DB
        /// snapshot. Uses the value <code>all</code> to make the manual DB snapshot public, which
        /// means it can be copied or restored by all AWS accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <code>all</code> value for any manual DB snapshots that contain private
        /// information that you don't want available to all AWS accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the manual DB snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized AWS account IDs for the <code>ValuesToAdd</code> parameter. You
        /// can't use <code>all</code> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which AWS accounts have access to copy or restore a manual DB snapshot, or
        /// whether a manual DB snapshot public or private, use the <a>DescribeDBSnapshotAttributes</a>
        /// API action. The accounts are returned as values for the <code>restore</code> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual ModifyDBSnapshotAttributeResponse ModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual IAsyncResult BeginModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyDBSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyDBSnapshotAttributeResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual ModifyDBSnapshotAttributeResponse EndModifyDBSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyDBSubnetGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse EndModifyDBSubnetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyDBSubnetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyEventSubscription

        /// <summary>
        /// Modifies an existing RDS event notification subscription. You can't modify the source
        /// identifiers using this call. To change source identifiers for a subscription, use
        /// the <code>AddSourceIdentifierToSubscription</code> and <code>RemoveSourceIdentifierFromSubscription</code>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given source type (<code>SourceType</code>)
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// in the <i>Amazon RDS User Guide</i> or by using the <code>DescribeEventCategories</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SND topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyEventSubscriptionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyEventSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyGlobalCluster

        /// <summary>
        /// Modify a setting for an Amazon Aurora global cluster. You can change one or more
        /// database configuration parameters by specifying these parameters and the new values
        /// in the request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual ModifyGlobalClusterResponse ModifyGlobalCluster(ModifyGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginModifyGlobalCluster(ModifyGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ModifyGlobalClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual ModifyGlobalClusterResponse EndModifyGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyOptionGroup

        /// <summary>
        /// Modifies an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyOptionGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyOptionGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual IAsyncResult BeginModifyOptionGroup(ModifyOptionGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyOptionGroup.</param>
        /// 
        /// <returns>Returns a  ModifyOptionGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual ModifyOptionGroupResponse EndModifyOptionGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyOptionGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  PromoteReadReplica

        /// <summary>
        /// Promotes a read replica DB instance to a standalone DB instance.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Backup duration is a function of the amount of changes to the database since the previous
        /// backup. If you plan to promote a read replica to a standalone instance, we recommend
        /// that you enable backups and complete at least one backup prior to promotion. In addition,
        /// a read replica cannot be promoted to a standalone instance when it is in the <code>backing-up</code>
        /// status. If you have enabled backups on your read replica, configure the automated
        /// backup window so that daily backups do not interfere with read replica promotion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromoteReadReplica
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual IAsyncResult BeginPromoteReadReplica(PromoteReadReplicaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PromoteReadReplica operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteReadReplica.</param>
        /// 
        /// <returns>Returns a  PromoteReadReplicaResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual PromoteReadReplicaResponse EndPromoteReadReplica(IAsyncResult asyncResult)
        {
            return EndInvoke<PromoteReadReplicaResponse>(asyncResult);
        }

        #endregion
        
        #region  PromoteReadReplicaDBCluster

        /// <summary>
        /// Promotes a read replica DB cluster to a standalone DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromoteReadReplicaDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual IAsyncResult BeginPromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteReadReplicaDBCluster.</param>
        /// 
        /// <returns>Returns a  PromoteReadReplicaDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual PromoteReadReplicaDBClusterResponse EndPromoteReadReplicaDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<PromoteReadReplicaDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering

        /// <summary>
        /// Purchases a reserved DB instance offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceQuotaExceededException">
        /// Request would exceed the user's DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PurchaseReservedDBInstancesOffering">REST API Reference for PurchaseReservedDBInstancesOffering Operation</seealso>
        public virtual PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedDBInstancesOfferingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedDBInstancesOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PurchaseReservedDBInstancesOffering">REST API Reference for PurchaseReservedDBInstancesOffering Operation</seealso>
        public virtual IAsyncResult BeginPurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedDBInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedDBInstancesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedDBInstancesOfferingResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PurchaseReservedDBInstancesOffering">REST API Reference for PurchaseReservedDBInstancesOffering Operation</seealso>
        public virtual PurchaseReservedDBInstancesOfferingResponse EndPurchaseReservedDBInstancesOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseReservedDBInstancesOfferingResponse>(asyncResult);
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
        ///  
        /// <para>
        /// For more information about rebooting, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_RebootInstance.html">Rebooting
        /// a DB Instance</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual IAsyncResult BeginRebootDBInstance(RebootDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RebootDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse EndRebootDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterDBProxyTargets

        /// <summary>
        /// Associate one or more <code>DBProxyTarget</code> data structures with a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDBProxyTargets service method.</param>
        /// 
        /// <returns>The response from the RegisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetAlreadyRegisteredException">
        /// The proxy is already associated with the specified RDS DB instance or Aurora DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientAvailableIPsInSubnetException">
        /// The requested operation can't be performed because there aren't enough available IP
        /// addresses in the proxy's subnets. Add more CIDR blocks to the VPC or remove IP address
        /// that aren't required from the subnets.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RegisterDBProxyTargets">REST API Reference for RegisterDBProxyTargets Operation</seealso>
        public virtual RegisterDBProxyTargetsResponse RegisterDBProxyTargets(RegisterDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterDBProxyTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDBProxyTargets operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDBProxyTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RegisterDBProxyTargets">REST API Reference for RegisterDBProxyTargets Operation</seealso>
        public virtual IAsyncResult BeginRegisterDBProxyTargets(RegisterDBProxyTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDBProxyTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDBProxyTargets.</param>
        /// 
        /// <returns>Returns a  RegisterDBProxyTargetsResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RegisterDBProxyTargets">REST API Reference for RegisterDBProxyTargets Operation</seealso>
        public virtual RegisterDBProxyTargetsResponse EndRegisterDBProxyTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDBProxyTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveFromGlobalCluster

        /// <summary>
        /// Detaches an Aurora secondary cluster from an Aurora global database cluster. The
        /// cluster becomes a standalone cluster with read-write capability instead of being read-only
        /// and receiving data from a primary cluster in a different region. 
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual RemoveFromGlobalClusterResponse RemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveFromGlobalClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveFromGlobalCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveFromGlobalCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual IAsyncResult BeginRemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RemoveFromGlobalClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual RemoveFromGlobalClusterResponse EndRemoveFromGlobalCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveFromGlobalClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveRoleFromDBCluster

        /// <summary>
        /// Disassociates an AWS Identity and Access Management (IAM) role from an Amazon Aurora
        /// DB cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Integrating.Authorizing.html">Authorizing
        /// Amazon Aurora MySQL to Access Other AWS Services on Your Behalf </a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) isn't associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRoleFromDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual IAsyncResult BeginRemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromDBCluster.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual RemoveRoleFromDBClusterResponse EndRemoveRoleFromDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveRoleFromDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveRoleFromDBInstance

        /// <summary>
        /// Disassociates an AWS Identity and Access Management (IAM) role from a DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBInstance service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleNotFoundException">
        /// The specified <code>RoleArn</code> value doesn't match the specified feature for the
        /// DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual RemoveRoleFromDBInstanceResponse RemoveRoleFromDBInstance(RemoveRoleFromDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRoleFromDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual IAsyncResult BeginRemoveRoleFromDBInstance(RemoveRoleFromDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromDBInstance.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual RemoveRoleFromDBInstanceResponse EndRemoveRoleFromDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveRoleFromDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSourceIdentifierFromSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual IAsyncResult BeginRemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RemoveSourceIdentifierFromSubscriptionResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse EndRemoveSourceIdentifierFromSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveSourceIdentifierFromSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your AWS account in
        /// the specified AWS Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RemoveTagsFromResourceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
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
        /// restart or <code>RebootDBInstance</code> request. You must call <code>RebootDBInstance</code>
        /// for every DB instance in your DB cluster that you want the updated static parameter
        /// to apply to.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDBClusterParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ResetDBClusterParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
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
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetDBParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual IAsyncResult BeginResetDBParameterGroup(ResetDBParameterGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetDBParameterGroupResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual ResetDBParameterGroupResponse EndResetDBParameterGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetDBParameterGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterFromS3

        /// <summary>
        /// Creates an Amazon Aurora DB cluster from MySQL data stored in an Amazon S3 bucket.
        /// Amazon RDS must be authorized to access the Amazon S3 bucket and the data must be
        /// created using the Percona XtraBackup utility as described in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Migrating.ExtMySQL.html#AuroraMySQL.Migrating.ExtMySQL.S3">
        /// Migrating Data from MySQL by Using an Amazon S3 Bucket</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
        /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterFromS3</code> action
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters. The source DB engine must be MySQL.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromS3 service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual RestoreDBClusterFromS3Response RestoreDBClusterFromS3(RestoreDBClusterFromS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterFromS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterFromS3(RestoreDBClusterFromS3Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBClusterFromS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBClusterFromS3.</param>
        /// 
        /// <returns>Returns a  RestoreDBClusterFromS3Result from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual RestoreDBClusterFromS3Response EndRestoreDBClusterFromS3(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterFromS3Response>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        /// <summary>
        /// Creates a new DB cluster from a DB snapshot or DB cluster snapshot. This action only
        /// applies to Aurora DB clusters.
        /// 
        ///  
        /// <para>
        /// The target DB cluster is created from the source snapshot with a default configuration.
        /// If you don't specify a security group, the new DB cluster is associated with the default
        /// security group.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
        /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterFromSnapshot</code>
        /// action has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RestoreDBClusterFromSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
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
        /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
        /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
        /// action has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBClusterToPointInTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  RestoreDBClusterToPointInTimeResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse EndRestoreDBClusterToPointInTime(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBClusterToPointInTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot

        /// <summary>
        /// Creates a new DB instance from a DB snapshot. The target database is created from
        /// the source database restore point with most of the source's original configuration,
        /// including the default security group and DB parameter group. By default, the new DB
        /// instance is created as a Single-AZ deployment, except when the instance is a SQL Server
        /// instance that has an option group associated with mirroring. In this case, the instance
        /// becomes a Multi-AZ deployment, not a Single-AZ deployment.
        /// 
        ///  
        /// <para>
        /// If you want to replace your original DB instance with the new, restored DB instance,
        /// then rename your original DB instance before you call the RestoreDBInstanceFromDBSnapshot
        /// action. RDS doesn't allow two DB instances with the same name. After you have renamed
        /// your original DB instance with a different identifier, then you can pass the original
        /// name of the DB instance as the DBInstanceIdentifier in the call to the RestoreDBInstanceFromDBSnapshot
        /// action. The result is that you replace the original DB instance with the DB instance
        /// created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <code>DBSnapshotIdentifier</code>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <code>RestoreDBClusterFromSnapshot</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromDBSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBInstanceFromDBSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBInstanceFromDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceFromDBSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreDBInstanceFromDBSnapshotResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual RestoreDBInstanceFromDBSnapshotResponse EndRestoreDBInstanceFromDBSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBInstanceFromDBSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBInstanceFromS3

        /// <summary>
        /// Amazon Relational Database Service (Amazon RDS) supports importing MySQL databases
        /// by using backup files. You can create a backup of your on-premises database, store
        /// it on Amazon Simple Storage Service (Amazon S3), and then restore the backup file
        /// onto a new Amazon RDS DB instance running MySQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/MySQL.Procedural.Importing.html">Importing
        /// Data into an Amazon RDS MySQL DB Instance</a> in the <i>Amazon RDS User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromS3 service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromS3 service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual RestoreDBInstanceFromS3Response RestoreDBInstanceFromS3(RestoreDBInstanceFromS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromS3Response>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromS3 operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBInstanceFromS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBInstanceFromS3(RestoreDBInstanceFromS3Request request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBInstanceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceFromS3.</param>
        /// 
        /// <returns>Returns a  RestoreDBInstanceFromS3Result from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual RestoreDBInstanceFromS3Response EndRestoreDBInstanceFromS3(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBInstanceFromS3Response>(asyncResult);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime

        /// <summary>
        /// Restores a DB instance to an arbitrary point in time. You can restore to any point
        /// in time before the time identified by the LatestRestorableTime property. You can restore
        /// to a point up to the number of days specified by the BackupRetentionPeriod property.
        /// 
        ///  
        /// <para>
        /// The target database is created with most of the original configuration, but in a system-selected
        /// Availability Zone, with the default security group, the default subnet group, and
        /// the default DB parameter group. By default, the new DB instance is created as a single-AZ
        /// deployment except when the instance is a SQL Server instance that has an option group
        /// that is associated with mirroring; in this case, the instance becomes a mirrored deployment
        /// and not a single-AZ deployment.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <code>RestoreDBClusterToPointInTime</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.PointInTimeRestoreNotEnabledException">
        /// <code>SourceDBInstanceIdentifier</code> refers to a DB instance with <code>BackupRetentionPeriod</code>
        /// equal to 0.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreDBInstanceToPointInTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual IAsyncResult BeginRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreDBInstanceToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceToPointInTime.</param>
        /// 
        /// <returns>Returns a  RestoreDBInstanceToPointInTimeResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual RestoreDBInstanceToPointInTimeResponse EndRestoreDBInstanceToPointInTime(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreDBInstanceToPointInTimeResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress

        /// <summary>
        /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
        /// or VPC Security Groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
        /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeDBSecurityGroupIngressResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeDBSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual IAsyncResult BeginRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeDBSecurityGroupIngressResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual RevokeDBSecurityGroupIngressResponse EndRevokeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeDBSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  StartActivityStream

        /// <summary>
        /// Starts a database activity stream to monitor activity on the database. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">Database
        /// Activity Streams</a> in the <i>Amazon Aurora User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActivityStream service method.</param>
        /// 
        /// <returns>The response from the StartActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartActivityStream">REST API Reference for StartActivityStream Operation</seealso>
        public virtual StartActivityStreamResponse StartActivityStream(StartActivityStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StartActivityStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartActivityStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartActivityStream operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartActivityStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartActivityStream">REST API Reference for StartActivityStream Operation</seealso>
        public virtual IAsyncResult BeginStartActivityStream(StartActivityStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartActivityStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartActivityStream.</param>
        /// 
        /// <returns>Returns a  StartActivityStreamResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartActivityStream">REST API Reference for StartActivityStream Operation</seealso>
        public virtual StartActivityStreamResponse EndStartActivityStream(IAsyncResult asyncResult)
        {
            return EndInvoke<StartActivityStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDBCluster

        /// <summary>
        /// Starts an Amazon Aurora DB cluster that was stopped using the AWS console, the stop-db-cluster
        /// AWS CLI command, or the StopDBCluster action.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide.</i>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual StartDBClusterResponse StartDBCluster(StartDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return Invoke<StartDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual IAsyncResult BeginStartDBCluster(StartDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StartDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual StartDBClusterResponse EndStartDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDBInstance

        /// <summary>
        /// Starts an Amazon RDS DB instance that was stopped using the AWS console, the stop-db-instance
        /// AWS CLI command, or the StopDBInstance action. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StartInstance.html">
        /// Starting an Amazon RDS DB instance That Was Previously Stopped</a> in the <i>Amazon
        /// RDS User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora DB clusters,
        /// use <code>StartDBCluster</code> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstance service method.</param>
        /// 
        /// <returns>The response from the StartDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstance">REST API Reference for StartDBInstance Operation</seealso>
        public virtual StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstance">REST API Reference for StartDBInstance Operation</seealso>
        public virtual IAsyncResult BeginStartDBInstance(StartDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDBInstance.</param>
        /// 
        /// <returns>Returns a  StartDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstance">REST API Reference for StartDBInstance Operation</seealso>
        public virtual StartDBInstanceResponse EndStartDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDBInstanceAutomatedBackupsReplication

        /// <summary>
        /// Enables replication of automated backups to a different AWS Region.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
        /// Replicating Automated Backups to Another AWS Region</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstanceAutomatedBackupsReplication service method.</param>
        /// 
        /// <returns>The response from the StartDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StartDBInstanceAutomatedBackupsReplicationResponse StartDBInstanceAutomatedBackupsReplication(StartDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceAutomatedBackupsReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDBInstanceAutomatedBackupsReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstanceAutomatedBackupsReplication operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDBInstanceAutomatedBackupsReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual IAsyncResult BeginStartDBInstanceAutomatedBackupsReplication(StartDBInstanceAutomatedBackupsReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDBInstanceAutomatedBackupsReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDBInstanceAutomatedBackupsReplication.</param>
        /// 
        /// <returns>Returns a  StartDBInstanceAutomatedBackupsReplicationResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StartDBInstanceAutomatedBackupsReplicationResponse EndStartDBInstanceAutomatedBackupsReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDBInstanceAutomatedBackupsReplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartExportTask

        /// <summary>
        /// Starts an export of a snapshot to Amazon S3. The provided IAM role must have access
        /// to the S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ExportTaskAlreadyExistsException">
        /// You can't start an export task that's already running.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IamRoleMissingPermissionsException">
        /// The IAM role requires additional permissions to export to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IamRoleNotFoundException">
        /// The IAM role is missing for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportOnlyException">
        /// The export is invalid for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportSourceStateException">
        /// The state of the export snapshot is invalid for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an AWS KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual IAsyncResult BeginStartExportTask(StartExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExportTask.</param>
        /// 
        /// <returns>Returns a  StartExportTaskResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual StartExportTaskResponse EndStartExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  StopActivityStream

        /// <summary>
        /// Stops a database activity stream that was started using the AWS console, the <code>start-activity-stream</code>
        /// AWS CLI command, or the <code>StartActivityStream</code> action.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">Database
        /// Activity Streams</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopActivityStream service method.</param>
        /// 
        /// <returns>The response from the StopActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopActivityStream">REST API Reference for StopActivityStream Operation</seealso>
        public virtual StopActivityStreamResponse StopActivityStream(StopActivityStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StopActivityStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopActivityStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopActivityStream operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopActivityStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopActivityStream">REST API Reference for StopActivityStream Operation</seealso>
        public virtual IAsyncResult BeginStopActivityStream(StopActivityStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopActivityStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopActivityStream.</param>
        /// 
        /// <returns>Returns a  StopActivityStreamResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopActivityStream">REST API Reference for StopActivityStream Operation</seealso>
        public virtual StopActivityStreamResponse EndStopActivityStream(IAsyncResult asyncResult)
        {
            return EndInvoke<StopActivityStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDBCluster

        /// <summary>
        /// Stops an Amazon Aurora DB cluster. When you stop a DB cluster, Aurora retains the
        /// DB cluster's metadata, including its endpoints and DB parameter groups. Aurora also
        /// retains the transaction logs so you can do a point-in-time restore if necessary. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide.</i>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual StopDBClusterResponse StopDBCluster(StopDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return Invoke<StopDBClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDBCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual IAsyncResult BeginStopDBCluster(StopDBClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  StopDBClusterResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual StopDBClusterResponse EndStopDBCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDBClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDBInstance

        /// <summary>
        /// Stops an Amazon RDS DB instance. When you stop a DB instance, Amazon RDS retains
        /// the DB instance's metadata, including its endpoint, DB parameter group, and option
        /// group membership. Amazon RDS also retains the transaction logs so you can do a point-in-time
        /// restore if necessary. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StopInstance.html">
        /// Stopping an Amazon RDS DB Instance Temporarily</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora clusters,
        /// use <code>StopDBCluster</code> instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstance service method.</param>
        /// 
        /// <returns>The response from the StopDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstance">REST API Reference for StopDBInstance Operation</seealso>
        public virtual StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstance operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDBInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstance">REST API Reference for StopDBInstance Operation</seealso>
        public virtual IAsyncResult BeginStopDBInstance(StopDBInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDBInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDBInstance.</param>
        /// 
        /// <returns>Returns a  StopDBInstanceResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstance">REST API Reference for StopDBInstance Operation</seealso>
        public virtual StopDBInstanceResponse EndStopDBInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDBInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDBInstanceAutomatedBackupsReplication

        /// <summary>
        /// Stops automated backup replication for a DB instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
        /// Replicating Automated Backups to Another AWS Region</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstanceAutomatedBackupsReplication service method.</param>
        /// 
        /// <returns>The response from the StopDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StopDBInstanceAutomatedBackupsReplicationResponse StopDBInstanceAutomatedBackupsReplication(StopDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceAutomatedBackupsReplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDBInstanceAutomatedBackupsReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstanceAutomatedBackupsReplication operation on AmazonRDSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDBInstanceAutomatedBackupsReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual IAsyncResult BeginStopDBInstanceAutomatedBackupsReplication(StopDBInstanceAutomatedBackupsReplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDBInstanceAutomatedBackupsReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDBInstanceAutomatedBackupsReplication.</param>
        /// 
        /// <returns>Returns a  StopDBInstanceAutomatedBackupsReplicationResult from RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StopDBInstanceAutomatedBackupsReplicationResponse EndStopDBInstanceAutomatedBackupsReplication(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDBInstanceAutomatedBackupsReplicationResponse>(asyncResult);
        }

        #endregion
        
    }
}
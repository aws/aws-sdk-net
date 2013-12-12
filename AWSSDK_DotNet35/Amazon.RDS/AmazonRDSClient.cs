/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing AmazonRDS.
    ///  
    /// Amazon Relational Database Service <para> Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up,
    /// operate, and scale a relational database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational
    /// database and manages common database administration tasks, freeing up developers to focus on what makes their applications and businesses
    /// unique. </para> <para> Amazon RDS gives you access to the capabilities of a familiar MySQL or Oracle database server. This means the code,
    /// applications, and tools you already use today with your existing MySQL or Oracle databases work with Amazon RDS without modification. Amazon
    /// RDS automatically backs up your database and maintains the database software that powers your DB instance. Amazon RDS is flexible: you can
    /// scale your database instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. </para> <para> This is an interface reference for Amazon RDS.
    /// It contains documentation for a programming or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling or callback functions to determine when a command has
    /// been applied. In this reference, the parameter descriptions indicate whether a command is applied immediately, on the next instance reboot,
    /// or during the maintenance window. For a summary of the Amazon RDS interfaces, go to <a
    /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces" >Available RDS Interfaces</a> .
    /// </para>
    /// </summary>
    public partial class AmazonRDSClient : AmazonWebServiceClient, IAmazonRDS
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
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDS Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region AddSourceIdentifierToSubscription

        /// <summary>
        /// <para>Adds a source identifier to an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="addSourceIdentifierToSubscriptionRequest">Container for the necessary parameters to execute the
        ///          AddSourceIdentifierToSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SourceNotFoundException"/>
        /// <exception cref="SubscriptionNotFoundException"/>
        public AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest addSourceIdentifierToSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeAddSourceIdentifierToSubscription(addSourceIdentifierToSubscriptionRequest, null, null, true);
            return EndAddSourceIdentifierToSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddSourceIdentifierToSubscription"/>
        /// </summary>
        /// 
        /// <param name="addSourceIdentifierToSubscriptionRequest">Container for the necessary parameters to execute the
        ///          AddSourceIdentifierToSubscription operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAddSourceIdentifierToSubscription operation.</returns>
        public IAsyncResult BeginAddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest addSourceIdentifierToSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeAddSourceIdentifierToSubscription(addSourceIdentifierToSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddSourceIdentifierToSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddSourceIdentifierToSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRDS.</returns>
        public AddSourceIdentifierToSubscriptionResponse EndAddSourceIdentifierToSubscription(IAsyncResult asyncResult)
        {
            return endOperation<AddSourceIdentifierToSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest addSourceIdentifierToSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddSourceIdentifierToSubscriptionRequestMarshaller().Marshall(addSourceIdentifierToSubscriptionRequest);
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AddTagsToResource

        /// <summary>
        /// <para> Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost allocation reporting to track cost associated
        /// with Amazon RDS resources, or used in Condition statement in IAM policy for Amazon RDS.</para> <para>For an overview on tagging Amazon RDS
        /// resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html" >Tagging Amazon RDS Resources</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="addTagsToResourceRequest">Container for the necessary parameters to execute the AddTagsToResource service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest addTagsToResourceRequest)
        {
            IAsyncResult asyncResult = invokeAddTagsToResource(addTagsToResourceRequest, null, null, true);
            return EndAddTagsToResource(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddTagsToResource"/>
        /// </summary>
        /// 
        /// <param name="addTagsToResourceRequest">Container for the necessary parameters to execute the AddTagsToResource operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest addTagsToResourceRequest, AsyncCallback callback, object state)
        {
            return invokeAddTagsToResource(addTagsToResourceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddTagsToResource"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        public AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return endOperation<AddTagsToResourceResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddTagsToResource(AddTagsToResourceRequest addTagsToResourceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddTagsToResourceRequestMarshaller().Marshall(addTagsToResourceRequest);
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AuthorizeDBSecurityGroupIngress

        /// <summary>
        /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC security groups can be added to the
        /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
        /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
        /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
        /// ingress from an EC2 security group in one Region to an Amazon RDS DB instance in another. You cannot authorize ingress from a VPC security
        /// group in one VPC to an Amazon RDS DB instance in another. </para> <para>For an overview of CIDR ranges, go to the <a
        /// href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing" >Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="AuthorizationAlreadyExistsException"/>
        /// <exception cref="AuthorizationQuotaExceededException"/>
        public AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeAuthorizeDBSecurityGroupIngress(authorizeDBSecurityGroupIngressRequest, null, null, true);
            return EndAuthorizeDBSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AuthorizeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAuthorizeDBSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeAuthorizeDBSecurityGroupIngress(authorizeDBSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AuthorizeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public AuthorizeDBSecurityGroupIngressResponse EndAuthorizeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<AuthorizeDBSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AuthorizeDBSecurityGroupIngressRequestMarshaller().Marshall(authorizeDBSecurityGroupIngressRequest);
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CopyDBSnapshot

        /// <summary>
        /// <para> Copies the specified DBSnapshot. The source DBSnapshot must be in the "available" state. </para>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCopyDBSnapshot(copyDBSnapshotRequest, null, null, true);
            return EndCopyDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CopyDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCopyDBSnapshot(copyDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CopyDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public CopyDBSnapshotResponse EndCopyDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CopyDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopyDBSnapshot(CopyDBSnapshotRequest copyDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopyDBSnapshotRequestMarshaller().Marshall(copyDBSnapshotRequest);
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBInstance

        /// <summary>
        /// <para> Creates a new DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException"/>
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBInstance(createDBInstanceRequest, null, null, true);
            return EndCreateDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstance"/>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginCreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBInstance(createDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public CreateDBInstanceResponse EndCreateDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBInstanceRequestMarshaller().Marshall(createDBInstanceRequest);
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBInstanceReadReplica

        /// <summary>
        /// <para> Creates a DB instance that acts as a read replica of a source DB instance. </para> <para> All read replica DB instances are created
        /// as Single-AZ deployments with backups disabled. All other DB instance attributes (including DB security groups and DB parameter groups) are
        /// inherited from the source DB instance, except as specified below. </para> <para><b>IMPORTANT:</b> The source DB instance must have backup
        /// retention enabled. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBSubnetGroupException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotAllowedException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException"/>
        public CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBInstanceReadReplica(createDBInstanceReadReplicaRequest, null, null, true);
            return EndCreateDBInstanceReadReplica(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstanceReadReplica"/>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBInstanceReadReplica operation.</returns>
        public IAsyncResult BeginCreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBInstanceReadReplica(createDBInstanceReadReplicaRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstanceReadReplica"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBInstanceReadReplica.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public CreateDBInstanceReadReplicaResponse EndCreateDBInstanceReadReplica(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBInstanceReadReplicaResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBInstanceReadReplicaRequestMarshaller().Marshall(createDBInstanceReadReplicaRequest);
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBParameterGroup

        /// <summary>
        /// <para> Creates a new DB parameter group. </para> <para> A DB parameter group is initially created with the default parameters for the
        /// database engine used by the DB instance. To provide custom values for any of the parameters, you must modify the group after creating it
        /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB parameter group, you need to associate it with your DB instance using
        /// <i>ModifyDBInstance</i> . When you associate a new DB parameter group with a running DB instance, you need to reboot the DB Instance for the
        /// new DB parameter group and associated settings to take effect. </para>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupQuotaExceededException"/>
        /// <exception cref="DBParameterGroupAlreadyExistsException"/>
        public CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBParameterGroup(createDBParameterGroupRequest, null, null, true);
            return EndCreateDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBParameterGroup operation.</returns>
        public IAsyncResult BeginCreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBParameterGroup(createDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBParameterGroup.</param>
        /// 
        /// <returns>Returns a DBParameterGroup from AmazonRDS.</returns>
        public CreateDBParameterGroupResponse EndCreateDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBParameterGroupRequestMarshaller().Marshall(createDBParameterGroupRequest);
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSecurityGroup

        /// <summary>
        /// <para> Creates a new DB security group. DB security groups control access to a DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupQuotaExceededException"/>
        /// <exception cref="DBSecurityGroupNotSupportedException"/>
        /// <exception cref="DBSecurityGroupAlreadyExistsException"/>
        public CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSecurityGroup(createDBSecurityGroupRequest, null, null, true);
            return EndCreateDBSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBSecurityGroup operation.</returns>
        public IAsyncResult BeginCreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSecurityGroup(createDBSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSecurityGroup.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public CreateDBSecurityGroupResponse EndCreateDBSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSecurityGroupRequestMarshaller().Marshall(createDBSecurityGroupRequest);
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSnapshot

        /// <summary>
        /// <para> Creates a DBSnapshot. The source DBInstance must be in "available" state. </para>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        public CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSnapshot(createDBSnapshotRequest, null, null, true);
            return EndCreateDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSnapshot(createDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public CreateDBSnapshotResponse EndCreateDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSnapshotRequestMarshaller().Marshall(createDBSnapshotRequest);
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDBSubnetGroup

        /// <summary>
        /// <para> Creates a new DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupAlreadyExistsException"/>
        /// <exception cref="DBSubnetGroupQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InvalidSubnetException"/>
        public CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateDBSubnetGroup(createDBSubnetGroupRequest, null, null, true);
            return EndCreateDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateDBSubnetGroup operation.</returns>
        public IAsyncResult BeginCreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDBSubnetGroup(createDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a DBSubnetGroup from AmazonRDS.</returns>
        public CreateDBSubnetGroupResponse EndCreateDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDBSubnetGroup(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDBSubnetGroupRequestMarshaller().Marshall(createDBSubnetGroupRequest);
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateEventSubscription

        /// <summary>
        /// <para>Creates an RDS event notification subscription. This action requires a topic ARN (Amazon Resource Name) created by either the RDS
        /// console, the SNS console, or the SNS API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to the topic. The
        /// ARN is displayed in the SNS console.</para> <para>You can specify the type of source (SourceType) you want to be notified of, provide a list
        /// of RDS sources (SourceIds) that triggers the events, and provide a list of event categories (EventCategories) for events you want to be
        /// notified of. For example, you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2 and EventCategories =
        /// Availability, Backup.</para> <para>If you specify both the SourceType and SourceIds, such as SourceType = db-instance and SourceIdentifier =
        /// myDBInstance1, you will be notified of all the db-instance events for the specified source. If you specify a SourceType but do not specify a
        /// SourceIdentifier, you will receive notice of the events for that source type for all your RDS sources. If you do not specify either the
        /// SourceType nor the SourceIdentifier, you will be notified of events generated from all RDS sources belonging to your customer
        /// account.</para>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SourceNotFoundException"/>
        /// <exception cref="SNSTopicArnNotFoundException"/>
        /// <exception cref="SNSInvalidTopicException"/>
        /// <exception cref="SubscriptionCategoryNotFoundException"/>
        /// <exception cref="SNSNoAuthorizationException"/>
        /// <exception cref="EventSubscriptionQuotaExceededException"/>
        /// <exception cref="SubscriptionAlreadyExistException"/>
        public CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest createEventSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeCreateEventSubscription(createEventSubscriptionRequest, null, null, true);
            return EndCreateEventSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateEventSubscription operation.</returns>
        public IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest createEventSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateEventSubscription(createEventSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRDS.</returns>
        public CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation<CreateEventSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateEventSubscription(CreateEventSubscriptionRequest createEventSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateEventSubscriptionRequestMarshaller().Marshall(createEventSubscriptionRequest);
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateOptionGroup

        /// <summary>
        /// <para> Creates a new option group. You can create up to 20 option groups. </para>
        /// </summary>
        /// 
        /// <param name="createOptionGroupRequest">Container for the necessary parameters to execute the CreateOptionGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="OptionGroupAlreadyExistsException"/>
        /// <exception cref="OptionGroupQuotaExceededException"/>
        public CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest createOptionGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateOptionGroup(createOptionGroupRequest, null, null, true);
            return EndCreateOptionGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="createOptionGroupRequest">Container for the necessary parameters to execute the CreateOptionGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOptionGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateOptionGroup(CreateOptionGroupRequest createOptionGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateOptionGroup(createOptionGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOptionGroup.</param>
        /// 
        /// <returns>Returns a OptionGroup from AmazonRDS.</returns>
        public CreateOptionGroupResponse EndCreateOptionGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateOptionGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateOptionGroup(CreateOptionGroupRequest createOptionGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateOptionGroupRequestMarshaller().Marshall(createOptionGroupRequest);
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBInstance

        /// <summary>
        /// <para> The DeleteDBInstance action deletes a previously provisioned DB instance. A successful response from the web service indicates the
        /// request was received correctly. When you delete a DB instance, all automated backups for that instance are deleted and cannot be recovered.
        /// Manual DB snapshots of the DB instance to be deleted are not deleted. </para> <para> If a final DB snapshot is requested the status of the
        /// RDS instance will be "deleting" until the DB snapshot is created. The API action <c>DescribeDBInstance</c> is used to monitor the status of
        /// this operation. The action cannot be canceled or reverted once submitted. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="SnapshotQuotaExceededException"/>
        /// <exception cref="DBSnapshotAlreadyExistsException"/>
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBInstance(deleteDBInstanceRequest, null, null, true);
            return EndDeleteDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBInstance"/>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBInstance(deleteDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public DeleteDBInstanceResponse EndDeleteDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBInstanceRequestMarshaller().Marshall(deleteDBInstanceRequest);
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBParameterGroup

        /// <summary>
        /// <para> Deletes a specified DBParameterGroup. The DBParameterGroup cannot be associated with any RDS instances to be deleted. </para>
        /// <para><b>NOTE:</b> The specified DB parameter group cannot be associated with any DB instances. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBParameterGroup(deleteDBParameterGroupRequest, null, null, true);
            return EndDeleteDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBParameterGroup(deleteDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBParameterGroup.</param>
        public DeleteDBParameterGroupResponse EndDeleteDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBParameterGroupRequestMarshaller().Marshall(deleteDBParameterGroupRequest);
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBSecurityGroup

        /// <summary>
        /// <para> Deletes a DB security group. </para> <para><b>NOTE:</b>The specified DB security group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        public DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSecurityGroup(deleteDBSecurityGroupRequest, null, null, true);
            return EndDeleteDBSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSecurityGroup(deleteDBSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSecurityGroup.</param>
        public DeleteDBSecurityGroupResponse EndDeleteDBSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSecurityGroupRequestMarshaller().Marshall(deleteDBSecurityGroupRequest);
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBSnapshot

        /// <summary>
        /// <para> Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated. </para> <para><b>NOTE:</b>The DBSnapshot
        /// must be in the available state to be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSnapshot(deleteDBSnapshotRequest, null, null, true);
            return EndDeleteDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDBSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSnapshot(deleteDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBSnapshot from AmazonRDS.</returns>
        public DeleteDBSnapshotResponse EndDeleteDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSnapshotRequestMarshaller().Marshall(deleteDBSnapshotRequest);
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDBSubnetGroup

        /// <summary>
        /// <para> Deletes a DB subnet group. </para> <para><b>NOTE:</b>The specified database subnet group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="InvalidDBSubnetGroupStateException"/>
        /// <exception cref="InvalidDBSubnetStateException"/>
        public DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDBSubnetGroup(deleteDBSubnetGroupRequest, null, null, true);
            return EndDeleteDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDBSubnetGroup(deleteDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDBSubnetGroup.</param>
        public DeleteDBSubnetGroupResponse EndDeleteDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDBSubnetGroup(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDBSubnetGroupRequestMarshaller().Marshall(deleteDBSubnetGroupRequest);
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteEventSubscription

        /// <summary>
        /// <para>Deletes an RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        /// <exception cref="InvalidEventSubscriptionStateException"/>
        public DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteEventSubscription(deleteEventSubscriptionRequest, null, null, true);
            return EndDeleteEventSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteEventSubscription operation.</returns>
        public IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteEventSubscription(deleteEventSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRDS.</returns>
        public DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation<DeleteEventSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteEventSubscription(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteEventSubscriptionRequestMarshaller().Marshall(deleteEventSubscriptionRequest);
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteOptionGroup

        /// <summary>
        /// <para> Deletes an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="deleteOptionGroupRequest">Container for the necessary parameters to execute the DeleteOptionGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="InvalidOptionGroupStateException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        public DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest deleteOptionGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteOptionGroup(deleteOptionGroupRequest, null, null, true);
            return EndDeleteOptionGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteOptionGroupRequest">Container for the necessary parameters to execute the DeleteOptionGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteOptionGroup(DeleteOptionGroupRequest deleteOptionGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteOptionGroup(deleteOptionGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOptionGroup.</param>
        public DeleteOptionGroupResponse EndDeleteOptionGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteOptionGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteOptionGroup(DeleteOptionGroupRequest deleteOptionGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteOptionGroupRequestMarshaller().Marshall(deleteOptionGroupRequest);
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBEngineVersions

        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        ///          on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBEngineVersions(describeDBEngineVersionsRequest, null, null, true);
            return EndDescribeDBEngineVersions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBEngineVersions operation.</returns>
        public IAsyncResult BeginDescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBEngineVersions(describeDBEngineVersionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBEngineVersions.</param>
        /// 
        /// <returns>Returns a DescribeDBEngineVersionsResult from AmazonRDS.</returns>
        public DescribeDBEngineVersionsResponse EndDescribeDBEngineVersions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBEngineVersionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBEngineVersionsRequestMarshaller().Marshall(describeDBEngineVersionsRequest);
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
        

        #endregion
    
        #region DescribeDBInstances

        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBInstances(describeDBInstancesRequest, null, null, true);
            return EndDescribeDBInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBInstances"/>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBInstances operation.</returns>
        public IAsyncResult BeginDescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBInstances(describeDBInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBInstances.</param>
        /// 
        /// <returns>Returns a DescribeDBInstancesResult from AmazonRDS.</returns>
        public DescribeDBInstancesResponse EndDescribeDBInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBInstancesRequestMarshaller().Marshall(describeDBInstancesRequest);
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }
        

        #endregion
    
        #region DescribeDBLogFiles

        /// <summary>
        /// <para> Returns a list of DB log files for the DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest describeDBLogFilesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBLogFiles(describeDBLogFilesRequest, null, null, true);
            return EndDescribeDBLogFiles(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBLogFiles"/>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBLogFiles operation.</returns>
        public IAsyncResult BeginDescribeDBLogFiles(DescribeDBLogFilesRequest describeDBLogFilesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBLogFiles(describeDBLogFilesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBLogFiles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBLogFiles.</param>
        /// 
        /// <returns>Returns a DescribeDBLogFilesResult from AmazonRDS.</returns>
        public DescribeDBLogFilesResponse EndDescribeDBLogFiles(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBLogFilesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBLogFiles(DescribeDBLogFilesRequest describeDBLogFilesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBLogFilesRequestMarshaller().Marshall(describeDBLogFilesRequest);
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBParameterGroups

        /// <summary>
        /// <para> Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c> is specified, the list will contain only the
        /// description of the specified DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBParameterGroups(describeDBParameterGroupsRequest, null, null, true);
            return EndDescribeDBParameterGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBParameterGroups operation.</returns>
        public IAsyncResult BeginDescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBParameterGroups(describeDBParameterGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameterGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBParameterGroupsResult from AmazonRDS.</returns>
        public DescribeDBParameterGroupsResponse EndDescribeDBParameterGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBParameterGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBParameterGroupsRequestMarshaller().Marshall(describeDBParameterGroupsRequest);
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c> is specified, the list will contain only the
        /// description of the specified DB parameter group. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
        

        #endregion
    
        #region DescribeDBParameters

        /// <summary>
        /// <para> Returns the detailed parameter list for a particular DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        public DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBParameters(describeDBParametersRequest, null, null, true);
            return EndDescribeDBParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameters"/>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBParameters operation.</returns>
        public IAsyncResult BeginDescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBParameters(describeDBParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBParameters.</param>
        /// 
        /// <returns>Returns a DescribeDBParametersResult from AmazonRDS.</returns>
        public DescribeDBParametersResponse EndDescribeDBParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBParametersRequestMarshaller().Marshall(describeDBParametersRequest);
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeDBSecurityGroups

        /// <summary>
        /// <para> Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c> is specified, the list will contain only the
        /// descriptions of the specified DB security group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        ///          on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSecurityGroups(describeDBSecurityGroupsRequest, null, null, true);
            return EndDescribeDBSecurityGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSecurityGroups operation.</returns>
        public IAsyncResult BeginDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSecurityGroups(describeDBSecurityGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBSecurityGroupsResult from AmazonRDS.</returns>
        public DescribeDBSecurityGroupsResponse EndDescribeDBSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSecurityGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSecurityGroupsRequestMarshaller().Marshall(describeDBSecurityGroupsRequest);
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c> is specified, the list will contain only the
        /// descriptions of the specified DB security group. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
        

        #endregion
    
        #region DescribeDBSnapshots

        /// <summary>
        /// <para> Returns information about DB snapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSnapshots(describeDBSnapshotsRequest, null, null, true);
            return EndDescribeDBSnapshots(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSnapshots"/>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSnapshots operation.</returns>
        public IAsyncResult BeginDescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSnapshots(describeDBSnapshotsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSnapshots"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSnapshots.</param>
        /// 
        /// <returns>Returns a DescribeDBSnapshotsResult from AmazonRDS.</returns>
        public DescribeDBSnapshotsResponse EndDescribeDBSnapshots(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSnapshotsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSnapshotsRequestMarshaller().Marshall(describeDBSnapshotsRequest);
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about DB snapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSnapshotNotFoundException"/>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
        

        #endregion
    
        #region DescribeDBSubnetGroups

        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the <a
        /// href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing" >Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDBSubnetGroups(describeDBSubnetGroupsRequest, null, null, true);
            return EndDescribeDBSubnetGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDBSubnetGroups operation.</returns>
        public IAsyncResult BeginDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDBSubnetGroups(describeDBSubnetGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDBSubnetGroups.</param>
        /// 
        /// <returns>Returns a DescribeDBSubnetGroupsResult from AmazonRDS.</returns>
        public DescribeDBSubnetGroupsResponse EndDescribeDBSubnetGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDBSubnetGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDBSubnetGroupsRequestMarshaller().Marshall(describeDBSubnetGroupsRequest);
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the <a
        /// href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing" >Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
        

        #endregion
    
        #region DescribeEngineDefaultParameters

        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified database engine. </para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, null, null, true);
            return EndDescribeEngineDefaultParameters(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEngineDefaultParameters operation.</returns>
        public IAsyncResult BeginDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEngineDefaultParameters(describeEngineDefaultParametersRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineDefaultParameters.</param>
        /// 
        /// <returns>Returns a EngineDefaults from AmazonRDS.</returns>
        public DescribeEngineDefaultParametersResponse EndDescribeEngineDefaultParameters(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEngineDefaultParametersResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEngineDefaultParametersRequestMarshaller().Marshall(describeEngineDefaultParametersRequest);
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeEventCategories

        /// <summary>
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html" > Events</a> topic
        /// in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest describeEventCategoriesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEventCategories(describeEventCategoriesRequest, null, null, true);
            return EndDescribeEventCategories(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEventCategories operation.</returns>
        public IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest describeEventCategoriesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEventCategories(describeEventCategoriesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a DescribeEventCategoriesResult from AmazonRDS.</returns>
        public DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventCategoriesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEventCategories(DescribeEventCategoriesRequest describeEventCategoriesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventCategoriesRequestMarshaller().Marshall(describeEventCategoriesRequest);
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html" > Events</a> topic
        /// in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        

        #endregion
    
        #region DescribeEventSubscriptions

        /// <summary>
        /// <para>Lists all the subscription descriptions for a customer account. The description for a subscription includes SubscriptionName,
        /// SNSTopicARN, CustomerID, SourceType, SourceID, CreationTime, and Status. </para> <para>If you specify a SubscriptionName, lists the
        /// description for that subscription.</para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEventSubscriptions(describeEventSubscriptionsRequest, null, null, true);
            return EndDescribeEventSubscriptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeEventSubscriptions operation.</returns>
        public IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEventSubscriptions(describeEventSubscriptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a DescribeEventSubscriptionsResult from AmazonRDS.</returns>
        public DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventSubscriptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEventSubscriptions(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventSubscriptionsRequestMarshaller().Marshall(describeEventSubscriptionsRequest);
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Lists all the subscription descriptions for a customer account. The description for a subscription includes SubscriptionName,
        /// SNSTopicARN, CustomerID, SourceType, SourceID, CreationTime, and Status. </para> <para>If you specify a SubscriptionName, lists the
        /// description for that subscription.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SubscriptionNotFoundException"/>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        

        #endregion
    
        #region DescribeEvents

        /// <summary>
        /// <para> Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter groups for the past 14 days. Events
        /// specific to a particular DB instance, DB security group, database snapshot, or DB parameter group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(describeEventsRequest, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(describeEventsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a DescribeEventsResult from AmazonRDS.</returns>
        public DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation<DescribeEventsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeEvents(DescribeEventsRequest describeEventsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeEventsRequestMarshaller().Marshall(describeEventsRequest);
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter groups for the past 14 days. Events
        /// specific to a particular DB instance, DB security group, database snapshot, or DB parameter group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        

        #endregion
    
        #region DescribeOptionGroupOptions

        /// <summary>
        /// <para> Describes all available options. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupOptionsRequest">Container for the necessary parameters to execute the DescribeOptionGroupOptions service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest describeOptionGroupOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOptionGroupOptions(describeOptionGroupOptionsRequest, null, null, true);
            return EndDescribeOptionGroupOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroupOptions"/>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupOptionsRequest">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOptionGroupOptions operation.</returns>
        public IAsyncResult BeginDescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest describeOptionGroupOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOptionGroupOptions(describeOptionGroupOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroupOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptionGroupOptions.</param>
        /// 
        /// <returns>Returns a DescribeOptionGroupOptionsResult from AmazonRDS.</returns>
        public DescribeOptionGroupOptionsResponse EndDescribeOptionGroupOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOptionGroupOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest describeOptionGroupOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOptionGroupOptionsRequestMarshaller().Marshall(describeOptionGroupOptionsRequest);
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeOptionGroups

        /// <summary>
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="OptionGroupNotFoundException"/>
        public DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest describeOptionGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOptionGroups(describeOptionGroupsRequest, null, null, true);
            return EndDescribeOptionGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroups"/>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOptionGroups operation.</returns>
        public IAsyncResult BeginDescribeOptionGroups(DescribeOptionGroupsRequest describeOptionGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOptionGroups(describeOptionGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOptionGroups.</param>
        /// 
        /// <returns>Returns a DescribeOptionGroupsResult from AmazonRDS.</returns>
        public DescribeOptionGroupsResponse EndDescribeOptionGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOptionGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOptionGroups(DescribeOptionGroupsRequest describeOptionGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOptionGroupsRequestMarshaller().Marshall(describeOptionGroupsRequest);
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="OptionGroupNotFoundException"/>
        public DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }
        

        #endregion
    
        #region DescribeOrderableDBInstanceOptions

        /// <summary>
        /// <para> Returns a list of orderable DB instance options for the specified engine. </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        ///          DescribeOrderableDBInstanceOptions service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by AmazonRDS.</returns>
        /// 
        public DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOrderableDBInstanceOptions(describeOrderableDBInstanceOptionsRequest, null, null, true);
            return EndDescribeOrderableDBInstanceOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOrderableDBInstanceOptions"/>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        ///          DescribeOrderableDBInstanceOptions operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOrderableDBInstanceOptions operation.</returns>
        public IAsyncResult BeginDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOrderableDBInstanceOptions(describeOrderableDBInstanceOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOrderableDBInstanceOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableDBInstanceOptions.</param>
        /// 
        /// <returns>Returns a DescribeOrderableDBInstanceOptionsResult from AmazonRDS.</returns>
        public DescribeOrderableDBInstanceOptionsResponse EndDescribeOrderableDBInstanceOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOrderableDBInstanceOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOrderableDBInstanceOptionsRequestMarshaller().Marshall(describeOrderableDBInstanceOptionsRequest);
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeReservedDBInstances

        /// <summary>
        /// <para> Returns information about reserved DB instances for this account, or about a specified reserved DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstanceNotFoundException"/>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedDBInstances(describeReservedDBInstancesRequest, null, null, true);
            return EndDescribeReservedDBInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstances"/>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances operation
        ///          on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedDBInstances operation.</returns>
        public IAsyncResult BeginDescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedDBInstances(describeReservedDBInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstances.</param>
        /// 
        /// <returns>Returns a DescribeReservedDBInstancesResult from AmazonRDS.</returns>
        public DescribeReservedDBInstancesResponse EndDescribeReservedDBInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedDBInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedDBInstancesRequestMarshaller().Marshall(describeReservedDBInstancesRequest);
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about reserved DB instances for this account, or about a specified reserved DB instance. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstanceNotFoundException"/>
        public DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
        

        #endregion
    
        #region DescribeReservedDBInstancesOfferings

        /// <summary>
        /// <para> Lists available reserved DB instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedDBInstancesOfferings(describeReservedDBInstancesOfferingsRequest, null, null, true);
            return EndDescribeReservedDBInstancesOfferings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedDBInstancesOfferings operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedDBInstancesOfferings operation.</returns>
        public IAsyncResult BeginDescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedDBInstancesOfferings(describeReservedDBInstancesOfferingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedDBInstancesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedDBInstancesOfferingsResult from AmazonRDS.</returns>
        public DescribeReservedDBInstancesOfferingsResponse EndDescribeReservedDBInstancesOfferings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedDBInstancesOfferingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedDBInstancesOfferingsRequestMarshaller().Marshall(describeReservedDBInstancesOfferingsRequest);
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Lists available reserved DB instance offerings. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
        

        #endregion
    
        #region DownloadDBLogFilePortion

        /// <summary>
        /// <para> Downloads the last line of the specified log file. </para>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method
        ///          on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        public DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest)
        {
            IAsyncResult asyncResult = invokeDownloadDBLogFilePortion(downloadDBLogFilePortionRequest, null, null, true);
            return EndDownloadDBLogFilePortion(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DownloadDBLogFilePortion"/>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDownloadDBLogFilePortion operation.</returns>
        public IAsyncResult BeginDownloadDBLogFilePortion(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest, AsyncCallback callback, object state)
        {
            return invokeDownloadDBLogFilePortion(downloadDBLogFilePortionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DownloadDBLogFilePortion"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadDBLogFilePortion.</param>
        /// 
        /// <returns>Returns a DownloadDBLogFilePortionResult from AmazonRDS.</returns>
        public DownloadDBLogFilePortionResponse EndDownloadDBLogFilePortion(IAsyncResult asyncResult)
        {
            return endOperation<DownloadDBLogFilePortionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDownloadDBLogFilePortion(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DownloadDBLogFilePortionRequestMarshaller().Marshall(downloadDBLogFilePortionRequest);
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListTagsForResource

        /// <summary>
        /// <para> Lists all tags on an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html" >Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="listTagsForResourceRequest">Container for the necessary parameters to execute the ListTagsForResource service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest listTagsForResourceRequest)
        {
            IAsyncResult asyncResult = invokeListTagsForResource(listTagsForResourceRequest, null, null, true);
            return EndListTagsForResource(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ListTagsForResource"/>
        /// </summary>
        /// 
        /// <param name="listTagsForResourceRequest">Container for the necessary parameters to execute the ListTagsForResource operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListTagsForResource operation.</returns>
        public IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest listTagsForResourceRequest, AsyncCallback callback, object state)
        {
            return invokeListTagsForResource(listTagsForResourceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ListTagsForResource"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a ListTagsForResourceResult from AmazonRDS.</returns>
        public ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return endOperation<ListTagsForResourceResponse>(asyncResult);
        }
        
        IAsyncResult invokeListTagsForResource(ListTagsForResourceRequest listTagsForResourceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListTagsForResourceRequestMarshaller().Marshall(listTagsForResourceRequest);
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyDBInstance

        /// <summary>
        /// <para> Modify settings for a DB instance. You can change one or more database configuration parameters by specifying these parameters and
        /// the new values in the request. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="DBUpgradeDependencyFailureException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException"/>
        public ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBInstance(modifyDBInstanceRequest, null, null, true);
            return EndModifyDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBInstance"/>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBInstance(modifyDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public ModifyDBInstanceResponse EndModifyDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBInstanceRequestMarshaller().Marshall(modifyDBInstanceRequest);
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyDBParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a DB parameter group. To modify more than one parameter, submit a list of the following:
        /// <c>ParameterName</c> ,
        /// <c>ParameterValue</c> , and <c>ApplyMethod</c> . A maximum of 20 parameters can be modified in a single request. </para>
        /// <para><b>NOTE:</b> The apply-immediate method can be used only for dynamic parameters; the pending-reboot method can be used with MySQL and
        /// Oracle DB instances for either dynamic or static parameters. For Microsoft SQL Server DB instances, the pending-reboot method can be used
        /// only for static parameters. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBParameterGroup(modifyDBParameterGroupRequest, null, null, true);
            return EndModifyDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyDBParameterGroup operation.</returns>
        public IAsyncResult BeginModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBParameterGroup(modifyDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBParameterGroup.</param>
        /// 
        /// <returns>Returns a ModifyDBParameterGroupResult from AmazonRDS.</returns>
        public ModifyDBParameterGroupResponse EndModifyDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBParameterGroupRequestMarshaller().Marshall(modifyDBParameterGroupRequest);
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyDBSubnetGroup

        /// <summary>
        /// <para> Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBSubnetQuotaExceededException"/>
        /// <exception cref="SubnetAlreadyInUseException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InvalidSubnetException"/>
        public ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyDBSubnetGroup(modifyDBSubnetGroupRequest, null, null, true);
            return EndModifyDBSubnetGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyDBSubnetGroup operation.</returns>
        public IAsyncResult BeginModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyDBSubnetGroup(modifyDBSubnetGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyDBSubnetGroup.</param>
        /// 
        /// <returns>Returns a DBSubnetGroup from AmazonRDS.</returns>
        public ModifyDBSubnetGroupResponse EndModifyDBSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyDBSubnetGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyDBSubnetGroup(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyDBSubnetGroupRequestMarshaller().Marshall(modifyDBSubnetGroupRequest);
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyEventSubscription

        /// <summary>
        /// <para>Modifies an existing RDS event notification subscription. Note that you cannot modify the source identifiers using this call; to
        /// change source identifiers for a subscription, use the AddSourceIdentifierToSubscription and RemoveSourceIdentifierFromSubscription
        /// calls.</para> <para>You can see a list of the event categories for a given SourceType in the <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html" >Events</a> topic in the Amazon RDS User Guide or by using the
        /// <b>DescribeEventCategories</b> action.</para>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SNSTopicArnNotFoundException"/>
        /// <exception cref="SNSInvalidTopicException"/>
        /// <exception cref="SubscriptionCategoryNotFoundException"/>
        /// <exception cref="SubscriptionNotFoundException"/>
        /// <exception cref="SNSNoAuthorizationException"/>
        /// <exception cref="EventSubscriptionQuotaExceededException"/>
        public ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeModifyEventSubscription(modifyEventSubscriptionRequest, null, null, true);
            return EndModifyEventSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyEventSubscription operation.</returns>
        public IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeModifyEventSubscription(modifyEventSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRDS.</returns>
        public ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation<ModifyEventSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyEventSubscription(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyEventSubscriptionRequestMarshaller().Marshall(modifyEventSubscriptionRequest);
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyOptionGroup

        /// <summary>
        /// <para> Modifies an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="modifyOptionGroupRequest">Container for the necessary parameters to execute the ModifyOptionGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidOptionGroupStateException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        public ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest modifyOptionGroupRequest)
        {
            IAsyncResult asyncResult = invokeModifyOptionGroup(modifyOptionGroupRequest, null, null, true);
            return EndModifyOptionGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="modifyOptionGroupRequest">Container for the necessary parameters to execute the ModifyOptionGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyOptionGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyOptionGroup(ModifyOptionGroupRequest modifyOptionGroupRequest, AsyncCallback callback, object state)
        {
            return invokeModifyOptionGroup(modifyOptionGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyOptionGroup.</param>
        /// 
        /// <returns>Returns a OptionGroup from AmazonRDS.</returns>
        public ModifyOptionGroupResponse EndModifyOptionGroup(IAsyncResult asyncResult)
        {
            return endOperation<ModifyOptionGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyOptionGroup(ModifyOptionGroupRequest modifyOptionGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyOptionGroupRequestMarshaller().Marshall(modifyOptionGroupRequest);
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PromoteReadReplica

        /// <summary>
        /// <para> Promotes a read replica DB instance to a standalone DB instance. </para>
        /// </summary>
        /// 
        /// <param name="promoteReadReplicaRequest">Container for the necessary parameters to execute the PromoteReadReplica service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        public PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest promoteReadReplicaRequest)
        {
            IAsyncResult asyncResult = invokePromoteReadReplica(promoteReadReplicaRequest, null, null, true);
            return EndPromoteReadReplica(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PromoteReadReplica"/>
        /// </summary>
        /// 
        /// <param name="promoteReadReplicaRequest">Container for the necessary parameters to execute the PromoteReadReplica operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPromoteReadReplica operation.</returns>
        public IAsyncResult BeginPromoteReadReplica(PromoteReadReplicaRequest promoteReadReplicaRequest, AsyncCallback callback, object state)
        {
            return invokePromoteReadReplica(promoteReadReplicaRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PromoteReadReplica"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteReadReplica.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public PromoteReadReplicaResponse EndPromoteReadReplica(IAsyncResult asyncResult)
        {
            return endOperation<PromoteReadReplicaResponse>(asyncResult);
        }
        
        IAsyncResult invokePromoteReadReplica(PromoteReadReplicaRequest promoteReadReplicaRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PromoteReadReplicaRequestMarshaller().Marshall(promoteReadReplicaRequest);
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PurchaseReservedDBInstancesOffering

        /// <summary>
        /// <para> Purchases a reserved DB instance offering. </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedDBInstancesOffering service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        /// <exception cref="ReservedDBInstanceQuotaExceededException"/>
        /// <exception cref="ReservedDBInstanceAlreadyExistsException"/>
        public PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest)
        {
            IAsyncResult asyncResult = invokePurchaseReservedDBInstancesOffering(purchaseReservedDBInstancesOfferingRequest, null, null, true);
            return EndPurchaseReservedDBInstancesOffering(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PurchaseReservedDBInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedDBInstancesOffering operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedDBInstancesOffering operation.</returns>
        public IAsyncResult BeginPurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedDBInstancesOffering(purchaseReservedDBInstancesOfferingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PurchaseReservedDBInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedDBInstancesOffering.</param>
        /// 
        /// <returns>Returns a ReservedDBInstance from AmazonRDS.</returns>
        public PurchaseReservedDBInstancesOfferingResponse EndPurchaseReservedDBInstancesOffering(IAsyncResult asyncResult)
        {
            return endOperation<PurchaseReservedDBInstancesOfferingResponse>(asyncResult);
        }
        
        IAsyncResult invokePurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PurchaseReservedDBInstancesOfferingRequestMarshaller().Marshall(purchaseReservedDBInstancesOfferingRequest);
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RebootDBInstance

        /// <summary>
        /// <para> Rebooting a DB instance restarts the database engine service. A reboot also applies to the DB instance any modifications to the
        /// associated DB parameter group that were pending. Rebooting a DB instance results in a momentary outage of the instance, during which the DB
        /// instance status is set to rebooting. If the RDS instance is configured for MultiAZ, it is possible that the reboot will be conducted through
        /// a failover. An Amazon RDS event is created when the reboot is completed. </para> <para> If your DB instance is deployed in multiple
        /// Availability Zones, you can force a failover from one AZ to the other during the reboot. You might force a failover to test the availability
        /// of your DB instance deployment or to restore operations to the original AZ after a failover occurs. </para> <para> The time required to
        /// reboot is a function of the specific database engine's crash recovery process. To improve the reboot time, we recommend that you reduce
        /// database activities as much as possible during the reboot process to reduce rollback activity for in-transit transactions. </para>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        public RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest)
        {
            IAsyncResult asyncResult = invokeRebootDBInstance(rebootDBInstanceRequest, null, null, true);
            return EndRebootDBInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RebootDBInstance"/>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootDBInstance
        ///         operation.</returns>
        public IAsyncResult BeginRebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeRebootDBInstance(rebootDBInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RebootDBInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootDBInstance.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RebootDBInstanceResponse EndRebootDBInstance(IAsyncResult asyncResult)
        {
            return endOperation<RebootDBInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootDBInstanceRequestMarshaller().Marshall(rebootDBInstanceRequest);
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemoveSourceIdentifierFromSubscription

        /// <summary>
        /// <para>Removes a source identifier from an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="removeSourceIdentifierFromSubscriptionRequest">Container for the necessary parameters to execute the
        ///          RemoveSourceIdentifierFromSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="SourceNotFoundException"/>
        /// <exception cref="SubscriptionNotFoundException"/>
        public RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest removeSourceIdentifierFromSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeRemoveSourceIdentifierFromSubscription(removeSourceIdentifierFromSubscriptionRequest, null, null, true);
            return EndRemoveSourceIdentifierFromSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveSourceIdentifierFromSubscription"/>
        /// </summary>
        /// 
        /// <param name="removeSourceIdentifierFromSubscriptionRequest">Container for the necessary parameters to execute the
        ///          RemoveSourceIdentifierFromSubscription operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRemoveSourceIdentifierFromSubscription operation.</returns>
        public IAsyncResult BeginRemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest removeSourceIdentifierFromSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeRemoveSourceIdentifierFromSubscription(removeSourceIdentifierFromSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveSourceIdentifierFromSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSourceIdentifierFromSubscription.</param>
        /// 
        /// <returns>Returns a EventSubscription from AmazonRDS.</returns>
        public RemoveSourceIdentifierFromSubscriptionResponse EndRemoveSourceIdentifierFromSubscription(IAsyncResult asyncResult)
        {
            return endOperation<RemoveSourceIdentifierFromSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest removeSourceIdentifierFromSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller().Marshall(removeSourceIdentifierFromSubscriptionRequest);
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemoveTagsFromResource

        /// <summary>
        /// <para> Removes metadata tags from an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a
        /// href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html" >Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="removeTagsFromResourceRequest">Container for the necessary parameters to execute the RemoveTagsFromResource service method on
        ///          AmazonRDS.</param>
        /// 
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest removeTagsFromResourceRequest)
        {
            IAsyncResult asyncResult = invokeRemoveTagsFromResource(removeTagsFromResourceRequest, null, null, true);
            return EndRemoveTagsFromResource(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveTagsFromResource"/>
        /// </summary>
        /// 
        /// <param name="removeTagsFromResourceRequest">Container for the necessary parameters to execute the RemoveTagsFromResource operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest removeTagsFromResourceRequest, AsyncCallback callback, object state)
        {
            return invokeRemoveTagsFromResource(removeTagsFromResourceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveTagsFromResource"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        public RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return endOperation<RemoveTagsFromResourceResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemoveTagsFromResource(RemoveTagsFromResourceRequest removeTagsFromResourceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemoveTagsFromResourceRequestMarshaller().Marshall(removeTagsFromResourceRequest);
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetDBParameterGroup

        /// <summary>
        /// <para> Modifies the parameters of a DB parameter group to the engine/system default value. To reset specific parameters submit a list of the
        /// following: <c>ParameterName</c> and <c>ApplyMethod</c> . To reset the entire DB parameter group, specify the <c>DBParameterGroup</c> name
        /// and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic parameters are updated immediately and static parameters
        /// are set to <c>pending-reboot</c> to take effect on the next DB instance restart or <c>RebootDBInstance</c> request. </para>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup service method on
        ///          AmazonRDS.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBParameterGroupNotFoundException"/>
        /// <exception cref="InvalidDBParameterGroupStateException"/>
        public ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest)
        {
            IAsyncResult asyncResult = invokeResetDBParameterGroup(resetDBParameterGroupRequest, null, null, true);
            return EndResetDBParameterGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ResetDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup operation on
        ///          AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndResetDBParameterGroup operation.</returns>
        public IAsyncResult BeginResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest, AsyncCallback callback, object state)
        {
            return invokeResetDBParameterGroup(resetDBParameterGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ResetDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetDBParameterGroup.</param>
        /// 
        /// <returns>Returns a ResetDBParameterGroupResult from AmazonRDS.</returns>
        public ResetDBParameterGroupResponse EndResetDBParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation<ResetDBParameterGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetDBParameterGroupRequestMarshaller().Marshall(resetDBParameterGroupRequest);
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RestoreDBInstanceFromDBSnapshot

        /// <summary>
        /// <para> Creates a new DB instance from a DB snapshot. The target database is created from the source database restore point with the same
        /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="InvalidRestoreException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBSnapshotStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException"/>
        /// <exception cref="DBSnapshotNotFoundException"/>
        public RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeRestoreDBInstanceFromDBSnapshot(restoreDBInstanceFromDBSnapshotRequest, null, null, true);
            return EndRestoreDBInstanceFromDBSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceFromDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRestoreDBInstanceFromDBSnapshot operation.</returns>
        public IAsyncResult BeginRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeRestoreDBInstanceFromDBSnapshot(restoreDBInstanceFromDBSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceFromDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceFromDBSnapshot.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RestoreDBInstanceFromDBSnapshotResponse EndRestoreDBInstanceFromDBSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<RestoreDBInstanceFromDBSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestoreDBInstanceFromDBSnapshotRequestMarshaller().Marshall(restoreDBInstanceFromDBSnapshotRequest);
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RestoreDBInstanceToPointInTime

        /// <summary>
        /// <para> Restores a DB instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
        /// to backupRetentionPeriod days. The target database is created from the source database with the same configuration as the original database
        /// except that the DB instance is created with the default DB security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        ///          service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="PointInTimeRestoreNotEnabledException"/>
        /// <exception cref="InvalidRestoreException"/>
        /// <exception cref="InstanceQuotaExceededException"/>
        /// <exception cref="DBSubnetGroupNotFoundException"/>
        /// <exception cref="DBInstanceAlreadyExistsException"/>
        /// <exception cref="DBInstanceNotFoundException"/>
        /// <exception cref="StorageQuotaExceededException"/>
        /// <exception cref="InvalidVPCNetworkStateException"/>
        /// <exception cref="InvalidDBInstanceStateException"/>
        /// <exception cref="InsufficientDBInstanceCapacityException"/>
        /// <exception cref="DBSubnetGroupDoesNotCoverEnoughAZsException"/>
        /// <exception cref="InvalidSubnetException"/>
        /// <exception cref="OptionGroupNotFoundException"/>
        /// <exception cref="ProvisionedIopsNotAvailableInAZException"/>
        public RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest)
        {
            IAsyncResult asyncResult = invokeRestoreDBInstanceToPointInTime(restoreDBInstanceToPointInTimeRequest, null, null, true);
            return EndRestoreDBInstanceToPointInTime(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceToPointInTime"/>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRestoreDBInstanceToPointInTime operation.</returns>
        public IAsyncResult BeginRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, AsyncCallback callback, object state)
        {
            return invokeRestoreDBInstanceToPointInTime(restoreDBInstanceToPointInTimeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceToPointInTime"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreDBInstanceToPointInTime.</param>
        /// 
        /// <returns>Returns a DBInstance from AmazonRDS.</returns>
        public RestoreDBInstanceToPointInTimeResponse EndRestoreDBInstanceToPointInTime(IAsyncResult asyncResult)
        {
            return endOperation<RestoreDBInstanceToPointInTimeResponse>(asyncResult);
        }
        
        IAsyncResult invokeRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RestoreDBInstanceToPointInTimeRequestMarshaller().Marshall(restoreDBInstanceToPointInTimeRequest);
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RevokeDBSecurityGroupIngress

        /// <summary>
        /// <para> Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 or VPC Security Groups. Required parameters for
        /// this API are one of CIDRIP, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service
        ///          method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="DBSecurityGroupNotFoundException"/>
        /// <exception cref="InvalidDBSecurityGroupStateException"/>
        /// <exception cref="AuthorizationNotFoundException"/>
        public RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeRevokeDBSecurityGroupIngress(revokeDBSecurityGroupIngressRequest, null, null, true);
            return EndRevokeDBSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RevokeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress
        ///          operation on AmazonRDS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRevokeDBSecurityGroupIngress operation.</returns>
        public IAsyncResult BeginRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeRevokeDBSecurityGroupIngress(revokeDBSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RevokeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeDBSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a DBSecurityGroup from AmazonRDS.</returns>
        public RevokeDBSecurityGroupIngressResponse EndRevokeDBSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<RevokeDBSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RevokeDBSecurityGroupIngressRequestMarshaller().Marshall(revokeDBSecurityGroupIngressRequest);
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    

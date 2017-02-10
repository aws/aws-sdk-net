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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.OpsWorksCM.Model;
using Amazon.OpsWorksCM.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OpsWorksCM
{
    /// <summary>
    /// Implementation for accessing OpsWorksCM
    ///
    /// AWS OpsWorks for Chef Automate 
    /// <para>
    ///  A service that runs and manages configuration management servers. 
    /// </para>
    ///  
    /// <para>
    /// Glossary of terms
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Server</b>: A server is a configuration management server, and can be highly-available.
    /// The configuration manager runs on your instances by using various AWS services, such
    /// as Amazon Elastic Compute Cloud (EC2), and potentially Amazon Relational Database
    /// Service (RDS). A server is a generic abstraction over the configuration manager that
    /// you want to use, much like Amazon RDS. In AWS OpsWorks for Chef Automate, you do not
    /// start or stop servers. After you create servers, they continue to run until they are
    /// deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Engine</b>: The specific configuration manager that you want to use (such as <code>Chef</code>)
    /// is the engine.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Backup</b>: This is an application-level backup of the data that the configuration
    /// manager stores. A backup creates a .tar.gz file that is stored in an Amazon Simple
    /// Storage Service (S3) bucket in your account. AWS OpsWorks for Chef Automate creates
    /// the S3 bucket when you launch the first instance. A backup maintains a snapshot of
    /// all of a server's important attributes at the time of the backup.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Events</b>: Events are always related to a server. Events are written during server
    /// creation, when health checks run, when backups are created, etc. When you delete a
    /// server, the server's events are also deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AccountAttributes</b>: Every account has attributes that are assigned in the AWS
    /// OpsWorks for Chef Automate database. These attributes store information about configuration
    /// limits (servers, backups, etc.) and your customer account. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Throttling limits
    /// </para>
    ///  
    /// <para>
    /// All API operations allow for 5 requests per second with a burst of 10 requests per
    /// second.
    /// </para>
    /// </summary>
    public partial class AmazonOpsWorksCMClient : AmazonServiceClient, IAmazonOpsWorksCM
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        public AmazonOpsWorksCMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksCMConfig()) { }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        public AmazonOpsWorksCMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksCMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(AmazonOpsWorksCMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpsWorksCMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials and an
        /// AmazonOpsWorksCMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials, AmazonOpsWorksCMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksCMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksCMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpsWorksCMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksCMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksCMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpsWorksCMConfig clientConfig)
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

        
        #region  AssociateNode

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode service method.</param>
        /// 
        /// <returns>The response from the AssociateNode service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/AssociateNode">REST API Reference for AssociateNode Operation</seealso>
        public AssociateNodeResponse AssociateNode(AssociateNodeRequest request)
        {
            var marshaller = new AssociateNodeRequestMarshaller();
            var unmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return Invoke<AssociateNodeRequest,AssociateNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/AssociateNode">REST API Reference for AssociateNode Operation</seealso>
        public IAsyncResult BeginAssociateNode(AssociateNodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateNodeRequestMarshaller();
            var unmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateNodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateNode.</param>
        /// 
        /// <returns>Returns a  AssociateNodeResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/AssociateNode">REST API Reference for AssociateNode Operation</seealso>
        public  AssociateNodeResponse EndAssociateNode(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBackup

        /// <summary>
        /// Creates an application-level backup of a server. While the server is <code>BACKING_UP</code>,
        /// the server can not be modified and no additional backup can be created. 
        /// 
        ///  
        /// <para>
        ///  Backups can be created for <code>RUNNING</code>, <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asnychronous. 
        /// </para>
        ///  
        /// <para>
        ///  By default 50 manual backups can be created. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown then the maximum number of manual
        /// backup is reached. A <code>InvalidStateException</code> is thrown when the server
        /// is not in any of RUNNING, HEALTHY, UNHEALTHY. A <code>ResourceNotFoundException</code>
        /// is thrown when the server is not found. A <code>ValidationException</code> is thrown
        /// when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.LimitExceededException">
        /// The limit of servers or backups has been reached.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            var marshaller = new CreateBackupRequestMarshaller();
            var unmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return Invoke<CreateBackupRequest,CreateBackupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public IAsyncResult BeginCreateBackup(CreateBackupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateBackupRequestMarshaller();
            var unmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateBackupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackup.</param>
        /// 
        /// <returns>Returns a  CreateBackupResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public  CreateBackupResponse EndCreateBackup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServer

        /// <summary>
        /// Creates and immedately starts a new Server. The server can be used once it has reached
        /// the <code>HEALTHY</code> state. 
        /// 
        ///  
        /// <para>
        ///  This operation is asnychronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown then the maximum number of server
        /// backup is reached. A <code>ResourceAlreadyExistsException</code> is raise when a server
        /// with the same name already exists in the account. A <code>ResourceNotFoundException</code>
        /// is thrown when a backupId is passed, but the backup does not exist. A <code>ValidationException</code>
        /// is thrown when parameters of the request are not valid. 
        /// </para>
        ///  
        /// <para>
        ///  By default 10 servers can be created. A <code>LimitExceededException</code> is raised
        /// when the limit is exceeded. 
        /// </para>
        ///  
        /// <para>
        ///  When no security groups are provided by using <code>SecurityGroupIds</code>, AWS
        /// OpsWorks creates a new security group. This security group opens the Chef server to
        /// the world on TCP port 443. If a KeyName is present, SSH access is enabled. SSH is
        /// also open to the world on TCP port 22. 
        /// </para>
        ///  
        /// <para>
        /// By default, the Chef Server is accessible from any IP address. We recommend that you
        /// update your security group rules to allow access from known IP addresses and address
        /// ranges only. To edit security group rules, open Security Groups in the navigation
        /// pane of the EC2 management console. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.LimitExceededException">
        /// The limit of servers or backups has been reached.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceAlreadyExistsException">
        /// The requested resource cannot be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public CreateServerResponse CreateServer(CreateServerRequest request)
        {
            var marshaller = new CreateServerRequestMarshaller();
            var unmarshaller = CreateServerResponseUnmarshaller.Instance;

            return Invoke<CreateServerRequest,CreateServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServer operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public IAsyncResult BeginCreateServer(CreateServerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateServerRequestMarshaller();
            var unmarshaller = CreateServerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateServerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServer.</param>
        /// 
        /// <returns>Returns a  CreateServerResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public  CreateServerResponse EndCreateServer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBackup

        /// <summary>
        /// Deletes a backup. You can delete both manual and automated backups. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown then a backup is already deleting.
        /// A <code>ResourceNotFoundException</code> is thrown when the backup does not exist.
        /// A <code>ValidationException</code> is thrown when parameters of the request are not
        /// valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            var marshaller = new DeleteBackupRequestMarshaller();
            var unmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupRequest,DeleteBackupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public IAsyncResult BeginDeleteBackup(DeleteBackupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBackupRequestMarshaller();
            var unmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBackupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackup.</param>
        /// 
        /// <returns>Returns a  DeleteBackupResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public  DeleteBackupResponse EndDeleteBackup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServer

        /// <summary>
        /// Deletes the server and the underlying AWS CloudFormation stack (including the server's
        /// EC2 instance). The server status updated to <code>DELETING</code>. Once the server
        /// is successfully deleted, it will no longer be returned by <code>DescribeServer</code>
        /// requests. If the AWS CloudFormation stack cannot be deleted, the server cannot be
        /// deleted. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown then a server is already deleting.
        /// A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public DeleteServerResponse DeleteServer(DeleteServerRequest request)
        {
            var marshaller = new DeleteServerRequestMarshaller();
            var unmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return Invoke<DeleteServerRequest,DeleteServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public IAsyncResult BeginDeleteServer(DeleteServerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteServerRequestMarshaller();
            var unmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServer.</param>
        /// 
        /// <returns>Returns a  DeleteServerResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public  DeleteServerResponse EndDeleteServer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Describes your account attributes, and creates requests to increase limits before
        /// they are reached or exceeded. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public  DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBackups

        /// <summary>
        /// Describes backups. The results are ordered by time, with newest backups first. If
        /// you do not specify a BackupId or ServerName, the command returns all backups. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the backup does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            var marshaller = new DescribeBackupsRequestMarshaller();
            var unmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupsRequest,DescribeBackupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public IAsyncResult BeginDescribeBackups(DescribeBackupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBackupsRequestMarshaller();
            var unmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBackupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackups.</param>
        /// 
        /// <returns>Returns a  DescribeBackupsResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public  DescribeBackupsResponse EndDescribeBackups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBackupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Describes events for a specified server. Results are ordered by time, with newest
        /// events first. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
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
        /// <returns>Returns a  DescribeEventsResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public  DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNodeAssociationStatus

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeNodeAssociationStatus service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeNodeAssociationStatus">REST API Reference for DescribeNodeAssociationStatus Operation</seealso>
        public DescribeNodeAssociationStatusResponse DescribeNodeAssociationStatus(DescribeNodeAssociationStatusRequest request)
        {
            var marshaller = new DescribeNodeAssociationStatusRequestMarshaller();
            var unmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeAssociationStatusRequest,DescribeNodeAssociationStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNodeAssociationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeNodeAssociationStatus">REST API Reference for DescribeNodeAssociationStatus Operation</seealso>
        public IAsyncResult BeginDescribeNodeAssociationStatus(DescribeNodeAssociationStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNodeAssociationStatusRequestMarshaller();
            var unmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNodeAssociationStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNodeAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNodeAssociationStatus.</param>
        /// 
        /// <returns>Returns a  DescribeNodeAssociationStatusResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeNodeAssociationStatus">REST API Reference for DescribeNodeAssociationStatus Operation</seealso>
        public  DescribeNodeAssociationStatusResponse EndDescribeNodeAssociationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNodeAssociationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServers

        /// <summary>
        /// Lists all configuration management servers that are identified with your account.
        /// Only the stored results from Amazon DynamoDB are returned. AWS OpsWorks for Chef Automate
        /// does not query other services. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when the server does not exist.
        /// A <code>ValidationException</code> is raised when parameters of the request are invalid.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers service method.</param>
        /// 
        /// <returns>The response from the DescribeServers service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidNextTokenException">
        /// This occurs when the provided nextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeServers">REST API Reference for DescribeServers Operation</seealso>
        public DescribeServersResponse DescribeServers(DescribeServersRequest request)
        {
            var marshaller = new DescribeServersRequestMarshaller();
            var unmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return Invoke<DescribeServersRequest,DescribeServersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeServers">REST API Reference for DescribeServers Operation</seealso>
        public IAsyncResult BeginDescribeServers(DescribeServersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeServersRequestMarshaller();
            var unmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeServersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServers.</param>
        /// 
        /// <returns>Returns a  DescribeServersResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeServers">REST API Reference for DescribeServers Operation</seealso>
        public  DescribeServersResponse EndDescribeServers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServersResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateNode

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode service method.</param>
        /// 
        /// <returns>The response from the DisassociateNode service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DisassociateNode">REST API Reference for DisassociateNode Operation</seealso>
        public DisassociateNodeResponse DisassociateNode(DisassociateNodeRequest request)
        {
            var marshaller = new DisassociateNodeRequestMarshaller();
            var unmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return Invoke<DisassociateNodeRequest,DisassociateNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DisassociateNode">REST API Reference for DisassociateNode Operation</seealso>
        public IAsyncResult BeginDisassociateNode(DisassociateNodeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateNodeRequestMarshaller();
            var unmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateNodeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateNode.</param>
        /// 
        /// <returns>Returns a  DisassociateNodeResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DisassociateNode">REST API Reference for DisassociateNode Operation</seealso>
        public  DisassociateNodeResponse EndDisassociateNode(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreServer

        /// <summary>
        /// Restores a backup to a server that is in a <code>RUNNING</code>, <code>FAILED</code>,
        /// or <code>HEALTHY</code> state. When you run RestoreServer, the server's EC2 instance
        /// is deleted, and a new EC2 instance is configured. RestoreServer maintains the existing
        /// server endpoint, so configuration management of all of the server's client devices
        /// should continue to work. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>InvalidStateException</code> is thrown when the server is not in a valid
        /// state. A <code>ResourceNotFoundException</code> is thrown when the server does not
        /// exist. A <code>ValidationException</code> is raised when parameters of the request
        /// are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer service method.</param>
        /// 
        /// <returns>The response from the RestoreServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/RestoreServer">REST API Reference for RestoreServer Operation</seealso>
        public RestoreServerResponse RestoreServer(RestoreServerRequest request)
        {
            var marshaller = new RestoreServerRequestMarshaller();
            var unmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return Invoke<RestoreServerRequest,RestoreServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/RestoreServer">REST API Reference for RestoreServer Operation</seealso>
        public IAsyncResult BeginRestoreServer(RestoreServerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RestoreServerRequestMarshaller();
            var unmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreServerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreServer.</param>
        /// 
        /// <returns>Returns a  RestoreServerResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/RestoreServer">REST API Reference for RestoreServer Operation</seealso>
        public  RestoreServerResponse EndRestoreServer(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreServerResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMaintenance

        /// <summary>
        /// Manually starts server maintenance. This command can be useful if an earlier maintenance
        /// attempt failed, and the underlying cause of maintenance failure has been resolved.
        /// The server will switch to <code>UNDER_MAINTENANCE</code> state, while maintenace is
        /// in progress. 
        /// 
        ///  
        /// <para>
        ///  Maintenace can only be started for <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. A <code>InvalidStateException</code> is thrown otherwise. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance service method.</param>
        /// 
        /// <returns>The response from the StartMaintenance service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/StartMaintenance">REST API Reference for StartMaintenance Operation</seealso>
        public StartMaintenanceResponse StartMaintenance(StartMaintenanceRequest request)
        {
            var marshaller = new StartMaintenanceRequestMarshaller();
            var unmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return Invoke<StartMaintenanceRequest,StartMaintenanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMaintenance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/StartMaintenance">REST API Reference for StartMaintenance Operation</seealso>
        public IAsyncResult BeginStartMaintenance(StartMaintenanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartMaintenanceRequestMarshaller();
            var unmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return BeginInvoke<StartMaintenanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMaintenance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMaintenance.</param>
        /// 
        /// <returns>Returns a  StartMaintenanceResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/StartMaintenance">REST API Reference for StartMaintenance Operation</seealso>
        public  StartMaintenanceResponse EndStartMaintenance(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMaintenanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServer

        /// <summary>
        /// Updates settings for a server. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public UpdateServerResponse UpdateServer(UpdateServerRequest request)
        {
            var marshaller = new UpdateServerRequestMarshaller();
            var unmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return Invoke<UpdateServerRequest,UpdateServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public IAsyncResult BeginUpdateServer(UpdateServerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateServerRequestMarshaller();
            var unmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServer.</param>
        /// 
        /// <returns>Returns a  UpdateServerResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public  UpdateServerResponse EndUpdateServer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServerEngineAttributes

        /// <summary>
        /// Updates engine specific attributes on a specified server. Server will enter the <code>MODIFYING</code>
        /// state when this operation is in progress. Only one update can take place at a time.
        /// 
        /// 
        ///  
        /// <para>
        ///  This operation can be use to reset Chef Server main API key (<code>CHEF_PIVOTAL_KEY</code>).
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  This operation can only be called for <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// servers. Otherwise a <code>InvalidStateException</code> is raised. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are invalid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateServerEngineAttributes service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServerEngineAttributes">REST API Reference for UpdateServerEngineAttributes Operation</seealso>
        public UpdateServerEngineAttributesResponse UpdateServerEngineAttributes(UpdateServerEngineAttributesRequest request)
        {
            var marshaller = new UpdateServerEngineAttributesRequestMarshaller();
            var unmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateServerEngineAttributesRequest,UpdateServerEngineAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerEngineAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes operation on AmazonOpsWorksCMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServerEngineAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServerEngineAttributes">REST API Reference for UpdateServerEngineAttributes Operation</seealso>
        public IAsyncResult BeginUpdateServerEngineAttributes(UpdateServerEngineAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateServerEngineAttributesRequestMarshaller();
            var unmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServerEngineAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerEngineAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerEngineAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateServerEngineAttributesResult from OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServerEngineAttributes">REST API Reference for UpdateServerEngineAttributes Operation</seealso>
        public  UpdateServerEngineAttributesResponse EndUpdateServerEngineAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServerEngineAttributesResponse>(asyncResult);
        }

        #endregion
        
    }
}
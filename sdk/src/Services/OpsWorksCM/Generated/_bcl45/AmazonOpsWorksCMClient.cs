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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    ///  AWS OpsWorks for Chef Automate is a service that runs and manages configuration management
    /// servers. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Glossary of terms</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Server</b>: A configuration management server that can be highly-available. The
    /// configuration manager runs on your instances by using various AWS services, such as
    /// Amazon Elastic Compute Cloud (EC2), and potentially Amazon Relational Database Service
    /// (RDS). A server is a generic abstraction over the configuration manager that you want
    /// to use, much like Amazon RDS. In AWS OpsWorks for Chef Automate, you do not start
    /// or stop servers. After you create servers, they continue to run until they are deleted.
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
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS OpsWorks for Chef Automate supports the following endpoints, all HTTPS. You must
    /// connect to one of the following endpoints. Chef servers can only be accessed or managed
    /// within the endpoint in which they are created.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// opsworks-cm.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.us-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.eu-west-1.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Throttling limits</b> 
    /// </para>
    ///  
    /// <para>
    /// All API operations allow for five requests per second with a burst of 10 requests
    /// per second.
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
        /// Associates a new node with the Chef server. This command is an alternative to <code>knife
        /// bootstrap</code>. For more information about how to disassociate a node, see <a>DisassociateNode</a>.
        /// 
        ///  
        /// <para>
        ///  A node can can only be associated with servers that are in a <code>HEALTHY</code>
        /// state. Otherwise, an <code>InvalidStateException</code> is thrown. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are not valid. The AssociateNode API call can be integrated
        /// into Auto Scaling configurations, AWS Cloudformation templates, or the user data of
        /// a server's instance. 
        /// </para>
        ///  
        /// <para>
        ///  Example: <code>aws opsworks-cm associate-node --server-name <i>MyServer</i> --node-name
        /// <i>MyManagedNode</i> --engine-attributes "Name=<i>MyOrganization</i>,Value=default"
        /// "Name=<i>Chef_node_public_key</i>,Value=<i>Public_key_contents</i>"</code> 
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/AssociateNode">REST API Reference for AssociateNode Operation</seealso>
        public Task<AssociateNodeResponse> AssociateNodeAsync(AssociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateNodeRequestMarshaller();
            var unmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateNodeRequest,AssociateNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBackup


        /// <summary>
        /// Creates an application-level backup of a server. While the server is in the <code>BACKING_UP</code>
        /// state, the server cannot be changed, and no additional backup can be created. 
        /// 
        ///  
        /// <para>
        ///  Backups can be created for servers in <code>RUNNING</code>, <code>HEALTHY</code>,
        /// and <code>UNHEALTHY</code> states. By default, you can create a maximum of 50 manual
        /// backups. 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown when the maximum number of manual
        /// backups is reached. An <code>InvalidStateException</code> is thrown when the server
        /// is not in any of the following states: RUNNING, HEALTHY, or UNHEALTHY. A <code>ResourceNotFoundException</code>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBackupRequestMarshaller();
            var unmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackupRequest,CreateBackupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateServer


        /// <summary>
        /// Creates and immedately starts a new server. The server is ready to use when it is
        /// in the <code>HEALTHY</code> state. By default, you can create a maximum of 10 servers.
        /// 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <code>LimitExceededException</code> is thrown when you have created the maximum
        /// number of servers (10). A <code>ResourceAlreadyExistsException</code> is thrown when
        /// a server with the same name already exists in the account. A <code>ResourceNotFoundException</code>
        /// is thrown when you specify a backup ID that is not valid or is for a backup that does
        /// not exist. A <code>ValidationException</code> is thrown when parameters of the request
        /// are not valid. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify a security group by adding the <code>SecurityGroupIds</code>
        /// parameter, AWS OpsWorks creates a new security group. The default security group opens
        /// the Chef server to the world on TCP port 443. If a KeyName is present, AWS OpsWorks
        /// enables SSH access. SSH is also open to the world on TCP port 22. 
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
        /// <param name="request">Container for the necessary parameters to execute the CreateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/CreateServer">REST API Reference for CreateServer Operation</seealso>
        public Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateServerRequestMarshaller();
            var unmarshaller = CreateServerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServerRequest,CreateServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes a backup. You can delete both manual and automated backups. This operation
        /// is asynchronous. 
        /// 
        ///  
        /// <para>
        ///  An <code>InvalidStateException</code> is thrown when a backup deletion is already
        /// in progress. A <code>ResourceNotFoundException</code> is thrown when the backup does
        /// not exist. A <code>ValidationException</code> is thrown when parameters of the request
        /// are not valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBackupRequestMarshaller();
            var unmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackupRequest,DeleteBackupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServer


        /// <summary>
        /// Deletes the server and the underlying AWS CloudFormation stack (including the server's
        /// EC2 instance). When you run this command, the server state is updated to <code>DELETING</code>.
        /// After the server is deleted, it is no longer returned by <code>DescribeServer</code>
        /// requests. If the AWS CloudFormation stack cannot be deleted, the server cannot be
        /// deleted. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  An <code>InvalidStateException</code> is thrown when a server deletion is already
        /// in progress. A <code>ResourceNotFoundException</code> is thrown when the server does
        /// not exist. A <code>ValidationException</code> is raised when parameters of the request
        /// are not valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        public Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteServerRequestMarshaller();
            var unmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerRequest,DeleteServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// A <code>ValidationException</code> is raised when parameters of the request are not
        /// valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        public Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBackupsRequestMarshaller();
            var unmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBackupsRequest,DescribeBackupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// A <code>ValidationException</code> is raised when parameters of the request are not
        /// valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNodeAssociationStatus


        /// <summary>
        /// Returns the current status of an existing association or disassociation request.
        /// 
        /// 
        ///  
        /// <para>
        ///  A <code>ResourceNotFoundException</code> is thrown when no recent association or
        /// disassociation request with the specified token is found, or when the server does
        /// not exist. A <code>ValidationException</code> is raised when parameters of the request
        /// are not valid. 
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeNodeAssociationStatus">REST API Reference for DescribeNodeAssociationStatus Operation</seealso>
        public Task<DescribeNodeAssociationStatusResponse> DescribeNodeAssociationStatusAsync(DescribeNodeAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNodeAssociationStatusRequestMarshaller();
            var unmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeAssociationStatusRequest,DescribeNodeAssociationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// A <code>ValidationException</code> is raised when parameters of the request are not
        /// valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeServers">REST API Reference for DescribeServers Operation</seealso>
        public Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServersRequestMarshaller();
            var unmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServersRequest,DescribeServersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateNode


        /// <summary>
        /// Disassociates a node from a Chef server, and removes the node from the Chef server's
        /// managed nodes. After a node is disassociated, the node key pair is no longer valid
        /// for accessing the Chef API. For more information about how to associate a node, see
        /// <a>AssociateNode</a>. 
        /// 
        ///  
        /// <para>
        /// A node can can only be disassociated from a server that is in a <code>HEALTHY</code>
        /// state. Otherwise, an <code>InvalidStateException</code> is thrown. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are not valid. 
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DisassociateNode">REST API Reference for DisassociateNode Operation</seealso>
        public Task<DisassociateNodeResponse> DisassociateNodeAsync(DisassociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateNodeRequestMarshaller();
            var unmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateNodeRequest,DisassociateNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreServer


        /// <summary>
        /// Restores a backup to a server that is in a <code>CONNECTION_LOST</code>, <code>HEALTHY</code>,
        /// <code>RUNNING</code>, <code>UNHEALTHY</code>, or <code>TERMINATED</code> state. When
        /// you run RestoreServer, the server's EC2 instance is deleted, and a new EC2 instance
        /// is configured. RestoreServer maintains the existing server endpoint, so configuration
        /// management of the server's client devices (nodes) should continue to work. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  An <code>InvalidStateException</code> is thrown when the server is not in a valid
        /// state. A <code>ResourceNotFoundException</code> is thrown when the server does not
        /// exist. A <code>ValidationException</code> is raised when parameters of the request
        /// are not valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/RestoreServer">REST API Reference for RestoreServer Operation</seealso>
        public Task<RestoreServerResponse> RestoreServerAsync(RestoreServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreServerRequestMarshaller();
            var unmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreServerRequest,RestoreServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartMaintenance


        /// <summary>
        /// Manually starts server maintenance. This command can be useful if an earlier maintenance
        /// attempt failed, and the underlying cause of maintenance failure has been resolved.
        /// The server is in an <code>UNDER_MAINTENANCE</code> state while maintenance is in progress.
        /// 
        /// 
        ///  
        /// <para>
        ///  Maintenance can only be started on servers in <code>HEALTHY</code> and <code>UNHEALTHY</code>
        /// states. Otherwise, an <code>InvalidStateException</code> is thrown. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are not valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/StartMaintenance">REST API Reference for StartMaintenance Operation</seealso>
        public Task<StartMaintenanceResponse> StartMaintenanceAsync(StartMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartMaintenanceRequestMarshaller();
            var unmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartMaintenanceRequest,StartMaintenanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        public Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServerRequestMarshaller();
            var unmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerRequest,UpdateServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServerEngineAttributes


        /// <summary>
        /// Updates engine-specific attributes on a specified server. The server enters the <code>MODIFYING</code>
        /// state when this operation is in progress. Only one update can occur at a time. You
        /// can use this command to reset the Chef server's private key (<code>CHEF_PIVOTAL_KEY</code>).
        /// 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  This operation can only be called for servers in <code>HEALTHY</code> or <code>UNHEALTHY</code>
        /// states. Otherwise, an <code>InvalidStateException</code> is raised. A <code>ResourceNotFoundException</code>
        /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
        /// when parameters of the request are not valid. 
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UpdateServerEngineAttributes">REST API Reference for UpdateServerEngineAttributes Operation</seealso>
        public Task<UpdateServerEngineAttributesResponse> UpdateServerEngineAttributesAsync(UpdateServerEngineAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServerEngineAttributesRequestMarshaller();
            var unmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerEngineAttributesRequest,UpdateServerEngineAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}
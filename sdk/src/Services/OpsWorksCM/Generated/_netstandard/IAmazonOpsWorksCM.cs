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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpsWorksCM.Model;

#pragma warning disable CS1570
namespace Amazon.OpsWorksCM
{
    /// <summary>
    /// <para>Interface for accessing OpsWorksCM</para>
    ///
    /// OpsWorks CM <important> 
    /// <para>
    /// The OpsWorks services have reached end of life and have been disabled for both new
    /// and existing customers. We strongly recommend customers migrate their workloads to
    /// other solutions as soon as possible. If you have questions about migration, reach
    /// out to the Amazon Web ServicesSupport Team on <a href="https://repost.aws/">Amazon
    /// Web Services re:Post</a> or through <a href="https://aws.amazon.com/support">Amazon
    /// Web Services Premium Support</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// OpsWorks CM is a service that runs and manages configuration management servers. You
    /// can use OpsWorks CM to create and manage OpsWorks for Chef Automate and OpsWorks for
    /// Puppet Enterprise servers, and add or remove nodes for the servers to manage.
    /// </para>
    ///  
    /// <para>
    ///  <b>Glossary of terms</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Server</b>: A configuration management server that can be highly-available. The
    /// configuration management server runs on an Amazon Elastic Compute Cloud (EC2) instance,
    /// and may use various other Amazon Web Services services, such as Amazon Relational
    /// Database Service (RDS) and Elastic Load Balancing. A server is a generic abstraction
    /// over the configuration manager that you want to use, much like Amazon RDS. In OpsWorks
    /// CM, you do not start or stop servers. After you create servers, they continue to run
    /// until they are deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Engine</b>: The engine is the specific configuration manager that you want to
    /// use. Valid values in this release include <c>ChefAutomate</c> and <c>Puppet</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Backup</b>: This is an application-level backup of the data that the configuration
    /// manager stores. OpsWorks CM creates an S3 bucket for backups when you launch the first
    /// server. A backup maintains a snapshot of a server's configuration-related attributes
    /// at the time the backup starts.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Events</b>: Events are always related to a server. Events are written during server
    /// creation, when health checks run, when backups are created, when system maintenance
    /// is performed, etc. When you delete a server, the server's events are also deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Account attributes</b>: Every account has attributes that are assigned in the
    /// OpsWorks CM database. These attributes store information about configuration limits
    /// (servers, backups, etc.) and your customer account. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// OpsWorks CM supports the following endpoints, all HTTPS. You must connect to one of
    /// the following endpoints. Your servers can only be accessed or managed within the endpoint
    /// in which they are created.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// opsworks-cm.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.us-east-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.us-west-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.us-west-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.ap-northeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.ap-southeast-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.ap-southeast-2.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.eu-central-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// opsworks-cm.eu-west-1.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/opsworks-service.html">OpsWorks
    /// endpoints and quotas</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  
    /// <para>
    ///  <b>Throttling limits</b> 
    /// </para>
    ///  
    /// <para>
    /// All API operations allow for five requests per second with a burst of 10 requests
    /// per second.
    /// </para>
    /// </summary>
    public partial interface IAmazonOpsWorksCM : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOpsWorksCMPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateNode



        /// <summary>
        /// Associates a new node with the server. For more information about how to disassociate
        /// a node, see <a>DisassociateNode</a>.
        /// 
        ///  
        /// <para>
        ///  On a Chef server: This command is an alternative to <c>knife bootstrap</c>.
        /// </para>
        ///  
        /// <para>
        ///  Example (Chef): <c>aws opsworks-cm associate-node --server-name <i>MyServer</i> --node-name
        /// <i>MyManagedNode</i> --engine-attributes "Name=<i>CHEF_ORGANIZATION</i>,Value=default"
        /// "Name=<i>CHEF_AUTOMATE_NODE_PUBLIC_KEY</i>,Value=<i>public-key-pem</i>"</c> 
        /// </para>
        ///  
        /// <para>
        ///  On a Puppet server, this command is an alternative to the <c>puppet cert sign</c>
        /// command that signs a Puppet node CSR. 
        /// </para>
        ///  
        /// <para>
        ///  Example (Puppet): <c>aws opsworks-cm associate-node --server-name <i>MyServer</i>
        /// --node-name <i>MyManagedNode</i> --engine-attributes "Name=<i>PUPPET_NODE_CSR</i>,Value=<i>csr-pem</i>"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A node can can only be associated with servers that are in a <c>HEALTHY</c> state.
        /// Otherwise, an <c>InvalidStateException</c> is thrown. A <c>ResourceNotFoundException</c>
        /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
        /// parameters of the request are not valid. The AssociateNode API call can be integrated
        /// into Auto Scaling configurations, CloudFormation templates, or the user data of a
        /// server's instance. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateNodeResponse> AssociateNodeAsync(AssociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBackup



        /// <summary>
        /// Creates an application-level backup of a server. While the server is in the <c>BACKING_UP</c>
        /// state, the server cannot be changed, and no additional backup can be created. 
        /// 
        ///  
        /// <para>
        ///  Backups can be created for servers in <c>RUNNING</c>, <c>HEALTHY</c>, and <c>UNHEALTHY</c>
        /// states. By default, you can create a maximum of 50 manual backups. 
        /// </para>
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>LimitExceededException</c> is thrown when the maximum number of manual backups
        /// is reached. An <c>InvalidStateException</c> is thrown when the server is not in any
        /// of the following states: RUNNING, HEALTHY, or UNHEALTHY. A <c>ResourceNotFoundException</c>
        /// is thrown when the server is not found. A <c>ValidationException</c> is thrown when
        /// parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServer



        /// <summary>
        /// Creates and immedately starts a new server. The server is ready to use when it is
        /// in the <c>HEALTHY</c> state. By default, you can create a maximum of 10 servers. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>LimitExceededException</c> is thrown when you have created the maximum number
        /// of servers (10). A <c>ResourceAlreadyExistsException</c> is thrown when a server with
        /// the same name already exists in the account. A <c>ResourceNotFoundException</c> is
        /// thrown when you specify a backup ID that is not valid or is for a backup that does
        /// not exist. A <c>ValidationException</c> is thrown when parameters of the request are
        /// not valid. 
        /// </para>
        ///  
        /// <para>
        ///  If you do not specify a security group by adding the <c>SecurityGroupIds</c> parameter,
        /// OpsWorks creates a new security group. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Chef Automate:</i> The default security group opens the Chef server to the world
        /// on TCP port 443. If a KeyName is present, OpsWorks enables SSH access. SSH is also
        /// open to the world on TCP port 22. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Puppet Enterprise:</i> The default security group opens TCP ports 22, 443, 4433,
        /// 8140, 8142, 8143, and 8170. If a KeyName is present, OpsWorks enables SSH access.
        /// SSH is also open to the world on TCP port 22. 
        /// </para>
        ///  
        /// <para>
        /// By default, your server is accessible from any IP address. We recommend that you update
        /// your security group rules to allow access from known IP addresses and address ranges
        /// only. To edit security group rules, open Security Groups in the navigation pane of
        /// the EC2 management console. 
        /// </para>
        ///  
        /// <para>
        /// To specify your own domain for a server, and provide your own self-signed or CA-signed
        /// certificate and private key, specify values for <c>CustomDomain</c>, <c>CustomCertificate</c>,
        /// and <c>CustomPrivateKey</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackup



        /// <summary>
        /// Deletes a backup. You can delete both manual and automated backups. This operation
        /// is asynchronous. 
        /// 
        ///  
        /// <para>
        ///  An <c>InvalidStateException</c> is thrown when a backup deletion is already in progress.
        /// A <c>ResourceNotFoundException</c> is thrown when the backup does not exist. A <c>ValidationException</c>
        /// is thrown when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServer



        /// <summary>
        /// Deletes the server and the underlying CloudFormation stacks (including the server's
        /// EC2 instance). When you run this command, the server state is updated to <c>DELETING</c>.
        /// After the server is deleted, it is no longer returned by <c>DescribeServer</c> requests.
        /// If the CloudFormation stack cannot be deleted, the server cannot be deleted. 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  An <c>InvalidStateException</c> is thrown when a server deletion is already in progress.
        /// A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountAttributes



        /// <summary>
        /// Describes your OpsWorks CM account attributes. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by OpsWorksCM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        ///  A <c>ResourceNotFoundException</c> is thrown when the backup does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        ///  A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNodeAssociationStatus



        /// <summary>
        /// Returns the current status of an existing association or disassociation request.
        /// 
        /// 
        ///  
        /// <para>
        ///  A <c>ResourceNotFoundException</c> is thrown when no recent association or disassociation
        /// request with the specified token is found, or when the server does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodeAssociationStatus service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/DescribeNodeAssociationStatus">REST API Reference for DescribeNodeAssociationStatus Operation</seealso>
        Task<DescribeNodeAssociationStatusResponse> DescribeNodeAssociationStatusAsync(DescribeNodeAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServers



        /// <summary>
        /// Lists all configuration management servers that are identified with your account.
        /// Only the stored results from Amazon DynamoDB are returned. OpsWorks CM does not query
        /// other services. 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateNode



        /// <summary>
        /// Disassociates a node from an OpsWorks CM server, and removes the node from the server's
        /// managed nodes. After a node is disassociated, the node key pair is no longer valid
        /// for accessing the configuration manager's API. For more information about how to associate
        /// a node, see <a>AssociateNode</a>. 
        /// 
        ///  
        /// <para>
        /// A node can can only be disassociated from a server that is in a <c>HEALTHY</c> state.
        /// Otherwise, an <c>InvalidStateException</c> is thrown. A <c>ResourceNotFoundException</c>
        /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
        /// parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateNodeResponse> DisassociateNodeAsync(DisassociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportServerEngineAttribute



        /// <summary>
        /// Exports a specified server engine attribute as a base64-encoded string. For example,
        /// you can export user data that you can use in EC2 to associate nodes with a server.
        /// 
        /// 
        ///  
        /// <para>
        ///  This operation is synchronous. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>ValidationException</c> is raised when parameters of the request are not valid.
        /// A <c>ResourceNotFoundException</c> is thrown when the server does not exist. An <c>InvalidStateException</c>
        /// is thrown when the server is in any of the following states: CREATING, TERMINATED,
        /// FAILED or DELETING. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportServerEngineAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportServerEngineAttribute service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/ExportServerEngineAttribute">REST API Reference for ExportServerEngineAttribute Operation</seealso>
        Task<ExportServerEngineAttributeResponse> ExportServerEngineAttributeAsync(ExportServerEngineAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags that are applied to the specified OpsWorks for Chef Automate
        /// or OpsWorks for Puppet Enterprise servers or backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreServer



        /// <summary>
        /// Restores a backup to a server that is in a <c>CONNECTION_LOST</c>, <c>HEALTHY</c>,
        /// <c>RUNNING</c>, <c>UNHEALTHY</c>, or <c>TERMINATED</c> state. When you run RestoreServer,
        /// the server's EC2 instance is deleted, and a new EC2 instance is configured. RestoreServer
        /// maintains the existing server endpoint, so configuration management of the server's
        /// client devices (nodes) should continue to work. 
        /// 
        ///  
        /// <para>
        /// Restoring from a backup is performed by creating a new EC2 instance. If restoration
        /// is successful, and the server is in a <c>HEALTHY</c> state, OpsWorks CM switches traffic
        /// over to the new instance. After restoration is finished, the old EC2 instance is maintained
        /// in a <c>Running</c> or <c>Stopped</c> state, but is eventually terminated.
        /// </para>
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  An <c>InvalidStateException</c> is thrown when the server is not in a valid state.
        /// A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
        /// is raised when parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RestoreServerResponse> RestoreServerAsync(RestoreServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMaintenance



        /// <summary>
        /// Manually starts server maintenance. This command can be useful if an earlier maintenance
        /// attempt failed, and the underlying cause of maintenance failure has been resolved.
        /// The server is in an <c>UNDER_MAINTENANCE</c> state while maintenance is in progress.
        /// 
        /// 
        ///  
        /// <para>
        ///  Maintenance can only be started on servers in <c>HEALTHY</c> and <c>UNHEALTHY</c>
        /// states. Otherwise, an <c>InvalidStateException</c> is thrown. A <c>ResourceNotFoundException</c>
        /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
        /// parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMaintenanceResponse> StartMaintenanceAsync(StartMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies tags to an OpsWorks for Chef Automate or OpsWorks for Puppet Enterprise server,
        /// or to server backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes specified tags from an OpsWorks CM server or backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OpsWorksCM.</returns>
        /// <exception cref="Amazon.OpsWorksCM.Model.InvalidStateException">
        /// The resource is in a state that does not allow you to perform a specified action.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or access was denied.
        /// </exception>
        /// <exception cref="Amazon.OpsWorksCM.Model.ValidationException">
        /// One or more of the provided request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opsworkscm-2016-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServerEngineAttributes



        /// <summary>
        /// Updates engine-specific attributes on a specified server. The server enters the <c>MODIFYING</c>
        /// state when this operation is in progress. Only one update can occur at a time. You
        /// can use this command to reset a Chef server's public key (<c>CHEF_PIVOTAL_KEY</c>)
        /// or a Puppet server's admin password (<c>PUPPET_ADMIN_PASSWORD</c>). 
        /// 
        ///  
        /// <para>
        ///  This operation is asynchronous. 
        /// </para>
        ///  
        /// <para>
        ///  This operation can only be called for servers in <c>HEALTHY</c> or <c>UNHEALTHY</c>
        /// states. Otherwise, an <c>InvalidStateException</c> is raised. A <c>ResourceNotFoundException</c>
        /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
        /// parameters of the request are not valid. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateServerEngineAttributesResponse> UpdateServerEngineAttributesAsync(UpdateServerEngineAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonOpsWorksCMConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonOpsWorksCMConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonOpsWorksCMConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonOpsWorksCMConfig to create AmazonOpsWorksCMClient");
            }

            return awsCredentials == null ? 
                    new AmazonOpsWorksCMClient(serviceClientConfig) :
                    new AmazonOpsWorksCMClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}
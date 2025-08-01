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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.OpsWorksCM.Model;
using Amazon.OpsWorksCM.Model.Internal.MarshallTransformations;
using Amazon.OpsWorksCM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.OpsWorksCM
{
    /// <summary>
    /// <para>Implementation for accessing OpsWorksCM</para>
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
    public partial class AmazonOpsWorksCMClient : AmazonServiceClient, IAmazonOpsWorksCM
    {
        private static IServiceMetadata serviceMetadata = new AmazonOpsWorksCMMetadata();
        
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
            : base(new AmazonOpsWorksCMConfig()) { }

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
            : base(new AmazonOpsWorksCMConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IOpsWorksCMPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOpsWorksCMPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OpsWorksCMPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOpsWorksCMEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOpsWorksCMAuthSchemeHandler());
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


        #region  AssociateNode

        internal virtual AssociateNodeResponse AssociateNode(AssociateNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return Invoke<AssociateNodeResponse>(request, options);
        }



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
        public virtual Task<AssociateNodeResponse> AssociateNodeAsync(AssociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBackup

        internal virtual CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return Invoke<CreateBackupResponse>(request, options);
        }



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
        public virtual Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateServer

        internal virtual CreateServerResponse CreateServer(CreateServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerResponseUnmarshaller.Instance;

            return Invoke<CreateServerResponse>(request, options);
        }



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
        public virtual Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBackup

        internal virtual DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupResponse>(request, options);
        }



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
        public virtual Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteServer

        internal virtual DeleteServerResponse DeleteServer(DeleteServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return Invoke<DeleteServerResponse>(request, options);
        }



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
        public virtual Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerResponse>(request, options, cancellationToken);
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
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBackups

        internal virtual DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupsResponse>(request, options);
        }



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
        public virtual Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBackupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }



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
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNodeAssociationStatus

        internal virtual DescribeNodeAssociationStatusResponse DescribeNodeAssociationStatus(DescribeNodeAssociationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeAssociationStatusResponse>(request, options);
        }



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
        public virtual Task<DescribeNodeAssociationStatusResponse> DescribeNodeAssociationStatusAsync(DescribeNodeAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNodeAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeAssociationStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeServers

        internal virtual DescribeServersResponse DescribeServers(DescribeServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return Invoke<DescribeServersResponse>(request, options);
        }



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
        public virtual Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateNode

        internal virtual DisassociateNodeResponse DisassociateNode(DisassociateNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return Invoke<DisassociateNodeResponse>(request, options);
        }



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
        public virtual Task<DisassociateNodeResponse> DisassociateNodeAsync(DisassociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportServerEngineAttribute

        internal virtual ExportServerEngineAttributeResponse ExportServerEngineAttribute(ExportServerEngineAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportServerEngineAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportServerEngineAttributeResponseUnmarshaller.Instance;

            return Invoke<ExportServerEngineAttributeResponse>(request, options);
        }



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
        public virtual Task<ExportServerEngineAttributeResponse> ExportServerEngineAttributeAsync(ExportServerEngineAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportServerEngineAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportServerEngineAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ExportServerEngineAttributeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestoreServer

        internal virtual RestoreServerResponse RestoreServer(RestoreServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return Invoke<RestoreServerResponse>(request, options);
        }



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
        public virtual Task<RestoreServerResponse> RestoreServerAsync(RestoreServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartMaintenance

        internal virtual StartMaintenanceResponse StartMaintenance(StartMaintenanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return Invoke<StartMaintenanceResponse>(request, options);
        }



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
        public virtual Task<StartMaintenanceResponse> StartMaintenanceAsync(StartMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMaintenanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartMaintenanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateServer

        internal virtual UpdateServerResponse UpdateServer(UpdateServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return Invoke<UpdateServerResponse>(request, options);
        }



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
        public virtual Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateServerEngineAttributes

        internal virtual UpdateServerEngineAttributesResponse UpdateServerEngineAttributes(UpdateServerEngineAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerEngineAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateServerEngineAttributesResponse>(request, options);
        }



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
        public virtual Task<UpdateServerEngineAttributesResponse> UpdateServerEngineAttributesAsync(UpdateServerEngineAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServerEngineAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerEngineAttributesResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}
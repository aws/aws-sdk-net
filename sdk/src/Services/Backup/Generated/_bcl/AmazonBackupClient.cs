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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Backup.Model;
using Amazon.Backup.Model.Internal.MarshallTransformations;
using Amazon.Backup.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Backup
{
    /// <summary>
    /// <para>Implementation for accessing Backup</para>
    ///
    /// Backup 
    /// <para>
    /// Backup is a unified backup service designed to protect Amazon Web Services services
    /// and their associated data. Backup simplifies the creation, migration, restoration,
    /// and deletion of backups, while also providing reporting and auditing.
    /// </para>
    /// </summary>
    public partial class AmazonBackupClient : AmazonServiceClient, IAmazonBackup
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupMetadata();
        private IBackupPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBackupPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BackupPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        public AmazonBackupClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupConfig()) { }

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        public AmazonBackupClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBackupClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(AmazonBackupConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBackupClient(AWSCredentials credentials)
            : this(credentials, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBackupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Credentials and an
        /// AmazonBackupClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(AWSCredentials credentials, AmazonBackupConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBackupConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBackupClient Configuration Object</param>
        public AmazonBackupClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBackupConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBackupEndpointResolver());
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


        #region  CancelLegalHold


        /// <summary>
        /// This action removes the specified legal hold on a recovery point. This action can
        /// only be performed by a user with sufficient permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLegalHold service method.</param>
        /// 
        /// <returns>The response from the CancelLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CancelLegalHold">REST API Reference for CancelLegalHold Operation</seealso>
        public virtual CancelLegalHoldResponse CancelLegalHold(CancelLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLegalHoldResponseUnmarshaller.Instance;

            return Invoke<CancelLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// This action removes the specified legal hold on a recovery point. This action can
        /// only be performed by a user with sufficient permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CancelLegalHold">REST API Reference for CancelLegalHold Operation</seealso>
        public virtual Task<CancelLegalHoldResponse> CancelLegalHoldAsync(CancelLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLegalHoldResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackupPlan


        /// <summary>
        /// Creates a backup plan using a backup plan name and backup rules. A backup plan is
        /// a document that contains information that Backup uses to schedule tasks that create
        /// recovery points for resources.
        /// 
        ///  
        /// <para>
        /// If you call <c>CreateBackupPlan</c> with a plan that already exists, you receive an
        /// <c>AlreadyExistsException</c> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan service method.</param>
        /// 
        /// <returns>The response from the CreateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<CreateBackupPlanResponse>(request, options);
        }


        /// <summary>
        /// Creates a backup plan using a backup plan name and backup rules. A backup plan is
        /// a document that contains information that Backup uses to schedule tasks that create
        /// recovery points for resources.
        /// 
        ///  
        /// <para>
        /// If you call <c>CreateBackupPlan</c> with a plan that already exists, you receive an
        /// <c>AlreadyExistsException</c> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBackupPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackupSelection


        /// <summary>
        /// Creates a JSON document that specifies a set of resources to assign to a backup plan.
        /// For examples, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/assigning-resources.html#assigning-resources-json">Assigning
        /// resources programmatically</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection service method.</param>
        /// 
        /// <returns>The response from the CreateBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual CreateBackupSelectionResponse CreateBackupSelection(CreateBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateBackupSelectionResponse>(request, options);
        }


        /// <summary>
        /// Creates a JSON document that specifies a set of resources to assign to a backup plan.
        /// For examples, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/assigning-resources.html#assigning-resources-json">Assigning
        /// resources programmatically</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual Task<CreateBackupSelectionResponse> CreateBackupSelectionAsync(CreateBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBackupSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackupVault


        /// <summary>
        /// Creates a logical container where backups are stored. A <c>CreateBackupVault</c> request
        /// includes a name, optionally one or more resource tags, an encryption key, and a request
        /// ID.
        /// 
        ///  <note> 
        /// <para>
        /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault service method.</param>
        /// 
        /// <returns>The response from the CreateBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual CreateBackupVaultResponse CreateBackupVault(CreateBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// Creates a logical container where backups are stored. A <c>CreateBackupVault</c> request
        /// includes a name, optionally one or more resource tags, an encryption key, and a request
        /// ID.
        /// 
        ///  <note> 
        /// <para>
        /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual Task<CreateBackupVaultResponse> CreateBackupVaultAsync(CreateBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFramework


        /// <summary>
        /// Creates a framework with one or more controls. A framework is a collection of controls
        /// that you can use to evaluate your backup practices. By using pre-built customizable
        /// controls to define your policies, you can evaluate whether your backup practices comply
        /// with your policies and which resources are not yet in compliance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFramework service method.</param>
        /// 
        /// <returns>The response from the CreateFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateFramework">REST API Reference for CreateFramework Operation</seealso>
        public virtual CreateFrameworkResponse CreateFramework(CreateFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFrameworkResponseUnmarshaller.Instance;

            return Invoke<CreateFrameworkResponse>(request, options);
        }


        /// <summary>
        /// Creates a framework with one or more controls. A framework is a collection of controls
        /// that you can use to evaluate your backup practices. By using pre-built customizable
        /// controls to define your policies, you can evaluate whether your backup practices comply
        /// with your policies and which resources are not yet in compliance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateFramework">REST API Reference for CreateFramework Operation</seealso>
        public virtual Task<CreateFrameworkResponse> CreateFrameworkAsync(CreateFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFrameworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLegalHold


        /// <summary>
        /// This action creates a legal hold on a recovery point (backup). A legal hold is a restraint
        /// on altering or deleting a backup until an authorized user cancels the legal hold.
        /// Any actions to delete or disassociate a recovery point will fail with an error if
        /// one or more active legal holds are on the recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLegalHold service method.</param>
        /// 
        /// <returns>The response from the CreateLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLegalHold">REST API Reference for CreateLegalHold Operation</seealso>
        public virtual CreateLegalHoldResponse CreateLegalHold(CreateLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLegalHoldResponseUnmarshaller.Instance;

            return Invoke<CreateLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// This action creates a legal hold on a recovery point (backup). A legal hold is a restraint
        /// on altering or deleting a backup until an authorized user cancels the legal hold.
        /// Any actions to delete or disassociate a recovery point will fail with an error if
        /// one or more active legal holds are on the recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLegalHold">REST API Reference for CreateLegalHold Operation</seealso>
        public virtual Task<CreateLegalHoldResponse> CreateLegalHoldAsync(CreateLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLegalHoldResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLogicallyAirGappedBackupVault


        /// <summary>
        /// This request creates a logical container to where backups may be copied.
        /// 
        ///  
        /// <para>
        /// This request includes a name, the Region, the maximum number of retention days, the
        /// minimum number of retention days, and optionally can include tags and a creator request
        /// ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogicallyAirGappedBackupVault service method.</param>
        /// 
        /// <returns>The response from the CreateLogicallyAirGappedBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLogicallyAirGappedBackupVault">REST API Reference for CreateLogicallyAirGappedBackupVault Operation</seealso>
        public virtual CreateLogicallyAirGappedBackupVaultResponse CreateLogicallyAirGappedBackupVault(CreateLogicallyAirGappedBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogicallyAirGappedBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogicallyAirGappedBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateLogicallyAirGappedBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// This request creates a logical container to where backups may be copied.
        /// 
        ///  
        /// <para>
        /// This request includes a name, the Region, the maximum number of retention days, the
        /// minimum number of retention days, and optionally can include tags and a creator request
        /// ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogicallyAirGappedBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLogicallyAirGappedBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLogicallyAirGappedBackupVault">REST API Reference for CreateLogicallyAirGappedBackupVault Operation</seealso>
        public virtual Task<CreateLogicallyAirGappedBackupVaultResponse> CreateLogicallyAirGappedBackupVaultAsync(CreateLogicallyAirGappedBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogicallyAirGappedBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogicallyAirGappedBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLogicallyAirGappedBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReportPlan


        /// <summary>
        /// Creates a report plan. A report plan is a document that contains information about
        /// the contents of the report and where Backup will deliver it.
        /// 
        ///  
        /// <para>
        /// If you call <c>CreateReportPlan</c> with a plan that already exists, you receive an
        /// <c>AlreadyExistsException</c> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportPlan service method.</param>
        /// 
        /// <returns>The response from the CreateReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateReportPlan">REST API Reference for CreateReportPlan Operation</seealso>
        public virtual CreateReportPlanResponse CreateReportPlan(CreateReportPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportPlanResponseUnmarshaller.Instance;

            return Invoke<CreateReportPlanResponse>(request, options);
        }


        /// <summary>
        /// Creates a report plan. A report plan is a document that contains information about
        /// the contents of the report and where Backup will deliver it.
        /// 
        ///  
        /// <para>
        /// If you call <c>CreateReportPlan</c> with a plan that already exists, you receive an
        /// <c>AlreadyExistsException</c> exception.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReportPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateReportPlan">REST API Reference for CreateReportPlan Operation</seealso>
        public virtual Task<CreateReportPlanResponse> CreateReportPlanAsync(CreateReportPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReportPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRestoreTestingPlan


        /// <summary>
        /// This is the first of two steps to create a restore testing plan; once this request
        /// is successful, finish the procedure with request CreateRestoreTestingSelection.
        /// 
        ///  
        /// <para>
        /// You must include the parameter RestoreTestingPlan. You may optionally include CreatorRequestId
        /// and Tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingPlan service method.</param>
        /// 
        /// <returns>The response from the CreateRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingPlan">REST API Reference for CreateRestoreTestingPlan Operation</seealso>
        public virtual CreateRestoreTestingPlanResponse CreateRestoreTestingPlan(CreateRestoreTestingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<CreateRestoreTestingPlanResponse>(request, options);
        }


        /// <summary>
        /// This is the first of two steps to create a restore testing plan; once this request
        /// is successful, finish the procedure with request CreateRestoreTestingSelection.
        /// 
        ///  
        /// <para>
        /// You must include the parameter RestoreTestingPlan. You may optionally include CreatorRequestId
        /// and Tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingPlan">REST API Reference for CreateRestoreTestingPlan Operation</seealso>
        public virtual Task<CreateRestoreTestingPlanResponse> CreateRestoreTestingPlanAsync(CreateRestoreTestingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRestoreTestingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRestoreTestingSelection


        /// <summary>
        /// This request can be sent after CreateRestoreTestingPlan request returns successfully.
        /// This is the second part of creating a resource testing plan, and it must be completed
        /// sequentially.
        /// 
        ///  
        /// <para>
        /// This consists of <c>RestoreTestingSelectionName</c>, <c>ProtectedResourceType</c>,
        /// and one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProtectedResourceArns</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProtectedResourceConditions</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each protected resource type can have one single value.
        /// </para>
        ///  
        /// <para>
        /// A restore testing selection can include a wildcard value ("*") for <c>ProtectedResourceArns</c>
        /// along with <c>ProtectedResourceConditions</c>. Alternatively, you can include up to
        /// 30 specific protected resource ARNs in <c>ProtectedResourceArns</c>.
        /// </para>
        ///  
        /// <para>
        /// Cannot select by both protected resource types AND specific ARNs. Request will fail
        /// if both are included.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingSelection service method.</param>
        /// 
        /// <returns>The response from the CreateRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingSelection">REST API Reference for CreateRestoreTestingSelection Operation</seealso>
        public virtual CreateRestoreTestingSelectionResponse CreateRestoreTestingSelection(CreateRestoreTestingSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateRestoreTestingSelectionResponse>(request, options);
        }


        /// <summary>
        /// This request can be sent after CreateRestoreTestingPlan request returns successfully.
        /// This is the second part of creating a resource testing plan, and it must be completed
        /// sequentially.
        /// 
        ///  
        /// <para>
        /// This consists of <c>RestoreTestingSelectionName</c>, <c>ProtectedResourceType</c>,
        /// and one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProtectedResourceArns</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProtectedResourceConditions</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each protected resource type can have one single value.
        /// </para>
        ///  
        /// <para>
        /// A restore testing selection can include a wildcard value ("*") for <c>ProtectedResourceArns</c>
        /// along with <c>ProtectedResourceConditions</c>. Alternatively, you can include up to
        /// 30 specific protected resource ARNs in <c>ProtectedResourceArns</c>.
        /// </para>
        ///  
        /// <para>
        /// Cannot select by both protected resource types AND specific ARNs. Request will fail
        /// if both are included.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingSelection">REST API Reference for CreateRestoreTestingSelection Operation</seealso>
        public virtual Task<CreateRestoreTestingSelectionResponse> CreateRestoreTestingSelectionAsync(CreateRestoreTestingSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRestoreTestingSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupPlan


        /// <summary>
        /// Deletes a backup plan. A backup plan can only be deleted after all associated selections
        /// of resources have been deleted. Deleting a backup plan deletes the current version
        /// of a backup plan. Previous versions, if any, will still exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupPlanResponse>(request, options);
        }


        /// <summary>
        /// Deletes a backup plan. A backup plan can only be deleted after all associated selections
        /// of resources have been deleted. Deleting a backup plan deletes the current version
        /// of a backup plan. Previous versions, if any, will still exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual Task<DeleteBackupPlanResponse> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupSelection


        /// <summary>
        /// Deletes the resource selection associated with a backup plan that is specified by
        /// the <c>SelectionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual DeleteBackupSelectionResponse DeleteBackupSelection(DeleteBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupSelectionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the resource selection associated with a backup plan that is specified by
        /// the <c>SelectionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual Task<DeleteBackupSelectionResponse> DeleteBackupSelectionAsync(DeleteBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupVault


        /// <summary>
        /// Deletes the backup vault identified by its name. A vault can be deleted only if it
        /// is empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual DeleteBackupVaultResponse DeleteBackupVault(DeleteBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// Deletes the backup vault identified by its name. A vault can be deleted only if it
        /// is empty.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual Task<DeleteBackupVaultResponse> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupVaultAccessPolicy


        /// <summary>
        /// Deletes the policy document that manages permissions on a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual DeleteBackupVaultAccessPolicyResponse DeleteBackupVaultAccessPolicy(DeleteBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the policy document that manages permissions on a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual Task<DeleteBackupVaultAccessPolicyResponse> DeleteBackupVaultAccessPolicyAsync(DeleteBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupVaultLockConfiguration


        /// <summary>
        /// Deletes Backup Vault Lock from a backup vault specified by a backup vault name.
        /// 
        ///  
        /// <para>
        /// If the Vault Lock configuration is immutable, then you cannot delete Vault Lock using
        /// API operations, and you will receive an <c>InvalidRequestException</c> if you attempt
        /// to do so. For more information, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/vault-lock.html">Vault
        /// Lock</a> in the <i>Backup Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultLockConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVaultLockConfiguration service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultLockConfiguration">REST API Reference for DeleteBackupVaultLockConfiguration Operation</seealso>
        public virtual DeleteBackupVaultLockConfigurationResponse DeleteBackupVaultLockConfiguration(DeleteBackupVaultLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultLockConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes Backup Vault Lock from a backup vault specified by a backup vault name.
        /// 
        ///  
        /// <para>
        /// If the Vault Lock configuration is immutable, then you cannot delete Vault Lock using
        /// API operations, and you will receive an <c>InvalidRequestException</c> if you attempt
        /// to do so. For more information, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/vault-lock.html">Vault
        /// Lock</a> in the <i>Backup Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultLockConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupVaultLockConfiguration service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultLockConfiguration">REST API Reference for DeleteBackupVaultLockConfiguration Operation</seealso>
        public virtual Task<DeleteBackupVaultLockConfigurationResponse> DeleteBackupVaultLockConfigurationAsync(DeleteBackupVaultLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultLockConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupVaultLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackupVaultNotifications


        /// <summary>
        /// Deletes event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual DeleteBackupVaultNotificationsResponse DeleteBackupVaultNotifications(DeleteBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Deletes event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual Task<DeleteBackupVaultNotificationsResponse> DeleteBackupVaultNotificationsAsync(DeleteBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBackupVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFramework


        /// <summary>
        /// Deletes the framework specified by a framework name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFramework service method.</param>
        /// 
        /// <returns>The response from the DeleteFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteFramework">REST API Reference for DeleteFramework Operation</seealso>
        public virtual DeleteFrameworkResponse DeleteFramework(DeleteFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFrameworkResponseUnmarshaller.Instance;

            return Invoke<DeleteFrameworkResponse>(request, options);
        }


        /// <summary>
        /// Deletes the framework specified by a framework name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteFramework">REST API Reference for DeleteFramework Operation</seealso>
        public virtual Task<DeleteFrameworkResponse> DeleteFrameworkAsync(DeleteFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFrameworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRecoveryPoint


        /// <summary>
        /// Deletes the recovery point specified by a recovery point ID.
        /// 
        ///  
        /// <para>
        /// If the recovery point ID belongs to a continuous backup, calling this endpoint deletes
        /// the existing continuous backup and stops future continuous backup.
        /// </para>
        ///  
        /// <para>
        /// When an IAM role's permissions are insufficient to call this API, the service sends
        /// back an HTTP 200 response with an empty HTTP body, but the recovery point is not deleted.
        /// Instead, it enters an <c>EXPIRED</c> state.
        /// </para>
        ///  
        /// <para>
        ///  <c>EXPIRED</c> recovery points can be deleted with this API once the IAM role has
        /// the <c>iam:CreateServiceLinkedRole</c> action. To learn more about adding this role,
        /// see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/deleting-backups.html#deleting-backups-troubleshooting">
        /// Troubleshooting manual deletions</a>.
        /// </para>
        ///  
        /// <para>
        /// If the user or role is deleted or the permission within the role is removed, the deletion
        /// will not be successful and will enter an <c>EXPIRED</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual DeleteRecoveryPointResponse DeleteRecoveryPoint(DeleteRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryPointResponse>(request, options);
        }


        /// <summary>
        /// Deletes the recovery point specified by a recovery point ID.
        /// 
        ///  
        /// <para>
        /// If the recovery point ID belongs to a continuous backup, calling this endpoint deletes
        /// the existing continuous backup and stops future continuous backup.
        /// </para>
        ///  
        /// <para>
        /// When an IAM role's permissions are insufficient to call this API, the service sends
        /// back an HTTP 200 response with an empty HTTP body, but the recovery point is not deleted.
        /// Instead, it enters an <c>EXPIRED</c> state.
        /// </para>
        ///  
        /// <para>
        ///  <c>EXPIRED</c> recovery points can be deleted with this API once the IAM role has
        /// the <c>iam:CreateServiceLinkedRole</c> action. To learn more about adding this role,
        /// see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/deleting-backups.html#deleting-backups-troubleshooting">
        /// Troubleshooting manual deletions</a>.
        /// </para>
        ///  
        /// <para>
        /// If the user or role is deleted or the permission within the role is removed, the deletion
        /// will not be successful and will enter an <c>EXPIRED</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual Task<DeleteRecoveryPointResponse> DeleteRecoveryPointAsync(DeleteRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReportPlan


        /// <summary>
        /// Deletes the report plan specified by a report plan name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteReportPlan">REST API Reference for DeleteReportPlan Operation</seealso>
        public virtual DeleteReportPlanResponse DeleteReportPlan(DeleteReportPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteReportPlanResponse>(request, options);
        }


        /// <summary>
        /// Deletes the report plan specified by a report plan name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteReportPlan">REST API Reference for DeleteReportPlan Operation</seealso>
        public virtual Task<DeleteReportPlanResponse> DeleteReportPlanAsync(DeleteReportPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReportPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRestoreTestingPlan


        /// <summary>
        /// This request deletes the specified restore testing plan.
        /// 
        ///  
        /// <para>
        /// Deletion can only successfully occur if all associated restore testing selections
        /// are deleted first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingPlan">REST API Reference for DeleteRestoreTestingPlan Operation</seealso>
        public virtual DeleteRestoreTestingPlanResponse DeleteRestoreTestingPlan(DeleteRestoreTestingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteRestoreTestingPlanResponse>(request, options);
        }


        /// <summary>
        /// This request deletes the specified restore testing plan.
        /// 
        ///  
        /// <para>
        /// Deletion can only successfully occur if all associated restore testing selections
        /// are deleted first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingPlan">REST API Reference for DeleteRestoreTestingPlan Operation</seealso>
        public virtual Task<DeleteRestoreTestingPlanResponse> DeleteRestoreTestingPlanAsync(DeleteRestoreTestingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRestoreTestingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRestoreTestingSelection


        /// <summary>
        /// Input the Restore Testing Plan name and Restore Testing Selection name.
        /// 
        ///  
        /// <para>
        /// All testing selections associated with a restore testing plan must be deleted before
        /// the restore testing plan can be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingSelection service method.</param>
        /// 
        /// <returns>The response from the DeleteRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingSelection">REST API Reference for DeleteRestoreTestingSelection Operation</seealso>
        public virtual DeleteRestoreTestingSelectionResponse DeleteRestoreTestingSelection(DeleteRestoreTestingSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteRestoreTestingSelectionResponse>(request, options);
        }


        /// <summary>
        /// Input the Restore Testing Plan name and Restore Testing Selection name.
        /// 
        ///  
        /// <para>
        /// All testing selections associated with a restore testing plan must be deleted before
        /// the restore testing plan can be deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingSelection">REST API Reference for DeleteRestoreTestingSelection Operation</seealso>
        public virtual Task<DeleteRestoreTestingSelectionResponse> DeleteRestoreTestingSelectionAsync(DeleteRestoreTestingSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRestoreTestingSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackupJob


        /// <summary>
        /// Returns backup job details for the specified <c>BackupJobId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob service method.</param>
        /// 
        /// <returns>The response from the DescribeBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent Amazon Web Services service or resource returned an error to the Backup
        /// service, and the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual DescribeBackupJobResponse DescribeBackupJob(DescribeBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupJobResponse>(request, options);
        }


        /// <summary>
        /// Returns backup job details for the specified <c>BackupJobId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent Amazon Web Services service or resource returned an error to the Backup
        /// service, and the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual Task<DescribeBackupJobResponse> DescribeBackupJobAsync(DescribeBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBackupJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackupVault


        /// <summary>
        /// Returns metadata about a backup vault specified by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault service method.</param>
        /// 
        /// <returns>The response from the DescribeBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual DescribeBackupVaultResponse DescribeBackupVault(DescribeBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata about a backup vault specified by its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual Task<DescribeBackupVaultResponse> DescribeBackupVaultAsync(DescribeBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCopyJob


        /// <summary>
        /// Returns metadata associated with creating a copy of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyJob service method.</param>
        /// 
        /// <returns>The response from the DescribeCopyJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeCopyJob">REST API Reference for DescribeCopyJob Operation</seealso>
        public virtual DescribeCopyJobResponse DescribeCopyJob(DescribeCopyJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyJobResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyJobResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata associated with creating a copy of a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCopyJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeCopyJob">REST API Reference for DescribeCopyJob Operation</seealso>
        public virtual Task<DescribeCopyJobResponse> DescribeCopyJobAsync(DescribeCopyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCopyJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFramework


        /// <summary>
        /// Returns the framework details for the specified <c>FrameworkName</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFramework service method.</param>
        /// 
        /// <returns>The response from the DescribeFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeFramework">REST API Reference for DescribeFramework Operation</seealso>
        public virtual DescribeFrameworkResponse DescribeFramework(DescribeFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFrameworkResponseUnmarshaller.Instance;

            return Invoke<DescribeFrameworkResponse>(request, options);
        }


        /// <summary>
        /// Returns the framework details for the specified <c>FrameworkName</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeFramework">REST API Reference for DescribeFramework Operation</seealso>
        public virtual Task<DescribeFrameworkResponse> DescribeFrameworkAsync(DescribeFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFrameworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalSettings


        /// <summary>
        /// Describes whether the Amazon Web Services account is opted in to cross-account backup.
        /// Returns an error if the account is not a member of an Organizations organization.
        /// Example: <c>describe-global-settings --region us-west-2</c>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeGlobalSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeGlobalSettings">REST API Reference for DescribeGlobalSettings Operation</seealso>
        public virtual DescribeGlobalSettingsResponse DescribeGlobalSettings(DescribeGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalSettingsResponse>(request, options);
        }


        /// <summary>
        /// Describes whether the Amazon Web Services account is opted in to cross-account backup.
        /// Returns an error if the account is not a member of an Organizations organization.
        /// Example: <c>describe-global-settings --region us-west-2</c>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeGlobalSettings">REST API Reference for DescribeGlobalSettings Operation</seealso>
        public virtual Task<DescribeGlobalSettingsResponse> DescribeGlobalSettingsAsync(DescribeGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGlobalSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeProtectedResource


        /// <summary>
        /// Returns information about a saved resource, including the last time it was backed
        /// up, its Amazon Resource Name (ARN), and the Amazon Web Services service type of the
        /// saved resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource service method.</param>
        /// 
        /// <returns>The response from the DescribeProtectedResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual DescribeProtectedResourceResponse DescribeProtectedResource(DescribeProtectedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectedResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a saved resource, including the last time it was backed
        /// up, its Amazon Resource Name (ARN), and the Amazon Web Services service type of the
        /// saved resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtectedResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual Task<DescribeProtectedResourceResponse> DescribeProtectedResourceAsync(DescribeProtectedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeProtectedResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecoveryPoint


        /// <summary>
        /// Returns metadata associated with a recovery point, including ID, status, encryption,
        /// and lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the DescribeRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual DescribeRecoveryPointResponse DescribeRecoveryPoint(DescribeRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DescribeRecoveryPointResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata associated with a recovery point, including ID, status, encryption,
        /// and lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual Task<DescribeRecoveryPointResponse> DescribeRecoveryPointAsync(DescribeRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegionSettings


        /// <summary>
        /// Returns the current service opt-in settings for the Region. If service opt-in is enabled
        /// for a service, Backup tries to protect that service's resources in this Region, when
        /// the resource is included in an on-demand backup or scheduled backup plan. Otherwise,
        /// Backup does not try to protect that service's resources in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegionSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeRegionSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRegionSettings">REST API Reference for DescribeRegionSettings Operation</seealso>
        public virtual DescribeRegionSettingsResponse DescribeRegionSettings(DescribeRegionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Returns the current service opt-in settings for the Region. If service opt-in is enabled
        /// for a service, Backup tries to protect that service's resources in this Region, when
        /// the resource is included in an on-demand backup or scheduled backup plan. Otherwise,
        /// Backup does not try to protect that service's resources in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegionSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRegionSettings">REST API Reference for DescribeRegionSettings Operation</seealso>
        public virtual Task<DescribeRegionSettingsResponse> DescribeRegionSettingsAsync(DescribeRegionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRegionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReportJob


        /// <summary>
        /// Returns the details associated with creating a report as specified by its <c>ReportJobId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeReportJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportJob">REST API Reference for DescribeReportJob Operation</seealso>
        public virtual DescribeReportJobResponse DescribeReportJob(DescribeReportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeReportJobResponse>(request, options);
        }


        /// <summary>
        /// Returns the details associated with creating a report as specified by its <c>ReportJobId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportJob">REST API Reference for DescribeReportJob Operation</seealso>
        public virtual Task<DescribeReportJobResponse> DescribeReportJobAsync(DescribeReportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReportPlan


        /// <summary>
        /// Returns a list of all report plans for an Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportPlan">REST API Reference for DescribeReportPlan Operation</seealso>
        public virtual DescribeReportPlanResponse DescribeReportPlan(DescribeReportPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeReportPlanResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all report plans for an Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportPlan">REST API Reference for DescribeReportPlan Operation</seealso>
        public virtual Task<DescribeReportPlanResponse> DescribeReportPlanAsync(DescribeReportPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReportPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRestoreJob


        /// <summary>
        /// Returns metadata associated with a restore job that is specified by a job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob service method.</param>
        /// 
        /// <returns>The response from the DescribeRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent Amazon Web Services service or resource returned an error to the Backup
        /// service, and the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual DescribeRestoreJobResponse DescribeRestoreJob(DescribeRestoreJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;

            return Invoke<DescribeRestoreJobResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata associated with a restore job that is specified by a job ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent Amazon Web Services service or resource returned an error to the Backup
        /// service, and the action cannot be completed.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual Task<DescribeRestoreJobResponse> DescribeRestoreJobAsync(DescribeRestoreJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRestoreJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRecoveryPoint


        /// <summary>
        /// Deletes the specified continuous backup recovery point from Backup and releases control
        /// of that continuous backup to the source service, such as Amazon RDS. The source service
        /// will continue to create and retain continuous backups using the lifecycle that you
        /// specified in your original backup plan.
        /// 
        ///  
        /// <para>
        /// Does not support snapshot backup recovery points.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPoint service method.</param>
        /// 
        /// <returns>The response from the DisassociateRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPoint">REST API Reference for DisassociateRecoveryPoint Operation</seealso>
        public virtual DisassociateRecoveryPointResponse DisassociateRecoveryPoint(DisassociateRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DisassociateRecoveryPointResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified continuous backup recovery point from Backup and releases control
        /// of that continuous backup to the source service, such as Amazon RDS. The source service
        /// will continue to create and retain continuous backups using the lifecycle that you
        /// specified in your original backup plan.
        /// 
        ///  
        /// <para>
        /// Does not support snapshot backup recovery points.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRecoveryPoint service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidResourceStateException">
        /// Backup is already performing an action on this recovery point. It can't perform the
        /// action you requested until the first action finishes. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPoint">REST API Reference for DisassociateRecoveryPoint Operation</seealso>
        public virtual Task<DisassociateRecoveryPointResponse> DisassociateRecoveryPointAsync(DisassociateRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRecoveryPointFromParent


        /// <summary>
        /// This action to a specific child (nested) recovery point removes the relationship between
        /// the specified recovery point and its parent (composite) recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPointFromParent service method.</param>
        /// 
        /// <returns>The response from the DisassociateRecoveryPointFromParent service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPointFromParent">REST API Reference for DisassociateRecoveryPointFromParent Operation</seealso>
        public virtual DisassociateRecoveryPointFromParentResponse DisassociateRecoveryPointFromParent(DisassociateRecoveryPointFromParentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointFromParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointFromParentResponseUnmarshaller.Instance;

            return Invoke<DisassociateRecoveryPointFromParentResponse>(request, options);
        }


        /// <summary>
        /// This action to a specific child (nested) recovery point removes the relationship between
        /// the specified recovery point and its parent (composite) recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPointFromParent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRecoveryPointFromParent service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPointFromParent">REST API Reference for DisassociateRecoveryPointFromParent Operation</seealso>
        public virtual Task<DisassociateRecoveryPointFromParentResponse> DisassociateRecoveryPointFromParentAsync(DisassociateRecoveryPointFromParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointFromParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointFromParentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateRecoveryPointFromParentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportBackupPlanTemplate


        /// <summary>
        /// Returns the backup plan that is specified by the plan ID as a backup template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate service method.</param>
        /// 
        /// <returns>The response from the ExportBackupPlanTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual ExportBackupPlanTemplateResponse ExportBackupPlanTemplate(ExportBackupPlanTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;

            return Invoke<ExportBackupPlanTemplateResponse>(request, options);
        }


        /// <summary>
        /// Returns the backup plan that is specified by the plan ID as a backup template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportBackupPlanTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual Task<ExportBackupPlanTemplateResponse> ExportBackupPlanTemplateAsync(ExportBackupPlanTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportBackupPlanTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupPlan


        /// <summary>
        /// Returns <c>BackupPlan</c> details for the specified <c>BackupPlanId</c>. The details
        /// are the body of a backup plan in JSON format, in addition to plan metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual GetBackupPlanResponse GetBackupPlan(GetBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanResponse>(request, options);
        }


        /// <summary>
        /// Returns <c>BackupPlan</c> details for the specified <c>BackupPlanId</c>. The details
        /// are the body of a backup plan in JSON format, in addition to plan metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual Task<GetBackupPlanResponse> GetBackupPlanAsync(GetBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupPlanFromJSON


        /// <summary>
        /// Returns a valid JSON document specifying a backup plan or an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlanFromJSON service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual GetBackupPlanFromJSONResponse GetBackupPlanFromJSON(GetBackupPlanFromJSONRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromJSONResponse>(request, options);
        }


        /// <summary>
        /// Returns a valid JSON document specifying a backup plan or an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupPlanFromJSON service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual Task<GetBackupPlanFromJSONResponse> GetBackupPlanFromJSONAsync(GetBackupPlanFromJSONRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupPlanFromJSONResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupPlanFromTemplate


        /// <summary>
        /// Returns the template specified by its <c>templateId</c> as a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate service method.</param>
        /// 
        /// <returns>The response from the GetBackupPlanFromTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual GetBackupPlanFromTemplateResponse GetBackupPlanFromTemplate(GetBackupPlanFromTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromTemplateResponse>(request, options);
        }


        /// <summary>
        /// Returns the template specified by its <c>templateId</c> as a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupPlanFromTemplate service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual Task<GetBackupPlanFromTemplateResponse> GetBackupPlanFromTemplateAsync(GetBackupPlanFromTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupPlanFromTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupSelection


        /// <summary>
        /// Returns selection metadata and a document in JSON format that specifies a list of
        /// resources that are associated with a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection service method.</param>
        /// 
        /// <returns>The response from the GetBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual GetBackupSelectionResponse GetBackupSelection(GetBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<GetBackupSelectionResponse>(request, options);
        }


        /// <summary>
        /// Returns selection metadata and a document in JSON format that specifies a list of
        /// resources that are associated with a backup plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual Task<GetBackupSelectionResponse> GetBackupSelectionAsync(GetBackupSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupVaultAccessPolicy


        /// <summary>
        /// Returns the access policy document that is associated with the named backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual GetBackupVaultAccessPolicyResponse GetBackupVaultAccessPolicy(GetBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the access policy document that is associated with the named backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual Task<GetBackupVaultAccessPolicyResponse> GetBackupVaultAccessPolicyAsync(GetBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBackupVaultNotifications


        /// <summary>
        /// Returns event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the GetBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual GetBackupVaultNotificationsResponse GetBackupVaultNotifications(GetBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Returns event notifications for the specified backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual Task<GetBackupVaultNotificationsResponse> GetBackupVaultNotificationsAsync(GetBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBackupVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLegalHold


        /// <summary>
        /// This action returns details for a specified legal hold. The details are the body of
        /// a legal hold in JSON format, in addition to metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLegalHold service method.</param>
        /// 
        /// <returns>The response from the GetLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetLegalHold">REST API Reference for GetLegalHold Operation</seealso>
        public virtual GetLegalHoldResponse GetLegalHold(GetLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLegalHoldResponseUnmarshaller.Instance;

            return Invoke<GetLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// This action returns details for a specified legal hold. The details are the body of
        /// a legal hold in JSON format, in addition to metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetLegalHold">REST API Reference for GetLegalHold Operation</seealso>
        public virtual Task<GetLegalHoldResponse> GetLegalHoldAsync(GetLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLegalHoldResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecoveryPointRestoreMetadata


        /// <summary>
        /// Returns a set of metadata key-value pairs that were used to create the backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryPointRestoreMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual GetRecoveryPointRestoreMetadataResponse GetRecoveryPointRestoreMetadata(GetRecoveryPointRestoreMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointRestoreMetadataResponse>(request, options);
        }


        /// <summary>
        /// Returns a set of metadata key-value pairs that were used to create the backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecoveryPointRestoreMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual Task<GetRecoveryPointRestoreMetadataResponse> GetRecoveryPointRestoreMetadataAsync(GetRecoveryPointRestoreMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRecoveryPointRestoreMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRestoreJobMetadata


        /// <summary>
        /// This request returns the metadata for the specified restore job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreJobMetadata service method.</param>
        /// 
        /// <returns>The response from the GetRestoreJobMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreJobMetadata">REST API Reference for GetRestoreJobMetadata Operation</seealso>
        public virtual GetRestoreJobMetadataResponse GetRestoreJobMetadata(GetRestoreJobMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreJobMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreJobMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRestoreJobMetadataResponse>(request, options);
        }


        /// <summary>
        /// This request returns the metadata for the specified restore job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreJobMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestoreJobMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreJobMetadata">REST API Reference for GetRestoreJobMetadata Operation</seealso>
        public virtual Task<GetRestoreJobMetadataResponse> GetRestoreJobMetadataAsync(GetRestoreJobMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreJobMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreJobMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRestoreJobMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRestoreTestingInferredMetadata


        /// <summary>
        /// This request returns the minimal required set of metadata needed to start a restore
        /// job with secure default settings. <c>BackupVaultName</c> and <c>RecoveryPointArn</c>
        /// are required parameters. <c>BackupVaultAccountId</c> is an optional parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingInferredMetadata service method.</param>
        /// 
        /// <returns>The response from the GetRestoreTestingInferredMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingInferredMetadata">REST API Reference for GetRestoreTestingInferredMetadata Operation</seealso>
        public virtual GetRestoreTestingInferredMetadataResponse GetRestoreTestingInferredMetadata(GetRestoreTestingInferredMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingInferredMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingInferredMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingInferredMetadataResponse>(request, options);
        }


        /// <summary>
        /// This request returns the minimal required set of metadata needed to start a restore
        /// job with secure default settings. <c>BackupVaultName</c> and <c>RecoveryPointArn</c>
        /// are required parameters. <c>BackupVaultAccountId</c> is an optional parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingInferredMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestoreTestingInferredMetadata service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingInferredMetadata">REST API Reference for GetRestoreTestingInferredMetadata Operation</seealso>
        public virtual Task<GetRestoreTestingInferredMetadataResponse> GetRestoreTestingInferredMetadataAsync(GetRestoreTestingInferredMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingInferredMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingInferredMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRestoreTestingInferredMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRestoreTestingPlan


        /// <summary>
        /// Returns <c>RestoreTestingPlan</c> details for the specified <c>RestoreTestingPlanName</c>.
        /// The details are the body of a restore testing plan in JSON format, in addition to
        /// plan metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingPlan service method.</param>
        /// 
        /// <returns>The response from the GetRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingPlan">REST API Reference for GetRestoreTestingPlan Operation</seealso>
        public virtual GetRestoreTestingPlanResponse GetRestoreTestingPlan(GetRestoreTestingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingPlanResponse>(request, options);
        }


        /// <summary>
        /// Returns <c>RestoreTestingPlan</c> details for the specified <c>RestoreTestingPlanName</c>.
        /// The details are the body of a restore testing plan in JSON format, in addition to
        /// plan metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingPlan">REST API Reference for GetRestoreTestingPlan Operation</seealso>
        public virtual Task<GetRestoreTestingPlanResponse> GetRestoreTestingPlanAsync(GetRestoreTestingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRestoreTestingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRestoreTestingSelection


        /// <summary>
        /// Returns RestoreTestingSelection, which displays resources and elements of the restore
        /// testing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingSelection service method.</param>
        /// 
        /// <returns>The response from the GetRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingSelection">REST API Reference for GetRestoreTestingSelection Operation</seealso>
        public virtual GetRestoreTestingSelectionResponse GetRestoreTestingSelection(GetRestoreTestingSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingSelectionResponse>(request, options);
        }


        /// <summary>
        /// Returns RestoreTestingSelection, which displays resources and elements of the restore
        /// testing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingSelection">REST API Reference for GetRestoreTestingSelection Operation</seealso>
        public virtual Task<GetRestoreTestingSelectionResponse> GetRestoreTestingSelectionAsync(GetRestoreTestingSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRestoreTestingSelectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSupportedResourceTypes


        /// <summary>
        /// Returns the Amazon Web Services resource types supported by Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetSupportedResourceTypes service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual GetSupportedResourceTypesResponse GetSupportedResourceTypes(GetSupportedResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetSupportedResourceTypesResponse>(request, options);
        }


        /// <summary>
        /// Returns the Amazon Web Services resource types supported by Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSupportedResourceTypes service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesAsync(GetSupportedResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSupportedResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupJobs


        /// <summary>
        /// Returns a list of existing backup jobs for an authenticated account for the last 30
        /// days. For a longer period of time, consider using these <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">monitoring
        /// tools</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs service method.</param>
        /// 
        /// <returns>The response from the ListBackupJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual ListBackupJobsResponse ListBackupJobs(ListBackupJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of existing backup jobs for an authenticated account for the last 30
        /// days. For a longer period of time, consider using these <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">monitoring
        /// tools</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual Task<ListBackupJobsResponse> ListBackupJobsAsync(ListBackupJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupJobSummaries


        /// <summary>
        /// This is a request for a summary of backup jobs created or running within the most
        /// recent 30 days. You can include parameters AccountID, State, ResourceType, MessageCategory,
        /// AggregationPeriod, MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, ResourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobSummaries service method.</param>
        /// 
        /// <returns>The response from the ListBackupJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobSummaries">REST API Reference for ListBackupJobSummaries Operation</seealso>
        public virtual ListBackupJobSummariesResponse ListBackupJobSummaries(ListBackupJobSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobSummariesResponse>(request, options);
        }


        /// <summary>
        /// This is a request for a summary of backup jobs created or running within the most
        /// recent 30 days. You can include parameters AccountID, State, ResourceType, MessageCategory,
        /// AggregationPeriod, MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, ResourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobSummaries">REST API Reference for ListBackupJobSummaries Operation</seealso>
        public virtual Task<ListBackupJobSummariesResponse> ListBackupJobSummariesAsync(ListBackupJobSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupJobSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupPlans


        /// <summary>
        /// Returns a list of all active backup plans for an authenticated account. The list contains
        /// information such as Amazon Resource Names (ARNs), plan IDs, creation and deletion
        /// dates, version IDs, plan names, and creator request IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual ListBackupPlansResponse ListBackupPlans(ListBackupPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlansResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all active backup plans for an authenticated account. The list contains
        /// information such as Amazon Resource Names (ARNs), plan IDs, creation and deletion
        /// dates, version IDs, plan names, and creator request IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual Task<ListBackupPlansResponse> ListBackupPlansAsync(ListBackupPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupPlanTemplates


        /// <summary>
        /// Returns metadata of your saved backup plan templates, including the template ID, name,
        /// and the creation and deletion dates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlanTemplates service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual ListBackupPlanTemplatesResponse ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata of your saved backup plan templates, including the template ID, name,
        /// and the creation and deletion dates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupPlanTemplates service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual Task<ListBackupPlanTemplatesResponse> ListBackupPlanTemplatesAsync(ListBackupPlanTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupPlanTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupPlanVersions


        /// <summary>
        /// Returns version metadata of your backup plans, including Amazon Resource Names (ARNs),
        /// backup plan IDs, creation and deletion dates, plan names, and version IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions service method.</param>
        /// 
        /// <returns>The response from the ListBackupPlanVersions service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual ListBackupPlanVersionsResponse ListBackupPlanVersions(ListBackupPlanVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns version metadata of your backup plans, including Amazon Resource Names (ARNs),
        /// backup plan IDs, creation and deletion dates, plan names, and version IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupPlanVersions service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual Task<ListBackupPlanVersionsResponse> ListBackupPlanVersionsAsync(ListBackupPlanVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupPlanVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupSelections


        /// <summary>
        /// Returns an array containing metadata of the resources associated with the target backup
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections service method.</param>
        /// 
        /// <returns>The response from the ListBackupSelections service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual ListBackupSelectionsResponse ListBackupSelections(ListBackupSelectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupSelectionsResponse>(request, options);
        }


        /// <summary>
        /// Returns an array containing metadata of the resources associated with the target backup
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupSelections service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual Task<ListBackupSelectionsResponse> ListBackupSelectionsAsync(ListBackupSelectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupSelectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackupVaults


        /// <summary>
        /// Returns a list of recovery point storage containers along with information about them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults service method.</param>
        /// 
        /// <returns>The response from the ListBackupVaults service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual ListBackupVaultsResponse ListBackupVaults(ListBackupVaultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;

            return Invoke<ListBackupVaultsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of recovery point storage containers along with information about them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackupVaults service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual Task<ListBackupVaultsResponse> ListBackupVaultsAsync(ListBackupVaultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBackupVaultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCopyJobs


        /// <summary>
        /// Returns metadata about your copy jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobs service method.</param>
        /// 
        /// <returns>The response from the ListCopyJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobs">REST API Reference for ListCopyJobs Operation</seealso>
        public virtual ListCopyJobsResponse ListCopyJobs(ListCopyJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobsResponseUnmarshaller.Instance;

            return Invoke<ListCopyJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata about your copy jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCopyJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobs">REST API Reference for ListCopyJobs Operation</seealso>
        public virtual Task<ListCopyJobsResponse> ListCopyJobsAsync(ListCopyJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCopyJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCopyJobSummaries


        /// <summary>
        /// This request obtains a list of copy jobs created or running within the the most recent
        /// 30 days. You can include parameters AccountID, State, ResourceType, MessageCategory,
        /// AggregationPeriod, MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, RestourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobSummaries service method.</param>
        /// 
        /// <returns>The response from the ListCopyJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobSummaries">REST API Reference for ListCopyJobSummaries Operation</seealso>
        public virtual ListCopyJobSummariesResponse ListCopyJobSummaries(ListCopyJobSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCopyJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListCopyJobSummariesResponse>(request, options);
        }


        /// <summary>
        /// This request obtains a list of copy jobs created or running within the the most recent
        /// 30 days. You can include parameters AccountID, State, ResourceType, MessageCategory,
        /// AggregationPeriod, MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, RestourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCopyJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobSummaries">REST API Reference for ListCopyJobSummaries Operation</seealso>
        public virtual Task<ListCopyJobSummariesResponse> ListCopyJobSummariesAsync(ListCopyJobSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCopyJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCopyJobSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFrameworks


        /// <summary>
        /// Returns a list of all frameworks for an Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFrameworks service method.</param>
        /// 
        /// <returns>The response from the ListFrameworks service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListFrameworks">REST API Reference for ListFrameworks Operation</seealso>
        public virtual ListFrameworksResponse ListFrameworks(ListFrameworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFrameworksResponseUnmarshaller.Instance;

            return Invoke<ListFrameworksResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all frameworks for an Amazon Web Services account and Amazon Web
        /// Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFrameworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFrameworks service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListFrameworks">REST API Reference for ListFrameworks Operation</seealso>
        public virtual Task<ListFrameworksResponse> ListFrameworksAsync(ListFrameworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFrameworksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFrameworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLegalHolds


        /// <summary>
        /// This action returns metadata about active and previous legal holds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLegalHolds service method.</param>
        /// 
        /// <returns>The response from the ListLegalHolds service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListLegalHolds">REST API Reference for ListLegalHolds Operation</seealso>
        public virtual ListLegalHoldsResponse ListLegalHolds(ListLegalHoldsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLegalHoldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLegalHoldsResponseUnmarshaller.Instance;

            return Invoke<ListLegalHoldsResponse>(request, options);
        }


        /// <summary>
        /// This action returns metadata about active and previous legal holds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLegalHolds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLegalHolds service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListLegalHolds">REST API Reference for ListLegalHolds Operation</seealso>
        public virtual Task<ListLegalHoldsResponse> ListLegalHoldsAsync(ListLegalHoldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLegalHoldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLegalHoldsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLegalHoldsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProtectedResources


        /// <summary>
        /// Returns an array of resources successfully backed up by Backup, including the time
        /// the resource was saved, an Amazon Resource Name (ARN) of the resource, and a resource
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources service method.</param>
        /// 
        /// <returns>The response from the ListProtectedResources service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual ListProtectedResourcesResponse ListProtectedResources(ListProtectedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns an array of resources successfully backed up by Backup, including the time
        /// the resource was saved, an Amazon Resource Name (ARN) of the resource, and a resource
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectedResources service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual Task<ListProtectedResourcesResponse> ListProtectedResourcesAsync(ListProtectedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProtectedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProtectedResourcesByBackupVault


        /// <summary>
        /// This request lists the protected resources corresponding to each backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResourcesByBackupVault service method.</param>
        /// 
        /// <returns>The response from the ListProtectedResourcesByBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResourcesByBackupVault">REST API Reference for ListProtectedResourcesByBackupVault Operation</seealso>
        public virtual ListProtectedResourcesByBackupVaultResponse ListProtectedResourcesByBackupVault(ListProtectedResourcesByBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesByBackupVaultResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesByBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// This request lists the protected resources corresponding to each backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResourcesByBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectedResourcesByBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResourcesByBackupVault">REST API Reference for ListProtectedResourcesByBackupVault Operation</seealso>
        public virtual Task<ListProtectedResourcesByBackupVaultResponse> ListProtectedResourcesByBackupVaultAsync(ListProtectedResourcesByBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesByBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListProtectedResourcesByBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecoveryPointsByBackupVault


        /// <summary>
        /// Returns detailed information about the recovery points stored in a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual ListRecoveryPointsByBackupVaultResponse ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByBackupVaultResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed information about the recovery points stored in a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByBackupVault service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual Task<ListRecoveryPointsByBackupVaultResponse> ListRecoveryPointsByBackupVaultAsync(ListRecoveryPointsByBackupVaultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecoveryPointsByBackupVaultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecoveryPointsByLegalHold


        /// <summary>
        /// This action returns recovery point ARNs (Amazon Resource Names) of the specified legal
        /// hold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByLegalHold service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByLegalHold">REST API Reference for ListRecoveryPointsByLegalHold Operation</seealso>
        public virtual ListRecoveryPointsByLegalHoldResponse ListRecoveryPointsByLegalHold(ListRecoveryPointsByLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByLegalHoldResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// This action returns recovery point ARNs (Amazon Resource Names) of the specified legal
        /// hold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByLegalHold service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByLegalHold service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByLegalHold">REST API Reference for ListRecoveryPointsByLegalHold Operation</seealso>
        public virtual Task<ListRecoveryPointsByLegalHoldResponse> ListRecoveryPointsByLegalHoldAsync(ListRecoveryPointsByLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByLegalHoldResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecoveryPointsByLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecoveryPointsByResource


        /// <summary>
        /// Returns detailed information about all the recovery points of the type specified by
        /// a resource Amazon Resource Name (ARN).
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EFS and Amazon EC2, this action only lists recovery points created by Backup.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual ListRecoveryPointsByResourceResponse ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed information about all the recovery points of the type specified by
        /// a resource Amazon Resource Name (ARN).
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EFS and Amazon EC2, this action only lists recovery points created by Backup.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryPointsByResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual Task<ListRecoveryPointsByResourceResponse> ListRecoveryPointsByResourceAsync(ListRecoveryPointsByResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRecoveryPointsByResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReportJobs


        /// <summary>
        /// Returns details about your report jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReportJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportJobs">REST API Reference for ListReportJobs Operation</seealso>
        public virtual ListReportJobsResponse ListReportJobs(ListReportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReportJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns details about your report jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportJobs">REST API Reference for ListReportJobs Operation</seealso>
        public virtual Task<ListReportJobsResponse> ListReportJobsAsync(ListReportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReportPlans


        /// <summary>
        /// Returns a list of your report plans. For detailed information about a single report
        /// plan, use <c>DescribeReportPlan</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportPlans service method.</param>
        /// 
        /// <returns>The response from the ListReportPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportPlans">REST API Reference for ListReportPlans Operation</seealso>
        public virtual ListReportPlansResponse ListReportPlans(ListReportPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportPlansResponseUnmarshaller.Instance;

            return Invoke<ListReportPlansResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of your report plans. For detailed information about a single report
        /// plan, use <c>DescribeReportPlan</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportPlans">REST API Reference for ListReportPlans Operation</seealso>
        public virtual Task<ListReportPlansResponse> ListReportPlansAsync(ListReportPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReportPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListReportPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRestoreJobs


        /// <summary>
        /// Returns a list of jobs that Backup initiated to restore a saved resource, including
        /// details about the recovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs service method.</param>
        /// 
        /// <returns>The response from the ListRestoreJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual ListRestoreJobsResponse ListRestoreJobs(ListRestoreJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of jobs that Backup initiated to restore a saved resource, including
        /// details about the recovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRestoreJobs service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual Task<ListRestoreJobsResponse> ListRestoreJobsAsync(ListRestoreJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRestoreJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRestoreJobsByProtectedResource


        /// <summary>
        /// This returns restore jobs that contain the specified protected resource.
        /// 
        ///  
        /// <para>
        /// You must include <c>ResourceArn</c>. You can optionally include <c>NextToken</c>,
        /// <c>ByStatus</c>, <c>MaxResults</c>, <c>ByRecoveryPointCreationDateAfter</c> , and
        /// <c>ByRecoveryPointCreationDateBefore</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobsByProtectedResource service method.</param>
        /// 
        /// <returns>The response from the ListRestoreJobsByProtectedResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobsByProtectedResource">REST API Reference for ListRestoreJobsByProtectedResource Operation</seealso>
        public virtual ListRestoreJobsByProtectedResourceResponse ListRestoreJobsByProtectedResource(ListRestoreJobsByProtectedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsByProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsByProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsByProtectedResourceResponse>(request, options);
        }


        /// <summary>
        /// This returns restore jobs that contain the specified protected resource.
        /// 
        ///  
        /// <para>
        /// You must include <c>ResourceArn</c>. You can optionally include <c>NextToken</c>,
        /// <c>ByStatus</c>, <c>MaxResults</c>, <c>ByRecoveryPointCreationDateAfter</c> , and
        /// <c>ByRecoveryPointCreationDateBefore</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobsByProtectedResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRestoreJobsByProtectedResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobsByProtectedResource">REST API Reference for ListRestoreJobsByProtectedResource Operation</seealso>
        public virtual Task<ListRestoreJobsByProtectedResourceResponse> ListRestoreJobsByProtectedResourceAsync(ListRestoreJobsByProtectedResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsByProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsByProtectedResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRestoreJobsByProtectedResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRestoreJobSummaries


        /// <summary>
        /// This request obtains a summary of restore jobs created or running within the the most
        /// recent 30 days. You can include parameters AccountID, State, ResourceType, AggregationPeriod,
        /// MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, RestourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobSummaries service method.</param>
        /// 
        /// <returns>The response from the ListRestoreJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobSummaries">REST API Reference for ListRestoreJobSummaries Operation</seealso>
        public virtual ListRestoreJobSummariesResponse ListRestoreJobSummaries(ListRestoreJobSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobSummariesResponse>(request, options);
        }


        /// <summary>
        /// This request obtains a summary of restore jobs created or running within the the most
        /// recent 30 days. You can include parameters AccountID, State, ResourceType, AggregationPeriod,
        /// MaxResults, or NextToken to filter results.
        /// 
        ///  
        /// <para>
        /// This request returns a summary that contains Region, Account, State, RestourceType,
        /// MessageCategory, StartTime, EndTime, and Count of included jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRestoreJobSummaries service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobSummaries">REST API Reference for ListRestoreJobSummaries Operation</seealso>
        public virtual Task<ListRestoreJobSummariesResponse> ListRestoreJobSummariesAsync(ListRestoreJobSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobSummariesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRestoreJobSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRestoreTestingPlans


        /// <summary>
        /// Returns a list of restore testing plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingPlans service method.</param>
        /// 
        /// <returns>The response from the ListRestoreTestingPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingPlans">REST API Reference for ListRestoreTestingPlans Operation</seealso>
        public virtual ListRestoreTestingPlansResponse ListRestoreTestingPlans(ListRestoreTestingPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingPlansResponseUnmarshaller.Instance;

            return Invoke<ListRestoreTestingPlansResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of restore testing plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRestoreTestingPlans service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingPlans">REST API Reference for ListRestoreTestingPlans Operation</seealso>
        public virtual Task<ListRestoreTestingPlansResponse> ListRestoreTestingPlansAsync(ListRestoreTestingPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRestoreTestingPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRestoreTestingSelections


        /// <summary>
        /// Returns a list of restore testing selections. Can be filtered by <c>MaxResults</c>
        /// and <c>RestoreTestingPlanName</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingSelections service method.</param>
        /// 
        /// <returns>The response from the ListRestoreTestingSelections service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingSelections">REST API Reference for ListRestoreTestingSelections Operation</seealso>
        public virtual ListRestoreTestingSelectionsResponse ListRestoreTestingSelections(ListRestoreTestingSelectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingSelectionsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreTestingSelectionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of restore testing selections. Can be filtered by <c>MaxResults</c>
        /// and <c>RestoreTestingPlanName</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingSelections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRestoreTestingSelections service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingSelections">REST API Reference for ListRestoreTestingSelections Operation</seealso>
        public virtual Task<ListRestoreTestingSelectionsResponse> ListRestoreTestingSelectionsAsync(ListRestoreTestingSelectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingSelectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRestoreTestingSelectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns a list of key-value pairs assigned to a target recovery point, backup plan,
        /// or backup vault.
        /// 
        ///  
        /// <para>
        ///  <c>ListTags</c> only works for resource types that support full Backup management
        /// of their backups. Those resource types are listed in the "Full Backup management"
        /// section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
        /// Feature availability by resource</a> table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of key-value pairs assigned to a target recovery point, backup plan,
        /// or backup vault.
        /// 
        ///  
        /// <para>
        ///  <c>ListTags</c> only works for resource types that support full Backup management
        /// of their backups. Those resource types are listed in the "Full Backup management"
        /// section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
        /// Feature availability by resource</a> table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBackupVaultAccessPolicy


        /// <summary>
        /// Sets a resource-based policy that is used to manage access permissions on the target
        /// backup vault. Requires a backup vault name and an access policy document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual PutBackupVaultAccessPolicyResponse PutBackupVaultAccessPolicy(PutBackupVaultAccessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultAccessPolicyResponse>(request, options);
        }


        /// <summary>
        /// Sets a resource-based policy that is used to manage access permissions on the target
        /// backup vault. Requires a backup vault name and an access policy document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBackupVaultAccessPolicy service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual Task<PutBackupVaultAccessPolicyResponse> PutBackupVaultAccessPolicyAsync(PutBackupVaultAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBackupVaultAccessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBackupVaultLockConfiguration


        /// <summary>
        /// Applies Backup Vault Lock to a backup vault, preventing attempts to delete any recovery
        /// point stored in or created in a backup vault. Vault Lock also prevents attempts to
        /// update the lifecycle policy that controls the retention period of any recovery point
        /// currently stored in a backup vault. If specified, Vault Lock enforces a minimum and
        /// maximum retention period for future backup and copy jobs that target a backup vault.
        /// 
        ///  <note> 
        /// <para>
        /// Backup Vault Lock has been assessed by Cohasset Associates for use in environments
        /// that are subject to SEC 17a-4, CFTC, and FINRA regulations. For more information about
        /// how Backup Vault Lock relates to these regulations, see the <a href="samples/cohassetreport.zip">Cohasset
        /// Associates Compliance Assessment.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultLockConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBackupVaultLockConfiguration service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultLockConfiguration">REST API Reference for PutBackupVaultLockConfiguration Operation</seealso>
        public virtual PutBackupVaultLockConfigurationResponse PutBackupVaultLockConfiguration(PutBackupVaultLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultLockConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Applies Backup Vault Lock to a backup vault, preventing attempts to delete any recovery
        /// point stored in or created in a backup vault. Vault Lock also prevents attempts to
        /// update the lifecycle policy that controls the retention period of any recovery point
        /// currently stored in a backup vault. If specified, Vault Lock enforces a minimum and
        /// maximum retention period for future backup and copy jobs that target a backup vault.
        /// 
        ///  <note> 
        /// <para>
        /// Backup Vault Lock has been assessed by Cohasset Associates for use in environments
        /// that are subject to SEC 17a-4, CFTC, and FINRA regulations. For more information about
        /// how Backup Vault Lock relates to these regulations, see the <a href="samples/cohassetreport.zip">Cohasset
        /// Associates Compliance Assessment.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultLockConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBackupVaultLockConfiguration service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultLockConfiguration">REST API Reference for PutBackupVaultLockConfiguration Operation</seealso>
        public virtual Task<PutBackupVaultLockConfigurationResponse> PutBackupVaultLockConfigurationAsync(PutBackupVaultLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultLockConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBackupVaultLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBackupVaultNotifications


        /// <summary>
        /// Turns on notifications on a backup vault for the specified topic and events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications service method.</param>
        /// 
        /// <returns>The response from the PutBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual PutBackupVaultNotificationsResponse PutBackupVaultNotifications(PutBackupVaultNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Turns on notifications on a backup vault for the specified topic and events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBackupVaultNotifications service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual Task<PutBackupVaultNotificationsResponse> PutBackupVaultNotificationsAsync(PutBackupVaultNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBackupVaultNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRestoreValidationResult


        /// <summary>
        /// This request allows you to send your independent self-run restore test validation
        /// results. <c>RestoreJobId</c> and <c>ValidationStatus</c> are required. Optionally,
        /// you can input a <c>ValidationStatusMessage</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestoreValidationResult service method.</param>
        /// 
        /// <returns>The response from the PutRestoreValidationResult service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutRestoreValidationResult">REST API Reference for PutRestoreValidationResult Operation</seealso>
        public virtual PutRestoreValidationResultResponse PutRestoreValidationResult(PutRestoreValidationResultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRestoreValidationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestoreValidationResultResponseUnmarshaller.Instance;

            return Invoke<PutRestoreValidationResultResponse>(request, options);
        }


        /// <summary>
        /// This request allows you to send your independent self-run restore test validation
        /// results. <c>RestoreJobId</c> and <c>ValidationStatus</c> are required. Optionally,
        /// you can input a <c>ValidationStatusMessage</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestoreValidationResult service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRestoreValidationResult service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutRestoreValidationResult">REST API Reference for PutRestoreValidationResult Operation</seealso>
        public virtual Task<PutRestoreValidationResultResponse> PutRestoreValidationResultAsync(PutRestoreValidationResultRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRestoreValidationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestoreValidationResultResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRestoreValidationResultResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBackupJob


        /// <summary>
        /// Starts an on-demand backup job for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob service method.</param>
        /// 
        /// <returns>The response from the StartBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual StartBackupJobResponse StartBackupJob(StartBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;

            return Invoke<StartBackupJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an on-demand backup job for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual Task<StartBackupJobResponse> StartBackupJobAsync(StartBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartBackupJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCopyJob


        /// <summary>
        /// Starts a job to create a one-time copy of the specified resource.
        /// 
        ///  
        /// <para>
        /// Does not support continuous backups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCopyJob service method.</param>
        /// 
        /// <returns>The response from the StartCopyJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartCopyJob">REST API Reference for StartCopyJob Operation</seealso>
        public virtual StartCopyJobResponse StartCopyJob(StartCopyJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCopyJobResponseUnmarshaller.Instance;

            return Invoke<StartCopyJobResponse>(request, options);
        }


        /// <summary>
        /// Starts a job to create a one-time copy of the specified resource.
        /// 
        ///  
        /// <para>
        /// Does not support continuous backups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCopyJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCopyJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartCopyJob">REST API Reference for StartCopyJob Operation</seealso>
        public virtual Task<StartCopyJobResponse> StartCopyJobAsync(StartCopyJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCopyJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartCopyJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartReportJob


        /// <summary>
        /// Starts an on-demand report job for the specified report plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportJob service method.</param>
        /// 
        /// <returns>The response from the StartReportJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartReportJob">REST API Reference for StartReportJob Operation</seealso>
        public virtual StartReportJobResponse StartReportJob(StartReportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportJobResponseUnmarshaller.Instance;

            return Invoke<StartReportJobResponse>(request, options);
        }


        /// <summary>
        /// Starts an on-demand report job for the specified report plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReportJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartReportJob">REST API Reference for StartReportJob Operation</seealso>
        public virtual Task<StartReportJobResponse> StartReportJobAsync(StartReportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartRestoreJob


        /// <summary>
        /// Recovers the saved resource identified by an Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob service method.</param>
        /// 
        /// <returns>The response from the StartRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual StartRestoreJobResponse StartRestoreJob(StartRestoreJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;

            return Invoke<StartRestoreJobResponse>(request, options);
        }


        /// <summary>
        /// Recovers the saved resource identified by an Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRestoreJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual Task<StartRestoreJobResponse> StartRestoreJobAsync(StartRestoreJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartRestoreJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopBackupJob


        /// <summary>
        /// Attempts to cancel a job to create a one-time backup of a resource.
        /// 
        ///  
        /// <para>
        /// This action is not supported for the following services: Amazon FSx for Windows File
        /// Server, Amazon FSx for Lustre, Amazon FSx for NetApp ONTAP , Amazon FSx for OpenZFS,
        /// Amazon DocumentDB (with MongoDB compatibility), Amazon RDS, Amazon Aurora, and Amazon
        /// Neptune.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob service method.</param>
        /// 
        /// <returns>The response from the StopBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual StopBackupJobResponse StopBackupJob(StopBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return Invoke<StopBackupJobResponse>(request, options);
        }


        /// <summary>
        /// Attempts to cancel a job to create a one-time backup of a resource.
        /// 
        ///  
        /// <para>
        /// This action is not supported for the following services: Amazon FSx for Windows File
        /// Server, Amazon FSx for Lustre, Amazon FSx for NetApp ONTAP , Amazon FSx for OpenZFS,
        /// Amazon DocumentDB (with MongoDB compatibility), Amazon RDS, Amazon Aurora, and Amazon
        /// Neptune.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual Task<StopBackupJobResponse> StopBackupJobAsync(StopBackupJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopBackupJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns a set of key-value pairs to a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns a set of key-value pairs to a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a set of key-value pairs from a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a set of key-value pairs from a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBackupPlan


        /// <summary>
        /// Updates an existing backup plan identified by its <c>backupPlanId</c> with the input
        /// document in JSON format. The new version is uniquely identified by a <c>VersionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual UpdateBackupPlanResponse UpdateBackupPlan(UpdateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateBackupPlanResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing backup plan identified by its <c>backupPlanId</c> with the input
        /// document in JSON format. The new version is uniquely identified by a <c>VersionId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBackupPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual Task<UpdateBackupPlanResponse> UpdateBackupPlanAsync(UpdateBackupPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBackupPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFramework


        /// <summary>
        /// Updates an existing framework identified by its <c>FrameworkName</c> with the input
        /// document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFramework service method.</param>
        /// 
        /// <returns>The response from the UpdateFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateFramework">REST API Reference for UpdateFramework Operation</seealso>
        public virtual UpdateFrameworkResponse UpdateFramework(UpdateFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFrameworkResponseUnmarshaller.Instance;

            return Invoke<UpdateFrameworkResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing framework identified by its <c>FrameworkName</c> with the input
        /// document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFramework service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.AlreadyExistsException">
        /// The required resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.LimitExceededException">
        /// A limit in the request has been exceeded; for example, a maximum number of items allowed
        /// in a request.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateFramework">REST API Reference for UpdateFramework Operation</seealso>
        public virtual Task<UpdateFrameworkResponse> UpdateFrameworkAsync(UpdateFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFrameworkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalSettings


        /// <summary>
        /// Updates whether the Amazon Web Services account is opted in to cross-account backup.
        /// Returns an error if the account is not an Organizations management account. Use the
        /// <c>DescribeGlobalSettings</c> API to determine the current settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates whether the Amazon Web Services account is opted in to cross-account backup.
        /// Returns an error if the account is not an Organizations management account. Use the
        /// <c>DescribeGlobalSettings</c> API to determine the current settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGlobalSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRecoveryPointLifecycle


        /// <summary>
        /// Sets the transition lifecycle of a recovery point.
        /// 
        ///  
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
        /// to cold after days” setting. The “transition to cold after days” setting cannot be
        /// changed after a backup has been transitioned to cold.
        /// </para>
        ///  
        /// <para>
        /// Resource types that are able to be transitioned to cold storage are listed in the
        /// "Lifecycle to cold storage" section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
        /// Feature availability by resource</a> table. Backup ignores this expression for other
        /// resource types.
        /// </para>
        ///  
        /// <para>
        /// This operation does not support continuous backups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle service method.</param>
        /// 
        /// <returns>The response from the UpdateRecoveryPointLifecycle service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual UpdateRecoveryPointLifecycleResponse UpdateRecoveryPointLifecycle(UpdateRecoveryPointLifecycleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateRecoveryPointLifecycleResponse>(request, options);
        }


        /// <summary>
        /// Sets the transition lifecycle of a recovery point.
        /// 
        ///  
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
        /// to cold after days” setting. The “transition to cold after days” setting cannot be
        /// changed after a backup has been transitioned to cold.
        /// </para>
        ///  
        /// <para>
        /// Resource types that are able to be transitioned to cold storage are listed in the
        /// "Lifecycle to cold storage" section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
        /// Feature availability by resource</a> table. Backup ignores this expression for other
        /// resource types.
        /// </para>
        ///  
        /// <para>
        /// This operation does not support continuous backups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecoveryPointLifecycle service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a parameter
        /// is of the wrong type.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual Task<UpdateRecoveryPointLifecycleResponse> UpdateRecoveryPointLifecycleAsync(UpdateRecoveryPointLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRecoveryPointLifecycleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRegionSettings


        /// <summary>
        /// Updates the current service opt-in settings for the Region.
        /// 
        ///  
        /// <para>
        /// Use the <c>DescribeRegionSettings</c> API to determine the resource types that are
        /// supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegionSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateRegionSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRegionSettings">REST API Reference for UpdateRegionSettings Operation</seealso>
        public virtual UpdateRegionSettingsResponse UpdateRegionSettings(UpdateRegionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateRegionSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates the current service opt-in settings for the Region.
        /// 
        ///  
        /// <para>
        /// Use the <c>DescribeRegionSettings</c> API to determine the resource types that are
        /// supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegionSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegionSettings service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRegionSettings">REST API Reference for UpdateRegionSettings Operation</seealso>
        public virtual Task<UpdateRegionSettingsResponse> UpdateRegionSettingsAsync(UpdateRegionSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegionSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRegionSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReportPlan


        /// <summary>
        /// Updates an existing report plan identified by its <c>ReportPlanName</c> with the input
        /// document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateReportPlan">REST API Reference for UpdateReportPlan Operation</seealso>
        public virtual UpdateReportPlanResponse UpdateReportPlan(UpdateReportPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateReportPlanResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing report plan identified by its <c>ReportPlanName</c> with the input
        /// document in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReportPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateReportPlan">REST API Reference for UpdateReportPlan Operation</seealso>
        public virtual Task<UpdateReportPlanResponse> UpdateReportPlanAsync(UpdateReportPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateReportPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRestoreTestingPlan


        /// <summary>
        /// This request will send changes to your specified restore testing plan. <c>RestoreTestingPlanName</c>
        /// cannot be updated after it is created.
        /// 
        ///  
        /// <para>
        ///  <c>RecoveryPointSelection</c> can contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Algorithm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExcludeVaults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IncludeVaults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RecoveryPointTypes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SelectionWindowDays</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingPlan service method.</param>
        /// 
        /// <returns>The response from the UpdateRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingPlan">REST API Reference for UpdateRestoreTestingPlan Operation</seealso>
        public virtual UpdateRestoreTestingPlanResponse UpdateRestoreTestingPlan(UpdateRestoreTestingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateRestoreTestingPlanResponse>(request, options);
        }


        /// <summary>
        /// This request will send changes to your specified restore testing plan. <c>RestoreTestingPlanName</c>
        /// cannot be updated after it is created.
        /// 
        ///  
        /// <para>
        ///  <c>RecoveryPointSelection</c> can contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Algorithm</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExcludeVaults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IncludeVaults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RecoveryPointTypes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SelectionWindowDays</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRestoreTestingPlan service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingPlan">REST API Reference for UpdateRestoreTestingPlan Operation</seealso>
        public virtual Task<UpdateRestoreTestingPlanResponse> UpdateRestoreTestingPlanAsync(UpdateRestoreTestingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRestoreTestingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRestoreTestingSelection


        /// <summary>
        /// Most elements except the <c>RestoreTestingSelectionName</c> can be updated with this
        /// request.
        /// 
        ///  
        /// <para>
        ///  <c>RestoreTestingSelection</c> can use either protected resource ARNs or conditions,
        /// but not both. That is, if your selection has <c>ProtectedResourceArns</c>, requesting
        /// an update with the parameter <c>ProtectedResourceConditions</c> will be unsuccessful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingSelection service method.</param>
        /// 
        /// <returns>The response from the UpdateRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingSelection">REST API Reference for UpdateRestoreTestingSelection Operation</seealso>
        public virtual UpdateRestoreTestingSelectionResponse UpdateRestoreTestingSelection(UpdateRestoreTestingSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<UpdateRestoreTestingSelectionResponse>(request, options);
        }


        /// <summary>
        /// Most elements except the <c>RestoreTestingSelectionName</c> can be updated with this
        /// request.
        /// 
        ///  
        /// <para>
        ///  <c>RestoreTestingSelection</c> can use either protected resource ARNs or conditions,
        /// but not both. That is, if your selection has <c>ProtectedResourceArns</c>, requesting
        /// an update with the parameter <c>ProtectedResourceConditions</c> will be unsuccessful.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingSelection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRestoreTestingSelection service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.ConflictException">
        /// Backup can't perform the action that you requested until it finishes performing a
        /// previous action. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.MissingParameterValueException">
        /// Indicates that a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingSelection">REST API Reference for UpdateRestoreTestingSelection Operation</seealso>
        public virtual Task<UpdateRestoreTestingSelectionResponse> UpdateRestoreTestingSelectionAsync(UpdateRestoreTestingSelectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingSelectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRestoreTestingSelectionResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBackupEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
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

namespace Amazon.Backup
{
    /// <summary>
    /// Implementation for accessing Backup
    ///
    /// AWS Backup 
    /// <para>
    /// AWS Backup is a unified backup service designed to protect AWS services and their
    /// associated data. AWS Backup simplifies the creation, migration, restoration, and deletion
    /// of backups, while also providing reporting and auditing.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonBackupClient : AmazonServiceClient, IAmazonBackup
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupMetadata();
        
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  CreateBackupPlan

        internal virtual CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<CreateBackupPlanResponse>(request, options);
        }



        /// <summary>
        /// Creates a backup plan using a backup plan name and backup rules. A backup plan is
        /// a document that contains information that AWS Backup uses to schedule tasks that create
        /// recovery points for resources.
        /// 
        ///  
        /// <para>
        /// If you call <code>CreateBackupPlan</code> with a plan that already exists, an <code>AlreadyExistsException</code>
        /// is returned.
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

        internal virtual CreateBackupSelectionResponse CreateBackupSelection(CreateBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateBackupSelectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a JSON document that specifies a set of resources to assign to a backup plan.
        /// Resources can be included by specifying patterns for a <code>ListOfTags</code> and
        /// selected <code>Resources</code>. 
        /// 
        ///  
        /// <para>
        /// For example, consider the following patterns:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Resources: "arn:aws:ec2:region:account-id:volume/volume-id"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConditionKey:"department"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionValue:"finance"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionType:"StringEquals"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConditionKey:"importance"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionValue:"critical"</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>ConditionType:"StringEquals"</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Using these patterns would back up all Amazon Elastic Block Store (Amazon EBS) volumes
        /// that are tagged as <code>"department=finance"</code>, <code>"importance=critical"</code>,
        /// in addition to an EBS volume with the specified volume ID.
        /// </para>
        ///  
        /// <para>
        /// Resources and conditions are additive in that all resources that match the pattern
        /// are selected. This shouldn't be confused with a logical AND, where all conditions
        /// must match. The matching patterns are logically put together using the OR operator.
        /// In other words, all patterns that match are selected for backup.
        /// </para>
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

        internal virtual CreateBackupVaultResponse CreateBackupVault(CreateBackupVaultRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateBackupVaultResponse>(request, options);
        }



        /// <summary>
        /// Creates a logical container where backups are stored. A <code>CreateBackupVault</code>
        /// request includes a name, optionally one or more resource tags, an encryption key,
        /// and a request ID.
        /// 
        ///  <note> 
        /// <para>
        /// Sensitive data, such as passport numbers, should not be included the name of a backup
        /// vault.
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
        
        #region  DeleteBackupPlan

        internal virtual DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
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

        internal virtual DeleteBackupSelectionResponse DeleteBackupSelection(DeleteBackupSelectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupSelectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource selection associated with a backup plan that is specified by
        /// the <code>SelectionId</code>.
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

        internal virtual DeleteBackupVaultResponse DeleteBackupVault(DeleteBackupVaultRequest request)
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

        internal virtual DeleteBackupVaultAccessPolicyResponse DeleteBackupVaultAccessPolicy(DeleteBackupVaultAccessPolicyRequest request)
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
        
        #region  DeleteBackupVaultNotifications

        internal virtual DeleteBackupVaultNotificationsResponse DeleteBackupVaultNotifications(DeleteBackupVaultNotificationsRequest request)
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
        
        #region  DeleteRecoveryPoint

        internal virtual DeleteRecoveryPointResponse DeleteRecoveryPoint(DeleteRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Deletes the recovery point specified by a recovery point ID.
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
        
        #region  DescribeBackupJob

        internal virtual DescribeBackupJobResponse DescribeBackupJob(DescribeBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupJobResponse>(request, options);
        }



        /// <summary>
        /// Returns backup job details for the specified <code>BackupJobId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackupJob service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.DependencyFailureException">
        /// A dependent AWS service or resource returned an error to the AWS Backup service, and
        /// the action cannot be completed.
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

        internal virtual DescribeBackupVaultResponse DescribeBackupVault(DescribeBackupVaultRequest request)
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

        internal virtual DescribeCopyJobResponse DescribeCopyJob(DescribeCopyJobRequest request)
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
        
        #region  DescribeGlobalSettings

        internal virtual DescribeGlobalSettingsResponse DescribeGlobalSettings(DescribeGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalSettingsResponse>(request, options);
        }



        /// <summary>
        /// The current feature settings for the AWS Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalSettings service method, as returned by Backup.</returns>
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

        internal virtual DescribeProtectedResourceResponse DescribeProtectedResource(DescribeProtectedResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectedResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a saved resource, including the last time it was backed
        /// up, its Amazon Resource Name (ARN), and the AWS service type of the saved resource.
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

        internal virtual DescribeRecoveryPointResponse DescribeRecoveryPoint(DescribeRecoveryPointRequest request)
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

        internal virtual DescribeRegionSettingsResponse DescribeRegionSettings(DescribeRegionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Returns the current service opt-in settings for the Region. If service-opt-in is enabled
        /// for a service, AWS Backup tries to protect that service's resources in this Region,
        /// when the resource is included in an on-demand backup or scheduled backup plan. Otherwise,
        /// AWS Backup does not try to protect that service's resources in this Region, AWS Backup
        /// does not try to protect that service's resources in this Region.
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
        
        #region  DescribeRestoreJob

        internal virtual DescribeRestoreJobResponse DescribeRestoreJob(DescribeRestoreJobRequest request)
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
        /// A dependent AWS service or resource returned an error to the AWS Backup service, and
        /// the action cannot be completed.
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
        
        #region  ExportBackupPlanTemplate

        internal virtual ExportBackupPlanTemplateResponse ExportBackupPlanTemplate(ExportBackupPlanTemplateRequest request)
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

        internal virtual GetBackupPlanResponse GetBackupPlan(GetBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanResponse>(request, options);
        }



        /// <summary>
        /// Returns <code>BackupPlan</code> details for the specified <code>BackupPlanId</code>.
        /// Returns the body of a backup plan in JSON format, in addition to plan metadata.
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

        internal virtual GetBackupPlanFromJSONResponse GetBackupPlanFromJSON(GetBackupPlanFromJSONRequest request)
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

        internal virtual GetBackupPlanFromTemplateResponse GetBackupPlanFromTemplate(GetBackupPlanFromTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromTemplateResponse>(request, options);
        }



        /// <summary>
        /// Returns the template specified by its <code>templateId</code> as a backup plan.
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

        internal virtual GetBackupSelectionResponse GetBackupSelection(GetBackupSelectionRequest request)
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

        internal virtual GetBackupVaultAccessPolicyResponse GetBackupVaultAccessPolicy(GetBackupVaultAccessPolicyRequest request)
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

        internal virtual GetBackupVaultNotificationsResponse GetBackupVaultNotifications(GetBackupVaultNotificationsRequest request)
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
        
        #region  GetRecoveryPointRestoreMetadata

        internal virtual GetRecoveryPointRestoreMetadataResponse GetRecoveryPointRestoreMetadata(GetRecoveryPointRestoreMetadataRequest request)
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
        
        #region  GetSupportedResourceTypes

        internal virtual GetSupportedResourceTypesResponse GetSupportedResourceTypes(GetSupportedResourceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetSupportedResourceTypesResponse>(request, options);
        }



        /// <summary>
        /// Returns the AWS resource types supported by AWS Backup.
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

        internal virtual ListBackupJobsResponse ListBackupJobs(ListBackupJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of existing backup jobs for an authenticated account.
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
        
        #region  ListBackupPlans

        internal virtual ListBackupPlansResponse ListBackupPlans(ListBackupPlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlansResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of existing backup plans for an authenticated account. The list is
        /// populated only if the advanced option is set for the backup plan. The list contains
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

        internal virtual ListBackupPlanTemplatesResponse ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request)
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

        internal virtual ListBackupPlanVersionsResponse ListBackupPlanVersions(ListBackupPlanVersionsRequest request)
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

        internal virtual ListBackupSelectionsResponse ListBackupSelections(ListBackupSelectionsRequest request)
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

        internal virtual ListBackupVaultsResponse ListBackupVaults(ListBackupVaultsRequest request)
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

        internal virtual ListCopyJobsResponse ListCopyJobs(ListCopyJobsRequest request)
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
        
        #region  ListProtectedResources

        internal virtual ListProtectedResourcesResponse ListProtectedResources(ListProtectedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of resources successfully backed up by AWS Backup, including the
        /// time the resource was saved, an Amazon Resource Name (ARN) of the resource, and a
        /// resource type.
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
        
        #region  ListRecoveryPointsByBackupVault

        internal virtual ListRecoveryPointsByBackupVaultResponse ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request)
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
        
        #region  ListRecoveryPointsByResource

        internal virtual ListRecoveryPointsByResourceResponse ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed information about recovery points of the type specified by a resource
        /// Amazon Resource Name (ARN).
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
        
        #region  ListRestoreJobs

        internal virtual ListRestoreJobsResponse ListRestoreJobs(ListRestoreJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of jobs that AWS Backup initiated to restore a saved resource, including
        /// metadata about the recovery process.
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
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
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
        ///  <note> 
        /// <para>
        ///  <code>ListTags</code> are currently only supported with Amazon EFS backups.
        /// </para>
        ///  </note>
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

        internal virtual PutBackupVaultAccessPolicyResponse PutBackupVaultAccessPolicy(PutBackupVaultAccessPolicyRequest request)
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
        
        #region  PutBackupVaultNotifications

        internal virtual PutBackupVaultNotificationsResponse PutBackupVaultNotifications(PutBackupVaultNotificationsRequest request)
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
        
        #region  StartBackupJob

        internal virtual StartBackupJobResponse StartBackupJob(StartBackupJobRequest request)
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

        internal virtual StartCopyJobResponse StartCopyJob(StartCopyJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCopyJobResponseUnmarshaller.Instance;

            return Invoke<StartCopyJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a job to create a one-time copy of the specified resource.
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
        
        #region  StartRestoreJob

        internal virtual StartRestoreJobResponse StartRestoreJob(StartRestoreJobRequest request)
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

        internal virtual StopBackupJobResponse StopBackupJob(StopBackupJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return Invoke<StopBackupJobResponse>(request, options);
        }



        /// <summary>
        /// Attempts to cancel a job to create a one-time backup of a resource.
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

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
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

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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

        internal virtual UpdateBackupPlanResponse UpdateBackupPlan(UpdateBackupPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateBackupPlanResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing backup plan identified by its <code>backupPlanId</code> with the
        /// input document in JSON format. The new version is uniquely identified by a <code>VersionId</code>.
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
        
        #region  UpdateGlobalSettings

        internal virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the current global settings for the AWS Account. Use the <code>DescribeGlobalSettings</code>
        /// API to determine the current settings.
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

        internal virtual UpdateRecoveryPointLifecycleResponse UpdateRecoveryPointLifecycle(UpdateRecoveryPointLifecycleRequest request)
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
        /// when it expires. AWS Backup transitions and expires backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “expire after days” setting must be 90 days greater than
        /// the “transition to cold after days” setting. The “transition to cold after days” setting
        /// cannot be changed after a backup has been transitioned to cold. 
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

        internal virtual UpdateRegionSettingsResponse UpdateRegionSettings(UpdateRegionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateRegionSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the current service opt-in settings for the Region. If service-opt-in is enabled
        /// for a service, AWS Backup tries to protect that service's resources in this Region,
        /// when the resource is included in an on-demand backup or scheduled backup plan. Otherwise,
        /// AWS Backup does not try to protect that service's resources in this Region. Use the
        /// <code>DescribeRegionSettings</code> API to determine the resource types that are supported.
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
        
    }
}
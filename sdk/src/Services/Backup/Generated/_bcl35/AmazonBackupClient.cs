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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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


        #region  AssociateBackupVaultMpaApprovalTeam

        /// <summary>
        /// Associates an MPA approval team with a backup vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBackupVaultMpaApprovalTeam service method.</param>
        /// 
        /// <returns>The response from the AssociateBackupVaultMpaApprovalTeam service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/AssociateBackupVaultMpaApprovalTeam">REST API Reference for AssociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual AssociateBackupVaultMpaApprovalTeamResponse AssociateBackupVaultMpaApprovalTeam(AssociateBackupVaultMpaApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBackupVaultMpaApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBackupVaultMpaApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<AssociateBackupVaultMpaApprovalTeamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBackupVaultMpaApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBackupVaultMpaApprovalTeam operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBackupVaultMpaApprovalTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/AssociateBackupVaultMpaApprovalTeam">REST API Reference for AssociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual IAsyncResult BeginAssociateBackupVaultMpaApprovalTeam(AssociateBackupVaultMpaApprovalTeamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateBackupVaultMpaApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateBackupVaultMpaApprovalTeamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBackupVaultMpaApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBackupVaultMpaApprovalTeam.</param>
        /// 
        /// <returns>Returns a  AssociateBackupVaultMpaApprovalTeamResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/AssociateBackupVaultMpaApprovalTeam">REST API Reference for AssociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual AssociateBackupVaultMpaApprovalTeamResponse EndAssociateBackupVaultMpaApprovalTeam(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateBackupVaultMpaApprovalTeamResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelLegalHold

        /// <summary>
        /// Removes the specified legal hold on a recovery point. This action can only be performed
        /// by a user with sufficient permissions.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLegalHoldResponseUnmarshaller.Instance;

            return Invoke<CancelLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelLegalHold operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelLegalHold
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CancelLegalHold">REST API Reference for CancelLegalHold Operation</seealso>
        public virtual IAsyncResult BeginCancelLegalHold(CancelLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelLegalHold.</param>
        /// 
        /// <returns>Returns a  CancelLegalHoldResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CancelLegalHold">REST API Reference for CancelLegalHold Operation</seealso>
        public virtual CancelLegalHoldResponse EndCancelLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelLegalHoldResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<CreateBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupPlan(CreateBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupPlan.</param>
        /// 
        /// <returns>Returns a  CreateBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupPlan">REST API Reference for CreateBackupPlan Operation</seealso>
        public virtual CreateBackupPlanResponse EndCreateBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupSelection(CreateBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupSelection.</param>
        /// 
        /// <returns>Returns a  CreateBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupSelection">REST API Reference for CreateBackupSelection Operation</seealso>
        public virtual CreateBackupSelectionResponse EndCreateBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupSelectionResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual IAsyncResult BeginCreateBackupVault(CreateBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackupVault.</param>
        /// 
        /// <returns>Returns a  CreateBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateBackupVault">REST API Reference for CreateBackupVault Operation</seealso>
        public virtual CreateBackupVaultResponse EndCreateBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFrameworkResponseUnmarshaller.Instance;

            return Invoke<CreateFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFramework operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateFramework">REST API Reference for CreateFramework Operation</seealso>
        public virtual IAsyncResult BeginCreateFramework(CreateFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFramework.</param>
        /// 
        /// <returns>Returns a  CreateFrameworkResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateFramework">REST API Reference for CreateFramework Operation</seealso>
        public virtual CreateFrameworkResponse EndCreateFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFrameworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLegalHold

        /// <summary>
        /// Creates a legal hold on a recovery point (backup). A legal hold is a restraint on
        /// altering or deleting a backup until an authorized user cancels the legal hold. Any
        /// actions to delete or disassociate a recovery point will fail with an error if one
        /// or more active legal holds are on the recovery point.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLegalHoldResponseUnmarshaller.Instance;

            return Invoke<CreateLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLegalHold operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLegalHold
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLegalHold">REST API Reference for CreateLegalHold Operation</seealso>
        public virtual IAsyncResult BeginCreateLegalHold(CreateLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLegalHold.</param>
        /// 
        /// <returns>Returns a  CreateLegalHoldResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLegalHold">REST API Reference for CreateLegalHold Operation</seealso>
        public virtual CreateLegalHoldResponse EndCreateLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLegalHoldResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLogicallyAirGappedBackupVault

        /// <summary>
        /// Creates a logical container to where backups may be copied.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogicallyAirGappedBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogicallyAirGappedBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateLogicallyAirGappedBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogicallyAirGappedBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogicallyAirGappedBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogicallyAirGappedBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLogicallyAirGappedBackupVault">REST API Reference for CreateLogicallyAirGappedBackupVault Operation</seealso>
        public virtual IAsyncResult BeginCreateLogicallyAirGappedBackupVault(CreateLogicallyAirGappedBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogicallyAirGappedBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogicallyAirGappedBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogicallyAirGappedBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogicallyAirGappedBackupVault.</param>
        /// 
        /// <returns>Returns a  CreateLogicallyAirGappedBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateLogicallyAirGappedBackupVault">REST API Reference for CreateLogicallyAirGappedBackupVault Operation</seealso>
        public virtual CreateLogicallyAirGappedBackupVaultResponse EndCreateLogicallyAirGappedBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogicallyAirGappedBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportPlanResponseUnmarshaller.Instance;

            return Invoke<CreateReportPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReportPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReportPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReportPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateReportPlan">REST API Reference for CreateReportPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateReportPlan(CreateReportPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReportPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReportPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReportPlan.</param>
        /// 
        /// <returns>Returns a  CreateReportPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateReportPlan">REST API Reference for CreateReportPlan Operation</seealso>
        public virtual CreateReportPlanResponse EndCreateReportPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReportPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRestoreAccessBackupVault

        /// <summary>
        /// Creates a restore access backup vault that provides temporary access to recovery points
        /// in a logically air-gapped backup vault, subject to MPA approval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreAccessBackupVault service method.</param>
        /// 
        /// <returns>The response from the CreateRestoreAccessBackupVault service method, as returned by Backup.</returns>
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
        /// <exception cref="Amazon.Backup.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreAccessBackupVault">REST API Reference for CreateRestoreAccessBackupVault Operation</seealso>
        public virtual CreateRestoreAccessBackupVaultResponse CreateRestoreAccessBackupVault(CreateRestoreAccessBackupVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreAccessBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreAccessBackupVaultResponseUnmarshaller.Instance;

            return Invoke<CreateRestoreAccessBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestoreAccessBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreAccessBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRestoreAccessBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreAccessBackupVault">REST API Reference for CreateRestoreAccessBackupVault Operation</seealso>
        public virtual IAsyncResult BeginCreateRestoreAccessBackupVault(CreateRestoreAccessBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreAccessBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreAccessBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestoreAccessBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestoreAccessBackupVault.</param>
        /// 
        /// <returns>Returns a  CreateRestoreAccessBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreAccessBackupVault">REST API Reference for CreateRestoreAccessBackupVault Operation</seealso>
        public virtual CreateRestoreAccessBackupVaultResponse EndCreateRestoreAccessBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestoreAccessBackupVaultResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRestoreTestingPlan

        /// <summary>
        /// Creates a restore testing plan.
        /// 
        ///  
        /// <para>
        /// The first of two steps to create a restore testing plan. After this request is successful,
        /// finish the procedure using CreateRestoreTestingSelection.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<CreateRestoreTestingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRestoreTestingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingPlan">REST API Reference for CreateRestoreTestingPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateRestoreTestingPlan(CreateRestoreTestingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestoreTestingPlan.</param>
        /// 
        /// <returns>Returns a  CreateRestoreTestingPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingPlan">REST API Reference for CreateRestoreTestingPlan Operation</seealso>
        public virtual CreateRestoreTestingPlanResponse EndCreateRestoreTestingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestoreTestingPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<CreateRestoreTestingSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestoreTestingSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRestoreTestingSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingSelection">REST API Reference for CreateRestoreTestingSelection Operation</seealso>
        public virtual IAsyncResult BeginCreateRestoreTestingSelection(CreateRestoreTestingSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestoreTestingSelection.</param>
        /// 
        /// <returns>Returns a  CreateRestoreTestingSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateRestoreTestingSelection">REST API Reference for CreateRestoreTestingSelection Operation</seealso>
        public virtual CreateRestoreTestingSelectionResponse EndCreateRestoreTestingSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestoreTestingSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTieringConfiguration

        /// <summary>
        /// Creates a tiering configuration.
        /// 
        ///  
        /// <para>
        /// A tiering configuration enables automatic movement of backup data to a lower-cost
        /// storage tier based on the age of backed-up objects in the backup vault.
        /// </para>
        ///  
        /// <para>
        /// Each vault can only have one vault-specific tiering configuration, in addition to
        /// any global configuration that applies to all vaults.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTieringConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateTieringConfiguration service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateTieringConfiguration">REST API Reference for CreateTieringConfiguration Operation</seealso>
        public virtual CreateTieringConfigurationResponse CreateTieringConfiguration(CreateTieringConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTieringConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateTieringConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTieringConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTieringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateTieringConfiguration">REST API Reference for CreateTieringConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateTieringConfiguration(CreateTieringConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTieringConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTieringConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateTieringConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/CreateTieringConfiguration">REST API Reference for CreateTieringConfiguration Operation</seealso>
        public virtual CreateTieringConfigurationResponse EndCreateTieringConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTieringConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupPlan(DeleteBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupPlan.</param>
        /// 
        /// <returns>Returns a  DeleteBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupPlan">REST API Reference for DeleteBackupPlan Operation</seealso>
        public virtual DeleteBackupPlanResponse EndDeleteBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupSelection(DeleteBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupSelection.</param>
        /// 
        /// <returns>Returns a  DeleteBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupSelection">REST API Reference for DeleteBackupSelection Operation</seealso>
        public virtual DeleteBackupSelectionResponse EndDeleteBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupSelectionResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVault(DeleteBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVault.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVault">REST API Reference for DeleteBackupVault Operation</seealso>
        public virtual DeleteBackupVaultResponse EndDeleteBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVaultAccessPolicy(DeleteBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultAccessPolicy">REST API Reference for DeleteBackupVaultAccessPolicy Operation</seealso>
        public virtual DeleteBackupVaultAccessPolicyResponse EndDeleteBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultAccessPolicyResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultLockConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultLockConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVaultLockConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultLockConfiguration">REST API Reference for DeleteBackupVaultLockConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVaultLockConfiguration(DeleteBackupVaultLockConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVaultLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVaultLockConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultLockConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultLockConfiguration">REST API Reference for DeleteBackupVaultLockConfiguration Operation</seealso>
        public virtual DeleteBackupVaultLockConfigurationResponse EndDeleteBackupVaultLockConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultLockConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginDeleteBackupVaultNotifications(DeleteBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  DeleteBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteBackupVaultNotifications">REST API Reference for DeleteBackupVaultNotifications Operation</seealso>
        public virtual DeleteBackupVaultNotificationsResponse EndDeleteBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBackupVaultNotificationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFrameworkResponseUnmarshaller.Instance;

            return Invoke<DeleteFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFramework operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteFramework">REST API Reference for DeleteFramework Operation</seealso>
        public virtual IAsyncResult BeginDeleteFramework(DeleteFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFramework.</param>
        /// 
        /// <returns>Returns a  DeleteFrameworkResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteFramework">REST API Reference for DeleteFramework Operation</seealso>
        public virtual DeleteFrameworkResponse EndDeleteFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFrameworkResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DeleteRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryPoint operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecoveryPoint(DeleteRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  DeleteRecoveryPointResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRecoveryPoint">REST API Reference for DeleteRecoveryPoint Operation</seealso>
        public virtual DeleteRecoveryPointResponse EndDeleteRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecoveryPointResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteReportPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReportPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReportPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteReportPlan">REST API Reference for DeleteReportPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteReportPlan(DeleteReportPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReportPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReportPlan.</param>
        /// 
        /// <returns>Returns a  DeleteReportPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteReportPlan">REST API Reference for DeleteReportPlan Operation</seealso>
        public virtual DeleteReportPlanResponse EndDeleteReportPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReportPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteRestoreTestingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRestoreTestingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingPlan">REST API Reference for DeleteRestoreTestingPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteRestoreTestingPlan(DeleteRestoreTestingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestoreTestingPlan.</param>
        /// 
        /// <returns>Returns a  DeleteRestoreTestingPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingPlan">REST API Reference for DeleteRestoreTestingPlan Operation</seealso>
        public virtual DeleteRestoreTestingPlanResponse EndDeleteRestoreTestingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRestoreTestingPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<DeleteRestoreTestingSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestoreTestingSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRestoreTestingSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingSelection">REST API Reference for DeleteRestoreTestingSelection Operation</seealso>
        public virtual IAsyncResult BeginDeleteRestoreTestingSelection(DeleteRestoreTestingSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestoreTestingSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestoreTestingSelection.</param>
        /// 
        /// <returns>Returns a  DeleteRestoreTestingSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteRestoreTestingSelection">REST API Reference for DeleteRestoreTestingSelection Operation</seealso>
        public virtual DeleteRestoreTestingSelectionResponse EndDeleteRestoreTestingSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRestoreTestingSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTieringConfiguration

        /// <summary>
        /// Deletes the tiering configuration specified by a tiering configuration name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTieringConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTieringConfiguration service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteTieringConfiguration">REST API Reference for DeleteTieringConfiguration Operation</seealso>
        public virtual DeleteTieringConfigurationResponse DeleteTieringConfiguration(DeleteTieringConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTieringConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteTieringConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTieringConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTieringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteTieringConfiguration">REST API Reference for DeleteTieringConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteTieringConfiguration(DeleteTieringConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTieringConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTieringConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTieringConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DeleteTieringConfiguration">REST API Reference for DeleteTieringConfiguration Operation</seealso>
        public virtual DeleteTieringConfigurationResponse EndDeleteTieringConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTieringConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeBackupJob(DescribeBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackupJob.</param>
        /// 
        /// <returns>Returns a  DescribeBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupJob">REST API Reference for DescribeBackupJob Operation</seealso>
        public virtual DescribeBackupJobResponse EndDescribeBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBackupJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual IAsyncResult BeginDescribeBackupVault(DescribeBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackupVault.</param>
        /// 
        /// <returns>Returns a  DescribeBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeBackupVault">REST API Reference for DescribeBackupVault Operation</seealso>
        public virtual DescribeBackupVaultResponse EndDescribeBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyJobResponseUnmarshaller.Instance;

            return Invoke<DescribeCopyJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCopyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCopyJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeCopyJob">REST API Reference for DescribeCopyJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeCopyJob(DescribeCopyJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCopyJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCopyJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCopyJob.</param>
        /// 
        /// <returns>Returns a  DescribeCopyJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeCopyJob">REST API Reference for DescribeCopyJob Operation</seealso>
        public virtual DescribeCopyJobResponse EndDescribeCopyJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCopyJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFrameworkResponseUnmarshaller.Instance;

            return Invoke<DescribeFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFramework operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeFramework">REST API Reference for DescribeFramework Operation</seealso>
        public virtual IAsyncResult BeginDescribeFramework(DescribeFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFramework.</param>
        /// 
        /// <returns>Returns a  DescribeFrameworkResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeFramework">REST API Reference for DescribeFramework Operation</seealso>
        public virtual DescribeFrameworkResponse EndDescribeFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFrameworkResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalSettings operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeGlobalSettings">REST API Reference for DescribeGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeGlobalSettings(DescribeGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGlobalSettings.</param>
        /// 
        /// <returns>Returns a  DescribeGlobalSettingsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeGlobalSettings">REST API Reference for DescribeGlobalSettings Operation</seealso>
        public virtual DescribeGlobalSettingsResponse EndDescribeGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGlobalSettingsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectedResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectedResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProtectedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeProtectedResource(DescribeProtectedResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectedResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProtectedResource.</param>
        /// 
        /// <returns>Returns a  DescribeProtectedResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeProtectedResource">REST API Reference for DescribeProtectedResource Operation</seealso>
        public virtual DescribeProtectedResourceResponse EndDescribeProtectedResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProtectedResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DescribeRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecoveryPoint operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginDescribeRecoveryPoint(DescribeRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  DescribeRecoveryPointResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRecoveryPoint">REST API Reference for DescribeRecoveryPoint Operation</seealso>
        public virtual DescribeRecoveryPointResponse EndDescribeRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRecoveryPointResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegionSettings operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRegionSettings">REST API Reference for DescribeRegionSettings Operation</seealso>
        public virtual IAsyncResult BeginDescribeRegionSettings(DescribeRegionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegionSettings.</param>
        /// 
        /// <returns>Returns a  DescribeRegionSettingsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRegionSettings">REST API Reference for DescribeRegionSettings Operation</seealso>
        public virtual DescribeRegionSettingsResponse EndDescribeRegionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRegionSettingsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeReportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportJob">REST API Reference for DescribeReportJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeReportJob(DescribeReportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReportJob.</param>
        /// 
        /// <returns>Returns a  DescribeReportJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportJob">REST API Reference for DescribeReportJob Operation</seealso>
        public virtual DescribeReportJobResponse EndDescribeReportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReportJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportPlanResponseUnmarshaller.Instance;

            return Invoke<DescribeReportPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReportPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReportPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportPlan">REST API Reference for DescribeReportPlan Operation</seealso>
        public virtual IAsyncResult BeginDescribeReportPlan(DescribeReportPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReportPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReportPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReportPlan.</param>
        /// 
        /// <returns>Returns a  DescribeReportPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeReportPlan">REST API Reference for DescribeReportPlan Operation</seealso>
        public virtual DescribeReportPlanResponse EndDescribeReportPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReportPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;

            return Invoke<DescribeRestoreJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRestoreJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRestoreJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeRestoreJob(DescribeRestoreJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRestoreJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRestoreJob.</param>
        /// 
        /// <returns>Returns a  DescribeRestoreJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DescribeRestoreJob">REST API Reference for DescribeRestoreJob Operation</seealso>
        public virtual DescribeRestoreJobResponse EndDescribeRestoreJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRestoreJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateBackupVaultMpaApprovalTeam

        /// <summary>
        /// Removes the association between an MPA approval team and a backup vault, disabling
        /// the MPA approval workflow for restore operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBackupVaultMpaApprovalTeam service method.</param>
        /// 
        /// <returns>The response from the DisassociateBackupVaultMpaApprovalTeam service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateBackupVaultMpaApprovalTeam">REST API Reference for DisassociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual DisassociateBackupVaultMpaApprovalTeamResponse DisassociateBackupVaultMpaApprovalTeam(DisassociateBackupVaultMpaApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBackupVaultMpaApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBackupVaultMpaApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<DisassociateBackupVaultMpaApprovalTeamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBackupVaultMpaApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBackupVaultMpaApprovalTeam operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBackupVaultMpaApprovalTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateBackupVaultMpaApprovalTeam">REST API Reference for DisassociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual IAsyncResult BeginDisassociateBackupVaultMpaApprovalTeam(DisassociateBackupVaultMpaApprovalTeamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateBackupVaultMpaApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateBackupVaultMpaApprovalTeamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBackupVaultMpaApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBackupVaultMpaApprovalTeam.</param>
        /// 
        /// <returns>Returns a  DisassociateBackupVaultMpaApprovalTeamResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateBackupVaultMpaApprovalTeam">REST API Reference for DisassociateBackupVaultMpaApprovalTeam Operation</seealso>
        public virtual DisassociateBackupVaultMpaApprovalTeamResponse EndDisassociateBackupVaultMpaApprovalTeam(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateBackupVaultMpaApprovalTeamResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<DisassociateRecoveryPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPoint operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRecoveryPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPoint">REST API Reference for DisassociateRecoveryPoint Operation</seealso>
        public virtual IAsyncResult BeginDisassociateRecoveryPoint(DisassociateRecoveryPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRecoveryPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRecoveryPoint.</param>
        /// 
        /// <returns>Returns a  DisassociateRecoveryPointResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPoint">REST API Reference for DisassociateRecoveryPoint Operation</seealso>
        public virtual DisassociateRecoveryPointResponse EndDisassociateRecoveryPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRecoveryPointResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointFromParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointFromParentResponseUnmarshaller.Instance;

            return Invoke<DisassociateRecoveryPointFromParentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRecoveryPointFromParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRecoveryPointFromParent operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRecoveryPointFromParent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPointFromParent">REST API Reference for DisassociateRecoveryPointFromParent Operation</seealso>
        public virtual IAsyncResult BeginDisassociateRecoveryPointFromParent(DisassociateRecoveryPointFromParentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateRecoveryPointFromParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRecoveryPointFromParentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRecoveryPointFromParent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRecoveryPointFromParent.</param>
        /// 
        /// <returns>Returns a  DisassociateRecoveryPointFromParentResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/DisassociateRecoveryPointFromParent">REST API Reference for DisassociateRecoveryPointFromParent Operation</seealso>
        public virtual DisassociateRecoveryPointFromParentResponse EndDisassociateRecoveryPointFromParent(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRecoveryPointFromParentResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;

            return Invoke<ExportBackupPlanTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportBackupPlanTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportBackupPlanTemplate operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportBackupPlanTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual IAsyncResult BeginExportBackupPlanTemplate(ExportBackupPlanTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportBackupPlanTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportBackupPlanTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportBackupPlanTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportBackupPlanTemplate.</param>
        /// 
        /// <returns>Returns a  ExportBackupPlanTemplateResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ExportBackupPlanTemplate">REST API Reference for ExportBackupPlanTemplate Operation</seealso>
        public virtual ExportBackupPlanTemplateResponse EndExportBackupPlanTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportBackupPlanTemplateResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlan(GetBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlan.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlan">REST API Reference for GetBackupPlan Operation</seealso>
        public virtual GetBackupPlanResponse EndGetBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromJSONResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromJSON operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromJSON operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlanFromJSON
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlanFromJSON(GetBackupPlanFromJSONRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromJSONRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromJSONResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlanFromJSON operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlanFromJSON.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanFromJSONResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromJSON">REST API Reference for GetBackupPlanFromJSON Operation</seealso>
        public virtual GetBackupPlanFromJSONResponse EndGetBackupPlanFromJSON(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanFromJSONResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return Invoke<GetBackupPlanFromTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupPlanFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupPlanFromTemplate operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupPlanFromTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetBackupPlanFromTemplate(GetBackupPlanFromTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupPlanFromTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupPlanFromTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupPlanFromTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupPlanFromTemplate.</param>
        /// 
        /// <returns>Returns a  GetBackupPlanFromTemplateResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupPlanFromTemplate">REST API Reference for GetBackupPlanFromTemplate Operation</seealso>
        public virtual GetBackupPlanFromTemplateResponse EndGetBackupPlanFromTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupPlanFromTemplateResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;

            return Invoke<GetBackupSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual IAsyncResult BeginGetBackupSelection(GetBackupSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupSelection.</param>
        /// 
        /// <returns>Returns a  GetBackupSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupSelection">REST API Reference for GetBackupSelection Operation</seealso>
        public virtual GetBackupSelectionResponse EndGetBackupSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupSelectionResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetBackupVaultAccessPolicy(GetBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  GetBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultAccessPolicy">REST API Reference for GetBackupVaultAccessPolicy Operation</seealso>
        public virtual GetBackupVaultAccessPolicyResponse EndGetBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupVaultAccessPolicyResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<GetBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginGetBackupVaultNotifications(GetBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  GetBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetBackupVaultNotifications">REST API Reference for GetBackupVaultNotifications Operation</seealso>
        public virtual GetBackupVaultNotificationsResponse EndGetBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBackupVaultNotificationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLegalHoldResponseUnmarshaller.Instance;

            return Invoke<GetLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLegalHold operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLegalHold
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetLegalHold">REST API Reference for GetLegalHold Operation</seealso>
        public virtual IAsyncResult BeginGetLegalHold(GetLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLegalHold.</param>
        /// 
        /// <returns>Returns a  GetLegalHoldResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetLegalHold">REST API Reference for GetLegalHold Operation</seealso>
        public virtual GetLegalHoldResponse EndGetLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLegalHoldResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecoveryPointIndexDetails

        /// <summary>
        /// This operation returns the metadata and details specific to the backup index associated
        /// with the specified recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointIndexDetails service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryPointIndexDetails service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointIndexDetails">REST API Reference for GetRecoveryPointIndexDetails Operation</seealso>
        public virtual GetRecoveryPointIndexDetailsResponse GetRecoveryPointIndexDetails(GetRecoveryPointIndexDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointIndexDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointIndexDetailsResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointIndexDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPointIndexDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointIndexDetails operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryPointIndexDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointIndexDetails">REST API Reference for GetRecoveryPointIndexDetails Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryPointIndexDetails(GetRecoveryPointIndexDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointIndexDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointIndexDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryPointIndexDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryPointIndexDetails.</param>
        /// 
        /// <returns>Returns a  GetRecoveryPointIndexDetailsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointIndexDetails">REST API Reference for GetRecoveryPointIndexDetails Operation</seealso>
        public virtual GetRecoveryPointIndexDetailsResponse EndGetRecoveryPointIndexDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryPointIndexDetailsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointRestoreMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryPointRestoreMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPointRestoreMetadata operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryPointRestoreMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetRecoveryPointRestoreMetadata(GetRecoveryPointRestoreMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRestoreMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointRestoreMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryPointRestoreMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryPointRestoreMetadata.</param>
        /// 
        /// <returns>Returns a  GetRecoveryPointRestoreMetadataResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRecoveryPointRestoreMetadata">REST API Reference for GetRecoveryPointRestoreMetadata Operation</seealso>
        public virtual GetRecoveryPointRestoreMetadataResponse EndGetRecoveryPointRestoreMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecoveryPointRestoreMetadataResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreJobMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreJobMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRestoreJobMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestoreJobMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreJobMetadata operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestoreJobMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreJobMetadata">REST API Reference for GetRestoreJobMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetRestoreJobMetadata(GetRestoreJobMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreJobMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreJobMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestoreJobMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestoreJobMetadata.</param>
        /// 
        /// <returns>Returns a  GetRestoreJobMetadataResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreJobMetadata">REST API Reference for GetRestoreJobMetadata Operation</seealso>
        public virtual GetRestoreJobMetadataResponse EndGetRestoreJobMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestoreJobMetadataResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingInferredMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingInferredMetadataResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingInferredMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestoreTestingInferredMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingInferredMetadata operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestoreTestingInferredMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingInferredMetadata">REST API Reference for GetRestoreTestingInferredMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetRestoreTestingInferredMetadata(GetRestoreTestingInferredMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingInferredMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingInferredMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestoreTestingInferredMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestoreTestingInferredMetadata.</param>
        /// 
        /// <returns>Returns a  GetRestoreTestingInferredMetadataResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingInferredMetadata">REST API Reference for GetRestoreTestingInferredMetadata Operation</seealso>
        public virtual GetRestoreTestingInferredMetadataResponse EndGetRestoreTestingInferredMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestoreTestingInferredMetadataResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestoreTestingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingPlan">REST API Reference for GetRestoreTestingPlan Operation</seealso>
        public virtual IAsyncResult BeginGetRestoreTestingPlan(GetRestoreTestingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestoreTestingPlan.</param>
        /// 
        /// <returns>Returns a  GetRestoreTestingPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingPlan">REST API Reference for GetRestoreTestingPlan Operation</seealso>
        public virtual GetRestoreTestingPlanResponse EndGetRestoreTestingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestoreTestingPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<GetRestoreTestingSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestoreTestingSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestoreTestingSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingSelection">REST API Reference for GetRestoreTestingSelection Operation</seealso>
        public virtual IAsyncResult BeginGetRestoreTestingSelection(GetRestoreTestingSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestoreTestingSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestoreTestingSelection.</param>
        /// 
        /// <returns>Returns a  GetRestoreTestingSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetRestoreTestingSelection">REST API Reference for GetRestoreTestingSelection Operation</seealso>
        public virtual GetRestoreTestingSelectionResponse EndGetRestoreTestingSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestoreTestingSelectionResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return Invoke<GetSupportedResourceTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSupportedResourceTypes operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSupportedResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginGetSupportedResourceTypes(GetSupportedResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSupportedResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportedResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSupportedResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSupportedResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetSupportedResourceTypesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetSupportedResourceTypes">REST API Reference for GetSupportedResourceTypes Operation</seealso>
        public virtual GetSupportedResourceTypesResponse EndGetSupportedResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSupportedResourceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTieringConfiguration

        /// <summary>
        /// Returns <c>TieringConfiguration</c> details for the specified <c>TieringConfigurationName</c>.
        /// The details are the body of a tiering configuration in JSON format, in addition to
        /// configuration metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTieringConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTieringConfiguration service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetTieringConfiguration">REST API Reference for GetTieringConfiguration Operation</seealso>
        public virtual GetTieringConfigurationResponse GetTieringConfiguration(GetTieringConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTieringConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTieringConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTieringConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTieringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetTieringConfiguration">REST API Reference for GetTieringConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetTieringConfiguration(GetTieringConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTieringConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTieringConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTieringConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/GetTieringConfiguration">REST API Reference for GetTieringConfiguration Operation</seealso>
        public virtual GetTieringConfigurationResponse EndGetTieringConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTieringConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual IAsyncResult BeginListBackupJobs(ListBackupJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupJobs.</param>
        /// 
        /// <returns>Returns a  ListBackupJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobs">REST API Reference for ListBackupJobs Operation</seealso>
        public virtual ListBackupJobsResponse EndListBackupJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupJobsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListBackupJobSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupJobSummaries operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupJobSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobSummaries">REST API Reference for ListBackupJobSummaries Operation</seealso>
        public virtual IAsyncResult BeginListBackupJobSummaries(ListBackupJobSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupJobSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupJobSummaries.</param>
        /// 
        /// <returns>Returns a  ListBackupJobSummariesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupJobSummaries">REST API Reference for ListBackupJobSummaries Operation</seealso>
        public virtual ListBackupJobSummariesResponse EndListBackupJobSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupJobSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupPlans

        /// <summary>
        /// Lists the active backup plans for the account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlans operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlans(ListBackupPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlans.</param>
        /// 
        /// <returns>Returns a  ListBackupPlansResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlans">REST API Reference for ListBackupPlans Operation</seealso>
        public virtual ListBackupPlansResponse EndListBackupPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBackupPlanTemplates

        /// <summary>
        /// Lists the backup plan templates.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanTemplates operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlanTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlanTemplates(ListBackupPlanTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlanTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlanTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlanTemplates.</param>
        /// 
        /// <returns>Returns a  ListBackupPlanTemplatesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanTemplates">REST API Reference for ListBackupPlanTemplates Operation</seealso>
        public virtual ListBackupPlanTemplatesResponse EndListBackupPlanTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlanTemplatesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupPlanVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupPlanVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupPlanVersions operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupPlanVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual IAsyncResult BeginListBackupPlanVersions(ListBackupPlanVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupPlanVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupPlanVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupPlanVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupPlanVersions.</param>
        /// 
        /// <returns>Returns a  ListBackupPlanVersionsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupPlanVersions">REST API Reference for ListBackupPlanVersions Operation</seealso>
        public virtual ListBackupPlanVersionsResponse EndListBackupPlanVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupPlanVersionsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;

            return Invoke<ListBackupSelectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupSelections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupSelections operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupSelections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual IAsyncResult BeginListBackupSelections(ListBackupSelectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupSelectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupSelections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupSelections.</param>
        /// 
        /// <returns>Returns a  ListBackupSelectionsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupSelections">REST API Reference for ListBackupSelections Operation</seealso>
        public virtual ListBackupSelectionsResponse EndListBackupSelections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupSelectionsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;

            return Invoke<ListBackupVaultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBackupVaults operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBackupVaults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual IAsyncResult BeginListBackupVaults(ListBackupVaultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupVaultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBackupVaults.</param>
        /// 
        /// <returns>Returns a  ListBackupVaultsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListBackupVaults">REST API Reference for ListBackupVaults Operation</seealso>
        public virtual ListBackupVaultsResponse EndListBackupVaults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBackupVaultsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobsResponseUnmarshaller.Instance;

            return Invoke<ListCopyJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCopyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCopyJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobs">REST API Reference for ListCopyJobs Operation</seealso>
        public virtual IAsyncResult BeginListCopyJobs(ListCopyJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCopyJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCopyJobs.</param>
        /// 
        /// <returns>Returns a  ListCopyJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobs">REST API Reference for ListCopyJobs Operation</seealso>
        public virtual ListCopyJobsResponse EndListCopyJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCopyJobsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCopyJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListCopyJobSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCopyJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCopyJobSummaries operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCopyJobSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobSummaries">REST API Reference for ListCopyJobSummaries Operation</seealso>
        public virtual IAsyncResult BeginListCopyJobSummaries(ListCopyJobSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCopyJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCopyJobSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCopyJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCopyJobSummaries.</param>
        /// 
        /// <returns>Returns a  ListCopyJobSummariesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListCopyJobSummaries">REST API Reference for ListCopyJobSummaries Operation</seealso>
        public virtual ListCopyJobSummariesResponse EndListCopyJobSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCopyJobSummariesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFrameworksResponseUnmarshaller.Instance;

            return Invoke<ListFrameworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFrameworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFrameworks operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFrameworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListFrameworks">REST API Reference for ListFrameworks Operation</seealso>
        public virtual IAsyncResult BeginListFrameworks(ListFrameworksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFrameworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFrameworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFrameworks.</param>
        /// 
        /// <returns>Returns a  ListFrameworksResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListFrameworks">REST API Reference for ListFrameworks Operation</seealso>
        public virtual ListFrameworksResponse EndListFrameworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFrameworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIndexedRecoveryPoints

        /// <summary>
        /// This operation returns a list of recovery points that have an associated index, belonging
        /// to the specified account.
        /// 
        ///  
        /// <para>
        /// Optional parameters you can include are: MaxResults; NextToken; SourceResourceArns;
        /// CreatedBefore; CreatedAfter; and ResourceType.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndexedRecoveryPoints service method.</param>
        /// 
        /// <returns>The response from the ListIndexedRecoveryPoints service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListIndexedRecoveryPoints">REST API Reference for ListIndexedRecoveryPoints Operation</seealso>
        public virtual ListIndexedRecoveryPointsResponse ListIndexedRecoveryPoints(ListIndexedRecoveryPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexedRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexedRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListIndexedRecoveryPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndexedRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndexedRecoveryPoints operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndexedRecoveryPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListIndexedRecoveryPoints">REST API Reference for ListIndexedRecoveryPoints Operation</seealso>
        public virtual IAsyncResult BeginListIndexedRecoveryPoints(ListIndexedRecoveryPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIndexedRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIndexedRecoveryPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndexedRecoveryPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndexedRecoveryPoints.</param>
        /// 
        /// <returns>Returns a  ListIndexedRecoveryPointsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListIndexedRecoveryPoints">REST API Reference for ListIndexedRecoveryPoints Operation</seealso>
        public virtual ListIndexedRecoveryPointsResponse EndListIndexedRecoveryPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIndexedRecoveryPointsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLegalHoldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLegalHoldsResponseUnmarshaller.Instance;

            return Invoke<ListLegalHoldsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLegalHolds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLegalHolds operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLegalHolds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListLegalHolds">REST API Reference for ListLegalHolds Operation</seealso>
        public virtual IAsyncResult BeginListLegalHolds(ListLegalHoldsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLegalHoldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLegalHoldsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLegalHolds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLegalHolds.</param>
        /// 
        /// <returns>Returns a  ListLegalHoldsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListLegalHolds">REST API Reference for ListLegalHolds Operation</seealso>
        public virtual ListLegalHoldsResponse EndListLegalHolds(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLegalHoldsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResources operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual IAsyncResult BeginListProtectedResources(ListProtectedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedResources.</param>
        /// 
        /// <returns>Returns a  ListProtectedResourcesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResources">REST API Reference for ListProtectedResources Operation</seealso>
        public virtual ListProtectedResourcesResponse EndListProtectedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectedResourcesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesByBackupVaultResponseUnmarshaller.Instance;

            return Invoke<ListProtectedResourcesByBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedResourcesByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedResourcesByBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedResourcesByBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResourcesByBackupVault">REST API Reference for ListProtectedResourcesByBackupVault Operation</seealso>
        public virtual IAsyncResult BeginListProtectedResourcesByBackupVault(ListProtectedResourcesByBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectedResourcesByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectedResourcesByBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedResourcesByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedResourcesByBackupVault.</param>
        /// 
        /// <returns>Returns a  ListProtectedResourcesByBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListProtectedResourcesByBackupVault">REST API Reference for ListProtectedResourcesByBackupVault Operation</seealso>
        public virtual ListProtectedResourcesByBackupVaultResponse EndListProtectedResourcesByBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtectedResourcesByBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPointsByBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPointsByBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPointsByBackupVault.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsByBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByBackupVault">REST API Reference for ListRecoveryPointsByBackupVault Operation</seealso>
        public virtual ListRecoveryPointsByBackupVaultResponse EndListRecoveryPointsByBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsByBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByLegalHoldResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByLegalHoldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByLegalHold operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPointsByLegalHold
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByLegalHold">REST API Reference for ListRecoveryPointsByLegalHold Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPointsByLegalHold(ListRecoveryPointsByLegalHoldRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByLegalHoldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPointsByLegalHold operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPointsByLegalHold.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsByLegalHoldResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByLegalHold">REST API Reference for ListRecoveryPointsByLegalHold Operation</seealso>
        public virtual ListRecoveryPointsByLegalHoldResponse EndListRecoveryPointsByLegalHold(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsByLegalHoldResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecoveryPointsByResource

        /// <summary>
        /// The information about the recovery points of the type specified by a resource Amazon
        /// Resource Name (ARN).
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsByResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryPointsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPointsByResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryPointsByResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual IAsyncResult BeginListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsByResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryPointsByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryPointsByResource.</param>
        /// 
        /// <returns>Returns a  ListRecoveryPointsByResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRecoveryPointsByResource">REST API Reference for ListRecoveryPointsByResource Operation</seealso>
        public virtual ListRecoveryPointsByResourceResponse EndListRecoveryPointsByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecoveryPointsByResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportJobs">REST API Reference for ListReportJobs Operation</seealso>
        public virtual IAsyncResult BeginListReportJobs(ListReportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportJobs.</param>
        /// 
        /// <returns>Returns a  ListReportJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportJobs">REST API Reference for ListReportJobs Operation</seealso>
        public virtual ListReportJobsResponse EndListReportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportJobsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportPlansResponseUnmarshaller.Instance;

            return Invoke<ListReportPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReportPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReportPlans operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReportPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportPlans">REST API Reference for ListReportPlans Operation</seealso>
        public virtual IAsyncResult BeginListReportPlans(ListReportPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReportPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReportPlans.</param>
        /// 
        /// <returns>Returns a  ListReportPlansResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListReportPlans">REST API Reference for ListReportPlans Operation</seealso>
        public virtual ListReportPlansResponse EndListReportPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReportPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRestoreAccessBackupVaults

        /// <summary>
        /// Returns a list of restore access backup vaults associated with a specified backup
        /// vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreAccessBackupVaults service method.</param>
        /// 
        /// <returns>The response from the ListRestoreAccessBackupVaults service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreAccessBackupVaults">REST API Reference for ListRestoreAccessBackupVaults Operation</seealso>
        public virtual ListRestoreAccessBackupVaultsResponse ListRestoreAccessBackupVaults(ListRestoreAccessBackupVaultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreAccessBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreAccessBackupVaultsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreAccessBackupVaultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreAccessBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreAccessBackupVaults operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreAccessBackupVaults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreAccessBackupVaults">REST API Reference for ListRestoreAccessBackupVaults Operation</seealso>
        public virtual IAsyncResult BeginListRestoreAccessBackupVaults(ListRestoreAccessBackupVaultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreAccessBackupVaultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreAccessBackupVaultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreAccessBackupVaults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreAccessBackupVaults.</param>
        /// 
        /// <returns>Returns a  ListRestoreAccessBackupVaultsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreAccessBackupVaults">REST API Reference for ListRestoreAccessBackupVaults Operation</seealso>
        public virtual ListRestoreAccessBackupVaultsResponse EndListRestoreAccessBackupVaults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreAccessBackupVaultsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobs operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual IAsyncResult BeginListRestoreJobs(ListRestoreJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreJobs.</param>
        /// 
        /// <returns>Returns a  ListRestoreJobsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobs">REST API Reference for ListRestoreJobs Operation</seealso>
        public virtual ListRestoreJobsResponse EndListRestoreJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreJobsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsByProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsByProtectedResourceResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobsByProtectedResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreJobsByProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobsByProtectedResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreJobsByProtectedResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobsByProtectedResource">REST API Reference for ListRestoreJobsByProtectedResource Operation</seealso>
        public virtual IAsyncResult BeginListRestoreJobsByProtectedResource(ListRestoreJobsByProtectedResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobsByProtectedResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobsByProtectedResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreJobsByProtectedResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreJobsByProtectedResource.</param>
        /// 
        /// <returns>Returns a  ListRestoreJobsByProtectedResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobsByProtectedResource">REST API Reference for ListRestoreJobsByProtectedResource Operation</seealso>
        public virtual ListRestoreJobsByProtectedResourceResponse EndListRestoreJobsByProtectedResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreJobsByProtectedResourceResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobSummariesResponseUnmarshaller.Instance;

            return Invoke<ListRestoreJobSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreJobSummaries operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreJobSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobSummaries">REST API Reference for ListRestoreJobSummaries Operation</seealso>
        public virtual IAsyncResult BeginListRestoreJobSummaries(ListRestoreJobSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreJobSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreJobSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreJobSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreJobSummaries.</param>
        /// 
        /// <returns>Returns a  ListRestoreJobSummariesResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreJobSummaries">REST API Reference for ListRestoreJobSummaries Operation</seealso>
        public virtual ListRestoreJobSummariesResponse EndListRestoreJobSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreJobSummariesResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingPlansResponseUnmarshaller.Instance;

            return Invoke<ListRestoreTestingPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreTestingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingPlans operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreTestingPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingPlans">REST API Reference for ListRestoreTestingPlans Operation</seealso>
        public virtual IAsyncResult BeginListRestoreTestingPlans(ListRestoreTestingPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreTestingPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreTestingPlans.</param>
        /// 
        /// <returns>Returns a  ListRestoreTestingPlansResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingPlans">REST API Reference for ListRestoreTestingPlans Operation</seealso>
        public virtual ListRestoreTestingPlansResponse EndListRestoreTestingPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreTestingPlansResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingSelectionsResponseUnmarshaller.Instance;

            return Invoke<ListRestoreTestingSelectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRestoreTestingSelections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRestoreTestingSelections operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRestoreTestingSelections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingSelections">REST API Reference for ListRestoreTestingSelections Operation</seealso>
        public virtual IAsyncResult BeginListRestoreTestingSelections(ListRestoreTestingSelectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRestoreTestingSelectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRestoreTestingSelectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRestoreTestingSelections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRestoreTestingSelections.</param>
        /// 
        /// <returns>Returns a  ListRestoreTestingSelectionsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListRestoreTestingSelections">REST API Reference for ListRestoreTestingSelections Operation</seealso>
        public virtual ListRestoreTestingSelectionsResponse EndListRestoreTestingSelections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRestoreTestingSelectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns the tags assigned to the resource, such as a target recovery point, backup
        /// plan, or backup vault.
        /// 
        ///  
        /// <para>
        /// This operation returns results depending on the resource type used in the value for
        /// <c>resourceArn</c>. For example, recovery points of Amazon DynamoDB with Advanced
        /// Settings have an ARN (Amazon Resource Name) that begins with <c>arn:aws:backup</c>.
        /// Recovery points (backups) of DynamoDB without Advanced Settings enabled have an ARN
        /// that begins with <c>arn:aws:dynamodb</c>.
        /// </para>
        ///  
        /// <para>
        /// When this operation is called and when you include values of <c>resourceArn</c> that
        /// have an ARN other than <c>arn:aws:backup</c>, it may return one of the exceptions
        /// listed below. To prevent this exception, include only values representing resource
        /// types that are fully managed by Backup. These have an ARN that begins <c>arn:aws:backup</c>
        /// and they are noted in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTieringConfigurations

        /// <summary>
        /// Returns a list of tiering configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTieringConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListTieringConfigurations service method, as returned by Backup.</returns>
        /// <exception cref="Amazon.Backup.Model.InvalidParameterValueException">
        /// Indicates that something is wrong with a parameter's value. For example, the value
        /// is out of range.
        /// </exception>
        /// <exception cref="Amazon.Backup.Model.ServiceUnavailableException">
        /// The request failed due to a temporary failure of the server.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTieringConfigurations">REST API Reference for ListTieringConfigurations Operation</seealso>
        public virtual ListTieringConfigurationsResponse ListTieringConfigurations(ListTieringConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTieringConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTieringConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListTieringConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTieringConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTieringConfigurations operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTieringConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTieringConfigurations">REST API Reference for ListTieringConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListTieringConfigurations(ListTieringConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTieringConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTieringConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTieringConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTieringConfigurations.</param>
        /// 
        /// <returns>Returns a  ListTieringConfigurationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/ListTieringConfigurations">REST API Reference for ListTieringConfigurations Operation</seealso>
        public virtual ListTieringConfigurationsResponse EndListTieringConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTieringConfigurationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultAccessPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultAccessPolicy operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBackupVaultAccessPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutBackupVaultAccessPolicy(PutBackupVaultAccessPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultAccessPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBackupVaultAccessPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBackupVaultAccessPolicy.</param>
        /// 
        /// <returns>Returns a  PutBackupVaultAccessPolicyResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultAccessPolicy">REST API Reference for PutBackupVaultAccessPolicy Operation</seealso>
        public virtual PutBackupVaultAccessPolicyResponse EndPutBackupVaultAccessPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBackupVaultAccessPolicyResponse>(asyncResult);
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
        /// how Backup Vault Lock relates to these regulations, see the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/samples/cohassetreport.zip">Cohasset
        /// Associates Compliance Assessment.</a> 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/vault-lock.html">Backup
        /// Vault Lock</a>.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultLockConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultLockConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBackupVaultLockConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultLockConfiguration">REST API Reference for PutBackupVaultLockConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutBackupVaultLockConfiguration(PutBackupVaultLockConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultLockConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBackupVaultLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBackupVaultLockConfiguration.</param>
        /// 
        /// <returns>Returns a  PutBackupVaultLockConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultLockConfiguration">REST API Reference for PutBackupVaultLockConfiguration Operation</seealso>
        public virtual PutBackupVaultLockConfigurationResponse EndPutBackupVaultLockConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBackupVaultLockConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;

            return Invoke<PutBackupVaultNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBackupVaultNotifications operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBackupVaultNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual IAsyncResult BeginPutBackupVaultNotifications(PutBackupVaultNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutBackupVaultNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBackupVaultNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutBackupVaultNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBackupVaultNotifications.</param>
        /// 
        /// <returns>Returns a  PutBackupVaultNotificationsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutBackupVaultNotifications">REST API Reference for PutBackupVaultNotifications Operation</seealso>
        public virtual PutBackupVaultNotificationsResponse EndPutBackupVaultNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<PutBackupVaultNotificationsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRestoreValidationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestoreValidationResultResponseUnmarshaller.Instance;

            return Invoke<PutRestoreValidationResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRestoreValidationResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRestoreValidationResult operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRestoreValidationResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutRestoreValidationResult">REST API Reference for PutRestoreValidationResult Operation</seealso>
        public virtual IAsyncResult BeginPutRestoreValidationResult(PutRestoreValidationResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRestoreValidationResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestoreValidationResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRestoreValidationResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRestoreValidationResult.</param>
        /// 
        /// <returns>Returns a  PutRestoreValidationResultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/PutRestoreValidationResult">REST API Reference for PutRestoreValidationResult Operation</seealso>
        public virtual PutRestoreValidationResultResponse EndPutRestoreValidationResult(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRestoreValidationResultResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeRestoreAccessBackupVault

        /// <summary>
        /// Revokes access to a restore access backup vault, removing the ability to restore from
        /// its recovery points and permanently deleting the vault.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRestoreAccessBackupVault service method.</param>
        /// 
        /// <returns>The response from the RevokeRestoreAccessBackupVault service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/RevokeRestoreAccessBackupVault">REST API Reference for RevokeRestoreAccessBackupVault Operation</seealso>
        public virtual RevokeRestoreAccessBackupVaultResponse RevokeRestoreAccessBackupVault(RevokeRestoreAccessBackupVaultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeRestoreAccessBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRestoreAccessBackupVaultResponseUnmarshaller.Instance;

            return Invoke<RevokeRestoreAccessBackupVaultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeRestoreAccessBackupVault operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeRestoreAccessBackupVault operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeRestoreAccessBackupVault
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/RevokeRestoreAccessBackupVault">REST API Reference for RevokeRestoreAccessBackupVault Operation</seealso>
        public virtual IAsyncResult BeginRevokeRestoreAccessBackupVault(RevokeRestoreAccessBackupVaultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeRestoreAccessBackupVaultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeRestoreAccessBackupVaultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeRestoreAccessBackupVault operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeRestoreAccessBackupVault.</param>
        /// 
        /// <returns>Returns a  RevokeRestoreAccessBackupVaultResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/RevokeRestoreAccessBackupVault">REST API Reference for RevokeRestoreAccessBackupVault Operation</seealso>
        public virtual RevokeRestoreAccessBackupVaultResponse EndRevokeRestoreAccessBackupVault(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeRestoreAccessBackupVaultResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;

            return Invoke<StartBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual IAsyncResult BeginStartBackupJob(StartBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBackupJob.</param>
        /// 
        /// <returns>Returns a  StartBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartBackupJob">REST API Reference for StartBackupJob Operation</seealso>
        public virtual StartBackupJobResponse EndStartBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartBackupJobResponse>(asyncResult);
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
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/recov-point-create-a-copy.html#backup-copy-retry">Copy
        /// job retry</a> for information on how Backup retries copy job operations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCopyJobResponseUnmarshaller.Instance;

            return Invoke<StartCopyJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCopyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCopyJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCopyJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartCopyJob">REST API Reference for StartCopyJob Operation</seealso>
        public virtual IAsyncResult BeginStartCopyJob(StartCopyJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCopyJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCopyJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCopyJob.</param>
        /// 
        /// <returns>Returns a  StartCopyJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartCopyJob">REST API Reference for StartCopyJob Operation</seealso>
        public virtual StartCopyJobResponse EndStartCopyJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCopyJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportJobResponseUnmarshaller.Instance;

            return Invoke<StartReportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReportJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartReportJob">REST API Reference for StartReportJob Operation</seealso>
        public virtual IAsyncResult BeginStartReportJob(StartReportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartReportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReportJob.</param>
        /// 
        /// <returns>Returns a  StartReportJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartReportJob">REST API Reference for StartReportJob Operation</seealso>
        public virtual StartReportJobResponse EndStartReportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReportJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;

            return Invoke<StartRestoreJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRestoreJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRestoreJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual IAsyncResult BeginStartRestoreJob(StartRestoreJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRestoreJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRestoreJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRestoreJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRestoreJob.</param>
        /// 
        /// <returns>Returns a  StartRestoreJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StartRestoreJob">REST API Reference for StartRestoreJob Operation</seealso>
        public virtual StartRestoreJobResponse EndStartRestoreJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRestoreJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopBackupJob

        /// <summary>
        /// Attempts to cancel a job to create a one-time backup of a resource.
        /// 
        ///  
        /// <para>
        /// This action is not supported for the following services:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon DocumentDB (with MongoDB compatibility)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for Lustre
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for NetApp ONTAP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for OpenZFS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for Windows File Server
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Neptune
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SAP HANA databases on Amazon EC2 instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon RDS
        /// </para>
        ///  </li> </ul>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return Invoke<StopBackupJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopBackupJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBackupJob operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBackupJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual IAsyncResult BeginStopBackupJob(StopBackupJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopBackupJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBackupJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopBackupJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBackupJob.</param>
        /// 
        /// <returns>Returns a  StopBackupJobResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/StopBackupJob">REST API Reference for StopBackupJob Operation</seealso>
        public virtual StopBackupJobResponse EndStopBackupJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopBackupJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns a set of key-value pairs to a resource.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a set of key-value pairs from a recovery point, backup plan, or backup vault
        /// identified by an Amazon Resource Name (ARN)
        /// 
        ///  
        /// <para>
        /// This API is not supported for recovery points for resource types including Aurora,
        /// Amazon DocumentDB. Amazon EBS, Amazon FSx, Neptune, and Amazon RDS.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBackupPlan

        /// <summary>
        /// Updates the specified backup plan. The new version is uniquely identified by its ID.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateBackupPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackupPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBackupPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateBackupPlan(UpdateBackupPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBackupPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBackupPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBackupPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBackupPlan.</param>
        /// 
        /// <returns>Returns a  UpdateBackupPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateBackupPlan">REST API Reference for UpdateBackupPlan Operation</seealso>
        public virtual UpdateBackupPlanResponse EndUpdateBackupPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBackupPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFramework

        /// <summary>
        /// Updates the specified framework.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFrameworkResponseUnmarshaller.Instance;

            return Invoke<UpdateFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFramework operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateFramework">REST API Reference for UpdateFramework Operation</seealso>
        public virtual IAsyncResult BeginUpdateFramework(UpdateFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFramework.</param>
        /// 
        /// <returns>Returns a  UpdateFrameworkResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateFramework">REST API Reference for UpdateFramework Operation</seealso>
        public virtual UpdateFrameworkResponse EndUpdateFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFrameworkResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlobalSettings(UpdateGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalSettings.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalSettingsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse EndUpdateGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlobalSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecoveryPointIndexSettings

        /// <summary>
        /// This operation updates the settings of a recovery point index.
        /// 
        ///  
        /// <para>
        /// Required: BackupVaultName, RecoveryPointArn, and IAMRoleArn
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointIndexSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateRecoveryPointIndexSettings service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointIndexSettings">REST API Reference for UpdateRecoveryPointIndexSettings Operation</seealso>
        public virtual UpdateRecoveryPointIndexSettingsResponse UpdateRecoveryPointIndexSettings(UpdateRecoveryPointIndexSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointIndexSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointIndexSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateRecoveryPointIndexSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryPointIndexSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointIndexSettings operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecoveryPointIndexSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointIndexSettings">REST API Reference for UpdateRecoveryPointIndexSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecoveryPointIndexSettings(UpdateRecoveryPointIndexSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointIndexSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointIndexSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecoveryPointIndexSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecoveryPointIndexSettings.</param>
        /// 
        /// <returns>Returns a  UpdateRecoveryPointIndexSettingsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointIndexSettings">REST API Reference for UpdateRecoveryPointIndexSettings Operation</seealso>
        public virtual UpdateRecoveryPointIndexSettingsResponse EndUpdateRecoveryPointIndexSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecoveryPointIndexSettingsResponse>(asyncResult);
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
        /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table. Backup ignores this expression for other resource
        /// types.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
        /// to cold after days” setting. The “transition to cold after days” setting cannot be
        /// changed after a backup has been transitioned to cold.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your lifecycle currently uses the parameters <c>DeleteAfterDays</c> and <c>MoveToColdStorageAfterDays</c>,
        /// include these parameters and their values when you call this operation. Not including
        /// them may result in your plan updating with null values.
        /// </para>
        ///  </important> 
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateRecoveryPointLifecycleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryPointLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryPointLifecycle operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecoveryPointLifecycle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecoveryPointLifecycle(UpdateRecoveryPointLifecycleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecoveryPointLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecoveryPointLifecycleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecoveryPointLifecycle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecoveryPointLifecycle.</param>
        /// 
        /// <returns>Returns a  UpdateRecoveryPointLifecycleResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRecoveryPointLifecycle">REST API Reference for UpdateRecoveryPointLifecycle Operation</seealso>
        public virtual UpdateRecoveryPointLifecycleResponse EndUpdateRecoveryPointLifecycle(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecoveryPointLifecycleResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegionSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateRegionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRegionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegionSettings operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRegionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRegionSettings">REST API Reference for UpdateRegionSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateRegionSettings(UpdateRegionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRegionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRegionSettings.</param>
        /// 
        /// <returns>Returns a  UpdateRegionSettingsResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRegionSettings">REST API Reference for UpdateRegionSettings Operation</seealso>
        public virtual UpdateRegionSettingsResponse EndUpdateRegionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRegionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateReportPlan

        /// <summary>
        /// Updates the specified report plan.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateReportPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReportPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReportPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateReportPlan">REST API Reference for UpdateReportPlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateReportPlan(UpdateReportPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReportPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReportPlan.</param>
        /// 
        /// <returns>Returns a  UpdateReportPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateReportPlan">REST API Reference for UpdateReportPlan Operation</seealso>
        public virtual UpdateReportPlanResponse EndUpdateReportPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateReportPlanResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateRestoreTestingPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingPlan operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRestoreTestingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingPlan">REST API Reference for UpdateRestoreTestingPlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateRestoreTestingPlan(UpdateRestoreTestingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestoreTestingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestoreTestingPlan.</param>
        /// 
        /// <returns>Returns a  UpdateRestoreTestingPlanResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingPlan">REST API Reference for UpdateRestoreTestingPlan Operation</seealso>
        public virtual UpdateRestoreTestingPlanResponse EndUpdateRestoreTestingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRestoreTestingPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRestoreTestingSelection

        /// <summary>
        /// Updates the specified restore testing selection.
        /// 
        ///  
        /// <para>
        /// Most elements except the <c>RestoreTestingSelectionName</c> can be updated with this
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You can use either protected resource ARNs or conditions, but not both.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return Invoke<UpdateRestoreTestingSelectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestoreTestingSelection operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRestoreTestingSelection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingSelection">REST API Reference for UpdateRestoreTestingSelection Operation</seealso>
        public virtual IAsyncResult BeginUpdateRestoreTestingSelection(UpdateRestoreTestingSelectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestoreTestingSelectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestoreTestingSelectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestoreTestingSelection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestoreTestingSelection.</param>
        /// 
        /// <returns>Returns a  UpdateRestoreTestingSelectionResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateRestoreTestingSelection">REST API Reference for UpdateRestoreTestingSelection Operation</seealso>
        public virtual UpdateRestoreTestingSelectionResponse EndUpdateRestoreTestingSelection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRestoreTestingSelectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTieringConfiguration

        /// <summary>
        /// This request will send changes to your specified tiering configuration. <c>TieringConfigurationName</c>
        /// cannot be updated after it is created.
        /// 
        ///  
        /// <para>
        ///  <c>ResourceSelection</c> can contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Resources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TieringDownSettingsInDays</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTieringConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateTieringConfiguration service method, as returned by Backup.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateTieringConfiguration">REST API Reference for UpdateTieringConfiguration Operation</seealso>
        public virtual UpdateTieringConfigurationResponse UpdateTieringConfiguration(UpdateTieringConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTieringConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateTieringConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTieringConfiguration operation on AmazonBackupClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTieringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateTieringConfiguration">REST API Reference for UpdateTieringConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateTieringConfiguration(UpdateTieringConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTieringConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTieringConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTieringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTieringConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateTieringConfigurationResult from Backup.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-2018-11-15/UpdateTieringConfiguration">REST API Reference for UpdateTieringConfiguration Operation</seealso>
        public virtual UpdateTieringConfigurationResponse EndUpdateTieringConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTieringConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonBackupEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}
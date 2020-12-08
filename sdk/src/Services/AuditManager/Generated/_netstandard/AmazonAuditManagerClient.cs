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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AuditManager.Model;
using Amazon.AuditManager.Model.Internal.MarshallTransformations;
using Amazon.AuditManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AuditManager
{
    /// <summary>
    /// Implementation for accessing AuditManager
    ///
    /// Welcome to the AWS Audit Manager API reference. This guide is for developers who need
    /// detailed information about the AWS Audit Manager API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// AWS Audit Manager is a service that provides automated evidence collection so that
    /// you can continuously audit your AWS usage, and assess the effectiveness of your controls
    /// to better manage risk and simplify compliance.
    /// </para>
    ///  
    /// <para>
    /// AWS Audit Manager provides pre-built frameworks that structure and automate assessments
    /// for a given compliance standard. Frameworks include a pre-built collection of controls
    /// with descriptions and testing procedures, which are grouped according to the requirements
    /// of the specified compliance standard or regulation. You can also customize frameworks
    /// and controls to support internal audits with unique requirements. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started with the AWS Audit Manager API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all AWS Audit Manager API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all AWS Audit Manager data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all Query operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to AWS Audit Manager, we recommend that you review the <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/what-is.html">
    /// AWS Audit Manager User Guide</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonAuditManagerClient : AmazonServiceClient, IAmazonAuditManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonAuditManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAuditManagerClient with the credentials loaded from the application's
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
        public AmazonAuditManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAuditManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with the credentials loaded from the application's
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
        public AmazonAuditManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAuditManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAuditManagerClient Configuration Object</param>
        public AmazonAuditManagerClient(AmazonAuditManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAuditManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonAuditManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAuditManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAuditManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Credentials and an
        /// AmazonAuditManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAuditManagerClient Configuration Object</param>
        public AmazonAuditManagerClient(AWSCredentials credentials, AmazonAuditManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAuditManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAuditManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAuditManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAuditManagerClient Configuration Object</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAuditManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAuditManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAuditManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAuditManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAuditManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAuditManagerClient Configuration Object</param>
        public AmazonAuditManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAuditManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAuditManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAuditManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AuditManagerPaginatorFactory(this);
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


        #region  AssociateAssessmentReportEvidenceFolder

        internal virtual AssociateAssessmentReportEvidenceFolderResponse AssociateAssessmentReportEvidenceFolder(AssociateAssessmentReportEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<AssociateAssessmentReportEvidenceFolderResponse>(request, options);
        }



        /// <summary>
        /// Associates an evidence folder to the specified assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual Task<AssociateAssessmentReportEvidenceFolderResponse> AssociateAssessmentReportEvidenceFolderAsync(AssociateAssessmentReportEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAssessmentReportEvidenceFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateAssessmentReportEvidence

        internal virtual BatchAssociateAssessmentReportEvidenceResponse BatchAssociateAssessmentReportEvidence(BatchAssociateAssessmentReportEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateAssessmentReportEvidenceResponse>(request, options);
        }



        /// <summary>
        /// Associates a list of evidence to an assessment report in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        public virtual Task<BatchAssociateAssessmentReportEvidenceResponse> BatchAssociateAssessmentReportEvidenceAsync(BatchAssociateAssessmentReportEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateAssessmentReportEvidenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchCreateDelegationByAssessment

        internal virtual BatchCreateDelegationByAssessmentResponse BatchCreateDelegationByAssessment(BatchCreateDelegationByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateDelegationByAssessmentResponseUnmarshaller.Instance;

            return Invoke<BatchCreateDelegationByAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Create a batch of delegations for a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        public virtual Task<BatchCreateDelegationByAssessmentResponse> BatchCreateDelegationByAssessmentAsync(BatchCreateDelegationByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateDelegationByAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateDelegationByAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteDelegationByAssessment

        internal virtual BatchDeleteDelegationByAssessmentResponse BatchDeleteDelegationByAssessment(BatchDeleteDelegationByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDelegationByAssessmentResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDelegationByAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the delegations in the specified AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        public virtual Task<BatchDeleteDelegationByAssessmentResponse> BatchDeleteDelegationByAssessmentAsync(BatchDeleteDelegationByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDelegationByAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteDelegationByAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateAssessmentReportEvidence

        internal virtual BatchDisassociateAssessmentReportEvidenceResponse BatchDisassociateAssessmentReportEvidence(BatchDisassociateAssessmentReportEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateAssessmentReportEvidenceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a list of evidence from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        public virtual Task<BatchDisassociateAssessmentReportEvidenceResponse> BatchDisassociateAssessmentReportEvidenceAsync(BatchDisassociateAssessmentReportEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateAssessmentReportEvidenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchImportEvidenceToAssessmentControl

        internal virtual BatchImportEvidenceToAssessmentControlResponse BatchImportEvidenceToAssessmentControl(BatchImportEvidenceToAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportEvidenceToAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportEvidenceToAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<BatchImportEvidenceToAssessmentControlResponse>(request, options);
        }



        /// <summary>
        /// Uploads one or more pieces of evidence to the specified control in the assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchImportEvidenceToAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        public virtual Task<BatchImportEvidenceToAssessmentControlResponse> BatchImportEvidenceToAssessmentControlAsync(BatchImportEvidenceToAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportEvidenceToAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportEvidenceToAssessmentControlResponseUnmarshaller.Instance;

            return InvokeAsync<BatchImportEvidenceToAssessmentControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessment

        internal virtual CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Creates an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        public virtual Task<CreateAssessmentResponse> CreateAssessmentAsync(CreateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentFramework

        internal virtual CreateAssessmentFrameworkResponse CreateAssessmentFramework(CreateAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentFrameworkResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        public virtual Task<CreateAssessmentFrameworkResponse> CreateAssessmentFrameworkAsync(CreateAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentFrameworkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAssessmentReport

        internal virtual CreateAssessmentReportResponse CreateAssessmentReport(CreateAssessmentReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentReportResponse>(request, options);
        }



        /// <summary>
        /// Creates an assessment report for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        public virtual Task<CreateAssessmentReportResponse> CreateAssessmentReportAsync(CreateAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssessmentReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateControl

        internal virtual CreateControlResponse CreateControl(CreateControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlResponseUnmarshaller.Instance;

            return Invoke<CreateControlResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        public virtual Task<CreateControlResponse> CreateControlAsync(CreateControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessment

        internal virtual DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        public virtual Task<DeleteAssessmentResponse> DeleteAssessmentAsync(DeleteAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentFramework

        internal virtual DeleteAssessmentFrameworkResponse DeleteAssessmentFramework(DeleteAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentFrameworkResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        public virtual Task<DeleteAssessmentFrameworkResponse> DeleteAssessmentFrameworkAsync(DeleteAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAssessmentReport

        internal virtual DeleteAssessmentReportResponse DeleteAssessmentReport(DeleteAssessmentReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentReportResponse>(request, options);
        }



        /// <summary>
        /// Deletes an assessment report from an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        public virtual Task<DeleteAssessmentReportResponse> DeleteAssessmentReportAsync(DeleteAssessmentReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentReportResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssessmentReportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteControl

        internal virtual DeleteControlResponse DeleteControl(DeleteControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlResponseUnmarshaller.Instance;

            return Invoke<DeleteControlResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        public virtual Task<DeleteControlResponse> DeleteControlAsync(DeleteControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterAccount

        internal virtual DeregisterAccountResponse DeregisterAccount(DeregisterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountResponseUnmarshaller.Instance;

            return Invoke<DeregisterAccountResponse>(request, options);
        }



        /// <summary>
        /// Deregisters an account in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        public virtual Task<DeregisterAccountResponse> DeregisterAccountAsync(DeregisterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterOrganizationAdminAccount

        internal virtual DeregisterOrganizationAdminAccountResponse DeregisterOrganizationAdminAccount(DeregisterOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DeregisterOrganizationAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Deregisters the delegated AWS administrator account from the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        public virtual Task<DeregisterOrganizationAdminAccountResponse> DeregisterOrganizationAdminAccountAsync(DeregisterOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAssessmentReportEvidenceFolder

        internal virtual DisassociateAssessmentReportEvidenceFolderResponse DisassociateAssessmentReportEvidenceFolder(DisassociateAssessmentReportEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<DisassociateAssessmentReportEvidenceFolderResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an evidence folder from the specified assessment report in AWS Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual Task<DisassociateAssessmentReportEvidenceFolderResponse> DisassociateAssessmentReportEvidenceFolderAsync(DisassociateAssessmentReportEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAssessmentReportEvidenceFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountStatus

        internal virtual GetAccountStatusResponse GetAccountStatus(GetAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountStatusResponseUnmarshaller.Instance;

            return Invoke<GetAccountStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the registration status of an account in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        public virtual Task<GetAccountStatusResponse> GetAccountStatusAsync(GetAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssessment

        internal virtual GetAssessmentResponse GetAssessment(GetAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Returns an assessment from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual Task<GetAssessmentResponse> GetAssessmentAsync(GetAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssessmentFramework

        internal virtual GetAssessmentFrameworkResponse GetAssessmentFramework(GetAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentFrameworkResponse>(request, options);
        }



        /// <summary>
        /// Returns a framework from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        public virtual Task<GetAssessmentFrameworkResponse> GetAssessmentFrameworkAsync(GetAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentFrameworkResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAssessmentReportUrl

        internal virtual GetAssessmentReportUrlResponse GetAssessmentReportUrl(GetAssessmentReportUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportUrlResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportUrlResponse>(request, options);
        }



        /// <summary>
        /// Returns the URL of a specified assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssessmentReportUrl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        public virtual Task<GetAssessmentReportUrlResponse> GetAssessmentReportUrlAsync(GetAssessmentReportUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssessmentReportUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChangeLogs

        internal virtual GetChangeLogsResponse GetChangeLogs(GetChangeLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeLogsResponseUnmarshaller.Instance;

            return Invoke<GetChangeLogsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of changelogs from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeLogs service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        public virtual Task<GetChangeLogsResponse> GetChangeLogsAsync(GetChangeLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeLogsResponseUnmarshaller.Instance;

            return InvokeAsync<GetChangeLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetControl

        internal virtual GetControlResponse GetControl(GetControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;

            return Invoke<GetControlResponse>(request, options);
        }



        /// <summary>
        /// Returns a control from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual Task<GetControlResponse> GetControlAsync(GetControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;

            return InvokeAsync<GetControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDelegations

        internal virtual GetDelegationsResponse GetDelegations(GetDelegationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDelegationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegationsResponseUnmarshaller.Instance;

            return Invoke<GetDelegationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of delegations from an audit owner to a delegate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDelegations service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        public virtual Task<GetDelegationsResponse> GetDelegationsAsync(GetDelegationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDelegationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDelegationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvidence

        internal virtual GetEvidenceResponse GetEvidence(GetEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceResponse>(request, options);
        }



        /// <summary>
        /// Returns evidence from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        public virtual Task<GetEvidenceResponse> GetEvidenceAsync(GetEvidenceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvidenceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvidenceByEvidenceFolder

        internal virtual GetEvidenceByEvidenceFolderResponse GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceByEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceByEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceByEvidenceFolderResponse>(request, options);
        }



        /// <summary>
        /// Returns all evidence from a specified evidence folder in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvidenceByEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        public virtual Task<GetEvidenceByEvidenceFolderResponse> GetEvidenceByEvidenceFolderAsync(GetEvidenceByEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceByEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceByEvidenceFolderResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvidenceByEvidenceFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvidenceFolder

        internal virtual GetEvidenceFolderResponse GetEvidenceFolder(GetEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFolderResponse>(request, options);
        }



        /// <summary>
        /// Returns an evidence folder from the specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        public virtual Task<GetEvidenceFolderResponse> GetEvidenceFolderAsync(GetEvidenceFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFolderResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvidenceFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvidenceFoldersByAssessment

        internal virtual GetEvidenceFoldersByAssessmentResponse GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFoldersByAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Returns the evidence folders from a specified assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        public virtual Task<GetEvidenceFoldersByAssessmentResponse> GetEvidenceFoldersByAssessmentAsync(GetEvidenceFoldersByAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvidenceFoldersByAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEvidenceFoldersByAssessmentControl

        internal virtual GetEvidenceFoldersByAssessmentControlResponse GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFoldersByAssessmentControlResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of evidence folders associated with a specified control of an assessment
        /// in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        public virtual Task<GetEvidenceFoldersByAssessmentControlResponse> GetEvidenceFoldersByAssessmentControlAsync(GetEvidenceFoldersByAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentControlResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvidenceFoldersByAssessmentControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOrganizationAdminAccount

        internal virtual GetOrganizationAdminAccountResponse GetOrganizationAdminAccount(GetOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Returns the name of the delegated AWS administrator account for the AWS organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        public virtual Task<GetOrganizationAdminAccountResponse> GetOrganizationAdminAccountAsync(GetOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetOrganizationAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServicesInScope

        internal virtual GetServicesInScopeResponse GetServicesInScope(GetServicesInScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServicesInScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicesInScopeResponseUnmarshaller.Instance;

            return Invoke<GetServicesInScopeResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the in-scope AWS services for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServicesInScope service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        public virtual Task<GetServicesInScopeResponse> GetServicesInScopeAsync(GetServicesInScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServicesInScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicesInScopeResponseUnmarshaller.Instance;

            return InvokeAsync<GetServicesInScopeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSettings

        internal virtual GetSettingsResponse GetSettings(GetSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSettingsResponseUnmarshaller.Instance;

            return Invoke<GetSettingsResponse>(request, options);
        }



        /// <summary>
        /// Returns the settings for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        public virtual Task<GetSettingsResponse> GetSettingsAsync(GetSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentFrameworks

        internal virtual ListAssessmentFrameworksResponse ListAssessmentFrameworks(ListAssessmentFrameworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworksResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentFrameworksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the frameworks available in the AWS Audit Manager framework library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworks service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        public virtual Task<ListAssessmentFrameworksResponse> ListAssessmentFrameworksAsync(ListAssessmentFrameworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentFrameworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessmentReports

        internal virtual ListAssessmentReportsResponse ListAssessmentReports(ListAssessmentReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentReportsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentReportsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of assessment reports created in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessmentReports service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        public virtual Task<ListAssessmentReportsResponse> ListAssessmentReportsAsync(ListAssessmentReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentReportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssessments

        internal virtual ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of current and past assessments from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        public virtual Task<ListAssessmentsResponse> ListAssessmentsAsync(ListAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssessmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListControls

        internal virtual ListControlsResponse ListControls(ListControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;

            return Invoke<ListControlsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of controls from AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual Task<ListControlsResponse> ListControlsAsync(ListControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;

            return InvokeAsync<ListControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeywordsForDataSource

        internal virtual ListKeywordsForDataSourceResponse ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeywordsForDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeywordsForDataSourceResponseUnmarshaller.Instance;

            return Invoke<ListKeywordsForDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of keywords that pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeywordsForDataSource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        public virtual Task<ListKeywordsForDataSourceResponse> ListKeywordsForDataSourceAsync(ListKeywordsForDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeywordsForDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeywordsForDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeywordsForDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotifications

        internal virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all AWS Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotificationsResponse>(request, options, cancellationToken);
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
        /// Returns a list of tags for the specified resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterAccount

        internal virtual RegisterAccountResponse RegisterAccount(RegisterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return Invoke<RegisterAccountResponse>(request, options);
        }



        /// <summary>
        /// Enables AWS Audit Manager for the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterOrganizationAdminAccount

        internal virtual RegisterOrganizationAdminAccountResponse RegisterOrganizationAdminAccount(RegisterOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<RegisterOrganizationAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Enables an AWS account within the organization as the delegated administrator for
        /// AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        public virtual Task<RegisterOrganizationAdminAccountResponse> RegisterOrganizationAdminAccountAsync(RegisterOrganizationAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterOrganizationAdminAccountResponse>(request, options, cancellationToken);
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
        /// Tags the specified resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from a resource in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessment

        internal virtual UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Edits an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        public virtual Task<UpdateAssessmentResponse> UpdateAssessmentAsync(UpdateAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentControl

        internal virtual UpdateAssessmentControlResponse UpdateAssessmentControl(UpdateAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentControlResponse>(request, options);
        }



        /// <summary>
        /// Updates a control within an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        public virtual Task<UpdateAssessmentControlResponse> UpdateAssessmentControlAsync(UpdateAssessmentControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentControlSetStatus

        internal virtual UpdateAssessmentControlSetStatusResponse UpdateAssessmentControlSetStatus(UpdateAssessmentControlSetStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlSetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlSetStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentControlSetStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of a control set in an AWS Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessmentControlSetStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        public virtual Task<UpdateAssessmentControlSetStatusResponse> UpdateAssessmentControlSetStatusAsync(UpdateAssessmentControlSetStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlSetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlSetStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentControlSetStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentFramework

        internal virtual UpdateAssessmentFrameworkResponse UpdateAssessmentFramework(UpdateAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentFrameworkResponse>(request, options);
        }



        /// <summary>
        /// Updates a custom framework in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        public virtual Task<UpdateAssessmentFrameworkResponse> UpdateAssessmentFrameworkAsync(UpdateAssessmentFrameworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentFrameworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAssessmentStatus

        internal virtual UpdateAssessmentStatusResponse UpdateAssessmentStatus(UpdateAssessmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the status of an assessment in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssessmentStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        public virtual Task<UpdateAssessmentStatusResponse> UpdateAssessmentStatusAsync(UpdateAssessmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssessmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateControl

        internal virtual UpdateControlResponse UpdateControl(UpdateControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlResponseUnmarshaller.Instance;

            return Invoke<UpdateControlResponse>(request, options);
        }



        /// <summary>
        /// Updates a custom control in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        public virtual Task<UpdateControlResponse> UpdateControlAsync(UpdateControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSettings

        internal virtual UpdateSettingsResponse UpdateSettings(UpdateSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates AWS Audit Manager settings for the current user account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual Task<UpdateSettingsResponse> UpdateSettingsAsync(UpdateSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateAssessmentReportIntegrity

        internal virtual ValidateAssessmentReportIntegrityResponse ValidateAssessmentReportIntegrity(ValidateAssessmentReportIntegrityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateAssessmentReportIntegrityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAssessmentReportIntegrityResponseUnmarshaller.Instance;

            return Invoke<ValidateAssessmentReportIntegrityResponse>(request, options);
        }



        /// <summary>
        /// Validates the integrity of an assessment report in AWS Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateAssessmentReportIntegrity service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        public virtual Task<ValidateAssessmentReportIntegrityResponse> ValidateAssessmentReportIntegrityAsync(ValidateAssessmentReportIntegrityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateAssessmentReportIntegrityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAssessmentReportIntegrityResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateAssessmentReportIntegrityResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}
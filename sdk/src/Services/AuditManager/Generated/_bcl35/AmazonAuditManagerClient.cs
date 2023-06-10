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
    /// Welcome to the Audit Manager API reference. This guide is for developers who need
    /// detailed information about the Audit Manager API operations, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// Audit Manager is a service that provides automated evidence collection so that you
    /// can continually audit your Amazon Web Services usage. You can use it to assess the
    /// effectiveness of your controls, manage risk, and simplify compliance.
    /// </para>
    ///  
    /// <para>
    /// Audit Manager provides prebuilt frameworks that structure and automate assessments
    /// for a given compliance standard. Frameworks include a prebuilt collection of controls
    /// with descriptions and testing procedures. These controls are grouped according to
    /// the requirements of the specified compliance standard or regulation. You can also
    /// customize frameworks and controls to support internal audits with specific requirements.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started with the Audit Manager API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Audit Manager API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Audit Manager data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're new to Audit Manager, we recommend that you review the <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/what-is.html">
    /// Audit Manager User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAuditManagerClient : AmazonServiceClient, IAmazonAuditManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonAuditManagerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAuditManagerEndpointResolver());
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

        /// <summary>
        /// Associates an evidence folder to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the AssociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual AssociateAssessmentReportEvidenceFolderResponse AssociateAssessmentReportEvidenceFolder(AssociateAssessmentReportEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<AssociateAssessmentReportEvidenceFolderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssessmentReportEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAssessmentReportEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual IAsyncResult BeginAssociateAssessmentReportEvidenceFolder(AssociateAssessmentReportEvidenceFolderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAssessmentReportEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  AssociateAssessmentReportEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/AssociateAssessmentReportEvidenceFolder">REST API Reference for AssociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual AssociateAssessmentReportEvidenceFolderResponse EndAssociateAssessmentReportEvidenceFolder(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAssessmentReportEvidenceFolderResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchAssociateAssessmentReportEvidence

        /// <summary>
        /// Associates a list of evidence to an assessment report in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        public virtual BatchAssociateAssessmentReportEvidenceResponse BatchAssociateAssessmentReportEvidence(BatchAssociateAssessmentReportEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateAssessmentReportEvidenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateAssessmentReportEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateAssessmentReportEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateAssessmentReportEvidence(BatchAssociateAssessmentReportEvidenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateAssessmentReportEvidence.</param>
        /// 
        /// <returns>Returns a  BatchAssociateAssessmentReportEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchAssociateAssessmentReportEvidence">REST API Reference for BatchAssociateAssessmentReportEvidence Operation</seealso>
        public virtual BatchAssociateAssessmentReportEvidenceResponse EndBatchAssociateAssessmentReportEvidence(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateAssessmentReportEvidenceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateDelegationByAssessment

        /// <summary>
        /// Creates a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchCreateDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        public virtual BatchCreateDelegationByAssessmentResponse BatchCreateDelegationByAssessment(BatchCreateDelegationByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateDelegationByAssessmentResponseUnmarshaller.Instance;

            return Invoke<BatchCreateDelegationByAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateDelegationByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateDelegationByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateDelegationByAssessment(BatchCreateDelegationByAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateDelegationByAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateDelegationByAssessment.</param>
        /// 
        /// <returns>Returns a  BatchCreateDelegationByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchCreateDelegationByAssessment">REST API Reference for BatchCreateDelegationByAssessment Operation</seealso>
        public virtual BatchCreateDelegationByAssessmentResponse EndBatchCreateDelegationByAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateDelegationByAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeleteDelegationByAssessment

        /// <summary>
        /// Deletes a batch of delegations for an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDelegationByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        public virtual BatchDeleteDelegationByAssessmentResponse BatchDeleteDelegationByAssessment(BatchDeleteDelegationByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDelegationByAssessmentResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDelegationByAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDelegationByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDelegationByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteDelegationByAssessment(BatchDeleteDelegationByAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteDelegationByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDelegationByAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDelegationByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDelegationByAssessment.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDelegationByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDeleteDelegationByAssessment">REST API Reference for BatchDeleteDelegationByAssessment Operation</seealso>
        public virtual BatchDeleteDelegationByAssessmentResponse EndBatchDeleteDelegationByAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteDelegationByAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateAssessmentReportEvidence

        /// <summary>
        /// Disassociates a list of evidence from an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateAssessmentReportEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        public virtual BatchDisassociateAssessmentReportEvidenceResponse BatchDisassociateAssessmentReportEvidence(BatchDisassociateAssessmentReportEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateAssessmentReportEvidenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateAssessmentReportEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateAssessmentReportEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateAssessmentReportEvidence(BatchDisassociateAssessmentReportEvidenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateAssessmentReportEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateAssessmentReportEvidenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateAssessmentReportEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateAssessmentReportEvidence.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateAssessmentReportEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchDisassociateAssessmentReportEvidence">REST API Reference for BatchDisassociateAssessmentReportEvidence Operation</seealso>
        public virtual BatchDisassociateAssessmentReportEvidenceResponse EndBatchDisassociateAssessmentReportEvidence(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateAssessmentReportEvidenceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchImportEvidenceToAssessmentControl

        /// <summary>
        /// Uploads one or more pieces of evidence to a control in an Audit Manager assessment.
        /// You can upload manual evidence from any Amazon Simple Storage Service (Amazon S3)
        /// bucket by specifying the S3 URI of the evidence. 
        /// 
        ///  
        /// <para>
        /// You must upload manual evidence to your S3 bucket before you can upload it to your
        /// assessment. For instructions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// in the <i>Amazon Simple Storage Service API Reference.</i> 
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to this action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum size of an individual evidence file: 100 MB
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number of daily manual evidence uploads per control: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Supported file formats: See <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/upload-evidence.html#supported-manual-evidence-files">Supported
        /// file types for manual evidence</a> in the <i>Audit Manager User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Audit Manager service restrictions, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the BatchImportEvidenceToAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        public virtual BatchImportEvidenceToAssessmentControlResponse BatchImportEvidenceToAssessmentControl(BatchImportEvidenceToAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportEvidenceToAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportEvidenceToAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<BatchImportEvidenceToAssessmentControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchImportEvidenceToAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchImportEvidenceToAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchImportEvidenceToAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        public virtual IAsyncResult BeginBatchImportEvidenceToAssessmentControl(BatchImportEvidenceToAssessmentControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchImportEvidenceToAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchImportEvidenceToAssessmentControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchImportEvidenceToAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchImportEvidenceToAssessmentControl.</param>
        /// 
        /// <returns>Returns a  BatchImportEvidenceToAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/BatchImportEvidenceToAssessmentControl">REST API Reference for BatchImportEvidenceToAssessmentControl Operation</seealso>
        public virtual BatchImportEvidenceToAssessmentControlResponse EndBatchImportEvidenceToAssessmentControl(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchImportEvidenceToAssessmentControlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessment

        /// <summary>
        /// Creates an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment service method.</param>
        /// 
        /// <returns>The response from the CreateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        public virtual CreateAssessmentResponse CreateAssessment(CreateAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        public virtual IAsyncResult BeginCreateAssessment(CreateAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessment.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessment">REST API Reference for CreateAssessment Operation</seealso>
        public virtual CreateAssessmentResponse EndCreateAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessmentFramework

        /// <summary>
        /// Creates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        public virtual CreateAssessmentFrameworkResponse CreateAssessmentFramework(CreateAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        public virtual IAsyncResult BeginCreateAssessmentFramework(CreateAssessmentFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentFramework">REST API Reference for CreateAssessmentFramework Operation</seealso>
        public virtual CreateAssessmentFrameworkResponse EndCreateAssessmentFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentFrameworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssessmentReport

        /// <summary>
        /// Creates an assessment report for the specified assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the CreateAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        public virtual CreateAssessmentReportResponse CreateAssessmentReport(CreateAssessmentReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<CreateAssessmentReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssessmentReport operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssessmentReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        public virtual IAsyncResult BeginCreateAssessmentReport(CreateAssessmentReportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssessmentReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssessmentReport.</param>
        /// 
        /// <returns>Returns a  CreateAssessmentReportResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateAssessmentReport">REST API Reference for CreateAssessmentReport Operation</seealso>
        public virtual CreateAssessmentReportResponse EndCreateAssessmentReport(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssessmentReportResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateControl

        /// <summary>
        /// Creates a new custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControl service method.</param>
        /// 
        /// <returns>The response from the CreateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        public virtual CreateControlResponse CreateControl(CreateControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlResponseUnmarshaller.Instance;

            return Invoke<CreateControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        public virtual IAsyncResult BeginCreateControl(CreateControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateControl.</param>
        /// 
        /// <returns>Returns a  CreateControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/CreateControl">REST API Reference for CreateControl Operation</seealso>
        public virtual CreateControlResponse EndCreateControl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateControlResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssessment

        /// <summary>
        /// Deletes an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        public virtual DeleteAssessmentResponse DeleteAssessment(DeleteAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessment(DeleteAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessment">REST API Reference for DeleteAssessment Operation</seealso>
        public virtual DeleteAssessmentResponse EndDeleteAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssessmentFramework

        /// <summary>
        /// Deletes a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        public virtual DeleteAssessmentFrameworkResponse DeleteAssessmentFramework(DeleteAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentFramework(DeleteAssessmentFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFramework">REST API Reference for DeleteAssessmentFramework Operation</seealso>
        public virtual DeleteAssessmentFrameworkResponse EndDeleteAssessmentFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentFrameworkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssessmentFrameworkShare

        /// <summary>
        /// Deletes a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        public virtual DeleteAssessmentFrameworkShareResponse DeleteAssessmentFrameworkShare(DeleteAssessmentFrameworkShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentFrameworkShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentFrameworkShare(DeleteAssessmentFrameworkShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentFrameworkShare">REST API Reference for DeleteAssessmentFrameworkShare Operation</seealso>
        public virtual DeleteAssessmentFrameworkShareResponse EndDeleteAssessmentFrameworkShare(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentFrameworkShareResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssessmentReport

        /// <summary>
        /// Deletes an assessment report in Audit Manager. 
        /// 
        ///  
        /// <para>
        /// When you run the <code>DeleteAssessmentReport</code> operation, Audit Manager attempts
        /// to delete the following data:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// The specified assessment report that’s stored in your S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The associated metadata that’s stored in Audit Manager
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If Audit Manager can’t access the assessment report in your S3 bucket, the report
        /// isn’t deleted. In this event, the <code>DeleteAssessmentReport</code> operation doesn’t
        /// fail. Instead, it proceeds to delete the associated metadata only. You must then delete
        /// the assessment report from the S3 bucket yourself. 
        /// </para>
        ///  
        /// <para>
        /// This scenario happens when Audit Manager receives a <code>403 (Forbidden)</code> or
        /// <code>404 (Not Found)</code> error from Amazon S3. To avoid this, make sure that your
        /// S3 bucket is available, and that you configured the correct permissions for Audit
        /// Manager to delete resources in your S3 bucket. For an example permissions policy that
        /// you can use, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/security_iam_id-based-policy-examples.html#full-administrator-access-assessment-report-destination">Assessment
        /// report destination permissions</a> in the <i>Audit Manager User Guide</i>. For information
        /// about the issues that could cause a <code>403 (Forbidden)</code> or <code>404 (Not
        /// Found</code>) error from Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
        /// of Error Codes</a> in the <i>Amazon Simple Storage Service API Reference</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport service method.</param>
        /// 
        /// <returns>The response from the DeleteAssessmentReport service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        public virtual DeleteAssessmentReportResponse DeleteAssessmentReport(DeleteAssessmentReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentReportResponseUnmarshaller.Instance;

            return Invoke<DeleteAssessmentReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssessmentReport operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssessmentReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssessmentReport(DeleteAssessmentReportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAssessmentReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssessmentReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssessmentReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssessmentReport.</param>
        /// 
        /// <returns>Returns a  DeleteAssessmentReportResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteAssessmentReport">REST API Reference for DeleteAssessmentReport Operation</seealso>
        public virtual DeleteAssessmentReportResponse EndDeleteAssessmentReport(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssessmentReportResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteControl

        /// <summary>
        /// Deletes a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl service method.</param>
        /// 
        /// <returns>The response from the DeleteControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        public virtual DeleteControlResponse DeleteControl(DeleteControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlResponseUnmarshaller.Instance;

            return Invoke<DeleteControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        public virtual IAsyncResult BeginDeleteControl(DeleteControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteControl.</param>
        /// 
        /// <returns>Returns a  DeleteControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeleteControl">REST API Reference for DeleteControl Operation</seealso>
        public virtual DeleteControlResponse EndDeleteControl(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteControlResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterAccount

        /// <summary>
        /// Deregisters an account in Audit Manager. 
        /// 
        ///  <note> 
        /// <para>
        /// Before you deregister, you can use the <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_UpdateSettings.html">UpdateSettings</a>
        /// API operation to set your preferred data retention policy. By default, Audit Manager
        /// retains your data. If you want to delete your data, you can use the <code>DeregistrationPolicy</code>
        /// attribute to request the deletion of your data. 
        /// </para>
        ///  
        /// <para>
        /// For more information about data retention, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/data-protection.html">Data
        /// Protection</a> in the <i>Audit Manager User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        public virtual DeregisterAccountResponse DeregisterAccount(DeregisterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountResponseUnmarshaller.Instance;

            return Invoke<DeregisterAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        public virtual IAsyncResult BeginDeregisterAccount(DeregisterAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterAccount.</param>
        /// 
        /// <returns>Returns a  DeregisterAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterAccount">REST API Reference for DeregisterAccount Operation</seealso>
        public virtual DeregisterAccountResponse EndDeregisterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterOrganizationAdminAccount

        /// <summary>
        /// Removes the specified Amazon Web Services account as a delegated administrator for
        /// Audit Manager. 
        /// 
        ///  
        /// <para>
        /// When you remove a delegated administrator from your Audit Manager settings, you continue
        /// to have access to the evidence that you previously collected under that account. This
        /// is also the case when you deregister a delegated administrator from Organizations.
        /// However, Audit Manager stops collecting and attaching evidence to that delegated administrator
        /// account moving forward.
        /// </para>
        ///  <important> 
        /// <para>
        /// Keep in mind the following cleanup task if you use evidence finder:
        /// </para>
        ///  
        /// <para>
        /// Before you use your management account to remove a delegated administrator, make sure
        /// that the current delegated administrator account signs in to Audit Manager and disables
        /// evidence finder first. Disabling evidence finder automatically deletes the event data
        /// store that was created in their account when they enabled evidence finder. If this
        /// task isn’t completed, the event data store remains in their account. In this case,
        /// we recommend that the original delegated administrator goes to CloudTrail Lake and
        /// manually <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-eds-disable-termination.html">deletes
        /// the event data store</a>.
        /// </para>
        ///  
        /// <para>
        /// This cleanup task is necessary to ensure that you don't end up with multiple event
        /// data stores. Audit Manager ignores an unused event data store after you remove or
        /// change a delegated administrator account. However, the unused event data store continues
        /// to incur storage costs from CloudTrail Lake if you don't delete it.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you deregister a delegated administrator account for Audit Manager, the data
        /// for that account isn’t deleted. If you want to delete resource data for a delegated
        /// administrator account, you must perform that task separately before you deregister
        /// the account. Either, you can do this in the Audit Manager console. Or, you can use
        /// one of the delete API operations that are provided by Audit Manager. 
        /// </para>
        ///  
        /// <para>
        /// To delete your Audit Manager resource data, see the following instructions: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessment.html">DeleteAssessment</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-assessment.html">Deleting
        /// an assessment</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFramework.html">DeleteAssessmentFramework</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-custom-framework.html">Deleting
        /// a custom framework</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentFrameworkShare.html">DeleteAssessmentFrameworkShare</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/deleting-shared-framework-requests.html">Deleting
        /// a share request</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteAssessmentReport.html">DeleteAssessmentReport</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/generate-assessment-report.html#delete-assessment-report-steps">Deleting
        /// an assessment report</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeleteControl.html">DeleteControl</a>
        /// (see also: <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/delete-controls.html">Deleting
        /// a custom control</a> in the <i>Audit Manager User Guide</i>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At this time, Audit Manager doesn't provide an option to delete evidence for a specific
        /// delegated administrator. Instead, when your management account deregisters Audit Manager,
        /// we perform a cleanup for the current delegated administrator account at the time of
        /// deregistration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DeregisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        public virtual DeregisterOrganizationAdminAccountResponse DeregisterOrganizationAdminAccount(DeregisterOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DeregisterOrganizationAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginDeregisterOrganizationAdminAccount(DeregisterOrganizationAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  DeregisterOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DeregisterOrganizationAdminAccount">REST API Reference for DeregisterOrganizationAdminAccount Operation</seealso>
        public virtual DeregisterOrganizationAdminAccountResponse EndDeregisterOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterOrganizationAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAssessmentReportEvidenceFolder

        /// <summary>
        /// Disassociates an evidence folder from the specified assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the DisassociateAssessmentReportEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual DisassociateAssessmentReportEvidenceFolderResponse DisassociateAssessmentReportEvidenceFolder(DisassociateAssessmentReportEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<DisassociateAssessmentReportEvidenceFolderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssessmentReportEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAssessmentReportEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAssessmentReportEvidenceFolder(DisassociateAssessmentReportEvidenceFolderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAssessmentReportEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssessmentReportEvidenceFolderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAssessmentReportEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAssessmentReportEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  DisassociateAssessmentReportEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/DisassociateAssessmentReportEvidenceFolder">REST API Reference for DisassociateAssessmentReportEvidenceFolder Operation</seealso>
        public virtual DisassociateAssessmentReportEvidenceFolderResponse EndDisassociateAssessmentReportEvidenceFolder(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAssessmentReportEvidenceFolderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountStatus

        /// <summary>
        /// Returns the registration status of an account in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus service method.</param>
        /// 
        /// <returns>The response from the GetAccountStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        public virtual GetAccountStatusResponse GetAccountStatus(GetAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountStatusResponseUnmarshaller.Instance;

            return Invoke<GetAccountStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        public virtual IAsyncResult BeginGetAccountStatus(GetAccountStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountStatus.</param>
        /// 
        /// <returns>Returns a  GetAccountStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAccountStatus">REST API Reference for GetAccountStatus Operation</seealso>
        public virtual GetAccountStatusResponse EndGetAccountStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssessment

        /// <summary>
        /// Returns an assessment from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment service method.</param>
        /// 
        /// <returns>The response from the GetAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual GetAssessmentResponse GetAssessment(GetAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual IAsyncResult BeginGetAssessment(GetAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessment.</param>
        /// 
        /// <returns>Returns a  GetAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessment">REST API Reference for GetAssessment Operation</seealso>
        public virtual GetAssessmentResponse EndGetAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssessmentFramework

        /// <summary>
        /// Returns a framework from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        public virtual GetAssessmentFrameworkResponse GetAssessmentFramework(GetAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        public virtual IAsyncResult BeginGetAssessmentFramework(GetAssessmentFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  GetAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentFramework">REST API Reference for GetAssessmentFramework Operation</seealso>
        public virtual GetAssessmentFrameworkResponse EndGetAssessmentFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentFrameworkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssessmentReportUrl

        /// <summary>
        /// Returns the URL of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl service method.</param>
        /// 
        /// <returns>The response from the GetAssessmentReportUrl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        public virtual GetAssessmentReportUrlResponse GetAssessmentReportUrl(GetAssessmentReportUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportUrlResponseUnmarshaller.Instance;

            return Invoke<GetAssessmentReportUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssessmentReportUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssessmentReportUrl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssessmentReportUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        public virtual IAsyncResult BeginGetAssessmentReportUrl(GetAssessmentReportUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAssessmentReportUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssessmentReportUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssessmentReportUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssessmentReportUrl.</param>
        /// 
        /// <returns>Returns a  GetAssessmentReportUrlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetAssessmentReportUrl">REST API Reference for GetAssessmentReportUrl Operation</seealso>
        public virtual GetAssessmentReportUrlResponse EndGetAssessmentReportUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssessmentReportUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChangeLogs

        /// <summary>
        /// Returns a list of changelogs from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs service method.</param>
        /// 
        /// <returns>The response from the GetChangeLogs service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        public virtual GetChangeLogsResponse GetChangeLogs(GetChangeLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeLogsResponseUnmarshaller.Instance;

            return Invoke<GetChangeLogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChangeLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChangeLogs operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChangeLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        public virtual IAsyncResult BeginGetChangeLogs(GetChangeLogsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChangeLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChangeLogsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChangeLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChangeLogs.</param>
        /// 
        /// <returns>Returns a  GetChangeLogsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetChangeLogs">REST API Reference for GetChangeLogs Operation</seealso>
        public virtual GetChangeLogsResponse EndGetChangeLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChangeLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetControl

        /// <summary>
        /// Returns a control from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControl service method.</param>
        /// 
        /// <returns>The response from the GetControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual GetControlResponse GetControl(GetControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;

            return Invoke<GetControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual IAsyncResult BeginGetControl(GetControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetControl.</param>
        /// 
        /// <returns>Returns a  GetControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetControl">REST API Reference for GetControl Operation</seealso>
        public virtual GetControlResponse EndGetControl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetControlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDelegations

        /// <summary>
        /// Returns a list of delegations from an audit owner to a delegate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations service method.</param>
        /// 
        /// <returns>The response from the GetDelegations service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        public virtual GetDelegationsResponse GetDelegations(GetDelegationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDelegationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegationsResponseUnmarshaller.Instance;

            return Invoke<GetDelegationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDelegations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDelegations operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDelegations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        public virtual IAsyncResult BeginGetDelegations(GetDelegationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDelegationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDelegationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDelegations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDelegations.</param>
        /// 
        /// <returns>Returns a  GetDelegationsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetDelegations">REST API Reference for GetDelegations Operation</seealso>
        public virtual GetDelegationsResponse EndGetDelegations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDelegationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvidence

        /// <summary>
        /// Returns evidence from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence service method.</param>
        /// 
        /// <returns>The response from the GetEvidence service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        public virtual GetEvidenceResponse GetEvidence(GetEvidenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidence operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        public virtual IAsyncResult BeginGetEvidence(GetEvidenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidence.</param>
        /// 
        /// <returns>Returns a  GetEvidenceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidence">REST API Reference for GetEvidence Operation</seealso>
        public virtual GetEvidenceResponse EndGetEvidence(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvidenceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvidenceByEvidenceFolder

        /// <summary>
        /// Returns all evidence from a specified evidence folder in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceByEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        public virtual GetEvidenceByEvidenceFolderResponse GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceByEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceByEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceByEvidenceFolderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceByEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceByEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceByEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        public virtual IAsyncResult BeginGetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceByEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceByEvidenceFolderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceByEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceByEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  GetEvidenceByEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceByEvidenceFolder">REST API Reference for GetEvidenceByEvidenceFolder Operation</seealso>
        public virtual GetEvidenceByEvidenceFolderResponse EndGetEvidenceByEvidenceFolder(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvidenceByEvidenceFolderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvidenceFolder

        /// <summary>
        /// Returns an evidence folder from the specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFolder service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        public virtual GetEvidenceFolderResponse GetEvidenceFolder(GetEvidenceFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFolderResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFolderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFolder operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        public virtual IAsyncResult BeginGetEvidenceFolder(GetEvidenceFolderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFolderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFolder.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFolderResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFolder">REST API Reference for GetEvidenceFolder Operation</seealso>
        public virtual GetEvidenceFolderResponse EndGetEvidenceFolder(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvidenceFolderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvidenceFoldersByAssessment

        /// <summary>
        /// Returns the evidence folders from a specified assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        public virtual GetEvidenceFoldersByAssessmentResponse GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFoldersByAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFoldersByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFoldersByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        public virtual IAsyncResult BeginGetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFoldersByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFoldersByAssessment.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFoldersByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessment">REST API Reference for GetEvidenceFoldersByAssessment Operation</seealso>
        public virtual GetEvidenceFoldersByAssessmentResponse EndGetEvidenceFoldersByAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvidenceFoldersByAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvidenceFoldersByAssessmentControl

        /// <summary>
        /// Returns a list of evidence folders that are associated with a specified control in
        /// an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the GetEvidenceFoldersByAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        public virtual GetEvidenceFoldersByAssessmentControlResponse GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<GetEvidenceFoldersByAssessmentControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvidenceFoldersByAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvidenceFoldersByAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvidenceFoldersByAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        public virtual IAsyncResult BeginGetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEvidenceFoldersByAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvidenceFoldersByAssessmentControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvidenceFoldersByAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvidenceFoldersByAssessmentControl.</param>
        /// 
        /// <returns>Returns a  GetEvidenceFoldersByAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetEvidenceFoldersByAssessmentControl">REST API Reference for GetEvidenceFoldersByAssessmentControl Operation</seealso>
        public virtual GetEvidenceFoldersByAssessmentControlResponse EndGetEvidenceFoldersByAssessmentControl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvidenceFoldersByAssessmentControlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsights

        /// <summary>
        /// Gets the latest analytics data for all your current active assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual GetInsightsResponse GetInsights(GetInsightsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return Invoke<GetInsightsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsights operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual IAsyncResult BeginGetInsights(GetInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsights.</param>
        /// 
        /// <returns>Returns a  GetInsightsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsights">REST API Reference for GetInsights Operation</seealso>
        public virtual GetInsightsResponse EndGetInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsightsByAssessment

        /// <summary>
        /// Gets the latest analytics data for a specific active assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightsByAssessment service method.</param>
        /// 
        /// <returns>The response from the GetInsightsByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        public virtual GetInsightsByAssessmentResponse GetInsightsByAssessment(GetInsightsByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsByAssessmentResponseUnmarshaller.Instance;

            return Invoke<GetInsightsByAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightsByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightsByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        public virtual IAsyncResult BeginGetInsightsByAssessment(GetInsightsByAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightsByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightsByAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightsByAssessment.</param>
        /// 
        /// <returns>Returns a  GetInsightsByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetInsightsByAssessment">REST API Reference for GetInsightsByAssessment Operation</seealso>
        public virtual GetInsightsByAssessmentResponse EndGetInsightsByAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightsByAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOrganizationAdminAccount

        /// <summary>
        /// Returns the name of the delegated Amazon Web Services administrator account for the
        /// organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        public virtual GetOrganizationAdminAccountResponse GetOrganizationAdminAccount(GetOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginGetOrganizationAdminAccount(GetOrganizationAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  GetOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetOrganizationAdminAccount">REST API Reference for GetOrganizationAdminAccount Operation</seealso>
        public virtual GetOrganizationAdminAccountResponse EndGetOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOrganizationAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServicesInScope

        /// <summary>
        /// Returns a list of all of the Amazon Web Services that you can choose to include in
        /// your assessment. When you <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_CreateAssessment.html">create
        /// an assessment</a>, specify which of these services you want to include to narrow the
        /// assessment's <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_Scope.html">scope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope service method.</param>
        /// 
        /// <returns>The response from the GetServicesInScope service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        public virtual GetServicesInScopeResponse GetServicesInScope(GetServicesInScopeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServicesInScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicesInScopeResponseUnmarshaller.Instance;

            return Invoke<GetServicesInScopeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServicesInScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServicesInScope operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServicesInScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        public virtual IAsyncResult BeginGetServicesInScope(GetServicesInScopeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServicesInScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServicesInScopeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServicesInScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServicesInScope.</param>
        /// 
        /// <returns>Returns a  GetServicesInScopeResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetServicesInScope">REST API Reference for GetServicesInScope Operation</seealso>
        public virtual GetServicesInScopeResponse EndGetServicesInScope(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServicesInScopeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSettings

        /// <summary>
        /// Returns the settings for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSettings service method.</param>
        /// 
        /// <returns>The response from the GetSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        public virtual GetSettingsResponse GetSettings(GetSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSettingsResponseUnmarshaller.Instance;

            return Invoke<GetSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSettings operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        public virtual IAsyncResult BeginGetSettings(GetSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSettings.</param>
        /// 
        /// <returns>Returns a  GetSettingsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/GetSettings">REST API Reference for GetSettings Operation</seealso>
        public virtual GetSettingsResponse EndGetSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentControlInsightsByControlDomain

        /// <summary>
        /// Lists the latest analytics data for controls within a specific control domain and
        /// a specific active assessment.
        /// 
        ///  <note> 
        /// <para>
        /// Control insights are listed only if the control belongs to the control domain and
        /// assessment that was specified. Moreover, the control must have collected evidence
        /// on the <code>lastUpdated</code> date of <code>controlInsightsByAssessment</code>.
        /// If neither of these conditions are met, no data is listed for that control. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentControlInsightsByControlDomain service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentControlInsightsByControlDomain service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        public virtual ListAssessmentControlInsightsByControlDomainResponse ListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentControlInsightsByControlDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentControlInsightsByControlDomainResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentControlInsightsByControlDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentControlInsightsByControlDomain operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentControlInsightsByControlDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentControlInsightsByControlDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentControlInsightsByControlDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentControlInsightsByControlDomain.</param>
        /// 
        /// <returns>Returns a  ListAssessmentControlInsightsByControlDomainResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentControlInsightsByControlDomain">REST API Reference for ListAssessmentControlInsightsByControlDomain Operation</seealso>
        public virtual ListAssessmentControlInsightsByControlDomainResponse EndListAssessmentControlInsightsByControlDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentControlInsightsByControlDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentFrameworks

        /// <summary>
        /// Returns a list of the frameworks that are available in the Audit Manager framework
        /// library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworks service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        public virtual ListAssessmentFrameworksResponse ListAssessmentFrameworks(ListAssessmentFrameworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworksResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentFrameworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentFrameworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworks operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentFrameworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentFrameworks(ListAssessmentFrameworksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentFrameworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentFrameworks.</param>
        /// 
        /// <returns>Returns a  ListAssessmentFrameworksResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworks">REST API Reference for ListAssessmentFrameworks Operation</seealso>
        public virtual ListAssessmentFrameworksResponse EndListAssessmentFrameworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentFrameworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentFrameworkShareRequests

        /// <summary>
        /// Returns a list of sent or received share requests for custom frameworks in Audit
        /// Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworkShareRequests service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentFrameworkShareRequests service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        public virtual ListAssessmentFrameworkShareRequestsResponse ListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworkShareRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworkShareRequestsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentFrameworkShareRequestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentFrameworkShareRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentFrameworkShareRequests operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentFrameworkShareRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentFrameworkShareRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentFrameworkShareRequestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentFrameworkShareRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentFrameworkShareRequests.</param>
        /// 
        /// <returns>Returns a  ListAssessmentFrameworkShareRequestsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentFrameworkShareRequests">REST API Reference for ListAssessmentFrameworkShareRequests Operation</seealso>
        public virtual ListAssessmentFrameworkShareRequestsResponse EndListAssessmentFrameworkShareRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentFrameworkShareRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessmentReports

        /// <summary>
        /// Returns a list of assessment reports created in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports service method.</param>
        /// 
        /// <returns>The response from the ListAssessmentReports service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        public virtual ListAssessmentReportsResponse ListAssessmentReports(ListAssessmentReportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentReportsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessmentReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessmentReports operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessmentReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        public virtual IAsyncResult BeginListAssessmentReports(ListAssessmentReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessmentReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessmentReports.</param>
        /// 
        /// <returns>Returns a  ListAssessmentReportsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessmentReports">REST API Reference for ListAssessmentReports Operation</seealso>
        public virtual ListAssessmentReportsResponse EndListAssessmentReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentReportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssessments

        /// <summary>
        /// Returns a list of current and past assessments from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAssessments service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        public virtual ListAssessmentsResponse ListAssessments(ListAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAssessmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssessments operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        public virtual IAsyncResult BeginListAssessments(ListAssessmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssessmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssessments.</param>
        /// 
        /// <returns>Returns a  ListAssessmentsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListAssessments">REST API Reference for ListAssessments Operation</seealso>
        public virtual ListAssessmentsResponse EndListAssessments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssessmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListControlDomainInsights

        /// <summary>
        /// Lists the latest analytics data for control domains across all of your active assessments.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// A control domain is listed only if at least one of the controls within that domain
        /// collected evidence on the <code>lastUpdated</code> date of <code>controlDomainInsights</code>.
        /// If this condition isn’t met, no data is listed for that control domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsights service method.</param>
        /// 
        /// <returns>The response from the ListControlDomainInsights service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        public virtual ListControlDomainInsightsResponse ListControlDomainInsights(ListControlDomainInsightsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlDomainInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlDomainInsightsResponseUnmarshaller.Instance;

            return Invoke<ListControlDomainInsightsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlDomainInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsights operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlDomainInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        public virtual IAsyncResult BeginListControlDomainInsights(ListControlDomainInsightsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlDomainInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlDomainInsightsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlDomainInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlDomainInsights.</param>
        /// 
        /// <returns>Returns a  ListControlDomainInsightsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsights">REST API Reference for ListControlDomainInsights Operation</seealso>
        public virtual ListControlDomainInsightsResponse EndListControlDomainInsights(IAsyncResult asyncResult)
        {
            return EndInvoke<ListControlDomainInsightsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListControlDomainInsightsByAssessment

        /// <summary>
        /// Lists analytics data for control domains within a specified active assessment.
        /// 
        ///  <note> 
        /// <para>
        /// A control domain is listed only if at least one of the controls within that domain
        /// collected evidence on the <code>lastUpdated</code> date of <code>controlDomainInsights</code>.
        /// If this condition isn’t met, no data is listed for that domain.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsightsByAssessment service method.</param>
        /// 
        /// <returns>The response from the ListControlDomainInsightsByAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        public virtual ListControlDomainInsightsByAssessmentResponse ListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlDomainInsightsByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlDomainInsightsByAssessmentResponseUnmarshaller.Instance;

            return Invoke<ListControlDomainInsightsByAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlDomainInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlDomainInsightsByAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlDomainInsightsByAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        public virtual IAsyncResult BeginListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlDomainInsightsByAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlDomainInsightsByAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlDomainInsightsByAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlDomainInsightsByAssessment.</param>
        /// 
        /// <returns>Returns a  ListControlDomainInsightsByAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlDomainInsightsByAssessment">REST API Reference for ListControlDomainInsightsByAssessment Operation</seealso>
        public virtual ListControlDomainInsightsByAssessmentResponse EndListControlDomainInsightsByAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<ListControlDomainInsightsByAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListControlInsightsByControlDomain

        /// <summary>
        /// Lists the latest analytics data for controls within a specific control domain across
        /// all active assessments.
        /// 
        ///  <note> 
        /// <para>
        /// Control insights are listed only if the control belongs to the control domain that
        /// was specified and the control collected evidence on the <code>lastUpdated</code> date
        /// of <code>controlInsightsMetadata</code>. If neither of these conditions are met, no
        /// data is listed for that control. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlInsightsByControlDomain service method.</param>
        /// 
        /// <returns>The response from the ListControlInsightsByControlDomain service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        public virtual ListControlInsightsByControlDomainResponse ListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlInsightsByControlDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlInsightsByControlDomainResponseUnmarshaller.Instance;

            return Invoke<ListControlInsightsByControlDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlInsightsByControlDomain operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlInsightsByControlDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        public virtual IAsyncResult BeginListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlInsightsByControlDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlInsightsByControlDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlInsightsByControlDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlInsightsByControlDomain.</param>
        /// 
        /// <returns>Returns a  ListControlInsightsByControlDomainResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControlInsightsByControlDomain">REST API Reference for ListControlInsightsByControlDomain Operation</seealso>
        public virtual ListControlInsightsByControlDomainResponse EndListControlInsightsByControlDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<ListControlInsightsByControlDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  ListControls

        /// <summary>
        /// Returns a list of controls from Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControls service method.</param>
        /// 
        /// <returns>The response from the ListControls service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual ListControlsResponse ListControls(ListControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;

            return Invoke<ListControlsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControls operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual IAsyncResult BeginListControls(ListControlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControls.</param>
        /// 
        /// <returns>Returns a  ListControlsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListControls">REST API Reference for ListControls Operation</seealso>
        public virtual ListControlsResponse EndListControls(IAsyncResult asyncResult)
        {
            return EndInvoke<ListControlsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKeywordsForDataSource

        /// <summary>
        /// Returns a list of keywords that are pre-mapped to the specified control data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource service method.</param>
        /// 
        /// <returns>The response from the ListKeywordsForDataSource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        public virtual ListKeywordsForDataSourceResponse ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeywordsForDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeywordsForDataSourceResponseUnmarshaller.Instance;

            return Invoke<ListKeywordsForDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeywordsForDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeywordsForDataSource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeywordsForDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        public virtual IAsyncResult BeginListKeywordsForDataSource(ListKeywordsForDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeywordsForDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeywordsForDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeywordsForDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeywordsForDataSource.</param>
        /// 
        /// <returns>Returns a  ListKeywordsForDataSourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListKeywordsForDataSource">REST API Reference for ListKeywordsForDataSource Operation</seealso>
        public virtual ListKeywordsForDataSourceResponse EndListKeywordsForDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKeywordsForDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotifications

        /// <summary>
        /// Returns a list of all Audit Manager notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual IAsyncResult BeginListNotifications(ListNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotifications.</param>
        /// 
        /// <returns>Returns a  ListNotificationsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse EndListNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of tags for the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterAccount

        /// <summary>
        /// Enables Audit Manager for the specified Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual RegisterAccountResponse RegisterAccount(RegisterAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return Invoke<RegisterAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual IAsyncResult BeginRegisterAccount(RegisterAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccount.</param>
        /// 
        /// <returns>Returns a  RegisterAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        public virtual RegisterAccountResponse EndRegisterAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterOrganizationAdminAccount

        /// <summary>
        /// Enables an Amazon Web Services account within the organization as the delegated administrator
        /// for Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterOrganizationAdminAccount service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        public virtual RegisterOrganizationAdminAccountResponse RegisterOrganizationAdminAccount(RegisterOrganizationAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return Invoke<RegisterOrganizationAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterOrganizationAdminAccount operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterOrganizationAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginRegisterOrganizationAdminAccount(RegisterOrganizationAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterOrganizationAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterOrganizationAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterOrganizationAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterOrganizationAdminAccount.</param>
        /// 
        /// <returns>Returns a  RegisterOrganizationAdminAccountResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/RegisterOrganizationAdminAccount">REST API Reference for RegisterOrganizationAdminAccount Operation</seealso>
        public virtual RegisterOrganizationAdminAccountResponse EndRegisterOrganizationAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterOrganizationAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAssessmentFrameworkShare

        /// <summary>
        /// Creates a share request for a custom framework in Audit Manager. 
        /// 
        ///  
        /// <para>
        /// The share request specifies a recipient and notifies them that a custom framework
        /// is available. Recipients have 120 days to accept or decline the request. If no action
        /// is taken, the share request expires.
        /// </para>
        ///  
        /// <para>
        /// When you create a share request, Audit Manager stores a snapshot of your custom framework
        /// in the US East (N. Virginia) Amazon Web Services Region. Audit Manager also stores
        /// a backup of the same snapshot in the US West (Oregon) Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Audit Manager deletes the snapshot and the backup snapshot when one of the following
        /// events occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The sender revokes the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The recipient declines the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The recipient encounters an error and doesn't successfully accept the share request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The share request expires before the recipient responds to the request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When a sender <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/framework-sharing.html#framework-sharing-resend">resends
        /// a share request</a>, the snapshot is replaced with an updated version that corresponds
        /// with the latest version of the custom framework. 
        /// </para>
        ///  
        /// <para>
        /// When a recipient accepts a share request, the snapshot is replicated into their Amazon
        /// Web Services account under the Amazon Web Services Region that was specified in the
        /// share request. 
        /// </para>
        ///  <important> 
        /// <para>
        /// When you invoke the <code>StartAssessmentFrameworkShare</code> API, you are about
        /// to share a custom framework with another Amazon Web Services account. You may not
        /// share a custom framework that is derived from a standard framework if the standard
        /// framework is designated as not eligible for sharing by Amazon Web Services, unless
        /// you have obtained permission to do so from the owner of the standard framework. To
        /// learn more about which standard frameworks are eligible for sharing, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/share-custom-framework-concepts-and-terminology.html#eligibility">Framework
        /// sharing eligibility</a> in the <i>Audit Manager User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the StartAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        public virtual StartAssessmentFrameworkShareResponse StartAssessmentFrameworkShare(StartAssessmentFrameworkShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return Invoke<StartAssessmentFrameworkShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        public virtual IAsyncResult BeginStartAssessmentFrameworkShare(StartAssessmentFrameworkShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  StartAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/StartAssessmentFrameworkShare">REST API Reference for StartAssessmentFrameworkShare Operation</seealso>
        public virtual StartAssessmentFrameworkShareResponse EndStartAssessmentFrameworkShare(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAssessmentFrameworkShareResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags the specified resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessment

        /// <summary>
        /// Edits an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessment service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        public virtual UpdateAssessmentResponse UpdateAssessment(UpdateAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessment operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessment(UpdateAssessmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessment.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessment">REST API Reference for UpdateAssessment Operation</seealso>
        public virtual UpdateAssessmentResponse EndUpdateAssessment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentControl

        /// <summary>
        /// Updates a control within an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        public virtual UpdateAssessmentControlResponse UpdateAssessmentControl(UpdateAssessmentControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentControl(UpdateAssessmentControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentControl.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControl">REST API Reference for UpdateAssessmentControl Operation</seealso>
        public virtual UpdateAssessmentControlResponse EndUpdateAssessmentControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentControlResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentControlSetStatus

        /// <summary>
        /// Updates the status of a control set in an Audit Manager assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentControlSetStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        public virtual UpdateAssessmentControlSetStatusResponse UpdateAssessmentControlSetStatus(UpdateAssessmentControlSetStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlSetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlSetStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentControlSetStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentControlSetStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentControlSetStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentControlSetStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentControlSetStatus(UpdateAssessmentControlSetStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentControlSetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentControlSetStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentControlSetStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentControlSetStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentControlSetStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentControlSetStatus">REST API Reference for UpdateAssessmentControlSetStatus Operation</seealso>
        public virtual UpdateAssessmentControlSetStatusResponse EndUpdateAssessmentControlSetStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentControlSetStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentFramework

        /// <summary>
        /// Updates a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentFramework service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        public virtual UpdateAssessmentFrameworkResponse UpdateAssessmentFramework(UpdateAssessmentFrameworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentFrameworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFramework operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentFramework
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentFramework(UpdateAssessmentFrameworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentFramework operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentFramework.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentFrameworkResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFramework">REST API Reference for UpdateAssessmentFramework Operation</seealso>
        public virtual UpdateAssessmentFrameworkResponse EndUpdateAssessmentFramework(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentFrameworkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentFrameworkShare

        /// <summary>
        /// Updates a share request for a custom framework in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFrameworkShare service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentFrameworkShare service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        public virtual UpdateAssessmentFrameworkShareResponse UpdateAssessmentFrameworkShare(UpdateAssessmentFrameworkShareRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentFrameworkShareResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentFrameworkShare operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentFrameworkShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentFrameworkShare(UpdateAssessmentFrameworkShareRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentFrameworkShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentFrameworkShareResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentFrameworkShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentFrameworkShare.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentFrameworkShareResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentFrameworkShare">REST API Reference for UpdateAssessmentFrameworkShare Operation</seealso>
        public virtual UpdateAssessmentFrameworkShareResponse EndUpdateAssessmentFrameworkShare(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentFrameworkShareResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssessmentStatus

        /// <summary>
        /// Updates the status of an assessment in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateAssessmentStatus service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ServiceQuotaExceededException">
        /// You've reached your account quota for this resource type. To perform the requested
        /// action, delete some existing resources or <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">request
        /// a quota increase</a> from the Service Quotas console. For a list of Audit Manager
        /// service quotas, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/service-quotas.html">Quotas
        /// and restrictions for Audit Manager</a>.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        public virtual UpdateAssessmentStatusResponse UpdateAssessmentStatus(UpdateAssessmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateAssessmentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssessmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssessmentStatus operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssessmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssessmentStatus(UpdateAssessmentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAssessmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssessmentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssessmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssessmentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateAssessmentStatusResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateAssessmentStatus">REST API Reference for UpdateAssessmentStatus Operation</seealso>
        public virtual UpdateAssessmentStatusResponse EndUpdateAssessmentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssessmentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateControl

        /// <summary>
        /// Updates a custom control in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl service method.</param>
        /// 
        /// <returns>The response from the UpdateControl service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        public virtual UpdateControlResponse UpdateControl(UpdateControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlResponseUnmarshaller.Instance;

            return Invoke<UpdateControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateControl operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateControl(UpdateControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateControl.</param>
        /// 
        /// <returns>Returns a  UpdateControlResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateControl">REST API Reference for UpdateControl Operation</seealso>
        public virtual UpdateControlResponse EndUpdateControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateControlResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSettings

        /// <summary>
        /// Updates Audit Manager settings for the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateSettings service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual UpdateSettingsResponse UpdateSettings(UpdateSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSettings operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateSettings(UpdateSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSettings.</param>
        /// 
        /// <returns>Returns a  UpdateSettingsResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/UpdateSettings">REST API Reference for UpdateSettings Operation</seealso>
        public virtual UpdateSettingsResponse EndUpdateSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateAssessmentReportIntegrity

        /// <summary>
        /// Validates the integrity of an assessment report in Audit Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity service method.</param>
        /// 
        /// <returns>The response from the ValidateAssessmentReportIntegrity service method, as returned by AuditManager.</returns>
        /// <exception cref="Amazon.AuditManager.Model.AccessDeniedException">
        /// Your account isn't registered with Audit Manager. Check the delegated administrator
        /// setup on the Audit Manager settings page, and try again.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ResourceNotFoundException">
        /// The resource that's specified in the request can't be found.
        /// </exception>
        /// <exception cref="Amazon.AuditManager.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        public virtual ValidateAssessmentReportIntegrityResponse ValidateAssessmentReportIntegrity(ValidateAssessmentReportIntegrityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateAssessmentReportIntegrityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAssessmentReportIntegrityResponseUnmarshaller.Instance;

            return Invoke<ValidateAssessmentReportIntegrityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateAssessmentReportIntegrity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateAssessmentReportIntegrity operation on AmazonAuditManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateAssessmentReportIntegrity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        public virtual IAsyncResult BeginValidateAssessmentReportIntegrity(ValidateAssessmentReportIntegrityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateAssessmentReportIntegrityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateAssessmentReportIntegrityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateAssessmentReportIntegrity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateAssessmentReportIntegrity.</param>
        /// 
        /// <returns>Returns a  ValidateAssessmentReportIntegrityResult from AuditManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/auditmanager-2017-07-25/ValidateAssessmentReportIntegrity">REST API Reference for ValidateAssessmentReportIntegrity Operation</seealso>
        public virtual ValidateAssessmentReportIntegrityResponse EndValidateAssessmentReportIntegrity(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateAssessmentReportIntegrityResponse>(asyncResult);
        }

        #endregion
        
    }
}
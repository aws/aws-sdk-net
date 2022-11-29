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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Omics.Model;
using Amazon.Omics.Model.Internal.MarshallTransformations;
using Amazon.Omics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Omics
{
    /// <summary>
    /// Implementation for accessing Omics
    ///
    /// This is the <i>Amazon Omics API Reference</i>. For an introduction to the service,
    /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/">What is Amazon Omics?</a>
    /// in the <i>Amazon Omics Developer Guide</i>.
    /// </summary>
    public partial class AmazonOmicsClient : AmazonServiceClient, IAmazonOmics
    {
        private static IServiceMetadata serviceMetadata = new AmazonOmicsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IOmicsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOmicsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OmicsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonOmicsClient with the credentials loaded from the application's
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
        public AmazonOmicsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOmicsConfig()) { }

        /// <summary>
        /// Constructs AmazonOmicsClient with the credentials loaded from the application's
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
        public AmazonOmicsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOmicsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOmicsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOmicsClient Configuration Object</param>
        public AmazonOmicsClient(AmazonOmicsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOmicsClient(AWSCredentials credentials)
            : this(credentials, new AmazonOmicsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOmicsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOmicsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Credentials and an
        /// AmazonOmicsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOmicsClient Configuration Object</param>
        public AmazonOmicsClient(AWSCredentials credentials, AmazonOmicsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOmicsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOmicsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOmicsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOmicsClient Configuration Object</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOmicsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOmicsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOmicsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOmicsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOmicsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOmicsClient Configuration Object</param>
        public AmazonOmicsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOmicsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOmicsEndpointResolver());
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


        #region  BatchDeleteReadSet

        /// <summary>
        /// Deletes one or more read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteReadSet service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        public virtual BatchDeleteReadSetResponse BatchDeleteReadSet(BatchDeleteReadSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteReadSetResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteReadSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteReadSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteReadSet operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteReadSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteReadSet(BatchDeleteReadSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteReadSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteReadSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteReadSet.</param>
        /// 
        /// <returns>Returns a  BatchDeleteReadSetResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/BatchDeleteReadSet">REST API Reference for BatchDeleteReadSet Operation</seealso>
        public virtual BatchDeleteReadSetResponse EndBatchDeleteReadSet(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteReadSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelAnnotationImportJob

        /// <summary>
        /// Cancels an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        public virtual CancelAnnotationImportJobResponse CancelAnnotationImportJob(CancelAnnotationImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<CancelAnnotationImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        public virtual IAsyncResult BeginCancelAnnotationImportJob(CancelAnnotationImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAnnotationImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  CancelAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelAnnotationImportJob">REST API Reference for CancelAnnotationImportJob Operation</seealso>
        public virtual CancelAnnotationImportJobResponse EndCancelAnnotationImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelAnnotationImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelRun

        /// <summary>
        /// Cancels a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRun service method.</param>
        /// 
        /// <returns>The response from the CancelRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        public virtual CancelRunResponse CancelRun(CancelRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRunResponseUnmarshaller.Instance;

            return Invoke<CancelRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        public virtual IAsyncResult BeginCancelRun(CancelRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelRun.</param>
        /// 
        /// <returns>Returns a  CancelRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelRun">REST API Reference for CancelRun Operation</seealso>
        public virtual CancelRunResponse EndCancelRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelVariantImportJob

        /// <summary>
        /// Cancels a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        public virtual CancelVariantImportJobResponse CancelVariantImportJob(CancelVariantImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<CancelVariantImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        public virtual IAsyncResult BeginCancelVariantImportJob(CancelVariantImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelVariantImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelVariantImportJob.</param>
        /// 
        /// <returns>Returns a  CancelVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CancelVariantImportJob">REST API Reference for CancelVariantImportJob Operation</seealso>
        public virtual CancelVariantImportJobResponse EndCancelVariantImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelVariantImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAnnotationStore

        /// <summary>
        /// Creates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the CreateAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        public virtual CreateAnnotationStoreResponse CreateAnnotationStore(CreateAnnotationStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<CreateAnnotationStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        public virtual IAsyncResult BeginCreateAnnotationStore(CreateAnnotationStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnnotationStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnnotationStore.</param>
        /// 
        /// <returns>Returns a  CreateAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateAnnotationStore">REST API Reference for CreateAnnotationStore Operation</seealso>
        public virtual CreateAnnotationStoreResponse EndCreateAnnotationStore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAnnotationStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReferenceStore

        /// <summary>
        /// Creates a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore service method.</param>
        /// 
        /// <returns>The response from the CreateReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        public virtual CreateReferenceStoreResponse CreateReferenceStore(CreateReferenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<CreateReferenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        public virtual IAsyncResult BeginCreateReferenceStore(CreateReferenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReferenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReferenceStore.</param>
        /// 
        /// <returns>Returns a  CreateReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateReferenceStore">REST API Reference for CreateReferenceStore Operation</seealso>
        public virtual CreateReferenceStoreResponse EndCreateReferenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReferenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRunGroup

        /// <summary>
        /// Creates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        public virtual CreateRunGroupResponse CreateRunGroup(CreateRunGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRunGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateRunGroup(CreateRunGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRunGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRunGroup.</param>
        /// 
        /// <returns>Returns a  CreateRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateRunGroup">REST API Reference for CreateRunGroup Operation</seealso>
        public virtual CreateRunGroupResponse EndCreateRunGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRunGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSequenceStore

        /// <summary>
        /// Creates a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore service method.</param>
        /// 
        /// <returns>The response from the CreateSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        public virtual CreateSequenceStoreResponse CreateSequenceStore(CreateSequenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<CreateSequenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        public virtual IAsyncResult BeginCreateSequenceStore(CreateSequenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSequenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSequenceStore.</param>
        /// 
        /// <returns>Returns a  CreateSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateSequenceStore">REST API Reference for CreateSequenceStore Operation</seealso>
        public virtual CreateSequenceStoreResponse EndCreateSequenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSequenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVariantStore

        /// <summary>
        /// Creates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore service method.</param>
        /// 
        /// <returns>The response from the CreateVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        public virtual CreateVariantStoreResponse CreateVariantStore(CreateVariantStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariantStoreResponseUnmarshaller.Instance;

            return Invoke<CreateVariantStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        public virtual IAsyncResult BeginCreateVariantStore(CreateVariantStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariantStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVariantStore.</param>
        /// 
        /// <returns>Returns a  CreateVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateVariantStore">REST API Reference for CreateVariantStore Operation</seealso>
        public virtual CreateVariantStoreResponse EndCreateVariantStore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVariantStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkflow

        /// <summary>
        /// Creates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return Invoke<CreateWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        public virtual CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAnnotationStore

        /// <summary>
        /// Deletes an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the DeleteAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        public virtual DeleteAnnotationStoreResponse DeleteAnnotationStore(DeleteAnnotationStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteAnnotationStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        public virtual IAsyncResult BeginDeleteAnnotationStore(DeleteAnnotationStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnnotationStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnnotationStore.</param>
        /// 
        /// <returns>Returns a  DeleteAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteAnnotationStore">REST API Reference for DeleteAnnotationStore Operation</seealso>
        public virtual DeleteAnnotationStoreResponse EndDeleteAnnotationStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAnnotationStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReference

        /// <summary>
        /// Deletes a genome reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference service method.</param>
        /// 
        /// <returns>The response from the DeleteReference service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        public virtual DeleteReferenceResponse DeleteReference(DeleteReferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceResponseUnmarshaller.Instance;

            return Invoke<DeleteReferenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReference operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        public virtual IAsyncResult BeginDeleteReference(DeleteReferenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReference.</param>
        /// 
        /// <returns>Returns a  DeleteReferenceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReference">REST API Reference for DeleteReference Operation</seealso>
        public virtual DeleteReferenceResponse EndDeleteReference(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReferenceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteReferenceStore

        /// <summary>
        /// Deletes a genome reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore service method.</param>
        /// 
        /// <returns>The response from the DeleteReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        public virtual DeleteReferenceStoreResponse DeleteReferenceStore(DeleteReferenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteReferenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        public virtual IAsyncResult BeginDeleteReferenceStore(DeleteReferenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReferenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReferenceStore.</param>
        /// 
        /// <returns>Returns a  DeleteReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteReferenceStore">REST API Reference for DeleteReferenceStore Operation</seealso>
        public virtual DeleteReferenceStoreResponse EndDeleteReferenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteReferenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRun

        /// <summary>
        /// Deletes a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun service method.</param>
        /// 
        /// <returns>The response from the DeleteRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual DeleteRunResponse DeleteRun(DeleteRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return Invoke<DeleteRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual IAsyncResult BeginDeleteRun(DeleteRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRun.</param>
        /// 
        /// <returns>Returns a  DeleteRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRun">REST API Reference for DeleteRun Operation</seealso>
        public virtual DeleteRunResponse EndDeleteRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRunGroup

        /// <summary>
        /// Deletes a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        public virtual DeleteRunGroupResponse DeleteRunGroup(DeleteRunGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRunGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteRunGroup(DeleteRunGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRunGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRunGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteRunGroup">REST API Reference for DeleteRunGroup Operation</seealso>
        public virtual DeleteRunGroupResponse EndDeleteRunGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRunGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSequenceStore

        /// <summary>
        /// Deletes a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore service method.</param>
        /// 
        /// <returns>The response from the DeleteSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        public virtual DeleteSequenceStoreResponse DeleteSequenceStore(DeleteSequenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteSequenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        public virtual IAsyncResult BeginDeleteSequenceStore(DeleteSequenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSequenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSequenceStore.</param>
        /// 
        /// <returns>Returns a  DeleteSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteSequenceStore">REST API Reference for DeleteSequenceStore Operation</seealso>
        public virtual DeleteSequenceStoreResponse EndDeleteSequenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSequenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVariantStore

        /// <summary>
        /// Deletes a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore service method.</param>
        /// 
        /// <returns>The response from the DeleteVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        public virtual DeleteVariantStoreResponse DeleteVariantStore(DeleteVariantStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariantStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteVariantStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        public virtual IAsyncResult BeginDeleteVariantStore(DeleteVariantStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariantStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVariantStore.</param>
        /// 
        /// <returns>Returns a  DeleteVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteVariantStore">REST API Reference for DeleteVariantStore Operation</seealso>
        public virtual DeleteVariantStoreResponse EndDeleteVariantStore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVariantStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkflow

        /// <summary>
        /// Deletes a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        public virtual DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAnnotationImportJob

        /// <summary>
        /// Gets information about an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the GetAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        public virtual GetAnnotationImportJobResponse GetAnnotationImportJob(GetAnnotationImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<GetAnnotationImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetAnnotationImportJob(GetAnnotationImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  GetAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationImportJob">REST API Reference for GetAnnotationImportJob Operation</seealso>
        public virtual GetAnnotationImportJobResponse EndGetAnnotationImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAnnotationImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAnnotationStore

        /// <summary>
        /// Gets information about an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the GetAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        public virtual GetAnnotationStoreResponse GetAnnotationStore(GetAnnotationStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<GetAnnotationStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        public virtual IAsyncResult BeginGetAnnotationStore(GetAnnotationStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnnotationStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnnotationStore.</param>
        /// 
        /// <returns>Returns a  GetAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetAnnotationStore">REST API Reference for GetAnnotationStore Operation</seealso>
        public virtual GetAnnotationStoreResponse EndGetAnnotationStore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAnnotationStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadSet

        /// <summary>
        /// Gets a file from a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet service method.</param>
        /// 
        /// <returns>The response from the GetReadSet service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RangeNotSatisfiableException">
        /// The ranges specified in the request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        public virtual GetReadSetResponse GetReadSet(GetReadSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetResponseUnmarshaller.Instance;

            return Invoke<GetReadSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSet operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        public virtual IAsyncResult BeginGetReadSet(GetReadSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSet.</param>
        /// 
        /// <returns>Returns a  GetReadSetResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSet">REST API Reference for GetReadSet Operation</seealso>
        public virtual GetReadSetResponse EndGetReadSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadSetActivationJob

        /// <summary>
        /// Gets information about a read set activation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetActivationJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        public virtual GetReadSetActivationJobResponse GetReadSetActivationJob(GetReadSetActivationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetActivationJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetActivationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetActivationJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetActivationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        public virtual IAsyncResult BeginGetReadSetActivationJob(GetReadSetActivationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetActivationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetActivationJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetActivationJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetActivationJob">REST API Reference for GetReadSetActivationJob Operation</seealso>
        public virtual GetReadSetActivationJobResponse EndGetReadSetActivationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadSetActivationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadSetExportJob

        /// <summary>
        /// Gets information about a read set export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetExportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        public virtual GetReadSetExportJobResponse GetReadSetExportJob(GetReadSetExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetExportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        public virtual IAsyncResult BeginGetReadSetExportJob(GetReadSetExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetExportJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetExportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetExportJob">REST API Reference for GetReadSetExportJob Operation</seealso>
        public virtual GetReadSetExportJobResponse EndGetReadSetExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadSetExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadSetImportJob

        /// <summary>
        /// Gets information about a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetReadSetImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        public virtual GetReadSetImportJobResponse GetReadSetImportJob(GetReadSetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetReadSetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetReadSetImportJob(GetReadSetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetImportJob.</param>
        /// 
        /// <returns>Returns a  GetReadSetImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetImportJob">REST API Reference for GetReadSetImportJob Operation</seealso>
        public virtual GetReadSetImportJobResponse EndGetReadSetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadSetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReadSetMetadata

        /// <summary>
        /// Gets details about a read set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata service method.</param>
        /// 
        /// <returns>The response from the GetReadSetMetadata service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        public virtual GetReadSetMetadataResponse GetReadSetMetadata(GetReadSetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetMetadataResponseUnmarshaller.Instance;

            return Invoke<GetReadSetMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadSetMetadata operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadSetMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetReadSetMetadata(GetReadSetMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReadSetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReadSetMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadSetMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadSetMetadata.</param>
        /// 
        /// <returns>Returns a  GetReadSetMetadataResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReadSetMetadata">REST API Reference for GetReadSetMetadata Operation</seealso>
        public virtual GetReadSetMetadataResponse EndGetReadSetMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReadSetMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReference

        /// <summary>
        /// Gets a reference file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReference service method.</param>
        /// 
        /// <returns>The response from the GetReference service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RangeNotSatisfiableException">
        /// The ranges specified in the request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        public virtual GetReferenceResponse GetReference(GetReferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceResponseUnmarshaller.Instance;

            return Invoke<GetReferenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReference operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReference
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        public virtual IAsyncResult BeginGetReference(GetReferenceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReference operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReference.</param>
        /// 
        /// <returns>Returns a  GetReferenceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReference">REST API Reference for GetReference Operation</seealso>
        public virtual GetReferenceResponse EndGetReference(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReferenceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReferenceImportJob

        /// <summary>
        /// Gets information about a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob service method.</param>
        /// 
        /// <returns>The response from the GetReferenceImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        public virtual GetReferenceImportJobResponse GetReferenceImportJob(GetReferenceImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceImportJobResponseUnmarshaller.Instance;

            return Invoke<GetReferenceImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetReferenceImportJob(GetReferenceImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceImportJob.</param>
        /// 
        /// <returns>Returns a  GetReferenceImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceImportJob">REST API Reference for GetReferenceImportJob Operation</seealso>
        public virtual GetReferenceImportJobResponse EndGetReferenceImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReferenceImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReferenceMetadata

        /// <summary>
        /// Gets information about a genome reference's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata service method.</param>
        /// 
        /// <returns>The response from the GetReferenceMetadata service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        public virtual GetReferenceMetadataResponse GetReferenceMetadata(GetReferenceMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceMetadataResponseUnmarshaller.Instance;

            return Invoke<GetReferenceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceMetadata operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        public virtual IAsyncResult BeginGetReferenceMetadata(GetReferenceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceMetadata.</param>
        /// 
        /// <returns>Returns a  GetReferenceMetadataResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceMetadata">REST API Reference for GetReferenceMetadata Operation</seealso>
        public virtual GetReferenceMetadataResponse EndGetReferenceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReferenceMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReferenceStore

        /// <summary>
        /// Gets information about a reference store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore service method.</param>
        /// 
        /// <returns>The response from the GetReferenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        public virtual GetReferenceStoreResponse GetReferenceStore(GetReferenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceStoreResponseUnmarshaller.Instance;

            return Invoke<GetReferenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReferenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReferenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        public virtual IAsyncResult BeginGetReferenceStore(GetReferenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReferenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReferenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReferenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReferenceStore.</param>
        /// 
        /// <returns>Returns a  GetReferenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetReferenceStore">REST API Reference for GetReferenceStore Operation</seealso>
        public virtual GetReferenceStoreResponse EndGetReferenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReferenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRun

        /// <summary>
        /// Gets information about a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRun service method.</param>
        /// 
        /// <returns>The response from the GetRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual GetRunResponse GetRun(GetRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return Invoke<GetRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual IAsyncResult BeginGetRun(GetRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRun.</param>
        /// 
        /// <returns>Returns a  GetRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRun">REST API Reference for GetRun Operation</seealso>
        public virtual GetRunResponse EndGetRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRunGroup

        /// <summary>
        /// Gets information about a workflow run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup service method.</param>
        /// 
        /// <returns>The response from the GetRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        public virtual GetRunGroupResponse GetRunGroup(GetRunGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunGroupResponseUnmarshaller.Instance;

            return Invoke<GetRunGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        public virtual IAsyncResult BeginGetRunGroup(GetRunGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRunGroup.</param>
        /// 
        /// <returns>Returns a  GetRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunGroup">REST API Reference for GetRunGroup Operation</seealso>
        public virtual GetRunGroupResponse EndGetRunGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRunGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRunTask

        /// <summary>
        /// Gets information about a workflow run task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask service method.</param>
        /// 
        /// <returns>The response from the GetRunTask service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        public virtual GetRunTaskResponse GetRunTask(GetRunTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunTaskResponseUnmarshaller.Instance;

            return Invoke<GetRunTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRunTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRunTask operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRunTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        public virtual IAsyncResult BeginGetRunTask(GetRunTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRunTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRunTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRunTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRunTask.</param>
        /// 
        /// <returns>Returns a  GetRunTaskResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetRunTask">REST API Reference for GetRunTask Operation</seealso>
        public virtual GetRunTaskResponse EndGetRunTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRunTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSequenceStore

        /// <summary>
        /// Gets information about a sequence store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore service method.</param>
        /// 
        /// <returns>The response from the GetSequenceStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        public virtual GetSequenceStoreResponse GetSequenceStore(GetSequenceStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSequenceStoreResponseUnmarshaller.Instance;

            return Invoke<GetSequenceStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSequenceStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSequenceStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        public virtual IAsyncResult BeginGetSequenceStore(GetSequenceStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSequenceStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSequenceStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSequenceStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSequenceStore.</param>
        /// 
        /// <returns>Returns a  GetSequenceStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetSequenceStore">REST API Reference for GetSequenceStore Operation</seealso>
        public virtual GetSequenceStoreResponse EndGetSequenceStore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSequenceStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVariantImportJob

        /// <summary>
        /// Gets information about a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the GetVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        public virtual GetVariantImportJobResponse GetVariantImportJob(GetVariantImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<GetVariantImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetVariantImportJob(GetVariantImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariantImportJob.</param>
        /// 
        /// <returns>Returns a  GetVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantImportJob">REST API Reference for GetVariantImportJob Operation</seealso>
        public virtual GetVariantImportJobResponse EndGetVariantImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVariantImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVariantStore

        /// <summary>
        /// Gets information about a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore service method.</param>
        /// 
        /// <returns>The response from the GetVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        public virtual GetVariantStoreResponse GetVariantStore(GetVariantStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantStoreResponseUnmarshaller.Instance;

            return Invoke<GetVariantStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        public virtual IAsyncResult BeginGetVariantStore(GetVariantStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariantStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariantStore.</param>
        /// 
        /// <returns>Returns a  GetVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetVariantStore">REST API Reference for GetVariantStore Operation</seealso>
        public virtual GetVariantStoreResponse EndGetVariantStore(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVariantStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkflow

        /// <summary>
        /// Gets information about a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse GetWorkflow(GetWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        public virtual GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnnotationImportJobs

        /// <summary>
        /// Retrieves a list of annotation import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAnnotationImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        public virtual ListAnnotationImportJobsResponse ListAnnotationImportJobs(ListAnnotationImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnnotationImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAnnotationImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnnotationImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnnotationImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListAnnotationImportJobs(ListAnnotationImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnnotationImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnnotationImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnnotationImportJobs.</param>
        /// 
        /// <returns>Returns a  ListAnnotationImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationImportJobs">REST API Reference for ListAnnotationImportJobs Operation</seealso>
        public virtual ListAnnotationImportJobsResponse EndListAnnotationImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnnotationImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnnotationStores

        /// <summary>
        /// Retrieves a list of annotation stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores service method.</param>
        /// 
        /// <returns>The response from the ListAnnotationStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        public virtual ListAnnotationStoresResponse ListAnnotationStores(ListAnnotationStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoresResponseUnmarshaller.Instance;

            return Invoke<ListAnnotationStoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnnotationStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnnotationStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnnotationStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        public virtual IAsyncResult BeginListAnnotationStores(ListAnnotationStoresRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnnotationStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnnotationStoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnnotationStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnnotationStores.</param>
        /// 
        /// <returns>Returns a  ListAnnotationStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListAnnotationStores">REST API Reference for ListAnnotationStores Operation</seealso>
        public virtual ListAnnotationStoresResponse EndListAnnotationStores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnnotationStoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReadSetActivationJobs

        /// <summary>
        /// Retrieves a list of read set activation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetActivationJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        public virtual ListReadSetActivationJobsResponse ListReadSetActivationJobs(ListReadSetActivationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetActivationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetActivationJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetActivationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetActivationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetActivationJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetActivationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        public virtual IAsyncResult BeginListReadSetActivationJobs(ListReadSetActivationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetActivationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetActivationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetActivationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetActivationJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetActivationJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetActivationJobs">REST API Reference for ListReadSetActivationJobs Operation</seealso>
        public virtual ListReadSetActivationJobsResponse EndListReadSetActivationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReadSetActivationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReadSetExportJobs

        /// <summary>
        /// Retrieves a list of read set export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetExportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        public virtual ListReadSetExportJobsResponse ListReadSetExportJobs(ListReadSetExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetExportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        public virtual IAsyncResult BeginListReadSetExportJobs(ListReadSetExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetExportJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetExportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetExportJobs">REST API Reference for ListReadSetExportJobs Operation</seealso>
        public virtual ListReadSetExportJobsResponse EndListReadSetExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReadSetExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReadSetImportJobs

        /// <summary>
        /// Retrieves a list of read set import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReadSetImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        public virtual ListReadSetImportJobsResponse ListReadSetImportJobs(ListReadSetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSetImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListReadSetImportJobs(ListReadSetImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListReadSetImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSetImportJobs">REST API Reference for ListReadSetImportJobs Operation</seealso>
        public virtual ListReadSetImportJobsResponse EndListReadSetImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReadSetImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReadSets

        /// <summary>
        /// Retrieves a list of read sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets service method.</param>
        /// 
        /// <returns>The response from the ListReadSets service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        public virtual ListReadSetsResponse ListReadSets(ListReadSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetsResponseUnmarshaller.Instance;

            return Invoke<ListReadSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadSets operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        public virtual IAsyncResult BeginListReadSets(ListReadSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReadSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReadSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadSets.</param>
        /// 
        /// <returns>Returns a  ListReadSetsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReadSets">REST API Reference for ListReadSets Operation</seealso>
        public virtual ListReadSetsResponse EndListReadSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReadSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReferenceImportJobs

        /// <summary>
        /// Retrieves a list of reference import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListReferenceImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        public virtual ListReferenceImportJobsResponse ListReferenceImportJobs(ListReferenceImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferenceImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListReferenceImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferenceImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferenceImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListReferenceImportJobs(ListReferenceImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferenceImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferenceImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferenceImportJobs.</param>
        /// 
        /// <returns>Returns a  ListReferenceImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceImportJobs">REST API Reference for ListReferenceImportJobs Operation</seealso>
        public virtual ListReferenceImportJobsResponse EndListReferenceImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReferenceImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReferences

        /// <summary>
        /// Retrieves a list of references.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferences service method.</param>
        /// 
        /// <returns>The response from the ListReferences service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        public virtual ListReferencesResponse ListReferences(ListReferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferencesResponseUnmarshaller.Instance;

            return Invoke<ListReferencesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferences operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        public virtual IAsyncResult BeginListReferences(ListReferencesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferencesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferences.</param>
        /// 
        /// <returns>Returns a  ListReferencesResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferences">REST API Reference for ListReferences Operation</seealso>
        public virtual ListReferencesResponse EndListReferences(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListReferenceStores

        /// <summary>
        /// Retrieves a list of reference stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores service method.</param>
        /// 
        /// <returns>The response from the ListReferenceStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        public virtual ListReferenceStoresResponse ListReferenceStores(ListReferenceStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceStoresResponseUnmarshaller.Instance;

            return Invoke<ListReferenceStoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListReferenceStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReferenceStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReferenceStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        public virtual IAsyncResult BeginListReferenceStores(ListReferenceStoresRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReferenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReferenceStoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListReferenceStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReferenceStores.</param>
        /// 
        /// <returns>Returns a  ListReferenceStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListReferenceStores">REST API Reference for ListReferenceStores Operation</seealso>
        public virtual ListReferenceStoresResponse EndListReferenceStores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListReferenceStoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRunGroups

        /// <summary>
        /// Retrieves a list of run groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups service method.</param>
        /// 
        /// <returns>The response from the ListRunGroups service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        public virtual ListRunGroupsResponse ListRunGroups(ListRunGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRunGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRunGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRunGroups operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRunGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        public virtual IAsyncResult BeginListRunGroups(ListRunGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRunGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRunGroups.</param>
        /// 
        /// <returns>Returns a  ListRunGroupsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunGroups">REST API Reference for ListRunGroups Operation</seealso>
        public virtual ListRunGroupsResponse EndListRunGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuns

        /// <summary>
        /// Retrieves a list of runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuns service method.</param>
        /// 
        /// <returns>The response from the ListRuns service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual ListRunsResponse ListRuns(ListRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return Invoke<ListRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuns operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual IAsyncResult BeginListRuns(ListRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuns.</param>
        /// 
        /// <returns>Returns a  ListRunsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRuns">REST API Reference for ListRuns Operation</seealso>
        public virtual ListRunsResponse EndListRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRunTasks

        /// <summary>
        /// Retrieves a list of tasks for a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks service method.</param>
        /// 
        /// <returns>The response from the ListRunTasks service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        public virtual ListRunTasksResponse ListRunTasks(ListRunTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunTasksResponseUnmarshaller.Instance;

            return Invoke<ListRunTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRunTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRunTasks operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRunTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        public virtual IAsyncResult BeginListRunTasks(ListRunTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRunTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRunTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRunTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRunTasks.</param>
        /// 
        /// <returns>Returns a  ListRunTasksResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListRunTasks">REST API Reference for ListRunTasks Operation</seealso>
        public virtual ListRunTasksResponse EndListRunTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRunTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSequenceStores

        /// <summary>
        /// Retrieves a list of sequence stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores service method.</param>
        /// 
        /// <returns>The response from the ListSequenceStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        public virtual ListSequenceStoresResponse ListSequenceStores(ListSequenceStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSequenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSequenceStoresResponseUnmarshaller.Instance;

            return Invoke<ListSequenceStoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSequenceStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSequenceStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSequenceStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        public virtual IAsyncResult BeginListSequenceStores(ListSequenceStoresRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSequenceStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSequenceStoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSequenceStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSequenceStores.</param>
        /// 
        /// <returns>Returns a  ListSequenceStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListSequenceStores">REST API Reference for ListSequenceStores Operation</seealso>
        public virtual ListSequenceStoresResponse EndListSequenceStores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSequenceStoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVariantImportJobs

        /// <summary>
        /// Retrieves a list of variant import jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListVariantImportJobs service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        public virtual ListVariantImportJobsResponse ListVariantImportJobs(ListVariantImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVariantImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListVariantImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVariantImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVariantImportJobs operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVariantImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListVariantImportJobs(ListVariantImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVariantImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVariantImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVariantImportJobs.</param>
        /// 
        /// <returns>Returns a  ListVariantImportJobsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantImportJobs">REST API Reference for ListVariantImportJobs Operation</seealso>
        public virtual ListVariantImportJobsResponse EndListVariantImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVariantImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVariantStores

        /// <summary>
        /// Retrieves a list of variant stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores service method.</param>
        /// 
        /// <returns>The response from the ListVariantStores service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        public virtual ListVariantStoresResponse ListVariantStores(ListVariantStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVariantStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantStoresResponseUnmarshaller.Instance;

            return Invoke<ListVariantStoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVariantStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVariantStores operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVariantStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        public virtual IAsyncResult BeginListVariantStores(ListVariantStoresRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVariantStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVariantStoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVariantStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVariantStores.</param>
        /// 
        /// <returns>Returns a  ListVariantStoresResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListVariantStores">REST API Reference for ListVariantStores Operation</seealso>
        public virtual ListVariantStoresResponse EndListVariantStores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVariantStoresResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkflows

        /// <summary>
        /// Retrieves a list of workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        public virtual ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAnnotationImportJob

        /// <summary>
        /// Starts an annotation import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob service method.</param>
        /// 
        /// <returns>The response from the StartAnnotationImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        public virtual StartAnnotationImportJobResponse StartAnnotationImportJob(StartAnnotationImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnnotationImportJobResponseUnmarshaller.Instance;

            return Invoke<StartAnnotationImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAnnotationImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAnnotationImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartAnnotationImportJob(StartAnnotationImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAnnotationImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnnotationImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAnnotationImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAnnotationImportJob.</param>
        /// 
        /// <returns>Returns a  StartAnnotationImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartAnnotationImportJob">REST API Reference for StartAnnotationImportJob Operation</seealso>
        public virtual StartAnnotationImportJobResponse EndStartAnnotationImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAnnotationImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReadSetActivationJob

        /// <summary>
        /// Starts a read set activation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetActivationJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        public virtual StartReadSetActivationJobResponse StartReadSetActivationJob(StartReadSetActivationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetActivationJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetActivationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetActivationJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetActivationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        public virtual IAsyncResult BeginStartReadSetActivationJob(StartReadSetActivationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetActivationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetActivationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetActivationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetActivationJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetActivationJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetActivationJob">REST API Reference for StartReadSetActivationJob Operation</seealso>
        public virtual StartReadSetActivationJobResponse EndStartReadSetActivationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReadSetActivationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReadSetExportJob

        /// <summary>
        /// Starts a read set export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetExportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        public virtual StartReadSetExportJobResponse StartReadSetExportJob(StartReadSetExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetExportJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetExportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        public virtual IAsyncResult BeginStartReadSetExportJob(StartReadSetExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetExportJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetExportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetExportJob">REST API Reference for StartReadSetExportJob Operation</seealso>
        public virtual StartReadSetExportJobResponse EndStartReadSetExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReadSetExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReadSetImportJob

        /// <summary>
        /// Starts a read set import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob service method.</param>
        /// 
        /// <returns>The response from the StartReadSetImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        public virtual StartReadSetImportJobResponse StartReadSetImportJob(StartReadSetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetImportJobResponseUnmarshaller.Instance;

            return Invoke<StartReadSetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReadSetImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReadSetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartReadSetImportJob(StartReadSetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReadSetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReadSetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReadSetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReadSetImportJob.</param>
        /// 
        /// <returns>Returns a  StartReadSetImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReadSetImportJob">REST API Reference for StartReadSetImportJob Operation</seealso>
        public virtual StartReadSetImportJobResponse EndStartReadSetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReadSetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartReferenceImportJob

        /// <summary>
        /// Starts a reference import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob service method.</param>
        /// 
        /// <returns>The response from the StartReferenceImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        public virtual StartReferenceImportJobResponse StartReferenceImportJob(StartReferenceImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReferenceImportJobResponseUnmarshaller.Instance;

            return Invoke<StartReferenceImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReferenceImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReferenceImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartReferenceImportJob(StartReferenceImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReferenceImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReferenceImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartReferenceImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReferenceImportJob.</param>
        /// 
        /// <returns>Returns a  StartReferenceImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartReferenceImportJob">REST API Reference for StartReferenceImportJob Operation</seealso>
        public virtual StartReferenceImportJobResponse EndStartReferenceImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartReferenceImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRun

        /// <summary>
        /// Starts a run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRun service method.</param>
        /// 
        /// <returns>The response from the StartRun service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        public virtual StartRunResponse StartRun(StartRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRunResponseUnmarshaller.Instance;

            return Invoke<StartRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRun operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        public virtual IAsyncResult BeginStartRun(StartRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRun.</param>
        /// 
        /// <returns>Returns a  StartRunResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartRun">REST API Reference for StartRun Operation</seealso>
        public virtual StartRunResponse EndStartRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartVariantImportJob

        /// <summary>
        /// Starts a variant import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob service method.</param>
        /// 
        /// <returns>The response from the StartVariantImportJob service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        public virtual StartVariantImportJobResponse StartVariantImportJob(StartVariantImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVariantImportJobResponseUnmarshaller.Instance;

            return Invoke<StartVariantImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartVariantImportJob operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartVariantImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartVariantImportJob(StartVariantImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVariantImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVariantImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartVariantImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartVariantImportJob.</param>
        /// 
        /// <returns>Returns a  StartVariantImportJobResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/StartVariantImportJob">REST API Reference for StartVariantImportJob Operation</seealso>
        public virtual StartVariantImportJobResponse EndStartVariantImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartVariantImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAnnotationStore

        /// <summary>
        /// Updates an annotation store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore service method.</param>
        /// 
        /// <returns>The response from the UpdateAnnotationStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        public virtual UpdateAnnotationStoreResponse UpdateAnnotationStore(UpdateAnnotationStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateAnnotationStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnnotationStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnnotationStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        public virtual IAsyncResult BeginUpdateAnnotationStore(UpdateAnnotationStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnnotationStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnnotationStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnnotationStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnnotationStore.</param>
        /// 
        /// <returns>Returns a  UpdateAnnotationStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateAnnotationStore">REST API Reference for UpdateAnnotationStore Operation</seealso>
        public virtual UpdateAnnotationStoreResponse EndUpdateAnnotationStore(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAnnotationStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRunGroup

        /// <summary>
        /// Updates a run group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRunGroup service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        public virtual UpdateRunGroupResponse UpdateRunGroup(UpdateRunGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRunGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRunGroup operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRunGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateRunGroup(UpdateRunGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRunGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRunGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRunGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRunGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRunGroupResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateRunGroup">REST API Reference for UpdateRunGroup Operation</seealso>
        public virtual UpdateRunGroupResponse EndUpdateRunGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRunGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVariantStore

        /// <summary>
        /// Updates a variant store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore service method.</param>
        /// 
        /// <returns>The response from the UpdateVariantStore service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        public virtual UpdateVariantStoreResponse UpdateVariantStore(UpdateVariantStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariantStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateVariantStoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariantStore operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVariantStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        public virtual IAsyncResult BeginUpdateVariantStore(UpdateVariantStoreRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariantStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariantStoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVariantStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVariantStore.</param>
        /// 
        /// <returns>Returns a  UpdateVariantStoreResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateVariantStore">REST API Reference for UpdateVariantStore Operation</seealso>
        public virtual UpdateVariantStoreResponse EndUpdateVariantStore(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVariantStoreResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkflow

        /// <summary>
        /// Updates a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by Omics.</returns>
        /// <exception cref="Amazon.Omics.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ConflictException">
        /// The request cannot be applied to the target resource in its current state.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.InternalServerException">
        /// An unexpected error occurred. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ResourceNotFoundException">
        /// The target resource was not found in the current Region.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Omics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow operation on AmazonOmicsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkflow(UpdateWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowResult from Omics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/omics-2022-11-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        public virtual UpdateWorkflowResponse EndUpdateWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkflowResponse>(asyncResult);
        }

        #endregion
        
    }
}